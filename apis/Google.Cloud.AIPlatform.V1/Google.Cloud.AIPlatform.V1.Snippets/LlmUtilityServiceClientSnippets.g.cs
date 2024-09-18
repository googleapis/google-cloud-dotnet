// Copyright 2024 Google LLC
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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLlmUtilityServiceClientSnippets
    {
        /// <summary>Snippet for CountTokens</summary>
        public void CountTokensRequestObject()
        {
            // Snippet: CountTokens(CountTokensRequest, CallSettings)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = LlmUtilityServiceClient.Create();
            // Initialize request argument(s)
            CountTokensRequest request = new CountTokensRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Model = "",
                Contents = { new Content(), },
                SystemInstruction = new Content(),
                Tools = { new Tool(), },
                GenerationConfig = new GenerationConfig(),
            };
            // Make the request
            CountTokensResponse response = llmUtilityServiceClient.CountTokens(request);
            // End snippet
        }

        /// <summary>Snippet for CountTokensAsync</summary>
        public async Task CountTokensRequestObjectAsync()
        {
            // Snippet: CountTokensAsync(CountTokensRequest, CallSettings)
            // Additional: CountTokensAsync(CountTokensRequest, CancellationToken)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = await LlmUtilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CountTokensRequest request = new CountTokensRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Model = "",
                Contents = { new Content(), },
                SystemInstruction = new Content(),
                Tools = { new Tool(), },
                GenerationConfig = new GenerationConfig(),
            };
            // Make the request
            CountTokensResponse response = await llmUtilityServiceClient.CountTokensAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CountTokens</summary>
        public void CountTokens()
        {
            // Snippet: CountTokens(string, IEnumerable<Value>, CallSettings)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = LlmUtilityServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = llmUtilityServiceClient.CountTokens(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for CountTokensAsync</summary>
        public async Task CountTokensAsync()
        {
            // Snippet: CountTokensAsync(string, IEnumerable<Value>, CallSettings)
            // Additional: CountTokensAsync(string, IEnumerable<Value>, CancellationToken)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = await LlmUtilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = await llmUtilityServiceClient.CountTokensAsync(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for CountTokens</summary>
        public void CountTokensResourceNames()
        {
            // Snippet: CountTokens(EndpointName, IEnumerable<Value>, CallSettings)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = LlmUtilityServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = llmUtilityServiceClient.CountTokens(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for CountTokensAsync</summary>
        public async Task CountTokensResourceNamesAsync()
        {
            // Snippet: CountTokensAsync(EndpointName, IEnumerable<Value>, CallSettings)
            // Additional: CountTokensAsync(EndpointName, IEnumerable<Value>, CancellationToken)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = await LlmUtilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = await llmUtilityServiceClient.CountTokensAsync(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for ComputeTokens</summary>
        public void ComputeTokensRequestObject()
        {
            // Snippet: ComputeTokens(ComputeTokensRequest, CallSettings)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = LlmUtilityServiceClient.Create();
            // Initialize request argument(s)
            ComputeTokensRequest request = new ComputeTokensRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Model = "",
                Contents = { new Content(), },
            };
            // Make the request
            ComputeTokensResponse response = llmUtilityServiceClient.ComputeTokens(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeTokensAsync</summary>
        public async Task ComputeTokensRequestObjectAsync()
        {
            // Snippet: ComputeTokensAsync(ComputeTokensRequest, CallSettings)
            // Additional: ComputeTokensAsync(ComputeTokensRequest, CancellationToken)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = await LlmUtilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeTokensRequest request = new ComputeTokensRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Model = "",
                Contents = { new Content(), },
            };
            // Make the request
            ComputeTokensResponse response = await llmUtilityServiceClient.ComputeTokensAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeTokens</summary>
        public void ComputeTokens()
        {
            // Snippet: ComputeTokens(string, IEnumerable<Value>, CallSettings)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = LlmUtilityServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            ComputeTokensResponse response = llmUtilityServiceClient.ComputeTokens(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for ComputeTokensAsync</summary>
        public async Task ComputeTokensAsync()
        {
            // Snippet: ComputeTokensAsync(string, IEnumerable<Value>, CallSettings)
            // Additional: ComputeTokensAsync(string, IEnumerable<Value>, CancellationToken)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = await LlmUtilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            ComputeTokensResponse response = await llmUtilityServiceClient.ComputeTokensAsync(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for ComputeTokens</summary>
        public void ComputeTokensResourceNames()
        {
            // Snippet: ComputeTokens(EndpointName, IEnumerable<Value>, CallSettings)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = LlmUtilityServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            ComputeTokensResponse response = llmUtilityServiceClient.ComputeTokens(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for ComputeTokensAsync</summary>
        public async Task ComputeTokensResourceNamesAsync()
        {
            // Snippet: ComputeTokensAsync(EndpointName, IEnumerable<Value>, CallSettings)
            // Additional: ComputeTokensAsync(EndpointName, IEnumerable<Value>, CancellationToken)
            // Create client
            LlmUtilityServiceClient llmUtilityServiceClient = await LlmUtilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            ComputeTokensResponse response = await llmUtilityServiceClient.ComputeTokensAsync(endpoint, instances);
            // End snippet
        }
    }
}
