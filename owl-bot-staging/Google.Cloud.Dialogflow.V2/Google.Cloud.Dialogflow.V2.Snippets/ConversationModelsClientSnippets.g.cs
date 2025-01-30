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
    using Google.Api.Gax;
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversationModelsClientSnippets
    {
        /// <summary>Snippet for CreateConversationModel</summary>
        public void CreateConversationModelRequestObject()
        {
            // Snippet: CreateConversationModel(CreateConversationModelRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            CreateConversationModelRequest request = new CreateConversationModelRequest
            {
                Parent = "",
                ConversationModel = new ConversationModel(),
            };
            // Make the request
            Operation<ConversationModel, CreateConversationModelOperationMetadata> response = conversationModelsClient.CreateConversationModel(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModel, CreateConversationModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModel, CreateConversationModelOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceCreateConversationModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelAsync</summary>
        public async Task CreateConversationModelRequestObjectAsync()
        {
            // Snippet: CreateConversationModelAsync(CreateConversationModelRequest, CallSettings)
            // Additional: CreateConversationModelAsync(CreateConversationModelRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationModelRequest request = new CreateConversationModelRequest
            {
                Parent = "",
                ConversationModel = new ConversationModel(),
            };
            // Make the request
            Operation<ConversationModel, CreateConversationModelOperationMetadata> response = await conversationModelsClient.CreateConversationModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModel, CreateConversationModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModel, CreateConversationModelOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceCreateConversationModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModel</summary>
        public void CreateConversationModel()
        {
            // Snippet: CreateConversationModel(string, ConversationModel, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            ConversationModel conversationModel = new ConversationModel();
            // Make the request
            Operation<ConversationModel, CreateConversationModelOperationMetadata> response = conversationModelsClient.CreateConversationModel(parent, conversationModel);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModel, CreateConversationModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModel, CreateConversationModelOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceCreateConversationModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelAsync</summary>
        public async Task CreateConversationModelAsync()
        {
            // Snippet: CreateConversationModelAsync(string, ConversationModel, CallSettings)
            // Additional: CreateConversationModelAsync(string, ConversationModel, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            ConversationModel conversationModel = new ConversationModel();
            // Make the request
            Operation<ConversationModel, CreateConversationModelOperationMetadata> response = await conversationModelsClient.CreateConversationModelAsync(parent, conversationModel);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModel, CreateConversationModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModel, CreateConversationModelOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceCreateConversationModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConversationModel</summary>
        public void GetConversationModelRequestObject()
        {
            // Snippet: GetConversationModel(GetConversationModelRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            GetConversationModelRequest request = new GetConversationModelRequest { Name = "", };
            // Make the request
            ConversationModel response = conversationModelsClient.GetConversationModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationModelAsync</summary>
        public async Task GetConversationModelRequestObjectAsync()
        {
            // Snippet: GetConversationModelAsync(GetConversationModelRequest, CallSettings)
            // Additional: GetConversationModelAsync(GetConversationModelRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationModelRequest request = new GetConversationModelRequest { Name = "", };
            // Make the request
            ConversationModel response = await conversationModelsClient.GetConversationModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationModel</summary>
        public void GetConversationModel()
        {
            // Snippet: GetConversationModel(string, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ConversationModel response = conversationModelsClient.GetConversationModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationModelAsync</summary>
        public async Task GetConversationModelAsync()
        {
            // Snippet: GetConversationModelAsync(string, CallSettings)
            // Additional: GetConversationModelAsync(string, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ConversationModel response = await conversationModelsClient.GetConversationModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversationModels</summary>
        public void ListConversationModelsRequestObject()
        {
            // Snippet: ListConversationModels(ListConversationModelsRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            ListConversationModelsRequest request = new ListConversationModelsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListConversationModelsResponse, ConversationModel> response = conversationModelsClient.ListConversationModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationModel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationModelsAsync</summary>
        public async Task ListConversationModelsRequestObjectAsync()
        {
            // Snippet: ListConversationModelsAsync(ListConversationModelsRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationModelsRequest request = new ListConversationModelsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListConversationModelsResponse, ConversationModel> response = conversationModelsClient.ListConversationModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationModel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationModels</summary>
        public void ListConversationModels()
        {
            // Snippet: ListConversationModels(string, string, int?, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListConversationModelsResponse, ConversationModel> response = conversationModelsClient.ListConversationModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationModel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationModelsAsync</summary>
        public async Task ListConversationModelsAsync()
        {
            // Snippet: ListConversationModelsAsync(string, string, int?, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListConversationModelsResponse, ConversationModel> response = conversationModelsClient.ListConversationModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationModel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationModel</summary>
        public void DeleteConversationModelRequestObject()
        {
            // Snippet: DeleteConversationModel(DeleteConversationModelRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            DeleteConversationModelRequest request = new DeleteConversationModelRequest { Name = "", };
            // Make the request
            Operation<Empty, DeleteConversationModelOperationMetadata> response = conversationModelsClient.DeleteConversationModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationModelOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceDeleteConversationModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationModelAsync</summary>
        public async Task DeleteConversationModelRequestObjectAsync()
        {
            // Snippet: DeleteConversationModelAsync(DeleteConversationModelRequest, CallSettings)
            // Additional: DeleteConversationModelAsync(DeleteConversationModelRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversationModelRequest request = new DeleteConversationModelRequest { Name = "", };
            // Make the request
            Operation<Empty, DeleteConversationModelOperationMetadata> response = await conversationModelsClient.DeleteConversationModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationModelOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceDeleteConversationModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationModel</summary>
        public void DeleteConversationModel()
        {
            // Snippet: DeleteConversationModel(string, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, DeleteConversationModelOperationMetadata> response = conversationModelsClient.DeleteConversationModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationModelOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceDeleteConversationModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationModelAsync</summary>
        public async Task DeleteConversationModelAsync()
        {
            // Snippet: DeleteConversationModelAsync(string, CallSettings)
            // Additional: DeleteConversationModelAsync(string, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, DeleteConversationModelOperationMetadata> response = await conversationModelsClient.DeleteConversationModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationModelOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceDeleteConversationModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployConversationModel</summary>
        public void DeployConversationModelRequestObject()
        {
            // Snippet: DeployConversationModel(DeployConversationModelRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            DeployConversationModelRequest request = new DeployConversationModelRequest { Name = "", };
            // Make the request
            Operation<Empty, DeployConversationModelOperationMetadata> response = conversationModelsClient.DeployConversationModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeployConversationModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeployConversationModelOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceDeployConversationModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployConversationModelAsync</summary>
        public async Task DeployConversationModelRequestObjectAsync()
        {
            // Snippet: DeployConversationModelAsync(DeployConversationModelRequest, CallSettings)
            // Additional: DeployConversationModelAsync(DeployConversationModelRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            DeployConversationModelRequest request = new DeployConversationModelRequest { Name = "", };
            // Make the request
            Operation<Empty, DeployConversationModelOperationMetadata> response = await conversationModelsClient.DeployConversationModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeployConversationModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeployConversationModelOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceDeployConversationModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployConversationModel</summary>
        public void UndeployConversationModelRequestObject()
        {
            // Snippet: UndeployConversationModel(UndeployConversationModelRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            UndeployConversationModelRequest request = new UndeployConversationModelRequest { Name = "", };
            // Make the request
            Operation<Empty, UndeployConversationModelOperationMetadata> response = conversationModelsClient.UndeployConversationModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UndeployConversationModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UndeployConversationModelOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceUndeployConversationModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployConversationModelAsync</summary>
        public async Task UndeployConversationModelRequestObjectAsync()
        {
            // Snippet: UndeployConversationModelAsync(UndeployConversationModelRequest, CallSettings)
            // Additional: UndeployConversationModelAsync(UndeployConversationModelRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            UndeployConversationModelRequest request = new UndeployConversationModelRequest { Name = "", };
            // Make the request
            Operation<Empty, UndeployConversationModelOperationMetadata> response = await conversationModelsClient.UndeployConversationModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UndeployConversationModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UndeployConversationModelOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceUndeployConversationModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConversationModelEvaluation</summary>
        public void GetConversationModelEvaluationRequestObject()
        {
            // Snippet: GetConversationModelEvaluation(GetConversationModelEvaluationRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            GetConversationModelEvaluationRequest request = new GetConversationModelEvaluationRequest { Name = "", };
            // Make the request
            ConversationModelEvaluation response = conversationModelsClient.GetConversationModelEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationModelEvaluationAsync</summary>
        public async Task GetConversationModelEvaluationRequestObjectAsync()
        {
            // Snippet: GetConversationModelEvaluationAsync(GetConversationModelEvaluationRequest, CallSettings)
            // Additional: GetConversationModelEvaluationAsync(GetConversationModelEvaluationRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationModelEvaluationRequest request = new GetConversationModelEvaluationRequest { Name = "", };
            // Make the request
            ConversationModelEvaluation response = await conversationModelsClient.GetConversationModelEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationModelEvaluation</summary>
        public void GetConversationModelEvaluation()
        {
            // Snippet: GetConversationModelEvaluation(string, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ConversationModelEvaluation response = conversationModelsClient.GetConversationModelEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationModelEvaluationAsync</summary>
        public async Task GetConversationModelEvaluationAsync()
        {
            // Snippet: GetConversationModelEvaluationAsync(string, CallSettings)
            // Additional: GetConversationModelEvaluationAsync(string, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            ConversationModelEvaluation response = await conversationModelsClient.GetConversationModelEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversationModelEvaluations</summary>
        public void ListConversationModelEvaluationsRequestObject()
        {
            // Snippet: ListConversationModelEvaluations(ListConversationModelEvaluationsRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            ListConversationModelEvaluationsRequest request = new ListConversationModelEvaluationsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> response = conversationModelsClient.ListConversationModelEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationModelEvaluationsAsync</summary>
        public async Task ListConversationModelEvaluationsRequestObjectAsync()
        {
            // Snippet: ListConversationModelEvaluationsAsync(ListConversationModelEvaluationsRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationModelEvaluationsRequest request = new ListConversationModelEvaluationsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> response = conversationModelsClient.ListConversationModelEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationModelEvaluations</summary>
        public void ListConversationModelEvaluations()
        {
            // Snippet: ListConversationModelEvaluations(string, string, int?, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> response = conversationModelsClient.ListConversationModelEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationModelEvaluationsAsync</summary>
        public async Task ListConversationModelEvaluationsAsync()
        {
            // Snippet: ListConversationModelEvaluationsAsync(string, string, int?, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> response = conversationModelsClient.ListConversationModelEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationModelEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationModelEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelEvaluation</summary>
        public void CreateConversationModelEvaluationRequestObject()
        {
            // Snippet: CreateConversationModelEvaluation(CreateConversationModelEvaluationRequest, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            CreateConversationModelEvaluationRequest request = new CreateConversationModelEvaluationRequest
            {
                ParentAsConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                ConversationModelEvaluation = new ConversationModelEvaluation(),
            };
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = conversationModelsClient.CreateConversationModelEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceCreateConversationModelEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelEvaluationAsync</summary>
        public async Task CreateConversationModelEvaluationRequestObjectAsync()
        {
            // Snippet: CreateConversationModelEvaluationAsync(CreateConversationModelEvaluationRequest, CallSettings)
            // Additional: CreateConversationModelEvaluationAsync(CreateConversationModelEvaluationRequest, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationModelEvaluationRequest request = new CreateConversationModelEvaluationRequest
            {
                ParentAsConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                ConversationModelEvaluation = new ConversationModelEvaluation(),
            };
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = await conversationModelsClient.CreateConversationModelEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceCreateConversationModelEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelEvaluation</summary>
        public void CreateConversationModelEvaluation()
        {
            // Snippet: CreateConversationModelEvaluation(string, ConversationModelEvaluation, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversationModels/[CONVERSATION_MODEL]";
            ConversationModelEvaluation conversationModelEvaluation = new ConversationModelEvaluation();
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = conversationModelsClient.CreateConversationModelEvaluation(parent, conversationModelEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceCreateConversationModelEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelEvaluationAsync</summary>
        public async Task CreateConversationModelEvaluationAsync()
        {
            // Snippet: CreateConversationModelEvaluationAsync(string, ConversationModelEvaluation, CallSettings)
            // Additional: CreateConversationModelEvaluationAsync(string, ConversationModelEvaluation, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversationModels/[CONVERSATION_MODEL]";
            ConversationModelEvaluation conversationModelEvaluation = new ConversationModelEvaluation();
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = await conversationModelsClient.CreateConversationModelEvaluationAsync(parent, conversationModelEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceCreateConversationModelEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelEvaluation</summary>
        public void CreateConversationModelEvaluationResourceNames()
        {
            // Snippet: CreateConversationModelEvaluation(ConversationModelName, ConversationModelEvaluation, CallSettings)
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            ConversationModelName parent = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]");
            ConversationModelEvaluation conversationModelEvaluation = new ConversationModelEvaluation();
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = conversationModelsClient.CreateConversationModelEvaluation(parent, conversationModelEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceCreateConversationModelEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationModelEvaluationAsync</summary>
        public async Task CreateConversationModelEvaluationResourceNamesAsync()
        {
            // Snippet: CreateConversationModelEvaluationAsync(ConversationModelName, ConversationModelEvaluation, CallSettings)
            // Additional: CreateConversationModelEvaluationAsync(ConversationModelName, ConversationModelEvaluation, CancellationToken)
            // Create client
            ConversationModelsClient conversationModelsClient = await ConversationModelsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationModelName parent = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]");
            ConversationModelEvaluation conversationModelEvaluation = new ConversationModelEvaluation();
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = await conversationModelsClient.CreateConversationModelEvaluationAsync(parent, conversationModelEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = await conversationModelsClient.PollOnceCreateConversationModelEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
