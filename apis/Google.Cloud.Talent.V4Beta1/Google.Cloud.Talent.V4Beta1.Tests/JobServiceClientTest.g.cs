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
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedJobServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.Parent, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.Parent, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.Parent, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames1()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsTenantName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNames1Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsTenantName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsTenantName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames2()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsProjectName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNames2Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsProjectName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsProjectName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job
                {
                    JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                    CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                    RequisitionId = "requisition_id21c2f0af",
                    Title = "title17dbd3d5",
                    Description = "description2cf9da67",
                    Addresses =
                    {
                        "addresses2f3a3e96",
                    },
                    ApplicationInfo = new Job.Types.ApplicationInfo
                    {
                        Emails = { "emails2fca67af", },
                        Instruction = "instructionfa6ecc39",
                        Uris = { "uris9aee097b", },
                    },
                    JobBenefits = { JobBenefit.Dental, },
                    CompensationInfo = new CompensationInfo
                    {
                        Entries =
                        {
                            new CompensationInfo.Types.CompensationEntry
                            {
                                Type = CompensationInfo.Types.CompensationType.Unspecified,
                                Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                Amount = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                Range = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                Description = "description2cf9da67",
                                ExpectedUnitsPerYear = 4.1649570948025856E+17,
                            },
                        },
                        AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    CustomAttributes =
                    {
                        {
                            "key8a0b6e3c",
                            new CustomAttribute
                            {
                                StringValues =
                                {
                                    "string_valuesc7b5c24c",
                                },
                                LongValues =
                                {
                                    -5952618049634455831L,
                                },
                                Filterable = true,
                            }
                        },
                    },
                    DegreeTypes =
                    {
                        DegreeType.PrimaryEducation,
                    },
                    Department = "departmentca9f9d45",
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    Incentives = "incentives80814488",
                    LanguageCode = "language_code2f6c7160",
                    JobLevel = JobLevel.Director,
                    PromotionValue = 899484920,
                    Qualifications = "qualifications920abb76",
                    Responsibilities = "responsibilities978e5c9b",
                    PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                    Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                    JobStartTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    JobEndTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingPublishTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingExpireTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingCreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PostingUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CompanyDisplayName = "company_display_name07e5990f",
                    DerivedInfo = new Job.Types.DerivedInfo
                    {
                        Locations =
                        {
                            new Location
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
                        JobCategories =
                        {
                            JobCategory.ComputerAndIt,
                        },
                    },
                    ProcessingOptions = new Job.Types.ProcessingOptions
                    {
                        DisableStreetAddressResolution = false,
                        HtmlSanitization = HtmlSanitization.Unspecified,
                    },
                },
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo
                {
                    Emails = { "emails2fca67af", },
                    Instruction = "instructionfa6ecc39",
                    Uris = { "uris9aee097b", },
                },
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo
                {
                    Entries =
                    {
                        new CompensationInfo.Types.CompensationEntry
                        {
                            Type = CompensationInfo.Types.CompensationType.Unspecified,
                            Unit = CompensationInfo.Types.CompensationUnit.Daily,
                            Amount = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            Range = new CompensationInfo.Types.CompensationRange
                            {
                                MinCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                                MaxCompensation = new gt::Money
                                {
                                    CurrencyCode = "currency_code7f81e352",
                                    Units = 1040752433522641849L,
                                    Nanos = 985689544,
                                },
                            },
                            Description = "description2cf9da67",
                            ExpectedUnitsPerYear = 4.1649570948025856E+17,
                        },
                    },
                    AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                    AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                    {
                        MinCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                        MaxCompensation = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute
                        {
                            StringValues =
                            {
                                "string_valuesc7b5c24c",
                            },
                            LongValues =
                            {
                                -5952618049634455831L,
                            },
                            Filterable = true,
                        }
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                JobStartTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                JobEndTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingPublishTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingCreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PostingUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo
                {
                    Locations =
                    {
                        new Location
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
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                },
                ProcessingOptions = new Job.Types.ProcessingOptions
                {
                    DisableStreetAddressResolution = false,
                    HtmlSanitization = HtmlSanitization.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.JobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.JobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobs()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.Parent, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.Parent, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.Parent, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsResourceNames1()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.ParentAsTenantName, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsResourceNames1Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.ParentAsTenantName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.ParentAsTenantName, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsResourceNames2()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.ParentAsProjectName, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsResourceNames2Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.ParentAsProjectName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.ParentAsProjectName, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchJobsRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.FeaturedJobSearch,
                RequestMetadata = new RequestMetadata
                {
                    Domain = "domaine8825fad",
                    SessionId = "session_id54efc87f",
                    UserId = "user_idd41a70e8",
                    AllowMissingIds = true,
                    DeviceInfo = new DeviceInfo
                    {
                        DeviceType = DeviceInfo.Types.DeviceType.Other,
                        Id = "id74b70bb8",
                    },
                },
                JobQuery = new JobQuery
                {
                    Query = "queryf0c71c1b",
                    Companies =
                    {
                        "companies75166514",
                    },
                    LocationFilters =
                    {
                        new LocationFilter
                        {
                            Address = "address04984d88",
                            RegionCode = "region_code72561d46",
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            DistanceInMiles = 6.393700656368388E+17,
                            TelecommutePreference = LocationFilter.Types.TelecommutePreference.Unspecified,
                            Negated = false,
                        },
                    },
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                    CommuteFilter = new CommuteFilter
                    {
                        CommuteMethod = CommuteMethod.Driving,
                        StartCoordinates = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        TravelDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AllowImpreciseAddresses = true,
                        RoadTraffic = CommuteFilter.Types.RoadTraffic.TrafficFree,
                        DepartureTime = new gt::TimeOfDay
                        {
                            Hours = -673329805,
                            Minutes = -858779804,
                            Seconds = 697187960,
                            Nanos = 985689544,
                        },
                    },
                    CompanyDisplayNames =
                    {
                        "company_display_names66095574",
                    },
                    CompensationFilter = new CompensationFilter
                    {
                        Type = CompensationFilter.Types.FilterType.Unspecified,
                        Units =
                        {
                            CompensationInfo.Types.CompensationUnit.OtherCompensationUnit,
                        },
                        Range = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        IncludeJobsWithUnspecifiedCompensationRange = false,
                    },
                    CustomAttributeFilter = "custom_attribute_filter4b4e94a7",
                    DisableSpellCheck = true,
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    LanguageCodes =
                    {
                        "language_codes1de1a181",
                    },
                    PublishTimeRange = new TimestampRange
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
                    },
                    ExcludedJobs =
                    {
                        "excluded_jobs1a4cdb42",
                    },
                    QueryLanguageCode = "query_language_code819ce6b5",
                },
                EnableBroadening = false,
                RequirePreciseResultSize = false,
                HistogramQueries =
                {
                    new HistogramQuery
                    {
                        HistogramQuery_ = "histogram_query515f7e5d",
                    },
                },
                JobView = JobView.Small,
                Offset = 1472300666,
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                OrderBy = "order_byb4d33ada",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Disabled,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo
                {
                    ImportanceLevel = SearchJobsRequest.Types.CustomRankingInfo.Types.ImportanceLevel.Extreme,
                    RankingExpression = "ranking_expression21d1daee",
                },
                DisableKeywordMatch = true,
            };
            SearchJobsResponse expectedResponse = new SearchJobsResponse
            {
                MatchingJobs =
                {
                    new SearchJobsResponse.Types.MatchingJob
                    {
                        Job = new Job
                        {
                            JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                            CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                            RequisitionId = "requisition_id21c2f0af",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Addresses =
                            {
                                "addresses2f3a3e96",
                            },
                            ApplicationInfo = new Job.Types.ApplicationInfo
                            {
                                Emails = { "emails2fca67af", },
                                Instruction = "instructionfa6ecc39",
                                Uris = { "uris9aee097b", },
                            },
                            JobBenefits = { JobBenefit.Dental, },
                            CompensationInfo = new CompensationInfo
                            {
                                Entries =
                                {
                                    new CompensationInfo.Types.CompensationEntry
                                    {
                                        Type = CompensationInfo.Types.CompensationType.Unspecified,
                                        Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                        Amount = new gt::Money
                                        {
                                            CurrencyCode = "currency_code7f81e352",
                                            Units = 1040752433522641849L,
                                            Nanos = 985689544,
                                        },
                                        Range = new CompensationInfo.Types.CompensationRange
                                        {
                                            MinCompensation = new gt::Money
                                            {
                                                CurrencyCode = "currency_code7f81e352",
                                                Units = 1040752433522641849L,
                                                Nanos = 985689544,
                                            },
                                            MaxCompensation = new gt::Money
                                            {
                                                CurrencyCode = "currency_code7f81e352",
                                                Units = 1040752433522641849L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        Description = "description2cf9da67",
                                        ExpectedUnitsPerYear = 4.1649570948025856E+17,
                                    },
                                },
                                AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            CustomAttributes =
                            {
                                {
                                    "key8a0b6e3c",
                                    new CustomAttribute
                                    {
                                        StringValues =
                                        {
                                            "string_valuesc7b5c24c",
                                        },
                                        LongValues =
                                        {
                                            -5952618049634455831L,
                                        },
                                        Filterable = true,
                                    }
                                },
                            },
                            DegreeTypes =
                            {
                                DegreeType.PrimaryEducation,
                            },
                            Department = "departmentca9f9d45",
                            EmploymentTypes =
                            {
                                EmploymentType.OtherEmploymentType,
                            },
                            Incentives = "incentives80814488",
                            LanguageCode = "language_code2f6c7160",
                            JobLevel = JobLevel.Director,
                            PromotionValue = 899484920,
                            Qualifications = "qualifications920abb76",
                            Responsibilities = "responsibilities978e5c9b",
                            PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                            Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                            JobStartTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            JobEndTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingPublishTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingExpireTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingCreateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            CompanyDisplayName = "company_display_name07e5990f",
                            DerivedInfo = new Job.Types.DerivedInfo
                            {
                                Locations =
                                {
                                    new Location
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
                                JobCategories =
                                {
                                    JobCategory.ComputerAndIt,
                                },
                            },
                            ProcessingOptions = new Job.Types.ProcessingOptions
                            {
                                DisableStreetAddressResolution = false,
                                HtmlSanitization = HtmlSanitization.Unspecified,
                            },
                        },
                        JobSummary = "job_summary28184b23",
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        SearchTextSnippet = "search_text_snippet84342ea2",
                        CommuteInfo = new SearchJobsResponse.Types.CommuteInfo
                        {
                            JobLocation = new Location
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
                            TravelDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                },
                HistogramQueryResults =
                {
                    new HistogramQueryResult
                    {
                        HistogramQuery = "histogram_query515f7e5d",
                        Histogram =
                        {
                            {
                                "key8a0b6e3c",
                                -5833447338835614944L
                            },
                        },
                    },
                },
                NextPageToken = "next_page_tokendbee0940",
                LocationFilters =
                {
                    new Location
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
                EstimatedTotalSize = 1828561437,
                TotalSize = 1202968108,
                Metadata = new ResponseMetadata
                {
                    RequestId = "request_id362c8df6",
                },
                BroadenedQueryJobsCount = 2131480093,
                SpellCorrection = new SpellingCorrection
                {
                    Corrected = false,
                    CorrectedText = "corrected_text126e3cb7",
                    CorrectedHtml = "corrected_html5279788d",
                },
            };
            mockGrpcClient.Setup(x => x.SearchJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            SearchJobsResponse response = client.SearchJobs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchJobsRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.FeaturedJobSearch,
                RequestMetadata = new RequestMetadata
                {
                    Domain = "domaine8825fad",
                    SessionId = "session_id54efc87f",
                    UserId = "user_idd41a70e8",
                    AllowMissingIds = true,
                    DeviceInfo = new DeviceInfo
                    {
                        DeviceType = DeviceInfo.Types.DeviceType.Other,
                        Id = "id74b70bb8",
                    },
                },
                JobQuery = new JobQuery
                {
                    Query = "queryf0c71c1b",
                    Companies =
                    {
                        "companies75166514",
                    },
                    LocationFilters =
                    {
                        new LocationFilter
                        {
                            Address = "address04984d88",
                            RegionCode = "region_code72561d46",
                            LatLng = new gt::LatLng
                            {
                                Latitude = 8.158369671878062E+17,
                                Longitude = 8.869183012043108E+17,
                            },
                            DistanceInMiles = 6.393700656368388E+17,
                            TelecommutePreference = LocationFilter.Types.TelecommutePreference.Unspecified,
                            Negated = false,
                        },
                    },
                    JobCategories =
                    {
                        JobCategory.ComputerAndIt,
                    },
                    CommuteFilter = new CommuteFilter
                    {
                        CommuteMethod = CommuteMethod.Driving,
                        StartCoordinates = new gt::LatLng
                        {
                            Latitude = 8.158369671878062E+17,
                            Longitude = 8.869183012043108E+17,
                        },
                        TravelDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        AllowImpreciseAddresses = true,
                        RoadTraffic = CommuteFilter.Types.RoadTraffic.TrafficFree,
                        DepartureTime = new gt::TimeOfDay
                        {
                            Hours = -673329805,
                            Minutes = -858779804,
                            Seconds = 697187960,
                            Nanos = 985689544,
                        },
                    },
                    CompanyDisplayNames =
                    {
                        "company_display_names66095574",
                    },
                    CompensationFilter = new CompensationFilter
                    {
                        Type = CompensationFilter.Types.FilterType.Unspecified,
                        Units =
                        {
                            CompensationInfo.Types.CompensationUnit.OtherCompensationUnit,
                        },
                        Range = new CompensationInfo.Types.CompensationRange
                        {
                            MinCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                            MaxCompensation = new gt::Money
                            {
                                CurrencyCode = "currency_code7f81e352",
                                Units = 1040752433522641849L,
                                Nanos = 985689544,
                            },
                        },
                        IncludeJobsWithUnspecifiedCompensationRange = false,
                    },
                    CustomAttributeFilter = "custom_attribute_filter4b4e94a7",
                    DisableSpellCheck = true,
                    EmploymentTypes =
                    {
                        EmploymentType.OtherEmploymentType,
                    },
                    LanguageCodes =
                    {
                        "language_codes1de1a181",
                    },
                    PublishTimeRange = new TimestampRange
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
                    },
                    ExcludedJobs =
                    {
                        "excluded_jobs1a4cdb42",
                    },
                    QueryLanguageCode = "query_language_code819ce6b5",
                },
                EnableBroadening = false,
                RequirePreciseResultSize = false,
                HistogramQueries =
                {
                    new HistogramQuery
                    {
                        HistogramQuery_ = "histogram_query515f7e5d",
                    },
                },
                JobView = JobView.Small,
                Offset = 1472300666,
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                OrderBy = "order_byb4d33ada",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Disabled,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo
                {
                    ImportanceLevel = SearchJobsRequest.Types.CustomRankingInfo.Types.ImportanceLevel.Extreme,
                    RankingExpression = "ranking_expression21d1daee",
                },
                DisableKeywordMatch = true,
            };
            SearchJobsResponse expectedResponse = new SearchJobsResponse
            {
                MatchingJobs =
                {
                    new SearchJobsResponse.Types.MatchingJob
                    {
                        Job = new Job
                        {
                            JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                            CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                            RequisitionId = "requisition_id21c2f0af",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Addresses =
                            {
                                "addresses2f3a3e96",
                            },
                            ApplicationInfo = new Job.Types.ApplicationInfo
                            {
                                Emails = { "emails2fca67af", },
                                Instruction = "instructionfa6ecc39",
                                Uris = { "uris9aee097b", },
                            },
                            JobBenefits = { JobBenefit.Dental, },
                            CompensationInfo = new CompensationInfo
                            {
                                Entries =
                                {
                                    new CompensationInfo.Types.CompensationEntry
                                    {
                                        Type = CompensationInfo.Types.CompensationType.Unspecified,
                                        Unit = CompensationInfo.Types.CompensationUnit.Daily,
                                        Amount = new gt::Money
                                        {
                                            CurrencyCode = "currency_code7f81e352",
                                            Units = 1040752433522641849L,
                                            Nanos = 985689544,
                                        },
                                        Range = new CompensationInfo.Types.CompensationRange
                                        {
                                            MinCompensation = new gt::Money
                                            {
                                                CurrencyCode = "currency_code7f81e352",
                                                Units = 1040752433522641849L,
                                                Nanos = 985689544,
                                            },
                                            MaxCompensation = new gt::Money
                                            {
                                                CurrencyCode = "currency_code7f81e352",
                                                Units = 1040752433522641849L,
                                                Nanos = 985689544,
                                            },
                                        },
                                        Description = "description2cf9da67",
                                        ExpectedUnitsPerYear = 4.1649570948025856E+17,
                                    },
                                },
                                AnnualizedBaseCompensationRange = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                                AnnualizedTotalCompensationRange = new CompensationInfo.Types.CompensationRange
                                {
                                    MinCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                    MaxCompensation = new gt::Money
                                    {
                                        CurrencyCode = "currency_code7f81e352",
                                        Units = 1040752433522641849L,
                                        Nanos = 985689544,
                                    },
                                },
                            },
                            CustomAttributes =
                            {
                                {
                                    "key8a0b6e3c",
                                    new CustomAttribute
                                    {
                                        StringValues =
                                        {
                                            "string_valuesc7b5c24c",
                                        },
                                        LongValues =
                                        {
                                            -5952618049634455831L,
                                        },
                                        Filterable = true,
                                    }
                                },
                            },
                            DegreeTypes =
                            {
                                DegreeType.PrimaryEducation,
                            },
                            Department = "departmentca9f9d45",
                            EmploymentTypes =
                            {
                                EmploymentType.OtherEmploymentType,
                            },
                            Incentives = "incentives80814488",
                            LanguageCode = "language_code2f6c7160",
                            JobLevel = JobLevel.Director,
                            PromotionValue = 899484920,
                            Qualifications = "qualifications920abb76",
                            Responsibilities = "responsibilities978e5c9b",
                            PostingRegion = PostingRegion.AdministrativeArea,
#pragma warning disable CS0612
                            Visibility = Visibility.SharedWithPublic,
#pragma warning restore CS0612
                            JobStartTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            JobEndTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingPublishTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingExpireTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingCreateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            PostingUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            CompanyDisplayName = "company_display_name07e5990f",
                            DerivedInfo = new Job.Types.DerivedInfo
                            {
                                Locations =
                                {
                                    new Location
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
                                JobCategories =
                                {
                                    JobCategory.ComputerAndIt,
                                },
                            },
                            ProcessingOptions = new Job.Types.ProcessingOptions
                            {
                                DisableStreetAddressResolution = false,
                                HtmlSanitization = HtmlSanitization.Unspecified,
                            },
                        },
                        JobSummary = "job_summary28184b23",
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        SearchTextSnippet = "search_text_snippet84342ea2",
                        CommuteInfo = new SearchJobsResponse.Types.CommuteInfo
                        {
                            JobLocation = new Location
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
                            TravelDuration = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                },
                HistogramQueryResults =
                {
                    new HistogramQueryResult
                    {
                        HistogramQuery = "histogram_query515f7e5d",
                        Histogram =
                        {
                            {
                                "key8a0b6e3c",
                                -5833447338835614944L
                            },
                        },
                    },
                },
                NextPageToken = "next_page_tokendbee0940",
                LocationFilters =
                {
                    new Location
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
                EstimatedTotalSize = 1828561437,
                TotalSize = 1202968108,
                Metadata = new ResponseMetadata
                {
                    RequestId = "request_id362c8df6",
                },
                BroadenedQueryJobsCount = 2131480093,
                SpellCorrection = new SpellingCorrection
                {
                    Corrected = false,
                    CorrectedText = "corrected_text126e3cb7",
                    CorrectedHtml = "corrected_html5279788d",
                },
            };
            mockGrpcClient.Setup(x => x.SearchJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchJobsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            SearchJobsResponse responseCallSettings = await client.SearchJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchJobsResponse responseCancellationToken = await client.SearchJobsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
