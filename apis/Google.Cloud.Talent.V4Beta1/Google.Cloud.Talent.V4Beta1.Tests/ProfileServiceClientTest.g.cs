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

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedProfileServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateProfileRequestObject()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.CreateProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProfileRequestObjectAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.CreateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.CreateProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProfile()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.CreateProfile(request.Parent, request.Profile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProfileAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.CreateProfileAsync(request.Parent, request.Profile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.CreateProfileAsync(request.Parent, request.Profile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProfileResourceNames()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.CreateProfile(request.ParentAsTenantName, request.Profile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProfileResourceNamesAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.CreateProfileAsync(request.ParentAsTenantName, request.Profile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.CreateProfileAsync(request.ParentAsTenantName, request.Profile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProfileRequestObject()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.GetProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProfileRequestObjectAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.GetProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.GetProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProfile()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.GetProfile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProfileAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.GetProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.GetProfileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProfileResourceNames()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.GetProfile(request.ProfileName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProfileResourceNamesAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.GetProfileAsync(request.ProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.GetProfileAsync(request.ProfileName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProfileRequestObject()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.UpdateProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProfileRequestObjectAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.UpdateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.UpdateProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProfile()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.UpdateProfile(request.Profile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProfileAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile
                {
                    ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                    ExternalId = "external_id9442680e",
                    Source = "sourcef438cd36",
                    Uri = "uri3db70593",
                    GroupId = "group_id4f9a930e",
                    IsHirable = true,
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
                    PersonNames =
                    {
                        new PersonName
                        {
                            FormattedName = "formatted_name6368d50a",
                            StructuredName = new PersonName.Types.PersonStructuredName
                            {
                                GivenName = "given_name706d7da1",
                                MiddleInitial = "middle_initialf6fc8a86",
                                FamilyName = "family_nameb77ab71e",
                                Suffixes =
                                {
                                    "suffixes80b61faa",
                                },
                                Prefixes =
                                {
                                    "prefixes89515e73",
                                },
                                PreferredName = "preferred_namef9339d2d",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                    },
                    Addresses =
                    {
                        new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                    },
                    EmailAddresses =
                    {
                        new Email
                        {
                            Usage = ContactInfoUsage.School,
                            EmailAddress = "email_addressf3aae0b5",
                        },
                    },
                    PhoneNumbers =
                    {
                        new Phone
                        {
                            Usage = ContactInfoUsage.School,
                            Type = Phone.Types.PhoneType.TtyOrTdd,
                            Number = "number8a24bcb1",
                            WhenAvailable = "when_availablec58ed10f",
                        },
                    },
                    PersonalUris =
                    {
                        new PersonalUri { Uri = "uri3db70593", },
                    },
                    AdditionalContactInfo =
                    {
                        new AdditionalContactInfo
                        {
                            Usage = ContactInfoUsage.School,
                            Name = "name1c9368b0",
                            ContactId = "contact_id3df1826d",
                        },
                    },
                    EmploymentRecords =
                    {
                        new EmploymentRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EmployerName = "employer_nameed94ebc1",
                            DivisionName = "division_name17c13ed1",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            JobTitle = "job_title1840f829",
                            JobDescription = "job_description71a1e458",
                            IsSupervisor = false,
                            IsSelfEmployed = false,
                            IsCurrent = true,
                            JobTitleSnippet = "job_title_snippet4f14afe7",
                            JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                            EmployerNameSnippet = "employer_name_snippet55ee6685",
                        },
                    },
                    EducationRecords =
                    {
                        new EducationRecord
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpectedGraduationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            SchoolName = "school_namecada2826",
                            Address = new Address
                            {
                                Usage = ContactInfoUsage.School,
                                UnstructuredAddress = "unstructured_address423e5c75",
                                StructuredAddress = new gt::PostalAddress
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
                                Current = true,
                            },
                            DegreeDescription = "degree_descriptionf13cc9aa",
                            StructuredDegree = new Degree
                            {
                                DegreeType = DegreeType.UpperSecondaryEducation,
                                DegreeName = "degree_name1cdb797a",
                                FieldsOfStudy =
                                {
                                    "fields_of_study31142c29",
                                },
                            },
                            Description = "description2cf9da67",
                            IsCurrent = true,
                            SchoolNameSnippet = "school_name_snippetb8367dc1",
                            DegreeSnippet = "degree_snippetef3bb851",
                        },
                    },
                    Skills =
                    {
                        new Skill
                        {
                            DisplayName = "display_name137f65c2",
                            LastUsedDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Level = SkillProficiencyLevel.Unskilled,
                            Context = "context72ef185c",
                            SkillNameSnippet = "skill_name_snippet79b97035",
                        },
                    },
                    Activities =
                    {
                        new Activity
                        {
                            DisplayName = "display_name137f65c2",
                            Description = "description2cf9da67",
                            Uri = "uri3db70593",
                            CreateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            UpdateDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            TeamMembers =
                            {
                                "team_membersf4bf0d8d",
                            },
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            ActivityNameSnippet = "activity_name_snippet2571bd6b",
                            ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                            SkillsUsedSnippet =
                            {
                                "skills_used_snippet3545b1dc",
                            },
                        },
                    },
                    Publications =
                    {
                        new Publication
                        {
                            Authors = { "authorse849945d", },
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Journal = "journalb44191fb",
                            Volume = "volumee7b90a21",
                            Publisher = "publisher16edad52",
                            PublicationDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PublicationType = "publication_typeed243fdb",
                            Isbn = "isbn73119664",
                        },
                    },
                    Patents =
                    {
                        new Patent
                        {
                            DisplayName = "display_name137f65c2",
                            Inventors =
                            {
                                "inventorsacd1d97e",
                            },
                            PatentStatus = "patent_status70adf21c",
                            PatentStatusDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentFilingDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            PatentOffice = "patent_office03472d2a",
                            PatentNumber = "patent_number996d4b3b",
                            PatentDescription = "patent_description06f4e493",
                            SkillsUsed =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                        },
                    },
                    Certifications =
                    {
                        new Certification
                        {
                            DisplayName = "display_name137f65c2",
                            AcquireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            ExpireDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            Authority = "authority0b9c3e87",
                            Description = "description2cf9da67",
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
                    Processed = true,
                    KeywordSnippet = "keyword_snippet7289f6ef",
                    Applications =
                    {
                        "applicationsffa9fbb5",
                    },
                    Assignments =
                    {
                        "assignments2923b317",
                    },
                    Resume = new Resume
                    {
                        StructuredResume = "structured_resume2a115c3e",
                        ResumeType = Resume.Types.ResumeType.Hrxml,
                    },
                    DerivedAddresses =
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
                    CandidateUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResumeUpdateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    AvailabilitySignals =
                    {
                        new AvailabilitySignal
                        {
                            Type = AvailabilitySignalType.Unspecified,
                            LastUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            FilterSatisfied = true,
                        },
                    },
                },
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
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
                PersonNames =
                {
                    new PersonName
                    {
                        FormattedName = "formatted_name6368d50a",
                        StructuredName = new PersonName.Types.PersonStructuredName
                        {
                            GivenName = "given_name706d7da1",
                            MiddleInitial = "middle_initialf6fc8a86",
                            FamilyName = "family_nameb77ab71e",
                            Suffixes =
                            {
                                "suffixes80b61faa",
                            },
                            Prefixes =
                            {
                                "prefixes89515e73",
                            },
                            PreferredName = "preferred_namef9339d2d",
                        },
                        PreferredName = "preferred_namef9339d2d",
                    },
                },
                Addresses =
                {
                    new Address
                    {
                        Usage = ContactInfoUsage.School,
                        UnstructuredAddress = "unstructured_address423e5c75",
                        StructuredAddress = new gt::PostalAddress
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
                        Current = true,
                    },
                },
                EmailAddresses =
                {
                    new Email
                    {
                        Usage = ContactInfoUsage.School,
                        EmailAddress = "email_addressf3aae0b5",
                    },
                },
                PhoneNumbers =
                {
                    new Phone
                    {
                        Usage = ContactInfoUsage.School,
                        Type = Phone.Types.PhoneType.TtyOrTdd,
                        Number = "number8a24bcb1",
                        WhenAvailable = "when_availablec58ed10f",
                    },
                },
                PersonalUris =
                {
                    new PersonalUri { Uri = "uri3db70593", },
                },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo
                    {
                        Usage = ContactInfoUsage.School,
                        Name = "name1c9368b0",
                        ContactId = "contact_id3df1826d",
                    },
                },
                EmploymentRecords =
                {
                    new EmploymentRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EmployerName = "employer_nameed94ebc1",
                        DivisionName = "division_name17c13ed1",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        JobTitle = "job_title1840f829",
                        JobDescription = "job_description71a1e458",
                        IsSupervisor = false,
                        IsSelfEmployed = false,
                        IsCurrent = true,
                        JobTitleSnippet = "job_title_snippet4f14afe7",
                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                    },
                },
                EducationRecords =
                {
                    new EducationRecord
                    {
                        StartDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        EndDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpectedGraduationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        SchoolName = "school_namecada2826",
                        Address = new Address
                        {
                            Usage = ContactInfoUsage.School,
                            UnstructuredAddress = "unstructured_address423e5c75",
                            StructuredAddress = new gt::PostalAddress
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
                            Current = true,
                        },
                        DegreeDescription = "degree_descriptionf13cc9aa",
                        StructuredDegree = new Degree
                        {
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            DegreeName = "degree_name1cdb797a",
                            FieldsOfStudy =
                            {
                                "fields_of_study31142c29",
                            },
                        },
                        Description = "description2cf9da67",
                        IsCurrent = true,
                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                        DegreeSnippet = "degree_snippetef3bb851",
                    },
                },
                Skills =
                {
                    new Skill
                    {
                        DisplayName = "display_name137f65c2",
                        LastUsedDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Level = SkillProficiencyLevel.Unskilled,
                        Context = "context72ef185c",
                        SkillNameSnippet = "skill_name_snippet79b97035",
                    },
                },
                Activities =
                {
                    new Activity
                    {
                        DisplayName = "display_name137f65c2",
                        Description = "description2cf9da67",
                        Uri = "uri3db70593",
                        CreateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        UpdateDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        TeamMembers =
                        {
                            "team_membersf4bf0d8d",
                        },
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                        SkillsUsedSnippet =
                        {
                            "skills_used_snippet3545b1dc",
                        },
                    },
                },
                Publications =
                {
                    new Publication
                    {
                        Authors = { "authorse849945d", },
                        Title = "title17dbd3d5",
                        Description = "description2cf9da67",
                        Journal = "journalb44191fb",
                        Volume = "volumee7b90a21",
                        Publisher = "publisher16edad52",
                        PublicationDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PublicationType = "publication_typeed243fdb",
                        Isbn = "isbn73119664",
                    },
                },
                Patents =
                {
                    new Patent
                    {
                        DisplayName = "display_name137f65c2",
                        Inventors =
                        {
                            "inventorsacd1d97e",
                        },
                        PatentStatus = "patent_status70adf21c",
                        PatentStatusDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentFilingDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        PatentOffice = "patent_office03472d2a",
                        PatentNumber = "patent_number996d4b3b",
                        PatentDescription = "patent_description06f4e493",
                        SkillsUsed =
                        {
                            new Skill
                            {
                                DisplayName = "display_name137f65c2",
                                LastUsedDate = new gt::Date
                                {
                                    Year = 1825033604,
                                    Month = 1123628660,
                                    Day = -1333949598,
                                },
                                Level = SkillProficiencyLevel.Unskilled,
                                Context = "context72ef185c",
                                SkillNameSnippet = "skill_name_snippet79b97035",
                            },
                        },
                    },
                },
                Certifications =
                {
                    new Certification
                    {
                        DisplayName = "display_name137f65c2",
                        AcquireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        ExpireDate = new gt::Date
                        {
                            Year = 1825033604,
                            Month = 1123628660,
                            Day = -1333949598,
                        },
                        Authority = "authority0b9c3e87",
                        Description = "description2cf9da67",
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
                Processed = true,
                KeywordSnippet = "keyword_snippet7289f6ef",
                Applications =
                {
                    "applicationsffa9fbb5",
                },
                Assignments =
                {
                    "assignments2923b317",
                },
                Resume = new Resume
                {
                    StructuredResume = "structured_resume2a115c3e",
                    ResumeType = Resume.Types.ResumeType.Hrxml,
                },
                DerivedAddresses =
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
                CandidateUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ResumeUpdateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                AvailabilitySignals =
                {
                    new AvailabilitySignal
                    {
                        Type = AvailabilitySignalType.Unspecified,
                        LastUpdateTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        FilterSatisfied = true,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile responseCallSettings = await client.UpdateProfileAsync(request.Profile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.UpdateProfileAsync(request.Profile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProfileRequestObject()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteProfile(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProfileRequestObjectAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProfileAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProfile()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteProfile(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProfileAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProfileAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProfileResourceNames()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteProfile(request.ProfileName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteProfileResourceNamesAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteProfileAsync(request.ProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteProfileAsync(request.ProfileName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchProfilesRequestObject()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            SearchProfilesRequest request = new SearchProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
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
                ProfileQuery = new ProfileQuery
                {
                    Query = "queryf0c71c1b",
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
                    JobTitleFilters =
                    {
                        new JobTitleFilter
                        {
                            JobTitle = "job_title1840f829",
                            Negated = false,
                        },
                    },
                    EmployerFilters =
                    {
                        new EmployerFilter
                        {
                            Employer = "employer1277c6ed",
                            Mode = EmployerFilter.Types.EmployerFilterMode.AllEmploymentRecords,
                            Negated = false,
                        },
                    },
                    EducationFilters =
                    {
                        new EducationFilter
                        {
                            School = "schoolb3c31675",
                            FieldOfStudy = "field_of_studyfef18f84",
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            Negated = false,
                        },
                    },
                    SkillFilters =
                    {
                        new SkillFilter
                        {
                            Skill = "skilld0d43d71",
                            Negated = false,
                        },
                    },
                    WorkExperienceFilter =
                    {
                        new WorkExperienceFilter
                        {
                            MinExperience = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            MaxExperience = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    TimeFilters =
                    {
                        new TimeFilter
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
                            TimeField = TimeFilter.Types.TimeField.Unspecified,
                        },
                    },
                    HirableFilter = false,
                    ApplicationDateFilters =
                    {
                        new ApplicationDateFilter
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                        },
                    },
                    ApplicationOutcomeNotesFilters =
                    {
                        new ApplicationOutcomeNotesFilter
                        {
                            OutcomeNotes = "outcome_notes38ed921d",
                            Negated = false,
                        },
                    },
                    ApplicationJobFilters =
                    {
                        new ApplicationJobFilter
                        {
                            JobRequisitionId = "job_requisition_id46c75cf1",
                            JobTitle = "job_title1840f829",
                            Negated = false,
                        },
                    },
                    CustomAttributeFilter = "custom_attribute_filter4b4e94a7",
#pragma warning disable CS0612
                    CandidateAvailabilityFilter = new CandidateAvailabilityFilter { Negated = false, },
#pragma warning restore CS0612
                    PersonNameFilters =
                    {
                        new PersonNameFilter
                        {
                            PersonName = "person_name40c7ac69",
                        },
                    },
                    AvailabilityFilters =
                    {
                        new AvailabilityFilter
                        {
                            SignalType = AvailabilitySignalType.CandidateUpdate,
                            Range = new TimestampRange
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
                            Required = false,
                        },
                    },
                },
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                Offset = 1472300666,
                DisableSpellCheck = true,
                OrderBy = "order_byb4d33ada",
                CaseSensitiveSort = true,
                HistogramQueries =
                {
                    new HistogramQuery
                    {
                        HistogramQuery_ = "histogram_query515f7e5d",
                    },
                },
                ResultSetId = "result_set_id6cf58a14",
                StrictKeywordsSearch = true,
            };
            SearchProfilesResponse expectedResponse = new SearchProfilesResponse
            {
                EstimatedTotalSize = 5269174732212511261L,
                SpellCorrection = new SpellingCorrection
                {
                    Corrected = false,
                    CorrectedText = "corrected_text126e3cb7",
                    CorrectedHtml = "corrected_html5279788d",
                },
                Metadata = new ResponseMetadata
                {
                    RequestId = "request_id362c8df6",
                },
                NextPageToken = "next_page_tokendbee0940",
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
                SummarizedProfiles =
                {
                    new SummarizedProfile
                    {
                        Profiles =
                        {
                            new Profile
                            {
                                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                                ExternalId = "external_id9442680e",
                                Source = "sourcef438cd36",
                                Uri = "uri3db70593",
                                GroupId = "group_id4f9a930e",
                                IsHirable = true,
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
                                PersonNames =
                                {
                                    new PersonName
                                    {
                                        FormattedName = "formatted_name6368d50a",
                                        StructuredName = new PersonName.Types.PersonStructuredName
                                        {
                                            GivenName = "given_name706d7da1",
                                            MiddleInitial = "middle_initialf6fc8a86",
                                            FamilyName = "family_nameb77ab71e",
                                            Suffixes =
                                            {
                                                "suffixes80b61faa",
                                            },
                                            Prefixes =
                                            {
                                                "prefixes89515e73",
                                            },
                                            PreferredName = "preferred_namef9339d2d",
                                        },
                                        PreferredName = "preferred_namef9339d2d",
                                    },
                                },
                                Addresses =
                                {
                                    new Address
                                    {
                                        Usage = ContactInfoUsage.School,
                                        UnstructuredAddress = "unstructured_address423e5c75",
                                        StructuredAddress = new gt::PostalAddress
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
                                        Current = true,
                                    },
                                },
                                EmailAddresses =
                                {
                                    new Email
                                    {
                                        Usage = ContactInfoUsage.School,
                                        EmailAddress = "email_addressf3aae0b5",
                                    },
                                },
                                PhoneNumbers =
                                {
                                    new Phone
                                    {
                                        Usage = ContactInfoUsage.School,
                                        Type = Phone.Types.PhoneType.TtyOrTdd,
                                        Number = "number8a24bcb1",
                                        WhenAvailable = "when_availablec58ed10f",
                                    },
                                },
                                PersonalUris =
                                {
                                    new PersonalUri { Uri = "uri3db70593", },
                                },
                                AdditionalContactInfo =
                                {
                                    new AdditionalContactInfo
                                    {
                                        Usage = ContactInfoUsage.School,
                                        Name = "name1c9368b0",
                                        ContactId = "contact_id3df1826d",
                                    },
                                },
                                EmploymentRecords =
                                {
                                    new EmploymentRecord
                                    {
                                        StartDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        EndDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        EmployerName = "employer_nameed94ebc1",
                                        DivisionName = "division_name17c13ed1",
                                        Address = new Address
                                        {
                                            Usage = ContactInfoUsage.School,
                                            UnstructuredAddress = "unstructured_address423e5c75",
                                            StructuredAddress = new gt::PostalAddress
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
                                            Current = true,
                                        },
                                        JobTitle = "job_title1840f829",
                                        JobDescription = "job_description71a1e458",
                                        IsSupervisor = false,
                                        IsSelfEmployed = false,
                                        IsCurrent = true,
                                        JobTitleSnippet = "job_title_snippet4f14afe7",
                                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                                    },
                                },
                                EducationRecords =
                                {
                                    new EducationRecord
                                    {
                                        StartDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        EndDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        ExpectedGraduationDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        SchoolName = "school_namecada2826",
                                        Address = new Address
                                        {
                                            Usage = ContactInfoUsage.School,
                                            UnstructuredAddress = "unstructured_address423e5c75",
                                            StructuredAddress = new gt::PostalAddress
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
                                            Current = true,
                                        },
                                        DegreeDescription = "degree_descriptionf13cc9aa",
                                        StructuredDegree = new Degree
                                        {
                                            DegreeType = DegreeType.UpperSecondaryEducation,
                                            DegreeName = "degree_name1cdb797a",
                                            FieldsOfStudy =
                                            {
                                                "fields_of_study31142c29",
                                            },
                                        },
                                        Description = "description2cf9da67",
                                        IsCurrent = true,
                                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                                        DegreeSnippet = "degree_snippetef3bb851",
                                    },
                                },
                                Skills =
                                {
                                    new Skill
                                    {
                                        DisplayName = "display_name137f65c2",
                                        LastUsedDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        Level = SkillProficiencyLevel.Unskilled,
                                        Context = "context72ef185c",
                                        SkillNameSnippet = "skill_name_snippet79b97035",
                                    },
                                },
                                Activities =
                                {
                                    new Activity
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                        Uri = "uri3db70593",
                                        CreateDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        UpdateDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        TeamMembers =
                                        {
                                            "team_membersf4bf0d8d",
                                        },
                                        SkillsUsed =
                                        {
                                            new Skill
                                            {
                                                DisplayName = "display_name137f65c2",
                                                LastUsedDate = new gt::Date
                                                {
                                                    Year = 1825033604,
                                                    Month = 1123628660,
                                                    Day = -1333949598,
                                                },
                                                Level = SkillProficiencyLevel.Unskilled,
                                                Context = "context72ef185c",
                                                SkillNameSnippet = "skill_name_snippet79b97035",
                                            },
                                        },
                                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                                        SkillsUsedSnippet =
                                        {
                                            "skills_used_snippet3545b1dc",
                                        },
                                    },
                                },
                                Publications =
                                {
                                    new Publication
                                    {
                                        Authors = { "authorse849945d", },
                                        Title = "title17dbd3d5",
                                        Description = "description2cf9da67",
                                        Journal = "journalb44191fb",
                                        Volume = "volumee7b90a21",
                                        Publisher = "publisher16edad52",
                                        PublicationDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        PublicationType = "publication_typeed243fdb",
                                        Isbn = "isbn73119664",
                                    },
                                },
                                Patents =
                                {
                                    new Patent
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Inventors =
                                        {
                                            "inventorsacd1d97e",
                                        },
                                        PatentStatus = "patent_status70adf21c",
                                        PatentStatusDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        PatentFilingDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        PatentOffice = "patent_office03472d2a",
                                        PatentNumber = "patent_number996d4b3b",
                                        PatentDescription = "patent_description06f4e493",
                                        SkillsUsed =
                                        {
                                            new Skill
                                            {
                                                DisplayName = "display_name137f65c2",
                                                LastUsedDate = new gt::Date
                                                {
                                                    Year = 1825033604,
                                                    Month = 1123628660,
                                                    Day = -1333949598,
                                                },
                                                Level = SkillProficiencyLevel.Unskilled,
                                                Context = "context72ef185c",
                                                SkillNameSnippet = "skill_name_snippet79b97035",
                                            },
                                        },
                                    },
                                },
                                Certifications =
                                {
                                    new Certification
                                    {
                                        DisplayName = "display_name137f65c2",
                                        AcquireDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        ExpireDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        Authority = "authority0b9c3e87",
                                        Description = "description2cf9da67",
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
                                Processed = true,
                                KeywordSnippet = "keyword_snippet7289f6ef",
                                Applications =
                                {
                                    "applicationsffa9fbb5",
                                },
                                Assignments =
                                {
                                    "assignments2923b317",
                                },
                                Resume = new Resume
                                {
                                    StructuredResume = "structured_resume2a115c3e",
                                    ResumeType = Resume.Types.ResumeType.Hrxml,
                                },
                                DerivedAddresses =
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
                                CandidateUpdateTime = new wkt::Timestamp
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                ResumeUpdateTime = new wkt::Timestamp
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                AvailabilitySignals =
                                {
                                    new AvailabilitySignal
                                    {
                                        Type = AvailabilitySignalType.Unspecified,
                                        LastUpdateTime = new wkt::Timestamp
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        FilterSatisfied = true,
                                    },
                                },
                            },
                        },
                        Summary = new Profile
                        {
                            ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                            ExternalId = "external_id9442680e",
                            Source = "sourcef438cd36",
                            Uri = "uri3db70593",
                            GroupId = "group_id4f9a930e",
                            IsHirable = true,
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
                            PersonNames =
                            {
                                new PersonName
                                {
                                    FormattedName = "formatted_name6368d50a",
                                    StructuredName = new PersonName.Types.PersonStructuredName
                                    {
                                        GivenName = "given_name706d7da1",
                                        MiddleInitial = "middle_initialf6fc8a86",
                                        FamilyName = "family_nameb77ab71e",
                                        Suffixes =
                                        {
                                            "suffixes80b61faa",
                                        },
                                        Prefixes =
                                        {
                                            "prefixes89515e73",
                                        },
                                        PreferredName = "preferred_namef9339d2d",
                                    },
                                    PreferredName = "preferred_namef9339d2d",
                                },
                            },
                            Addresses =
                            {
                                new Address
                                {
                                    Usage = ContactInfoUsage.School,
                                    UnstructuredAddress = "unstructured_address423e5c75",
                                    StructuredAddress = new gt::PostalAddress
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
                                    Current = true,
                                },
                            },
                            EmailAddresses =
                            {
                                new Email
                                {
                                    Usage = ContactInfoUsage.School,
                                    EmailAddress = "email_addressf3aae0b5",
                                },
                            },
                            PhoneNumbers =
                            {
                                new Phone
                                {
                                    Usage = ContactInfoUsage.School,
                                    Type = Phone.Types.PhoneType.TtyOrTdd,
                                    Number = "number8a24bcb1",
                                    WhenAvailable = "when_availablec58ed10f",
                                },
                            },
                            PersonalUris =
                            {
                                new PersonalUri { Uri = "uri3db70593", },
                            },
                            AdditionalContactInfo =
                            {
                                new AdditionalContactInfo
                                {
                                    Usage = ContactInfoUsage.School,
                                    Name = "name1c9368b0",
                                    ContactId = "contact_id3df1826d",
                                },
                            },
                            EmploymentRecords =
                            {
                                new EmploymentRecord
                                {
                                    StartDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    EndDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    EmployerName = "employer_nameed94ebc1",
                                    DivisionName = "division_name17c13ed1",
                                    Address = new Address
                                    {
                                        Usage = ContactInfoUsage.School,
                                        UnstructuredAddress = "unstructured_address423e5c75",
                                        StructuredAddress = new gt::PostalAddress
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
                                        Current = true,
                                    },
                                    JobTitle = "job_title1840f829",
                                    JobDescription = "job_description71a1e458",
                                    IsSupervisor = false,
                                    IsSelfEmployed = false,
                                    IsCurrent = true,
                                    JobTitleSnippet = "job_title_snippet4f14afe7",
                                    JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                                    EmployerNameSnippet = "employer_name_snippet55ee6685",
                                },
                            },
                            EducationRecords =
                            {
                                new EducationRecord
                                {
                                    StartDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    EndDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    ExpectedGraduationDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    SchoolName = "school_namecada2826",
                                    Address = new Address
                                    {
                                        Usage = ContactInfoUsage.School,
                                        UnstructuredAddress = "unstructured_address423e5c75",
                                        StructuredAddress = new gt::PostalAddress
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
                                        Current = true,
                                    },
                                    DegreeDescription = "degree_descriptionf13cc9aa",
                                    StructuredDegree = new Degree
                                    {
                                        DegreeType = DegreeType.UpperSecondaryEducation,
                                        DegreeName = "degree_name1cdb797a",
                                        FieldsOfStudy =
                                        {
                                            "fields_of_study31142c29",
                                        },
                                    },
                                    Description = "description2cf9da67",
                                    IsCurrent = true,
                                    SchoolNameSnippet = "school_name_snippetb8367dc1",
                                    DegreeSnippet = "degree_snippetef3bb851",
                                },
                            },
                            Skills =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            Activities =
                            {
                                new Activity
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                    Uri = "uri3db70593",
                                    CreateDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    UpdateDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    TeamMembers =
                                    {
                                        "team_membersf4bf0d8d",
                                    },
                                    SkillsUsed =
                                    {
                                        new Skill
                                        {
                                            DisplayName = "display_name137f65c2",
                                            LastUsedDate = new gt::Date
                                            {
                                                Year = 1825033604,
                                                Month = 1123628660,
                                                Day = -1333949598,
                                            },
                                            Level = SkillProficiencyLevel.Unskilled,
                                            Context = "context72ef185c",
                                            SkillNameSnippet = "skill_name_snippet79b97035",
                                        },
                                    },
                                    ActivityNameSnippet = "activity_name_snippet2571bd6b",
                                    ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                                    SkillsUsedSnippet =
                                    {
                                        "skills_used_snippet3545b1dc",
                                    },
                                },
                            },
                            Publications =
                            {
                                new Publication
                                {
                                    Authors = { "authorse849945d", },
                                    Title = "title17dbd3d5",
                                    Description = "description2cf9da67",
                                    Journal = "journalb44191fb",
                                    Volume = "volumee7b90a21",
                                    Publisher = "publisher16edad52",
                                    PublicationDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    PublicationType = "publication_typeed243fdb",
                                    Isbn = "isbn73119664",
                                },
                            },
                            Patents =
                            {
                                new Patent
                                {
                                    DisplayName = "display_name137f65c2",
                                    Inventors =
                                    {
                                        "inventorsacd1d97e",
                                    },
                                    PatentStatus = "patent_status70adf21c",
                                    PatentStatusDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    PatentFilingDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    PatentOffice = "patent_office03472d2a",
                                    PatentNumber = "patent_number996d4b3b",
                                    PatentDescription = "patent_description06f4e493",
                                    SkillsUsed =
                                    {
                                        new Skill
                                        {
                                            DisplayName = "display_name137f65c2",
                                            LastUsedDate = new gt::Date
                                            {
                                                Year = 1825033604,
                                                Month = 1123628660,
                                                Day = -1333949598,
                                            },
                                            Level = SkillProficiencyLevel.Unskilled,
                                            Context = "context72ef185c",
                                            SkillNameSnippet = "skill_name_snippet79b97035",
                                        },
                                    },
                                },
                            },
                            Certifications =
                            {
                                new Certification
                                {
                                    DisplayName = "display_name137f65c2",
                                    AcquireDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    ExpireDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Authority = "authority0b9c3e87",
                                    Description = "description2cf9da67",
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
                            Processed = true,
                            KeywordSnippet = "keyword_snippet7289f6ef",
                            Applications =
                            {
                                "applicationsffa9fbb5",
                            },
                            Assignments =
                            {
                                "assignments2923b317",
                            },
                            Resume = new Resume
                            {
                                StructuredResume = "structured_resume2a115c3e",
                                ResumeType = Resume.Types.ResumeType.Hrxml,
                            },
                            DerivedAddresses =
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
                            CandidateUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ResumeUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            AvailabilitySignals =
                            {
                                new AvailabilitySignal
                                {
                                    Type = AvailabilitySignalType.Unspecified,
                                    LastUpdateTime = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    FilterSatisfied = true,
                                },
                            },
                        },
                    },
                },
                ResultSetId = "result_set_id6cf58a14",
            };
            mockGrpcClient.Setup(x => x.SearchProfiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            SearchProfilesResponse response = client.SearchProfiles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchProfilesRequestObjectAsync()
        {
            moq::Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new moq::Mock<ProfileService.ProfileServiceClient>(moq::MockBehavior.Strict);
            SearchProfilesRequest request = new SearchProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
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
                ProfileQuery = new ProfileQuery
                {
                    Query = "queryf0c71c1b",
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
                    JobTitleFilters =
                    {
                        new JobTitleFilter
                        {
                            JobTitle = "job_title1840f829",
                            Negated = false,
                        },
                    },
                    EmployerFilters =
                    {
                        new EmployerFilter
                        {
                            Employer = "employer1277c6ed",
                            Mode = EmployerFilter.Types.EmployerFilterMode.AllEmploymentRecords,
                            Negated = false,
                        },
                    },
                    EducationFilters =
                    {
                        new EducationFilter
                        {
                            School = "schoolb3c31675",
                            FieldOfStudy = "field_of_studyfef18f84",
                            DegreeType = DegreeType.UpperSecondaryEducation,
                            Negated = false,
                        },
                    },
                    SkillFilters =
                    {
                        new SkillFilter
                        {
                            Skill = "skilld0d43d71",
                            Negated = false,
                        },
                    },
                    WorkExperienceFilter =
                    {
                        new WorkExperienceFilter
                        {
                            MinExperience = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            MaxExperience = new wkt::Duration
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                        },
                    },
                    TimeFilters =
                    {
                        new TimeFilter
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
                            TimeField = TimeFilter.Types.TimeField.Unspecified,
                        },
                    },
                    HirableFilter = false,
                    ApplicationDateFilters =
                    {
                        new ApplicationDateFilter
                        {
                            StartDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                            EndDate = new gt::Date
                            {
                                Year = 1825033604,
                                Month = 1123628660,
                                Day = -1333949598,
                            },
                        },
                    },
                    ApplicationOutcomeNotesFilters =
                    {
                        new ApplicationOutcomeNotesFilter
                        {
                            OutcomeNotes = "outcome_notes38ed921d",
                            Negated = false,
                        },
                    },
                    ApplicationJobFilters =
                    {
                        new ApplicationJobFilter
                        {
                            JobRequisitionId = "job_requisition_id46c75cf1",
                            JobTitle = "job_title1840f829",
                            Negated = false,
                        },
                    },
                    CustomAttributeFilter = "custom_attribute_filter4b4e94a7",
#pragma warning disable CS0612
                    CandidateAvailabilityFilter = new CandidateAvailabilityFilter { Negated = false, },
#pragma warning restore CS0612
                    PersonNameFilters =
                    {
                        new PersonNameFilter
                        {
                            PersonName = "person_name40c7ac69",
                        },
                    },
                    AvailabilityFilters =
                    {
                        new AvailabilityFilter
                        {
                            SignalType = AvailabilitySignalType.CandidateUpdate,
                            Range = new TimestampRange
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
                            Required = false,
                        },
                    },
                },
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                Offset = 1472300666,
                DisableSpellCheck = true,
                OrderBy = "order_byb4d33ada",
                CaseSensitiveSort = true,
                HistogramQueries =
                {
                    new HistogramQuery
                    {
                        HistogramQuery_ = "histogram_query515f7e5d",
                    },
                },
                ResultSetId = "result_set_id6cf58a14",
                StrictKeywordsSearch = true,
            };
            SearchProfilesResponse expectedResponse = new SearchProfilesResponse
            {
                EstimatedTotalSize = 5269174732212511261L,
                SpellCorrection = new SpellingCorrection
                {
                    Corrected = false,
                    CorrectedText = "corrected_text126e3cb7",
                    CorrectedHtml = "corrected_html5279788d",
                },
                Metadata = new ResponseMetadata
                {
                    RequestId = "request_id362c8df6",
                },
                NextPageToken = "next_page_tokendbee0940",
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
                SummarizedProfiles =
                {
                    new SummarizedProfile
                    {
                        Profiles =
                        {
                            new Profile
                            {
                                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                                ExternalId = "external_id9442680e",
                                Source = "sourcef438cd36",
                                Uri = "uri3db70593",
                                GroupId = "group_id4f9a930e",
                                IsHirable = true,
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
                                PersonNames =
                                {
                                    new PersonName
                                    {
                                        FormattedName = "formatted_name6368d50a",
                                        StructuredName = new PersonName.Types.PersonStructuredName
                                        {
                                            GivenName = "given_name706d7da1",
                                            MiddleInitial = "middle_initialf6fc8a86",
                                            FamilyName = "family_nameb77ab71e",
                                            Suffixes =
                                            {
                                                "suffixes80b61faa",
                                            },
                                            Prefixes =
                                            {
                                                "prefixes89515e73",
                                            },
                                            PreferredName = "preferred_namef9339d2d",
                                        },
                                        PreferredName = "preferred_namef9339d2d",
                                    },
                                },
                                Addresses =
                                {
                                    new Address
                                    {
                                        Usage = ContactInfoUsage.School,
                                        UnstructuredAddress = "unstructured_address423e5c75",
                                        StructuredAddress = new gt::PostalAddress
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
                                        Current = true,
                                    },
                                },
                                EmailAddresses =
                                {
                                    new Email
                                    {
                                        Usage = ContactInfoUsage.School,
                                        EmailAddress = "email_addressf3aae0b5",
                                    },
                                },
                                PhoneNumbers =
                                {
                                    new Phone
                                    {
                                        Usage = ContactInfoUsage.School,
                                        Type = Phone.Types.PhoneType.TtyOrTdd,
                                        Number = "number8a24bcb1",
                                        WhenAvailable = "when_availablec58ed10f",
                                    },
                                },
                                PersonalUris =
                                {
                                    new PersonalUri { Uri = "uri3db70593", },
                                },
                                AdditionalContactInfo =
                                {
                                    new AdditionalContactInfo
                                    {
                                        Usage = ContactInfoUsage.School,
                                        Name = "name1c9368b0",
                                        ContactId = "contact_id3df1826d",
                                    },
                                },
                                EmploymentRecords =
                                {
                                    new EmploymentRecord
                                    {
                                        StartDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        EndDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        EmployerName = "employer_nameed94ebc1",
                                        DivisionName = "division_name17c13ed1",
                                        Address = new Address
                                        {
                                            Usage = ContactInfoUsage.School,
                                            UnstructuredAddress = "unstructured_address423e5c75",
                                            StructuredAddress = new gt::PostalAddress
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
                                            Current = true,
                                        },
                                        JobTitle = "job_title1840f829",
                                        JobDescription = "job_description71a1e458",
                                        IsSupervisor = false,
                                        IsSelfEmployed = false,
                                        IsCurrent = true,
                                        JobTitleSnippet = "job_title_snippet4f14afe7",
                                        JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                                        EmployerNameSnippet = "employer_name_snippet55ee6685",
                                    },
                                },
                                EducationRecords =
                                {
                                    new EducationRecord
                                    {
                                        StartDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        EndDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        ExpectedGraduationDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        SchoolName = "school_namecada2826",
                                        Address = new Address
                                        {
                                            Usage = ContactInfoUsage.School,
                                            UnstructuredAddress = "unstructured_address423e5c75",
                                            StructuredAddress = new gt::PostalAddress
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
                                            Current = true,
                                        },
                                        DegreeDescription = "degree_descriptionf13cc9aa",
                                        StructuredDegree = new Degree
                                        {
                                            DegreeType = DegreeType.UpperSecondaryEducation,
                                            DegreeName = "degree_name1cdb797a",
                                            FieldsOfStudy =
                                            {
                                                "fields_of_study31142c29",
                                            },
                                        },
                                        Description = "description2cf9da67",
                                        IsCurrent = true,
                                        SchoolNameSnippet = "school_name_snippetb8367dc1",
                                        DegreeSnippet = "degree_snippetef3bb851",
                                    },
                                },
                                Skills =
                                {
                                    new Skill
                                    {
                                        DisplayName = "display_name137f65c2",
                                        LastUsedDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        Level = SkillProficiencyLevel.Unskilled,
                                        Context = "context72ef185c",
                                        SkillNameSnippet = "skill_name_snippet79b97035",
                                    },
                                },
                                Activities =
                                {
                                    new Activity
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                        Uri = "uri3db70593",
                                        CreateDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        UpdateDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        TeamMembers =
                                        {
                                            "team_membersf4bf0d8d",
                                        },
                                        SkillsUsed =
                                        {
                                            new Skill
                                            {
                                                DisplayName = "display_name137f65c2",
                                                LastUsedDate = new gt::Date
                                                {
                                                    Year = 1825033604,
                                                    Month = 1123628660,
                                                    Day = -1333949598,
                                                },
                                                Level = SkillProficiencyLevel.Unskilled,
                                                Context = "context72ef185c",
                                                SkillNameSnippet = "skill_name_snippet79b97035",
                                            },
                                        },
                                        ActivityNameSnippet = "activity_name_snippet2571bd6b",
                                        ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                                        SkillsUsedSnippet =
                                        {
                                            "skills_used_snippet3545b1dc",
                                        },
                                    },
                                },
                                Publications =
                                {
                                    new Publication
                                    {
                                        Authors = { "authorse849945d", },
                                        Title = "title17dbd3d5",
                                        Description = "description2cf9da67",
                                        Journal = "journalb44191fb",
                                        Volume = "volumee7b90a21",
                                        Publisher = "publisher16edad52",
                                        PublicationDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        PublicationType = "publication_typeed243fdb",
                                        Isbn = "isbn73119664",
                                    },
                                },
                                Patents =
                                {
                                    new Patent
                                    {
                                        DisplayName = "display_name137f65c2",
                                        Inventors =
                                        {
                                            "inventorsacd1d97e",
                                        },
                                        PatentStatus = "patent_status70adf21c",
                                        PatentStatusDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        PatentFilingDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        PatentOffice = "patent_office03472d2a",
                                        PatentNumber = "patent_number996d4b3b",
                                        PatentDescription = "patent_description06f4e493",
                                        SkillsUsed =
                                        {
                                            new Skill
                                            {
                                                DisplayName = "display_name137f65c2",
                                                LastUsedDate = new gt::Date
                                                {
                                                    Year = 1825033604,
                                                    Month = 1123628660,
                                                    Day = -1333949598,
                                                },
                                                Level = SkillProficiencyLevel.Unskilled,
                                                Context = "context72ef185c",
                                                SkillNameSnippet = "skill_name_snippet79b97035",
                                            },
                                        },
                                    },
                                },
                                Certifications =
                                {
                                    new Certification
                                    {
                                        DisplayName = "display_name137f65c2",
                                        AcquireDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        ExpireDate = new gt::Date
                                        {
                                            Year = 1825033604,
                                            Month = 1123628660,
                                            Day = -1333949598,
                                        },
                                        Authority = "authority0b9c3e87",
                                        Description = "description2cf9da67",
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
                                Processed = true,
                                KeywordSnippet = "keyword_snippet7289f6ef",
                                Applications =
                                {
                                    "applicationsffa9fbb5",
                                },
                                Assignments =
                                {
                                    "assignments2923b317",
                                },
                                Resume = new Resume
                                {
                                    StructuredResume = "structured_resume2a115c3e",
                                    ResumeType = Resume.Types.ResumeType.Hrxml,
                                },
                                DerivedAddresses =
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
                                CandidateUpdateTime = new wkt::Timestamp
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                ResumeUpdateTime = new wkt::Timestamp
                                {
                                    Seconds = -2106654494186127752L,
                                    Nanos = 985689544,
                                },
                                AvailabilitySignals =
                                {
                                    new AvailabilitySignal
                                    {
                                        Type = AvailabilitySignalType.Unspecified,
                                        LastUpdateTime = new wkt::Timestamp
                                        {
                                            Seconds = -2106654494186127752L,
                                            Nanos = 985689544,
                                        },
                                        FilterSatisfied = true,
                                    },
                                },
                            },
                        },
                        Summary = new Profile
                        {
                            ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                            ExternalId = "external_id9442680e",
                            Source = "sourcef438cd36",
                            Uri = "uri3db70593",
                            GroupId = "group_id4f9a930e",
                            IsHirable = true,
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
                            PersonNames =
                            {
                                new PersonName
                                {
                                    FormattedName = "formatted_name6368d50a",
                                    StructuredName = new PersonName.Types.PersonStructuredName
                                    {
                                        GivenName = "given_name706d7da1",
                                        MiddleInitial = "middle_initialf6fc8a86",
                                        FamilyName = "family_nameb77ab71e",
                                        Suffixes =
                                        {
                                            "suffixes80b61faa",
                                        },
                                        Prefixes =
                                        {
                                            "prefixes89515e73",
                                        },
                                        PreferredName = "preferred_namef9339d2d",
                                    },
                                    PreferredName = "preferred_namef9339d2d",
                                },
                            },
                            Addresses =
                            {
                                new Address
                                {
                                    Usage = ContactInfoUsage.School,
                                    UnstructuredAddress = "unstructured_address423e5c75",
                                    StructuredAddress = new gt::PostalAddress
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
                                    Current = true,
                                },
                            },
                            EmailAddresses =
                            {
                                new Email
                                {
                                    Usage = ContactInfoUsage.School,
                                    EmailAddress = "email_addressf3aae0b5",
                                },
                            },
                            PhoneNumbers =
                            {
                                new Phone
                                {
                                    Usage = ContactInfoUsage.School,
                                    Type = Phone.Types.PhoneType.TtyOrTdd,
                                    Number = "number8a24bcb1",
                                    WhenAvailable = "when_availablec58ed10f",
                                },
                            },
                            PersonalUris =
                            {
                                new PersonalUri { Uri = "uri3db70593", },
                            },
                            AdditionalContactInfo =
                            {
                                new AdditionalContactInfo
                                {
                                    Usage = ContactInfoUsage.School,
                                    Name = "name1c9368b0",
                                    ContactId = "contact_id3df1826d",
                                },
                            },
                            EmploymentRecords =
                            {
                                new EmploymentRecord
                                {
                                    StartDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    EndDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    EmployerName = "employer_nameed94ebc1",
                                    DivisionName = "division_name17c13ed1",
                                    Address = new Address
                                    {
                                        Usage = ContactInfoUsage.School,
                                        UnstructuredAddress = "unstructured_address423e5c75",
                                        StructuredAddress = new gt::PostalAddress
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
                                        Current = true,
                                    },
                                    JobTitle = "job_title1840f829",
                                    JobDescription = "job_description71a1e458",
                                    IsSupervisor = false,
                                    IsSelfEmployed = false,
                                    IsCurrent = true,
                                    JobTitleSnippet = "job_title_snippet4f14afe7",
                                    JobDescriptionSnippet = "job_description_snippetb4fd0d43",
                                    EmployerNameSnippet = "employer_name_snippet55ee6685",
                                },
                            },
                            EducationRecords =
                            {
                                new EducationRecord
                                {
                                    StartDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    EndDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    ExpectedGraduationDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    SchoolName = "school_namecada2826",
                                    Address = new Address
                                    {
                                        Usage = ContactInfoUsage.School,
                                        UnstructuredAddress = "unstructured_address423e5c75",
                                        StructuredAddress = new gt::PostalAddress
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
                                        Current = true,
                                    },
                                    DegreeDescription = "degree_descriptionf13cc9aa",
                                    StructuredDegree = new Degree
                                    {
                                        DegreeType = DegreeType.UpperSecondaryEducation,
                                        DegreeName = "degree_name1cdb797a",
                                        FieldsOfStudy =
                                        {
                                            "fields_of_study31142c29",
                                        },
                                    },
                                    Description = "description2cf9da67",
                                    IsCurrent = true,
                                    SchoolNameSnippet = "school_name_snippetb8367dc1",
                                    DegreeSnippet = "degree_snippetef3bb851",
                                },
                            },
                            Skills =
                            {
                                new Skill
                                {
                                    DisplayName = "display_name137f65c2",
                                    LastUsedDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Level = SkillProficiencyLevel.Unskilled,
                                    Context = "context72ef185c",
                                    SkillNameSnippet = "skill_name_snippet79b97035",
                                },
                            },
                            Activities =
                            {
                                new Activity
                                {
                                    DisplayName = "display_name137f65c2",
                                    Description = "description2cf9da67",
                                    Uri = "uri3db70593",
                                    CreateDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    UpdateDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    TeamMembers =
                                    {
                                        "team_membersf4bf0d8d",
                                    },
                                    SkillsUsed =
                                    {
                                        new Skill
                                        {
                                            DisplayName = "display_name137f65c2",
                                            LastUsedDate = new gt::Date
                                            {
                                                Year = 1825033604,
                                                Month = 1123628660,
                                                Day = -1333949598,
                                            },
                                            Level = SkillProficiencyLevel.Unskilled,
                                            Context = "context72ef185c",
                                            SkillNameSnippet = "skill_name_snippet79b97035",
                                        },
                                    },
                                    ActivityNameSnippet = "activity_name_snippet2571bd6b",
                                    ActivityDescriptionSnippet = "activity_description_snippet2fd7e8dd",
                                    SkillsUsedSnippet =
                                    {
                                        "skills_used_snippet3545b1dc",
                                    },
                                },
                            },
                            Publications =
                            {
                                new Publication
                                {
                                    Authors = { "authorse849945d", },
                                    Title = "title17dbd3d5",
                                    Description = "description2cf9da67",
                                    Journal = "journalb44191fb",
                                    Volume = "volumee7b90a21",
                                    Publisher = "publisher16edad52",
                                    PublicationDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    PublicationType = "publication_typeed243fdb",
                                    Isbn = "isbn73119664",
                                },
                            },
                            Patents =
                            {
                                new Patent
                                {
                                    DisplayName = "display_name137f65c2",
                                    Inventors =
                                    {
                                        "inventorsacd1d97e",
                                    },
                                    PatentStatus = "patent_status70adf21c",
                                    PatentStatusDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    PatentFilingDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    PatentOffice = "patent_office03472d2a",
                                    PatentNumber = "patent_number996d4b3b",
                                    PatentDescription = "patent_description06f4e493",
                                    SkillsUsed =
                                    {
                                        new Skill
                                        {
                                            DisplayName = "display_name137f65c2",
                                            LastUsedDate = new gt::Date
                                            {
                                                Year = 1825033604,
                                                Month = 1123628660,
                                                Day = -1333949598,
                                            },
                                            Level = SkillProficiencyLevel.Unskilled,
                                            Context = "context72ef185c",
                                            SkillNameSnippet = "skill_name_snippet79b97035",
                                        },
                                    },
                                },
                            },
                            Certifications =
                            {
                                new Certification
                                {
                                    DisplayName = "display_name137f65c2",
                                    AcquireDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    ExpireDate = new gt::Date
                                    {
                                        Year = 1825033604,
                                        Month = 1123628660,
                                        Day = -1333949598,
                                    },
                                    Authority = "authority0b9c3e87",
                                    Description = "description2cf9da67",
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
                            Processed = true,
                            KeywordSnippet = "keyword_snippet7289f6ef",
                            Applications =
                            {
                                "applicationsffa9fbb5",
                            },
                            Assignments =
                            {
                                "assignments2923b317",
                            },
                            Resume = new Resume
                            {
                                StructuredResume = "structured_resume2a115c3e",
                                ResumeType = Resume.Types.ResumeType.Hrxml,
                            },
                            DerivedAddresses =
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
                            CandidateUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            ResumeUpdateTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            AvailabilitySignals =
                            {
                                new AvailabilitySignal
                                {
                                    Type = AvailabilitySignalType.Unspecified,
                                    LastUpdateTime = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    FilterSatisfied = true,
                                },
                            },
                        },
                    },
                },
                ResultSetId = "result_set_id6cf58a14",
            };
            mockGrpcClient.Setup(x => x.SearchProfilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchProfilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            SearchProfilesResponse responseCallSettings = await client.SearchProfilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchProfilesResponse responseCancellationToken = await client.SearchProfilesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
