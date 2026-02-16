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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.WorkloadManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWorkloadManagerClientSnippets
    {
        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsRequestObject()
        {
            // Snippet: ListEvaluations(ListEvaluationsRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = workloadManagerClient.ListEvaluations(request);

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
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = workloadManagerClient.ListEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationsResponse page in response.AsRawResponses())
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
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = workloadManagerClient.ListEvaluations(parent);

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
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = workloadManagerClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationsResponse page in response.AsRawResponses())
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
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = workloadManagerClient.ListEvaluations(parent);

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
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = workloadManagerClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationRequestObject()
        {
            // Snippet: GetEvaluation(GetEvaluationRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = workloadManagerClient.GetEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationRequestObjectAsync()
        {
            // Snippet: GetEvaluationAsync(GetEvaluationRequest, CallSettings)
            // Additional: GetEvaluationAsync(GetEvaluationRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = await workloadManagerClient.GetEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluation()
        {
            // Snippet: GetEvaluation(string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = workloadManagerClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationAsync()
        {
            // Snippet: GetEvaluationAsync(string, CallSettings)
            // Additional: GetEvaluationAsync(string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = await workloadManagerClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationResourceNames()
        {
            // Snippet: GetEvaluation(EvaluationName, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            Evaluation response = workloadManagerClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationResourceNamesAsync()
        {
            // Snippet: GetEvaluationAsync(EvaluationName, CallSettings)
            // Additional: GetEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            Evaluation response = await workloadManagerClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluationRequestObject()
        {
            // Snippet: CreateEvaluation(CreateEvaluationRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            CreateEvaluationRequest request = new CreateEvaluationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EvaluationId = "",
                Evaluation = new Evaluation(),
                RequestId = "",
            };
            // Make the request
            Operation<Evaluation, OperationMetadata> response = workloadManagerClient.CreateEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceCreateEvaluation(operationName);
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
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateEvaluationRequest request = new CreateEvaluationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EvaluationId = "",
                Evaluation = new Evaluation(),
                RequestId = "",
            };
            // Make the request
            Operation<Evaluation, OperationMetadata> response = await workloadManagerClient.CreateEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceCreateEvaluationAsync(operationName);
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
            // Snippet: CreateEvaluation(string, Evaluation, string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Operation<Evaluation, OperationMetadata> response = workloadManagerClient.CreateEvaluation(parent, evaluation, evaluationId);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceCreateEvaluation(operationName);
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
            // Snippet: CreateEvaluationAsync(string, Evaluation, string, CallSettings)
            // Additional: CreateEvaluationAsync(string, Evaluation, string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Operation<Evaluation, OperationMetadata> response = await workloadManagerClient.CreateEvaluationAsync(parent, evaluation, evaluationId);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceCreateEvaluationAsync(operationName);
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
            // Snippet: CreateEvaluation(LocationName, Evaluation, string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Operation<Evaluation, OperationMetadata> response = workloadManagerClient.CreateEvaluation(parent, evaluation, evaluationId);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceCreateEvaluation(operationName);
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
            // Snippet: CreateEvaluationAsync(LocationName, Evaluation, string, CallSettings)
            // Additional: CreateEvaluationAsync(LocationName, Evaluation, string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Operation<Evaluation, OperationMetadata> response = await workloadManagerClient.CreateEvaluationAsync(parent, evaluation, evaluationId);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceCreateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluation</summary>
        public void UpdateEvaluationRequestObject()
        {
            // Snippet: UpdateEvaluation(UpdateEvaluationRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            UpdateEvaluationRequest request = new UpdateEvaluationRequest
            {
                UpdateMask = new FieldMask(),
                Evaluation = new Evaluation(),
                RequestId = "",
            };
            // Make the request
            Operation<Evaluation, OperationMetadata> response = workloadManagerClient.UpdateEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceUpdateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationAsync</summary>
        public async Task UpdateEvaluationRequestObjectAsync()
        {
            // Snippet: UpdateEvaluationAsync(UpdateEvaluationRequest, CallSettings)
            // Additional: UpdateEvaluationAsync(UpdateEvaluationRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEvaluationRequest request = new UpdateEvaluationRequest
            {
                UpdateMask = new FieldMask(),
                Evaluation = new Evaluation(),
                RequestId = "",
            };
            // Make the request
            Operation<Evaluation, OperationMetadata> response = await workloadManagerClient.UpdateEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceUpdateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluation</summary>
        public void UpdateEvaluation()
        {
            // Snippet: UpdateEvaluation(Evaluation, FieldMask, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            Evaluation evaluation = new Evaluation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Evaluation, OperationMetadata> response = workloadManagerClient.UpdateEvaluation(evaluation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceUpdateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationAsync</summary>
        public async Task UpdateEvaluationAsync()
        {
            // Snippet: UpdateEvaluationAsync(Evaluation, FieldMask, CallSettings)
            // Additional: UpdateEvaluationAsync(Evaluation, FieldMask, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            Evaluation evaluation = new Evaluation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Evaluation, OperationMetadata> response = await workloadManagerClient.UpdateEvaluationAsync(evaluation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceUpdateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluation</summary>
        public void DeleteEvaluationRequestObject()
        {
            // Snippet: DeleteEvaluation(DeleteEvaluationRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationRequest request = new DeleteEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = workloadManagerClient.DeleteEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceDeleteEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationAsync</summary>
        public async Task DeleteEvaluationRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationAsync(DeleteEvaluationRequest, CallSettings)
            // Additional: DeleteEvaluationAsync(DeleteEvaluationRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationRequest request = new DeleteEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await workloadManagerClient.DeleteEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceDeleteEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluation</summary>
        public void DeleteEvaluation()
        {
            // Snippet: DeleteEvaluation(string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = workloadManagerClient.DeleteEvaluation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceDeleteEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationAsync</summary>
        public async Task DeleteEvaluationAsync()
        {
            // Snippet: DeleteEvaluationAsync(string, CallSettings)
            // Additional: DeleteEvaluationAsync(string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await workloadManagerClient.DeleteEvaluationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceDeleteEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluation</summary>
        public void DeleteEvaluationResourceNames()
        {
            // Snippet: DeleteEvaluation(EvaluationName, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = workloadManagerClient.DeleteEvaluation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceDeleteEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationAsync</summary>
        public async Task DeleteEvaluationResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationAsync(EvaluationName, CallSettings)
            // Additional: DeleteEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await workloadManagerClient.DeleteEvaluationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceDeleteEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsRequestObject()
        {
            // Snippet: ListExecutions(ListExecutionsRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = workloadManagerClient.ListExecutions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsRequestObjectAsync()
        {
            // Snippet: ListExecutionsAsync(ListExecutionsRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = workloadManagerClient.ListExecutionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutions()
        {
            // Snippet: ListExecutions(string, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = workloadManagerClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsAsync()
        {
            // Snippet: ListExecutionsAsync(string, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = workloadManagerClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsResourceNames()
        {
            // Snippet: ListExecutions(EvaluationName, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = workloadManagerClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsResourceNamesAsync()
        {
            // Snippet: ListExecutionsAsync(EvaluationName, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = workloadManagerClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionRequestObject()
        {
            // Snippet: GetExecution(GetExecutionRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = workloadManagerClient.GetExecution(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionRequestObjectAsync()
        {
            // Snippet: GetExecutionAsync(GetExecutionRequest, CallSettings)
            // Additional: GetExecutionAsync(GetExecutionRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = await workloadManagerClient.GetExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecution()
        {
            // Snippet: GetExecution(string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]/executions/[EXECUTION]";
            // Make the request
            Execution response = workloadManagerClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionAsync()
        {
            // Snippet: GetExecutionAsync(string, CallSettings)
            // Additional: GetExecutionAsync(string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]/executions/[EXECUTION]";
            // Make the request
            Execution response = await workloadManagerClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionResourceNames()
        {
            // Snippet: GetExecution(ExecutionName, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]");
            // Make the request
            Execution response = workloadManagerClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionResourceNamesAsync()
        {
            // Snippet: GetExecutionAsync(ExecutionName, CallSettings)
            // Additional: GetExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]");
            // Make the request
            Execution response = await workloadManagerClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunEvaluation</summary>
        public void RunEvaluationRequestObject()
        {
            // Snippet: RunEvaluation(RunEvaluationRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            RunEvaluationRequest request = new RunEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
                ExecutionId = "",
                Execution = new Execution(),
                RequestId = "",
            };
            // Make the request
            Operation<Execution, OperationMetadata> response = workloadManagerClient.RunEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluationAsync</summary>
        public async Task RunEvaluationRequestObjectAsync()
        {
            // Snippet: RunEvaluationAsync(RunEvaluationRequest, CallSettings)
            // Additional: RunEvaluationAsync(RunEvaluationRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            RunEvaluationRequest request = new RunEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]"),
                ExecutionId = "",
                Execution = new Execution(),
                RequestId = "",
            };
            // Make the request
            Operation<Execution, OperationMetadata> response = await workloadManagerClient.RunEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceRunEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluation</summary>
        public void RunEvaluation()
        {
            // Snippet: RunEvaluation(string, Execution, string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = workloadManagerClient.RunEvaluation(name, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluationAsync</summary>
        public async Task RunEvaluationAsync()
        {
            // Snippet: RunEvaluationAsync(string, Execution, string, CallSettings)
            // Additional: RunEvaluationAsync(string, Execution, string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]";
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = await workloadManagerClient.RunEvaluationAsync(name, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceRunEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluation</summary>
        public void RunEvaluationResourceNames()
        {
            // Snippet: RunEvaluation(EvaluationName, Execution, string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = workloadManagerClient.RunEvaluation(name, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluationAsync</summary>
        public async Task RunEvaluationResourceNamesAsync()
        {
            // Snippet: RunEvaluationAsync(EvaluationName, Execution, string, CallSettings)
            // Additional: RunEvaluationAsync(EvaluationName, Execution, string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationEvaluation("[PROJECT]", "[LOCATION]", "[EVALUATION]");
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = await workloadManagerClient.RunEvaluationAsync(name, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceRunEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionRequestObject()
        {
            // Snippet: DeleteExecution(DeleteExecutionRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            DeleteExecutionRequest request = new DeleteExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = workloadManagerClient.DeleteExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionRequestObjectAsync()
        {
            // Snippet: DeleteExecutionAsync(DeleteExecutionRequest, CallSettings)
            // Additional: DeleteExecutionAsync(DeleteExecutionRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExecutionRequest request = new DeleteExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await workloadManagerClient.DeleteExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecution()
        {
            // Snippet: DeleteExecution(string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = workloadManagerClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionAsync()
        {
            // Snippet: DeleteExecutionAsync(string, CallSettings)
            // Additional: DeleteExecutionAsync(string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/evaluations/[EVALUATION]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await workloadManagerClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionResourceNames()
        {
            // Snippet: DeleteExecution(ExecutionName, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = workloadManagerClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workloadManagerClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionResourceNamesAsync()
        {
            // Snippet: DeleteExecutionAsync(ExecutionName, CallSettings)
            // Additional: DeleteExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationEvaluationExecution("[PROJECT]", "[LOCATION]", "[EVALUATION]", "[EXECUTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await workloadManagerClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workloadManagerClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExecutionResults</summary>
        public void ListExecutionResultsRequestObject()
        {
            // Snippet: ListExecutionResults(ListExecutionResultsRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ListExecutionResultsRequest request = new ListExecutionResultsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListExecutionResultsResponse, ExecutionResult> response = workloadManagerClient.ListExecutionResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExecutionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExecutionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExecutionResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExecutionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionResultsAsync</summary>
        public async Task ListExecutionResultsRequestObjectAsync()
        {
            // Snippet: ListExecutionResultsAsync(ListExecutionResultsRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListExecutionResultsRequest request = new ListExecutionResultsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExecutionResultsResponse, ExecutionResult> response = workloadManagerClient.ListExecutionResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ExecutionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExecutionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExecutionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExecutionResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExecutionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionResults</summary>
        public void ListExecutionResults()
        {
            // Snippet: ListExecutionResults(string, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListExecutionResultsResponse, ExecutionResult> response = workloadManagerClient.ListExecutionResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExecutionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExecutionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExecutionResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExecutionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionResultsAsync</summary>
        public async Task ListExecutionResultsAsync()
        {
            // Snippet: ListExecutionResultsAsync(string, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListExecutionResultsResponse, ExecutionResult> response = workloadManagerClient.ListExecutionResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ExecutionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListExecutionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExecutionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExecutionResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExecutionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRules</summary>
        public void ListRulesRequestObject()
        {
            // Snippet: ListRules(ListRulesRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ListRulesRequest request = new ListRulesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PageSize = 0,
                PageToken = "",
                Filter = "",
                CustomRulesBucket = "",
                EvaluationType = Evaluation.Types.EvaluationType.Unspecified,
            };
            // Make the request
            ListRulesResponse response = workloadManagerClient.ListRules(request);
            // End snippet
        }

        /// <summary>Snippet for ListRulesAsync</summary>
        public async Task ListRulesRequestObjectAsync()
        {
            // Snippet: ListRulesAsync(ListRulesRequest, CallSettings)
            // Additional: ListRulesAsync(ListRulesRequest, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListRulesRequest request = new ListRulesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PageSize = 0,
                PageToken = "",
                Filter = "",
                CustomRulesBucket = "",
                EvaluationType = Evaluation.Types.EvaluationType.Unspecified,
            };
            // Make the request
            ListRulesResponse response = await workloadManagerClient.ListRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListRules</summary>
        public void ListRules()
        {
            // Snippet: ListRules(string, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListRulesResponse response = workloadManagerClient.ListRules(parent);
            // End snippet
        }

        /// <summary>Snippet for ListRulesAsync</summary>
        public async Task ListRulesAsync()
        {
            // Snippet: ListRulesAsync(string, CallSettings)
            // Additional: ListRulesAsync(string, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListRulesResponse response = await workloadManagerClient.ListRulesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListRules</summary>
        public void ListRulesResourceNames()
        {
            // Snippet: ListRules(LocationName, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListRulesResponse response = workloadManagerClient.ListRules(parent);
            // End snippet
        }

        /// <summary>Snippet for ListRulesAsync</summary>
        public async Task ListRulesResourceNamesAsync()
        {
            // Snippet: ListRulesAsync(LocationName, CallSettings)
            // Additional: ListRulesAsync(LocationName, CancellationToken)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListRulesResponse response = await workloadManagerClient.ListRulesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListScannedResources</summary>
        public void ListScannedResourcesRequestObject()
        {
            // Snippet: ListScannedResources(ListScannedResourcesRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            ListScannedResourcesRequest request = new ListScannedResourcesRequest
            {
                Parent = "",
                Rule = "",
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListScannedResourcesResponse, ScannedResource> response = workloadManagerClient.ListScannedResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScannedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScannedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScannedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScannedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScannedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScannedResourcesAsync</summary>
        public async Task ListScannedResourcesRequestObjectAsync()
        {
            // Snippet: ListScannedResourcesAsync(ListScannedResourcesRequest, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListScannedResourcesRequest request = new ListScannedResourcesRequest
            {
                Parent = "",
                Rule = "",
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListScannedResourcesResponse, ScannedResource> response = workloadManagerClient.ListScannedResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ScannedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScannedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScannedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScannedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScannedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScannedResources</summary>
        public void ListScannedResources()
        {
            // Snippet: ListScannedResources(string, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = WorkloadManagerClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListScannedResourcesResponse, ScannedResource> response = workloadManagerClient.ListScannedResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScannedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScannedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScannedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScannedResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScannedResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScannedResourcesAsync</summary>
        public async Task ListScannedResourcesAsync()
        {
            // Snippet: ListScannedResourcesAsync(string, string, int?, CallSettings)
            // Create client
            WorkloadManagerClient workloadManagerClient = await WorkloadManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListScannedResourcesResponse, ScannedResource> response = workloadManagerClient.ListScannedResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ScannedResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScannedResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScannedResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScannedResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScannedResource item in singlePage)
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
