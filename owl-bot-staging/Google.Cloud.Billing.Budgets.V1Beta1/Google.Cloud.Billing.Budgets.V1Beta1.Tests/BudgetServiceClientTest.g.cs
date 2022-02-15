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

namespace Google.Cloud.Billing.Budgets.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBudgetServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateBudgetRequestObject()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            CreateBudgetRequest request = new CreateBudgetRequest
            {
                ParentAsBillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Budget = new Budget(),
            };
            Budget expectedResponse = new Budget
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
                DisplayName = "display_name137f65c2",
                BudgetFilter = new Filter(),
                Amount = new BudgetAmount(),
                ThresholdRules =
                {
                    new ThresholdRule(),
                },
                AllUpdatesRule = new AllUpdatesRule(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            Budget response = client.CreateBudget(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBudgetRequestObjectAsync()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            CreateBudgetRequest request = new CreateBudgetRequest
            {
                ParentAsBillingAccountName = gagr::BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Budget = new Budget(),
            };
            Budget expectedResponse = new Budget
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
                DisplayName = "display_name137f65c2",
                BudgetFilter = new Filter(),
                Amount = new BudgetAmount(),
                ThresholdRules =
                {
                    new ThresholdRule(),
                },
                AllUpdatesRule = new AllUpdatesRule(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Budget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            Budget responseCallSettings = await client.CreateBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Budget responseCancellationToken = await client.CreateBudgetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBudgetRequestObject()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            UpdateBudgetRequest request = new UpdateBudgetRequest
            {
                Budget = new Budget(),
                UpdateMask = new wkt::FieldMask(),
            };
            Budget expectedResponse = new Budget
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
                DisplayName = "display_name137f65c2",
                BudgetFilter = new Filter(),
                Amount = new BudgetAmount(),
                ThresholdRules =
                {
                    new ThresholdRule(),
                },
                AllUpdatesRule = new AllUpdatesRule(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            Budget response = client.UpdateBudget(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBudgetRequestObjectAsync()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            UpdateBudgetRequest request = new UpdateBudgetRequest
            {
                Budget = new Budget(),
                UpdateMask = new wkt::FieldMask(),
            };
            Budget expectedResponse = new Budget
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
                DisplayName = "display_name137f65c2",
                BudgetFilter = new Filter(),
                Amount = new BudgetAmount(),
                ThresholdRules =
                {
                    new ThresholdRule(),
                },
                AllUpdatesRule = new AllUpdatesRule(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Budget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            Budget responseCallSettings = await client.UpdateBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Budget responseCancellationToken = await client.UpdateBudgetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBudgetRequestObject()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            GetBudgetRequest request = new GetBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            Budget expectedResponse = new Budget
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
                DisplayName = "display_name137f65c2",
                BudgetFilter = new Filter(),
                Amount = new BudgetAmount(),
                ThresholdRules =
                {
                    new ThresholdRule(),
                },
                AllUpdatesRule = new AllUpdatesRule(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            Budget response = client.GetBudget(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBudgetRequestObjectAsync()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            GetBudgetRequest request = new GetBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            Budget expectedResponse = new Budget
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
                DisplayName = "display_name137f65c2",
                BudgetFilter = new Filter(),
                Amount = new BudgetAmount(),
                ThresholdRules =
                {
                    new ThresholdRule(),
                },
                AllUpdatesRule = new AllUpdatesRule(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Budget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            Budget responseCallSettings = await client.GetBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Budget responseCancellationToken = await client.GetBudgetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBudgetRequestObject()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            DeleteBudgetRequest request = new DeleteBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteBudget(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBudgetRequestObjectAsync()
        {
            moq::Mock<BudgetService.BudgetServiceClient> mockGrpcClient = new moq::Mock<BudgetService.BudgetServiceClient>(moq::MockBehavior.Strict);
            DeleteBudgetRequest request = new DeleteBudgetRequest
            {
                BudgetName = BudgetName.FromBillingAccountBudget("[BILLING_ACCOUNT]", "[BUDGET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BudgetServiceClient client = new BudgetServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBudgetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
