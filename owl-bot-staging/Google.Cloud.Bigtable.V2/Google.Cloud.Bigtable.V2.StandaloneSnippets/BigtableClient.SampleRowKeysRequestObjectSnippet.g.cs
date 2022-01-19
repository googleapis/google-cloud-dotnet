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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableClientStandaloneSnippets
    {
        /// <summary>Snippet for SampleRowKeys</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task SampleRowKeysRequestObject()
        {
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            SampleRowKeysRequest request = new SampleRowKeysRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AppProfileId = "",
            };
            // Make the request, returning a streaming response
            BigtableClient.SampleRowKeysStream response = bigtableClient.SampleRowKeys(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
}
