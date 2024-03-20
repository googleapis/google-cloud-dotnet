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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedKnowledgeBasesClientSnippets
    {
        /// <summary>Snippet for ListKnowledgeBases</summary>
        public void ListKnowledgeBasesRequestObject()
        {
            // Snippet: ListKnowledgeBases(ListKnowledgeBasesRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KnowledgeBase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKnowledgeBasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBasesAsync</summary>
        public async Task ListKnowledgeBasesRequestObjectAsync()
        {
            // Snippet: ListKnowledgeBasesAsync(ListKnowledgeBasesRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KnowledgeBase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKnowledgeBasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBases</summary>
        public void ListKnowledgeBases()
        {
            // Snippet: ListKnowledgeBases(string, string, int?, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KnowledgeBase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKnowledgeBasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBasesAsync</summary>
        public async Task ListKnowledgeBasesAsync()
        {
            // Snippet: ListKnowledgeBasesAsync(string, string, int?, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KnowledgeBase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKnowledgeBasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBases</summary>
        public void ListKnowledgeBasesResourceNames1()
        {
            // Snippet: ListKnowledgeBases(ProjectName, string, int?, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KnowledgeBase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKnowledgeBasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBasesAsync</summary>
        public async Task ListKnowledgeBasesResourceNames1Async()
        {
            // Snippet: ListKnowledgeBasesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KnowledgeBase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKnowledgeBasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBases</summary>
        public void ListKnowledgeBasesResourceNames2()
        {
            // Snippet: ListKnowledgeBases(LocationName, string, int?, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KnowledgeBase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKnowledgeBasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKnowledgeBasesAsync</summary>
        public async Task ListKnowledgeBasesResourceNames2Async()
        {
            // Snippet: ListKnowledgeBasesAsync(LocationName, string, int?, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> response = knowledgeBasesClient.ListKnowledgeBasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KnowledgeBase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKnowledgeBasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KnowledgeBase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KnowledgeBase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KnowledgeBase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetKnowledgeBase</summary>
        public void GetKnowledgeBaseRequestObject()
        {
            // Snippet: GetKnowledgeBase(GetKnowledgeBaseRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.GetKnowledgeBase(request);
            // End snippet
        }

        /// <summary>Snippet for GetKnowledgeBaseAsync</summary>
        public async Task GetKnowledgeBaseRequestObjectAsync()
        {
            // Snippet: GetKnowledgeBaseAsync(GetKnowledgeBaseRequest, CallSettings)
            // Additional: GetKnowledgeBaseAsync(GetKnowledgeBaseRequest, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.GetKnowledgeBaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKnowledgeBase</summary>
        public void GetKnowledgeBase()
        {
            // Snippet: GetKnowledgeBase(string, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.GetKnowledgeBase(name);
            // End snippet
        }

        /// <summary>Snippet for GetKnowledgeBaseAsync</summary>
        public async Task GetKnowledgeBaseAsync()
        {
            // Snippet: GetKnowledgeBaseAsync(string, CallSettings)
            // Additional: GetKnowledgeBaseAsync(string, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.GetKnowledgeBaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKnowledgeBase</summary>
        public void GetKnowledgeBaseResourceNames()
        {
            // Snippet: GetKnowledgeBase(KnowledgeBaseName, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            KnowledgeBaseName name = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.GetKnowledgeBase(name);
            // End snippet
        }

        /// <summary>Snippet for GetKnowledgeBaseAsync</summary>
        public async Task GetKnowledgeBaseResourceNamesAsync()
        {
            // Snippet: GetKnowledgeBaseAsync(KnowledgeBaseName, CallSettings)
            // Additional: GetKnowledgeBaseAsync(KnowledgeBaseName, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            KnowledgeBaseName name = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.GetKnowledgeBaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBase</summary>
        public void CreateKnowledgeBaseRequestObject()
        {
            // Snippet: CreateKnowledgeBase(CreateKnowledgeBaseRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.CreateKnowledgeBase(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBaseAsync</summary>
        public async Task CreateKnowledgeBaseRequestObjectAsync()
        {
            // Snippet: CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest, CallSettings)
            // Additional: CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.CreateKnowledgeBaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBase</summary>
        public void CreateKnowledgeBase()
        {
            // Snippet: CreateKnowledgeBase(string, KnowledgeBase, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.CreateKnowledgeBase(parent, knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBaseAsync</summary>
        public async Task CreateKnowledgeBaseAsync()
        {
            // Snippet: CreateKnowledgeBaseAsync(string, KnowledgeBase, CallSettings)
            // Additional: CreateKnowledgeBaseAsync(string, KnowledgeBase, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.CreateKnowledgeBaseAsync(parent, knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBase</summary>
        public void CreateKnowledgeBaseResourceNames1()
        {
            // Snippet: CreateKnowledgeBase(ProjectName, KnowledgeBase, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.CreateKnowledgeBase(parent, knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBaseAsync</summary>
        public async Task CreateKnowledgeBaseResourceNames1Async()
        {
            // Snippet: CreateKnowledgeBaseAsync(ProjectName, KnowledgeBase, CallSettings)
            // Additional: CreateKnowledgeBaseAsync(ProjectName, KnowledgeBase, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.CreateKnowledgeBaseAsync(parent, knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBase</summary>
        public void CreateKnowledgeBaseResourceNames2()
        {
            // Snippet: CreateKnowledgeBase(LocationName, KnowledgeBase, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.CreateKnowledgeBase(parent, knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for CreateKnowledgeBaseAsync</summary>
        public async Task CreateKnowledgeBaseResourceNames2Async()
        {
            // Snippet: CreateKnowledgeBaseAsync(LocationName, KnowledgeBase, CallSettings)
            // Additional: CreateKnowledgeBaseAsync(LocationName, KnowledgeBase, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.CreateKnowledgeBaseAsync(parent, knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for DeleteKnowledgeBase</summary>
        public void DeleteKnowledgeBaseRequestObject()
        {
            // Snippet: DeleteKnowledgeBase(DeleteKnowledgeBaseRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Force = false,
            };
            // Make the request
            knowledgeBasesClient.DeleteKnowledgeBase(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKnowledgeBaseAsync</summary>
        public async Task DeleteKnowledgeBaseRequestObjectAsync()
        {
            // Snippet: DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest, CallSettings)
            // Additional: DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Force = false,
            };
            // Make the request
            await knowledgeBasesClient.DeleteKnowledgeBaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKnowledgeBase</summary>
        public void DeleteKnowledgeBase()
        {
            // Snippet: DeleteKnowledgeBase(string, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            // Make the request
            knowledgeBasesClient.DeleteKnowledgeBase(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKnowledgeBaseAsync</summary>
        public async Task DeleteKnowledgeBaseAsync()
        {
            // Snippet: DeleteKnowledgeBaseAsync(string, CallSettings)
            // Additional: DeleteKnowledgeBaseAsync(string, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            // Make the request
            await knowledgeBasesClient.DeleteKnowledgeBaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKnowledgeBase</summary>
        public void DeleteKnowledgeBaseResourceNames()
        {
            // Snippet: DeleteKnowledgeBase(KnowledgeBaseName, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            KnowledgeBaseName name = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            // Make the request
            knowledgeBasesClient.DeleteKnowledgeBase(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKnowledgeBaseAsync</summary>
        public async Task DeleteKnowledgeBaseResourceNamesAsync()
        {
            // Snippet: DeleteKnowledgeBaseAsync(KnowledgeBaseName, CallSettings)
            // Additional: DeleteKnowledgeBaseAsync(KnowledgeBaseName, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            KnowledgeBaseName name = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            // Make the request
            await knowledgeBasesClient.DeleteKnowledgeBaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateKnowledgeBase</summary>
        public void UpdateKnowledgeBaseRequestObject()
        {
            // Snippet: UpdateKnowledgeBase(UpdateKnowledgeBaseRequest, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.UpdateKnowledgeBase(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKnowledgeBaseAsync</summary>
        public async Task UpdateKnowledgeBaseRequestObjectAsync()
        {
            // Snippet: UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest, CallSettings)
            // Additional: UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.UpdateKnowledgeBaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKnowledgeBase</summary>
        public void UpdateKnowledgeBase1()
        {
            // Snippet: UpdateKnowledgeBase(KnowledgeBase, FieldMask, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            FieldMask updateMask = new FieldMask();
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.UpdateKnowledgeBase(knowledgeBase, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateKnowledgeBaseAsync</summary>
        public async Task UpdateKnowledgeBase1Async()
        {
            // Snippet: UpdateKnowledgeBaseAsync(KnowledgeBase, FieldMask, CallSettings)
            // Additional: UpdateKnowledgeBaseAsync(KnowledgeBase, FieldMask, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            FieldMask updateMask = new FieldMask();
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.UpdateKnowledgeBaseAsync(knowledgeBase, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateKnowledgeBase</summary>
        public void UpdateKnowledgeBase2()
        {
            // Snippet: UpdateKnowledgeBase(KnowledgeBase, CallSettings)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = KnowledgeBasesClient.Create();
            // Initialize request argument(s)
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = knowledgeBasesClient.UpdateKnowledgeBase(knowledgeBase);
            // End snippet
        }

        /// <summary>Snippet for UpdateKnowledgeBaseAsync</summary>
        public async Task UpdateKnowledgeBase2Async()
        {
            // Snippet: UpdateKnowledgeBaseAsync(KnowledgeBase, CallSettings)
            // Additional: UpdateKnowledgeBaseAsync(KnowledgeBase, CancellationToken)
            // Create client
            KnowledgeBasesClient knowledgeBasesClient = await KnowledgeBasesClient.CreateAsync();
            // Initialize request argument(s)
            KnowledgeBase knowledgeBase = new KnowledgeBase();
            // Make the request
            KnowledgeBase response = await knowledgeBasesClient.UpdateKnowledgeBaseAsync(knowledgeBase);
            // End snippet
        }
    }
}
