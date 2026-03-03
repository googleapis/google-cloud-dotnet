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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVertexRagServiceClientSnippets
    {
        /// <summary>Snippet for RetrieveContexts</summary>
        public void RetrieveContextsRequestObject()
        {
            // Snippet: RetrieveContexts(RetrieveContextsRequest, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            RetrieveContextsRequest request = new RetrieveContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VertexRagStore = new RetrieveContextsRequest.Types.VertexRagStore(),
                Query = new RagQuery(),
            };
            // Make the request
            RetrieveContextsResponse response = vertexRagServiceClient.RetrieveContexts(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContextsAsync</summary>
        public async Task RetrieveContextsRequestObjectAsync()
        {
            // Snippet: RetrieveContextsAsync(RetrieveContextsRequest, CallSettings)
            // Additional: RetrieveContextsAsync(RetrieveContextsRequest, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveContextsRequest request = new RetrieveContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VertexRagStore = new RetrieveContextsRequest.Types.VertexRagStore(),
                Query = new RagQuery(),
            };
            // Make the request
            RetrieveContextsResponse response = await vertexRagServiceClient.RetrieveContextsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContexts</summary>
        public void RetrieveContexts()
        {
            // Snippet: RetrieveContexts(string, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = vertexRagServiceClient.RetrieveContexts(parent, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContextsAsync</summary>
        public async Task RetrieveContextsAsync()
        {
            // Snippet: RetrieveContextsAsync(string, RagQuery, CallSettings)
            // Additional: RetrieveContextsAsync(string, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = await vertexRagServiceClient.RetrieveContextsAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContexts</summary>
        public void RetrieveContextsResourceNames()
        {
            // Snippet: RetrieveContexts(LocationName, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = vertexRagServiceClient.RetrieveContexts(parent, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveContextsAsync</summary>
        public async Task RetrieveContextsResourceNamesAsync()
        {
            // Snippet: RetrieveContextsAsync(LocationName, RagQuery, CallSettings)
            // Additional: RetrieveContextsAsync(LocationName, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            RetrieveContextsResponse response = await vertexRagServiceClient.RetrieveContextsAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for AugmentPrompt</summary>
        public void AugmentPromptRequestObject()
        {
            // Snippet: AugmentPrompt(AugmentPromptRequest, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            AugmentPromptRequest request = new AugmentPromptRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Contents = { new Content(), },
                Model = new AugmentPromptRequest.Types.Model(),
                VertexRagStore = new VertexRagStore(),
            };
            // Make the request
            AugmentPromptResponse response = vertexRagServiceClient.AugmentPrompt(request);
            // End snippet
        }

        /// <summary>Snippet for AugmentPromptAsync</summary>
        public async Task AugmentPromptRequestObjectAsync()
        {
            // Snippet: AugmentPromptAsync(AugmentPromptRequest, CallSettings)
            // Additional: AugmentPromptAsync(AugmentPromptRequest, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            AugmentPromptRequest request = new AugmentPromptRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Contents = { new Content(), },
                Model = new AugmentPromptRequest.Types.Model(),
                VertexRagStore = new VertexRagStore(),
            };
            // Make the request
            AugmentPromptResponse response = await vertexRagServiceClient.AugmentPromptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AugmentPrompt</summary>
        public void AugmentPrompt()
        {
            // Snippet: AugmentPrompt(string, AugmentPromptRequest.Types.Model, VertexRagStore, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AugmentPromptRequest.Types.Model model = new AugmentPromptRequest.Types.Model();
            VertexRagStore vertexRagStore = new VertexRagStore();
            // Make the request
            AugmentPromptResponse response = vertexRagServiceClient.AugmentPrompt(parent, model, vertexRagStore);
            // End snippet
        }

        /// <summary>Snippet for AugmentPromptAsync</summary>
        public async Task AugmentPromptAsync()
        {
            // Snippet: AugmentPromptAsync(string, AugmentPromptRequest.Types.Model, VertexRagStore, CallSettings)
            // Additional: AugmentPromptAsync(string, AugmentPromptRequest.Types.Model, VertexRagStore, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AugmentPromptRequest.Types.Model model = new AugmentPromptRequest.Types.Model();
            VertexRagStore vertexRagStore = new VertexRagStore();
            // Make the request
            AugmentPromptResponse response = await vertexRagServiceClient.AugmentPromptAsync(parent, model, vertexRagStore);
            // End snippet
        }

        /// <summary>Snippet for AugmentPrompt</summary>
        public void AugmentPromptResourceNames()
        {
            // Snippet: AugmentPrompt(LocationName, AugmentPromptRequest.Types.Model, VertexRagStore, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AugmentPromptRequest.Types.Model model = new AugmentPromptRequest.Types.Model();
            VertexRagStore vertexRagStore = new VertexRagStore();
            // Make the request
            AugmentPromptResponse response = vertexRagServiceClient.AugmentPrompt(parent, model, vertexRagStore);
            // End snippet
        }

        /// <summary>Snippet for AugmentPromptAsync</summary>
        public async Task AugmentPromptResourceNamesAsync()
        {
            // Snippet: AugmentPromptAsync(LocationName, AugmentPromptRequest.Types.Model, VertexRagStore, CallSettings)
            // Additional: AugmentPromptAsync(LocationName, AugmentPromptRequest.Types.Model, VertexRagStore, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AugmentPromptRequest.Types.Model model = new AugmentPromptRequest.Types.Model();
            VertexRagStore vertexRagStore = new VertexRagStore();
            // Make the request
            AugmentPromptResponse response = await vertexRagServiceClient.AugmentPromptAsync(parent, model, vertexRagStore);
            // End snippet
        }

        /// <summary>Snippet for CorroborateContent</summary>
        public void CorroborateContentRequestObject()
        {
            // Snippet: CorroborateContent(CorroborateContentRequest, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            CorroborateContentRequest request = new CorroborateContentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Content = new Content(),
                Facts = { new Fact(), },
                Parameters = new CorroborateContentRequest.Types.Parameters(),
            };
            // Make the request
            CorroborateContentResponse response = vertexRagServiceClient.CorroborateContent(request);
            // End snippet
        }

        /// <summary>Snippet for CorroborateContentAsync</summary>
        public async Task CorroborateContentRequestObjectAsync()
        {
            // Snippet: CorroborateContentAsync(CorroborateContentRequest, CallSettings)
            // Additional: CorroborateContentAsync(CorroborateContentRequest, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            CorroborateContentRequest request = new CorroborateContentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Content = new Content(),
                Facts = { new Fact(), },
                Parameters = new CorroborateContentRequest.Types.Parameters(),
            };
            // Make the request
            CorroborateContentResponse response = await vertexRagServiceClient.CorroborateContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CorroborateContent</summary>
        public void CorroborateContent()
        {
            // Snippet: CorroborateContent(string, Content, IEnumerable<Fact>, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Content content = new Content();
            IEnumerable<Fact> facts = new Fact[] { new Fact(), };
            // Make the request
            CorroborateContentResponse response = vertexRagServiceClient.CorroborateContent(parent, content, facts);
            // End snippet
        }

        /// <summary>Snippet for CorroborateContentAsync</summary>
        public async Task CorroborateContentAsync()
        {
            // Snippet: CorroborateContentAsync(string, Content, IEnumerable<Fact>, CallSettings)
            // Additional: CorroborateContentAsync(string, Content, IEnumerable<Fact>, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Content content = new Content();
            IEnumerable<Fact> facts = new Fact[] { new Fact(), };
            // Make the request
            CorroborateContentResponse response = await vertexRagServiceClient.CorroborateContentAsync(parent, content, facts);
            // End snippet
        }

        /// <summary>Snippet for CorroborateContent</summary>
        public void CorroborateContentResourceNames()
        {
            // Snippet: CorroborateContent(LocationName, Content, IEnumerable<Fact>, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Content content = new Content();
            IEnumerable<Fact> facts = new Fact[] { new Fact(), };
            // Make the request
            CorroborateContentResponse response = vertexRagServiceClient.CorroborateContent(parent, content, facts);
            // End snippet
        }

        /// <summary>Snippet for CorroborateContentAsync</summary>
        public async Task CorroborateContentResourceNamesAsync()
        {
            // Snippet: CorroborateContentAsync(LocationName, Content, IEnumerable<Fact>, CallSettings)
            // Additional: CorroborateContentAsync(LocationName, Content, IEnumerable<Fact>, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Content content = new Content();
            IEnumerable<Fact> facts = new Fact[] { new Fact(), };
            // Make the request
            CorroborateContentResponse response = await vertexRagServiceClient.CorroborateContentAsync(parent, content, facts);
            // End snippet
        }

        /// <summary>Snippet for AskContexts</summary>
        public void AskContextsRequestObject()
        {
            // Snippet: AskContexts(AskContextsRequest, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            AskContextsRequest request = new AskContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = new RagQuery(),
                Tools = { new Tool(), },
            };
            // Make the request
            AskContextsResponse response = vertexRagServiceClient.AskContexts(request);
            // End snippet
        }

        /// <summary>Snippet for AskContextsAsync</summary>
        public async Task AskContextsRequestObjectAsync()
        {
            // Snippet: AskContextsAsync(AskContextsRequest, CallSettings)
            // Additional: AskContextsAsync(AskContextsRequest, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            AskContextsRequest request = new AskContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = new RagQuery(),
                Tools = { new Tool(), },
            };
            // Make the request
            AskContextsResponse response = await vertexRagServiceClient.AskContextsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AskContexts</summary>
        public void AskContexts()
        {
            // Snippet: AskContexts(string, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            AskContextsResponse response = vertexRagServiceClient.AskContexts(parent, query);
            // End snippet
        }

        /// <summary>Snippet for AskContextsAsync</summary>
        public async Task AskContextsAsync()
        {
            // Snippet: AskContextsAsync(string, RagQuery, CallSettings)
            // Additional: AskContextsAsync(string, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            AskContextsResponse response = await vertexRagServiceClient.AskContextsAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for AskContexts</summary>
        public void AskContextsResourceNames()
        {
            // Snippet: AskContexts(LocationName, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            AskContextsResponse response = vertexRagServiceClient.AskContexts(parent, query);
            // End snippet
        }

        /// <summary>Snippet for AskContextsAsync</summary>
        public async Task AskContextsResourceNamesAsync()
        {
            // Snippet: AskContextsAsync(LocationName, RagQuery, CallSettings)
            // Additional: AskContextsAsync(LocationName, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            AskContextsResponse response = await vertexRagServiceClient.AskContextsAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for AsyncRetrieveContexts</summary>
        public void AsyncRetrieveContextsRequestObject()
        {
            // Snippet: AsyncRetrieveContexts(AsyncRetrieveContextsRequest, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            AsyncRetrieveContextsRequest request = new AsyncRetrieveContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = new RagQuery(),
                Tools = { new Tool(), },
            };
            // Make the request
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> response = vertexRagServiceClient.AsyncRetrieveContexts(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncRetrieveContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> retrievedResponse = vertexRagServiceClient.PollOnceAsyncRetrieveContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRetrieveContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncRetrieveContextsAsync</summary>
        public async Task AsyncRetrieveContextsRequestObjectAsync()
        {
            // Snippet: AsyncRetrieveContextsAsync(AsyncRetrieveContextsRequest, CallSettings)
            // Additional: AsyncRetrieveContextsAsync(AsyncRetrieveContextsRequest, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsyncRetrieveContextsRequest request = new AsyncRetrieveContextsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = new RagQuery(),
                Tools = { new Tool(), },
            };
            // Make the request
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> response = await vertexRagServiceClient.AsyncRetrieveContextsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncRetrieveContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> retrievedResponse = await vertexRagServiceClient.PollOnceAsyncRetrieveContextsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRetrieveContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncRetrieveContexts</summary>
        public void AsyncRetrieveContexts()
        {
            // Snippet: AsyncRetrieveContexts(string, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> response = vertexRagServiceClient.AsyncRetrieveContexts(parent, query);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncRetrieveContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> retrievedResponse = vertexRagServiceClient.PollOnceAsyncRetrieveContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRetrieveContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncRetrieveContextsAsync</summary>
        public async Task AsyncRetrieveContextsAsync()
        {
            // Snippet: AsyncRetrieveContextsAsync(string, RagQuery, CallSettings)
            // Additional: AsyncRetrieveContextsAsync(string, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagQuery query = new RagQuery();
            // Make the request
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> response = await vertexRagServiceClient.AsyncRetrieveContextsAsync(parent, query);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncRetrieveContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> retrievedResponse = await vertexRagServiceClient.PollOnceAsyncRetrieveContextsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRetrieveContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncRetrieveContexts</summary>
        public void AsyncRetrieveContextsResourceNames()
        {
            // Snippet: AsyncRetrieveContexts(LocationName, RagQuery, CallSettings)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = VertexRagServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> response = vertexRagServiceClient.AsyncRetrieveContexts(parent, query);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncRetrieveContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> retrievedResponse = vertexRagServiceClient.PollOnceAsyncRetrieveContexts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRetrieveContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncRetrieveContextsAsync</summary>
        public async Task AsyncRetrieveContextsResourceNamesAsync()
        {
            // Snippet: AsyncRetrieveContextsAsync(LocationName, RagQuery, CallSettings)
            // Additional: AsyncRetrieveContextsAsync(LocationName, RagQuery, CancellationToken)
            // Create client
            VertexRagServiceClient vertexRagServiceClient = await VertexRagServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagQuery query = new RagQuery();
            // Make the request
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> response = await vertexRagServiceClient.AsyncRetrieveContextsAsync(parent, query);

            // Poll until the returned long-running operation is complete
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncRetrieveContextsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncRetrieveContextsResponse, AsyncRetrieveContextsOperationMetadata> retrievedResponse = await vertexRagServiceClient.PollOnceAsyncRetrieveContextsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncRetrieveContextsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
