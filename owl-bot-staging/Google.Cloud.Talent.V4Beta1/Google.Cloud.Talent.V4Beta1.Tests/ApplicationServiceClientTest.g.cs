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
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedApplicationServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateApplicationRequestObject()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.CreateApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.CreateApplication(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApplicationRequestObjectAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.CreateApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.CreateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.CreateApplicationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApplication()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.CreateApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.CreateApplication(request.Parent, request.Application);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApplicationAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.CreateApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.CreateApplicationAsync(request.Parent, request.Application, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.CreateApplicationAsync(request.Parent, request.Application, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApplicationResourceNames()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.CreateApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.CreateApplication(request.ParentAsProfileName, request.Application);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApplicationResourceNamesAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsProfileName = ProfileName.FromProjectTenantProfile("[PROJECT]", "[TENANT]", "[PROFILE]"),
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.CreateApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.CreateApplicationAsync(request.ParentAsProfileName, request.Application, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.CreateApplicationAsync(request.ParentAsProfileName, request.Application, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApplicationRequestObject()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.GetApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.GetApplication(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApplicationRequestObjectAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.GetApplicationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApplication()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.GetApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.GetApplication(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApplicationAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.GetApplicationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.GetApplicationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApplicationResourceNames()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.GetApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.GetApplication(request.ApplicationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApplicationResourceNamesAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.GetApplicationAsync(request.ApplicationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.GetApplicationAsync(request.ApplicationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApplicationRequestObject()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
                UpdateMask = new wkt::FieldMask(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.UpdateApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.UpdateApplication(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApplicationRequestObjectAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
                UpdateMask = new wkt::FieldMask(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.UpdateApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.UpdateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.UpdateApplicationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApplication()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.UpdateApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application response = client.UpdateApplication(request.Application);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApplicationAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
            };
            Application expectedResponse = new Application
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
                Profile = "profile1b48977d",
                JobAsJobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                ApplicationDate = new gt::Date(),
                Stage = Application.Types.ApplicationStage.OfferAccepted,
                State = Application.Types.ApplicationState.Unspecified,
                Interviews = { new Interview(), },
                Referral = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OutcomeNotes = "outcome_notes38ed921d",
                Outcome = Outcome.Neutral,
                IsMatch = false,
                JobTitleSnippet = "job_title_snippet4f14afe7",
                ExternalId = "external_id9442680e",
            };
            mockGrpcClient.Setup(x => x.UpdateApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.UpdateApplicationAsync(request.Application, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.UpdateApplicationAsync(request.Application, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApplicationRequestObject()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteApplication(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApplicationRequestObjectAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApplicationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApplication()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteApplication(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApplicationAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteApplicationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApplicationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApplicationResourceNames()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteApplication(request.ApplicationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApplicationResourceNamesAsync()
        {
            moq::Mock<ApplicationService.ApplicationServiceClient> mockGrpcClient = new moq::Mock<ApplicationService.ApplicationServiceClient>(moq::MockBehavior.Strict);
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectTenantProfileApplication("[PROJECT]", "[TENANT]", "[PROFILE]", "[APPLICATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationServiceClient client = new ApplicationServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteApplicationAsync(request.ApplicationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApplicationAsync(request.ApplicationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
