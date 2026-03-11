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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
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
            await foreach (RagCorpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagCorporaResponse page in response.AsRawResponses())
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
            await foreach (RagCorpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagCorporaResponse page in response.AsRawResponses())
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
            await foreach (RagCorpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagCorporaResponse page in response.AsRawResponses())
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
                ForceDelete = false,
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
                ForceDelete = false,
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
            await foreach (RagFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagFilesResponse page in response.AsRawResponses())
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
            await foreach (RagFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagFilesResponse page in response.AsRawResponses())
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
            await foreach (RagFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagFilesResponse page in response.AsRawResponses())
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
                ForceDelete = false,
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
                ForceDelete = false,
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

        /// <summary>Snippet for CreateRagDataSchema</summary>
        public void CreateRagDataSchemaRequestObject()
        {
            // Snippet: CreateRagDataSchema(CreateRagDataSchemaRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            CreateRagDataSchemaRequest request = new CreateRagDataSchemaRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                RagDataSchema = new RagDataSchema(),
                RagDataSchemaId = "",
            };
            // Make the request
            RagDataSchema response = vertexRagDataServiceClient.CreateRagDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRagDataSchemaAsync</summary>
        public async Task CreateRagDataSchemaRequestObjectAsync()
        {
            // Snippet: CreateRagDataSchemaAsync(CreateRagDataSchemaRequest, CallSettings)
            // Additional: CreateRagDataSchemaAsync(CreateRagDataSchemaRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRagDataSchemaRequest request = new CreateRagDataSchemaRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                RagDataSchema = new RagDataSchema(),
                RagDataSchemaId = "",
            };
            // Make the request
            RagDataSchema response = await vertexRagDataServiceClient.CreateRagDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRagDataSchema</summary>
        public void CreateRagDataSchema()
        {
            // Snippet: CreateRagDataSchema(string, RagDataSchema, string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            RagDataSchema ragDataSchema = new RagDataSchema();
            string ragDataSchemaId = "";
            // Make the request
            RagDataSchema response = vertexRagDataServiceClient.CreateRagDataSchema(parent, ragDataSchema, ragDataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateRagDataSchemaAsync</summary>
        public async Task CreateRagDataSchemaAsync()
        {
            // Snippet: CreateRagDataSchemaAsync(string, RagDataSchema, string, CallSettings)
            // Additional: CreateRagDataSchemaAsync(string, RagDataSchema, string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            RagDataSchema ragDataSchema = new RagDataSchema();
            string ragDataSchemaId = "";
            // Make the request
            RagDataSchema response = await vertexRagDataServiceClient.CreateRagDataSchemaAsync(parent, ragDataSchema, ragDataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateRagDataSchema</summary>
        public void CreateRagDataSchemaResourceNames()
        {
            // Snippet: CreateRagDataSchema(RagCorpusName, RagDataSchema, string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            RagDataSchema ragDataSchema = new RagDataSchema();
            string ragDataSchemaId = "";
            // Make the request
            RagDataSchema response = vertexRagDataServiceClient.CreateRagDataSchema(parent, ragDataSchema, ragDataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for CreateRagDataSchemaAsync</summary>
        public async Task CreateRagDataSchemaResourceNamesAsync()
        {
            // Snippet: CreateRagDataSchemaAsync(RagCorpusName, RagDataSchema, string, CallSettings)
            // Additional: CreateRagDataSchemaAsync(RagCorpusName, RagDataSchema, string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            RagDataSchema ragDataSchema = new RagDataSchema();
            string ragDataSchemaId = "";
            // Make the request
            RagDataSchema response = await vertexRagDataServiceClient.CreateRagDataSchemaAsync(parent, ragDataSchema, ragDataSchemaId);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRagDataSchemas</summary>
        public void BatchCreateRagDataSchemasRequestObject()
        {
            // Snippet: BatchCreateRagDataSchemas(BatchCreateRagDataSchemasRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateRagDataSchemasRequest request = new BatchCreateRagDataSchemasRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                Requests =
                {
                    new CreateRagDataSchemaRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateRagDataSchemasResponse, BatchCreateRagDataSchemasOperationMetadata> response = vertexRagDataServiceClient.BatchCreateRagDataSchemas(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRagDataSchemasResponse, BatchCreateRagDataSchemasOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateRagDataSchemasResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRagDataSchemasResponse, BatchCreateRagDataSchemasOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceBatchCreateRagDataSchemas(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRagDataSchemasResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRagDataSchemasAsync</summary>
        public async Task BatchCreateRagDataSchemasRequestObjectAsync()
        {
            // Snippet: BatchCreateRagDataSchemasAsync(BatchCreateRagDataSchemasRequest, CallSettings)
            // Additional: BatchCreateRagDataSchemasAsync(BatchCreateRagDataSchemasRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateRagDataSchemasRequest request = new BatchCreateRagDataSchemasRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                Requests =
                {
                    new CreateRagDataSchemaRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateRagDataSchemasResponse, BatchCreateRagDataSchemasOperationMetadata> response = await vertexRagDataServiceClient.BatchCreateRagDataSchemasAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRagDataSchemasResponse, BatchCreateRagDataSchemasOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateRagDataSchemasResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRagDataSchemasResponse, BatchCreateRagDataSchemasOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceBatchCreateRagDataSchemasAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRagDataSchemasResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRagDataSchema</summary>
        public void GetRagDataSchemaRequestObject()
        {
            // Snippet: GetRagDataSchema(GetRagDataSchemaRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            GetRagDataSchemaRequest request = new GetRagDataSchemaRequest
            {
                RagDataSchemaName = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]"),
            };
            // Make the request
            RagDataSchema response = vertexRagDataServiceClient.GetRagDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagDataSchemaAsync</summary>
        public async Task GetRagDataSchemaRequestObjectAsync()
        {
            // Snippet: GetRagDataSchemaAsync(GetRagDataSchemaRequest, CallSettings)
            // Additional: GetRagDataSchemaAsync(GetRagDataSchemaRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRagDataSchemaRequest request = new GetRagDataSchemaRequest
            {
                RagDataSchemaName = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]"),
            };
            // Make the request
            RagDataSchema response = await vertexRagDataServiceClient.GetRagDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagDataSchema</summary>
        public void GetRagDataSchema()
        {
            // Snippet: GetRagDataSchema(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragDataSchemas/[RAG_DATA_SCHEMA]";
            // Make the request
            RagDataSchema response = vertexRagDataServiceClient.GetRagDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagDataSchemaAsync</summary>
        public async Task GetRagDataSchemaAsync()
        {
            // Snippet: GetRagDataSchemaAsync(string, CallSettings)
            // Additional: GetRagDataSchemaAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragDataSchemas/[RAG_DATA_SCHEMA]";
            // Make the request
            RagDataSchema response = await vertexRagDataServiceClient.GetRagDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagDataSchema</summary>
        public void GetRagDataSchemaResourceNames()
        {
            // Snippet: GetRagDataSchema(RagDataSchemaName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagDataSchemaName name = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]");
            // Make the request
            RagDataSchema response = vertexRagDataServiceClient.GetRagDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagDataSchemaAsync</summary>
        public async Task GetRagDataSchemaResourceNamesAsync()
        {
            // Snippet: GetRagDataSchemaAsync(RagDataSchemaName, CallSettings)
            // Additional: GetRagDataSchemaAsync(RagDataSchemaName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagDataSchemaName name = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]");
            // Make the request
            RagDataSchema response = await vertexRagDataServiceClient.GetRagDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRagDataSchemas</summary>
        public void ListRagDataSchemasRequestObject()
        {
            // Snippet: ListRagDataSchemas(ListRagDataSchemasRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            ListRagDataSchemasRequest request = new ListRagDataSchemasRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
            };
            // Make the request
            PagedEnumerable<ListRagDataSchemasResponse, RagDataSchema> response = vertexRagDataServiceClient.ListRagDataSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagDataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagDataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagDataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagDataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagDataSchemasAsync</summary>
        public async Task ListRagDataSchemasRequestObjectAsync()
        {
            // Snippet: ListRagDataSchemasAsync(ListRagDataSchemasRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRagDataSchemasRequest request = new ListRagDataSchemasRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRagDataSchemasResponse, RagDataSchema> response = vertexRagDataServiceClient.ListRagDataSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RagDataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagDataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagDataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagDataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagDataSchemas</summary>
        public void ListRagDataSchemas()
        {
            // Snippet: ListRagDataSchemas(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            PagedEnumerable<ListRagDataSchemasResponse, RagDataSchema> response = vertexRagDataServiceClient.ListRagDataSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagDataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagDataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagDataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagDataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagDataSchemasAsync</summary>
        public async Task ListRagDataSchemasAsync()
        {
            // Snippet: ListRagDataSchemasAsync(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]";
            // Make the request
            PagedAsyncEnumerable<ListRagDataSchemasResponse, RagDataSchema> response = vertexRagDataServiceClient.ListRagDataSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RagDataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagDataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagDataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagDataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagDataSchemas</summary>
        public void ListRagDataSchemasResourceNames()
        {
            // Snippet: ListRagDataSchemas(RagCorpusName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            PagedEnumerable<ListRagDataSchemasResponse, RagDataSchema> response = vertexRagDataServiceClient.ListRagDataSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagDataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagDataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagDataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagDataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagDataSchemasAsync</summary>
        public async Task ListRagDataSchemasResourceNamesAsync()
        {
            // Snippet: ListRagDataSchemasAsync(RagCorpusName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagCorpusName parent = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]");
            // Make the request
            PagedAsyncEnumerable<ListRagDataSchemasResponse, RagDataSchema> response = vertexRagDataServiceClient.ListRagDataSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RagDataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagDataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagDataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagDataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRagDataSchema</summary>
        public void DeleteRagDataSchemaRequestObject()
        {
            // Snippet: DeleteRagDataSchema(DeleteRagDataSchemaRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            DeleteRagDataSchemaRequest request = new DeleteRagDataSchemaRequest
            {
                RagDataSchemaName = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]"),
            };
            // Make the request
            vertexRagDataServiceClient.DeleteRagDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagDataSchemaAsync</summary>
        public async Task DeleteRagDataSchemaRequestObjectAsync()
        {
            // Snippet: DeleteRagDataSchemaAsync(DeleteRagDataSchemaRequest, CallSettings)
            // Additional: DeleteRagDataSchemaAsync(DeleteRagDataSchemaRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRagDataSchemaRequest request = new DeleteRagDataSchemaRequest
            {
                RagDataSchemaName = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]"),
            };
            // Make the request
            await vertexRagDataServiceClient.DeleteRagDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagDataSchema</summary>
        public void DeleteRagDataSchema()
        {
            // Snippet: DeleteRagDataSchema(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragDataSchemas/[RAG_DATA_SCHEMA]";
            // Make the request
            vertexRagDataServiceClient.DeleteRagDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagDataSchemaAsync</summary>
        public async Task DeleteRagDataSchemaAsync()
        {
            // Snippet: DeleteRagDataSchemaAsync(string, CallSettings)
            // Additional: DeleteRagDataSchemaAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragDataSchemas/[RAG_DATA_SCHEMA]";
            // Make the request
            await vertexRagDataServiceClient.DeleteRagDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagDataSchema</summary>
        public void DeleteRagDataSchemaResourceNames()
        {
            // Snippet: DeleteRagDataSchema(RagDataSchemaName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagDataSchemaName name = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]");
            // Make the request
            vertexRagDataServiceClient.DeleteRagDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagDataSchemaAsync</summary>
        public async Task DeleteRagDataSchemaResourceNamesAsync()
        {
            // Snippet: DeleteRagDataSchemaAsync(RagDataSchemaName, CallSettings)
            // Additional: DeleteRagDataSchemaAsync(RagDataSchemaName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagDataSchemaName name = RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]");
            // Make the request
            await vertexRagDataServiceClient.DeleteRagDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRagDataSchemas</summary>
        public void BatchDeleteRagDataSchemasRequestObject()
        {
            // Snippet: BatchDeleteRagDataSchemas(BatchDeleteRagDataSchemasRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteRagDataSchemasRequest request = new BatchDeleteRagDataSchemasRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                RagDataSchemaNames =
                {
                    RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]"),
                },
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.BatchDeleteRagDataSchemas(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceBatchDeleteRagDataSchemas(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRagDataSchemasAsync</summary>
        public async Task BatchDeleteRagDataSchemasRequestObjectAsync()
        {
            // Snippet: BatchDeleteRagDataSchemasAsync(BatchDeleteRagDataSchemasRequest, CallSettings)
            // Additional: BatchDeleteRagDataSchemasAsync(BatchDeleteRagDataSchemasRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteRagDataSchemasRequest request = new BatchDeleteRagDataSchemasRequest
            {
                ParentAsRagCorpusName = RagCorpusName.FromProjectLocationRagCorpus("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]"),
                RagDataSchemaNames =
                {
                    RagDataSchemaName.FromProjectLocationRagCorpusRagDataSchema("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_DATA_SCHEMA]"),
                },
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.BatchDeleteRagDataSchemasAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceBatchDeleteRagDataSchemasAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRagMetadata</summary>
        public void CreateRagMetadataRequestObject()
        {
            // Snippet: CreateRagMetadata(CreateRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            CreateRagMetadataRequest request = new CreateRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
                RagMetadata = new RagMetadata(),
                RagMetadataId = "",
            };
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.CreateRagMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRagMetadataAsync</summary>
        public async Task CreateRagMetadataRequestObjectAsync()
        {
            // Snippet: CreateRagMetadataAsync(CreateRagMetadataRequest, CallSettings)
            // Additional: CreateRagMetadataAsync(CreateRagMetadataRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRagMetadataRequest request = new CreateRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
                RagMetadata = new RagMetadata(),
                RagMetadataId = "",
            };
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.CreateRagMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRagMetadata</summary>
        public void CreateRagMetadata()
        {
            // Snippet: CreateRagMetadata(string, RagMetadata, string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            RagMetadata ragMetadata = new RagMetadata();
            string ragMetadataId = "";
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.CreateRagMetadata(parent, ragMetadata, ragMetadataId);
            // End snippet
        }

        /// <summary>Snippet for CreateRagMetadataAsync</summary>
        public async Task CreateRagMetadataAsync()
        {
            // Snippet: CreateRagMetadataAsync(string, RagMetadata, string, CallSettings)
            // Additional: CreateRagMetadataAsync(string, RagMetadata, string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            RagMetadata ragMetadata = new RagMetadata();
            string ragMetadataId = "";
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.CreateRagMetadataAsync(parent, ragMetadata, ragMetadataId);
            // End snippet
        }

        /// <summary>Snippet for CreateRagMetadata</summary>
        public void CreateRagMetadataResourceNames()
        {
            // Snippet: CreateRagMetadata(RagFileName, RagMetadata, string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagFileName parent = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            RagMetadata ragMetadata = new RagMetadata();
            string ragMetadataId = "";
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.CreateRagMetadata(parent, ragMetadata, ragMetadataId);
            // End snippet
        }

        /// <summary>Snippet for CreateRagMetadataAsync</summary>
        public async Task CreateRagMetadataResourceNamesAsync()
        {
            // Snippet: CreateRagMetadataAsync(RagFileName, RagMetadata, string, CallSettings)
            // Additional: CreateRagMetadataAsync(RagFileName, RagMetadata, string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagFileName parent = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            RagMetadata ragMetadata = new RagMetadata();
            string ragMetadataId = "";
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.CreateRagMetadataAsync(parent, ragMetadata, ragMetadataId);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRagMetadata</summary>
        public void BatchCreateRagMetadataRequestObject()
        {
            // Snippet: BatchCreateRagMetadata(BatchCreateRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateRagMetadataRequest request = new BatchCreateRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
                Requests =
                {
                    new CreateRagMetadataRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateRagMetadataResponse, BatchCreateRagMetadataOperationMetadata> response = vertexRagDataServiceClient.BatchCreateRagMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRagMetadataResponse, BatchCreateRagMetadataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateRagMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRagMetadataResponse, BatchCreateRagMetadataOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceBatchCreateRagMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRagMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRagMetadataAsync</summary>
        public async Task BatchCreateRagMetadataRequestObjectAsync()
        {
            // Snippet: BatchCreateRagMetadataAsync(BatchCreateRagMetadataRequest, CallSettings)
            // Additional: BatchCreateRagMetadataAsync(BatchCreateRagMetadataRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateRagMetadataRequest request = new BatchCreateRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
                Requests =
                {
                    new CreateRagMetadataRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateRagMetadataResponse, BatchCreateRagMetadataOperationMetadata> response = await vertexRagDataServiceClient.BatchCreateRagMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRagMetadataResponse, BatchCreateRagMetadataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateRagMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRagMetadataResponse, BatchCreateRagMetadataOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceBatchCreateRagMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRagMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRagMetadata</summary>
        public void UpdateRagMetadataRequestObject()
        {
            // Snippet: UpdateRagMetadata(UpdateRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            UpdateRagMetadataRequest request = new UpdateRagMetadataRequest
            {
                RagMetadata = new RagMetadata(),
            };
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.UpdateRagMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRagMetadataAsync</summary>
        public async Task UpdateRagMetadataRequestObjectAsync()
        {
            // Snippet: UpdateRagMetadataAsync(UpdateRagMetadataRequest, CallSettings)
            // Additional: UpdateRagMetadataAsync(UpdateRagMetadataRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRagMetadataRequest request = new UpdateRagMetadataRequest
            {
                RagMetadata = new RagMetadata(),
            };
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.UpdateRagMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRagMetadata</summary>
        public void UpdateRagMetadata()
        {
            // Snippet: UpdateRagMetadata(RagMetadata, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagMetadata ragMetadata = new RagMetadata();
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.UpdateRagMetadata(ragMetadata);
            // End snippet
        }

        /// <summary>Snippet for UpdateRagMetadataAsync</summary>
        public async Task UpdateRagMetadataAsync()
        {
            // Snippet: UpdateRagMetadataAsync(RagMetadata, CallSettings)
            // Additional: UpdateRagMetadataAsync(RagMetadata, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagMetadata ragMetadata = new RagMetadata();
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.UpdateRagMetadataAsync(ragMetadata);
            // End snippet
        }

        /// <summary>Snippet for GetRagMetadata</summary>
        public void GetRagMetadataRequestObject()
        {
            // Snippet: GetRagMetadata(GetRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            GetRagMetadataRequest request = new GetRagMetadataRequest
            {
                RagMetadataName = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]"),
            };
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.GetRagMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagMetadataAsync</summary>
        public async Task GetRagMetadataRequestObjectAsync()
        {
            // Snippet: GetRagMetadataAsync(GetRagMetadataRequest, CallSettings)
            // Additional: GetRagMetadataAsync(GetRagMetadataRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRagMetadataRequest request = new GetRagMetadataRequest
            {
                RagMetadataName = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]"),
            };
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.GetRagMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRagMetadata</summary>
        public void GetRagMetadata()
        {
            // Snippet: GetRagMetadata(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]/ragMetadata/[RAG_METADATA]";
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.GetRagMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagMetadataAsync</summary>
        public async Task GetRagMetadataAsync()
        {
            // Snippet: GetRagMetadataAsync(string, CallSettings)
            // Additional: GetRagMetadataAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]/ragMetadata/[RAG_METADATA]";
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.GetRagMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagMetadata</summary>
        public void GetRagMetadataResourceNames()
        {
            // Snippet: GetRagMetadata(RagMetadataName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagMetadataName name = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]");
            // Make the request
            RagMetadata response = vertexRagDataServiceClient.GetRagMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetRagMetadataAsync</summary>
        public async Task GetRagMetadataResourceNamesAsync()
        {
            // Snippet: GetRagMetadataAsync(RagMetadataName, CallSettings)
            // Additional: GetRagMetadataAsync(RagMetadataName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagMetadataName name = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]");
            // Make the request
            RagMetadata response = await vertexRagDataServiceClient.GetRagMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRagMetadata</summary>
        public void ListRagMetadataRequestObject()
        {
            // Snippet: ListRagMetadata(ListRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            ListRagMetadataRequest request = new ListRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
            };
            // Make the request
            PagedEnumerable<ListRagMetadataResponse, RagMetadata> response = vertexRagDataServiceClient.ListRagMetadata(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagMetadataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagMetadataAsync</summary>
        public async Task ListRagMetadataRequestObjectAsync()
        {
            // Snippet: ListRagMetadataAsync(ListRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRagMetadataRequest request = new ListRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRagMetadataResponse, RagMetadata> response = vertexRagDataServiceClient.ListRagMetadataAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RagMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagMetadataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagMetadata</summary>
        public void ListRagMetadata()
        {
            // Snippet: ListRagMetadata(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            // Make the request
            PagedEnumerable<ListRagMetadataResponse, RagMetadata> response = vertexRagDataServiceClient.ListRagMetadata(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagMetadataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagMetadataAsync</summary>
        public async Task ListRagMetadataAsync()
        {
            // Snippet: ListRagMetadataAsync(string, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]";
            // Make the request
            PagedAsyncEnumerable<ListRagMetadataResponse, RagMetadata> response = vertexRagDataServiceClient.ListRagMetadataAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RagMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagMetadataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagMetadata</summary>
        public void ListRagMetadataResourceNames()
        {
            // Snippet: ListRagMetadata(RagFileName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagFileName parent = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            // Make the request
            PagedEnumerable<ListRagMetadataResponse, RagMetadata> response = vertexRagDataServiceClient.ListRagMetadata(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RagMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRagMetadataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRagMetadataAsync</summary>
        public async Task ListRagMetadataResourceNamesAsync()
        {
            // Snippet: ListRagMetadataAsync(RagFileName, string, int?, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagFileName parent = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]");
            // Make the request
            PagedAsyncEnumerable<ListRagMetadataResponse, RagMetadata> response = vertexRagDataServiceClient.ListRagMetadataAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RagMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRagMetadataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RagMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RagMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RagMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRagMetadata</summary>
        public void DeleteRagMetadataRequestObject()
        {
            // Snippet: DeleteRagMetadata(DeleteRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            DeleteRagMetadataRequest request = new DeleteRagMetadataRequest
            {
                RagMetadataName = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]"),
            };
            // Make the request
            vertexRagDataServiceClient.DeleteRagMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagMetadataAsync</summary>
        public async Task DeleteRagMetadataRequestObjectAsync()
        {
            // Snippet: DeleteRagMetadataAsync(DeleteRagMetadataRequest, CallSettings)
            // Additional: DeleteRagMetadataAsync(DeleteRagMetadataRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRagMetadataRequest request = new DeleteRagMetadataRequest
            {
                RagMetadataName = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]"),
            };
            // Make the request
            await vertexRagDataServiceClient.DeleteRagMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagMetadata</summary>
        public void DeleteRagMetadata()
        {
            // Snippet: DeleteRagMetadata(string, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]/ragMetadata/[RAG_METADATA]";
            // Make the request
            vertexRagDataServiceClient.DeleteRagMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagMetadataAsync</summary>
        public async Task DeleteRagMetadataAsync()
        {
            // Snippet: DeleteRagMetadataAsync(string, CallSettings)
            // Additional: DeleteRagMetadataAsync(string, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/ragCorpora/[RAG_CORPUS]/ragFiles/[RAG_FILE]/ragMetadata/[RAG_METADATA]";
            // Make the request
            await vertexRagDataServiceClient.DeleteRagMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagMetadata</summary>
        public void DeleteRagMetadataResourceNames()
        {
            // Snippet: DeleteRagMetadata(RagMetadataName, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            RagMetadataName name = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]");
            // Make the request
            vertexRagDataServiceClient.DeleteRagMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRagMetadataAsync</summary>
        public async Task DeleteRagMetadataResourceNamesAsync()
        {
            // Snippet: DeleteRagMetadataAsync(RagMetadataName, CallSettings)
            // Additional: DeleteRagMetadataAsync(RagMetadataName, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            RagMetadataName name = RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]");
            // Make the request
            await vertexRagDataServiceClient.DeleteRagMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRagMetadata</summary>
        public void BatchDeleteRagMetadataRequestObject()
        {
            // Snippet: BatchDeleteRagMetadata(BatchDeleteRagMetadataRequest, CallSettings)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = VertexRagDataServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteRagMetadataRequest request = new BatchDeleteRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
                RagMetadataNames =
                {
                    RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]"),
                },
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = vertexRagDataServiceClient.BatchDeleteRagMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = vertexRagDataServiceClient.PollOnceBatchDeleteRagMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRagMetadataAsync</summary>
        public async Task BatchDeleteRagMetadataRequestObjectAsync()
        {
            // Snippet: BatchDeleteRagMetadataAsync(BatchDeleteRagMetadataRequest, CallSettings)
            // Additional: BatchDeleteRagMetadataAsync(BatchDeleteRagMetadataRequest, CancellationToken)
            // Create client
            VertexRagDataServiceClient vertexRagDataServiceClient = await VertexRagDataServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteRagMetadataRequest request = new BatchDeleteRagMetadataRequest
            {
                ParentAsRagFileName = RagFileName.FromProjectLocationRagCorpusRagFile("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]"),
                RagMetadataNames =
                {
                    RagMetadataName.FromProjectLocationRagCorpusRagFileRagMetadata("[PROJECT]", "[LOCATION]", "[RAG_CORPUS]", "[RAG_FILE]", "[RAG_METADATA]"),
                },
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await vertexRagDataServiceClient.BatchDeleteRagMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await vertexRagDataServiceClient.PollOnceBatchDeleteRagMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
