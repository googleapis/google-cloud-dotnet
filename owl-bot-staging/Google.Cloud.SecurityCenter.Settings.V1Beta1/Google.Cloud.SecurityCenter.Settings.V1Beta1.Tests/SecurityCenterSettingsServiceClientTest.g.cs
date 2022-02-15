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

namespace Google.Cloud.SecurityCenter.Settings.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSecurityCenterSettingsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceAccountRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
                ServiceAccount_ = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.GetServiceAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
                ServiceAccount_ = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.GetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.GetServiceAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccount()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
                ServiceAccount_ = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.GetServiceAccount(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
                ServiceAccount_ = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.GetServiceAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.GetServiceAccountAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceAccountResourceNames()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
                ServiceAccount_ = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetServiceAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ServiceAccount response = client.GetServiceAccount(request.ServiceAccountName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAccountResourceNamesAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
            };
            ServiceAccount expectedResponse = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromOrganization("[ORGANIZATION]"),
                ServiceAccount_ = "service_accounta3c1b923",
            };
            mockGrpcClient.Setup(x => x.GetServiceAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ServiceAccount responseCallSettings = await client.GetServiceAccountAsync(request.ServiceAccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceAccount responseCancellationToken = await client.GetServiceAccountAsync(request.ServiceAccountName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.GetSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettings()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.GetSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingsResourceNames()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.GetSettings(request.SettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsResourceNamesAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request.SettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request.SettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.UpdateSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.UpdateSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettings()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.UpdateSettings(request.Settings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingsAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.UpdateSettingsAsync(request.Settings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.UpdateSettingsAsync(request.Settings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            ResetSettingsRequest request = new ResetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            client.ResetSettings(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            ResetSettingsRequest request = new ResetSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResetSettingsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchGetSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            BatchGetSettingsRequest request = new BatchGetSettingsRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Names = { "names318c99a8", },
            };
            BatchGetSettingsResponse expectedResponse = new BatchGetSettingsResponse
            {
                Settings = { new Settings(), },
            };
            mockGrpcClient.Setup(x => x.BatchGetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetSettingsResponse response = client.BatchGetSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            BatchGetSettingsRequest request = new BatchGetSettingsRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Names = { "names318c99a8", },
            };
            BatchGetSettingsResponse expectedResponse = new BatchGetSettingsResponse
            {
                Settings = { new Settings(), },
            };
            mockGrpcClient.Setup(x => x.BatchGetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetSettingsResponse responseCallSettings = await client.BatchGetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetSettingsResponse responseCancellationToken = await client.BatchGetSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateEffectiveSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.CalculateEffectiveSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateEffectiveSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.CalculateEffectiveSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.CalculateEffectiveSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateEffectiveSettings()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.CalculateEffectiveSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateEffectiveSettingsAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.CalculateEffectiveSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.CalculateEffectiveSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateEffectiveSettingsResourceNames()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings response = client.CalculateEffectiveSettings(request.SettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateEffectiveSettingsResourceNamesAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveSettingsRequest request = new CalculateEffectiveSettingsRequest
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromOrganization("[ORGANIZATION]"),
                BillingSettings = new BillingSettings(),
                State = Settings.Types.OnboardingState.OrgServiceAccountCreated,
                OrgServiceAccount = "org_service_accounte301d413",
                SinkSettings = new SinkSettings(),
                ComponentSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings()
                    },
                },
                DetectorGroupSettings =
                {
                    {
                        "key8a0b6e3c",
                        new Settings.Types.DetectorGroupSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.CalculateEffectiveSettingsAsync(request.SettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.CalculateEffectiveSettingsAsync(request.SettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCalculateEffectiveSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            BatchCalculateEffectiveSettingsRequest request = new BatchCalculateEffectiveSettingsRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Requests =
                {
                    new CalculateEffectiveSettingsRequest(),
                },
            };
            BatchCalculateEffectiveSettingsResponse expectedResponse = new BatchCalculateEffectiveSettingsResponse
            {
                Settings = { new Settings(), },
            };
            mockGrpcClient.Setup(x => x.BatchCalculateEffectiveSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            BatchCalculateEffectiveSettingsResponse response = client.BatchCalculateEffectiveSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCalculateEffectiveSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            BatchCalculateEffectiveSettingsRequest request = new BatchCalculateEffectiveSettingsRequest
            {
                ParentAsOrganizationName = gagr::OrganizationName.FromOrganization("[ORGANIZATION]"),
                Requests =
                {
                    new CalculateEffectiveSettingsRequest(),
                },
            };
            BatchCalculateEffectiveSettingsResponse expectedResponse = new BatchCalculateEffectiveSettingsResponse
            {
                Settings = { new Settings(), },
            };
            mockGrpcClient.Setup(x => x.BatchCalculateEffectiveSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCalculateEffectiveSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            BatchCalculateEffectiveSettingsResponse responseCallSettings = await client.BatchCalculateEffectiveSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCalculateEffectiveSettingsResponse responseCancellationToken = await client.BatchCalculateEffectiveSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetComponentSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.GetComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.GetComponentSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetComponentSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.GetComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.GetComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.GetComponentSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetComponentSettings()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.GetComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.GetComponentSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetComponentSettingsAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.GetComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.GetComponentSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.GetComponentSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetComponentSettingsResourceNames()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.GetComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.GetComponentSettings(request.ComponentSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetComponentSettingsResourceNamesAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            GetComponentSettingsRequest request = new GetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.GetComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.GetComponentSettingsAsync(request.ComponentSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.GetComponentSettingsAsync(request.ComponentSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateComponentSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateComponentSettingsRequest request = new UpdateComponentSettingsRequest
            {
                ComponentSettings = new ComponentSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.UpdateComponentSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateComponentSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateComponentSettingsRequest request = new UpdateComponentSettingsRequest
            {
                ComponentSettings = new ComponentSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.UpdateComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.UpdateComponentSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateComponentSettings()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateComponentSettingsRequest request = new UpdateComponentSettingsRequest
            {
                ComponentSettings = new ComponentSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.UpdateComponentSettings(request.ComponentSettings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateComponentSettingsAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            UpdateComponentSettingsRequest request = new UpdateComponentSettingsRequest
            {
                ComponentSettings = new ComponentSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.UpdateComponentSettingsAsync(request.ComponentSettings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.UpdateComponentSettingsAsync(request.ComponentSettings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetComponentSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            ResetComponentSettingsRequest request = new ResetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResetComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            client.ResetComponentSettings(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetComponentSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            ResetComponentSettingsRequest request = new ResetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.ResetComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            await client.ResetComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.ResetComponentSettingsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateEffectiveComponentSettingsRequestObject()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.CalculateEffectiveComponentSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateEffectiveComponentSettingsRequestObjectAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.CalculateEffectiveComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.CalculateEffectiveComponentSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateEffectiveComponentSettings()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.CalculateEffectiveComponentSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateEffectiveComponentSettingsAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.CalculateEffectiveComponentSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.CalculateEffectiveComponentSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateEffectiveComponentSettingsResourceNames()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveComponentSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings response = client.CalculateEffectiveComponentSettings(request.ComponentSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateEffectiveComponentSettingsResourceNamesAsync()
        {
            moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient> mockGrpcClient = new moq::Mock<SecurityCenterSettingsService.SecurityCenterSettingsServiceClient>(moq::MockBehavior.Strict);
            CalculateEffectiveComponentSettingsRequest request = new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
            };
            ComponentSettings expectedResponse = new ComponentSettings
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                State = ComponentEnablementState.Enable,
                ProjectServiceAccount = "project_service_account52bf6805",
                DetectorSettings =
                {
                    {
                        "key8a0b6e3c",
                        new ComponentSettings.Types.DetectorSettings()
                    },
                },
                Etag = "etage8ad7218",
                UpdateTime = new wkt::Timestamp(),
                WebSecurityScannerSettings = new WebSecurityScanner(),
                ContainerThreatDetectionSettings = new ContainerThreatDetectionSettings(),
                EventThreatDetectionSettings = new EventThreatDetectionSettings(),
                SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettings(),
            };
            mockGrpcClient.Setup(x => x.CalculateEffectiveComponentSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComponentSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterSettingsServiceClient client = new SecurityCenterSettingsServiceClientImpl(mockGrpcClient.Object, null);
            ComponentSettings responseCallSettings = await client.CalculateEffectiveComponentSettingsAsync(request.ComponentSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComponentSettings responseCancellationToken = await client.CalculateEffectiveComponentSettingsAsync(request.ComponentSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
