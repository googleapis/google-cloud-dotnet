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
    public sealed class GeneratedServiceAttachmentsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceAttachmentRequest request = new GetServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                ServiceAttachment = "service_attachment592c837a",
            };
            ServiceAttachment expectedResponse = new ServiceAttachment
            {
                Id = 11672635353343658936UL,
                TargetService = "target_service3f6f9a5a",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                ConnectedEndpoints =
                {
                    new ServiceAttachmentConnectedEndpoint(),
                },
                Region = "regionedb20d96",
                ConsumerRejectLists =
                {
                    "consumer_reject_lists640993ba",
                },
                Fingerprint = "fingerprint009e6052",
                ProducerForwardingRule = "producer_forwarding_rule8732a25d",
                ConnectionPreference = "connection_preference328ae231",
                EnableProxyProtocol = true,
                NatSubnets =
                {
                    "nat_subnets59063249",
                },
                ConsumerAcceptLists =
                {
                    new ServiceAttachmentConsumerProjectLimit(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                PscServiceAttachmentId = new Uint128(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            ServiceAttachment response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceAttachmentRequest request = new GetServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                ServiceAttachment = "service_attachment592c837a",
            };
            ServiceAttachment expectedResponse = new ServiceAttachment
            {
                Id = 11672635353343658936UL,
                TargetService = "target_service3f6f9a5a",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                ConnectedEndpoints =
                {
                    new ServiceAttachmentConnectedEndpoint(),
                },
                Region = "regionedb20d96",
                ConsumerRejectLists =
                {
                    "consumer_reject_lists640993ba",
                },
                Fingerprint = "fingerprint009e6052",
                ProducerForwardingRule = "producer_forwarding_rule8732a25d",
                ConnectionPreference = "connection_preference328ae231",
                EnableProxyProtocol = true,
                NatSubnets =
                {
                    "nat_subnets59063249",
                },
                ConsumerAcceptLists =
                {
                    new ServiceAttachmentConsumerProjectLimit(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                PscServiceAttachmentId = new Uint128(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAttachment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            ServiceAttachment responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAttachment responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceAttachmentRequest request = new GetServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                ServiceAttachment = "service_attachment592c837a",
            };
            ServiceAttachment expectedResponse = new ServiceAttachment
            {
                Id = 11672635353343658936UL,
                TargetService = "target_service3f6f9a5a",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                ConnectedEndpoints =
                {
                    new ServiceAttachmentConnectedEndpoint(),
                },
                Region = "regionedb20d96",
                ConsumerRejectLists =
                {
                    "consumer_reject_lists640993ba",
                },
                Fingerprint = "fingerprint009e6052",
                ProducerForwardingRule = "producer_forwarding_rule8732a25d",
                ConnectionPreference = "connection_preference328ae231",
                EnableProxyProtocol = true,
                NatSubnets =
                {
                    "nat_subnets59063249",
                },
                ConsumerAcceptLists =
                {
                    new ServiceAttachmentConsumerProjectLimit(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                PscServiceAttachmentId = new Uint128(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            ServiceAttachment response = client.Get(request.Project, request.Region, request.ServiceAttachment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceAttachmentRequest request = new GetServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                ServiceAttachment = "service_attachment592c837a",
            };
            ServiceAttachment expectedResponse = new ServiceAttachment
            {
                Id = 11672635353343658936UL,
                TargetService = "target_service3f6f9a5a",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                DomainNames =
                {
                    "domain_names58aa2a78",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                ConnectedEndpoints =
                {
                    new ServiceAttachmentConnectedEndpoint(),
                },
                Region = "regionedb20d96",
                ConsumerRejectLists =
                {
                    "consumer_reject_lists640993ba",
                },
                Fingerprint = "fingerprint009e6052",
                ProducerForwardingRule = "producer_forwarding_rule8732a25d",
                ConnectionPreference = "connection_preference328ae231",
                EnableProxyProtocol = true,
                NatSubnets =
                {
                    "nat_subnets59063249",
                },
                ConsumerAcceptLists =
                {
                    new ServiceAttachmentConsumerProjectLimit(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                PscServiceAttachmentId = new Uint128(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAttachment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            ServiceAttachment responseCallSettings = await client.GetAsync(request.Project, request.Region, request.ServiceAttachment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAttachment responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.ServiceAttachment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyServiceAttachmentRequest request = new GetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyServiceAttachmentRequest request = new GetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                OptionsRequestedPolicyVersion = -1471234741,
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyServiceAttachmentRequest request = new GetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Region, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIamPolicyServiceAttachmentRequest request = new GetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Region, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyServiceAttachmentRequest request = new SetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyServiceAttachmentRequest request = new SetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyServiceAttachmentRequest request = new SetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SetIamPolicyServiceAttachmentRequest request = new SetIamPolicyServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            Policy expectedResponse = new Policy
            {
                Etag = "etage8ad7218",
                Rules = { new Rule(), },
                AuditConfigs = { new AuditConfig(), },
                Version = 271578922,
                Bindings = { new Binding(), },
                IamOwned = false,
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Region, request.Resource, request.RegionSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsServiceAttachmentRequest request = new TestIamPermissionsServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsServiceAttachmentRequest request = new TestIamPermissionsServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsServiceAttachmentRequest request = new TestIamPermissionsServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<ServiceAttachments.ServiceAttachmentsClient> mockGrpcClient = new moq::Mock<ServiceAttachments.ServiceAttachmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsServiceAttachmentRequest request = new TestIamPermissionsServiceAttachmentRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceAttachmentsClient client = new ServiceAttachmentsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
