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
    public class GeneratedApplicationServiceClientTest
    {
        [Fact]
        public void CreateApplication()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            CreateApplicationRequest expectedRequest = new CreateApplicationRequest
            {
                ParentAsProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.CreateApplication(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            ProfileName parent = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]");
            Application application = new Application();
            Application response = client.CreateApplication(parent, application);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateApplicationAsync()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            CreateApplicationRequest expectedRequest = new CreateApplicationRequest
            {
                ParentAsProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.CreateApplicationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Application>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            ProfileName parent = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]");
            Application application = new Application();
            Application response = await client.CreateApplicationAsync(parent, application);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateApplication2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.CreateApplication(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.CreateApplication(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateApplicationAsync2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = new ProfileName("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.CreateApplicationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Application>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = await client.CreateApplicationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetApplication()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            GetApplicationRequest expectedRequest = new GetApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.GetApplication(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            ApplicationName name = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            Application response = client.GetApplication(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetApplicationAsync()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            GetApplicationRequest expectedRequest = new GetApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Application>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            ApplicationName name = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            Application response = await client.GetApplicationAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetApplication2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.GetApplication(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.GetApplication(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetApplicationAsync2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Application>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = await client.GetApplicationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateApplication()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            UpdateApplicationRequest expectedRequest = new UpdateApplicationRequest
            {
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.UpdateApplication(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application application = new Application();
            Application response = client.UpdateApplication(application);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateApplicationAsync()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            UpdateApplicationRequest expectedRequest = new UpdateApplicationRequest
            {
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.UpdateApplicationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Application>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application application = new Application();
            Application response = await client.UpdateApplicationAsync(application);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateApplication2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.UpdateApplication(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.UpdateApplication(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateApplicationAsync2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                ExternalId = "externalId-1153075697",
                Profile = "profile-309425751",
                Job = "job105405",
                Company = "company950484093",
                OutcomeNotes = "outcomeNotes-355961964",
                JobTitleSnippet = "jobTitleSnippet-1100512972",
            };
            mockGrpcClient.Setup(x => x.UpdateApplicationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Application>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = await client.UpdateApplicationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteApplication()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            DeleteApplicationRequest expectedRequest = new DeleteApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteApplication(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            ApplicationName name = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            client.DeleteApplication(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteApplicationAsync()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            DeleteApplicationRequest expectedRequest = new DeleteApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteApplicationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            ApplicationName name = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]");
            await client.DeleteApplicationAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteApplication2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteApplication(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteApplication(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteApplicationAsync2()
        {
            Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new Mock<ApplicationService.ApplicationServiceClient>(MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = new ApplicationName("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteApplicationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteApplicationAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
