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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Channel.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudChannelServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetCustomerRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.GetCustomer(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomerRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Customer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer responseCallSettings = await client.GetCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Customer responseCancellationToken = await client.GetCustomerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomer()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.GetCustomer(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomerAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Customer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer responseCallSettings = await client.GetCustomerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Customer responseCancellationToken = await client.GetCustomerAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomerResourceNames()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.GetCustomer(request.CustomerName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomerResourceNamesAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Customer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer responseCallSettings = await client.GetCustomerAsync(request.CustomerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Customer responseCancellationToken = await client.GetCustomerAsync(request.CustomerName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckCloudIdentityAccountsExistRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckCloudIdentityAccountsExistRequest request = new CheckCloudIdentityAccountsExistRequest
            {
                Parent = "parent7858e4d0",
                Domain = "domaine8825fad",
            };
            CheckCloudIdentityAccountsExistResponse expectedResponse = new CheckCloudIdentityAccountsExistResponse
            {
                CloudIdentityAccounts =
                {
                    new CloudIdentityCustomerAccount
                    {
                        Existing = true,
                        Owned = true,
                        CustomerName = "customer_name2ace137a",
                        CustomerCloudIdentityId = "customer_cloud_identity_idb7a91a6c",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CheckCloudIdentityAccountsExist(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            CheckCloudIdentityAccountsExistResponse response = client.CheckCloudIdentityAccountsExist(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckCloudIdentityAccountsExistRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckCloudIdentityAccountsExistRequest request = new CheckCloudIdentityAccountsExistRequest
            {
                Parent = "parent7858e4d0",
                Domain = "domaine8825fad",
            };
            CheckCloudIdentityAccountsExistResponse expectedResponse = new CheckCloudIdentityAccountsExistResponse
            {
                CloudIdentityAccounts =
                {
                    new CloudIdentityCustomerAccount
                    {
                        Existing = true,
                        Owned = true,
                        CustomerName = "customer_name2ace137a",
                        CustomerCloudIdentityId = "customer_cloud_identity_idb7a91a6c",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CheckCloudIdentityAccountsExistAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckCloudIdentityAccountsExistResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            CheckCloudIdentityAccountsExistResponse responseCallSettings = await client.CheckCloudIdentityAccountsExistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckCloudIdentityAccountsExistResponse responseCancellationToken = await client.CheckCloudIdentityAccountsExistAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomerRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomerRequest request = new CreateCustomerRequest
            {
                Parent = "parent7858e4d0",
                Customer = new Customer
                {
                    CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                    OrgDisplayName = "org_display_nameb29ddfcb",
                    OrgPostalAddress = new gt::PostalAddress
                    {
                        Revision = -1171785291,
                        RegionCode = "region_code72561d46",
                        LanguageCode = "language_code2f6c7160",
                        PostalCode = "postal_code51d301e6",
                        SortingCode = "sorting_codeab47cbcd",
                        AdministrativeArea = "administrative_area5d9f9eab",
                        Locality = "locality2082e309",
                        Sublocality = "sublocality1a785e24",
                        AddressLines =
                        {
                            "address_lines4ab5c702",
                        },
                        Recipients =
                        {
                            "recipients9bf62a97",
                        },
                        Organization = "organization8c94c1b4",
                    },
                    PrimaryContactInfo = new ContactInfo
                    {
                        FirstName = "first_name9d4e032a",
                        LastName = "last_namec053457d",
                        DisplayName = "display_name137f65c2",
                        Email = "email7cf5830c",
                        Title = "title17dbd3d5",
                        Phone = "phonee72fa4f7",
                    },
                    AlternateEmail = "alternate_email3cdfc6ce",
                    Domain = "domaine8825fad",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CloudIdentityId = "cloud_identity_idcb2e1526",
                    LanguageCode = "language_code2f6c7160",
                    CloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                    ChannelPartnerId = "channel_partner_ida548fd43",
                },
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.CreateCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.CreateCustomer(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomerRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateCustomerRequest request = new CreateCustomerRequest
            {
                Parent = "parent7858e4d0",
                Customer = new Customer
                {
                    CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                    OrgDisplayName = "org_display_nameb29ddfcb",
                    OrgPostalAddress = new gt::PostalAddress
                    {
                        Revision = -1171785291,
                        RegionCode = "region_code72561d46",
                        LanguageCode = "language_code2f6c7160",
                        PostalCode = "postal_code51d301e6",
                        SortingCode = "sorting_codeab47cbcd",
                        AdministrativeArea = "administrative_area5d9f9eab",
                        Locality = "locality2082e309",
                        Sublocality = "sublocality1a785e24",
                        AddressLines =
                        {
                            "address_lines4ab5c702",
                        },
                        Recipients =
                        {
                            "recipients9bf62a97",
                        },
                        Organization = "organization8c94c1b4",
                    },
                    PrimaryContactInfo = new ContactInfo
                    {
                        FirstName = "first_name9d4e032a",
                        LastName = "last_namec053457d",
                        DisplayName = "display_name137f65c2",
                        Email = "email7cf5830c",
                        Title = "title17dbd3d5",
                        Phone = "phonee72fa4f7",
                    },
                    AlternateEmail = "alternate_email3cdfc6ce",
                    Domain = "domaine8825fad",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CloudIdentityId = "cloud_identity_idcb2e1526",
                    LanguageCode = "language_code2f6c7160",
                    CloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                    ChannelPartnerId = "channel_partner_ida548fd43",
                },
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Customer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer responseCallSettings = await client.CreateCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Customer responseCancellationToken = await client.CreateCustomerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomerRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCustomerRequest request = new UpdateCustomerRequest
            {
                Customer = new Customer
                {
                    CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                    OrgDisplayName = "org_display_nameb29ddfcb",
                    OrgPostalAddress = new gt::PostalAddress
                    {
                        Revision = -1171785291,
                        RegionCode = "region_code72561d46",
                        LanguageCode = "language_code2f6c7160",
                        PostalCode = "postal_code51d301e6",
                        SortingCode = "sorting_codeab47cbcd",
                        AdministrativeArea = "administrative_area5d9f9eab",
                        Locality = "locality2082e309",
                        Sublocality = "sublocality1a785e24",
                        AddressLines =
                        {
                            "address_lines4ab5c702",
                        },
                        Recipients =
                        {
                            "recipients9bf62a97",
                        },
                        Organization = "organization8c94c1b4",
                    },
                    PrimaryContactInfo = new ContactInfo
                    {
                        FirstName = "first_name9d4e032a",
                        LastName = "last_namec053457d",
                        DisplayName = "display_name137f65c2",
                        Email = "email7cf5830c",
                        Title = "title17dbd3d5",
                        Phone = "phonee72fa4f7",
                    },
                    AlternateEmail = "alternate_email3cdfc6ce",
                    Domain = "domaine8825fad",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CloudIdentityId = "cloud_identity_idcb2e1526",
                    LanguageCode = "language_code2f6c7160",
                    CloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                    ChannelPartnerId = "channel_partner_ida548fd43",
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.UpdateCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.UpdateCustomer(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomerRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCustomerRequest request = new UpdateCustomerRequest
            {
                Customer = new Customer
                {
                    CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                    OrgDisplayName = "org_display_nameb29ddfcb",
                    OrgPostalAddress = new gt::PostalAddress
                    {
                        Revision = -1171785291,
                        RegionCode = "region_code72561d46",
                        LanguageCode = "language_code2f6c7160",
                        PostalCode = "postal_code51d301e6",
                        SortingCode = "sorting_codeab47cbcd",
                        AdministrativeArea = "administrative_area5d9f9eab",
                        Locality = "locality2082e309",
                        Sublocality = "sublocality1a785e24",
                        AddressLines =
                        {
                            "address_lines4ab5c702",
                        },
                        Recipients =
                        {
                            "recipients9bf62a97",
                        },
                        Organization = "organization8c94c1b4",
                    },
                    PrimaryContactInfo = new ContactInfo
                    {
                        FirstName = "first_name9d4e032a",
                        LastName = "last_namec053457d",
                        DisplayName = "display_name137f65c2",
                        Email = "email7cf5830c",
                        Title = "title17dbd3d5",
                        Phone = "phonee72fa4f7",
                    },
                    AlternateEmail = "alternate_email3cdfc6ce",
                    Domain = "domaine8825fad",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CloudIdentityId = "cloud_identity_idcb2e1526",
                    LanguageCode = "language_code2f6c7160",
                    CloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                    ChannelPartnerId = "channel_partner_ida548fd43",
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress
                {
                    Revision = -1171785291,
                    RegionCode = "region_code72561d46",
                    LanguageCode = "language_code2f6c7160",
                    PostalCode = "postal_code51d301e6",
                    SortingCode = "sorting_codeab47cbcd",
                    AdministrativeArea = "administrative_area5d9f9eab",
                    Locality = "locality2082e309",
                    Sublocality = "sublocality1a785e24",
                    AddressLines =
                    {
                        "address_lines4ab5c702",
                    },
                    Recipients =
                    {
                        "recipients9bf62a97",
                    },
                    Organization = "organization8c94c1b4",
                },
                PrimaryContactInfo = new ContactInfo
                {
                    FirstName = "first_name9d4e032a",
                    LastName = "last_namec053457d",
                    DisplayName = "display_name137f65c2",
                    Email = "email7cf5830c",
                    Title = "title17dbd3d5",
                    Phone = "phonee72fa4f7",
                },
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.UpdateCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Customer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer responseCallSettings = await client.UpdateCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Customer responseCancellationToken = await client.UpdateCustomerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCustomerRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCustomer(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCustomerRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCustomerAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCustomer()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCustomer(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCustomerAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCustomerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCustomerAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCustomerResourceNames()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCustomer(request.CustomerName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCustomerResourceNamesAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCustomerAsync(request.CustomerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCustomerAsync(request.CustomerName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEntitlementRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntitlementRequest request = new GetEntitlementRequest
            {
                EntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
            };
            Entitlement expectedResponse = new Entitlement
            {
                EntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                OfferAsOfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                CommitmentSettings = new CommitmentSettings
                {
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RenewalSettings = new RenewalSettings
                    {
                        EnableRenewal = false,
                        ResizeUnitCount = false,
                        PaymentPlan = PaymentPlan.Commitment,
                        PaymentCycle = new Period
                        {
                            Duration = 348348088,
                            PeriodType = PeriodType.Year,
                        },
                    },
                },
                ProvisioningState = Entitlement.Types.ProvisioningState.Unspecified,
                ProvisionedService = new ProvisionedService
                {
                    ProvisioningId = "provisioning_idb6b17dad",
                    ProductId = "product_idde82ea9b",
                    SkuId = "sku_idca5bad22",
                },
                SuspensionReasons =
                {
                    Entitlement.Types.SuspensionReason.TrialEnded,
                },
                PurchaseOrderId = "purchase_order_id4111e034",
                TrialSettings = new TrialSettings
                {
                    Trial = true,
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                AssociationInfo = new AssociationInfo
                {
                    BaseEntitlementAsEntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
                },
                Parameters =
                {
                    new Parameter
                    {
                        Name = "name1c9368b0",
                        Value = new Value
                        {
                            Int64Value = 4714169996607726047L,
                            StringValue = "string_valueb4853a86",
                            DoubleValue = -69080261192217800,
                            ProtoValue = new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                        Editable = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetEntitlement(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Entitlement response = client.GetEntitlement(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEntitlementRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEntitlementRequest request = new GetEntitlementRequest
            {
                EntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
            };
            Entitlement expectedResponse = new Entitlement
            {
                EntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                OfferAsOfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                CommitmentSettings = new CommitmentSettings
                {
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    RenewalSettings = new RenewalSettings
                    {
                        EnableRenewal = false,
                        ResizeUnitCount = false,
                        PaymentPlan = PaymentPlan.Commitment,
                        PaymentCycle = new Period
                        {
                            Duration = 348348088,
                            PeriodType = PeriodType.Year,
                        },
                    },
                },
                ProvisioningState = Entitlement.Types.ProvisioningState.Unspecified,
                ProvisionedService = new ProvisionedService
                {
                    ProvisioningId = "provisioning_idb6b17dad",
                    ProductId = "product_idde82ea9b",
                    SkuId = "sku_idca5bad22",
                },
                SuspensionReasons =
                {
                    Entitlement.Types.SuspensionReason.TrialEnded,
                },
                PurchaseOrderId = "purchase_order_id4111e034",
                TrialSettings = new TrialSettings
                {
                    Trial = true,
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                },
                AssociationInfo = new AssociationInfo
                {
                    BaseEntitlementAsEntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
                },
                Parameters =
                {
                    new Parameter
                    {
                        Name = "name1c9368b0",
                        Value = new Value
                        {
                            Int64Value = 4714169996607726047L,
                            StringValue = "string_valueb4853a86",
                            DoubleValue = -69080261192217800,
                            ProtoValue = new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                        Editable = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetEntitlementAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Entitlement>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Entitlement responseCallSettings = await client.GetEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Entitlement responseCancellationToken = await client.GetEntitlementAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetChannelPartnerLinkRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelPartnerLinkRequest request = new GetChannelPartnerLinkRequest
            {
                Name = "name1c9368b0",
                View = ChannelPartnerLinkView.Basic,
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                Name = "name1c9368b0",
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetChannelPartnerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            ChannelPartnerLink response = client.GetChannelPartnerLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChannelPartnerLinkRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetChannelPartnerLinkRequest request = new GetChannelPartnerLinkRequest
            {
                Name = "name1c9368b0",
                View = ChannelPartnerLinkView.Basic,
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                Name = "name1c9368b0",
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetChannelPartnerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ChannelPartnerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            ChannelPartnerLink responseCallSettings = await client.GetChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ChannelPartnerLink responseCancellationToken = await client.GetChannelPartnerLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateChannelPartnerLinkRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateChannelPartnerLinkRequest request = new CreateChannelPartnerLinkRequest
            {
                Parent = "parent7858e4d0",
                ChannelPartnerLink = new ChannelPartnerLink
                {
                    Name = "name1c9368b0",
                    ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                    LinkState = ChannelPartnerLinkState.Revoked,
                    InviteLinkUri = "invite_link_urie81ac099",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PublicId = "public_id4d74e21e",
                    ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                },
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                Name = "name1c9368b0",
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateChannelPartnerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            ChannelPartnerLink response = client.CreateChannelPartnerLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateChannelPartnerLinkRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateChannelPartnerLinkRequest request = new CreateChannelPartnerLinkRequest
            {
                Parent = "parent7858e4d0",
                ChannelPartnerLink = new ChannelPartnerLink
                {
                    Name = "name1c9368b0",
                    ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                    LinkState = ChannelPartnerLinkState.Revoked,
                    InviteLinkUri = "invite_link_urie81ac099",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PublicId = "public_id4d74e21e",
                    ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                },
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                Name = "name1c9368b0",
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateChannelPartnerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ChannelPartnerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            ChannelPartnerLink responseCallSettings = await client.CreateChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ChannelPartnerLink responseCancellationToken = await client.CreateChannelPartnerLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateChannelPartnerLinkRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateChannelPartnerLinkRequest request = new UpdateChannelPartnerLinkRequest
            {
                Name = "name1c9368b0",
                ChannelPartnerLink = new ChannelPartnerLink
                {
                    Name = "name1c9368b0",
                    ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                    LinkState = ChannelPartnerLinkState.Revoked,
                    InviteLinkUri = "invite_link_urie81ac099",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PublicId = "public_id4d74e21e",
                    ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                Name = "name1c9368b0",
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateChannelPartnerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            ChannelPartnerLink response = client.UpdateChannelPartnerLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateChannelPartnerLinkRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateChannelPartnerLinkRequest request = new UpdateChannelPartnerLinkRequest
            {
                Name = "name1c9368b0",
                ChannelPartnerLink = new ChannelPartnerLink
                {
                    Name = "name1c9368b0",
                    ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                    LinkState = ChannelPartnerLinkState.Revoked,
                    InviteLinkUri = "invite_link_urie81ac099",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PublicId = "public_id4d74e21e",
                    ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                    {
                        CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                        IsDomainVerified = false,
                        AlternateEmail = "alternate_email3cdfc6ce",
                        PhoneNumber = "phone_number9ebac341",
                        LanguageCode = "language_code2f6c7160",
                        PrimaryDomain = "primary_domainc60acdbc",
                        AdminConsoleUri = "admin_console_urif9cabb4a",
                        EduData = new EduData
                        {
                            InstituteType = EduData.Types.InstituteType.Unspecified,
                            InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                            Website = "website03fabed1",
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                Name = "name1c9368b0",
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo
                {
                    CustomerType = CloudIdentityInfo.Types.CustomerType.Domain,
                    IsDomainVerified = false,
                    AlternateEmail = "alternate_email3cdfc6ce",
                    PhoneNumber = "phone_number9ebac341",
                    LanguageCode = "language_code2f6c7160",
                    PrimaryDomain = "primary_domainc60acdbc",
                    AdminConsoleUri = "admin_console_urif9cabb4a",
                    EduData = new EduData
                    {
                        InstituteType = EduData.Types.InstituteType.Unspecified,
                        InstituteSize = EduData.Types.InstituteSize.Size10001OrMore,
                        Website = "website03fabed1",
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateChannelPartnerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ChannelPartnerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            ChannelPartnerLink responseCallSettings = await client.UpdateChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ChannelPartnerLink responseCancellationToken = await client.UpdateChannelPartnerLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RegisterSubscriberRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RegisterSubscriberRequest request = new RegisterSubscriberRequest
            {
                Account = "account3e4468e2",
                ServiceAccount = "service_accounta3c1b923",
            };
            RegisterSubscriberResponse expectedResponse = new RegisterSubscriberResponse
            {
                Topic = "topicac689b9d",
            };
            mockGrpcClient.Setup(x => x.RegisterSubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            RegisterSubscriberResponse response = client.RegisterSubscriber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RegisterSubscriberRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RegisterSubscriberRequest request = new RegisterSubscriberRequest
            {
                Account = "account3e4468e2",
                ServiceAccount = "service_accounta3c1b923",
            };
            RegisterSubscriberResponse expectedResponse = new RegisterSubscriberResponse
            {
                Topic = "topicac689b9d",
            };
            mockGrpcClient.Setup(x => x.RegisterSubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegisterSubscriberResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            RegisterSubscriberResponse responseCallSettings = await client.RegisterSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegisterSubscriberResponse responseCancellationToken = await client.RegisterSubscriberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UnregisterSubscriberRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UnregisterSubscriberRequest request = new UnregisterSubscriberRequest
            {
                Account = "account3e4468e2",
                ServiceAccount = "service_accounta3c1b923",
            };
            UnregisterSubscriberResponse expectedResponse = new UnregisterSubscriberResponse
            {
                Topic = "topicac689b9d",
            };
            mockGrpcClient.Setup(x => x.UnregisterSubscriber(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            UnregisterSubscriberResponse response = client.UnregisterSubscriber(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UnregisterSubscriberRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UnregisterSubscriberRequest request = new UnregisterSubscriberRequest
            {
                Account = "account3e4468e2",
                ServiceAccount = "service_accounta3c1b923",
            };
            UnregisterSubscriberResponse expectedResponse = new UnregisterSubscriberResponse
            {
                Topic = "topicac689b9d",
            };
            mockGrpcClient.Setup(x => x.UnregisterSubscriberAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UnregisterSubscriberResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            UnregisterSubscriberResponse responseCallSettings = await client.UnregisterSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UnregisterSubscriberResponse responseCancellationToken = await client.UnregisterSubscriberAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
