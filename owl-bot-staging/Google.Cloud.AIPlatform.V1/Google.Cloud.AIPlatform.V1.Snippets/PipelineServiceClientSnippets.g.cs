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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPipelineServiceClientSnippets
    {
        /// <summary>Snippet for CreateTrainingPipeline</summary>
        public void CreateTrainingPipelineRequestObject()
        {
            // Snippet: CreateTrainingPipeline(CreateTrainingPipelineRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            // Make the request
            TrainingPipeline response = pipelineServiceClient.CreateTrainingPipeline(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTrainingPipelineAsync</summary>
        public async Task CreateTrainingPipelineRequestObjectAsync()
        {
            // Snippet: CreateTrainingPipelineAsync(CreateTrainingPipelineRequest, CallSettings)
            // Additional: CreateTrainingPipelineAsync(CreateTrainingPipelineRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTrainingPipelineRequest request = new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TrainingPipeline = new TrainingPipeline(),
            };
            // Make the request
            TrainingPipeline response = await pipelineServiceClient.CreateTrainingPipelineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTrainingPipeline</summary>
        public void CreateTrainingPipeline()
        {
            // Snippet: CreateTrainingPipeline(string, TrainingPipeline, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TrainingPipeline trainingPipeline = new TrainingPipeline();
            // Make the request
            TrainingPipeline response = pipelineServiceClient.CreateTrainingPipeline(parent, trainingPipeline);
            // End snippet
        }

        /// <summary>Snippet for CreateTrainingPipelineAsync</summary>
        public async Task CreateTrainingPipelineAsync()
        {
            // Snippet: CreateTrainingPipelineAsync(string, TrainingPipeline, CallSettings)
            // Additional: CreateTrainingPipelineAsync(string, TrainingPipeline, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            TrainingPipeline trainingPipeline = new TrainingPipeline();
            // Make the request
            TrainingPipeline response = await pipelineServiceClient.CreateTrainingPipelineAsync(parent, trainingPipeline);
            // End snippet
        }

        /// <summary>Snippet for CreateTrainingPipeline</summary>
        public void CreateTrainingPipelineResourceNames()
        {
            // Snippet: CreateTrainingPipeline(LocationName, TrainingPipeline, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TrainingPipeline trainingPipeline = new TrainingPipeline();
            // Make the request
            TrainingPipeline response = pipelineServiceClient.CreateTrainingPipeline(parent, trainingPipeline);
            // End snippet
        }

        /// <summary>Snippet for CreateTrainingPipelineAsync</summary>
        public async Task CreateTrainingPipelineResourceNamesAsync()
        {
            // Snippet: CreateTrainingPipelineAsync(LocationName, TrainingPipeline, CallSettings)
            // Additional: CreateTrainingPipelineAsync(LocationName, TrainingPipeline, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TrainingPipeline trainingPipeline = new TrainingPipeline();
            // Make the request
            TrainingPipeline response = await pipelineServiceClient.CreateTrainingPipelineAsync(parent, trainingPipeline);
            // End snippet
        }

        /// <summary>Snippet for GetTrainingPipeline</summary>
        public void GetTrainingPipelineRequestObject()
        {
            // Snippet: GetTrainingPipeline(GetTrainingPipelineRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            // Make the request
            TrainingPipeline response = pipelineServiceClient.GetTrainingPipeline(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrainingPipelineAsync</summary>
        public async Task GetTrainingPipelineRequestObjectAsync()
        {
            // Snippet: GetTrainingPipelineAsync(GetTrainingPipelineRequest, CallSettings)
            // Additional: GetTrainingPipelineAsync(GetTrainingPipelineRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTrainingPipelineRequest request = new GetTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            // Make the request
            TrainingPipeline response = await pipelineServiceClient.GetTrainingPipelineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrainingPipeline</summary>
        public void GetTrainingPipeline()
        {
            // Snippet: GetTrainingPipeline(string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/trainingPipelines/[TRAINING_PIPELINE]";
            // Make the request
            TrainingPipeline response = pipelineServiceClient.GetTrainingPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrainingPipelineAsync</summary>
        public async Task GetTrainingPipelineAsync()
        {
            // Snippet: GetTrainingPipelineAsync(string, CallSettings)
            // Additional: GetTrainingPipelineAsync(string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/trainingPipelines/[TRAINING_PIPELINE]";
            // Make the request
            TrainingPipeline response = await pipelineServiceClient.GetTrainingPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrainingPipeline</summary>
        public void GetTrainingPipelineResourceNames()
        {
            // Snippet: GetTrainingPipeline(TrainingPipelineName, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            TrainingPipelineName name = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]");
            // Make the request
            TrainingPipeline response = pipelineServiceClient.GetTrainingPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrainingPipelineAsync</summary>
        public async Task GetTrainingPipelineResourceNamesAsync()
        {
            // Snippet: GetTrainingPipelineAsync(TrainingPipelineName, CallSettings)
            // Additional: GetTrainingPipelineAsync(TrainingPipelineName, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrainingPipelineName name = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]");
            // Make the request
            TrainingPipeline response = await pipelineServiceClient.GetTrainingPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTrainingPipelines</summary>
        public void ListTrainingPipelinesRequestObject()
        {
            // Snippet: ListTrainingPipelines(ListTrainingPipelinesRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            ListTrainingPipelinesRequest request = new ListTrainingPipelinesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> response = pipelineServiceClient.ListTrainingPipelines(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TrainingPipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrainingPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrainingPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrainingPipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrainingPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrainingPipelinesAsync</summary>
        public async Task ListTrainingPipelinesRequestObjectAsync()
        {
            // Snippet: ListTrainingPipelinesAsync(ListTrainingPipelinesRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTrainingPipelinesRequest request = new ListTrainingPipelinesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> response = pipelineServiceClient.ListTrainingPipelinesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TrainingPipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTrainingPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrainingPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrainingPipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrainingPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrainingPipelines</summary>
        public void ListTrainingPipelines()
        {
            // Snippet: ListTrainingPipelines(string, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> response = pipelineServiceClient.ListTrainingPipelines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TrainingPipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrainingPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrainingPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrainingPipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrainingPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrainingPipelinesAsync</summary>
        public async Task ListTrainingPipelinesAsync()
        {
            // Snippet: ListTrainingPipelinesAsync(string, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> response = pipelineServiceClient.ListTrainingPipelinesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TrainingPipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTrainingPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrainingPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrainingPipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrainingPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrainingPipelines</summary>
        public void ListTrainingPipelinesResourceNames()
        {
            // Snippet: ListTrainingPipelines(LocationName, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> response = pipelineServiceClient.ListTrainingPipelines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TrainingPipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrainingPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrainingPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrainingPipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrainingPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrainingPipelinesAsync</summary>
        public async Task ListTrainingPipelinesResourceNamesAsync()
        {
            // Snippet: ListTrainingPipelinesAsync(LocationName, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> response = pipelineServiceClient.ListTrainingPipelinesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TrainingPipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTrainingPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrainingPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrainingPipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrainingPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTrainingPipeline</summary>
        public void DeleteTrainingPipelineRequestObject()
        {
            // Snippet: DeleteTrainingPipeline(DeleteTrainingPipelineRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            DeleteTrainingPipelineRequest request = new DeleteTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = pipelineServiceClient.DeleteTrainingPipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceDeleteTrainingPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrainingPipelineAsync</summary>
        public async Task DeleteTrainingPipelineRequestObjectAsync()
        {
            // Snippet: DeleteTrainingPipelineAsync(DeleteTrainingPipelineRequest, CallSettings)
            // Additional: DeleteTrainingPipelineAsync(DeleteTrainingPipelineRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTrainingPipelineRequest request = new DeleteTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await pipelineServiceClient.DeleteTrainingPipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceDeleteTrainingPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrainingPipeline</summary>
        public void DeleteTrainingPipeline()
        {
            // Snippet: DeleteTrainingPipeline(string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/trainingPipelines/[TRAINING_PIPELINE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = pipelineServiceClient.DeleteTrainingPipeline(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceDeleteTrainingPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrainingPipelineAsync</summary>
        public async Task DeleteTrainingPipelineAsync()
        {
            // Snippet: DeleteTrainingPipelineAsync(string, CallSettings)
            // Additional: DeleteTrainingPipelineAsync(string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/trainingPipelines/[TRAINING_PIPELINE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await pipelineServiceClient.DeleteTrainingPipelineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceDeleteTrainingPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrainingPipeline</summary>
        public void DeleteTrainingPipelineResourceNames()
        {
            // Snippet: DeleteTrainingPipeline(TrainingPipelineName, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            TrainingPipelineName name = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = pipelineServiceClient.DeleteTrainingPipeline(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceDeleteTrainingPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTrainingPipelineAsync</summary>
        public async Task DeleteTrainingPipelineResourceNamesAsync()
        {
            // Snippet: DeleteTrainingPipelineAsync(TrainingPipelineName, CallSettings)
            // Additional: DeleteTrainingPipelineAsync(TrainingPipelineName, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrainingPipelineName name = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await pipelineServiceClient.DeleteTrainingPipelineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceDeleteTrainingPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelTrainingPipeline</summary>
        public void CancelTrainingPipelineRequestObject()
        {
            // Snippet: CancelTrainingPipeline(CancelTrainingPipelineRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            // Make the request
            pipelineServiceClient.CancelTrainingPipeline(request);
            // End snippet
        }

        /// <summary>Snippet for CancelTrainingPipelineAsync</summary>
        public async Task CancelTrainingPipelineRequestObjectAsync()
        {
            // Snippet: CancelTrainingPipelineAsync(CancelTrainingPipelineRequest, CallSettings)
            // Additional: CancelTrainingPipelineAsync(CancelTrainingPipelineRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelTrainingPipelineRequest request = new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
            };
            // Make the request
            await pipelineServiceClient.CancelTrainingPipelineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelTrainingPipeline</summary>
        public void CancelTrainingPipeline()
        {
            // Snippet: CancelTrainingPipeline(string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/trainingPipelines/[TRAINING_PIPELINE]";
            // Make the request
            pipelineServiceClient.CancelTrainingPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for CancelTrainingPipelineAsync</summary>
        public async Task CancelTrainingPipelineAsync()
        {
            // Snippet: CancelTrainingPipelineAsync(string, CallSettings)
            // Additional: CancelTrainingPipelineAsync(string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/trainingPipelines/[TRAINING_PIPELINE]";
            // Make the request
            await pipelineServiceClient.CancelTrainingPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelTrainingPipeline</summary>
        public void CancelTrainingPipelineResourceNames()
        {
            // Snippet: CancelTrainingPipeline(TrainingPipelineName, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            TrainingPipelineName name = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]");
            // Make the request
            pipelineServiceClient.CancelTrainingPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for CancelTrainingPipelineAsync</summary>
        public async Task CancelTrainingPipelineResourceNamesAsync()
        {
            // Snippet: CancelTrainingPipelineAsync(TrainingPipelineName, CallSettings)
            // Additional: CancelTrainingPipelineAsync(TrainingPipelineName, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrainingPipelineName name = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]");
            // Make the request
            await pipelineServiceClient.CancelTrainingPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineJob</summary>
        public void CreatePipelineJobRequestObject()
        {
            // Snippet: CreatePipelineJob(CreatePipelineJobRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "",
            };
            // Make the request
            PipelineJob response = pipelineServiceClient.CreatePipelineJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineJobAsync</summary>
        public async Task CreatePipelineJobRequestObjectAsync()
        {
            // Snippet: CreatePipelineJobAsync(CreatePipelineJobRequest, CallSettings)
            // Additional: CreatePipelineJobAsync(CreatePipelineJobRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePipelineJobRequest request = new CreatePipelineJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJob = new PipelineJob(),
                PipelineJobId = "",
            };
            // Make the request
            PipelineJob response = await pipelineServiceClient.CreatePipelineJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineJob</summary>
        public void CreatePipelineJob()
        {
            // Snippet: CreatePipelineJob(string, PipelineJob, string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PipelineJob pipelineJob = new PipelineJob();
            string pipelineJobId = "";
            // Make the request
            PipelineJob response = pipelineServiceClient.CreatePipelineJob(parent, pipelineJob, pipelineJobId);
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineJobAsync</summary>
        public async Task CreatePipelineJobAsync()
        {
            // Snippet: CreatePipelineJobAsync(string, PipelineJob, string, CallSettings)
            // Additional: CreatePipelineJobAsync(string, PipelineJob, string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PipelineJob pipelineJob = new PipelineJob();
            string pipelineJobId = "";
            // Make the request
            PipelineJob response = await pipelineServiceClient.CreatePipelineJobAsync(parent, pipelineJob, pipelineJobId);
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineJob</summary>
        public void CreatePipelineJobResourceNames()
        {
            // Snippet: CreatePipelineJob(LocationName, PipelineJob, string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PipelineJob pipelineJob = new PipelineJob();
            string pipelineJobId = "";
            // Make the request
            PipelineJob response = pipelineServiceClient.CreatePipelineJob(parent, pipelineJob, pipelineJobId);
            // End snippet
        }

        /// <summary>Snippet for CreatePipelineJobAsync</summary>
        public async Task CreatePipelineJobResourceNamesAsync()
        {
            // Snippet: CreatePipelineJobAsync(LocationName, PipelineJob, string, CallSettings)
            // Additional: CreatePipelineJobAsync(LocationName, PipelineJob, string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PipelineJob pipelineJob = new PipelineJob();
            string pipelineJobId = "";
            // Make the request
            PipelineJob response = await pipelineServiceClient.CreatePipelineJobAsync(parent, pipelineJob, pipelineJobId);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineJob</summary>
        public void GetPipelineJobRequestObject()
        {
            // Snippet: GetPipelineJob(GetPipelineJobRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            PipelineJob response = pipelineServiceClient.GetPipelineJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineJobAsync</summary>
        public async Task GetPipelineJobRequestObjectAsync()
        {
            // Snippet: GetPipelineJobAsync(GetPipelineJobRequest, CallSettings)
            // Additional: GetPipelineJobAsync(GetPipelineJobRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPipelineJobRequest request = new GetPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            PipelineJob response = await pipelineServiceClient.GetPipelineJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineJob</summary>
        public void GetPipelineJob()
        {
            // Snippet: GetPipelineJob(string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]";
            // Make the request
            PipelineJob response = pipelineServiceClient.GetPipelineJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineJobAsync</summary>
        public async Task GetPipelineJobAsync()
        {
            // Snippet: GetPipelineJobAsync(string, CallSettings)
            // Additional: GetPipelineJobAsync(string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]";
            // Make the request
            PipelineJob response = await pipelineServiceClient.GetPipelineJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineJob</summary>
        public void GetPipelineJobResourceNames()
        {
            // Snippet: GetPipelineJob(PipelineJobName, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            PipelineJobName name = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]");
            // Make the request
            PipelineJob response = pipelineServiceClient.GetPipelineJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetPipelineJobAsync</summary>
        public async Task GetPipelineJobResourceNamesAsync()
        {
            // Snippet: GetPipelineJobAsync(PipelineJobName, CallSettings)
            // Additional: GetPipelineJobAsync(PipelineJobName, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            PipelineJobName name = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]");
            // Make the request
            PipelineJob response = await pipelineServiceClient.GetPipelineJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPipelineJobs</summary>
        public void ListPipelineJobsRequestObject()
        {
            // Snippet: ListPipelineJobs(ListPipelineJobsRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            ListPipelineJobsRequest request = new ListPipelineJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListPipelineJobsResponse, PipelineJob> response = pipelineServiceClient.ListPipelineJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PipelineJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPipelineJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PipelineJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PipelineJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PipelineJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelineJobsAsync</summary>
        public async Task ListPipelineJobsRequestObjectAsync()
        {
            // Snippet: ListPipelineJobsAsync(ListPipelineJobsRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPipelineJobsRequest request = new ListPipelineJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListPipelineJobsResponse, PipelineJob> response = pipelineServiceClient.ListPipelineJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PipelineJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPipelineJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PipelineJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PipelineJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PipelineJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelineJobs</summary>
        public void ListPipelineJobs()
        {
            // Snippet: ListPipelineJobs(string, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPipelineJobsResponse, PipelineJob> response = pipelineServiceClient.ListPipelineJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PipelineJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPipelineJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PipelineJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PipelineJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PipelineJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelineJobsAsync</summary>
        public async Task ListPipelineJobsAsync()
        {
            // Snippet: ListPipelineJobsAsync(string, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPipelineJobsResponse, PipelineJob> response = pipelineServiceClient.ListPipelineJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PipelineJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPipelineJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PipelineJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PipelineJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PipelineJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelineJobs</summary>
        public void ListPipelineJobsResourceNames()
        {
            // Snippet: ListPipelineJobs(LocationName, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPipelineJobsResponse, PipelineJob> response = pipelineServiceClient.ListPipelineJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PipelineJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPipelineJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PipelineJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PipelineJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PipelineJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPipelineJobsAsync</summary>
        public async Task ListPipelineJobsResourceNamesAsync()
        {
            // Snippet: ListPipelineJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPipelineJobsResponse, PipelineJob> response = pipelineServiceClient.ListPipelineJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PipelineJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPipelineJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PipelineJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PipelineJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PipelineJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineJob</summary>
        public void DeletePipelineJobRequestObject()
        {
            // Snippet: DeletePipelineJob(DeletePipelineJobRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            DeletePipelineJobRequest request = new DeletePipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = pipelineServiceClient.DeletePipelineJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceDeletePipelineJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineJobAsync</summary>
        public async Task DeletePipelineJobRequestObjectAsync()
        {
            // Snippet: DeletePipelineJobAsync(DeletePipelineJobRequest, CallSettings)
            // Additional: DeletePipelineJobAsync(DeletePipelineJobRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePipelineJobRequest request = new DeletePipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await pipelineServiceClient.DeletePipelineJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceDeletePipelineJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineJob</summary>
        public void DeletePipelineJob()
        {
            // Snippet: DeletePipelineJob(string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = pipelineServiceClient.DeletePipelineJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceDeletePipelineJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineJobAsync</summary>
        public async Task DeletePipelineJobAsync()
        {
            // Snippet: DeletePipelineJobAsync(string, CallSettings)
            // Additional: DeletePipelineJobAsync(string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await pipelineServiceClient.DeletePipelineJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceDeletePipelineJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineJob</summary>
        public void DeletePipelineJobResourceNames()
        {
            // Snippet: DeletePipelineJob(PipelineJobName, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            PipelineJobName name = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = pipelineServiceClient.DeletePipelineJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceDeletePipelineJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePipelineJobAsync</summary>
        public async Task DeletePipelineJobResourceNamesAsync()
        {
            // Snippet: DeletePipelineJobAsync(PipelineJobName, CallSettings)
            // Additional: DeletePipelineJobAsync(PipelineJobName, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            PipelineJobName name = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await pipelineServiceClient.DeletePipelineJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceDeletePipelineJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePipelineJobs</summary>
        public void BatchDeletePipelineJobsRequestObject()
        {
            // Snippet: BatchDeletePipelineJobs(BatchDeletePipelineJobsRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            BatchDeletePipelineJobsRequest request = new BatchDeletePipelineJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJobNames =
                {
                    PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                },
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = pipelineServiceClient.BatchDeletePipelineJobs(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchDeletePipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePipelineJobsAsync</summary>
        public async Task BatchDeletePipelineJobsRequestObjectAsync()
        {
            // Snippet: BatchDeletePipelineJobsAsync(BatchDeletePipelineJobsRequest, CallSettings)
            // Additional: BatchDeletePipelineJobsAsync(BatchDeletePipelineJobsRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeletePipelineJobsRequest request = new BatchDeletePipelineJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJobNames =
                {
                    PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                },
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = await pipelineServiceClient.BatchDeletePipelineJobsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceBatchDeletePipelineJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePipelineJobs</summary>
        public void BatchDeletePipelineJobs()
        {
            // Snippet: BatchDeletePipelineJobs(string, IEnumerable<string>, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]",
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = pipelineServiceClient.BatchDeletePipelineJobs(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchDeletePipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePipelineJobsAsync</summary>
        public async Task BatchDeletePipelineJobsAsync()
        {
            // Snippet: BatchDeletePipelineJobsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeletePipelineJobsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]",
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = await pipelineServiceClient.BatchDeletePipelineJobsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceBatchDeletePipelineJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePipelineJobs</summary>
        public void BatchDeletePipelineJobsResourceNames()
        {
            // Snippet: BatchDeletePipelineJobs(LocationName, IEnumerable<PipelineJobName>, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<PipelineJobName> names = new PipelineJobName[]
            {
                PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = pipelineServiceClient.BatchDeletePipelineJobs(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchDeletePipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeletePipelineJobsAsync</summary>
        public async Task BatchDeletePipelineJobsResourceNamesAsync()
        {
            // Snippet: BatchDeletePipelineJobsAsync(LocationName, IEnumerable<PipelineJobName>, CallSettings)
            // Additional: BatchDeletePipelineJobsAsync(LocationName, IEnumerable<PipelineJobName>, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<PipelineJobName> names = new PipelineJobName[]
            {
                PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = await pipelineServiceClient.BatchDeletePipelineJobsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceBatchDeletePipelineJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelPipelineJob</summary>
        public void CancelPipelineJobRequestObject()
        {
            // Snippet: CancelPipelineJob(CancelPipelineJobRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            pipelineServiceClient.CancelPipelineJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPipelineJobAsync</summary>
        public async Task CancelPipelineJobRequestObjectAsync()
        {
            // Snippet: CancelPipelineJobAsync(CancelPipelineJobRequest, CallSettings)
            // Additional: CancelPipelineJobAsync(CancelPipelineJobRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelPipelineJobRequest request = new CancelPipelineJobRequest
            {
                PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            await pipelineServiceClient.CancelPipelineJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPipelineJob</summary>
        public void CancelPipelineJob()
        {
            // Snippet: CancelPipelineJob(string, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]";
            // Make the request
            pipelineServiceClient.CancelPipelineJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPipelineJobAsync</summary>
        public async Task CancelPipelineJobAsync()
        {
            // Snippet: CancelPipelineJobAsync(string, CallSettings)
            // Additional: CancelPipelineJobAsync(string, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]";
            // Make the request
            await pipelineServiceClient.CancelPipelineJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPipelineJob</summary>
        public void CancelPipelineJobResourceNames()
        {
            // Snippet: CancelPipelineJob(PipelineJobName, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            PipelineJobName name = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]");
            // Make the request
            pipelineServiceClient.CancelPipelineJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPipelineJobAsync</summary>
        public async Task CancelPipelineJobResourceNamesAsync()
        {
            // Snippet: CancelPipelineJobAsync(PipelineJobName, CallSettings)
            // Additional: CancelPipelineJobAsync(PipelineJobName, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            PipelineJobName name = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]");
            // Make the request
            await pipelineServiceClient.CancelPipelineJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchCancelPipelineJobs</summary>
        public void BatchCancelPipelineJobsRequestObject()
        {
            // Snippet: BatchCancelPipelineJobs(BatchCancelPipelineJobsRequest, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            BatchCancelPipelineJobsRequest request = new BatchCancelPipelineJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJobNames =
                {
                    PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                },
            };
            // Make the request
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> response = pipelineServiceClient.BatchCancelPipelineJobs(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCancelPipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchCancelPipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCancelPipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCancelPipelineJobsAsync</summary>
        public async Task BatchCancelPipelineJobsRequestObjectAsync()
        {
            // Snippet: BatchCancelPipelineJobsAsync(BatchCancelPipelineJobsRequest, CallSettings)
            // Additional: BatchCancelPipelineJobsAsync(BatchCancelPipelineJobsRequest, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCancelPipelineJobsRequest request = new BatchCancelPipelineJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PipelineJobNames =
                {
                    PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                },
            };
            // Make the request
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> response = await pipelineServiceClient.BatchCancelPipelineJobsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCancelPipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceBatchCancelPipelineJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCancelPipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCancelPipelineJobs</summary>
        public void BatchCancelPipelineJobs()
        {
            // Snippet: BatchCancelPipelineJobs(string, IEnumerable<string>, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]",
            };
            // Make the request
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> response = pipelineServiceClient.BatchCancelPipelineJobs(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCancelPipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchCancelPipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCancelPipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCancelPipelineJobsAsync</summary>
        public async Task BatchCancelPipelineJobsAsync()
        {
            // Snippet: BatchCancelPipelineJobsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchCancelPipelineJobsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]",
            };
            // Make the request
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> response = await pipelineServiceClient.BatchCancelPipelineJobsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCancelPipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceBatchCancelPipelineJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCancelPipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCancelPipelineJobs</summary>
        public void BatchCancelPipelineJobsResourceNames()
        {
            // Snippet: BatchCancelPipelineJobs(LocationName, IEnumerable<PipelineJobName>, CallSettings)
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<PipelineJobName> names = new PipelineJobName[]
            {
                PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> response = pipelineServiceClient.BatchCancelPipelineJobs(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCancelPipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchCancelPipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCancelPipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCancelPipelineJobsAsync</summary>
        public async Task BatchCancelPipelineJobsResourceNamesAsync()
        {
            // Snippet: BatchCancelPipelineJobsAsync(LocationName, IEnumerable<PipelineJobName>, CallSettings)
            // Additional: BatchCancelPipelineJobsAsync(LocationName, IEnumerable<PipelineJobName>, CancellationToken)
            // Create client
            PipelineServiceClient pipelineServiceClient = await PipelineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<PipelineJobName> names = new PipelineJobName[]
            {
                PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
            };
            // Make the request
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> response = await pipelineServiceClient.BatchCancelPipelineJobsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCancelPipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCancelPipelineJobsResponse, BatchCancelPipelineJobsOperationMetadata> retrievedResponse = await pipelineServiceClient.PollOnceBatchCancelPipelineJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCancelPipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
