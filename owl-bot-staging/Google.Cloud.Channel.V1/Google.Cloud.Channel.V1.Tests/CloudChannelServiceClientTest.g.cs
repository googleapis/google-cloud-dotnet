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
using lro = Google.LongRunning;
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
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                    new CloudIdentityCustomerAccount(),
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
                    new CloudIdentityCustomerAccount(),
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
                Customer = new Customer(),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                Customer = new Customer(),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                Customer = new Customer(),
                UpdateMask = new wkt::FieldMask(),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
                Customer = new Customer(),
                UpdateMask = new wkt::FieldMask(),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
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
        public void ImportCustomerRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportCustomerRequest request = new ImportCustomerRequest
            {
                Parent = "parent7858e4d0",
                Domain = "domaine8825fad",
                CloudIdentityId = "cloud_identity_idcb2e1526",
                AuthToken = "auth_token85f233bb",
                OverwriteIfExists = false,
                ChannelPartnerId = "channel_partner_ida548fd43",
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.ImportCustomer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.ImportCustomer(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportCustomerRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportCustomerRequest request = new ImportCustomerRequest
            {
                Parent = "parent7858e4d0",
                Domain = "domaine8825fad",
                CloudIdentityId = "cloud_identity_idcb2e1526",
                AuthToken = "auth_token85f233bb",
                OverwriteIfExists = false,
                ChannelPartnerId = "channel_partner_ida548fd43",
                CustomerAsCustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
            };
            Customer expectedResponse = new Customer
            {
                CustomerName = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]"),
                OrgDisplayName = "org_display_nameb29ddfcb",
                OrgPostalAddress = new gt::PostalAddress(),
                PrimaryContactInfo = new ContactInfo(),
                AlternateEmail = "alternate_email3cdfc6ce",
                Domain = "domaine8825fad",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CloudIdentityId = "cloud_identity_idcb2e1526",
                LanguageCode = "language_code2f6c7160",
                CloudIdentityInfo = new CloudIdentityInfo(),
                ChannelPartnerId = "channel_partner_ida548fd43",
            };
            mockGrpcClient.Setup(x => x.ImportCustomerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Customer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Customer responseCallSettings = await client.ImportCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Customer responseCancellationToken = await client.ImportCustomerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OfferAsOfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                CommitmentSettings = new CommitmentSettings(),
                ProvisioningState = Entitlement.Types.ProvisioningState.Unspecified,
                ProvisionedService = new ProvisionedService(),
                SuspensionReasons =
                {
                    Entitlement.Types.SuspensionReason.TrialEnded,
                },
                PurchaseOrderId = "purchase_order_id4111e034",
                TrialSettings = new TrialSettings(),
                AssociationInfo = new AssociationInfo(),
                Parameters = { new Parameter(), },
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
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                OfferAsOfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                CommitmentSettings = new CommitmentSettings(),
                ProvisioningState = Entitlement.Types.ProvisioningState.Unspecified,
                ProvisionedService = new ProvisionedService(),
                SuspensionReasons =
                {
                    Entitlement.Types.SuspensionReason.TrialEnded,
                },
                PurchaseOrderId = "purchase_order_id4111e034",
                TrialSettings = new TrialSettings(),
                AssociationInfo = new AssociationInfo(),
                Parameters = { new Parameter(), },
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
                ChannelPartnerLinkName = ChannelPartnerLinkName.FromAccountChannelPartnerLink("[ACCOUNT]", "[CHANNEL_PARTNER_LINK]"),
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo(),
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
                ChannelPartnerLinkName = ChannelPartnerLinkName.FromAccountChannelPartnerLink("[ACCOUNT]", "[CHANNEL_PARTNER_LINK]"),
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo(),
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
                ChannelPartnerLink = new ChannelPartnerLink(),
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                ChannelPartnerLinkName = ChannelPartnerLinkName.FromAccountChannelPartnerLink("[ACCOUNT]", "[CHANNEL_PARTNER_LINK]"),
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo(),
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
                ChannelPartnerLink = new ChannelPartnerLink(),
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                ChannelPartnerLinkName = ChannelPartnerLinkName.FromAccountChannelPartnerLink("[ACCOUNT]", "[CHANNEL_PARTNER_LINK]"),
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo(),
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
                ChannelPartnerLink = new ChannelPartnerLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                ChannelPartnerLinkName = ChannelPartnerLinkName.FromAccountChannelPartnerLink("[ACCOUNT]", "[CHANNEL_PARTNER_LINK]"),
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo(),
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
                ChannelPartnerLink = new ChannelPartnerLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            ChannelPartnerLink expectedResponse = new ChannelPartnerLink
            {
                ChannelPartnerLinkName = ChannelPartnerLinkName.FromAccountChannelPartnerLink("[ACCOUNT]", "[CHANNEL_PARTNER_LINK]"),
                ResellerCloudIdentityId = "reseller_cloud_identity_id1b90ae2b",
                LinkState = ChannelPartnerLinkState.Revoked,
                InviteLinkUri = "invite_link_urie81ac099",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PublicId = "public_id4d74e21e",
                ChannelPartnerCloudIdentityInfo = new CloudIdentityInfo(),
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
        public void LookupOfferRequestObject()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupOfferRequest request = new LookupOfferRequest
            {
                EntitlementAsEntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
            };
            Offer expectedResponse = new Offer
            {
                OfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                MarketingInfo = new MarketingInfo(),
                Sku = new Sku(),
                Plan = new Plan(),
                Constraints = new Constraints(),
                PriceByResources =
                {
                    new PriceByResource(),
                },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ParameterDefinitions =
                {
                    new ParameterDefinition(),
                },
            };
            mockGrpcClient.Setup(x => x.LookupOffer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Offer response = client.LookupOffer(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupOfferRequestObjectAsync()
        {
            moq::Mock<CloudChannelService.CloudChannelServiceClient> mockGrpcClient = new moq::Mock<CloudChannelService.CloudChannelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupOfferRequest request = new LookupOfferRequest
            {
                EntitlementAsEntitlementName = EntitlementName.FromAccountCustomerEntitlement("[ACCOUNT]", "[CUSTOMER]", "[ENTITLEMENT]"),
            };
            Offer expectedResponse = new Offer
            {
                OfferName = OfferName.FromAccountOffer("[ACCOUNT]", "[OFFER]"),
                MarketingInfo = new MarketingInfo(),
                Sku = new Sku(),
                Plan = new Plan(),
                Constraints = new Constraints(),
                PriceByResources =
                {
                    new PriceByResource(),
                },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ParameterDefinitions =
                {
                    new ParameterDefinition(),
                },
            };
            mockGrpcClient.Setup(x => x.LookupOfferAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Offer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudChannelServiceClient client = new CloudChannelServiceClientImpl(mockGrpcClient.Object, null);
            Offer responseCallSettings = await client.LookupOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Offer responseCancellationToken = await client.LookupOfferAsync(request, st::CancellationToken.None);
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
