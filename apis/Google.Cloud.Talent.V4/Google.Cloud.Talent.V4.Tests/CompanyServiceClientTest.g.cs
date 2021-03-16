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
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCompanyServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCompanyRequestObject()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.CreateCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.CreateCompany(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCompanyRequestObjectAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.CreateCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.CreateCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.CreateCompanyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCompany()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.CreateCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.CreateCompany(request.Parent, request.Company);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCompanyAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.CreateCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.CreateCompanyAsync(request.Parent, request.Company, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.CreateCompanyAsync(request.Parent, request.Company, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCompanyResourceNames()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.CreateCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.CreateCompany(request.ParentAsTenantName, request.Company);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCompanyResourceNamesAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.CreateCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.CreateCompanyAsync(request.ParentAsTenantName, request.Company, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.CreateCompanyAsync(request.ParentAsTenantName, request.Company, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompanyRequestObject()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.GetCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.GetCompany(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompanyRequestObjectAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.GetCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.GetCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.GetCompanyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompany()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.GetCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.GetCompany(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompanyAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.GetCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.GetCompanyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.GetCompanyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCompanyResourceNames()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.GetCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.GetCompany(request.CompanyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCompanyResourceNamesAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.GetCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.GetCompanyAsync(request.CompanyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.GetCompanyAsync(request.CompanyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCompanyRequestObject()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.UpdateCompany(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCompanyRequestObjectAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.UpdateCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.UpdateCompanyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCompany()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company response = client.UpdateCompany(request.Company, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCompanyAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company
                {
                    CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    DisplayName = "display_name137f65c2",
                    ExternalId = "external_id9442680e",
                    Size = CompanySize.Mini,
                    HeadquartersAddress = "headquarters_address64cd7eb7",
                    HiringAgency = true,
                    EeoText = "eeo_text70a1a576",
                    WebsiteUri = "website_urid0c5dfce",
                    CareerSiteUri = "career_site_uri62d45b74",
                    ImageUri = "image_urieba3b1bc",
                    KeywordSearchableJobCustomAttributes =
                    {
                        "keyword_searchable_job_custom_attributese72ec77c",
                    },
                    DerivedInfo = new Company.Types.DerivedInfo
                    {
                        HeadquartersLocation = new Location
                        {
                            LocationType = Location.Types.LocationType.SubLocality2,
                            PostalAddress = new gt::PostalAddress
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
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            RadiusMiles = 77208654055655410,
                        },
                    },
                    Suspended = true,
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Company expectedResponse = new Company
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                DisplayName = "display_name137f65c2",
                ExternalId = "external_id9442680e",
                Size = CompanySize.Mini,
                HeadquartersAddress = "headquarters_address64cd7eb7",
                HiringAgency = true,
                EeoText = "eeo_text70a1a576",
                WebsiteUri = "website_urid0c5dfce",
                CareerSiteUri = "career_site_uri62d45b74",
                ImageUri = "image_urieba3b1bc",
                KeywordSearchableJobCustomAttributes =
                {
                    "keyword_searchable_job_custom_attributese72ec77c",
                },
                DerivedInfo = new Company.Types.DerivedInfo
                {
                    HeadquartersLocation = new Location
                    {
                        LocationType = Location.Types.LocationType.SubLocality2,
                        PostalAddress = new gt::PostalAddress
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
                        LatLng = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        RadiusMiles = 77208654055655410,
                    },
                },
                Suspended = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Company>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            Company responseCallSettings = await client.UpdateCompanyAsync(request.Company, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Company responseCancellationToken = await client.UpdateCompanyAsync(request.Company, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCompanyRequestObject()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCompany(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCompanyRequestObjectAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCompanyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCompany()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCompany(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCompanyAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCompanyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCompanyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCompanyResourceNames()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCompany(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCompany(request.CompanyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCompanyResourceNamesAsync()
        {
            moq::Mock<CompanyService.CompanyServiceClient> mockGrpcClient = new moq::Mock<CompanyService.CompanyServiceClient>(moq::MockBehavior.Strict);
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCompanyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompanyServiceClient client = new CompanyServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCompanyAsync(request.CompanyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCompanyAsync(request.CompanyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
