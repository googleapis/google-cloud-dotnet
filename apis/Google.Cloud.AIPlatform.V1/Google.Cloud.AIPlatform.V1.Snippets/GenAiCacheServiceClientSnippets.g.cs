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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGenAiCacheServiceClientSnippets
    {
        /// <summary>Snippet for CreateCachedContent</summary>
        public void CreateCachedContentRequestObject()
        {
            // Snippet: CreateCachedContent(CreateCachedContentRequest, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            CreateCachedContentRequest request = new CreateCachedContentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CachedContent = new CachedContent(),
            };
            // Make the request
            CachedContent response = genAiCacheServiceClient.CreateCachedContent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCachedContentAsync</summary>
        public async Task CreateCachedContentRequestObjectAsync()
        {
            // Snippet: CreateCachedContentAsync(CreateCachedContentRequest, CallSettings)
            // Additional: CreateCachedContentAsync(CreateCachedContentRequest, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCachedContentRequest request = new CreateCachedContentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CachedContent = new CachedContent(),
            };
            // Make the request
            CachedContent response = await genAiCacheServiceClient.CreateCachedContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCachedContent</summary>
        public void CreateCachedContent()
        {
            // Snippet: CreateCachedContent(string, CachedContent, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CachedContent cachedContent = new CachedContent();
            // Make the request
            CachedContent response = genAiCacheServiceClient.CreateCachedContent(parent, cachedContent);
            // End snippet
        }

        /// <summary>Snippet for CreateCachedContentAsync</summary>
        public async Task CreateCachedContentAsync()
        {
            // Snippet: CreateCachedContentAsync(string, CachedContent, CallSettings)
            // Additional: CreateCachedContentAsync(string, CachedContent, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CachedContent cachedContent = new CachedContent();
            // Make the request
            CachedContent response = await genAiCacheServiceClient.CreateCachedContentAsync(parent, cachedContent);
            // End snippet
        }

        /// <summary>Snippet for CreateCachedContent</summary>
        public void CreateCachedContentResourceNames()
        {
            // Snippet: CreateCachedContent(LocationName, CachedContent, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CachedContent cachedContent = new CachedContent();
            // Make the request
            CachedContent response = genAiCacheServiceClient.CreateCachedContent(parent, cachedContent);
            // End snippet
        }

        /// <summary>Snippet for CreateCachedContentAsync</summary>
        public async Task CreateCachedContentResourceNamesAsync()
        {
            // Snippet: CreateCachedContentAsync(LocationName, CachedContent, CallSettings)
            // Additional: CreateCachedContentAsync(LocationName, CachedContent, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CachedContent cachedContent = new CachedContent();
            // Make the request
            CachedContent response = await genAiCacheServiceClient.CreateCachedContentAsync(parent, cachedContent);
            // End snippet
        }

        /// <summary>Snippet for GetCachedContent</summary>
        public void GetCachedContentRequestObject()
        {
            // Snippet: GetCachedContent(GetCachedContentRequest, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            GetCachedContentRequest request = new GetCachedContentRequest
            {
                CachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
            };
            // Make the request
            CachedContent response = genAiCacheServiceClient.GetCachedContent(request);
            // End snippet
        }

        /// <summary>Snippet for GetCachedContentAsync</summary>
        public async Task GetCachedContentRequestObjectAsync()
        {
            // Snippet: GetCachedContentAsync(GetCachedContentRequest, CallSettings)
            // Additional: GetCachedContentAsync(GetCachedContentRequest, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCachedContentRequest request = new GetCachedContentRequest
            {
                CachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
            };
            // Make the request
            CachedContent response = await genAiCacheServiceClient.GetCachedContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCachedContent</summary>
        public void GetCachedContent()
        {
            // Snippet: GetCachedContent(string, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cachedContents/[CACHED_CONTENT]";
            // Make the request
            CachedContent response = genAiCacheServiceClient.GetCachedContent(name);
            // End snippet
        }

        /// <summary>Snippet for GetCachedContentAsync</summary>
        public async Task GetCachedContentAsync()
        {
            // Snippet: GetCachedContentAsync(string, CallSettings)
            // Additional: GetCachedContentAsync(string, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cachedContents/[CACHED_CONTENT]";
            // Make the request
            CachedContent response = await genAiCacheServiceClient.GetCachedContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCachedContent</summary>
        public void GetCachedContentResourceNames()
        {
            // Snippet: GetCachedContent(CachedContentName, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            CachedContentName name = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]");
            // Make the request
            CachedContent response = genAiCacheServiceClient.GetCachedContent(name);
            // End snippet
        }

        /// <summary>Snippet for GetCachedContentAsync</summary>
        public async Task GetCachedContentResourceNamesAsync()
        {
            // Snippet: GetCachedContentAsync(CachedContentName, CallSettings)
            // Additional: GetCachedContentAsync(CachedContentName, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            CachedContentName name = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]");
            // Make the request
            CachedContent response = await genAiCacheServiceClient.GetCachedContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCachedContent</summary>
        public void UpdateCachedContentRequestObject()
        {
            // Snippet: UpdateCachedContent(UpdateCachedContentRequest, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            UpdateCachedContentRequest request = new UpdateCachedContentRequest
            {
                CachedContent = new CachedContent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CachedContent response = genAiCacheServiceClient.UpdateCachedContent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCachedContentAsync</summary>
        public async Task UpdateCachedContentRequestObjectAsync()
        {
            // Snippet: UpdateCachedContentAsync(UpdateCachedContentRequest, CallSettings)
            // Additional: UpdateCachedContentAsync(UpdateCachedContentRequest, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCachedContentRequest request = new UpdateCachedContentRequest
            {
                CachedContent = new CachedContent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CachedContent response = await genAiCacheServiceClient.UpdateCachedContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCachedContent</summary>
        public void UpdateCachedContent()
        {
            // Snippet: UpdateCachedContent(CachedContent, FieldMask, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            CachedContent cachedContent = new CachedContent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CachedContent response = genAiCacheServiceClient.UpdateCachedContent(cachedContent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCachedContentAsync</summary>
        public async Task UpdateCachedContentAsync()
        {
            // Snippet: UpdateCachedContentAsync(CachedContent, FieldMask, CallSettings)
            // Additional: UpdateCachedContentAsync(CachedContent, FieldMask, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            CachedContent cachedContent = new CachedContent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CachedContent response = await genAiCacheServiceClient.UpdateCachedContentAsync(cachedContent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCachedContent</summary>
        public void DeleteCachedContentRequestObject()
        {
            // Snippet: DeleteCachedContent(DeleteCachedContentRequest, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            DeleteCachedContentRequest request = new DeleteCachedContentRequest
            {
                CachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
            };
            // Make the request
            genAiCacheServiceClient.DeleteCachedContent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCachedContentAsync</summary>
        public async Task DeleteCachedContentRequestObjectAsync()
        {
            // Snippet: DeleteCachedContentAsync(DeleteCachedContentRequest, CallSettings)
            // Additional: DeleteCachedContentAsync(DeleteCachedContentRequest, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCachedContentRequest request = new DeleteCachedContentRequest
            {
                CachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
            };
            // Make the request
            await genAiCacheServiceClient.DeleteCachedContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCachedContent</summary>
        public void DeleteCachedContent()
        {
            // Snippet: DeleteCachedContent(string, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cachedContents/[CACHED_CONTENT]";
            // Make the request
            genAiCacheServiceClient.DeleteCachedContent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCachedContentAsync</summary>
        public async Task DeleteCachedContentAsync()
        {
            // Snippet: DeleteCachedContentAsync(string, CallSettings)
            // Additional: DeleteCachedContentAsync(string, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cachedContents/[CACHED_CONTENT]";
            // Make the request
            await genAiCacheServiceClient.DeleteCachedContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCachedContent</summary>
        public void DeleteCachedContentResourceNames()
        {
            // Snippet: DeleteCachedContent(CachedContentName, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            CachedContentName name = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]");
            // Make the request
            genAiCacheServiceClient.DeleteCachedContent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCachedContentAsync</summary>
        public async Task DeleteCachedContentResourceNamesAsync()
        {
            // Snippet: DeleteCachedContentAsync(CachedContentName, CallSettings)
            // Additional: DeleteCachedContentAsync(CachedContentName, CancellationToken)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            CachedContentName name = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]");
            // Make the request
            await genAiCacheServiceClient.DeleteCachedContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCachedContents</summary>
        public void ListCachedContentsRequestObject()
        {
            // Snippet: ListCachedContents(ListCachedContentsRequest, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            ListCachedContentsRequest request = new ListCachedContentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListCachedContentsResponse, CachedContent> response = genAiCacheServiceClient.ListCachedContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CachedContent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCachedContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CachedContent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CachedContent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CachedContent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCachedContentsAsync</summary>
        public async Task ListCachedContentsRequestObjectAsync()
        {
            // Snippet: ListCachedContentsAsync(ListCachedContentsRequest, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCachedContentsRequest request = new ListCachedContentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> response = genAiCacheServiceClient.ListCachedContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CachedContent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCachedContentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CachedContent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CachedContent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CachedContent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCachedContents</summary>
        public void ListCachedContents()
        {
            // Snippet: ListCachedContents(string, string, int?, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCachedContentsResponse, CachedContent> response = genAiCacheServiceClient.ListCachedContents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CachedContent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCachedContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CachedContent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CachedContent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CachedContent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCachedContentsAsync</summary>
        public async Task ListCachedContentsAsync()
        {
            // Snippet: ListCachedContentsAsync(string, string, int?, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> response = genAiCacheServiceClient.ListCachedContentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CachedContent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCachedContentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CachedContent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CachedContent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CachedContent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCachedContents</summary>
        public void ListCachedContentsResourceNames()
        {
            // Snippet: ListCachedContents(LocationName, string, int?, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = GenAiCacheServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCachedContentsResponse, CachedContent> response = genAiCacheServiceClient.ListCachedContents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CachedContent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCachedContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CachedContent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CachedContent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CachedContent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCachedContentsAsync</summary>
        public async Task ListCachedContentsResourceNamesAsync()
        {
            // Snippet: ListCachedContentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            GenAiCacheServiceClient genAiCacheServiceClient = await GenAiCacheServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> response = genAiCacheServiceClient.ListCachedContentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CachedContent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCachedContentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CachedContent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CachedContent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CachedContent item in singlePage)
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
