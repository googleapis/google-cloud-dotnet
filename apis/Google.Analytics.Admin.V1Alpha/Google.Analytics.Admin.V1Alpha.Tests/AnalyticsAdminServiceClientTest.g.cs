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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeletePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeletePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeleteProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.DeletePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateProperty(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdatePropertyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Property>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteUserLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteUserLinksAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.GetWebDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.GetWebDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.GetWebDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.GetWebDataStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.GetWebDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.GetWebDataStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.GetWebDataStream(request.WebDataStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.GetWebDataStreamAsync(request.WebDataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.GetWebDataStreamAsync(request.WebDataStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWebDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWebDataStream(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWebDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWebDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWebDataStreamAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWebDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWebDataStream(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWebDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWebDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWebDataStreamAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWebDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteWebDataStream(request.WebDataStreamName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWebDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWebDataStreamAsync(request.WebDataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWebDataStreamAsync(request.WebDataStreamName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWebDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateWebDataStreamRequest request = new UpdateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.UpdateWebDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWebDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateWebDataStreamRequest request = new UpdateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.UpdateWebDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.UpdateWebDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWebDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateWebDataStreamRequest request = new UpdateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.UpdateWebDataStream(request.WebDataStream, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWebDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateWebDataStreamRequest request = new UpdateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.UpdateWebDataStreamAsync(request.WebDataStream, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.UpdateWebDataStreamAsync(request.WebDataStream, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWebDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.CreateWebDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWebDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.CreateWebDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.CreateWebDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWebDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.CreateWebDataStream(request.Parent, request.WebDataStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWebDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.CreateWebDataStreamAsync(request.Parent, request.WebDataStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.CreateWebDataStreamAsync(request.Parent, request.WebDataStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWebDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateWebDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream response = client.CreateWebDataStream(request.ParentAsPropertyName, request.WebDataStream);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWebDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            WebDataStream expectedResponse = new WebDataStream
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                MeasurementId = "measurement_id2d9d31df",
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DefaultUri = "default_uri9ac940d5",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.CreateWebDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<WebDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            WebDataStream responseCallSettings = await client.CreateWebDataStreamAsync(request.ParentAsPropertyName, request.WebDataStream, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            WebDataStream responseCancellationToken = await client.CreateWebDataStreamAsync(request.ParentAsPropertyName, request.WebDataStream, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIosAppDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream response = client.GetIosAppDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIosAppDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IosAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream responseCallSettings = await client.GetIosAppDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IosAppDataStream responseCancellationToken = await client.GetIosAppDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIosAppDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream response = client.GetIosAppDataStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIosAppDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IosAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream responseCallSettings = await client.GetIosAppDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IosAppDataStream responseCancellationToken = await client.GetIosAppDataStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIosAppDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream response = client.GetIosAppDataStream(request.IosAppDataStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIosAppDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IosAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream responseCallSettings = await client.GetIosAppDataStreamAsync(request.IosAppDataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IosAppDataStream responseCancellationToken = await client.GetIosAppDataStreamAsync(request.IosAppDataStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIosAppDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteIosAppDataStream(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIosAppDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIosAppDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIosAppDataStreamAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIosAppDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteIosAppDataStream(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIosAppDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIosAppDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIosAppDataStreamAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIosAppDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteIosAppDataStream(request.IosAppDataStreamName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIosAppDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIosAppDataStreamAsync(request.IosAppDataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIosAppDataStreamAsync(request.IosAppDataStreamName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIosAppDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateIosAppDataStreamRequest request = new UpdateIosAppDataStreamRequest
            {
                IosAppDataStream = new IosAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream response = client.UpdateIosAppDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIosAppDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateIosAppDataStreamRequest request = new UpdateIosAppDataStreamRequest
            {
                IosAppDataStream = new IosAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IosAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream responseCallSettings = await client.UpdateIosAppDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IosAppDataStream responseCancellationToken = await client.UpdateIosAppDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIosAppDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateIosAppDataStreamRequest request = new UpdateIosAppDataStreamRequest
            {
                IosAppDataStream = new IosAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateIosAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream response = client.UpdateIosAppDataStream(request.IosAppDataStream, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIosAppDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateIosAppDataStreamRequest request = new UpdateIosAppDataStreamRequest
            {
                IosAppDataStream = new IosAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            IosAppDataStream expectedResponse = new IosAppDataStream
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                BundleId = "bundle_id58a23305",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateIosAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IosAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            IosAppDataStream responseCallSettings = await client.UpdateIosAppDataStreamAsync(request.IosAppDataStream, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IosAppDataStream responseCancellationToken = await client.UpdateIosAppDataStreamAsync(request.IosAppDataStream, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAndroidAppDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream response = client.GetAndroidAppDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAndroidAppDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AndroidAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream responseCallSettings = await client.GetAndroidAppDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AndroidAppDataStream responseCancellationToken = await client.GetAndroidAppDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAndroidAppDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream response = client.GetAndroidAppDataStream(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAndroidAppDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AndroidAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream responseCallSettings = await client.GetAndroidAppDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AndroidAppDataStream responseCancellationToken = await client.GetAndroidAppDataStreamAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAndroidAppDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream response = client.GetAndroidAppDataStream(request.AndroidAppDataStreamName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAndroidAppDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AndroidAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream responseCallSettings = await client.GetAndroidAppDataStreamAsync(request.AndroidAppDataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AndroidAppDataStream responseCancellationToken = await client.GetAndroidAppDataStreamAsync(request.AndroidAppDataStreamName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAndroidAppDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAndroidAppDataStream(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAndroidAppDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAndroidAppDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAndroidAppDataStreamAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAndroidAppDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAndroidAppDataStream(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAndroidAppDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAndroidAppDataStreamAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAndroidAppDataStreamAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAndroidAppDataStreamResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteAndroidAppDataStream(request.AndroidAppDataStreamName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAndroidAppDataStreamResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAndroidAppDataStreamAsync(request.AndroidAppDataStreamName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAndroidAppDataStreamAsync(request.AndroidAppDataStreamName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAndroidAppDataStreamRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAndroidAppDataStreamRequest request = new UpdateAndroidAppDataStreamRequest
            {
                AndroidAppDataStream = new AndroidAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream response = client.UpdateAndroidAppDataStream(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAndroidAppDataStreamRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAndroidAppDataStreamRequest request = new UpdateAndroidAppDataStreamRequest
            {
                AndroidAppDataStream = new AndroidAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AndroidAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream responseCallSettings = await client.UpdateAndroidAppDataStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AndroidAppDataStream responseCancellationToken = await client.UpdateAndroidAppDataStreamAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAndroidAppDataStream()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAndroidAppDataStreamRequest request = new UpdateAndroidAppDataStreamRequest
            {
                AndroidAppDataStream = new AndroidAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateAndroidAppDataStream(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream response = client.UpdateAndroidAppDataStream(request.AndroidAppDataStream, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAndroidAppDataStreamAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateAndroidAppDataStreamRequest request = new UpdateAndroidAppDataStreamRequest
            {
                AndroidAppDataStream = new AndroidAppDataStream(),
                UpdateMask = new wkt::FieldMask(),
            };
            AndroidAppDataStream expectedResponse = new AndroidAppDataStream
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
                FirebaseAppId = "firebase_app_id78213ad9",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                PackageName = "package_name9942c4d2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.UpdateAndroidAppDataStreamAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AndroidAppDataStream>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            AndroidAppDataStream responseCallSettings = await client.UpdateAndroidAppDataStreamAsync(request.AndroidAppDataStream, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AndroidAppDataStream responseCancellationToken = await client.UpdateAndroidAppDataStreamAsync(request.AndroidAppDataStream, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnhancedMeasurementSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.GetEnhancedMeasurementSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings response = client.GetEnhancedMeasurementSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnhancedMeasurementSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.GetEnhancedMeasurementSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EnhancedMeasurementSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings responseCallSettings = await client.GetEnhancedMeasurementSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EnhancedMeasurementSettings responseCancellationToken = await client.GetEnhancedMeasurementSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnhancedMeasurementSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.GetEnhancedMeasurementSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings response = client.GetEnhancedMeasurementSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnhancedMeasurementSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.GetEnhancedMeasurementSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EnhancedMeasurementSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings responseCallSettings = await client.GetEnhancedMeasurementSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EnhancedMeasurementSettings responseCancellationToken = await client.GetEnhancedMeasurementSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEnhancedMeasurementSettingsResourceNames()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.GetEnhancedMeasurementSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings response = client.GetEnhancedMeasurementSettings(request.EnhancedMeasurementSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnhancedMeasurementSettingsResourceNamesAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.GetEnhancedMeasurementSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EnhancedMeasurementSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings responseCallSettings = await client.GetEnhancedMeasurementSettingsAsync(request.EnhancedMeasurementSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EnhancedMeasurementSettings responseCancellationToken = await client.GetEnhancedMeasurementSettingsAsync(request.EnhancedMeasurementSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEnhancedMeasurementSettingsRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateEnhancedMeasurementSettingsRequest request = new UpdateEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettings = new EnhancedMeasurementSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.UpdateEnhancedMeasurementSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings response = client.UpdateEnhancedMeasurementSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEnhancedMeasurementSettingsRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateEnhancedMeasurementSettingsRequest request = new UpdateEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettings = new EnhancedMeasurementSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.UpdateEnhancedMeasurementSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EnhancedMeasurementSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings responseCallSettings = await client.UpdateEnhancedMeasurementSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EnhancedMeasurementSettings responseCancellationToken = await client.UpdateEnhancedMeasurementSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEnhancedMeasurementSettings()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateEnhancedMeasurementSettingsRequest request = new UpdateEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettings = new EnhancedMeasurementSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.UpdateEnhancedMeasurementSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings response = client.UpdateEnhancedMeasurementSettings(request.EnhancedMeasurementSettings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEnhancedMeasurementSettingsAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateEnhancedMeasurementSettingsRequest request = new UpdateEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettings = new EnhancedMeasurementSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            EnhancedMeasurementSettings expectedResponse = new EnhancedMeasurementSettings
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
                StreamEnabled = true,
                PageViewsEnabled = true,
                ScrollsEnabled = true,
                OutboundClicksEnabled = false,
                SiteSearchEnabled = false,
                VideoEngagementEnabled = true,
                FileDownloadsEnabled = true,
                PageLoadsEnabled = false,
                PageChangesEnabled = false,
                SearchQueryParameter = "search_query_parameter3de0ea6b",
                UriQueryParameter = "uri_query_parameter55687bee",
            };
            mockGrpcClient.Setup(x => x.UpdateEnhancedMeasurementSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EnhancedMeasurementSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            EnhancedMeasurementSettings responseCallSettings = await client.UpdateEnhancedMeasurementSettingsAsync(request.EnhancedMeasurementSettings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EnhancedMeasurementSettings responseCancellationToken = await client.UpdateEnhancedMeasurementSettingsAsync(request.EnhancedMeasurementSettings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
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
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.CreateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            FirebaseLink responseCallSettings = await client.CreateFirebaseLinkAsync(request.ParentAsPropertyName, request.FirebaseLink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirebaseLink responseCancellationToken = await client.CreateFirebaseLinkAsync(request.ParentAsPropertyName, request.FirebaseLink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFirebaseLinkRequestObject()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateFirebaseLinkRequest request = new UpdateFirebaseLinkRequest
            {
                FirebaseLink = new FirebaseLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.UpdateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            FirebaseLink response = client.UpdateFirebaseLink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFirebaseLinkRequestObjectAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateFirebaseLinkRequest request = new UpdateFirebaseLinkRequest
            {
                FirebaseLink = new FirebaseLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.UpdateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            FirebaseLink responseCallSettings = await client.UpdateFirebaseLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirebaseLink responseCancellationToken = await client.UpdateFirebaseLinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFirebaseLink()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateFirebaseLinkRequest request = new UpdateFirebaseLinkRequest
            {
                FirebaseLink = new FirebaseLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.UpdateFirebaseLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            FirebaseLink response = client.UpdateFirebaseLink(request.FirebaseLink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFirebaseLinkAsync()
        {
            moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient> mockGrpcClient = new moq::Mock<AnalyticsAdminService.AnalyticsAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateFirebaseLinkRequest request = new UpdateFirebaseLinkRequest
            {
                FirebaseLink = new FirebaseLink(),
                UpdateMask = new wkt::FieldMask(),
            };
            FirebaseLink expectedResponse = new FirebaseLink
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
                Project = "projectaa6ff846",
                CreateTime = new wkt::Timestamp(),
                MaximumUserAccess = MaximumUserAccess.NoAccess,
            };
            mockGrpcClient.Setup(x => x.UpdateFirebaseLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FirebaseLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            FirebaseLink responseCallSettings = await client.UpdateFirebaseLinkAsync(request.FirebaseLink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FirebaseLink responseCancellationToken = await client.UpdateFirebaseLinkAsync(request.FirebaseLink, request.UpdateMask, st::CancellationToken.None);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GlobalSiteTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GlobalSiteTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
            };
            GlobalSiteTag expectedResponse = new GlobalSiteTag
            {
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
                Snippet = "snippet5e4cde54",
            };
            mockGrpcClient.Setup(x => x.GetGlobalSiteTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GlobalSiteTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
                EmailAddress = "email_addressf3aae0b5",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateGoogleAdsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GoogleAdsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
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
            AnalyticsAdminServiceClient client = new AnalyticsAdminServiceClientImpl(mockGrpcClient.Object, null);
            DataSharingSettings responseCallSettings = await client.GetDataSharingSettingsAsync(request.DataSharingSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataSharingSettings responseCancellationToken = await client.GetDataSharingSettingsAsync(request.DataSharingSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
