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
    // [START geminidataanalytics_v1beta_generated_DataA2AService_SendStreamingMessage_sync_flattened]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.GeminiDataAnalytics.V1Beta;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataA2AServiceClientSnippets
    {
        /// <summary>Snippet for SendStreamingMessage</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task SendStreamingMessage()
        {
            // Create client
            DataA2AServiceClient dataA2AServiceClient = DataA2AServiceClient.Create();
            // Initialize request argument(s)
            string tenant = "";
            A2AMessage message = new A2AMessage();
            // Make the request, returning a streaming response
            using DataA2AServiceClient.SendStreamingMessageStream response = dataA2AServiceClient.SendStreamingMessage(tenant, message);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END geminidataanalytics_v1beta_generated_DataA2AService_SendStreamingMessage_sync_flattened]
}
