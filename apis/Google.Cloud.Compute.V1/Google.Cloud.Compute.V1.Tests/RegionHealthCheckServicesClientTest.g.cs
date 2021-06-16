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
    public sealed class GeneratedRegionHealthCheckServicesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionHealthCheckServiceRequest request = new DeleteRegionHealthCheckServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionHealthCheckServiceRequest request = new DeleteRegionHealthCheckServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionHealthCheckServiceRequest request = new DeleteRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.HealthCheckService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            DeleteRegionHealthCheckServiceRequest request = new DeleteRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.HealthCheckService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.HealthCheckService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = HealthCheckService.Types.HealthStatusAggregationPolicy.UndefinedHealthStatusAggregationPolicy,
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = HealthCheckService.Types.HealthStatusAggregationPolicy.UndefinedHealthStatusAggregationPolicy,
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheckService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheckService responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = HealthCheckService.Types.HealthStatusAggregationPolicy.UndefinedHealthStatusAggregationPolicy,
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService response = client.Get(request.Project, request.Region, request.HealthCheckService);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
            };
            HealthCheckService expectedResponse = new HealthCheckService
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                NetworkEndpointGroups =
                {
                    "network_endpoint_groupsb3b03e25",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                HealthStatusAggregationPolicy = HealthCheckService.Types.HealthStatusAggregationPolicy.UndefinedHealthStatusAggregationPolicy,
                NotificationEndpoints =
                {
                    "notification_endpoints507ebc27",
                },
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheckService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckService responseCallSettings = await client.GetAsync(request.Project, request.Region, request.HealthCheckService, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheckService responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.HealthCheckService, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            InsertRegionHealthCheckServiceRequest request = new InsertRegionHealthCheckServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            InsertRegionHealthCheckServiceRequest request = new InsertRegionHealthCheckServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            InsertRegionHealthCheckServiceRequest request = new InsertRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.HealthCheckServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            InsertRegionHealthCheckServiceRequest request = new InsertRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.HealthCheckServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.HealthCheckServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            ListRegionHealthCheckServicesRequest request = new ListRegionHealthCheckServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            HealthCheckServicesList expectedResponse = new HealthCheckServicesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new HealthCheckService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckServicesList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            ListRegionHealthCheckServicesRequest request = new ListRegionHealthCheckServicesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            HealthCheckServicesList expectedResponse = new HealthCheckServicesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new HealthCheckService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheckServicesList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckServicesList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheckServicesList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            ListRegionHealthCheckServicesRequest request = new ListRegionHealthCheckServicesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            HealthCheckServicesList expectedResponse = new HealthCheckServicesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new HealthCheckService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckServicesList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            ListRegionHealthCheckServicesRequest request = new ListRegionHealthCheckServicesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            HealthCheckServicesList expectedResponse = new HealthCheckServicesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new HealthCheckService(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheckServicesList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            HealthCheckServicesList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheckServicesList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            PatchRegionHealthCheckServiceRequest request = new PatchRegionHealthCheckServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            PatchRegionHealthCheckServiceRequest request = new PatchRegionHealthCheckServiceRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            PatchRegionHealthCheckServiceRequest request = new PatchRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.HealthCheckService, request.HealthCheckServiceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient> mockGrpcClient = new moq::Mock<RegionHealthCheckServices.RegionHealthCheckServicesClient>(moq::MockBehavior.Strict);
            PatchRegionHealthCheckServiceRequest request = new PatchRegionHealthCheckServiceRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheckService = "health_check_servicecdc3a03b",
                HealthCheckServiceResource = new HealthCheckService(),
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
            RegionHealthCheckServicesClient client = new RegionHealthCheckServicesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.HealthCheckService, request.HealthCheckServiceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.HealthCheckService, request.HealthCheckServiceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
