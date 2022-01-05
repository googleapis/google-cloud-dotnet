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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.EssentialContacts.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEssentialContactsServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateContactRequestObject()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.CreateContact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContactRequestObjectAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.CreateContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.CreateContactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContact()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.CreateContact(request.Parent, request.Contact);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContactAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.CreateContactAsync(request.Parent, request.Contact, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.CreateContactAsync(request.Parent, request.Contact, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContactResourceNames1()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.CreateContact(request.ParentAsProjectName, request.Contact);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContactResourceNames1Async()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.CreateContactAsync(request.ParentAsProjectName, request.Contact, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.CreateContactAsync(request.ParentAsProjectName, request.Contact, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContactResourceNames2()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.CreateContact(request.ParentAsFolderName, request.Contact);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContactResourceNames2Async()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.CreateContactAsync(request.ParentAsFolderName, request.Contact, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.CreateContactAsync(request.ParentAsFolderName, request.Contact, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContactResourceNames3()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.CreateContact(request.ParentAsOrganizationName, request.Contact);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContactResourceNames3Async()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            CreateContactRequest request = new CreateContactRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Contact = new Contact(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.CreateContactAsync(request.ParentAsOrganizationName, request.Contact, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.CreateContactAsync(request.ParentAsOrganizationName, request.Contact, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContactRequestObject()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new wkt::FieldMask(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.UpdateContact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContactRequestObjectAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new wkt::FieldMask(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.UpdateContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.UpdateContactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContact()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new wkt::FieldMask(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.UpdateContact(request.Contact, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContactAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            UpdateContactRequest request = new UpdateContactRequest
            {
                Contact = new Contact(),
                UpdateMask = new wkt::FieldMask(),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.UpdateContactAsync(request.Contact, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.UpdateContactAsync(request.Contact, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContactRequestObject()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.GetContact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContactRequestObjectAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.GetContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.GetContactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContact()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.GetContact(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContactAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.GetContactAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.GetContactAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContactResourceNames()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact response = client.GetContact(request.ContactName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContactResourceNamesAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            GetContactRequest request = new GetContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            Contact expectedResponse = new Contact
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                Email = "email7cf5830c",
                NotificationCategorySubscriptions =
                {
                    NotificationCategory.TechnicalIncidents,
                },
                LanguageTag = "language_tag40256b15",
                ValidationState = ValidationState.Invalid,
                ValidateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Contact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            Contact responseCallSettings = await client.GetContactAsync(request.ContactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Contact responseCancellationToken = await client.GetContactAsync(request.ContactName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContactRequestObject()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteContact(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContactRequestObjectAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContactAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContact()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteContact(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContactAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteContactAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContactAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContactResourceNames()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteContact(request.ContactName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContactResourceNamesAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            DeleteContactRequest request = new DeleteContactRequest
            {
                ContactName = ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteContactAsync(request.ContactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContactAsync(request.ContactName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SendTestMessageRequestObject()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            SendTestMessageRequest request = new SendTestMessageRequest
            {
                ContactsAsContactNames =
                {
                    ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                },
                ResourceAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                NotificationCategory = NotificationCategory.All,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendTestMessage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            client.SendTestMessage(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SendTestMessageRequestObjectAsync()
        {
            moq::Mock<EssentialContactsService.EssentialContactsServiceClient> mockGrpcClient = new moq::Mock<EssentialContactsService.EssentialContactsServiceClient>(moq::MockBehavior.Strict);
            SendTestMessageRequest request = new SendTestMessageRequest
            {
                ContactsAsContactNames =
                {
                    ContactName.FromProjectContact("[PROJECT]", "[CONTACT]"),
                },
                ResourceAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                NotificationCategory = NotificationCategory.All,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.SendTestMessageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EssentialContactsServiceClient client = new EssentialContactsServiceClientImpl(mockGrpcClient.Object, null);
            await client.SendTestMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.SendTestMessageAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
