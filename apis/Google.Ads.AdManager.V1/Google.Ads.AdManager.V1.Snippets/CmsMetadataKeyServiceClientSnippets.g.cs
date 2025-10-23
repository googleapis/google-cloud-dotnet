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
    public sealed class AllGeneratedCmsMetadataKeyServiceClientSnippets
    {
        /// <summary>Snippet for GetCmsMetadataKey</summary>
        public void GetCmsMetadataKeyRequestObject()
        {
            // Snippet: GetCmsMetadataKey(GetCmsMetadataKeyRequest, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = CmsMetadataKeyServiceClient.Create();
            // Initialize request argument(s)
            GetCmsMetadataKeyRequest request = new GetCmsMetadataKeyRequest
            {
                CmsMetadataKeyName = CmsMetadataKeyName.FromNetworkCodeCmsMetadataKey("[NETWORK_CODE]", "[CMS_METADATA_KEY]"),
            };
            // Make the request
            CmsMetadataKey response = cmsMetadataKeyServiceClient.GetCmsMetadataKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataKeyAsync</summary>
        public async Task GetCmsMetadataKeyRequestObjectAsync()
        {
            // Snippet: GetCmsMetadataKeyAsync(GetCmsMetadataKeyRequest, CallSettings)
            // Additional: GetCmsMetadataKeyAsync(GetCmsMetadataKeyRequest, CancellationToken)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = await CmsMetadataKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCmsMetadataKeyRequest request = new GetCmsMetadataKeyRequest
            {
                CmsMetadataKeyName = CmsMetadataKeyName.FromNetworkCodeCmsMetadataKey("[NETWORK_CODE]", "[CMS_METADATA_KEY]"),
            };
            // Make the request
            CmsMetadataKey response = await cmsMetadataKeyServiceClient.GetCmsMetadataKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataKey</summary>
        public void GetCmsMetadataKey()
        {
            // Snippet: GetCmsMetadataKey(string, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = CmsMetadataKeyServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/cmsMetadataKeys/[CMS_METADATA_KEY]";
            // Make the request
            CmsMetadataKey response = cmsMetadataKeyServiceClient.GetCmsMetadataKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataKeyAsync</summary>
        public async Task GetCmsMetadataKeyAsync()
        {
            // Snippet: GetCmsMetadataKeyAsync(string, CallSettings)
            // Additional: GetCmsMetadataKeyAsync(string, CancellationToken)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = await CmsMetadataKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/cmsMetadataKeys/[CMS_METADATA_KEY]";
            // Make the request
            CmsMetadataKey response = await cmsMetadataKeyServiceClient.GetCmsMetadataKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataKey</summary>
        public void GetCmsMetadataKeyResourceNames()
        {
            // Snippet: GetCmsMetadataKey(CmsMetadataKeyName, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = CmsMetadataKeyServiceClient.Create();
            // Initialize request argument(s)
            CmsMetadataKeyName name = CmsMetadataKeyName.FromNetworkCodeCmsMetadataKey("[NETWORK_CODE]", "[CMS_METADATA_KEY]");
            // Make the request
            CmsMetadataKey response = cmsMetadataKeyServiceClient.GetCmsMetadataKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmsMetadataKeyAsync</summary>
        public async Task GetCmsMetadataKeyResourceNamesAsync()
        {
            // Snippet: GetCmsMetadataKeyAsync(CmsMetadataKeyName, CallSettings)
            // Additional: GetCmsMetadataKeyAsync(CmsMetadataKeyName, CancellationToken)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = await CmsMetadataKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmsMetadataKeyName name = CmsMetadataKeyName.FromNetworkCodeCmsMetadataKey("[NETWORK_CODE]", "[CMS_METADATA_KEY]");
            // Make the request
            CmsMetadataKey response = await cmsMetadataKeyServiceClient.GetCmsMetadataKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataKeys</summary>
        public void ListCmsMetadataKeysRequestObject()
        {
            // Snippet: ListCmsMetadataKeys(ListCmsMetadataKeysRequest, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = CmsMetadataKeyServiceClient.Create();
            // Initialize request argument(s)
            ListCmsMetadataKeysRequest request = new ListCmsMetadataKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> response = cmsMetadataKeyServiceClient.ListCmsMetadataKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CmsMetadataKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCmsMetadataKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataKeysAsync</summary>
        public async Task ListCmsMetadataKeysRequestObjectAsync()
        {
            // Snippet: ListCmsMetadataKeysAsync(ListCmsMetadataKeysRequest, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = await CmsMetadataKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCmsMetadataKeysRequest request = new ListCmsMetadataKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> response = cmsMetadataKeyServiceClient.ListCmsMetadataKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CmsMetadataKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCmsMetadataKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataKeys</summary>
        public void ListCmsMetadataKeys()
        {
            // Snippet: ListCmsMetadataKeys(string, string, int?, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = CmsMetadataKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> response = cmsMetadataKeyServiceClient.ListCmsMetadataKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CmsMetadataKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCmsMetadataKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataKeysAsync</summary>
        public async Task ListCmsMetadataKeysAsync()
        {
            // Snippet: ListCmsMetadataKeysAsync(string, string, int?, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = await CmsMetadataKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> response = cmsMetadataKeyServiceClient.ListCmsMetadataKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CmsMetadataKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCmsMetadataKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataKeys</summary>
        public void ListCmsMetadataKeysResourceNames()
        {
            // Snippet: ListCmsMetadataKeys(NetworkName, string, int?, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = CmsMetadataKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> response = cmsMetadataKeyServiceClient.ListCmsMetadataKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CmsMetadataKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCmsMetadataKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCmsMetadataKeysAsync</summary>
        public async Task ListCmsMetadataKeysResourceNamesAsync()
        {
            // Snippet: ListCmsMetadataKeysAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CmsMetadataKeyServiceClient cmsMetadataKeyServiceClient = await CmsMetadataKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> response = cmsMetadataKeyServiceClient.ListCmsMetadataKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CmsMetadataKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCmsMetadataKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CmsMetadataKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CmsMetadataKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CmsMetadataKey item in singlePage)
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
