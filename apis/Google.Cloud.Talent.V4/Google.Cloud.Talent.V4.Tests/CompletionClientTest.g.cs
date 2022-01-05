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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCompletionClientTest
    {
        [xunit::FactAttribute]
        public void CompleteQueryRequestObject()
        {
            moq::Mock<Completion.CompletionClient> mockGrpcClient = new moq::Mock<Completion.CompletionClient>(moq::MockBehavior.Strict);
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                TenantAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Query = "queryf0c71c1b",
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
                PageSize = -226905851,
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                Scope = CompleteQueryRequest.Types.CompletionScope.Unspecified,
                Type = CompleteQueryRequest.Types.CompletionType.Combined,
            };
            CompleteQueryResponse expectedResponse = new CompleteQueryResponse
            {
                CompletionResults =
                {
                    new CompleteQueryResponse.Types.CompletionResult(),
                },
                Metadata = new ResponseMetadata(),
            };
            mockGrpcClient.Setup(x => x.CompleteQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompletionClient client = new CompletionClientImpl(mockGrpcClient.Object, null);
            CompleteQueryResponse response = client.CompleteQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteQueryRequestObjectAsync()
        {
            moq::Mock<Completion.CompletionClient> mockGrpcClient = new moq::Mock<Completion.CompletionClient>(moq::MockBehavior.Strict);
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                TenantAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Query = "queryf0c71c1b",
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
                PageSize = -226905851,
                CompanyAsCompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
                Scope = CompleteQueryRequest.Types.CompletionScope.Unspecified,
                Type = CompleteQueryRequest.Types.CompletionType.Combined,
            };
            CompleteQueryResponse expectedResponse = new CompleteQueryResponse
            {
                CompletionResults =
                {
                    new CompleteQueryResponse.Types.CompletionResult(),
                },
                Metadata = new ResponseMetadata(),
            };
            mockGrpcClient.Setup(x => x.CompleteQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompleteQueryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompletionClient client = new CompletionClientImpl(mockGrpcClient.Object, null);
            CompleteQueryResponse responseCallSettings = await client.CompleteQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompleteQueryResponse responseCancellationToken = await client.CompleteQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
