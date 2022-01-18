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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTenantServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateTenantRequestObject()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.CreateTenant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTenantRequestObjectAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.CreateTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.CreateTenantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTenant()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.CreateTenant(request.Parent, request.Tenant);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTenantAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.CreateTenantAsync(request.Parent, request.Tenant, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.CreateTenantAsync(request.Parent, request.Tenant, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTenantResourceNames()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.CreateTenant(request.ParentAsProjectName, request.Tenant);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTenantResourceNamesAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.CreateTenantAsync(request.ParentAsProjectName, request.Tenant, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.CreateTenantAsync(request.ParentAsProjectName, request.Tenant, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTenantRequestObject()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.GetTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.GetTenant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTenantRequestObjectAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.GetTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.GetTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.GetTenantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTenant()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.GetTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.GetTenant(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTenantAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.GetTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.GetTenantAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.GetTenantAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTenantResourceNames()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.GetTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.GetTenant(request.TenantName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTenantResourceNamesAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.GetTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.GetTenantAsync(request.TenantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.GetTenantAsync(request.TenantName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTenantRequestObject()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.UpdateTenant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTenantRequestObjectAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
                UpdateMask = new wkt::FieldMask(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.UpdateTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.UpdateTenantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTenant()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.UpdateTenant(request.Tenant);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTenantAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ExternalId = "external_id9442680e",
                UsageType = Tenant.Types.DataUsageType.Unspecified,
                KeywordSearchableProfileCustomAttributes =
                {
                    "keyword_searchable_profile_custom_attributes9dbf9d03",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Tenant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant responseCallSettings = await client.UpdateTenantAsync(request.Tenant, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Tenant responseCancellationToken = await client.UpdateTenantAsync(request.Tenant, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTenantRequestObject()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTenant(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTenantRequestObjectAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTenantAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTenant()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTenant(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTenantAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTenantAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTenantAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTenantResourceNames()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTenant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTenant(request.TenantName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTenantResourceNamesAsync()
        {
            moq::Mock<TenantService.TenantServiceClient> mockGrpcClient = new moq::Mock<TenantService.TenantServiceClient>(moq::MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTenantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTenantAsync(request.TenantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTenantAsync(request.TenantName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
