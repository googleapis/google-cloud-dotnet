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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataQnA.V1Alpha.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAutoSuggestionServiceClientTest
    {
        [xunit::FactAttribute]
        public void SuggestQueriesRequestObject()
        {
            moq::Mock<AutoSuggestionService.AutoSuggestionServiceClient> mockGrpcClient = new moq::Mock<AutoSuggestionService.AutoSuggestionServiceClient>(moq::MockBehavior.Strict);
            SuggestQueriesRequest request = new SuggestQueriesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                SuggestionTypes =
                {
                    SuggestionType.Entity,
                },
            };
            SuggestQueriesResponse expectedResponse = new SuggestQueriesResponse
            {
                Suggestions = { new Suggestion(), },
            };
            mockGrpcClient.Setup(x => x.SuggestQueries(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AutoSuggestionServiceClient client = new AutoSuggestionServiceClientImpl(mockGrpcClient.Object, null, null);
            SuggestQueriesResponse response = client.SuggestQueries(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestQueriesRequestObjectAsync()
        {
            moq::Mock<AutoSuggestionService.AutoSuggestionServiceClient> mockGrpcClient = new moq::Mock<AutoSuggestionService.AutoSuggestionServiceClient>(moq::MockBehavior.Strict);
            SuggestQueriesRequest request = new SuggestQueriesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Scopes = { "scopes35c99a1e", },
                Query = "queryf0c71c1b",
                SuggestionTypes =
                {
                    SuggestionType.Entity,
                },
            };
            SuggestQueriesResponse expectedResponse = new SuggestQueriesResponse
            {
                Suggestions = { new Suggestion(), },
            };
            mockGrpcClient.Setup(x => x.SuggestQueriesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestQueriesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AutoSuggestionServiceClient client = new AutoSuggestionServiceClientImpl(mockGrpcClient.Object, null, null);
            SuggestQueriesResponse responseCallSettings = await client.SuggestQueriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestQueriesResponse responseCancellationToken = await client.SuggestQueriesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
