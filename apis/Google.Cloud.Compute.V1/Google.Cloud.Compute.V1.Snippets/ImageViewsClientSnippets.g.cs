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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedImageViewsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetImageViewRequest, CallSettings)
            // Create client
            ImageViewsClient imageViewsClient = ImageViewsClient.Create();
            // Initialize request argument(s)
            GetImageViewRequest request = new GetImageViewRequest
            {
                Region = "",
                ResourceId = "",
                Project = "",
            };
            // Make the request
            ImageView response = imageViewsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetImageViewRequest, CallSettings)
            // Additional: GetAsync(GetImageViewRequest, CancellationToken)
            // Create client
            ImageViewsClient imageViewsClient = await ImageViewsClient.CreateAsync();
            // Initialize request argument(s)
            GetImageViewRequest request = new GetImageViewRequest
            {
                Region = "",
                ResourceId = "",
                Project = "",
            };
            // Make the request
            ImageView response = await imageViewsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ImageViewsClient imageViewsClient = ImageViewsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourceId = "";
            // Make the request
            ImageView response = imageViewsClient.Get(project, region, resourceId);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ImageViewsClient imageViewsClient = await ImageViewsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resourceId = "";
            // Make the request
            ImageView response = await imageViewsClient.GetAsync(project, region, resourceId);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListImageViewsRequest, CallSettings)
            // Create client
            ImageViewsClient imageViewsClient = ImageViewsClient.Create();
            // Initialize request argument(s)
            ListImageViewsRequest request = new ListImageViewsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ImageViewsListResponse, ImageView> response = imageViewsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImageView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ImageViewsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImageView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImageView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImageView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListImageViewsRequest, CallSettings)
            // Create client
            ImageViewsClient imageViewsClient = await ImageViewsClient.CreateAsync();
            // Initialize request argument(s)
            ListImageViewsRequest request = new ListImageViewsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ImageViewsListResponse, ImageView> response = imageViewsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ImageView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ImageViewsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImageView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImageView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImageView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            ImageViewsClient imageViewsClient = ImageViewsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<ImageViewsListResponse, ImageView> response = imageViewsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImageView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ImageViewsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImageView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImageView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImageView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            ImageViewsClient imageViewsClient = await ImageViewsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ImageViewsListResponse, ImageView> response = imageViewsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ImageView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ImageViewsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImageView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImageView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImageView item in singlePage)
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
