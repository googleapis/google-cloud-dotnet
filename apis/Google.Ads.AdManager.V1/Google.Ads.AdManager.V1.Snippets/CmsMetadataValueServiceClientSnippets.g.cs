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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCmsMetadataValueServiceClientSnippets
    {
        /// <summary>Snippet for GetCmsMetadataValue</summary>
        public void GetCmsMetadataValueRequestObject()
        {
            // Snippet: GetCmsMetadataValue(GetCmsMetadataValueRequest, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = CmsMetadataValueServiceClient.Create();
            // Initialize request argument(s)
            GetCmsMetadataValueRequest request = new GetCmsMetadataValueRequest
            {
                CmsMetadataValueName = CmsMetadataValueName.FromNetworkCodeCmsMetadataValue("[NETWORK_CODE]", "[CMS_METADATA_VALUE]"),
            };
            // Make the request
            CmsMetadataValue response = cmsMetadataValueServiceClient.GetCmsMetadataValue(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataValueAsync</summary>
        public async Task GetCmsMetadataValueRequestObjectAsync()
        {
            // Snippet: GetCmsMetadataValueAsync(GetCmsMetadataValueRequest, CallSettings)
            // Additional: GetCmsMetadataValueAsync(GetCmsMetadataValueRequest, CancellationToken)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = await CmsMetadataValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCmsMetadataValueRequest request = new GetCmsMetadataValueRequest
            {
                CmsMetadataValueName = CmsMetadataValueName.FromNetworkCodeCmsMetadataValue("[NETWORK_CODE]", "[CMS_METADATA_VALUE]"),
            };
            // Make the request
            CmsMetadataValue response = await cmsMetadataValueServiceClient.GetCmsMetadataValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataValue</summary>
        public void GetCmsMetadataValue()
        {
            // Snippet: GetCmsMetadataValue(string, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = CmsMetadataValueServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/cmsMetadataValues/[CMS_METADATA_VALUE]";
            // Make the request
            CmsMetadataValue response = cmsMetadataValueServiceClient.GetCmsMetadataValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataValueAsync</summary>
        public async Task GetCmsMetadataValueAsync()
        {
            // Snippet: GetCmsMetadataValueAsync(string, CallSettings)
            // Additional: GetCmsMetadataValueAsync(string, CancellationToken)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = await CmsMetadataValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/cmsMetadataValues/[CMS_METADATA_VALUE]";
            // Make the request
            CmsMetadataValue response = await cmsMetadataValueServiceClient.GetCmsMetadataValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataValue</summary>
        public void GetCmsMetadataValueResourceNames()
        {
            // Snippet: GetCmsMetadataValue(CmsMetadataValueName, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = CmsMetadataValueServiceClient.Create();
            // Initialize request argument(s)
            CmsMetadataValueName name = CmsMetadataValueName.FromNetworkCodeCmsMetadataValue("[NETWORK_CODE]", "[CMS_METADATA_VALUE]");
            // Make the request
            CmsMetadataValue response = cmsMetadataValueServiceClient.GetCmsMetadataValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataValueAsync</summary>
        public async Task GetCmsMetadataValueResourceNamesAsync()
        {
            // Snippet: GetCmsMetadataValueAsync(CmsMetadataValueName, CallSettings)
            // Additional: GetCmsMetadataValueAsync(CmsMetadataValueName, CancellationToken)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = await CmsMetadataValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmsMetadataValueName name = CmsMetadataValueName.FromNetworkCodeCmsMetadataValue("[NETWORK_CODE]", "[CMS_METADATA_VALUE]");
            // Make the request
            CmsMetadataValue response = await cmsMetadataValueServiceClient.GetCmsMetadataValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataValues</summary>
        public void ListCmsMetadataValuesRequestObject()
        {
            // Snippet: ListCmsMetadataValues(ListCmsMetadataValuesRequest, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = CmsMetadataValueServiceClient.Create();
            // Initialize request argument(s)
            ListCmsMetadataValuesRequest request = new ListCmsMetadataValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> response = cmsMetadataValueServiceClient.ListCmsMetadataValues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CmsMetadataValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCmsMetadataValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataValuesAsync</summary>
        public async Task ListCmsMetadataValuesRequestObjectAsync()
        {
            // Snippet: ListCmsMetadataValuesAsync(ListCmsMetadataValuesRequest, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = await CmsMetadataValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCmsMetadataValuesRequest request = new ListCmsMetadataValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> response = cmsMetadataValueServiceClient.ListCmsMetadataValuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CmsMetadataValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCmsMetadataValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataValues</summary>
        public void ListCmsMetadataValues()
        {
            // Snippet: ListCmsMetadataValues(string, string, int?, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = CmsMetadataValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> response = cmsMetadataValueServiceClient.ListCmsMetadataValues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CmsMetadataValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCmsMetadataValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataValuesAsync</summary>
        public async Task ListCmsMetadataValuesAsync()
        {
            // Snippet: ListCmsMetadataValuesAsync(string, string, int?, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = await CmsMetadataValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> response = cmsMetadataValueServiceClient.ListCmsMetadataValuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CmsMetadataValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCmsMetadataValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataValues</summary>
        public void ListCmsMetadataValuesResourceNames()
        {
            // Snippet: ListCmsMetadataValues(NetworkName, string, int?, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = CmsMetadataValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> response = cmsMetadataValueServiceClient.ListCmsMetadataValues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CmsMetadataValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCmsMetadataValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataValuesAsync</summary>
        public async Task ListCmsMetadataValuesResourceNamesAsync()
        {
            // Snippet: ListCmsMetadataValuesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CmsMetadataValueServiceClient cmsMetadataValueServiceClient = await CmsMetadataValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> response = cmsMetadataValueServiceClient.ListCmsMetadataValuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CmsMetadataValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCmsMetadataValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataValue item in singlePage)
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
