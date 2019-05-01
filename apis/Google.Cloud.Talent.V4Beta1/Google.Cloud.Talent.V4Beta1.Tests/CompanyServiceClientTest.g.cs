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
    public class GeneratedCompanyServiceClientTest
    {
        [Fact]
        public void CreateCompany()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            CreateCompanyRequest expectedRequest = new CreateCompanyRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.CreateCompany(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]"));
            Company company = new Company();
            Company response = client.CreateCompany(parent, company);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateCompanyAsync()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            CreateCompanyRequest expectedRequest = new CreateCompanyRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.CreateCompanyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Company>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]"));
            Company company = new Company();
            Company response = await client.CreateCompanyAsync(parent, company);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCompany2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.CreateCompany(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.CreateCompany(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateCompanyAsync2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.CreateCompanyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Company>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = await client.CreateCompanyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCompany()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            GetCompanyRequest expectedRequest = new GetCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetCompany(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            CompanyNameOneof name = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]"));
            Company response = client.GetCompany(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCompanyAsync()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            GetCompanyRequest expectedRequest = new GetCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetCompanyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Company>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            CompanyNameOneof name = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]"));
            Company response = await client.GetCompanyAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCompany2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetCompany(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.GetCompany(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCompanyAsync2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetCompanyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Company>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = await client.GetCompanyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCompany()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            UpdateCompanyRequest expectedRequest = new UpdateCompanyRequest
            {
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompany(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company company = new Company();
            Company response = client.UpdateCompany(company);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCompanyAsync()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            UpdateCompanyRequest expectedRequest = new UpdateCompanyRequest
            {
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompanyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Company>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company company = new Company();
            Company response = await client.UpdateCompanyAsync(company);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCompany2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompany(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.UpdateCompany(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCompanyAsync2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company(),
            };
            Company expectedResponse = new Company
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
                DisplayName = "displayName1615086568",
                ExternalId = "externalId-1153075697",
                HeadquartersAddress = "headquartersAddress-1879520036",
                HiringAgency = false,
                EeoText = "eeoText-1652097123",
                WebsiteUri = "websiteUri-2118185016",
                CareerSiteUri = "careerSiteUri1223331861",
                ImageUri = "imageUri-877823864",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCompanyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Company>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = await client.UpdateCompanyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteCompany()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            DeleteCompanyRequest expectedRequest = new DeleteCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteCompany(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            CompanyNameOneof name = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]"));
            client.DeleteCompany(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteCompanyAsync()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            DeleteCompanyRequest expectedRequest = new DeleteCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteCompanyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            CompanyNameOneof name = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]"));
            await client.DeleteCompanyAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteCompany2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteCompany(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCompany(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteCompanyAsync2()
        {
            Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new Mock<CompanyService.CompanyServiceClient>(MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyNameOneof = CompanyNameOneof.From(new CompanyName("[PROJECT]", "[TENANT]", "[COMPANY]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteCompanyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCompanyAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
