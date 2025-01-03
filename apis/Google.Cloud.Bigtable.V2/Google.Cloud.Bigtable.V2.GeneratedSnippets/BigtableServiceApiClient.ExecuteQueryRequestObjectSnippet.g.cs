// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START bigtable_v2_generated_Bigtable_ExecuteQuery_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Cloud.Bigtable.V2;
    using Google.Protobuf;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for ExecuteQuery</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExecuteQueryRequestObject()
        {
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            ExecuteQueryRequest request = new ExecuteQueryRequest
            {
                InstanceNameAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
                Query = "",
                ProtoFormat = new ProtoFormat(),
                Params = { { "", new Value() }, },
                ResumeToken = ByteString.Empty,
            };
            // Make the request, returning a streaming response
            using BigtableServiceApiClient.ExecuteQueryStream response = bigtableServiceApiClient.ExecuteQuery(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ExecuteQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ExecuteQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END bigtable_v2_generated_Bigtable_ExecuteQuery_sync]
}
