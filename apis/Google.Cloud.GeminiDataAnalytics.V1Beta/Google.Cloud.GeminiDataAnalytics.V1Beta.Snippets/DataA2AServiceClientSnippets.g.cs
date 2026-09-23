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
    using Google.Cloud.GeminiDataAnalytics.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataA2AServiceClientSnippets
    {
        /// <summary>Snippet for SendMessage</summary>
        public void SendMessageRequestObject()
        {
            // Snippet: SendMessage(SendMessageRequest, CallSettings)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = DataA2AServiceClient.Create();
            // Initialize request argument(s)
            SendMessageRequest request = new SendMessageRequest
            {
                Message = new A2AMessage(),
                Configuration = new SendMessageConfiguration(),
                Metadata = new Struct(),
                Tenant = "",
            };
            // Make the request
            SendMessageResponse response = dataA2AServiceClient.SendMessage(request);
            // End snippet
        }

        /// <summary>Snippet for SendMessageAsync</summary>
        public async Task SendMessageRequestObjectAsync()
        {
            // Snippet: SendMessageAsync(SendMessageRequest, CallSettings)
            // Additional: SendMessageAsync(SendMessageRequest, CancellationToken)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = await DataA2AServiceClient.CreateAsync();
            // Initialize request argument(s)
            SendMessageRequest request = new SendMessageRequest
            {
                Message = new A2AMessage(),
                Configuration = new SendMessageConfiguration(),
                Metadata = new Struct(),
                Tenant = "",
            };
            // Make the request
            SendMessageResponse response = await dataA2AServiceClient.SendMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SendMessage</summary>
        public void SendMessage()
        {
            // Snippet: SendMessage(string, A2AMessage, CallSettings)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = DataA2AServiceClient.Create();
            // Initialize request argument(s)
            string tenant = "";
            A2AMessage message = new A2AMessage();
            // Make the request
            SendMessageResponse response = dataA2AServiceClient.SendMessage(tenant, message);
            // End snippet
        }

        /// <summary>Snippet for SendMessageAsync</summary>
        public async Task SendMessageAsync()
        {
            // Snippet: SendMessageAsync(string, A2AMessage, CallSettings)
            // Additional: SendMessageAsync(string, A2AMessage, CancellationToken)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = await DataA2AServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tenant = "";
            A2AMessage message = new A2AMessage();
            // Make the request
            SendMessageResponse response = await dataA2AServiceClient.SendMessageAsync(tenant, message);
            // End snippet
        }

        /// <summary>Snippet for SendStreamingMessage</summary>
        public async Task SendStreamingMessageRequestObject()
        {
            // Snippet: SendStreamingMessage(SendMessageRequest, CallSettings)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = DataA2AServiceClient.Create();
            // Initialize request argument(s)
            SendMessageRequest request = new SendMessageRequest
            {
                Message = new A2AMessage(),
                Configuration = new SendMessageConfiguration(),
                Metadata = new Struct(),
                Tenant = "",
            };
            // Make the request, returning a streaming response
            using DataA2AServiceClient.SendStreamingMessageStream response = dataA2AServiceClient.SendStreamingMessage(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SendStreamingMessage</summary>
        public async Task SendStreamingMessage()
        {
            // Snippet: SendStreamingMessage(string, A2AMessage, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for GetAgentCard</summary>
        public void GetAgentCardRequestObject()
        {
            // Snippet: GetAgentCard(GetAgentCardRequest, CallSettings)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = DataA2AServiceClient.Create();
            // Initialize request argument(s)
            GetAgentCardRequest request = new GetAgentCardRequest { Tenant = "", };
            // Make the request
            AgentCard response = dataA2AServiceClient.GetAgentCard(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentCardAsync</summary>
        public async Task GetAgentCardRequestObjectAsync()
        {
            // Snippet: GetAgentCardAsync(GetAgentCardRequest, CallSettings)
            // Additional: GetAgentCardAsync(GetAgentCardRequest, CancellationToken)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = await DataA2AServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentCardRequest request = new GetAgentCardRequest { Tenant = "", };
            // Make the request
            AgentCard response = await dataA2AServiceClient.GetAgentCardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentCard</summary>
        public void GetAgentCard()
        {
            // Snippet: GetAgentCard(string, CallSettings)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = DataA2AServiceClient.Create();
            // Initialize request argument(s)
            string tenant = "";
            // Make the request
            AgentCard response = dataA2AServiceClient.GetAgentCard(tenant);
            // End snippet
        }

        /// <summary>Snippet for GetAgentCardAsync</summary>
        public async Task GetAgentCardAsync()
        {
            // Snippet: GetAgentCardAsync(string, CallSettings)
            // Additional: GetAgentCardAsync(string, CancellationToken)
            // Create client
            DataA2AServiceClient dataA2AServiceClient = await DataA2AServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tenant = "";
            // Make the request
            AgentCard response = await dataA2AServiceClient.GetAgentCardAsync(tenant);
            // End snippet
        }
    }
}
