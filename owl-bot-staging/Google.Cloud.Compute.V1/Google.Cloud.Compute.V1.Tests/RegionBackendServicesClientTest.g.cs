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
    public sealed class GeneratedRegionBackendServicesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                EdgeSecurityPolicy = "edge_security_policy85c5b8f4",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = "protocola08b7881",
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = "locality_lb_policyc8722098",
                Region = "regionedb20d96",
                ConnectionTrackingPolicy = new BackendServiceConnectionTrackingPolicy(),
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = "load_balancing_scheme21346104",
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                Subsetting = new Subsetting(),
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = "session_affinitye702dadf",
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                EdgeSecurityPolicy = "edge_security_policy85c5b8f4",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = "protocola08b7881",
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = "locality_lb_policyc8722098",
                Region = "regionedb20d96",
                ConnectionTrackingPolicy = new BackendServiceConnectionTrackingPolicy(),
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = "load_balancing_scheme21346104",
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                Subsetting = new Subsetting(),
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = "session_affinitye702dadf",
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendService responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                EdgeSecurityPolicy = "edge_security_policy85c5b8f4",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = "protocola08b7881",
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = "locality_lb_policyc8722098",
                Region = "regionedb20d96",
                ConnectionTrackingPolicy = new BackendServiceConnectionTrackingPolicy(),
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = "load_balancing_scheme21346104",
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                Subsetting = new Subsetting(),
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = "session_affinitye702dadf",
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService response = client.Get(request.Project, request.Region, request.BackendService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = 11672635353343658936UL,
                Iap = new BackendServiceIAP(),
                ConsistentHash = new ConsistentHashLoadBalancerSettings(),
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Port = -78310000,
                CustomRequestHeaders =
                {
                    "custom_request_headers3532c035",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                EdgeSecurityPolicy = "edge_security_policy85c5b8f4",
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = "protocola08b7881",
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = "locality_lb_policyc8722098",
                Region = "regionedb20d96",
                ConnectionTrackingPolicy = new BackendServiceConnectionTrackingPolicy(),
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = "load_balancing_scheme21346104",
                AffinityCookieTtlSec = -328985636,
                CustomResponseHeaders =
                {
                    "custom_response_headersda5d431e",
                },
                CircuitBreakers = new CircuitBreakers(),
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                Subsetting = new Subsetting(),
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = "session_affinitye702dadf",
                SecuritySettings = new SecuritySettings(),
                Backends = { new Backend(), },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendService responseCallSettings = await client.GetAsync(request.Project, request.Region, request.BackendService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendService responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.BackendService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealthRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthRegionBackendServiceRequest request = new GetHealthRegionBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth response = client.GetHealth(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthRegionBackendServiceRequest request = new GetHealthRegionBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceGroupHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth responseCallSettings = await client.GetHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceGroupHealth responseCancellationToken = await client.GetHealthAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealth()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthRegionBackendServiceRequest request = new GetHealthRegionBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth response = client.GetHealth(request.Project, request.Region, request.BackendService, request.ResourceGroupReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthRegionBackendServiceRequest request = new GetHealthRegionBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendServiceGroupHealth expectedResponse = new BackendServiceGroupHealth
            {
                Kind = "kindf7aa39d9",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceGroupHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceGroupHealth responseCallSettings = await client.GetHealthAsync(request.Project, request.Region, request.BackendService, request.ResourceGroupReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceGroupHealth responseCancellationToken = await client.GetHealthAsync(request.Project, request.Region, request.BackendService, request.ResourceGroupReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
