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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGeneratorEvaluationsClientSnippets
    {
        /// <summary>Snippet for CreateGeneratorEvaluation</summary>
        public void CreateGeneratorEvaluationRequestObject()
        {
            // Snippet: CreateGeneratorEvaluation(CreateGeneratorEvaluationRequest, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            CreateGeneratorEvaluationRequest request = new CreateGeneratorEvaluationRequest
            {
                ParentAsGeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
                GeneratorEvaluation = new GeneratorEvaluation(),
            };
            // Make the request
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> response = generatorEvaluationsClient.CreateGeneratorEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GeneratorEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> retrievedResponse = generatorEvaluationsClient.PollOnceCreateGeneratorEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GeneratorEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorEvaluationAsync</summary>
        public async Task CreateGeneratorEvaluationRequestObjectAsync()
        {
            // Snippet: CreateGeneratorEvaluationAsync(CreateGeneratorEvaluationRequest, CallSettings)
            // Additional: CreateGeneratorEvaluationAsync(CreateGeneratorEvaluationRequest, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateGeneratorEvaluationRequest request = new CreateGeneratorEvaluationRequest
            {
                ParentAsGeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
                GeneratorEvaluation = new GeneratorEvaluation(),
            };
            // Make the request
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> response = await generatorEvaluationsClient.CreateGeneratorEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GeneratorEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> retrievedResponse = await generatorEvaluationsClient.PollOnceCreateGeneratorEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GeneratorEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorEvaluation</summary>
        public void CreateGeneratorEvaluation()
        {
            // Snippet: CreateGeneratorEvaluation(string, GeneratorEvaluation, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            GeneratorEvaluation generatorEvaluation = new GeneratorEvaluation();
            // Make the request
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> response = generatorEvaluationsClient.CreateGeneratorEvaluation(parent, generatorEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GeneratorEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> retrievedResponse = generatorEvaluationsClient.PollOnceCreateGeneratorEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GeneratorEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorEvaluationAsync</summary>
        public async Task CreateGeneratorEvaluationAsync()
        {
            // Snippet: CreateGeneratorEvaluationAsync(string, GeneratorEvaluation, CallSettings)
            // Additional: CreateGeneratorEvaluationAsync(string, GeneratorEvaluation, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            GeneratorEvaluation generatorEvaluation = new GeneratorEvaluation();
            // Make the request
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> response = await generatorEvaluationsClient.CreateGeneratorEvaluationAsync(parent, generatorEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GeneratorEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> retrievedResponse = await generatorEvaluationsClient.PollOnceCreateGeneratorEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GeneratorEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorEvaluation</summary>
        public void CreateGeneratorEvaluationResourceNames()
        {
            // Snippet: CreateGeneratorEvaluation(GeneratorName, GeneratorEvaluation, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            GeneratorName parent = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            GeneratorEvaluation generatorEvaluation = new GeneratorEvaluation();
            // Make the request
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> response = generatorEvaluationsClient.CreateGeneratorEvaluation(parent, generatorEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GeneratorEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> retrievedResponse = generatorEvaluationsClient.PollOnceCreateGeneratorEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GeneratorEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGeneratorEvaluationAsync</summary>
        public async Task CreateGeneratorEvaluationResourceNamesAsync()
        {
            // Snippet: CreateGeneratorEvaluationAsync(GeneratorName, GeneratorEvaluation, CallSettings)
            // Additional: CreateGeneratorEvaluationAsync(GeneratorName, GeneratorEvaluation, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            GeneratorName parent = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            GeneratorEvaluation generatorEvaluation = new GeneratorEvaluation();
            // Make the request
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> response = await generatorEvaluationsClient.CreateGeneratorEvaluationAsync(parent, generatorEvaluation);

            // Poll until the returned long-running operation is complete
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GeneratorEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> retrievedResponse = await generatorEvaluationsClient.PollOnceCreateGeneratorEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GeneratorEvaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorEvaluation</summary>
        public void GetGeneratorEvaluationRequestObject()
        {
            // Snippet: GetGeneratorEvaluation(GetGeneratorEvaluationRequest, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            GetGeneratorEvaluationRequest request = new GetGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]"),
            };
            // Make the request
            GeneratorEvaluation response = generatorEvaluationsClient.GetGeneratorEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorEvaluationAsync</summary>
        public async Task GetGeneratorEvaluationRequestObjectAsync()
        {
            // Snippet: GetGeneratorEvaluationAsync(GetGeneratorEvaluationRequest, CallSettings)
            // Additional: GetGeneratorEvaluationAsync(GetGeneratorEvaluationRequest, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            GetGeneratorEvaluationRequest request = new GetGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]"),
            };
            // Make the request
            GeneratorEvaluation response = await generatorEvaluationsClient.GetGeneratorEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorEvaluation</summary>
        public void GetGeneratorEvaluation()
        {
            // Snippet: GetGeneratorEvaluation(string, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]/evaluations/[EVALUATION]";
            // Make the request
            GeneratorEvaluation response = generatorEvaluationsClient.GetGeneratorEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorEvaluationAsync</summary>
        public async Task GetGeneratorEvaluationAsync()
        {
            // Snippet: GetGeneratorEvaluationAsync(string, CallSettings)
            // Additional: GetGeneratorEvaluationAsync(string, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]/evaluations/[EVALUATION]";
            // Make the request
            GeneratorEvaluation response = await generatorEvaluationsClient.GetGeneratorEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorEvaluation</summary>
        public void GetGeneratorEvaluationResourceNames()
        {
            // Snippet: GetGeneratorEvaluation(GeneratorEvaluationName, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            GeneratorEvaluationName name = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]");
            // Make the request
            GeneratorEvaluation response = generatorEvaluationsClient.GetGeneratorEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeneratorEvaluationAsync</summary>
        public async Task GetGeneratorEvaluationResourceNamesAsync()
        {
            // Snippet: GetGeneratorEvaluationAsync(GeneratorEvaluationName, CallSettings)
            // Additional: GetGeneratorEvaluationAsync(GeneratorEvaluationName, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            GeneratorEvaluationName name = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]");
            // Make the request
            GeneratorEvaluation response = await generatorEvaluationsClient.GetGeneratorEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorEvaluations</summary>
        public void ListGeneratorEvaluationsRequestObject()
        {
            // Snippet: ListGeneratorEvaluations(ListGeneratorEvaluationsRequest, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            ListGeneratorEvaluationsRequest request = new ListGeneratorEvaluationsRequest
            {
                ParentAsGeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
            };
            // Make the request
            PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> response = generatorEvaluationsClient.ListGeneratorEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GeneratorEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeneratorEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeneratorEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeneratorEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeneratorEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorEvaluationsAsync</summary>
        public async Task ListGeneratorEvaluationsRequestObjectAsync()
        {
            // Snippet: ListGeneratorEvaluationsAsync(ListGeneratorEvaluationsRequest, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            ListGeneratorEvaluationsRequest request = new ListGeneratorEvaluationsRequest
            {
                ParentAsGeneratorName = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> response = generatorEvaluationsClient.ListGeneratorEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GeneratorEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeneratorEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeneratorEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeneratorEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeneratorEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorEvaluations</summary>
        public void ListGeneratorEvaluations()
        {
            // Snippet: ListGeneratorEvaluations(string, string, int?, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            // Make the request
            PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> response = generatorEvaluationsClient.ListGeneratorEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GeneratorEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeneratorEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeneratorEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeneratorEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeneratorEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorEvaluationsAsync</summary>
        public async Task ListGeneratorEvaluationsAsync()
        {
            // Snippet: ListGeneratorEvaluationsAsync(string, string, int?, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]";
            // Make the request
            PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> response = generatorEvaluationsClient.ListGeneratorEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GeneratorEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeneratorEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeneratorEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeneratorEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeneratorEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorEvaluations</summary>
        public void ListGeneratorEvaluationsResourceNames()
        {
            // Snippet: ListGeneratorEvaluations(GeneratorName, string, int?, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            GeneratorName parent = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            // Make the request
            PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> response = generatorEvaluationsClient.ListGeneratorEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GeneratorEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeneratorEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeneratorEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeneratorEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeneratorEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeneratorEvaluationsAsync</summary>
        public async Task ListGeneratorEvaluationsResourceNamesAsync()
        {
            // Snippet: ListGeneratorEvaluationsAsync(GeneratorName, string, int?, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            GeneratorName parent = GeneratorName.FromProjectLocationGenerator("[PROJECT]", "[LOCATION]", "[GENERATOR]");
            // Make the request
            PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> response = generatorEvaluationsClient.ListGeneratorEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GeneratorEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeneratorEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeneratorEvaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeneratorEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeneratorEvaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorEvaluation</summary>
        public void DeleteGeneratorEvaluationRequestObject()
        {
            // Snippet: DeleteGeneratorEvaluation(DeleteGeneratorEvaluationRequest, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            DeleteGeneratorEvaluationRequest request = new DeleteGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]"),
            };
            // Make the request
            generatorEvaluationsClient.DeleteGeneratorEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorEvaluationAsync</summary>
        public async Task DeleteGeneratorEvaluationRequestObjectAsync()
        {
            // Snippet: DeleteGeneratorEvaluationAsync(DeleteGeneratorEvaluationRequest, CallSettings)
            // Additional: DeleteGeneratorEvaluationAsync(DeleteGeneratorEvaluationRequest, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGeneratorEvaluationRequest request = new DeleteGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]"),
            };
            // Make the request
            await generatorEvaluationsClient.DeleteGeneratorEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorEvaluation</summary>
        public void DeleteGeneratorEvaluation()
        {
            // Snippet: DeleteGeneratorEvaluation(string, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]/evaluations/[EVALUATION]";
            // Make the request
            generatorEvaluationsClient.DeleteGeneratorEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorEvaluationAsync</summary>
        public async Task DeleteGeneratorEvaluationAsync()
        {
            // Snippet: DeleteGeneratorEvaluationAsync(string, CallSettings)
            // Additional: DeleteGeneratorEvaluationAsync(string, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/generators/[GENERATOR]/evaluations/[EVALUATION]";
            // Make the request
            await generatorEvaluationsClient.DeleteGeneratorEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorEvaluation</summary>
        public void DeleteGeneratorEvaluationResourceNames()
        {
            // Snippet: DeleteGeneratorEvaluation(GeneratorEvaluationName, CallSettings)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = GeneratorEvaluationsClient.Create();
            // Initialize request argument(s)
            GeneratorEvaluationName name = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]");
            // Make the request
            generatorEvaluationsClient.DeleteGeneratorEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGeneratorEvaluationAsync</summary>
        public async Task DeleteGeneratorEvaluationResourceNamesAsync()
        {
            // Snippet: DeleteGeneratorEvaluationAsync(GeneratorEvaluationName, CallSettings)
            // Additional: DeleteGeneratorEvaluationAsync(GeneratorEvaluationName, CancellationToken)
            // Create client
            GeneratorEvaluationsClient generatorEvaluationsClient = await GeneratorEvaluationsClient.CreateAsync();
            // Initialize request argument(s)
            GeneratorEvaluationName name = GeneratorEvaluationName.FromProjectLocationGeneratorEvaluation("[PROJECT]", "[LOCATION]", "[GENERATOR]", "[EVALUATION]");
            // Make the request
            await generatorEvaluationsClient.DeleteGeneratorEvaluationAsync(name);
            // End snippet
        }
    }
}
