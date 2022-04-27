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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Analytics.Admin.V1Alpha.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAnalyticsAdminServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetAccountRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account response = client.GetAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccountRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Account>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account responseCallSettings = await client.GetAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Account responseCancellationToken = await client.GetAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccount()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account response = client.GetAccount(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccountAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Account>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account responseCallSettings = await client.GetAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Account responseCancellationToken = await client.GetAccountAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccountResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account response = client.GetAccount(request.AccountName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccountResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.GetAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Account>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account responseCallSettings = await client.GetAccountAsync(request.AccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Account responseCancellationToken = await client.GetAccountAsync(request.AccountName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccountRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAccount(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccountRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAccountAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccount()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAccount(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccountAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAccountAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccountResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAccount(request.AccountName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccountResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAccountAsync(request.AccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAccountAsync(request.AccountName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAccountRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new wkt::FieldMask(),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account response = client.UpdateAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAccountRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new wkt::FieldMask(),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Account>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account responseCallSettings = await client.UpdateAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Account responseCancellationToken = await client.UpdateAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAccount()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new wkt::FieldMask(),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account response = client.UpdateAccount(request.Account, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAccountAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new wkt::FieldMask(),
            };
            Account expectedResponse = new Account
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                RegionCode = "region_code72561d46",
                Deleted = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Account>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Account responseCallSettings = await client.UpdateAccountAsync(request.Account, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Account responseCancellationToken = await client.UpdateAccountAsync(request.Account, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ProvisionAccountTicketRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ProvisionAccountTicketRequest request = new ProvisionAccountTicketRequest
            {
                Account = new Account(),
                RedirectUri = "redirect_urif2cd5914",
            };
            ProvisionAccountTicketResponse expectedResponse = new ProvisionAccountTicketResponse
            {
                AccountTicketId = "account_ticket_id75d82eaa",
            };
            mockGrpcClient.Setup(x => x.ProvisionAccountTicket(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ProvisionAccountTicketResponse response = client.ProvisionAccountTicket(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProvisionAccountTicketRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ProvisionAccountTicketRequest request = new ProvisionAccountTicketRequest
            {
                Account = new Account(),
                RedirectUri = "redirect_urif2cd5914",
            };
            ProvisionAccountTicketResponse expectedResponse = new ProvisionAccountTicketResponse
            {
                AccountTicketId = "account_ticket_id75d82eaa",
            };
            mockGrpcClient.Setup(x => x.ProvisionAccountTicketAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProvisionAccountTicketResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ProvisionAccountTicketResponse responseCallSettings = await client.ProvisionAccountTicketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProvisionAccountTicketResponse responseCancellationToken = await client.ProvisionAccountTicketAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPropertyRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.GetProperty(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPropertyRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetPropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.GetPropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.GetPropertyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProperty()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.GetProperty(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPropertyAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetPropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.GetPropertyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.GetPropertyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPropertyResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.GetProperty(request.PropertyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPropertyResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.GetPropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.GetPropertyAsync(request.PropertyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.GetPropertyAsync(request.PropertyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePropertyRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreatePropertyRequest request = new CreatePropertyRequest
            {
                Property = new Property(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.CreateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.CreateProperty(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePropertyRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreatePropertyRequest request = new CreatePropertyRequest
            {
                Property = new Property(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.CreatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.CreatePropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.CreatePropertyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateProperty()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreatePropertyRequest request = new CreatePropertyRequest
            {
                Property = new Property(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.CreateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.CreateProperty(request.Property);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePropertyAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreatePropertyRequest request = new CreatePropertyRequest
            {
                Property = new Property(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.CreatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.CreatePropertyAsync(request.Property, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.CreatePropertyAsync(request.Property, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePropertyRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.DeleteProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.DeleteProperty(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePropertyRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.DeletePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.DeletePropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.DeletePropertyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteProperty()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.DeleteProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.DeleteProperty(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePropertyAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.DeletePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.DeletePropertyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.DeletePropertyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePropertyResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.DeleteProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.DeleteProperty(request.PropertyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePropertyResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.DeletePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.DeletePropertyAsync(request.PropertyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.DeletePropertyAsync(request.PropertyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePropertyRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdatePropertyRequest request = new UpdatePropertyRequest
            {
                Property = new Property(),
                UpdateMask = new wkt::FieldMask(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.UpdateProperty(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePropertyRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdatePropertyRequest request = new UpdatePropertyRequest
            {
                Property = new Property(),
                UpdateMask = new wkt::FieldMask(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.UpdatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.UpdatePropertyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.UpdatePropertyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProperty()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdatePropertyRequest request = new UpdatePropertyRequest
            {
                Property = new Property(),
                UpdateMask = new wkt::FieldMask(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property response = client.UpdateProperty(request.Property, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePropertyAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdatePropertyRequest request = new UpdatePropertyRequest
            {
                Property = new Property(),
                UpdateMask = new wkt::FieldMask(),
            };
            Property expectedResponse = new Property
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Parent = "parent7858e4d0",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                IndustryCategory = IndustryCategory.Reference,
                TimeZone = "time_zone73f23b20",
                CurrencyCode = "currency_code7f81e352",
                ServiceLevel = ServiceLevel.GoogleAnalyticsStandard,
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            mockGrpcClient.Setup(x => x.UpdatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            Property responseCallSettings = await client.UpdatePropertyAsync(request.Property, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Property responseCancellationToken = await client.UpdatePropertyAsync(request.Property, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.GetUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.GetUserLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.GetUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.GetUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.GetUserLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.GetUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.GetUserLink(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.GetUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.GetUserLinkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.GetUserLinkAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUserLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.GetUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.GetUserLink(request.UserLinkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUserLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.GetUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.GetUserLinkAsync(request.UserLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.GetUserLinkAsync(request.UserLinkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchGetUserLinksRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchGetUserLinksRequest request = new BatchGetUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLinkNames =
                {
                    UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                },
            };
            BatchGetUserLinksResponse expectedResponse = new BatchGetUserLinksResponse
            {
                UserLinks = { new UserLink(), },
            };
            mockGrpcClient.Setup(x => x.BatchGetUserLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchGetUserLinksResponse response = client.BatchGetUserLinks(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetUserLinksRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchGetUserLinksRequest request = new BatchGetUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLinkNames =
                {
                    UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                },
            };
            BatchGetUserLinksResponse expectedResponse = new BatchGetUserLinksResponse
            {
                UserLinks = { new UserLink(), },
            };
            mockGrpcClient.Setup(x => x.BatchGetUserLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetUserLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchGetUserLinksResponse responseCallSettings = await client.BatchGetUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetUserLinksResponse responseCancellationToken = await client.BatchGetUserLinksAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUser = true,
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.CreateUserLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUser = true,
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.CreateUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.CreateUserLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.CreateUserLink(request.Parent, request.UserLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.CreateUserLinkAsync(request.Parent, request.UserLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.CreateUserLinkAsync(request.Parent, request.UserLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUserLinkResourceNames1()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.CreateUserLink(request.ParentAsAccountName, request.UserLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUserLinkResourceNames1Async()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.CreateUserLinkAsync(request.ParentAsAccountName, request.UserLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.CreateUserLinkAsync(request.ParentAsAccountName, request.UserLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateUserLinkResourceNames2()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.CreateUserLink(request.ParentAsPropertyName, request.UserLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateUserLinkResourceNames2Async()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.CreateUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.CreateUserLinkAsync(request.ParentAsPropertyName, request.UserLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.CreateUserLinkAsync(request.ParentAsPropertyName, request.UserLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateUserLinksRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchCreateUserLinksRequest request = new BatchCreateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUsers = false,
                Requests =
                {
                    new CreateUserLinkRequest(),
                },
            };
            BatchCreateUserLinksResponse expectedResponse = new BatchCreateUserLinksResponse
            {
                UserLinks = { new UserLink(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateUserLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchCreateUserLinksResponse response = client.BatchCreateUserLinks(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateUserLinksRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchCreateUserLinksRequest request = new BatchCreateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUsers = false,
                Requests =
                {
                    new CreateUserLinkRequest(),
                },
            };
            BatchCreateUserLinksResponse expectedResponse = new BatchCreateUserLinksResponse
            {
                UserLinks = { new UserLink(), },
            };
            mockGrpcClient.Setup(x => x.BatchCreateUserLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateUserLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchCreateUserLinksResponse responseCallSettings = await client.BatchCreateUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateUserLinksResponse responseCancellationToken = await client.BatchCreateUserLinksAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateUserLinkRequest request = new UpdateUserLinkRequest
            {
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.UpdateUserLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateUserLinkRequest request = new UpdateUserLinkRequest
            {
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.UpdateUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.UpdateUserLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateUserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateUserLinkRequest request = new UpdateUserLinkRequest
            {
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink response = client.UpdateUserLink(request.UserLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateUserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateUserLinkRequest request = new UpdateUserLinkRequest
            {
                UserLink = new UserLink(),
            };
            UserLink expectedResponse = new UserLink
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                EmailAddress = "email_addressf3aae0b5",
                DirectRoles =
                {
                    "direct_roles5488445c",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            UserLink responseCallSettings = await client.UpdateUserLinkAsync(request.UserLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserLink responseCancellationToken = await client.UpdateUserLinkAsync(request.UserLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchUpdateUserLinksRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchUpdateUserLinksRequest request = new BatchUpdateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateUserLinkRequest(),
                },
            };
            BatchUpdateUserLinksResponse expectedResponse = new BatchUpdateUserLinksResponse
            {
                UserLinks = { new UserLink(), },
            };
            mockGrpcClient.Setup(x => x.BatchUpdateUserLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchUpdateUserLinksResponse response = client.BatchUpdateUserLinks(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchUpdateUserLinksRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchUpdateUserLinksRequest request = new BatchUpdateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateUserLinkRequest(),
                },
            };
            BatchUpdateUserLinksResponse expectedResponse = new BatchUpdateUserLinksResponse
            {
                UserLinks = { new UserLink(), },
            };
            mockGrpcClient.Setup(x => x.BatchUpdateUserLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchUpdateUserLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchUpdateUserLinksResponse responseCallSettings = await client.BatchUpdateUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchUpdateUserLinksResponse responseCancellationToken = await client.BatchUpdateUserLinksAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteUserLink(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteUserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUserLinkAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteUserLink(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteUserLinkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUserLinkAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteUserLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteUserLink(request.UserLinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteUserLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteUserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteUserLinkAsync(request.UserLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteUserLinkAsync(request.UserLinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteUserLinksRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchDeleteUserLinksRequest request = new BatchDeleteUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteUserLinkRequest(),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteUserLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.BatchDeleteUserLinks(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteUserLinksRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            BatchDeleteUserLinksRequest request = new BatchDeleteUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteUserLinkRequest(),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteUserLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.BatchDeleteUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteUserLinksAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFirebaseLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            FirebaseLink response = client.CreateFirebaseLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFirebaseLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            FirebaseLink responseCallSettings = await client.CreateFirebaseLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirebaseLink responseCancellationToken = await client.CreateFirebaseLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFirebaseLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            FirebaseLink response = client.CreateFirebaseLink(request.Parent, request.FirebaseLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFirebaseLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            FirebaseLink responseCallSettings = await client.CreateFirebaseLinkAsync(request.Parent, request.FirebaseLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirebaseLink responseCancellationToken = await client.CreateFirebaseLinkAsync(request.Parent, request.FirebaseLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFirebaseLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            FirebaseLink response = client.CreateFirebaseLink(request.ParentAsPropertyName, request.FirebaseLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFirebaseLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            FirebaseLink responseCallSettings = await client.CreateFirebaseLinkAsync(request.ParentAsPropertyName, request.FirebaseLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirebaseLink responseCancellationToken = await client.CreateFirebaseLinkAsync(request.ParentAsPropertyName, request.FirebaseLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFirebaseLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteFirebaseLink(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFirebaseLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteFirebaseLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFirebaseLinkAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFirebaseLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteFirebaseLink(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFirebaseLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteFirebaseLinkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFirebaseLinkAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFirebaseLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteFirebaseLink(request.FirebaseLinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFirebaseLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteFirebaseLinkAsync(request.FirebaseLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFirebaseLinkAsync(request.FirebaseLinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGlobalSiteTagRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GlobalSiteTag response = client.GetGlobalSiteTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGlobalSiteTagRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GlobalSiteTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GlobalSiteTag responseCallSettings = await client.GetGlobalSiteTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GlobalSiteTag responseCancellationToken = await client.GetGlobalSiteTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGlobalSiteTag()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GlobalSiteTag response = client.GetGlobalSiteTag(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGlobalSiteTagAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GlobalSiteTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GlobalSiteTag responseCallSettings = await client.GetGlobalSiteTagAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GlobalSiteTag responseCancellationToken = await client.GetGlobalSiteTagAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGlobalSiteTagResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GlobalSiteTag response = client.GetGlobalSiteTag(request.GlobalSiteTagName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGlobalSiteTagResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GlobalSiteTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GlobalSiteTag responseCallSettings = await client.GetGlobalSiteTagAsync(request.GlobalSiteTagName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GlobalSiteTag responseCancellationToken = await client.GetGlobalSiteTagAsync(request.GlobalSiteTagName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGoogleAdsLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink response = client.CreateGoogleAdsLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGoogleAdsLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink responseCallSettings = await client.CreateGoogleAdsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleAdsLink responseCancellationToken = await client.CreateGoogleAdsLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGoogleAdsLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink response = client.CreateGoogleAdsLink(request.Parent, request.GoogleAdsLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGoogleAdsLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink responseCallSettings = await client.CreateGoogleAdsLinkAsync(request.Parent, request.GoogleAdsLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleAdsLink responseCancellationToken = await client.CreateGoogleAdsLinkAsync(request.Parent, request.GoogleAdsLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGoogleAdsLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink response = client.CreateGoogleAdsLink(request.ParentAsPropertyName, request.GoogleAdsLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGoogleAdsLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink responseCallSettings = await client.CreateGoogleAdsLinkAsync(request.ParentAsPropertyName, request.GoogleAdsLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleAdsLink responseCancellationToken = await client.CreateGoogleAdsLinkAsync(request.ParentAsPropertyName, request.GoogleAdsLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGoogleAdsLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleAdsLinkRequest request = new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = new GoogleAdsLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink response = client.UpdateGoogleAdsLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGoogleAdsLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleAdsLinkRequest request = new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = new GoogleAdsLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink responseCallSettings = await client.UpdateGoogleAdsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleAdsLink responseCancellationToken = await client.UpdateGoogleAdsLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGoogleAdsLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleAdsLinkRequest request = new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = new GoogleAdsLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink response = client.UpdateGoogleAdsLink(request.GoogleAdsLink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGoogleAdsLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleAdsLinkRequest request = new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = new GoogleAdsLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleAdsLink expectedResponse = new GoogleAdsLink
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
                CustomerId = "customer_id3b3724cb",
                CanManageClients = true,
                AdsPersonalizationEnabled = true,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                CreatorEmailAddress = "creator_email_address113105e5",
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleAdsLink responseCallSettings = await client.UpdateGoogleAdsLinkAsync(request.GoogleAdsLink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleAdsLink responseCancellationToken = await client.UpdateGoogleAdsLinkAsync(request.GoogleAdsLink, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGoogleAdsLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteGoogleAdsLink(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGoogleAdsLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteGoogleAdsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGoogleAdsLinkAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGoogleAdsLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteGoogleAdsLink(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGoogleAdsLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteGoogleAdsLinkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGoogleAdsLinkAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGoogleAdsLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteGoogleAdsLink(request.GoogleAdsLinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGoogleAdsLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteGoogleAdsLinkAsync(request.GoogleAdsLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGoogleAdsLinkAsync(request.GoogleAdsLinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataSharingSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            DataSharingSettings expectedResponse = new DataSharingSettings
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
                SharingWithGoogleSupportEnabled = true,
                SharingWithGoogleAssignedSalesEnabled = true,
                SharingWithGoogleAnySalesEnabled = false,
                SharingWithGoogleProductsEnabled = false,
                SharingWithOthersEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSharingSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataSharingSettings response = client.GetDataSharingSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataSharingSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            DataSharingSettings expectedResponse = new DataSharingSettings
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
                SharingWithGoogleSupportEnabled = true,
                SharingWithGoogleAssignedSalesEnabled = true,
                SharingWithGoogleAnySalesEnabled = false,
                SharingWithGoogleProductsEnabled = false,
                SharingWithOthersEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSharingSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataSharingSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataSharingSettings responseCallSettings = await client.GetDataSharingSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSharingSettings responseCancellationToken = await client.GetDataSharingSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataSharingSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            DataSharingSettings expectedResponse = new DataSharingSettings
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
                SharingWithGoogleSupportEnabled = true,
                SharingWithGoogleAssignedSalesEnabled = true,
                SharingWithGoogleAnySalesEnabled = false,
                SharingWithGoogleProductsEnabled = false,
                SharingWithOthersEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSharingSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataSharingSettings response = client.GetDataSharingSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataSharingSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            DataSharingSettings expectedResponse = new DataSharingSettings
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
                SharingWithGoogleSupportEnabled = true,
                SharingWithGoogleAssignedSalesEnabled = true,
                SharingWithGoogleAnySalesEnabled = false,
                SharingWithGoogleProductsEnabled = false,
                SharingWithOthersEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSharingSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataSharingSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataSharingSettings responseCallSettings = await client.GetDataSharingSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSharingSettings responseCancellationToken = await client.GetDataSharingSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataSharingSettingsResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            DataSharingSettings expectedResponse = new DataSharingSettings
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
                SharingWithGoogleSupportEnabled = true,
                SharingWithGoogleAssignedSalesEnabled = true,
                SharingWithGoogleAnySalesEnabled = false,
                SharingWithGoogleProductsEnabled = false,
                SharingWithOthersEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSharingSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataSharingSettings response = client.GetDataSharingSettings(request.DataSharingSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataSharingSettingsResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            DataSharingSettings expectedResponse = new DataSharingSettings
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
                SharingWithGoogleSupportEnabled = true,
                SharingWithGoogleAssignedSalesEnabled = true,
                SharingWithGoogleAnySalesEnabled = false,
                SharingWithGoogleProductsEnabled = false,
                SharingWithOthersEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSharingSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataSharingSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataSharingSettings responseCallSettings = await client.GetDataSharingSettingsAsync(request.DataSharingSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSharingSettings responseCancellationToken = await client.GetDataSharingSettingsAsync(request.DataSharingSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMeasurementProtocolSecretRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.GetMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.GetMeasurementProtocolSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMeasurementProtocolSecretRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.GetMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.GetMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.GetMeasurementProtocolSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMeasurementProtocolSecret()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.GetMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.GetMeasurementProtocolSecret(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMeasurementProtocolSecretAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.GetMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.GetMeasurementProtocolSecretAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.GetMeasurementProtocolSecretAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMeasurementProtocolSecretResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.GetMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.GetMeasurementProtocolSecret(request.MeasurementProtocolSecretName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMeasurementProtocolSecretResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.GetMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.GetMeasurementProtocolSecretAsync(request.MeasurementProtocolSecretName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.GetMeasurementProtocolSecretAsync(request.MeasurementProtocolSecretName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMeasurementProtocolSecretRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.CreateMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.CreateMeasurementProtocolSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMeasurementProtocolSecretRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.CreateMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.CreateMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.CreateMeasurementProtocolSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMeasurementProtocolSecret()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.CreateMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.CreateMeasurementProtocolSecret(request.Parent, request.MeasurementProtocolSecret);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMeasurementProtocolSecretAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.CreateMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.CreateMeasurementProtocolSecretAsync(request.Parent, request.MeasurementProtocolSecret, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.CreateMeasurementProtocolSecretAsync(request.Parent, request.MeasurementProtocolSecret, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateMeasurementProtocolSecretResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.CreateMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.CreateMeasurementProtocolSecret(request.ParentAsDataStreamName, request.MeasurementProtocolSecret);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateMeasurementProtocolSecretResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.CreateMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.CreateMeasurementProtocolSecretAsync(request.ParentAsDataStreamName, request.MeasurementProtocolSecret, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.CreateMeasurementProtocolSecretAsync(request.ParentAsDataStreamName, request.MeasurementProtocolSecret, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMeasurementProtocolSecretRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteMeasurementProtocolSecret(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMeasurementProtocolSecretRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMeasurementProtocolSecretAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMeasurementProtocolSecret()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteMeasurementProtocolSecret(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMeasurementProtocolSecretAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteMeasurementProtocolSecretAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMeasurementProtocolSecretAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteMeasurementProtocolSecretResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteMeasurementProtocolSecret(request.MeasurementProtocolSecretName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteMeasurementProtocolSecretResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteMeasurementProtocolSecretAsync(request.MeasurementProtocolSecretName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteMeasurementProtocolSecretAsync(request.MeasurementProtocolSecretName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateMeasurementProtocolSecretRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateMeasurementProtocolSecretRequest request = new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
                UpdateMask = new wkt::FieldMask(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.UpdateMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.UpdateMeasurementProtocolSecret(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateMeasurementProtocolSecretRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateMeasurementProtocolSecretRequest request = new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
                UpdateMask = new wkt::FieldMask(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.UpdateMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.UpdateMeasurementProtocolSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.UpdateMeasurementProtocolSecretAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateMeasurementProtocolSecret()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateMeasurementProtocolSecretRequest request = new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
                UpdateMask = new wkt::FieldMask(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.UpdateMeasurementProtocolSecret(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret response = client.UpdateMeasurementProtocolSecret(request.MeasurementProtocolSecret, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateMeasurementProtocolSecretAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateMeasurementProtocolSecretRequest request = new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
                UpdateMask = new wkt::FieldMask(),
            };
            MeasurementProtocolSecret expectedResponse = new MeasurementProtocolSecret
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
                DisplayName = "display_name137f65c2",
                SecretValue = "secret_valueaa711688",
            };
            mockGrpcClient.Setup(x => x.UpdateMeasurementProtocolSecretAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MeasurementProtocolSecret>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            MeasurementProtocolSecret responseCallSettings = await client.UpdateMeasurementProtocolSecretAsync(request.MeasurementProtocolSecret, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MeasurementProtocolSecret responseCancellationToken = await client.UpdateMeasurementProtocolSecretAsync(request.MeasurementProtocolSecret, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AcknowledgeUserDataCollectionRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            AcknowledgeUserDataCollectionRequest request = new AcknowledgeUserDataCollectionRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Acknowledgement = "acknowledgement44782104",
            };
            AcknowledgeUserDataCollectionResponse expectedResponse = new AcknowledgeUserDataCollectionResponse { };
            mockGrpcClient.Setup(x => x.AcknowledgeUserDataCollection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            AcknowledgeUserDataCollectionResponse response = client.AcknowledgeUserDataCollection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AcknowledgeUserDataCollectionRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            AcknowledgeUserDataCollectionRequest request = new AcknowledgeUserDataCollectionRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Acknowledgement = "acknowledgement44782104",
            };
            AcknowledgeUserDataCollectionResponse expectedResponse = new AcknowledgeUserDataCollectionResponse { };
            mockGrpcClient.Setup(x => x.AcknowledgeUserDataCollectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcknowledgeUserDataCollectionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            AcknowledgeUserDataCollectionResponse responseCallSettings = await client.AcknowledgeUserDataCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcknowledgeUserDataCollectionResponse responseCancellationToken = await client.AcknowledgeUserDataCollectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGoogleSignalsSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetGoogleSignalsSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings response = client.GetGoogleSignalsSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGoogleSignalsSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetGoogleSignalsSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleSignalsSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings responseCallSettings = await client.GetGoogleSignalsSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleSignalsSettings responseCancellationToken = await client.GetGoogleSignalsSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGoogleSignalsSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetGoogleSignalsSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings response = client.GetGoogleSignalsSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGoogleSignalsSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetGoogleSignalsSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleSignalsSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings responseCallSettings = await client.GetGoogleSignalsSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleSignalsSettings responseCancellationToken = await client.GetGoogleSignalsSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGoogleSignalsSettingsResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetGoogleSignalsSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings response = client.GetGoogleSignalsSettings(request.GoogleSignalsSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGoogleSignalsSettingsResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetGoogleSignalsSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleSignalsSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings responseCallSettings = await client.GetGoogleSignalsSettingsAsync(request.GoogleSignalsSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleSignalsSettings responseCancellationToken = await client.GetGoogleSignalsSettingsAsync(request.GoogleSignalsSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGoogleSignalsSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleSignalsSettingsRequest request = new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = new GoogleSignalsSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleSignalsSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings response = client.UpdateGoogleSignalsSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGoogleSignalsSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleSignalsSettingsRequest request = new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = new GoogleSignalsSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleSignalsSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleSignalsSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings responseCallSettings = await client.UpdateGoogleSignalsSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleSignalsSettings responseCancellationToken = await client.UpdateGoogleSignalsSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGoogleSignalsSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleSignalsSettingsRequest request = new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = new GoogleSignalsSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleSignalsSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings response = client.UpdateGoogleSignalsSettings(request.GoogleSignalsSettings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGoogleSignalsSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateGoogleSignalsSettingsRequest request = new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = new GoogleSignalsSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            GoogleSignalsSettings expectedResponse = new GoogleSignalsSettings
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
                State = GoogleSignalsState.Unspecified,
                Consent = GoogleSignalsConsent.Unspecified,
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleSignalsSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleSignalsSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            GoogleSignalsSettings responseCallSettings = await client.UpdateGoogleSignalsSettingsAsync(request.GoogleSignalsSettings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GoogleSignalsSettings responseCancellationToken = await client.UpdateGoogleSignalsSettingsAsync(request.GoogleSignalsSettings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversionEventRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.CreateConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent response = client.CreateConversionEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversionEventRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.CreateConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversionEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent responseCallSettings = await client.CreateConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversionEvent responseCancellationToken = await client.CreateConversionEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversionEvent()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.CreateConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent response = client.CreateConversionEvent(request.Parent, request.ConversionEvent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversionEventAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.CreateConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversionEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent responseCallSettings = await client.CreateConversionEventAsync(request.Parent, request.ConversionEvent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversionEvent responseCancellationToken = await client.CreateConversionEventAsync(request.Parent, request.ConversionEvent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversionEventResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.CreateConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent response = client.CreateConversionEvent(request.ParentAsPropertyName, request.ConversionEvent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversionEventResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.CreateConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversionEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent responseCallSettings = await client.CreateConversionEventAsync(request.ParentAsPropertyName, request.ConversionEvent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversionEvent responseCancellationToken = await client.CreateConversionEventAsync(request.ParentAsPropertyName, request.ConversionEvent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionEventRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.GetConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent response = client.GetConversionEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionEventRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.GetConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversionEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent responseCallSettings = await client.GetConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversionEvent responseCancellationToken = await client.GetConversionEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionEvent()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.GetConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent response = client.GetConversionEvent(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionEventAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.GetConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversionEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent responseCallSettings = await client.GetConversionEventAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversionEvent responseCancellationToken = await client.GetConversionEventAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversionEventResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.GetConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent response = client.GetConversionEvent(request.ConversionEventName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversionEventResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            ConversionEvent expectedResponse = new ConversionEvent
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
                EventName = "event_name43c4a22d",
                CreateTime = new wkt::Timestamp(),
                Deletable = true,
                Custom = false,
            };
            mockGrpcClient.Setup(x => x.GetConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversionEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ConversionEvent responseCallSettings = await client.GetConversionEventAsync(request.ConversionEventName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversionEvent responseCancellationToken = await client.GetConversionEventAsync(request.ConversionEventName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversionEventRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteConversionEvent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversionEventRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteConversionEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversionEventAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversionEvent()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteConversionEvent(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversionEventAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteConversionEventAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversionEventAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversionEventResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversionEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteConversionEvent(request.ConversionEventName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversionEventResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversionEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteConversionEventAsync(request.ConversionEventName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversionEventAsync(request.ConversionEventName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDisplayVideo360AdvertiserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.GetDisplayVideo360AdvertiserLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.GetDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.GetDisplayVideo360AdvertiserLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDisplayVideo360AdvertiserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.GetDisplayVideo360AdvertiserLink(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDisplayVideo360AdvertiserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.GetDisplayVideo360AdvertiserLinkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.GetDisplayVideo360AdvertiserLinkAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDisplayVideo360AdvertiserLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.GetDisplayVideo360AdvertiserLink(request.DisplayVideo360AdvertiserLinkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDisplayVideo360AdvertiserLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.GetDisplayVideo360AdvertiserLinkAsync(request.DisplayVideo360AdvertiserLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.GetDisplayVideo360AdvertiserLinkAsync(request.DisplayVideo360AdvertiserLinkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDisplayVideo360AdvertiserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.CreateDisplayVideo360AdvertiserLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.CreateDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.CreateDisplayVideo360AdvertiserLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDisplayVideo360AdvertiserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.CreateDisplayVideo360AdvertiserLink(request.Parent, request.DisplayVideo360AdvertiserLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDisplayVideo360AdvertiserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.CreateDisplayVideo360AdvertiserLinkAsync(request.Parent, request.DisplayVideo360AdvertiserLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.CreateDisplayVideo360AdvertiserLinkAsync(request.Parent, request.DisplayVideo360AdvertiserLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDisplayVideo360AdvertiserLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.CreateDisplayVideo360AdvertiserLink(request.ParentAsPropertyName, request.DisplayVideo360AdvertiserLink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDisplayVideo360AdvertiserLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.CreateDisplayVideo360AdvertiserLinkAsync(request.ParentAsPropertyName, request.DisplayVideo360AdvertiserLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.CreateDisplayVideo360AdvertiserLinkAsync(request.ParentAsPropertyName, request.DisplayVideo360AdvertiserLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDisplayVideo360AdvertiserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDisplayVideo360AdvertiserLink(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDisplayVideo360AdvertiserLinkAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDisplayVideo360AdvertiserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDisplayVideo360AdvertiserLink(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDisplayVideo360AdvertiserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDisplayVideo360AdvertiserLinkAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDisplayVideo360AdvertiserLinkAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDisplayVideo360AdvertiserLinkResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDisplayVideo360AdvertiserLink(request.DisplayVideo360AdvertiserLinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDisplayVideo360AdvertiserLinkResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDisplayVideo360AdvertiserLinkAsync(request.DisplayVideo360AdvertiserLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDisplayVideo360AdvertiserLinkAsync(request.DisplayVideo360AdvertiserLinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDisplayVideo360AdvertiserLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDisplayVideo360AdvertiserLinkRequest request = new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.UpdateDisplayVideo360AdvertiserLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDisplayVideo360AdvertiserLinkRequest request = new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.UpdateDisplayVideo360AdvertiserLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.UpdateDisplayVideo360AdvertiserLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDisplayVideo360AdvertiserLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDisplayVideo360AdvertiserLinkRequest request = new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayVideo360AdvertiserLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink response = client.UpdateDisplayVideo360AdvertiserLink(request.DisplayVideo360AdvertiserLink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDisplayVideo360AdvertiserLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDisplayVideo360AdvertiserLinkRequest request = new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            DisplayVideo360AdvertiserLink expectedResponse = new DisplayVideo360AdvertiserLink
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
                AdvertiserId = "advertiser_id7e57c73c",
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateDisplayVideo360AdvertiserLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLink responseCallSettings = await client.UpdateDisplayVideo360AdvertiserLinkAsync(request.DisplayVideo360AdvertiserLink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLink responseCancellationToken = await client.UpdateDisplayVideo360AdvertiserLinkAsync(request.DisplayVideo360AdvertiserLink, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.GetDisplayVideo360AdvertiserLinkProposal(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.GetDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.GetDisplayVideo360AdvertiserLinkProposalAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDisplayVideo360AdvertiserLinkProposal()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.GetDisplayVideo360AdvertiserLinkProposal(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDisplayVideo360AdvertiserLinkProposalAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.GetDisplayVideo360AdvertiserLinkProposalAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.GetDisplayVideo360AdvertiserLinkProposalAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.GetDisplayVideo360AdvertiserLinkProposal(request.DisplayVideo360AdvertiserLinkProposalName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDisplayVideo360AdvertiserLinkProposalResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.GetDisplayVideo360AdvertiserLinkProposalAsync(request.DisplayVideo360AdvertiserLinkProposalName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.GetDisplayVideo360AdvertiserLinkProposalAsync(request.DisplayVideo360AdvertiserLinkProposalName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.CreateDisplayVideo360AdvertiserLinkProposal(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.CreateDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.CreateDisplayVideo360AdvertiserLinkProposalAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDisplayVideo360AdvertiserLinkProposal()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.CreateDisplayVideo360AdvertiserLinkProposal(request.Parent, request.DisplayVideo360AdvertiserLinkProposal);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDisplayVideo360AdvertiserLinkProposalAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.CreateDisplayVideo360AdvertiserLinkProposalAsync(request.Parent, request.DisplayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.CreateDisplayVideo360AdvertiserLinkProposalAsync(request.Parent, request.DisplayVideo360AdvertiserLinkProposal, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.CreateDisplayVideo360AdvertiserLinkProposal(request.ParentAsPropertyName, request.DisplayVideo360AdvertiserLinkProposal);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDisplayVideo360AdvertiserLinkProposalResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.CreateDisplayVideo360AdvertiserLinkProposalAsync(request.ParentAsPropertyName, request.DisplayVideo360AdvertiserLinkProposal, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.CreateDisplayVideo360AdvertiserLinkProposalAsync(request.ParentAsPropertyName, request.DisplayVideo360AdvertiserLinkProposal, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDisplayVideo360AdvertiserLinkProposal(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDisplayVideo360AdvertiserLinkProposal()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDisplayVideo360AdvertiserLinkProposal(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDisplayVideo360AdvertiserLinkProposalAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDisplayVideo360AdvertiserLinkProposal(request.DisplayVideo360AdvertiserLinkProposalName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDisplayVideo360AdvertiserLinkProposalResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request.DisplayVideo360AdvertiserLinkProposalName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request.DisplayVideo360AdvertiserLinkProposalName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApproveDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ApproveDisplayVideo360AdvertiserLinkProposalRequest request = new ApproveDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            ApproveDisplayVideo360AdvertiserLinkProposalResponse expectedResponse = new ApproveDisplayVideo360AdvertiserLinkProposalResponse
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            mockGrpcClient.Setup(x => x.ApproveDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ApproveDisplayVideo360AdvertiserLinkProposalResponse response = client.ApproveDisplayVideo360AdvertiserLinkProposal(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApproveDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ApproveDisplayVideo360AdvertiserLinkProposalRequest request = new ApproveDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            ApproveDisplayVideo360AdvertiserLinkProposalResponse expectedResponse = new ApproveDisplayVideo360AdvertiserLinkProposalResponse
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            mockGrpcClient.Setup(x => x.ApproveDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApproveDisplayVideo360AdvertiserLinkProposalResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            ApproveDisplayVideo360AdvertiserLinkProposalResponse responseCallSettings = await client.ApproveDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApproveDisplayVideo360AdvertiserLinkProposalResponse responseCancellationToken = await client.ApproveDisplayVideo360AdvertiserLinkProposalAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CancelDisplayVideo360AdvertiserLinkProposalRequest request = new CancelDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CancelDisplayVideo360AdvertiserLinkProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal response = client.CancelDisplayVideo360AdvertiserLinkProposal(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CancelDisplayVideo360AdvertiserLinkProposalRequest request = new CancelDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            DisplayVideo360AdvertiserLinkProposal expectedResponse = new DisplayVideo360AdvertiserLinkProposal
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
                AdvertiserId = "advertiser_id7e57c73c",
                LinkProposalStatusDetails = new LinkProposalStatusDetails(),
                AdvertiserDisplayName = "advertiser_display_namede5a74e9",
                ValidationEmail = "validation_email8f79096a",
                AdsPersonalizationEnabled = true,
                CampaignDataSharingEnabled = false,
                CostDataSharingEnabled = true,
            };
            mockGrpcClient.Setup(x => x.CancelDisplayVideo360AdvertiserLinkProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DisplayVideo360AdvertiserLinkProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DisplayVideo360AdvertiserLinkProposal responseCallSettings = await client.CancelDisplayVideo360AdvertiserLinkProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DisplayVideo360AdvertiserLinkProposal responseCancellationToken = await client.CancelDisplayVideo360AdvertiserLinkProposalAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomDimensionRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.CreateCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.CreateCustomDimension(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomDimensionRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.CreateCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.CreateCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.CreateCustomDimensionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomDimension()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.CreateCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.CreateCustomDimension(request.Parent, request.CustomDimension);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomDimensionAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.CreateCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.CreateCustomDimensionAsync(request.Parent, request.CustomDimension, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.CreateCustomDimensionAsync(request.Parent, request.CustomDimension, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomDimensionResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.CreateCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.CreateCustomDimension(request.ParentAsPropertyName, request.CustomDimension);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomDimensionResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.CreateCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.CreateCustomDimensionAsync(request.ParentAsPropertyName, request.CustomDimension, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.CreateCustomDimensionAsync(request.ParentAsPropertyName, request.CustomDimension, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomDimensionRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomDimensionRequest request = new UpdateCustomDimensionRequest
            {
                CustomDimension = new CustomDimension(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.UpdateCustomDimension(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomDimensionRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomDimensionRequest request = new UpdateCustomDimensionRequest
            {
                CustomDimension = new CustomDimension(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.UpdateCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.UpdateCustomDimensionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomDimension()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomDimensionRequest request = new UpdateCustomDimensionRequest
            {
                CustomDimension = new CustomDimension(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.UpdateCustomDimension(request.CustomDimension, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomDimensionAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomDimensionRequest request = new UpdateCustomDimensionRequest
            {
                CustomDimension = new CustomDimension(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.UpdateCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.UpdateCustomDimensionAsync(request.CustomDimension, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.UpdateCustomDimensionAsync(request.CustomDimension, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ArchiveCustomDimensionRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.ArchiveCustomDimension(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ArchiveCustomDimensionRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.ArchiveCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ArchiveCustomDimensionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ArchiveCustomDimension()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.ArchiveCustomDimension(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ArchiveCustomDimensionAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.ArchiveCustomDimensionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ArchiveCustomDimensionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ArchiveCustomDimensionResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.ArchiveCustomDimension(request.CustomDimensionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ArchiveCustomDimensionResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.ArchiveCustomDimensionAsync(request.CustomDimensionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ArchiveCustomDimensionAsync(request.CustomDimensionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomDimensionRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.GetCustomDimension(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomDimensionRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.GetCustomDimensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.GetCustomDimensionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomDimension()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.GetCustomDimension(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomDimensionAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.GetCustomDimensionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.GetCustomDimensionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomDimensionResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomDimension(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension response = client.GetCustomDimension(request.CustomDimensionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomDimensionResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            CustomDimension expectedResponse = new CustomDimension
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                Scope = CustomDimension.Types.DimensionScope.Unspecified,
                DisallowAdsPersonalization = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomDimensionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomDimension>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomDimension responseCallSettings = await client.GetCustomDimensionAsync(request.CustomDimensionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomDimension responseCancellationToken = await client.GetCustomDimensionAsync(request.CustomDimensionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomMetricRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.CreateCustomMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomMetricRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.CreateCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.CreateCustomMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomMetric()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.CreateCustomMetric(request.Parent, request.CustomMetric);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomMetricAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.CreateCustomMetricAsync(request.Parent, request.CustomMetric, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.CreateCustomMetricAsync(request.Parent, request.CustomMetric, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomMetricResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.CreateCustomMetric(request.ParentAsPropertyName, request.CustomMetric);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomMetricResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.CreateCustomMetricAsync(request.ParentAsPropertyName, request.CustomMetric, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.CreateCustomMetricAsync(request.ParentAsPropertyName, request.CustomMetric, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomMetricRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomMetricRequest request = new UpdateCustomMetricRequest
            {
                CustomMetric = new CustomMetric(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.UpdateCustomMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomMetricRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomMetricRequest request = new UpdateCustomMetricRequest
            {
                CustomMetric = new CustomMetric(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.UpdateCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.UpdateCustomMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomMetric()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomMetricRequest request = new UpdateCustomMetricRequest
            {
                CustomMetric = new CustomMetric(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.UpdateCustomMetric(request.CustomMetric, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomMetricAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateCustomMetricRequest request = new UpdateCustomMetricRequest
            {
                CustomMetric = new CustomMetric(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.UpdateCustomMetricAsync(request.CustomMetric, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.UpdateCustomMetricAsync(request.CustomMetric, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ArchiveCustomMetricRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.ArchiveCustomMetric(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ArchiveCustomMetricRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.ArchiveCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ArchiveCustomMetricAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ArchiveCustomMetric()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.ArchiveCustomMetric(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ArchiveCustomMetricAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.ArchiveCustomMetricAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ArchiveCustomMetricAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ArchiveCustomMetricResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.ArchiveCustomMetric(request.CustomMetricName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ArchiveCustomMetricResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ArchiveCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.ArchiveCustomMetricAsync(request.CustomMetricName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ArchiveCustomMetricAsync(request.CustomMetricName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomMetricRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.GetCustomMetric(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomMetricRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.GetCustomMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.GetCustomMetricAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomMetric()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.GetCustomMetric(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomMetricAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.GetCustomMetricAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.GetCustomMetricAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomMetricResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomMetric(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric response = client.GetCustomMetric(request.CustomMetricName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomMetricResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            CustomMetric expectedResponse = new CustomMetric
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
                ParameterName = "parameter_name7d56d532",
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                MeasurementUnit = CustomMetric.Types.MeasurementUnit.Standard,
                Scope = CustomMetric.Types.MetricScope.Event,
                RestrictedMetricType =
                {
                    CustomMetric.Types.RestrictedMetricType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomMetricAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomMetric>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            CustomMetric responseCallSettings = await client.GetCustomMetricAsync(request.CustomMetricName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomMetric responseCancellationToken = await client.GetCustomMetricAsync(request.CustomMetricName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataRetentionSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.GetDataRetentionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings response = client.GetDataRetentionSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataRetentionSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.GetDataRetentionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataRetentionSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings responseCallSettings = await client.GetDataRetentionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataRetentionSettings responseCancellationToken = await client.GetDataRetentionSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataRetentionSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.GetDataRetentionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings response = client.GetDataRetentionSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataRetentionSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.GetDataRetentionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataRetentionSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings responseCallSettings = await client.GetDataRetentionSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataRetentionSettings responseCancellationToken = await client.GetDataRetentionSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataRetentionSettingsResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.GetDataRetentionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings response = client.GetDataRetentionSettings(request.DataRetentionSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataRetentionSettingsResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.GetDataRetentionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataRetentionSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings responseCallSettings = await client.GetDataRetentionSettingsAsync(request.DataRetentionSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataRetentionSettings responseCancellationToken = await client.GetDataRetentionSettingsAsync(request.DataRetentionSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataRetentionSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataRetentionSettingsRequest request = new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = new DataRetentionSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.UpdateDataRetentionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings response = client.UpdateDataRetentionSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataRetentionSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataRetentionSettingsRequest request = new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = new DataRetentionSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.UpdateDataRetentionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataRetentionSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings responseCallSettings = await client.UpdateDataRetentionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataRetentionSettings responseCancellationToken = await client.UpdateDataRetentionSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataRetentionSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataRetentionSettingsRequest request = new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = new DataRetentionSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.UpdateDataRetentionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings response = client.UpdateDataRetentionSettings(request.DataRetentionSettings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataRetentionSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataRetentionSettingsRequest request = new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = new DataRetentionSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataRetentionSettings expectedResponse = new DataRetentionSettings
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
                EventDataRetention = DataRetentionSettings.Types.RetentionDuration.TwentySixMonths,
                ResetUserDataOnNewActivity = false,
            };
            mockGrpcClient.Setup(x => x.UpdateDataRetentionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataRetentionSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataRetentionSettings responseCallSettings = await client.UpdateDataRetentionSettingsAsync(request.DataRetentionSettings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataRetentionSettings responseCancellationToken = await client.UpdateDataRetentionSettingsAsync(request.DataRetentionSettings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.CreateDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.CreateDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.CreateDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.CreateDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.CreateDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.CreateDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.CreateDataStream(request.Parent, request.DataStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.CreateDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.CreateDataStreamAsync(request.Parent, request.DataStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.CreateDataStreamAsync(request.Parent, request.DataStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.CreateDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.CreateDataStream(request.ParentAsPropertyName, request.DataStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.CreateDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.CreateDataStreamAsync(request.ParentAsPropertyName, request.DataStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.CreateDataStreamAsync(request.ParentAsPropertyName, request.DataStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataStream(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataStreamAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataStream(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataStreamAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataStream(request.DataStreamName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataStreamAsync(request.DataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataStreamAsync(request.DataStreamName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataStreamRequest request = new UpdateDataStreamRequest
            {
                DataStream = new DataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.UpdateDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataStreamRequest request = new UpdateDataStreamRequest
            {
                DataStream = new DataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.UpdateDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.UpdateDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataStreamRequest request = new UpdateDataStreamRequest
            {
                DataStream = new DataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.UpdateDataStream(request.DataStream, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateDataStreamRequest request = new UpdateDataStreamRequest
            {
                DataStream = new DataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.UpdateDataStreamAsync(request.DataStream, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.UpdateDataStreamAsync(request.DataStream, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.GetDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.GetDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.GetDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.GetDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.GetDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.GetDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.GetDataStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.GetDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.GetDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.GetDataStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.GetDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream response = client.GetDataStream(request.DataStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            DataStream expectedResponse = new DataStream
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                Type = DataStream.Types.DataStreamType.IosAppDataStream,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                WebStreamData = new DataStream.Types.WebStreamData(),
                AndroidAppStreamData = new DataStream.Types.AndroidAppStreamData(),
                IosAppStreamData = new DataStream.Types.IosAppStreamData(),
            };
            mockGrpcClient.Setup(x => x.GetDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            DataStream responseCallSettings = await client.GetDataStreamAsync(request.DataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataStream responseCancellationToken = await client.GetDataStreamAsync(request.DataStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
