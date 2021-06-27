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
    public sealed class GeneratedRegionBackendServicesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionBackendServiceRequest request = new DeleteRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionBackendServiceRequest request = new DeleteRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionBackendServiceRequest request = new DeleteRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.BackendService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionBackendServiceRequest request = new DeleteRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.BackendService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.BackendService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = "id74b70bb8",
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
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
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
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
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
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = "id74b70bb8",
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
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
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
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
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
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = "id74b70bb8",
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
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
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
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
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
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
            };
            BackendService expectedResponse = new BackendService
            {
                Id = "id74b70bb8",
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
                PortName = "port_namebaaa4cd4",
                MaxStreamDuration = new Duration(),
                TimeoutSec = -1529270667,
                Protocol = BackendService.Types.Protocol.Udp,
                FailoverPolicy = new BackendServiceFailoverPolicy(),
                LocalityLbPolicy = BackendService.Types.LocalityLbPolicy.UndefinedLocalityLbPolicy,
                Region = "regionedb20d96",
                SecurityPolicy = "security_policy76596315",
                CdnPolicy = new BackendServiceCdnPolicy(),
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                EnableCDN = false,
                LogConfig = new BackendServiceLogConfig(),
                OutlierDetection = new OutlierDetection(),
                LoadBalancingScheme = BackendService.Types.LoadBalancingScheme.UndefinedLoadBalancingScheme,
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
                SelfLink = "self_link7e87f12d",
                ConnectionDraining = new ConnectionDraining(),
                SessionAffinity = BackendService.Types.SessionAffinity.GeneratedCookie,
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

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            InsertRegionBackendServiceRequest request = new InsertRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            InsertRegionBackendServiceRequest request = new InsertRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            InsertRegionBackendServiceRequest request = new InsertRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.BackendServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            InsertRegionBackendServiceRequest request = new InsertRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.BackendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.BackendServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            ListRegionBackendServicesRequest request = new ListRegionBackendServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            ListRegionBackendServicesRequest request = new ListRegionBackendServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            ListRegionBackendServicesRequest request = new ListRegionBackendServicesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            ListRegionBackendServicesRequest request = new ListRegionBackendServicesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            BackendServiceList expectedResponse = new BackendServiceList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new BackendService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BackendServiceList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            BackendServiceList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BackendServiceList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            PatchRegionBackendServiceRequest request = new PatchRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            PatchRegionBackendServiceRequest request = new PatchRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            PatchRegionBackendServiceRequest request = new PatchRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.BackendService, request.BackendServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            PatchRegionBackendServiceRequest request = new PatchRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.BackendService, request.BackendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.BackendService, request.BackendServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRequestObject()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            UpdateRegionBackendServiceRequest request = new UpdateRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRequestObjectAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            UpdateRegionBackendServiceRequest request = new UpdateRegionBackendServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Update()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            UpdateRegionBackendServiceRequest request = new UpdateRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request.Project, request.Region, request.BackendService, request.BackendServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAsync()
        {
            moq::Mock<RegionBackendServices.RegionBackendServicesClient> mockGrpcClient = new moq::Mock<RegionBackendServices.RegionBackendServicesClient>(moq::MockBehavior.Strict);
            UpdateRegionBackendServiceRequest request = new UpdateRegionBackendServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                BackendService = "backend_serviceed490d45",
                BackendServiceResource = new BackendService(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionBackendServicesClient client = new RegionBackendServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request.Project, request.Region, request.BackendService, request.BackendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request.Project, request.Region, request.BackendService, request.BackendServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
