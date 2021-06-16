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
    public sealed class GeneratedGlobalPublicDelegatedPrefixesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.PublicDelegatedPrefix);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            DeleteGlobalPublicDelegatedPrefixeRequest request = new DeleteGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.PublicDelegatedPrefix, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.PublicDelegatedPrefix, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
            };
            PublicDelegatedPrefix expectedResponse = new PublicDelegatedPrefix
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                ParentPrefix = "parent_prefix33eed533",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Region = "regionedb20d96",
                Status = PublicDelegatedPrefix.Types.Status.Deleting,
                PublicDelegatedSubPrefixs =
                {
                    new PublicDelegatedPrefixPublicDelegatedSubPrefix(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                IsLiveMigration = true,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefix response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
            };
            PublicDelegatedPrefix expectedResponse = new PublicDelegatedPrefix
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                ParentPrefix = "parent_prefix33eed533",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Region = "regionedb20d96",
                Status = PublicDelegatedPrefix.Types.Status.Deleting,
                PublicDelegatedSubPrefixs =
                {
                    new PublicDelegatedPrefixPublicDelegatedSubPrefix(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                IsLiveMigration = true,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicDelegatedPrefix>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefix responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicDelegatedPrefix responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
            };
            PublicDelegatedPrefix expectedResponse = new PublicDelegatedPrefix
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                ParentPrefix = "parent_prefix33eed533",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Region = "regionedb20d96",
                Status = PublicDelegatedPrefix.Types.Status.Deleting,
                PublicDelegatedSubPrefixs =
                {
                    new PublicDelegatedPrefixPublicDelegatedSubPrefix(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                IsLiveMigration = true,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefix response = client.Get(request.Project, request.PublicDelegatedPrefix);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            GetGlobalPublicDelegatedPrefixeRequest request = new GetGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
            };
            PublicDelegatedPrefix expectedResponse = new PublicDelegatedPrefix
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                ParentPrefix = "parent_prefix33eed533",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Region = "regionedb20d96",
                Status = PublicDelegatedPrefix.Types.Status.Deleting,
                PublicDelegatedSubPrefixs =
                {
                    new PublicDelegatedPrefixPublicDelegatedSubPrefix(),
                },
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                IsLiveMigration = true,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicDelegatedPrefix>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefix responseCallSettings = await client.GetAsync(request.Project, request.PublicDelegatedPrefix, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicDelegatedPrefix responseCancellationToken = await client.GetAsync(request.Project, request.PublicDelegatedPrefix, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.PublicDelegatedPrefixResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            InsertGlobalPublicDelegatedPrefixeRequest request = new InsertGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.PublicDelegatedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.PublicDelegatedPrefixResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            PublicDelegatedPrefixList expectedResponse = new PublicDelegatedPrefixList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefixList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            PublicDelegatedPrefixList expectedResponse = new PublicDelegatedPrefixList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicDelegatedPrefixList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefixList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicDelegatedPrefixList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                Project = "projectaa6ff846",
            };
            PublicDelegatedPrefixList expectedResponse = new PublicDelegatedPrefixList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefixList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            ListGlobalPublicDelegatedPrefixesRequest request = new ListGlobalPublicDelegatedPrefixesRequest
            {
                Project = "projectaa6ff846",
            };
            PublicDelegatedPrefixList expectedResponse = new PublicDelegatedPrefixList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicDelegatedPrefixList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicDelegatedPrefixList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicDelegatedPrefixList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.PublicDelegatedPrefix, request.PublicDelegatedPrefixResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient> mockGrpcClient = new moq::Mock<GlobalPublicDelegatedPrefixes.GlobalPublicDelegatedPrefixesClient>(moq::MockBehavior.Strict);
            PatchGlobalPublicDelegatedPrefixeRequest request = new PatchGlobalPublicDelegatedPrefixeRequest
            {
                PublicDelegatedPrefixResource = new PublicDelegatedPrefix(),
                PublicDelegatedPrefix = "public_delegated_prefixff04d704",
                Project = "projectaa6ff846",
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
            GlobalPublicDelegatedPrefixesClient client = new GlobalPublicDelegatedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.PublicDelegatedPrefix, request.PublicDelegatedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.PublicDelegatedPrefix, request.PublicDelegatedPrefixResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
