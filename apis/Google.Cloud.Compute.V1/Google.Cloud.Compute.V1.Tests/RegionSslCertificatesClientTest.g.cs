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
    public sealed class GeneratedRegionSslCertificatesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            DeleteRegionSslCertificateRequest request = new DeleteRegionSslCertificateRequest
            {
                RequestId = "request_id362c8df6",
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            DeleteRegionSslCertificateRequest request = new DeleteRegionSslCertificateRequest
            {
                RequestId = "request_id362c8df6",
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            DeleteRegionSslCertificateRequest request = new DeleteRegionSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.SslCertificate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            DeleteRegionSslCertificateRequest request = new DeleteRegionSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.SslCertificate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.SslCertificate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            GetRegionSslCertificateRequest request = new GetRegionSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = SslCertificate.Types.Type.Unspecified,
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            SslCertificate response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            GetRegionSslCertificateRequest request = new GetRegionSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = SslCertificate.Types.Type.Unspecified,
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            SslCertificate responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslCertificate responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            GetRegionSslCertificateRequest request = new GetRegionSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = SslCertificate.Types.Type.Unspecified,
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            SslCertificate response = client.Get(request.Project, request.Region, request.SslCertificate);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            GetRegionSslCertificateRequest request = new GetRegionSslCertificateRequest
            {
                SslCertificate = "ssl_certificate25650c52",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            SslCertificate expectedResponse = new SslCertificate
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = SslCertificate.Types.Type.Unspecified,
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Managed = new SslCertificateManagedSslCertificate(),
                SelfManaged = new SslCertificateSelfManagedSslCertificate(),
                Certificate = "certificateef0cd3e0",
                PrivateKey = "private_key33176a15",
                Description = "description2cf9da67",
                ExpireTime = "expire_timece1cc25c",
                SelfLink = "self_link7e87f12d",
                SubjectAlternativeNames =
                {
                    "subject_alternative_names2036b37b",
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslCertificate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            SslCertificate responseCallSettings = await client.GetAsync(request.Project, request.Region, request.SslCertificate, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslCertificate responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.SslCertificate, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            InsertRegionSslCertificateRequest request = new InsertRegionSslCertificateRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                SslCertificateResource = new SslCertificate(),
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            InsertRegionSslCertificateRequest request = new InsertRegionSslCertificateRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                SslCertificateResource = new SslCertificate(),
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            InsertRegionSslCertificateRequest request = new InsertRegionSslCertificateRequest
            {
                Region = "regionedb20d96",
                SslCertificateResource = new SslCertificate(),
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.SslCertificateResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionSslCertificates.RegionSslCertificatesClient> mockGrpcClient = new moq::Mock<RegionSslCertificates.RegionSslCertificatesClient>(moq::MockBehavior.Strict);
            InsertRegionSslCertificateRequest request = new InsertRegionSslCertificateRequest
            {
                Region = "regionedb20d96",
                SslCertificateResource = new SslCertificate(),
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
            RegionSslCertificatesClient client = new RegionSslCertificatesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.SslCertificateResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.SslCertificateResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
