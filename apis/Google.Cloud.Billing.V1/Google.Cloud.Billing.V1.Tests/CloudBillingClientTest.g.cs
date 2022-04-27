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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Billing.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudBillingClientTest
    {
        [xunit::FactAttribute]
        public void GetBillingAccountRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.GetBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.GetBillingAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBillingAccountRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.GetBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.GetBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.GetBillingAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBillingAccount()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.GetBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.GetBillingAccount(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBillingAccountAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.GetBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.GetBillingAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.GetBillingAccountAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBillingAccountResourceNames()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.GetBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.GetBillingAccount(request.BillingAccountName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBillingAccountResourceNamesAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.GetBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.GetBillingAccountAsync(request.BillingAccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.GetBillingAccountAsync(request.BillingAccountName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBillingAccountRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
                UpdateMask = new wkt::FieldMask(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.UpdateBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.UpdateBillingAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBillingAccountRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
                UpdateMask = new wkt::FieldMask(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.UpdateBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.UpdateBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.UpdateBillingAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBillingAccount()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.UpdateBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.UpdateBillingAccount(request.Name, request.Account);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBillingAccountAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.UpdateBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.UpdateBillingAccountAsync(request.Name, request.Account, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.UpdateBillingAccountAsync(request.Name, request.Account, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBillingAccountResourceNames()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.UpdateBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.UpdateBillingAccount(request.BillingAccountName, request.Account);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBillingAccountResourceNamesAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.UpdateBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.UpdateBillingAccountAsync(request.BillingAccountName, request.Account, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.UpdateBillingAccountAsync(request.BillingAccountName, request.Account, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBillingAccountRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            CreateBillingAccountRequest request = new CreateBillingAccountRequest
            {
                BillingAccount = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.CreateBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.CreateBillingAccount(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBillingAccountRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            CreateBillingAccountRequest request = new CreateBillingAccountRequest
            {
                BillingAccount = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.CreateBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.CreateBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.CreateBillingAccountAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBillingAccount()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            CreateBillingAccountRequest request = new CreateBillingAccountRequest
            {
                BillingAccount = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.CreateBillingAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount response = client.CreateBillingAccount(request.BillingAccount);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBillingAccountAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            CreateBillingAccountRequest request = new CreateBillingAccountRequest
            {
                BillingAccount = new BillingAccount(),
            };
            BillingAccount expectedResponse = new BillingAccount
            {
                BillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Open = true,
                DisplayName = "display_name137f65c2",
                MasterBillingAccount = "master_billing_account42bd6a27",
            };
            mockGrpcClient.Setup(x => x.CreateBillingAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BillingAccount>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            BillingAccount responseCallSettings = await client.CreateBillingAccountAsync(request.BillingAccount, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BillingAccount responseCancellationToken = await client.CreateBillingAccountAsync(request.BillingAccount, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProjectBillingInfoRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetProjectBillingInfoRequest request = new GetProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetProjectBillingInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo response = client.GetProjectBillingInfo(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProjectBillingInfoRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetProjectBillingInfoRequest request = new GetProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetProjectBillingInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProjectBillingInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo responseCallSettings = await client.GetProjectBillingInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProjectBillingInfo responseCancellationToken = await client.GetProjectBillingInfoAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetProjectBillingInfo()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetProjectBillingInfoRequest request = new GetProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetProjectBillingInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo response = client.GetProjectBillingInfo(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetProjectBillingInfoAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            GetProjectBillingInfoRequest request = new GetProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.GetProjectBillingInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProjectBillingInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo responseCallSettings = await client.GetProjectBillingInfoAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProjectBillingInfo responseCancellationToken = await client.GetProjectBillingInfoAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProjectBillingInfoRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateProjectBillingInfoRequest request = new UpdateProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
                ProjectBillingInfo = new ProjectBillingInfo(),
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateProjectBillingInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo response = client.UpdateProjectBillingInfo(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProjectBillingInfoRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateProjectBillingInfoRequest request = new UpdateProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
                ProjectBillingInfo = new ProjectBillingInfo(),
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateProjectBillingInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProjectBillingInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo responseCallSettings = await client.UpdateProjectBillingInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProjectBillingInfo responseCancellationToken = await client.UpdateProjectBillingInfoAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProjectBillingInfo()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateProjectBillingInfoRequest request = new UpdateProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
                ProjectBillingInfo = new ProjectBillingInfo(),
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateProjectBillingInfo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo response = client.UpdateProjectBillingInfo(request.Name, request.ProjectBillingInfo);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProjectBillingInfoAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            UpdateProjectBillingInfoRequest request = new UpdateProjectBillingInfoRequest
            {
                Name = "name1c9368b0",
                ProjectBillingInfo = new ProjectBillingInfo(),
            };
            ProjectBillingInfo expectedResponse = new ProjectBillingInfo
            {
                Name = "name1c9368b0",
                ProjectId = "project_id43ad98b0",
                BillingAccountName = "billing_account_name68d77850",
                BillingEnabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateProjectBillingInfoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProjectBillingInfo>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            ProjectBillingInfo responseCallSettings = await client.UpdateProjectBillingInfoAsync(request.Name, request.ProjectBillingInfo, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProjectBillingInfo responseCancellationToken = await client.UpdateProjectBillingInfoAsync(request.Name, request.ProjectBillingInfo, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<CloudBilling.CloudBillingClient> mockGrpcClient = new moq::Mock<CloudBilling.CloudBillingClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudBillingClient client = new CloudBillingClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
