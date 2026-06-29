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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAssistantServiceClientSnippets
    {
        /// <summary>Snippet for StreamAssist</summary>
        public async Task StreamAssistRequestObject()
        {
            // Snippet: StreamAssist(StreamAssistRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            StreamAssistRequest request = new StreamAssistRequest
            {
                AssistantName = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]"),
                Query = new Query(),
                SessionAsSessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                UserMetadata = new AssistUserMetadata(),
                ToolsSpec = new StreamAssistRequest.Types.ToolsSpec(),
                GenerationSpec = new StreamAssistRequest.Types.GenerationSpec(),
            };
            // Make the request, returning a streaming response
            using AssistantServiceClient.StreamAssistStream response = assistantServiceClient.StreamAssist(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamAssistResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamAssistResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for CreateAssistant</summary>
        public void CreateAssistantRequestObject()
        {
            // Snippet: CreateAssistant(CreateAssistantRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            CreateAssistantRequest request = new CreateAssistantRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
                Assistant = new Assistant(),
                AssistantId = "",
            };
            // Make the request
            Assistant response = assistantServiceClient.CreateAssistant(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantAsync</summary>
        public async Task CreateAssistantRequestObjectAsync()
        {
            // Snippet: CreateAssistantAsync(CreateAssistantRequest, CallSettings)
            // Additional: CreateAssistantAsync(CreateAssistantRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAssistantRequest request = new CreateAssistantRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
                Assistant = new Assistant(),
                AssistantId = "",
            };
            // Make the request
            Assistant response = await assistantServiceClient.CreateAssistantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistant</summary>
        public void DeleteAssistantRequestObject()
        {
            // Snippet: DeleteAssistant(DeleteAssistantRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            DeleteAssistantRequest request = new DeleteAssistantRequest
            {
                AssistantName = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]"),
            };
            // Make the request
            assistantServiceClient.DeleteAssistant(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantAsync</summary>
        public async Task DeleteAssistantRequestObjectAsync()
        {
            // Snippet: DeleteAssistantAsync(DeleteAssistantRequest, CallSettings)
            // Additional: DeleteAssistantAsync(DeleteAssistantRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAssistantRequest request = new DeleteAssistantRequest
            {
                AssistantName = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]"),
            };
            // Make the request
            await assistantServiceClient.DeleteAssistantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistant</summary>
        public void DeleteAssistant()
        {
            // Snippet: DeleteAssistant(string, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]/assistants/[ASSISTANT]";
            // Make the request
            assistantServiceClient.DeleteAssistant(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantAsync</summary>
        public async Task DeleteAssistantAsync()
        {
            // Snippet: DeleteAssistantAsync(string, CallSettings)
            // Additional: DeleteAssistantAsync(string, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]/assistants/[ASSISTANT]";
            // Make the request
            await assistantServiceClient.DeleteAssistantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistant</summary>
        public void DeleteAssistantResourceNames()
        {
            // Snippet: DeleteAssistant(AssistantName, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            AssistantName name = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]");
            // Make the request
            assistantServiceClient.DeleteAssistant(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantAsync</summary>
        public async Task DeleteAssistantResourceNamesAsync()
        {
            // Snippet: DeleteAssistantAsync(AssistantName, CallSettings)
            // Additional: DeleteAssistantAsync(AssistantName, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssistantName name = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]");
            // Make the request
            await assistantServiceClient.DeleteAssistantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssistant</summary>
        public void UpdateAssistantRequestObject()
        {
            // Snippet: UpdateAssistant(UpdateAssistantRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            UpdateAssistantRequest request = new UpdateAssistantRequest
            {
                Assistant = new Assistant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Assistant response = assistantServiceClient.UpdateAssistant(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssistantAsync</summary>
        public async Task UpdateAssistantRequestObjectAsync()
        {
            // Snippet: UpdateAssistantAsync(UpdateAssistantRequest, CallSettings)
            // Additional: UpdateAssistantAsync(UpdateAssistantRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAssistantRequest request = new UpdateAssistantRequest
            {
                Assistant = new Assistant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Assistant response = await assistantServiceClient.UpdateAssistantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssistant</summary>
        public void UpdateAssistant()
        {
            // Snippet: UpdateAssistant(Assistant, FieldMask, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            Assistant assistant = new Assistant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Assistant response = assistantServiceClient.UpdateAssistant(assistant, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssistantAsync</summary>
        public async Task UpdateAssistantAsync()
        {
            // Snippet: UpdateAssistantAsync(Assistant, FieldMask, CallSettings)
            // Additional: UpdateAssistantAsync(Assistant, FieldMask, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            Assistant assistant = new Assistant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Assistant response = await assistantServiceClient.UpdateAssistantAsync(assistant, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetAssistant</summary>
        public void GetAssistantRequestObject()
        {
            // Snippet: GetAssistant(GetAssistantRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            GetAssistantRequest request = new GetAssistantRequest
            {
                AssistantName = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]"),
            };
            // Make the request
            Assistant response = assistantServiceClient.GetAssistant(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantAsync</summary>
        public async Task GetAssistantRequestObjectAsync()
        {
            // Snippet: GetAssistantAsync(GetAssistantRequest, CallSettings)
            // Additional: GetAssistantAsync(GetAssistantRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssistantRequest request = new GetAssistantRequest
            {
                AssistantName = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]"),
            };
            // Make the request
            Assistant response = await assistantServiceClient.GetAssistantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssistant</summary>
        public void GetAssistant()
        {
            // Snippet: GetAssistant(string, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]/assistants/[ASSISTANT]";
            // Make the request
            Assistant response = assistantServiceClient.GetAssistant(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantAsync</summary>
        public async Task GetAssistantAsync()
        {
            // Snippet: GetAssistantAsync(string, CallSettings)
            // Additional: GetAssistantAsync(string, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]/assistants/[ASSISTANT]";
            // Make the request
            Assistant response = await assistantServiceClient.GetAssistantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssistant</summary>
        public void GetAssistantResourceNames()
        {
            // Snippet: GetAssistant(AssistantName, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            AssistantName name = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]");
            // Make the request
            Assistant response = assistantServiceClient.GetAssistant(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantAsync</summary>
        public async Task GetAssistantResourceNamesAsync()
        {
            // Snippet: GetAssistantAsync(AssistantName, CallSettings)
            // Additional: GetAssistantAsync(AssistantName, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssistantName name = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]");
            // Make the request
            Assistant response = await assistantServiceClient.GetAssistantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAssistants</summary>
        public void ListAssistantsRequestObject()
        {
            // Snippet: ListAssistants(ListAssistantsRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            ListAssistantsRequest request = new ListAssistantsRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            PagedEnumerable<ListAssistantsResponse, Assistant> response = assistantServiceClient.ListAssistants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assistant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssistantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assistant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assistant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assistant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantsAsync</summary>
        public async Task ListAssistantsRequestObjectAsync()
        {
            // Snippet: ListAssistantsAsync(ListAssistantsRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAssistantsRequest request = new ListAssistantsRequest
            {
                ParentAsEngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAssistantsResponse, Assistant> response = assistantServiceClient.ListAssistantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Assistant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAssistantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assistant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assistant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assistant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistants</summary>
        public void ListAssistants()
        {
            // Snippet: ListAssistants(string, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            PagedEnumerable<ListAssistantsResponse, Assistant> response = assistantServiceClient.ListAssistants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assistant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssistantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assistant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assistant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assistant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantsAsync</summary>
        public async Task ListAssistantsAsync()
        {
            // Snippet: ListAssistantsAsync(string, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            PagedAsyncEnumerable<ListAssistantsResponse, Assistant> response = assistantServiceClient.ListAssistantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Assistant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAssistantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assistant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assistant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assistant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistants</summary>
        public void ListAssistantsResourceNames()
        {
            // Snippet: ListAssistants(EngineName, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            PagedEnumerable<ListAssistantsResponse, Assistant> response = assistantServiceClient.ListAssistants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assistant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssistantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assistant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assistant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assistant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantsAsync</summary>
        public async Task ListAssistantsResourceNamesAsync()
        {
            // Snippet: ListAssistantsAsync(EngineName, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName parent = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            PagedAsyncEnumerable<ListAssistantsResponse, Assistant> response = assistantServiceClient.ListAssistantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Assistant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAssistantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assistant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assistant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assistant item in singlePage)
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
