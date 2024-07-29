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

namespace GoogleCSharpSnippets
{
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExtensionExecutionServiceClientSnippets
    {
        /// <summary>Snippet for ExecuteExtension</summary>
        public void ExecuteExtensionRequestObject()
        {
            // Snippet: ExecuteExtension(ExecuteExtensionRequest, CallSettings)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = ExtensionExecutionServiceClient.Create();
            // Initialize request argument(s)
            ExecuteExtensionRequest request = new ExecuteExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
                OperationId = "",
                OperationParams = new Struct(),
                RuntimeAuthConfig = new AuthConfig(),
            };
            // Make the request
            ExecuteExtensionResponse response = extensionExecutionServiceClient.ExecuteExtension(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteExtensionAsync</summary>
        public async Task ExecuteExtensionRequestObjectAsync()
        {
            // Snippet: ExecuteExtensionAsync(ExecuteExtensionRequest, CallSettings)
            // Additional: ExecuteExtensionAsync(ExecuteExtensionRequest, CancellationToken)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = await ExtensionExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteExtensionRequest request = new ExecuteExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
                OperationId = "",
                OperationParams = new Struct(),
                RuntimeAuthConfig = new AuthConfig(),
            };
            // Make the request
            ExecuteExtensionResponse response = await extensionExecutionServiceClient.ExecuteExtensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteExtension</summary>
        public void ExecuteExtension()
        {
            // Snippet: ExecuteExtension(string, string, CallSettings)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = ExtensionExecutionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            string operationId = "";
            // Make the request
            ExecuteExtensionResponse response = extensionExecutionServiceClient.ExecuteExtension(name, operationId);
            // End snippet
        }

        /// <summary>Snippet for ExecuteExtensionAsync</summary>
        public async Task ExecuteExtensionAsync()
        {
            // Snippet: ExecuteExtensionAsync(string, string, CallSettings)
            // Additional: ExecuteExtensionAsync(string, string, CancellationToken)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = await ExtensionExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            string operationId = "";
            // Make the request
            ExecuteExtensionResponse response = await extensionExecutionServiceClient.ExecuteExtensionAsync(name, operationId);
            // End snippet
        }

        /// <summary>Snippet for ExecuteExtension</summary>
        public void ExecuteExtensionResourceNames()
        {
            // Snippet: ExecuteExtension(ExtensionName, string, CallSettings)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = ExtensionExecutionServiceClient.Create();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            string operationId = "";
            // Make the request
            ExecuteExtensionResponse response = extensionExecutionServiceClient.ExecuteExtension(name, operationId);
            // End snippet
        }

        /// <summary>Snippet for ExecuteExtensionAsync</summary>
        public async Task ExecuteExtensionResourceNamesAsync()
        {
            // Snippet: ExecuteExtensionAsync(ExtensionName, string, CallSettings)
            // Additional: ExecuteExtensionAsync(ExtensionName, string, CancellationToken)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = await ExtensionExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            string operationId = "";
            // Make the request
            ExecuteExtensionResponse response = await extensionExecutionServiceClient.ExecuteExtensionAsync(name, operationId);
            // End snippet
        }

        /// <summary>Snippet for QueryExtension</summary>
        public void QueryExtensionRequestObject()
        {
            // Snippet: QueryExtension(QueryExtensionRequest, CallSettings)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = ExtensionExecutionServiceClient.Create();
            // Initialize request argument(s)
            QueryExtensionRequest request = new QueryExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
                Contents = { new Content(), },
            };
            // Make the request
            QueryExtensionResponse response = extensionExecutionServiceClient.QueryExtension(request);
            // End snippet
        }

        /// <summary>Snippet for QueryExtensionAsync</summary>
        public async Task QueryExtensionRequestObjectAsync()
        {
            // Snippet: QueryExtensionAsync(QueryExtensionRequest, CallSettings)
            // Additional: QueryExtensionAsync(QueryExtensionRequest, CancellationToken)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = await ExtensionExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryExtensionRequest request = new QueryExtensionRequest
            {
                ExtensionName = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]"),
                Contents = { new Content(), },
            };
            // Make the request
            QueryExtensionResponse response = await extensionExecutionServiceClient.QueryExtensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryExtension</summary>
        public void QueryExtension()
        {
            // Snippet: QueryExtension(string, IEnumerable<Content>, CallSettings)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = ExtensionExecutionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request
            QueryExtensionResponse response = extensionExecutionServiceClient.QueryExtension(name, contents);
            // End snippet
        }

        /// <summary>Snippet for QueryExtensionAsync</summary>
        public async Task QueryExtensionAsync()
        {
            // Snippet: QueryExtensionAsync(string, IEnumerable<Content>, CallSettings)
            // Additional: QueryExtensionAsync(string, IEnumerable<Content>, CancellationToken)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = await ExtensionExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/extensions/[EXTENSION]";
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request
            QueryExtensionResponse response = await extensionExecutionServiceClient.QueryExtensionAsync(name, contents);
            // End snippet
        }

        /// <summary>Snippet for QueryExtension</summary>
        public void QueryExtensionResourceNames()
        {
            // Snippet: QueryExtension(ExtensionName, IEnumerable<Content>, CallSettings)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = ExtensionExecutionServiceClient.Create();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request
            QueryExtensionResponse response = extensionExecutionServiceClient.QueryExtension(name, contents);
            // End snippet
        }

        /// <summary>Snippet for QueryExtensionAsync</summary>
        public async Task QueryExtensionResourceNamesAsync()
        {
            // Snippet: QueryExtensionAsync(ExtensionName, IEnumerable<Content>, CallSettings)
            // Additional: QueryExtensionAsync(ExtensionName, IEnumerable<Content>, CancellationToken)
            // Create client
            ExtensionExecutionServiceClient extensionExecutionServiceClient = await ExtensionExecutionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExtensionName name = ExtensionName.FromProjectLocationExtension("[PROJECT]", "[LOCATION]", "[EXTENSION]");
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request
            QueryExtensionResponse response = await extensionExecutionServiceClient.QueryExtensionAsync(name, contents);
            // End snippet
        }
    }
}
