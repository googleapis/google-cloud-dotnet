// Copyright 2019 Google LLC
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

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Talent.V4Beta1;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedTenantServiceClientTest
    {
        [Fact]
        public void CreateTenant()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            CreateTenantRequest expectedRequest = new CreateTenantRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.CreateTenant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Tenant tenant = new Tenant();
            Tenant response = client.CreateTenant(parent, tenant);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTenantAsync()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            CreateTenantRequest expectedRequest = new CreateTenantRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.CreateTenantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tenant>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Tenant tenant = new Tenant();
            Tenant response = await client.CreateTenantAsync(parent, tenant);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTenant2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.CreateTenant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.CreateTenant(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTenantAsync2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.CreateTenantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tenant>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = await client.CreateTenantAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTenant()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            GetTenantRequest expectedRequest = new GetTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.GetTenant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            Tenant response = client.GetTenant(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTenantAsync()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            GetTenantRequest expectedRequest = new GetTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.GetTenantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tenant>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            Tenant response = await client.GetTenantAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTenant2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.GetTenant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.GetTenant(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTenantAsync2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.GetTenantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tenant>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = await client.GetTenantAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTenant()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            UpdateTenantRequest expectedRequest = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.UpdateTenant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant tenant = new Tenant();
            Tenant response = client.UpdateTenant(tenant);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTenantAsync()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            UpdateTenantRequest expectedRequest = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.UpdateTenantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tenant>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant tenant = new Tenant();
            Tenant response = await client.UpdateTenantAsync(tenant);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTenant2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.UpdateTenant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = client.UpdateTenant(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTenantAsync2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            Tenant expectedResponse = new Tenant
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
                ExternalId = "externalId-1153075697",
            };
            mockGrpcClient.Setup(x => x.UpdateTenantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tenant>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            Tenant response = await client.UpdateTenantAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTenant()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            DeleteTenantRequest expectedRequest = new DeleteTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTenant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            client.DeleteTenant(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTenantAsync()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            DeleteTenantRequest expectedRequest = new DeleteTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTenantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            await client.DeleteTenantAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTenant2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTenant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTenant(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTenantAsync2()
        {
            Mock<TenantService.TenantServiceClient> mockGrpcClient = new Mock<TenantService.TenantServiceClient>(MockBehavior.Strict);
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTenantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            TenantServiceClient client = new TenantServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTenantAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
