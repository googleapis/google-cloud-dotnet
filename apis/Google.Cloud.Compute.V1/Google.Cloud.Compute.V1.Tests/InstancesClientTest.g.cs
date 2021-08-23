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
    public sealed class GeneratedInstancesClientTest
    {
        [xunit::FactAttribute]
        public void AddAccessConfigRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddAccessConfigInstanceRequest request = new AddAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddAccessConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddAccessConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddAccessConfigRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddAccessConfigInstanceRequest request = new AddAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddAccessConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddAccessConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddAccessConfig()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddAccessConfigInstanceRequest request = new AddAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddAccessConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddAccessConfig(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.AccessConfigResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddAccessConfigAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddAccessConfigInstanceRequest request = new AddAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddAccessConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddAccessConfigAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.AccessConfigResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddAccessConfigAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.AccessConfigResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddResourcePoliciesRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddResourcePoliciesInstanceRequest request = new AddResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesAddResourcePoliciesRequestResource = new InstancesAddResourcePoliciesRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddResourcePolicies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddResourcePolicies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddResourcePoliciesRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddResourcePoliciesInstanceRequest request = new AddResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesAddResourcePoliciesRequestResource = new InstancesAddResourcePoliciesRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddResourcePoliciesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddResourcePoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddResourcePoliciesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddResourcePolicies()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddResourcePoliciesInstanceRequest request = new AddResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesAddResourcePoliciesRequestResource = new InstancesAddResourcePoliciesRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddResourcePolicies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddResourcePolicies(request.Project, request.Zone, request.Instance, request.InstancesAddResourcePoliciesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddResourcePoliciesAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AddResourcePoliciesInstanceRequest request = new AddResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesAddResourcePoliciesRequestResource = new InstancesAddResourcePoliciesRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddResourcePoliciesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddResourcePoliciesAsync(request.Project, request.Zone, request.Instance, request.InstancesAddResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddResourcePoliciesAsync(request.Project, request.Zone, request.Instance, request.InstancesAddResourcePoliciesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AttachDiskRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AttachDiskInstanceRequest request = new AttachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                AttachedDiskResource = new AttachedDisk(),
                ForceAttach = false,
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AttachDisk(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AttachDisk(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AttachDiskRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AttachDiskInstanceRequest request = new AttachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                AttachedDiskResource = new AttachedDisk(),
                ForceAttach = false,
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AttachDiskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AttachDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AttachDiskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AttachDisk()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AttachDiskInstanceRequest request = new AttachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                AttachedDiskResource = new AttachedDisk(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AttachDisk(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AttachDisk(request.Project, request.Zone, request.Instance, request.AttachedDiskResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AttachDiskAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            AttachDiskInstanceRequest request = new AttachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                AttachedDiskResource = new AttachedDisk(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AttachDiskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AttachDiskAsync(request.Project, request.Zone, request.Instance, request.AttachedDiskResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AttachDiskAsync(request.Project, request.Zone, request.Instance, request.AttachedDiskResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BulkInsertRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            BulkInsertInstanceRequest request = new BulkInsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                BulkInsertInstanceResourceResource = new BulkInsertInstanceResource(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.BulkInsert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.BulkInsert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BulkInsertRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            BulkInsertInstanceRequest request = new BulkInsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                BulkInsertInstanceResourceResource = new BulkInsertInstanceResource(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.BulkInsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.BulkInsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.BulkInsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BulkInsert()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            BulkInsertInstanceRequest request = new BulkInsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                BulkInsertInstanceResourceResource = new BulkInsertInstanceResource(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.BulkInsert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.BulkInsert(request.Project, request.Zone, request.BulkInsertInstanceResourceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BulkInsertAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            BulkInsertInstanceRequest request = new BulkInsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                BulkInsertInstanceResourceResource = new BulkInsertInstanceResource(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.BulkInsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.BulkInsertAsync(request.Project, request.Zone, request.BulkInsertInstanceResourceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.BulkInsertAsync(request.Project, request.Zone, request.BulkInsertInstanceResourceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccessConfigRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteAccessConfigInstanceRequest request = new DeleteAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                AccessConfig = "access_config9ac9e082",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAccessConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteAccessConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccessConfigRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteAccessConfigInstanceRequest request = new DeleteAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                AccessConfig = "access_config9ac9e082",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAccessConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAccessConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccessConfig()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteAccessConfigInstanceRequest request = new DeleteAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                AccessConfig = "access_config9ac9e082",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAccessConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteAccessConfig(request.Project, request.Zone, request.Instance, request.AccessConfig, request.NetworkInterface);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccessConfigAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DeleteAccessConfigInstanceRequest request = new DeleteAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                AccessConfig = "access_config9ac9e082",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAccessConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAccessConfigAsync(request.Project, request.Zone, request.Instance, request.AccessConfig, request.NetworkInterface, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAccessConfigAsync(request.Project, request.Zone, request.Instance, request.AccessConfig, request.NetworkInterface, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachDiskRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DetachDiskInstanceRequest request = new DetachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DetachDisk(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DetachDisk(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachDiskRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DetachDiskInstanceRequest request = new DetachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DetachDiskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DetachDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DetachDiskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetachDisk()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DetachDiskInstanceRequest request = new DetachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DetachDisk(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DetachDisk(request.Project, request.Zone, request.Instance, request.DeviceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetachDiskAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            DetachDiskInstanceRequest request = new DetachDiskInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DetachDiskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DetachDiskAsync(request.Project, request.Zone, request.Instance, request.DeviceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DetachDiskAsync(request.Project, request.Zone, request.Instance, request.DeviceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Instance.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork,
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Instance.Types.Status.Provisioning,
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Instance.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork,
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Instance.Types.Status.Provisioning,
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Instance.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork,
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Instance.Types.Status.Provisioning,
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance response = client.Get(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Instance expectedResponse = new Instance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Tags = new Tags(),
                Zone = "zone255f4ea8",
                ShieldedInstanceConfig = new ShieldedInstanceConfig(),
                ResourcePolicies =
                {
                    "resource_policiesdff15734",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                PrivateIpv6GoogleAccess = Instance.Types.PrivateIpv6GoogleAccess.InheritFromSubnetwork,
                NetworkInterfaces =
                {
                    new NetworkInterface(),
                },
                Metadata = new Metadata(),
                Disks = { new AttachedDisk(), },
                StartRestricted = true,
                ReservationAffinity = new ReservationAffinity(),
                ShieldedInstanceIntegrityPolicy = new ShieldedInstanceIntegrityPolicy(),
                LabelFingerprint = "label_fingerprint06ccff3a",
                Status = Instance.Types.Status.Provisioning,
                MachineType = "machine_type68ce40fa",
                Fingerprint = "fingerprint009e6052",
                Hostname = "hostnamef4ac9708",
                MinCpuPlatform = "min_cpu_platformf71ffa67",
                DisplayDevice = new DisplayDevice(),
                ServiceAccounts =
                {
                    new ServiceAccount(),
                },
                StatusMessage = "status_message2c618f86",
                LastSuspendedTimestamp = "last_suspended_timestamp1e59392b",
                Scheduling = new Scheduling(),
                AdvancedMachineFeatures = new AdvancedMachineFeatures(),
                CpuPlatform = "cpu_platformd5794042",
                LastStopTimestamp = "last_stop_timestampd336a8f1",
                Description = "description2cf9da67",
                LastStartTimestamp = "last_start_timestampe26bd347",
                SelfLink = "self_link7e87f12d",
                DeletionProtection = false,
                GuestAccelerators =
                {
                    new AcceleratorConfig(),
                },
                CanIpForward = true,
                SatisfiesPzs = false,
                ConfidentialInstanceConfig = new ConfidentialInstanceConfig(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewallsRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstancesGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstancesGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewalls()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request.Project, request.Zone, request.Instance, request.NetworkInterface);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsInstanceRequest request = new GetEffectiveFirewallsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
            };
            InstancesGetEffectiveFirewallsResponse expectedResponse = new InstancesGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new InstancesGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstancesGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            InstancesGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstancesGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestAttributesRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                VariableKey = "variable_key1c249a45",
                Project = "projectaa6ff846",
                QueryPath = "query_pathf44da93a",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes response = client.GetGuestAttributes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestAttributesRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                VariableKey = "variable_key1c249a45",
                Project = "projectaa6ff846",
                QueryPath = "query_pathf44da93a",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestAttributes>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes responseCallSettings = await client.GetGuestAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestAttributes responseCancellationToken = await client.GetGuestAttributesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGuestAttributes()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes response = client.GetGuestAttributes(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGuestAttributesAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetGuestAttributesInstanceRequest request = new GetGuestAttributesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            GuestAttributes expectedResponse = new GuestAttributes
            {
                Kind = "kindf7aa39d9",
                VariableValue = "variable_value61cc0fab",
                QueryValue = new GuestAttributesValue(),
                VariableKey = "variable_key1c249a45",
                QueryPath = "query_pathf44da93a",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetGuestAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GuestAttributes>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            GuestAttributes responseCallSettings = await client.GetGuestAttributesAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GuestAttributes responseCancellationToken = await client.GetGuestAttributesAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request.Project, request.Zone, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetIamPolicyInstanceRequest request = new GetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Project, request.Zone, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScreenshotRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot response = client.GetScreenshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScreenshotRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Screenshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot responseCallSettings = await client.GetScreenshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Screenshot responseCancellationToken = await client.GetScreenshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetScreenshot()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot response = client.GetScreenshot(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetScreenshotAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetScreenshotInstanceRequest request = new GetScreenshotInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Screenshot expectedResponse = new Screenshot
            {
                Kind = "kindf7aa39d9",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetScreenshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Screenshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Screenshot responseCallSettings = await client.GetScreenshotAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Screenshot responseCancellationToken = await client.GetScreenshotAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSerialPortOutputRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Port = -78310000,
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Start = -5616678393427383318L,
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput response = client.GetSerialPortOutput(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSerialPortOutputRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Port = -78310000,
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Start = -5616678393427383318L,
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SerialPortOutput>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput responseCallSettings = await client.GetSerialPortOutputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SerialPortOutput responseCancellationToken = await client.GetSerialPortOutputAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSerialPortOutput()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutput(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput response = client.GetSerialPortOutput(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSerialPortOutputAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetSerialPortOutputInstanceRequest request = new GetSerialPortOutputInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            SerialPortOutput expectedResponse = new SerialPortOutput
            {
                Kind = "kindf7aa39d9",
                Next = 9139246809011047120L,
                Start = -5616678393427383318L,
                SelfLink = "self_link7e87f12d",
                Contents = "contents8c7dbf98",
            };
            mockGrpcClient.Setup(x => x.GetSerialPortOutputAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SerialPortOutput>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            SerialPortOutput responseCallSettings = await client.GetSerialPortOutputAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SerialPortOutput responseCancellationToken = await client.GetSerialPortOutputAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShieldedInstanceIdentityRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity response = client.GetShieldedInstanceIdentity(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShieldedInstanceIdentityRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ShieldedInstanceIdentity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity responseCallSettings = await client.GetShieldedInstanceIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ShieldedInstanceIdentity responseCancellationToken = await client.GetShieldedInstanceIdentityAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetShieldedInstanceIdentity()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentity(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity response = client.GetShieldedInstanceIdentity(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetShieldedInstanceIdentityAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            GetShieldedInstanceIdentityInstanceRequest request = new GetShieldedInstanceIdentityInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            ShieldedInstanceIdentity expectedResponse = new ShieldedInstanceIdentity
            {
                Kind = "kindf7aa39d9",
                SigningKey = new ShieldedInstanceIdentityEntry(),
                EncryptionKey = new ShieldedInstanceIdentityEntry(),
            };
            mockGrpcClient.Setup(x => x.GetShieldedInstanceIdentityAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ShieldedInstanceIdentity>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            ShieldedInstanceIdentity responseCallSettings = await client.GetShieldedInstanceIdentityAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ShieldedInstanceIdentity responseCancellationToken = await client.GetShieldedInstanceIdentityAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            InsertInstanceRequest request = new InsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
                SourceInstanceTemplate = "source_instance_template4b774557",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            InsertInstanceRequest request = new InsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
                SourceInstanceTemplate = "source_instance_template4b774557",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            InsertInstanceRequest request = new InsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Zone, request.InstanceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            InsertInstanceRequest request = new InsertInstanceRequest
            {
                Zone = "zone255f4ea8",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Zone, request.InstanceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Zone, request.InstanceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveResourcePoliciesRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            RemoveResourcePoliciesInstanceRequest request = new RemoveResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesRemoveResourcePoliciesRequestResource = new InstancesRemoveResourcePoliciesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemoveResourcePolicies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveResourcePolicies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveResourcePoliciesRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            RemoveResourcePoliciesInstanceRequest request = new RemoveResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesRemoveResourcePoliciesRequestResource = new InstancesRemoveResourcePoliciesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemoveResourcePoliciesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveResourcePoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveResourcePoliciesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemoveResourcePolicies()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            RemoveResourcePoliciesInstanceRequest request = new RemoveResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesRemoveResourcePoliciesRequestResource = new InstancesRemoveResourcePoliciesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemoveResourcePolicies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemoveResourcePolicies(request.Project, request.Zone, request.Instance, request.InstancesRemoveResourcePoliciesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemoveResourcePoliciesAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            RemoveResourcePoliciesInstanceRequest request = new RemoveResourcePoliciesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesRemoveResourcePoliciesRequestResource = new InstancesRemoveResourcePoliciesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemoveResourcePoliciesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemoveResourcePoliciesAsync(request.Project, request.Zone, request.Instance, request.InstancesRemoveResourcePoliciesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemoveResourcePoliciesAsync(request.Project, request.Zone, request.Instance, request.InstancesRemoveResourcePoliciesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Reset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Reset(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.ResetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ResetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ResetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Reset()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Reset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Reset(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.ResetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.ResetAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.ResetAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDeletionProtectionRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDeletionProtectionInstanceRequest request = new SetDeletionProtectionInstanceRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                DeletionProtection = false,
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDeletionProtection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetDeletionProtection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDeletionProtectionRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDeletionProtectionInstanceRequest request = new SetDeletionProtectionInstanceRequest
            {
                Zone = "zone255f4ea8",
                RequestId = "request_id362c8df6",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                DeletionProtection = false,
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDeletionProtectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetDeletionProtectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetDeletionProtectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDeletionProtection()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDeletionProtectionInstanceRequest request = new SetDeletionProtectionInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDeletionProtection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetDeletionProtection(request.Project, request.Zone, request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDeletionProtectionAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDeletionProtectionInstanceRequest request = new SetDeletionProtectionInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDeletionProtectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetDeletionProtectionAsync(request.Project, request.Zone, request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetDeletionProtectionAsync(request.Project, request.Zone, request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDiskAutoDeleteRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDiskAutoDeleteInstanceRequest request = new SetDiskAutoDeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
                AutoDelete = true,
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDiskAutoDelete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetDiskAutoDelete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDiskAutoDeleteRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDiskAutoDeleteInstanceRequest request = new SetDiskAutoDeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
                AutoDelete = true,
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDiskAutoDeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetDiskAutoDeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetDiskAutoDeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetDiskAutoDelete()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDiskAutoDeleteInstanceRequest request = new SetDiskAutoDeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
                AutoDelete = true,
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDiskAutoDelete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetDiskAutoDelete(request.Project, request.Zone, request.Instance, request.AutoDelete, request.DeviceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetDiskAutoDeleteAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetDiskAutoDeleteInstanceRequest request = new SetDiskAutoDeleteInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                DeviceName = "device_name41d7923b",
                Project = "projectaa6ff846",
                AutoDelete = true,
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetDiskAutoDeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetDiskAutoDeleteAsync(request.Project, request.Zone, request.Instance, request.AutoDelete, request.DeviceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetDiskAutoDeleteAsync(request.Project, request.Zone, request.Instance, request.AutoDelete, request.DeviceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetIamPolicyInstanceRequest request = new SetIamPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Policy responseCallSettings = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Project, request.Zone, request.Resource, request.ZoneSetPolicyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabelsRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetLabelsInstanceRequest request = new SetLabelsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesSetLabelsRequestResource = new InstancesSetLabelsRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetLabelsInstanceRequest request = new SetLabelsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesSetLabelsRequestResource = new InstancesSetLabelsRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabels()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetLabelsInstanceRequest request = new SetLabelsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesSetLabelsRequestResource = new InstancesSetLabelsRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request.Project, request.Zone, request.Instance, request.InstancesSetLabelsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetLabelsInstanceRequest request = new SetLabelsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesSetLabelsRequestResource = new InstancesSetLabelsRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request.Project, request.Zone, request.Instance, request.InstancesSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request.Project, request.Zone, request.Instance, request.InstancesSetLabelsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMachineResourcesRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineResourcesInstanceRequest request = new SetMachineResourcesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesSetMachineResourcesRequestResource = new InstancesSetMachineResourcesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineResources(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMachineResources(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMachineResourcesRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineResourcesInstanceRequest request = new SetMachineResourcesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesSetMachineResourcesRequestResource = new InstancesSetMachineResourcesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineResourcesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMachineResourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMachineResourcesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMachineResources()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineResourcesInstanceRequest request = new SetMachineResourcesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesSetMachineResourcesRequestResource = new InstancesSetMachineResourcesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineResources(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMachineResources(request.Project, request.Zone, request.Instance, request.InstancesSetMachineResourcesRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMachineResourcesAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineResourcesInstanceRequest request = new SetMachineResourcesInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesSetMachineResourcesRequestResource = new InstancesSetMachineResourcesRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineResourcesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMachineResourcesAsync(request.Project, request.Zone, request.Instance, request.InstancesSetMachineResourcesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMachineResourcesAsync(request.Project, request.Zone, request.Instance, request.InstancesSetMachineResourcesRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMachineTypeRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineTypeInstanceRequest request = new SetMachineTypeInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesSetMachineTypeRequestResource = new InstancesSetMachineTypeRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMachineType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMachineTypeRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineTypeInstanceRequest request = new SetMachineTypeInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesSetMachineTypeRequestResource = new InstancesSetMachineTypeRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMachineTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMachineTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMachineType()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineTypeInstanceRequest request = new SetMachineTypeInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesSetMachineTypeRequestResource = new InstancesSetMachineTypeRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMachineType(request.Project, request.Zone, request.Instance, request.InstancesSetMachineTypeRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMachineTypeAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMachineTypeInstanceRequest request = new SetMachineTypeInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesSetMachineTypeRequestResource = new InstancesSetMachineTypeRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMachineTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMachineTypeAsync(request.Project, request.Zone, request.Instance, request.InstancesSetMachineTypeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMachineTypeAsync(request.Project, request.Zone, request.Instance, request.InstancesSetMachineTypeRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMetadataRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMetadataInstanceRequest request = new SetMetadataInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                MetadataResource = new Metadata(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMetadata(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMetadata(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMetadataRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMetadataInstanceRequest request = new SetMetadataInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                MetadataResource = new Metadata(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMetadataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMetadataAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMetadata()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMetadataInstanceRequest request = new SetMetadataInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                MetadataResource = new Metadata(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMetadata(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMetadata(request.Project, request.Zone, request.Instance, request.MetadataResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMetadataAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMetadataInstanceRequest request = new SetMetadataInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                MetadataResource = new Metadata(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMetadataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMetadataAsync(request.Project, request.Zone, request.Instance, request.MetadataResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMetadataAsync(request.Project, request.Zone, request.Instance, request.MetadataResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMinCpuPlatformRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMinCpuPlatformInstanceRequest request = new SetMinCpuPlatformInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesSetMinCpuPlatformRequestResource = new InstancesSetMinCpuPlatformRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMinCpuPlatform(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMinCpuPlatform(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMinCpuPlatformRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMinCpuPlatformInstanceRequest request = new SetMinCpuPlatformInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                InstancesSetMinCpuPlatformRequestResource = new InstancesSetMinCpuPlatformRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMinCpuPlatformAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMinCpuPlatformAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMinCpuPlatformAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetMinCpuPlatform()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMinCpuPlatformInstanceRequest request = new SetMinCpuPlatformInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesSetMinCpuPlatformRequestResource = new InstancesSetMinCpuPlatformRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMinCpuPlatform(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMinCpuPlatform(request.Project, request.Zone, request.Instance, request.InstancesSetMinCpuPlatformRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetMinCpuPlatformAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetMinCpuPlatformInstanceRequest request = new SetMinCpuPlatformInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstancesSetMinCpuPlatformRequestResource = new InstancesSetMinCpuPlatformRequest(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetMinCpuPlatformAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetMinCpuPlatformAsync(request.Project, request.Zone, request.Instance, request.InstancesSetMinCpuPlatformRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetMinCpuPlatformAsync(request.Project, request.Zone, request.Instance, request.InstancesSetMinCpuPlatformRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetSchedulingRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetSchedulingInstanceRequest request = new SetSchedulingInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SchedulingResource = new Scheduling(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetScheduling(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetScheduling(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSchedulingRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetSchedulingInstanceRequest request = new SetSchedulingInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SchedulingResource = new Scheduling(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetSchedulingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSchedulingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSchedulingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetScheduling()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetSchedulingInstanceRequest request = new SetSchedulingInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                SchedulingResource = new Scheduling(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetScheduling(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetScheduling(request.Project, request.Zone, request.Instance, request.SchedulingResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetSchedulingAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetSchedulingInstanceRequest request = new SetSchedulingInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                SchedulingResource = new Scheduling(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetSchedulingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetSchedulingAsync(request.Project, request.Zone, request.Instance, request.SchedulingResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetSchedulingAsync(request.Project, request.Zone, request.Instance, request.SchedulingResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetServiceAccountRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetServiceAccountInstanceRequest request = new SetServiceAccountInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesSetServiceAccountRequestResource = new InstancesSetServiceAccountRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetServiceAccountRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetServiceAccountInstanceRequest request = new SetServiceAccountInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesSetServiceAccountRequestResource = new InstancesSetServiceAccountRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetServiceAccount()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetServiceAccountInstanceRequest request = new SetServiceAccountInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesSetServiceAccountRequestResource = new InstancesSetServiceAccountRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetServiceAccount(request.Project, request.Zone, request.Instance, request.InstancesSetServiceAccountRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetServiceAccountAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetServiceAccountInstanceRequest request = new SetServiceAccountInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesSetServiceAccountRequestResource = new InstancesSetServiceAccountRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetServiceAccountAsync(request.Project, request.Zone, request.Instance, request.InstancesSetServiceAccountRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetServiceAccountAsync(request.Project, request.Zone, request.Instance, request.InstancesSetServiceAccountRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetShieldedInstanceIntegrityPolicyRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetShieldedInstanceIntegrityPolicyInstanceRequest request = new SetShieldedInstanceIntegrityPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ShieldedInstanceIntegrityPolicyResource = new ShieldedInstanceIntegrityPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetShieldedInstanceIntegrityPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetShieldedInstanceIntegrityPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetShieldedInstanceIntegrityPolicyRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetShieldedInstanceIntegrityPolicyInstanceRequest request = new SetShieldedInstanceIntegrityPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ShieldedInstanceIntegrityPolicyResource = new ShieldedInstanceIntegrityPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetShieldedInstanceIntegrityPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetShieldedInstanceIntegrityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetShieldedInstanceIntegrityPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetShieldedInstanceIntegrityPolicy()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetShieldedInstanceIntegrityPolicyInstanceRequest request = new SetShieldedInstanceIntegrityPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                ShieldedInstanceIntegrityPolicyResource = new ShieldedInstanceIntegrityPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetShieldedInstanceIntegrityPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetShieldedInstanceIntegrityPolicy(request.Project, request.Zone, request.Instance, request.ShieldedInstanceIntegrityPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetShieldedInstanceIntegrityPolicyAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetShieldedInstanceIntegrityPolicyInstanceRequest request = new SetShieldedInstanceIntegrityPolicyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                ShieldedInstanceIntegrityPolicyResource = new ShieldedInstanceIntegrityPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetShieldedInstanceIntegrityPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetShieldedInstanceIntegrityPolicyAsync(request.Project, request.Zone, request.Instance, request.ShieldedInstanceIntegrityPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetShieldedInstanceIntegrityPolicyAsync(request.Project, request.Zone, request.Instance, request.ShieldedInstanceIntegrityPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTagsRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetTagsInstanceRequest request = new SetTagsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TagsResource = new Tags(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTags(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTags(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTagsRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetTagsInstanceRequest request = new SetTagsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                TagsResource = new Tags(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTagsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTagsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTagsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetTags()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetTagsInstanceRequest request = new SetTagsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                TagsResource = new Tags(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTags(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetTags(request.Project, request.Zone, request.Instance, request.TagsResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetTagsAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SetTagsInstanceRequest request = new SetTagsInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                TagsResource = new Tags(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SetTagsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetTagsAsync(request.Project, request.Zone, request.Instance, request.TagsResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetTagsAsync(request.Project, request.Zone, request.Instance, request.TagsResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SimulateMaintenanceEventRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SimulateMaintenanceEventInstanceRequest request = new SimulateMaintenanceEventInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SimulateMaintenanceEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SimulateMaintenanceEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SimulateMaintenanceEventRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SimulateMaintenanceEventInstanceRequest request = new SimulateMaintenanceEventInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SimulateMaintenanceEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SimulateMaintenanceEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SimulateMaintenanceEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SimulateMaintenanceEvent()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SimulateMaintenanceEventInstanceRequest request = new SimulateMaintenanceEventInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SimulateMaintenanceEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SimulateMaintenanceEvent(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SimulateMaintenanceEventAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            SimulateMaintenanceEventInstanceRequest request = new SimulateMaintenanceEventInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SimulateMaintenanceEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SimulateMaintenanceEventAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SimulateMaintenanceEventAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartInstanceRequest request = new StartInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Start(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Start(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartInstanceRequest request = new StartInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StartAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StartAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Start()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartInstanceRequest request = new StartInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Start(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Start(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartInstanceRequest request = new StartInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StartAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StartAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StartAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartWithEncryptionKeyRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartWithEncryptionKeyInstanceRequest request = new StartWithEncryptionKeyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesStartWithEncryptionKeyRequestResource = new InstancesStartWithEncryptionKeyRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StartWithEncryptionKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.StartWithEncryptionKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartWithEncryptionKeyRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartWithEncryptionKeyInstanceRequest request = new StartWithEncryptionKeyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InstancesStartWithEncryptionKeyRequestResource = new InstancesStartWithEncryptionKeyRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StartWithEncryptionKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StartWithEncryptionKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StartWithEncryptionKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StartWithEncryptionKey()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartWithEncryptionKeyInstanceRequest request = new StartWithEncryptionKeyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesStartWithEncryptionKeyRequestResource = new InstancesStartWithEncryptionKeyRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StartWithEncryptionKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.StartWithEncryptionKey(request.Project, request.Zone, request.Instance, request.InstancesStartWithEncryptionKeyRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StartWithEncryptionKeyAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StartWithEncryptionKeyInstanceRequest request = new StartWithEncryptionKeyInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                InstancesStartWithEncryptionKeyRequestResource = new InstancesStartWithEncryptionKeyRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StartWithEncryptionKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StartWithEncryptionKeyAsync(request.Project, request.Zone, request.Instance, request.InstancesStartWithEncryptionKeyRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StartWithEncryptionKeyAsync(request.Project, request.Zone, request.Instance, request.InstancesStartWithEncryptionKeyRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StopRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StopInstanceRequest request = new StopInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Stop(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Stop(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StopInstanceRequest request = new StopInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StopAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StopAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StopAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Stop()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StopInstanceRequest request = new StopInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Stop(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Stop(request.Project, request.Zone, request.Instance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            StopInstanceRequest request = new StopInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.StopAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.StopAsync(request.Project, request.Zone, request.Instance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.StopAsync(request.Project, request.Zone, request.Instance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsInstanceRequest request = new TestIamPermissionsInstanceRequest
            {
                Zone = "zone255f4ea8",
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
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Zone, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                MostDisruptiveAllowedAction = "most_disruptive_allowed_actiondc81f7b0",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
                MinimalAction = "minimal_action55009cd3",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                MostDisruptiveAllowedAction = "most_disruptive_allowed_actiondc81f7b0",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
                MinimalAction = "minimal_action55009cd3",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Update()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request.Project, request.Zone, request.Instance, request.InstanceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                InstanceResource = new Instance(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request.Project, request.Zone, request.Instance, request.InstanceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request.Project, request.Zone, request.Instance, request.InstanceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAccessConfigRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateAccessConfigInstanceRequest request = new UpdateAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAccessConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateAccessConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAccessConfigRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateAccessConfigInstanceRequest request = new UpdateAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAccessConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAccessConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAccessConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAccessConfig()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateAccessConfigInstanceRequest request = new UpdateAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAccessConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateAccessConfig(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.AccessConfigResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAccessConfigAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateAccessConfigInstanceRequest request = new UpdateAccessConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterface = "network_interfaceb50da44f",
                AccessConfigResource = new AccessConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAccessConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAccessConfigAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.AccessConfigResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAccessConfigAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.AccessConfigResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDisplayDeviceRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateDisplayDeviceInstanceRequest request = new UpdateDisplayDeviceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                DisplayDeviceResource = new DisplayDevice(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateDisplayDevice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDisplayDeviceRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateDisplayDeviceInstanceRequest request = new UpdateDisplayDeviceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                DisplayDeviceResource = new DisplayDevice(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateDisplayDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateDisplayDeviceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDisplayDevice()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateDisplayDeviceInstanceRequest request = new UpdateDisplayDeviceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                DisplayDeviceResource = new DisplayDevice(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayDevice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateDisplayDevice(request.Project, request.Zone, request.Instance, request.DisplayDeviceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDisplayDeviceAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateDisplayDeviceInstanceRequest request = new UpdateDisplayDeviceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                DisplayDeviceResource = new DisplayDevice(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayDeviceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateDisplayDeviceAsync(request.Project, request.Zone, request.Instance, request.DisplayDeviceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateDisplayDeviceAsync(request.Project, request.Zone, request.Instance, request.DisplayDeviceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNetworkInterfaceRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateNetworkInterfaceInstanceRequest request = new UpdateNetworkInterfaceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkInterfaceResource = new NetworkInterface(),
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateNetworkInterface(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateNetworkInterface(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNetworkInterfaceRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateNetworkInterfaceInstanceRequest request = new UpdateNetworkInterfaceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                NetworkInterfaceResource = new NetworkInterface(),
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateNetworkInterfaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateNetworkInterfaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateNetworkInterfaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateNetworkInterface()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateNetworkInterfaceInstanceRequest request = new UpdateNetworkInterfaceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterfaceResource = new NetworkInterface(),
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateNetworkInterface(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateNetworkInterface(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.NetworkInterfaceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateNetworkInterfaceAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateNetworkInterfaceInstanceRequest request = new UpdateNetworkInterfaceInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                NetworkInterfaceResource = new NetworkInterface(),
                NetworkInterface = "network_interfaceb50da44f",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateNetworkInterfaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateNetworkInterfaceAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.NetworkInterfaceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateNetworkInterfaceAsync(request.Project, request.Zone, request.Instance, request.NetworkInterface, request.NetworkInterfaceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateShieldedInstanceConfigRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateShieldedInstanceConfigInstanceRequest request = new UpdateShieldedInstanceConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ShieldedInstanceConfigResource = new ShieldedInstanceConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateShieldedInstanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateShieldedInstanceConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateShieldedInstanceConfigRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateShieldedInstanceConfigInstanceRequest request = new UpdateShieldedInstanceConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                ShieldedInstanceConfigResource = new ShieldedInstanceConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateShieldedInstanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateShieldedInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateShieldedInstanceConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateShieldedInstanceConfig()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateShieldedInstanceConfigInstanceRequest request = new UpdateShieldedInstanceConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                ShieldedInstanceConfigResource = new ShieldedInstanceConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateShieldedInstanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateShieldedInstanceConfig(request.Project, request.Zone, request.Instance, request.ShieldedInstanceConfigResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateShieldedInstanceConfigAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            UpdateShieldedInstanceConfigInstanceRequest request = new UpdateShieldedInstanceConfigInstanceRequest
            {
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                Project = "projectaa6ff846",
                ShieldedInstanceConfigResource = new ShieldedInstanceConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
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
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateShieldedInstanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateShieldedInstanceConfigAsync(request.Project, request.Zone, request.Instance, request.ShieldedInstanceConfigResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateShieldedInstanceConfigAsync(request.Project, request.Zone, request.Instance, request.ShieldedInstanceConfigResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
