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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Retail.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCompletionServiceClientTest
    {
        [xunit::FactAttribute]
        public void CompleteQueryRequestObject()
        {
            moq::Mock<CompletionService.CompletionServiceClient> mockGrpcClient = new moq::Mock<CompletionService.CompletionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Query = "queryf0c71c1b",
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
                DeviceType = "device_typef69395c0",
                MaxSuggestions = -1310933316,
                Dataset = "datasete4094d3c",
                VisitorId = "visitor_id25f1c2bf",
            };
            CompleteQueryResponse expectedResponse = new CompleteQueryResponse
            {
                CompletionResults =
                {
                    new CompleteQueryResponse.Types.CompletionResult(),
                },
                AttributionToken = "attribution_token14371a88",
                RecentSearchResults =
                {
                    new CompleteQueryResponse.Types.RecentSearchResult(),
                },
            };
            mockGrpcClient.Setup(x => x.CompleteQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CompletionServiceClient client = new CompletionServiceClientImpl(mockGrpcClient.Object, null);
            CompleteQueryResponse response = client.CompleteQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteQueryRequestObjectAsync()
        {
            moq::Mock<CompletionService.CompletionServiceClient> mockGrpcClient = new moq::Mock<CompletionService.CompletionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Query = "queryf0c71c1b",
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
                DeviceType = "device_typef69395c0",
                MaxSuggestions = -1310933316,
                Dataset = "datasete4094d3c",
                VisitorId = "visitor_id25f1c2bf",
            };
            CompleteQueryResponse expectedResponse = new CompleteQueryResponse
            {
                CompletionResults =
                {
                    new CompleteQueryResponse.Types.CompletionResult(),
                },
                AttributionToken = "attribution_token14371a88",
                RecentSearchResults =
                {
                    new CompleteQueryResponse.Types.RecentSearchResult(),
                },
            };
            mockGrpcClient.Setup(x => x.CompleteQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompleteQueryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CompletionServiceClient client = new CompletionServiceClientImpl(mockGrpcClient.Object, null);
            CompleteQueryResponse responseCallSettings = await client.CompleteQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompleteQueryResponse responseCancellationToken = await client.CompleteQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
