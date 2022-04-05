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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Iam.Admin.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIAMClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.GetServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.GetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.GetServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccount()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.GetServiceAccount(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.GetServiceAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.GetServiceAccountAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccountResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.GetServiceAccount(request.ServiceAccountName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.GetServiceAccountAsync(request.ServiceAccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.GetServiceAccountAsync(request.ServiceAccountName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AccountId = "account_id2a9c088a",
                ServiceAccount = new ServiceAccount(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.CreateServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AccountId = "account_id2a9c088a",
                ServiceAccount = new ServiceAccount(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.CreateServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.CreateServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceAccount()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AccountId = "account_id2a9c088a",
                ServiceAccount = new ServiceAccount(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.CreateServiceAccount(request.Name, request.AccountId, request.ServiceAccount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAccountAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AccountId = "account_id2a9c088a",
                ServiceAccount = new ServiceAccount(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.CreateServiceAccountAsync(request.Name, request.AccountId, request.ServiceAccount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.CreateServiceAccountAsync(request.Name, request.AccountId, request.ServiceAccount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceAccountResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AccountId = "account_id2a9c088a",
                ServiceAccount = new ServiceAccount(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.CreateServiceAccount(request.ProjectName, request.AccountId, request.ServiceAccount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAccountResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                AccountId = "account_id2a9c088a",
                ServiceAccount = new ServiceAccount(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.CreateServiceAccountAsync(request.ProjectName, request.AccountId, request.ServiceAccount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.CreateServiceAccountAsync(request.ProjectName, request.AccountId, request.ServiceAccount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ServiceAccount request = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.UpdateServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ServiceAccount request = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.UpdateServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.UpdateServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            PatchServiceAccountRequest request = new PatchServiceAccountRequest
            {
                ServiceAccount = new ServiceAccount(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.PatchServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.PatchServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            PatchServiceAccountRequest request = new PatchServiceAccountRequest
            {
                ServiceAccount = new ServiceAccount(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "project_id43ad98b0",
                UniqueId = "unique_idee0c0869",
                Email = "email7cf5830c",
                DisplayName = "display_name137f65c2",
#pragma warning disable CS0612
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
#pragma warning restore CS0612
                Description = "description2cf9da67",
                Oauth2ClientId = "oauth2_client_id0e8ea240",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.PatchServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.PatchServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.PatchServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceAccount(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAccountAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceAccount()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceAccount(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAccountAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAccountAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceAccountResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceAccount(request.ServiceAccountName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAccountResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAccountAsync(request.ServiceAccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAccountAsync(request.ServiceAccountName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UndeleteServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UndeleteServiceAccountRequest request = new UndeleteServiceAccountRequest
            {
                Name = "name1c9368b0",
            };
            UndeleteServiceAccountResponse expectedResponse = new UndeleteServiceAccountResponse
            {
                RestoredAccount = new ServiceAccount(),
            };
            mockGrpcClient.Setup(x => x.UndeleteServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            UndeleteServiceAccountResponse response = client.UndeleteServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UndeleteServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UndeleteServiceAccountRequest request = new UndeleteServiceAccountRequest
            {
                Name = "name1c9368b0",
            };
            UndeleteServiceAccountResponse expectedResponse = new UndeleteServiceAccountResponse
            {
                RestoredAccount = new ServiceAccount(),
            };
            mockGrpcClient.Setup(x => x.UndeleteServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UndeleteServiceAccountResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            UndeleteServiceAccountResponse responseCallSettings = await client.UndeleteServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UndeleteServiceAccountResponse responseCancellationToken = await client.UndeleteServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void EnableServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            EnableServiceAccountRequest request = new EnableServiceAccountRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EnableServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.EnableServiceAccount(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EnableServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            EnableServiceAccountRequest request = new EnableServiceAccountRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EnableServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.EnableServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.EnableServiceAccountAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DisableServiceAccountRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DisableServiceAccountRequest request = new DisableServiceAccountRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DisableServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DisableServiceAccount(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DisableServiceAccountRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DisableServiceAccountRequest request = new DisableServiceAccountRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DisableServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DisableServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DisableServiceAccountAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListServiceAccountKeysRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.UserManaged,
                },
            };
            ListServiceAccountKeysResponse expectedResponse = new ListServiceAccountKeysResponse
            {
                Keys =
                {
                    new ServiceAccountKey(),
                },
            };
            mockGrpcClient.Setup(x => x.ListServiceAccountKeys(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ListServiceAccountKeysResponse response = client.ListServiceAccountKeys(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListServiceAccountKeysRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.UserManaged,
                },
            };
            ListServiceAccountKeysResponse expectedResponse = new ListServiceAccountKeysResponse
            {
                Keys =
                {
                    new ServiceAccountKey(),
                },
            };
            mockGrpcClient.Setup(x => x.ListServiceAccountKeysAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListServiceAccountKeysResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ListServiceAccountKeysResponse responseCallSettings = await client.ListServiceAccountKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListServiceAccountKeysResponse responseCancellationToken = await client.ListServiceAccountKeysAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListServiceAccountKeys()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.UserManaged,
                },
            };
            ListServiceAccountKeysResponse expectedResponse = new ListServiceAccountKeysResponse
            {
                Keys =
                {
                    new ServiceAccountKey(),
                },
            };
            mockGrpcClient.Setup(x => x.ListServiceAccountKeys(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ListServiceAccountKeysResponse response = client.ListServiceAccountKeys(request.Name, request.KeyTypes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListServiceAccountKeysAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.UserManaged,
                },
            };
            ListServiceAccountKeysResponse expectedResponse = new ListServiceAccountKeysResponse
            {
                Keys =
                {
                    new ServiceAccountKey(),
                },
            };
            mockGrpcClient.Setup(x => x.ListServiceAccountKeysAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListServiceAccountKeysResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ListServiceAccountKeysResponse responseCallSettings = await client.ListServiceAccountKeysAsync(request.Name, request.KeyTypes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListServiceAccountKeysResponse responseCancellationToken = await client.ListServiceAccountKeysAsync(request.Name, request.KeyTypes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListServiceAccountKeysResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.UserManaged,
                },
            };
            ListServiceAccountKeysResponse expectedResponse = new ListServiceAccountKeysResponse
            {
                Keys =
                {
                    new ServiceAccountKey(),
                },
            };
            mockGrpcClient.Setup(x => x.ListServiceAccountKeys(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ListServiceAccountKeysResponse response = client.ListServiceAccountKeys(request.ServiceAccountName, request.KeyTypes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListServiceAccountKeysResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.UserManaged,
                },
            };
            ListServiceAccountKeysResponse expectedResponse = new ListServiceAccountKeysResponse
            {
                Keys =
                {
                    new ServiceAccountKey(),
                },
            };
            mockGrpcClient.Setup(x => x.ListServiceAccountKeysAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListServiceAccountKeysResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ListServiceAccountKeysResponse responseCallSettings = await client.ListServiceAccountKeysAsync(request.ServiceAccountName, request.KeyTypes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListServiceAccountKeysResponse responseCancellationToken = await client.ListServiceAccountKeysAsync(request.ServiceAccountName, request.KeyTypes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccountKeyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.GetServiceAccountKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountKeyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.GetServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.GetServiceAccountKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccountKey()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.GetServiceAccountKey(request.Name, request.PublicKeyType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountKeyAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.GetServiceAccountKeyAsync(request.Name, request.PublicKeyType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.GetServiceAccountKeyAsync(request.Name, request.PublicKeyType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccountKeyResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.GetServiceAccountKey(request.KeyName, request.PublicKeyType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountKeyResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.GetServiceAccountKeyAsync(request.KeyName, request.PublicKeyType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.GetServiceAccountKeyAsync(request.KeyName, request.PublicKeyType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceAccountKeyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.CreateServiceAccountKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAccountKeyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.CreateServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.CreateServiceAccountKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceAccountKey()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.CreateServiceAccountKey(request.Name, request.PrivateKeyType, request.KeyAlgorithm);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAccountKeyAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.CreateServiceAccountKeyAsync(request.Name, request.PrivateKeyType, request.KeyAlgorithm, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.CreateServiceAccountKeyAsync(request.Name, request.PrivateKeyType, request.KeyAlgorithm, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceAccountKeyResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.CreateServiceAccountKey(request.ServiceAccountName, request.PrivateKeyType, request.KeyAlgorithm);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAccountKeyResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.CreateServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.CreateServiceAccountKeyAsync(request.ServiceAccountName, request.PrivateKeyType, request.KeyAlgorithm, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.CreateServiceAccountKeyAsync(request.ServiceAccountName, request.PrivateKeyType, request.KeyAlgorithm, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UploadServiceAccountKeyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UploadServiceAccountKeyRequest request = new UploadServiceAccountKeyRequest
            {
                Name = "name1c9368b0",
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.UploadServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey response = client.UploadServiceAccountKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UploadServiceAccountKeyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UploadServiceAccountKeyRequest request = new UploadServiceAccountKeyRequest
            {
                Name = "name1c9368b0",
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
            };
            ServiceAccountKey expectedResponse = new ServiceAccountKey
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypePkcs12File,
                PrivateKeyData = proto::ByteString.CopyFromUtf8("private_key_data11a0b8dc"),
                ValidAfterTime = new wkt::Timestamp(),
                ValidBeforeTime = new wkt::Timestamp(),
                PublicKeyData = proto::ByteString.CopyFromUtf8("public_key_datae6a6623a"),
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
                KeyOrigin = ServiceAccountKeyOrigin.GoogleProvided,
                KeyType = ListServiceAccountKeysRequest.Types.KeyType.SystemManaged,
            };
            mockGrpcClient.Setup(x => x.UploadServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            ServiceAccountKey responseCallSettings = await client.UploadServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccountKey responseCancellationToken = await client.UploadServiceAccountKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceAccountKeyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceAccountKey(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAccountKeyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAccountKeyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceAccountKey()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceAccountKey(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAccountKeyAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAccountKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAccountKeyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceAccountKeyResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceAccountKey(request.KeyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAccountKeyResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAccountKeyAsync(request.KeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAccountKeyAsync(request.KeyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignBlobRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BytesToSign = proto::ByteString.CopyFromUtf8("bytes_to_sign55943ccb"),
#pragma warning restore CS0612
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignBlob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignBlobResponse response = client.SignBlob(request);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignBlobRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BytesToSign = proto::ByteString.CopyFromUtf8("bytes_to_sign55943ccb"),
#pragma warning restore CS0612
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignBlobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignBlobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignBlobResponse responseCallSettings = await client.SignBlobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            SignBlobResponse responseCancellationToken = await client.SignBlobAsync(request, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignBlob()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BytesToSign = proto::ByteString.CopyFromUtf8("bytes_to_sign55943ccb"),
#pragma warning restore CS0612
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignBlob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignBlobResponse response = client.SignBlob(request.Name, request.BytesToSign);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignBlobAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BytesToSign = proto::ByteString.CopyFromUtf8("bytes_to_sign55943ccb"),
#pragma warning restore CS0612
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignBlobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignBlobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignBlobResponse responseCallSettings = await client.SignBlobAsync(request.Name, request.BytesToSign, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            SignBlobResponse responseCancellationToken = await client.SignBlobAsync(request.Name, request.BytesToSign, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignBlobResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BytesToSign = proto::ByteString.CopyFromUtf8("bytes_to_sign55943ccb"),
#pragma warning restore CS0612
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignBlob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignBlobResponse response = client.SignBlob(request.ServiceAccountName, request.BytesToSign);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignBlobResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                BytesToSign = proto::ByteString.CopyFromUtf8("bytes_to_sign55943ccb"),
#pragma warning restore CS0612
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignBlobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignBlobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignBlobResponse responseCallSettings = await client.SignBlobAsync(request.ServiceAccountName, request.BytesToSign, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            SignBlobResponse responseCancellationToken = await client.SignBlobAsync(request.ServiceAccountName, request.BytesToSign, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignJwtRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Payload = "payloadf43c1c32",
#pragma warning restore CS0612
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignJwt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignJwtResponse response = client.SignJwt(request);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignJwtRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Payload = "payloadf43c1c32",
#pragma warning restore CS0612
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignJwtAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignJwtResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignJwtResponse responseCallSettings = await client.SignJwtAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            SignJwtResponse responseCancellationToken = await client.SignJwtAsync(request, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignJwt()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Payload = "payloadf43c1c32",
#pragma warning restore CS0612
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignJwt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignJwtResponse response = client.SignJwt(request.Name, request.Payload);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignJwtAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Payload = "payloadf43c1c32",
#pragma warning restore CS0612
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignJwtAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignJwtResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignJwtResponse responseCallSettings = await client.SignJwtAsync(request.Name, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            SignJwtResponse responseCancellationToken = await client.SignJwtAsync(request.Name, request.Payload, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignJwtResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Payload = "payloadf43c1c32",
#pragma warning restore CS0612
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignJwt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignJwtResponse response = client.SignJwt(request.ServiceAccountName, request.Payload);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignJwtResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
#pragma warning disable CS0612
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Payload = "payloadf43c1c32",
#pragma warning restore CS0612
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
#pragma warning disable CS0612
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.SignJwtAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignJwtResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
#pragma warning disable CS0612
            SignJwtResponse responseCallSettings = await client.SignJwtAsync(request.ServiceAccountName, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            SignJwtResponse responseCancellationToken = await client.SignJwtAsync(request.ServiceAccountName, request.Payload, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRoleRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetRoleRequest request = new GetRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetRole(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role response = client.GetRole(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRoleRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            GetRoleRequest request = new GetRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetRoleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Role>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role responseCallSettings = await client.GetRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Role responseCancellationToken = await client.GetRoleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRoleRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateRoleRequest request = new CreateRoleRequest
            {
                ParentAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                RoleId = "role_id33685684",
                Role = new Role(),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.CreateRole(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role response = client.CreateRole(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRoleRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            CreateRoleRequest request = new CreateRoleRequest
            {
                ParentAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                RoleId = "role_id33685684",
                Role = new Role(),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.CreateRoleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Role>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role responseCallSettings = await client.CreateRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Role responseCancellationToken = await client.CreateRoleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRoleRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UpdateRoleRequest request = new UpdateRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Role = new Role(),
                UpdateMask = new wkt::FieldMask(),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UpdateRole(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role response = client.UpdateRole(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRoleRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UpdateRoleRequest request = new UpdateRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Role = new Role(),
                UpdateMask = new wkt::FieldMask(),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UpdateRoleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Role>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role responseCallSettings = await client.UpdateRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Role responseCancellationToken = await client.UpdateRoleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRoleRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteRoleRequest request = new DeleteRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.DeleteRole(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role response = client.DeleteRole(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRoleRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            DeleteRoleRequest request = new DeleteRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.DeleteRoleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Role>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role responseCallSettings = await client.DeleteRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Role responseCancellationToken = await client.DeleteRoleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UndeleteRoleRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UndeleteRoleRequest request = new UndeleteRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UndeleteRole(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role response = client.UndeleteRole(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UndeleteRoleRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            UndeleteRoleRequest request = new UndeleteRoleRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
            };
            Role expectedResponse = new Role
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                IncludedPermissions =
                {
                    "included_permissionsbb060f08",
                },
                Stage = Role.Types.RoleLaunchStage.Ga,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UndeleteRoleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Role>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            Role responseCallSettings = await client.UndeleteRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Role responseCancellationToken = await client.UndeleteRoleAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void QueryAuditableServicesRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            QueryAuditableServicesRequest request = new QueryAuditableServicesRequest
            {
                FullResourceName = "full_resource_nameb0e77737",
            };
            QueryAuditableServicesResponse expectedResponse = new QueryAuditableServicesResponse
            {
                Services =
                {
                    new QueryAuditableServicesResponse.Types.AuditableService(),
                },
            };
            mockGrpcClient.Setup(x => x.QueryAuditableServices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            QueryAuditableServicesResponse response = client.QueryAuditableServices(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task QueryAuditableServicesRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            QueryAuditableServicesRequest request = new QueryAuditableServicesRequest
            {
                FullResourceName = "full_resource_nameb0e77737",
            };
            QueryAuditableServicesResponse expectedResponse = new QueryAuditableServicesResponse
            {
                Services =
                {
                    new QueryAuditableServicesResponse.Types.AuditableService(),
                },
            };
            mockGrpcClient.Setup(x => x.QueryAuditableServicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<QueryAuditableServicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            QueryAuditableServicesResponse responseCallSettings = await client.QueryAuditableServicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            QueryAuditableServicesResponse responseCancellationToken = await client.QueryAuditableServicesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LintPolicyRequestObject()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            LintPolicyRequest request = new LintPolicyRequest
            {
                FullResourceName = "full_resource_nameb0e77737",
                Condition = new gt::Expr(),
            };
            LintPolicyResponse expectedResponse = new LintPolicyResponse
            {
                LintResults = { new LintResult(), },
            };
            mockGrpcClient.Setup(x => x.LintPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            LintPolicyResponse response = client.LintPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LintPolicyRequestObjectAsync()
        {
            moq::Mock<IAM.IAMClient> mockGrpcClient = new moq::Mock<IAM.IAMClient>(moq::MockBehavior.Strict);
            LintPolicyRequest request = new LintPolicyRequest
            {
                FullResourceName = "full_resource_nameb0e77737",
                Condition = new gt::Expr(),
            };
            LintPolicyResponse expectedResponse = new LintPolicyResponse
            {
                LintResults = { new LintResult(), },
            };
            mockGrpcClient.Setup(x => x.LintPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LintPolicyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMClient client = new IAMClientImpl(mockGrpcClient.Object, null);
            LintPolicyResponse responseCallSettings = await client.LintPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LintPolicyResponse responseCancellationToken = await client.LintPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
