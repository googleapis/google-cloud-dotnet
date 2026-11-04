// Copyright 2026 Google LLC
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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Sql.V1Beta4;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlDataServiceClientSnippets
    {
        /// <summary>Snippet for StreamSqlData</summary>
        public async Task StreamSqlData()
        {
            // Snippet: StreamSqlData(CallSettings, BidirectionalStreamingSettings)
            // Create client
            SqlDataServiceClient sqlDataServiceClient = SqlDataServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using SqlDataServiceClient.StreamSqlDataStream response = sqlDataServiceClient.StreamSqlData();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamSqlDataResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamSqlDataResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamSqlDataRequest request = new StreamSqlDataRequest
                {
                    Ack = new Ack(),
                    StartSession = new StartSession(),
                    InstanceIdAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }
    }
}
