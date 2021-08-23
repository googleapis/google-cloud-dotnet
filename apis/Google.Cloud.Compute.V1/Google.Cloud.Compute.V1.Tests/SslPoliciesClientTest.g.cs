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
    public sealed class GeneratedSslPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.SslPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            DeleteSslPolicyRequest request = new DeleteSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.SslPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.SslPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
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
                MinTlsVersion = SslPolicy.Types.MinTlsVersion.Tls12,
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = SslPolicy.Types.Profile.UndefinedProfile,
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            SslPolicy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
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
                MinTlsVersion = SslPolicy.Types.MinTlsVersion.Tls12,
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = SslPolicy.Types.Profile.UndefinedProfile,
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
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
                MinTlsVersion = SslPolicy.Types.MinTlsVersion.Tls12,
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = SslPolicy.Types.Profile.UndefinedProfile,
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            SslPolicy response = client.Get(request.Project, request.SslPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
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
                MinTlsVersion = SslPolicy.Types.MinTlsVersion.Tls12,
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = SslPolicy.Types.Profile.UndefinedProfile,
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            SslPolicy responseCallSettings = await client.GetAsync(request.Project, request.SslPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslPolicy responseCancellationToken = await client.GetAsync(request.Project, request.SslPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.SslPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            InsertSslPolicyRequest request = new InsertSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.SslPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.SslPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListAvailableFeaturesRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            SslPoliciesListAvailableFeaturesResponse response = client.ListAvailableFeatures(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAvailableFeaturesRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            SslPoliciesListAvailableFeaturesResponse response = client.ListAvailableFeatures(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAvailableFeaturesAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            SslPoliciesListAvailableFeaturesResponse responseCallSettings = await client.ListAvailableFeaturesAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslPoliciesListAvailableFeaturesResponse responseCancellationToken = await client.ListAvailableFeaturesAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.SslPolicy, request.SslPolicyResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            PatchSslPolicyRequest request = new PatchSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicyResource = new SslPolicy(),
                SslPolicy = "ssl_policybf005a65",
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
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.SslPolicy, request.SslPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.SslPolicy, request.SslPolicyResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
