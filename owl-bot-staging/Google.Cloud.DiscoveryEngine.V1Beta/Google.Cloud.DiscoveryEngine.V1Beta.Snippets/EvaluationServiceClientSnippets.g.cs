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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEvaluationServiceClientSnippets
    {
        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationRequestObject()
        {
            // Snippet: GetEvaluation(GetEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = evaluationServiceClient.GetEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationRequestObjectAsync()
        {
            // Snippet: GetEvaluationAsync(GetEvaluationRequest, CallSettings)
            // Additional: GetEvaluationAsync(GetEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = await evaluationServiceClient.GetEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluation()
        {
            // Snippet: GetEvaluation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = evaluationServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationAsync()
        {
            // Snippet: GetEvaluationAsync(string, CallSettings)
            // Additional: GetEvaluationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = await evaluationServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationResourceNames()
        {
            // Snippet: GetEvaluation(EvaluationName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            Evaluation response = evaluationServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationResourceNamesAsync()
        {
            // Snippet: GetEvaluationAsync(EvaluationName, CallSettings)
            // Additional: GetEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            Evaluation response = await evaluationServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsRequestObject()
        {
            // Snippet: ListEvaluations(ListEvaluationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsRequestObjectAsync()
        {
            // Snippet: ListEvaluationsAsync(ListEvaluationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluations()
        {
            // Snippet: ListEvaluations(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsAsync()
        {
            // Snippet: ListEvaluationsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsResourceNames()
        {
            // Snippet: ListEvaluations(LocationName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsResourceNamesAsync()
        {
            // Snippet: ListEvaluationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluationRequestObject()
        {
            // Snippet: CreateEvaluation(CreateEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            CreateEvaluationRequest request = new CreateEvaluationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Evaluation = new Evaluation(),
            };
            // Make the request
            Operation<Evaluation, CreateEvaluationMetadata> response = evaluationServiceClient.CreateEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, CreateEvaluationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, CreateEvaluationMetadata> retrievedResponse = evaluationServiceClient.PollOnceCreateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluationRequestObjectAsync()
        {
            // Snippet: CreateEvaluationAsync(CreateEvaluationRequest, CallSettings)
            // Additional: CreateEvaluationAsync(CreateEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEvaluationRequest request = new CreateEvaluationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Evaluation = new Evaluation(),
            };
            // Make the request
            Operation<Evaluation, CreateEvaluationMetadata> response = await evaluationServiceClient.CreateEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, CreateEvaluationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, CreateEvaluationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceCreateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluation()
        {
            // Snippet: CreateEvaluation(string, Evaluation, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Evaluation evaluation = new Evaluation();
            // Make the request
            Operation<Evaluation, CreateEvaluationMetadata> response = evaluationServiceClient.CreateEvaluation(parent, evaluation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, CreateEvaluationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, CreateEvaluationMetadata> retrievedResponse = evaluationServiceClient.PollOnceCreateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluationAsync()
        {
            // Snippet: CreateEvaluationAsync(string, Evaluation, CallSettings)
            // Additional: CreateEvaluationAsync(string, Evaluation, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Evaluation evaluation = new Evaluation();
            // Make the request
            Operation<Evaluation, CreateEvaluationMetadata> response = await evaluationServiceClient.CreateEvaluationAsync(parent, evaluation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, CreateEvaluationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, CreateEvaluationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceCreateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluationResourceNames()
        {
            // Snippet: CreateEvaluation(LocationName, Evaluation, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Evaluation evaluation = new Evaluation();
            // Make the request
            Operation<Evaluation, CreateEvaluationMetadata> response = evaluationServiceClient.CreateEvaluation(parent, evaluation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, CreateEvaluationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, CreateEvaluationMetadata> retrievedResponse = evaluationServiceClient.PollOnceCreateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluationResourceNamesAsync()
        {
            // Snippet: CreateEvaluationAsync(LocationName, Evaluation, CallSettings)
            // Additional: CreateEvaluationAsync(LocationName, Evaluation, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Evaluation evaluation = new Evaluation();
            // Make the request
            Operation<Evaluation, CreateEvaluationMetadata> response = await evaluationServiceClient.CreateEvaluationAsync(parent, evaluation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, CreateEvaluationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, CreateEvaluationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceCreateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResults</summary>
        public void ListEvaluationResultsRequestObject()
        {
            // Snippet: ListEvaluationResults(ListEvaluationResultsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
            {
                EvaluationAsEvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
            };
            // Make the request
            PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> response = evaluationServiceClient.ListEvaluationResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListEvaluationResultsResponse.Types.EvaluationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResultsAsync</summary>
        public async Task ListEvaluationResultsRequestObjectAsync()
        {
            // Snippet: ListEvaluationResultsAsync(ListEvaluationResultsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
            {
                EvaluationAsEvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> response = evaluationServiceClient.ListEvaluationResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListEvaluationResultsResponse.Types.EvaluationResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListEvaluationResultsResponse.Types.EvaluationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResults</summary>
        public void ListEvaluationResults()
        {
            // Snippet: ListEvaluationResults(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string evaluation = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> response = evaluationServiceClient.ListEvaluationResults(evaluation);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListEvaluationResultsResponse.Types.EvaluationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResultsAsync</summary>
        public async Task ListEvaluationResultsAsync()
        {
            // Snippet: ListEvaluationResultsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string evaluation = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> response = evaluationServiceClient.ListEvaluationResultsAsync(evaluation);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListEvaluationResultsResponse.Types.EvaluationResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListEvaluationResultsResponse.Types.EvaluationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResults</summary>
        public void ListEvaluationResultsResourceNames()
        {
            // Snippet: ListEvaluationResults(EvaluationName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName evaluation = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> response = evaluationServiceClient.ListEvaluationResults(evaluation);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListEvaluationResultsResponse.Types.EvaluationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResultsAsync</summary>
        public async Task ListEvaluationResultsResourceNamesAsync()
        {
            // Snippet: ListEvaluationResultsAsync(EvaluationName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName evaluation = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> response = evaluationServiceClient.ListEvaluationResultsAsync(evaluation);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListEvaluationResultsResponse.Types.EvaluationResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListEvaluationResultsResponse.Types.EvaluationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListEvaluationResultsResponse.Types.EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
