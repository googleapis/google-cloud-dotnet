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
    public sealed class GeneratedPublicAdvertisedPrefixesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.PublicAdvertisedPrefix);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            DeletePublicAdvertisedPrefixeRequest request = new DeletePublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.PublicAdvertisedPrefix, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.PublicAdvertisedPrefix, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
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
                Status = PublicAdvertisedPrefix.Types.Status.PrefixConfigurationComplete,
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
                Status = PublicAdvertisedPrefix.Types.Status.PrefixConfigurationComplete,
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
                Status = PublicAdvertisedPrefix.Types.Status.PrefixConfigurationComplete,
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
                Status = PublicAdvertisedPrefix.Types.Status.PrefixConfigurationComplete,
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

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.PublicAdvertisedPrefixResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            InsertPublicAdvertisedPrefixeRequest request = new InsertPublicAdvertisedPrefixeRequest
            {
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.PublicAdvertisedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.PublicAdvertisedPrefixResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                RequestId = "request_id362c8df6",
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.PublicAdvertisedPrefix, request.PublicAdvertisedPrefixResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            PatchPublicAdvertisedPrefixeRequest request = new PatchPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
                PublicAdvertisedPrefixResource = new PublicAdvertisedPrefix(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.PublicAdvertisedPrefix, request.PublicAdvertisedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.PublicAdvertisedPrefix, request.PublicAdvertisedPrefixResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
