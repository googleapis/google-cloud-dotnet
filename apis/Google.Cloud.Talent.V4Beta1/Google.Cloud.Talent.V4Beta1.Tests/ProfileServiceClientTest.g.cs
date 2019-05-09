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
    public class GeneratedProfileServiceClientTest
    {
        [Fact]
        public void CreateProfile()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            CreateProfileRequest expectedRequest = new CreateProfileRequest
            {
                ParentAsTenantName = new TenantName("[PROJECT]", "[TENANT]"),
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.CreateProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            TenantName parent = new TenantName("[PROJECT]", "[TENANT]");
            Profile profile = new Profile();
            Profile response = client.CreateProfile(parent, profile);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateProfileAsync()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            CreateProfileRequest expectedRequest = new CreateProfileRequest
            {
                ParentAsTenantName = new TenantName("[PROJECT]", "[TENANT]"),
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.CreateProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Profile>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            TenantName parent = new TenantName("[PROJECT]", "[TENANT]");
            Profile profile = new Profile();
            Profile response = await client.CreateProfileAsync(parent, profile);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateProfile2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = new TenantName("[PROJECT]", "[TENANT]"),
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.CreateProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.CreateProfile(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateProfileAsync2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                ParentAsTenantName = new TenantName("[PROJECT]", "[TENANT]"),
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.CreateProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Profile>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = await client.CreateProfileAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetProfile()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            GetProfileRequest expectedRequest = new GetProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.GetProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            ProfileName name = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]");
            Profile response = client.GetProfile(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetProfileAsync()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            GetProfileRequest expectedRequest = new GetProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.GetProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Profile>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            ProfileName name = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]");
            Profile response = await client.GetProfileAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetProfile2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.GetProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.GetProfile(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetProfileAsync2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            GetProfileRequest request = new GetProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.GetProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Profile>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = await client.GetProfileAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateProfile()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            UpdateProfileRequest expectedRequest = new UpdateProfileRequest
            {
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.UpdateProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile profile = new Profile();
            Profile response = client.UpdateProfile(profile);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateProfileAsync()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            UpdateProfileRequest expectedRequest = new UpdateProfileRequest
            {
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.UpdateProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Profile>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile profile = new Profile();
            Profile response = await client.UpdateProfileAsync(profile);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateProfile2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.UpdateProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = client.UpdateProfile(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateProfileAsync2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                ExternalId = "externalId-1153075697",
                Source = "source-896505829",
                Uri = "uri116076",
                GroupId = "groupId506361563",
                Processed = true,
                KeywordSnippet = "keywordSnippet1325317319",
            };
            mockGrpcClient.Setup(x => x.UpdateProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Profile>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            Profile response = await client.UpdateProfileAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteProfile()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            DeleteProfileRequest expectedRequest = new DeleteProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            ProfileName name = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]");
            client.DeleteProfile(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteProfileAsync()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            DeleteProfileRequest expectedRequest = new DeleteProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            ProfileName name = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]");
            await client.DeleteProfileAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteProfile2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteProfile(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteProfileAsync2()
        {
            Mock<ProfileService.ProfileServiceClient> mockGrpcClient = new Mock<ProfileService.ProfileServiceClient>(MockBehavior.Strict);
            DeleteProfileRequest request = new DeleteProfileRequest
            {
                ProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ProfileServiceClient client = new ProfileServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteProfileAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
