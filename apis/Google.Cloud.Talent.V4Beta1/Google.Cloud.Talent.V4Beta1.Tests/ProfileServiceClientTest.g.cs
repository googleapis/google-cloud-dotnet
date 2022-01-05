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
using wkt = Google.Protobuf.WellKnownTypes;
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
                UpdateMask = new wkt::FieldMask(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
                UpdateMask = new wkt::FieldMask(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "external_id9442680e",
                Source = "sourcef438cd36",
                Uri = "uri3db70593",
                GroupId = "group_id4f9a930e",
                IsHirable = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PersonNames = { new PersonName(), },
                Addresses = { new Address(), },
                EmailAddresses = { new Email(), },
                PhoneNumbers = { new Phone(), },
                PersonalUris = { new PersonalUri(), },
                AdditionalContactInfo =
                {
                    new AdditionalContactInfo(),
                },
                EmploymentRecords =
                {
                    new EmploymentRecord(),
                },
                EducationRecords =
                {
                    new EducationRecord(),
                },
                Skills = { new Skill(), },
                Activities = { new Activity(), },
                Publications = { new Publication(), },
                Patents = { new Patent(), },
                Certifications =
                {
                    new Certification(),
                },
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
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
                Resume = new Resume(),
                DerivedAddresses = { new Location(), },
                CandidateUpdateTime = new wkt::Timestamp(),
                ResumeUpdateTime = new wkt::Timestamp(),
                AvailabilitySignals =
                {
                    new AvailabilitySignal(),
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
                RequestMetadata = new RequestMetadata(),
                ProfileQuery = new ProfileQuery(),
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                Offset = 1472300666,
                DisableSpellCheck = true,
                OrderBy = "order_byb4d33ada",
                CaseSensitiveSort = true,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                ResultSetId = "result_set_id6cf58a14",
                StrictKeywordsSearch = true,
            };
            SearchProfilesResponse expectedResponse = new SearchProfilesResponse
            {
                EstimatedTotalSize = 5269174732212511261L,
                SpellCorrection = new SpellingCorrection(),
                Metadata = new ResponseMetadata(),
                NextPageToken = "next_page_tokendbee0940",
                HistogramQueryResults =
                {
                    new HistogramQueryResult(),
                },
                SummarizedProfiles =
                {
                    new SummarizedProfile(),
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
                RequestMetadata = new RequestMetadata(),
                ProfileQuery = new ProfileQuery(),
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                Offset = 1472300666,
                DisableSpellCheck = true,
                OrderBy = "order_byb4d33ada",
                CaseSensitiveSort = true,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                ResultSetId = "result_set_id6cf58a14",
                StrictKeywordsSearch = true,
            };
            SearchProfilesResponse expectedResponse = new SearchProfilesResponse
            {
                EstimatedTotalSize = 5269174732212511261L,
                SpellCorrection = new SpellingCorrection(),
                Metadata = new ResponseMetadata(),
                NextPageToken = "next_page_tokendbee0940",
                HistogramQueryResults =
                {
                    new HistogramQueryResult(),
                },
                SummarizedProfiles =
                {
                    new SummarizedProfile(),
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
