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

namespace Google.Cloud.GkeConnect.Gateway.V1Beta1.Snippets
{
    using Google.Api;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGatewayServiceClientSnippets
    {
        /// <summary>Snippet for GetResource</summary>
        public void GetResourceRequestObject()
        {
            // Snippet: GetResource(HttpBody, CallSettings)
            // Create client
            GatewayServiceClient gatewayServiceClient = GatewayServiceClient.Create();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = gatewayServiceClient.GetResource(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAsync</summary>
        public async Task GetResourceRequestObjectAsync()
        {
            // Snippet: GetResourceAsync(HttpBody, CallSettings)
            // Additional: GetResourceAsync(HttpBody, CancellationToken)
            // Create client
            GatewayServiceClient gatewayServiceClient = await GatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = await gatewayServiceClient.GetResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PostResource</summary>
        public void PostResourceRequestObject()
        {
            // Snippet: PostResource(HttpBody, CallSettings)
            // Create client
            GatewayServiceClient gatewayServiceClient = GatewayServiceClient.Create();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = gatewayServiceClient.PostResource(request);
            // End snippet
        }

        /// <summary>Snippet for PostResourceAsync</summary>
        public async Task PostResourceRequestObjectAsync()
        {
            // Snippet: PostResourceAsync(HttpBody, CallSettings)
            // Additional: PostResourceAsync(HttpBody, CancellationToken)
            // Create client
            GatewayServiceClient gatewayServiceClient = await GatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = await gatewayServiceClient.PostResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteResource</summary>
        public void DeleteResourceRequestObject()
        {
            // Snippet: DeleteResource(HttpBody, CallSettings)
            // Create client
            GatewayServiceClient gatewayServiceClient = GatewayServiceClient.Create();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = gatewayServiceClient.DeleteResource(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAsync</summary>
        public async Task DeleteResourceRequestObjectAsync()
        {
            // Snippet: DeleteResourceAsync(HttpBody, CallSettings)
            // Additional: DeleteResourceAsync(HttpBody, CancellationToken)
            // Create client
            GatewayServiceClient gatewayServiceClient = await GatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = await gatewayServiceClient.DeleteResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PutResource</summary>
        public void PutResourceRequestObject()
        {
            // Snippet: PutResource(HttpBody, CallSettings)
            // Create client
            GatewayServiceClient gatewayServiceClient = GatewayServiceClient.Create();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = gatewayServiceClient.PutResource(request);
            // End snippet
        }

        /// <summary>Snippet for PutResourceAsync</summary>
        public async Task PutResourceRequestObjectAsync()
        {
            // Snippet: PutResourceAsync(HttpBody, CallSettings)
            // Additional: PutResourceAsync(HttpBody, CancellationToken)
            // Create client
            GatewayServiceClient gatewayServiceClient = await GatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = await gatewayServiceClient.PutResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PatchResource</summary>
        public void PatchResourceRequestObject()
        {
            // Snippet: PatchResource(HttpBody, CallSettings)
            // Create client
            GatewayServiceClient gatewayServiceClient = GatewayServiceClient.Create();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = gatewayServiceClient.PatchResource(request);
            // End snippet
        }

        /// <summary>Snippet for PatchResourceAsync</summary>
        public async Task PatchResourceRequestObjectAsync()
        {
            // Snippet: PatchResourceAsync(HttpBody, CallSettings)
            // Additional: PatchResourceAsync(HttpBody, CancellationToken)
            // Create client
            GatewayServiceClient gatewayServiceClient = await GatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = await gatewayServiceClient.PatchResourceAsync(request);
            // End snippet
        }
    }
}
