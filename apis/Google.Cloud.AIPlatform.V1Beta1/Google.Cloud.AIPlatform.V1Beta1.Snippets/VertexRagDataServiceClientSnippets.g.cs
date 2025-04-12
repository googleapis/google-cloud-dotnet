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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVertexRagDataServiceClientSnippets
    {
        /// <summary>Snippet for CreateRagCorpus</summary>
        public void CreateRagCorpusRequestObject()
        {
            // Snippet: CreateRagCorpus(CreateRagCorpusRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            CreateRagCorpusRequest request = new CreateRagCorpusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RagCorpus = new RagCorpus(),
            };
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = vertexRagDataServiceClient.CreateRagCorpus(request);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceCreateRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRagCorpusAsync</summary>
        public async Task CreateRagCorpusRequestObjectAsync()
        {
            // Snippet: CreateRagCorpusAsync(CreateRagCorpusRequest, CallSettings)
            // Additional: CreateRagCorpusAsync(CreateRagCorpusRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRagCorpusRequest request = new CreateRagCorpusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RagCorpus = new RagCorpus(),
            };
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = await vertexRagDataServiceClient.CreateRagCorpusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceCreateRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRagCorpus</summary>
        public void CreateRagCorpus()
        {
            // Snippet: CreateRagCorpus(string, RagCorpus, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagCorpus ragCorpus = new RagCorpus();
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = vertexRagDataServiceClient.CreateRagCorpus(parent, ragCorpus);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceCreateRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRagCorpusAsync</summary>
        public async Task CreateRagCorpusAsync()
        {
            // Snippet: CreateRagCorpusAsync(string, RagCorpus, CallSettings)
            // Additional: CreateRagCorpusAsync(string, RagCorpus, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            RagCorpus ragCorpus = new RagCorpus();
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = await vertexRagDataServiceClient.CreateRagCorpusAsync(parent, ragCorpus);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceCreateRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRagCorpus</summary>
        public void CreateRagCorpusResourceNames()
        {
            // Snippet: CreateRagCorpus(LocationName, RagCorpus, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagCorpus ragCorpus = new RagCorpus();
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = vertexRagDataServiceClient.CreateRagCorpus(parent, ragCorpus);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceCreateRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRagCorpusAsync</summary>
        public async Task CreateRagCorpusResourceNamesAsync()
        {
            // Snippet: CreateRagCorpusAsync(LocationName, RagCorpus, CallSettings)
            // Additional: CreateRagCorpusAsync(LocationName, RagCorpus, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RagCorpus ragCorpus = new RagCorpus();
            // Make the request
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> response = await vertexRagDataServiceClient.CreateRagCorpusAsync(parent, ragCorpus);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, CreateRagCorpusOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceCreateRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagCorpus</summary>
        public void UpdateRagCorpusRequestObject()
        {
            // Snippet: UpdateRagCorpus(UpdateRagCorpusRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            UpdateRagCorpusRequest request = new UpdateRagCorpusRequest
            {
                RagCorpus = new RagCorpus(),
            };
            // Make the request
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> response = vertexRagDataServiceClient.UpdateRagCorpus(request);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceUpdateRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagCorpusAsync</summary>
        public async Task UpdateRagCorpusRequestObjectAsync()
        {
            // Snippet: UpdateRagCorpusAsync(UpdateRagCorpusRequest, CallSettings)
            // Additional: UpdateRagCorpusAsync(UpdateRagCorpusRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRagCorpusRequest request = new UpdateRagCorpusRequest
            {
                RagCorpus = new RagCorpus(),
            };
            // Make the request
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> response = await vertexRagDataServiceClient.UpdateRagCorpusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceUpdateRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagCorpus</summary>
        public void UpdateRagCorpus()
        {
            // Snippet: UpdateRagCorpus(RagCorpus, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpus ragCorpus = new RagCorpus();
            // Make the request
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> response = vertexRagDataServiceClient.UpdateRagCorpus(ragCorpus);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceUpdateRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagCorpusAsync</summary>
        public async Task UpdateRagCorpusAsync()
        {
            // Snippet: UpdateRagCorpusAsync(RagCorpus, CallSettings)
            // Additional: UpdateRagCorpusAsync(RagCorpus, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpus ragCorpus = new RagCorpus();
            // Make the request
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> response = await vertexRagDataServiceClient.UpdateRagCorpusAsync(ragCorpus);

            // Poll until the returned long-running operation is complete
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagCorpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagCorpus, UpdateRagCorpusOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceUpdateRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagCorpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRagCorpus</summary>
        public void GetRagCorpusRequestObject()
        {
            // Snippet: GetRagCorpus(GetRagCorpusRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            GetRagCorpusRequest request = new GetRagCorpusRequest
            {
                RagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
            };
            // Make the request
            RagCorpus response = vertexRagDataServiceClient.GetRagCorpus(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagCorpusAsync</summary>
        public async Task GetRagCorpusRequestObjectAsync()
        {
            // Snippet: GetRagCorpusAsync(GetRagCorpusRequest, CallSettings)
            // Additional: GetRagCorpusAsync(GetRagCorpusRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRagCorpusRequest request = new GetRagCorpusRequest
            {
                RagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
            };
            // Make the request
            RagCorpus response = await vertexRagDataServiceClient.GetRagCorpusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagCorpus</summary>
        public void GetRagCorpus()
        {
            // Snippet: GetRagCorpus(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            RagCorpus response = vertexRagDataServiceClient.GetRagCorpus(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagCorpusAsync</summary>
        public async Task GetRagCorpusAsync()
        {
            // Snippet: GetRagCorpusAsync(string, CallSettings)
            // Additional: GetRagCorpusAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            RagCorpus response = await vertexRagDataServiceClient.GetRagCorpusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagCorpus</summary>
        public void GetRagCorpusResourceNames()
        {
            // Snippet: GetRagCorpus(RagCorpusName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName name = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            RagCorpus response = vertexRagDataServiceClient.GetRagCorpus(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagCorpusAsync</summary>
        public async Task GetRagCorpusResourceNamesAsync()
        {
            // Snippet: GetRagCorpusAsync(RagCorpusName, CallSettings)
            // Additional: GetRagCorpusAsync(RagCorpusName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName name = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            RagCorpus response = await vertexRagDataServiceClient.GetRagCorpusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRagCorpora</summary>
        public void ListRagCorporaRequestObject()
        {
            // Snippet: ListRagCorpora(ListRagCorporaRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            ListRagCorporaRequest request = new ListRagCorporaRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListRagCorporaResponse, RagCorpus> response = vertexRagDataServiceClient.ListRagCorpora(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagCorpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagCorporaResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagCorpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagCorpus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagCorpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagCorporaAsync</summary>
        public async Task ListRagCorporaRequestObjectAsync()
        {
            // Snippet: ListRagCorporaAsync(ListRagCorporaRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRagCorporaRequest request = new ListRagCorporaRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> response = vertexRagDataServiceClient.ListRagCorporaAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RagCorpus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRagCorporaResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagCorpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagCorpus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagCorpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagCorpora</summary>
        public void ListRagCorpora()
        {
            // Snippet: ListRagCorpora(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRagCorporaResponse, RagCorpus> response = vertexRagDataServiceClient.ListRagCorpora(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagCorpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagCorporaResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagCorpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagCorpus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagCorpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagCorporaAsync</summary>
        public async Task ListRagCorporaAsync()
        {
            // Snippet: ListRagCorporaAsync(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> response = vertexRagDataServiceClient.ListRagCorporaAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RagCorpus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRagCorporaResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagCorpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagCorpus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagCorpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagCorpora</summary>
        public void ListRagCorporaResourceNames()
        {
            // Snippet: ListRagCorpora(LocationName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRagCorporaResponse, RagCorpus> response = vertexRagDataServiceClient.ListRagCorpora(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagCorpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagCorporaResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagCorpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagCorpus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagCorpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagCorporaAsync</summary>
        public async Task ListRagCorporaResourceNamesAsync()
        {
            // Snippet: ListRagCorporaAsync(LocationName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> response = vertexRagDataServiceClient.ListRagCorporaAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RagCorpus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRagCorporaResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagCorpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagCorpus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagCorpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRagCorpus</summary>
        public void DeleteRagCorpusRequestObject()
        {
            // Snippet: DeleteRagCorpus(DeleteRagCorpusRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            DeleteRagCorpusRequest request = new DeleteRagCorpusRequest
            {
                RagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.DeleteRagCorpus(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceDeleteRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagCorpusAsync</summary>
        public async Task DeleteRagCorpusRequestObjectAsync()
        {
            // Snippet: DeleteRagCorpusAsync(DeleteRagCorpusRequest, CallSettings)
            // Additional: DeleteRagCorpusAsync(DeleteRagCorpusRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRagCorpusRequest request = new DeleteRagCorpusRequest
            {
                RagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.DeleteRagCorpusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceDeleteRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagCorpus</summary>
        public void DeleteRagCorpus()
        {
            // Snippet: DeleteRagCorpus(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.DeleteRagCorpus(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceDeleteRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagCorpusAsync</summary>
        public async Task DeleteRagCorpusAsync()
        {
            // Snippet: DeleteRagCorpusAsync(string, CallSettings)
            // Additional: DeleteRagCorpusAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.DeleteRagCorpusAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceDeleteRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagCorpus</summary>
        public void DeleteRagCorpusResourceNames()
        {
            // Snippet: DeleteRagCorpus(RagCorpusName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName name = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.DeleteRagCorpus(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceDeleteRagCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagCorpusAsync</summary>
        public async Task DeleteRagCorpusResourceNamesAsync()
        {
            // Snippet: DeleteRagCorpusAsync(RagCorpusName, CallSettings)
            // Additional: DeleteRagCorpusAsync(RagCorpusName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName name = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.DeleteRagCorpusAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceDeleteRagCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadRagFile</summary>
        public void UploadRagFileRequestObject()
        {
            // Snippet: UploadRagFile(UploadRagFileRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            UploadRagFileRequest request = new UploadRagFileRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                RagFile = new RagFile(),
                UploadRagFileConfig = new UploadRagFileConfig(),
            };
            // Make the request
            UploadRagFileResponse response = vertexRagDataServiceClient.UploadRagFile(request);
            // End snippet
        }

        /// <summary>Snippet for UploadRagFileAsync</summary>
        public async Task UploadRagFileRequestObjectAsync()
        {
            // Snippet: UploadRagFileAsync(UploadRagFileRequest, CallSettings)
            // Additional: UploadRagFileAsync(UploadRagFileRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadRagFileRequest request = new UploadRagFileRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                RagFile = new RagFile(),
                UploadRagFileConfig = new UploadRagFileConfig(),
            };
            // Make the request
            UploadRagFileResponse response = await vertexRagDataServiceClient.UploadRagFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UploadRagFile</summary>
        public void UploadRagFile()
        {
            // Snippet: UploadRagFile(string, RagFile, UploadRagFileConfig, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            RagFile ragFile = new RagFile();
            UploadRagFileConfig uploadRagFileConfig = new UploadRagFileConfig();
            // Make the request
            UploadRagFileResponse response = vertexRagDataServiceClient.UploadRagFile(parent, ragFile, uploadRagFileConfig);
            // End snippet
        }

        /// <summary>Snippet for UploadRagFileAsync</summary>
        public async Task UploadRagFileAsync()
        {
            // Snippet: UploadRagFileAsync(string, RagFile, UploadRagFileConfig, CallSettings)
            // Additional: UploadRagFileAsync(string, RagFile, UploadRagFileConfig, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            RagFile ragFile = new RagFile();
            UploadRagFileConfig uploadRagFileConfig = new UploadRagFileConfig();
            // Make the request
            UploadRagFileResponse response = await vertexRagDataServiceClient.UploadRagFileAsync(parent, ragFile, uploadRagFileConfig);
            // End snippet
        }

        /// <summary>Snippet for UploadRagFile</summary>
        public void UploadRagFileResourceNames()
        {
            // Snippet: UploadRagFile(RagCorpusName, RagFile, UploadRagFileConfig, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            RagFile ragFile = new RagFile();
            UploadRagFileConfig uploadRagFileConfig = new UploadRagFileConfig();
            // Make the request
            UploadRagFileResponse response = vertexRagDataServiceClient.UploadRagFile(parent, ragFile, uploadRagFileConfig);
            // End snippet
        }

        /// <summary>Snippet for UploadRagFileAsync</summary>
        public async Task UploadRagFileResourceNamesAsync()
        {
            // Snippet: UploadRagFileAsync(RagCorpusName, RagFile, UploadRagFileConfig, CallSettings)
            // Additional: UploadRagFileAsync(RagCorpusName, RagFile, UploadRagFileConfig, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            RagFile ragFile = new RagFile();
            UploadRagFileConfig uploadRagFileConfig = new UploadRagFileConfig();
            // Make the request
            UploadRagFileResponse response = await vertexRagDataServiceClient.UploadRagFileAsync(parent, ragFile, uploadRagFileConfig);
            // End snippet
        }

        /// <summary>Snippet for ImportRagFiles</summary>
        public void ImportRagFilesRequestObject()
        {
            // Snippet: ImportRagFiles(ImportRagFilesRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            ImportRagFilesRequest request = new ImportRagFilesRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                ImportRagFilesConfig = new ImportRagFilesConfig(),
            };
            // Make the request
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> response = vertexRagDataServiceClient.ImportRagFiles(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportRagFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceImportRagFiles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRagFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRagFilesAsync</summary>
        public async Task ImportRagFilesRequestObjectAsync()
        {
            // Snippet: ImportRagFilesAsync(ImportRagFilesRequest, CallSettings)
            // Additional: ImportRagFilesAsync(ImportRagFilesRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportRagFilesRequest request = new ImportRagFilesRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                ImportRagFilesConfig = new ImportRagFilesConfig(),
            };
            // Make the request
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> response = await vertexRagDataServiceClient.ImportRagFilesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportRagFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceImportRagFilesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRagFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRagFiles</summary>
        public void ImportRagFiles()
        {
            // Snippet: ImportRagFiles(string, ImportRagFilesConfig, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            ImportRagFilesConfig importRagFilesConfig = new ImportRagFilesConfig();
            // Make the request
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> response = vertexRagDataServiceClient.ImportRagFiles(parent, importRagFilesConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportRagFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceImportRagFiles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRagFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRagFilesAsync</summary>
        public async Task ImportRagFilesAsync()
        {
            // Snippet: ImportRagFilesAsync(string, ImportRagFilesConfig, CallSettings)
            // Additional: ImportRagFilesAsync(string, ImportRagFilesConfig, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            ImportRagFilesConfig importRagFilesConfig = new ImportRagFilesConfig();
            // Make the request
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> response = await vertexRagDataServiceClient.ImportRagFilesAsync(parent, importRagFilesConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportRagFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceImportRagFilesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRagFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRagFiles</summary>
        public void ImportRagFilesResourceNames()
        {
            // Snippet: ImportRagFiles(RagCorpusName, ImportRagFilesConfig, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            ImportRagFilesConfig importRagFilesConfig = new ImportRagFilesConfig();
            // Make the request
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> response = vertexRagDataServiceClient.ImportRagFiles(parent, importRagFilesConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportRagFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceImportRagFiles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRagFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRagFilesAsync</summary>
        public async Task ImportRagFilesResourceNamesAsync()
        {
            // Snippet: ImportRagFilesAsync(RagCorpusName, ImportRagFilesConfig, CallSettings)
            // Additional: ImportRagFilesAsync(RagCorpusName, ImportRagFilesConfig, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            ImportRagFilesConfig importRagFilesConfig = new ImportRagFilesConfig();
            // Make the request
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> response = await vertexRagDataServiceClient.ImportRagFilesAsync(parent, importRagFilesConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportRagFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceImportRagFilesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRagFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRagFile</summary>
        public void GetRagFileRequestObject()
        {
            // Snippet: GetRagFile(GetRagFileRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            GetRagFileRequest request = new GetRagFileRequest
            {
                RagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
            };
            // Make the request
            RagFile response = vertexRagDataServiceClient.GetRagFile(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagFileAsync</summary>
        public async Task GetRagFileRequestObjectAsync()
        {
            // Snippet: GetRagFileAsync(GetRagFileRequest, CallSettings)
            // Additional: GetRagFileAsync(GetRagFileRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRagFileRequest request = new GetRagFileRequest
            {
                RagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
            };
            // Make the request
            RagFile response = await vertexRagDataServiceClient.GetRagFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagFile</summary>
        public void GetRagFile()
        {
            // Snippet: GetRagFile(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            // Make the request
            RagFile response = vertexRagDataServiceClient.GetRagFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagFileAsync</summary>
        public async Task GetRagFileAsync()
        {
            // Snippet: GetRagFileAsync(string, CallSettings)
            // Additional: GetRagFileAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            // Make the request
            RagFile response = await vertexRagDataServiceClient.GetRagFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagFile</summary>
        public void GetRagFileResourceNames()
        {
            // Snippet: GetRagFile(RagFileName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagFileName name = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            // Make the request
            RagFile response = vertexRagDataServiceClient.GetRagFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagFileAsync</summary>
        public async Task GetRagFileResourceNamesAsync()
        {
            // Snippet: GetRagFileAsync(RagFileName, CallSettings)
            // Additional: GetRagFileAsync(RagFileName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagFileName name = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            // Make the request
            RagFile response = await vertexRagDataServiceClient.GetRagFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRagFiles</summary>
        public void ListRagFilesRequestObject()
        {
            // Snippet: ListRagFiles(ListRagFilesRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            ListRagFilesRequest request = new ListRagFilesRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
            };
            // Make the request
            PagedEnumerable<ListRagFilesResponse, RagFile> response = vertexRagDataServiceClient.ListRagFiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagFilesAsync</summary>
        public async Task ListRagFilesRequestObjectAsync()
        {
            // Snippet: ListRagFilesAsync(ListRagFilesRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRagFilesRequest request = new ListRagFilesRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRagFilesResponse, RagFile> response = vertexRagDataServiceClient.ListRagFilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RagFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRagFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagFiles</summary>
        public void ListRagFiles()
        {
            // Snippet: ListRagFiles(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            PagedEnumerable<ListRagFilesResponse, RagFile> response = vertexRagDataServiceClient.ListRagFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagFilesAsync</summary>
        public async Task ListRagFilesAsync()
        {
            // Snippet: ListRagFilesAsync(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            PagedAsyncEnumerable<ListRagFilesResponse, RagFile> response = vertexRagDataServiceClient.ListRagFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RagFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRagFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagFiles</summary>
        public void ListRagFilesResourceNames()
        {
            // Snippet: ListRagFiles(RagCorpusName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            PagedEnumerable<ListRagFilesResponse, RagFile> response = vertexRagDataServiceClient.ListRagFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagFilesAsync</summary>
        public async Task ListRagFilesResourceNamesAsync()
        {
            // Snippet: ListRagFilesAsync(RagCorpusName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            PagedAsyncEnumerable<ListRagFilesResponse, RagFile> response = vertexRagDataServiceClient.ListRagFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RagFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRagFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRagFile</summary>
        public void DeleteRagFileRequestObject()
        {
            // Snippet: DeleteRagFile(DeleteRagFileRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            DeleteRagFileRequest request = new DeleteRagFileRequest
            {
                RagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.DeleteRagFile(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceDeleteRagFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagFileAsync</summary>
        public async Task DeleteRagFileRequestObjectAsync()
        {
            // Snippet: DeleteRagFileAsync(DeleteRagFileRequest, CallSettings)
            // Additional: DeleteRagFileAsync(DeleteRagFileRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRagFileRequest request = new DeleteRagFileRequest
            {
                RagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.DeleteRagFileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceDeleteRagFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagFile</summary>
        public void DeleteRagFile()
        {
            // Snippet: DeleteRagFile(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.DeleteRagFile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceDeleteRagFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagFileAsync</summary>
        public async Task DeleteRagFileAsync()
        {
            // Snippet: DeleteRagFileAsync(string, CallSettings)
            // Additional: DeleteRagFileAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.DeleteRagFileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceDeleteRagFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagFile</summary>
        public void DeleteRagFileResourceNames()
        {
            // Snippet: DeleteRagFile(RagFileName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagFileName name = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.DeleteRagFile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceDeleteRagFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRagFileAsync</summary>
        public async Task DeleteRagFileResourceNamesAsync()
        {
            // Snippet: DeleteRagFileAsync(RagFileName, CallSettings)
            // Additional: DeleteRagFileAsync(RagFileName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagFileName name = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.DeleteRagFileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceDeleteRagFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagEngineConfig</summary>
        public void UpdateRagEngineConfigRequestObject()
        {
            // Snippet: UpdateRagEngineConfig(UpdateRagEngineConfigRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            UpdateRagEngineConfigRequest request = new UpdateRagEngineConfigRequest
            {
                RagEngineConfig = new RagEngineConfig(),
            };
            // Make the request
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> response = vertexRagDataServiceClient.UpdateRagEngineConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagEngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceUpdateRagEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagEngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagEngineConfigAsync</summary>
        public async Task UpdateRagEngineConfigRequestObjectAsync()
        {
            // Snippet: UpdateRagEngineConfigAsync(UpdateRagEngineConfigRequest, CallSettings)
            // Additional: UpdateRagEngineConfigAsync(UpdateRagEngineConfigRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRagEngineConfigRequest request = new UpdateRagEngineConfigRequest
            {
                RagEngineConfig = new RagEngineConfig(),
            };
            // Make the request
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> response = await vertexRagDataServiceClient.UpdateRagEngineConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagEngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceUpdateRagEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagEngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagEngineConfig</summary>
        public void UpdateRagEngineConfig()
        {
            // Snippet: UpdateRagEngineConfig(RagEngineConfig, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagEngineConfig ragEngineConfig = new RagEngineConfig();
            // Make the request
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> response = vertexRagDataServiceClient.UpdateRagEngineConfig(ragEngineConfig);

            // Poll until the returned long-running operation is complete
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RagEngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceUpdateRagEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagEngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagEngineConfigAsync</summary>
        public async Task UpdateRagEngineConfigAsync()
        {
            // Snippet: UpdateRagEngineConfigAsync(RagEngineConfig, CallSettings)
            // Additional: UpdateRagEngineConfigAsync(RagEngineConfig, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagEngineConfig ragEngineConfig = new RagEngineConfig();
            // Make the request
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> response = await vertexRagDataServiceClient.UpdateRagEngineConfigAsync(ragEngineConfig);

            // Poll until the returned long-running operation is complete
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RagEngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RagEngineConfig, UpdateRagEngineConfigOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceUpdateRagEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RagEngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRagEngineConfig</summary>
        public void GetRagEngineConfigRequestObject()
        {
            // Snippet: GetRagEngineConfig(GetRagEngineConfigRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            GetRagEngineConfigRequest request = new GetRagEngineConfigRequest
            {
                RagEngineConfigName = RagEngineConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RagEngineConfig response = vertexRagDataServiceClient.GetRagEngineConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagEngineConfigAsync</summary>
        public async Task GetRagEngineConfigRequestObjectAsync()
        {
            // Snippet: GetRagEngineConfigAsync(GetRagEngineConfigRequest, CallSettings)
            // Additional: GetRagEngineConfigAsync(GetRagEngineConfigRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRagEngineConfigRequest request = new GetRagEngineConfigRequest
            {
                RagEngineConfigName = RagEngineConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RagEngineConfig response = await vertexRagDataServiceClient.GetRagEngineConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagEngineConfig</summary>
        public void GetRagEngineConfig()
        {
            // Snippet: GetRagEngineConfig(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragEngineConfig";
            // Make the request
            RagEngineConfig response = vertexRagDataServiceClient.GetRagEngineConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagEngineConfigAsync</summary>
        public async Task GetRagEngineConfigAsync()
        {
            // Snippet: GetRagEngineConfigAsync(string, CallSettings)
            // Additional: GetRagEngineConfigAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragEngineConfig";
            // Make the request
            RagEngineConfig response = await vertexRagDataServiceClient.GetRagEngineConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagEngineConfig</summary>
        public void GetRagEngineConfigResourceNames()
        {
            // Snippet: GetRagEngineConfig(RagEngineConfigName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagEngineConfigName name = RagEngineConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            RagEngineConfig response = vertexRagDataServiceClient.GetRagEngineConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagEngineConfigAsync</summary>
        public async Task GetRagEngineConfigResourceNamesAsync()
        {
            // Snippet: GetRagEngineConfigAsync(RagEngineConfigName, CallSettings)
            // Additional: GetRagEngineConfigAsync(RagEngineConfigName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagEngineConfigName name = RagEngineConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            RagEngineConfig response = await vertexRagDataServiceClient.GetRagEngineConfigAsync(name);
            // End snippet
        }
    }
}
