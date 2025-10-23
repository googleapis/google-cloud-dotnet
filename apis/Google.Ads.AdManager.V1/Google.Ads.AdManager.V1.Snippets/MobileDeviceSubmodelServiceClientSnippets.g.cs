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
    public sealed class AllGeneratedMobileDeviceSubmodelServiceClientSnippets
    {
        /// <summary>Snippet for GetMobileDeviceSubmodel</summary>
        public void GetMobileDeviceSubmodelRequestObject()
        {
            // Snippet: GetMobileDeviceSubmodel(GetMobileDeviceSubmodelRequest, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = MobileDeviceSubmodelServiceClient.Create();
            // Initialize request argument(s)
            GetMobileDeviceSubmodelRequest request = new GetMobileDeviceSubmodelRequest
            {
                MobileDeviceSubmodelName = MobileDeviceSubmodelName.FromNetworkCodeMobileDeviceSubmodel("[NETWORK_CODE]", "[MOBILE_DEVICE_SUBMODEL]"),
            };
            // Make the request
            MobileDeviceSubmodel response = mobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodel(request);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceSubmodelAsync</summary>
        public async Task GetMobileDeviceSubmodelRequestObjectAsync()
        {
            // Snippet: GetMobileDeviceSubmodelAsync(GetMobileDeviceSubmodelRequest, CallSettings)
            // Additional: GetMobileDeviceSubmodelAsync(GetMobileDeviceSubmodelRequest, CancellationToken)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = await MobileDeviceSubmodelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMobileDeviceSubmodelRequest request = new GetMobileDeviceSubmodelRequest
            {
                MobileDeviceSubmodelName = MobileDeviceSubmodelName.FromNetworkCodeMobileDeviceSubmodel("[NETWORK_CODE]", "[MOBILE_DEVICE_SUBMODEL]"),
            };
            // Make the request
            MobileDeviceSubmodel response = await mobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceSubmodel</summary>
        public void GetMobileDeviceSubmodel()
        {
            // Snippet: GetMobileDeviceSubmodel(string, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = MobileDeviceSubmodelServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/mobileDeviceSubmodels/[MOBILE_DEVICE_SUBMODEL]";
            // Make the request
            MobileDeviceSubmodel response = mobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodel(name);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceSubmodelAsync</summary>
        public async Task GetMobileDeviceSubmodelAsync()
        {
            // Snippet: GetMobileDeviceSubmodelAsync(string, CallSettings)
            // Additional: GetMobileDeviceSubmodelAsync(string, CancellationToken)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = await MobileDeviceSubmodelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/mobileDeviceSubmodels/[MOBILE_DEVICE_SUBMODEL]";
            // Make the request
            MobileDeviceSubmodel response = await mobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceSubmodel</summary>
        public void GetMobileDeviceSubmodelResourceNames()
        {
            // Snippet: GetMobileDeviceSubmodel(MobileDeviceSubmodelName, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = MobileDeviceSubmodelServiceClient.Create();
            // Initialize request argument(s)
            MobileDeviceSubmodelName name = MobileDeviceSubmodelName.FromNetworkCodeMobileDeviceSubmodel("[NETWORK_CODE]", "[MOBILE_DEVICE_SUBMODEL]");
            // Make the request
            MobileDeviceSubmodel response = mobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodel(name);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceSubmodelAsync</summary>
        public async Task GetMobileDeviceSubmodelResourceNamesAsync()
        {
            // Snippet: GetMobileDeviceSubmodelAsync(MobileDeviceSubmodelName, CallSettings)
            // Additional: GetMobileDeviceSubmodelAsync(MobileDeviceSubmodelName, CancellationToken)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = await MobileDeviceSubmodelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MobileDeviceSubmodelName name = MobileDeviceSubmodelName.FromNetworkCodeMobileDeviceSubmodel("[NETWORK_CODE]", "[MOBILE_DEVICE_SUBMODEL]");
            // Make the request
            MobileDeviceSubmodel response = await mobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMobileDeviceSubmodels</summary>
        public void ListMobileDeviceSubmodelsRequestObject()
        {
            // Snippet: ListMobileDeviceSubmodels(ListMobileDeviceSubmodelsRequest, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = MobileDeviceSubmodelServiceClient.Create();
            // Initialize request argument(s)
            ListMobileDeviceSubmodelsRequest request = new ListMobileDeviceSubmodelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> response = mobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MobileDeviceSubmodel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMobileDeviceSubmodelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MobileDeviceSubmodel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MobileDeviceSubmodel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MobileDeviceSubmodel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMobileDeviceSubmodelsAsync</summary>
        public async Task ListMobileDeviceSubmodelsRequestObjectAsync()
        {
            // Snippet: ListMobileDeviceSubmodelsAsync(ListMobileDeviceSubmodelsRequest, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = await MobileDeviceSubmodelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMobileDeviceSubmodelsRequest request = new ListMobileDeviceSubmodelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> response = mobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MobileDeviceSubmodel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMobileDeviceSubmodelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MobileDeviceSubmodel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MobileDeviceSubmodel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MobileDeviceSubmodel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMobileDeviceSubmodels</summary>
        public void ListMobileDeviceSubmodels()
        {
            // Snippet: ListMobileDeviceSubmodels(string, string, int?, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = MobileDeviceSubmodelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> response = mobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MobileDeviceSubmodel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMobileDeviceSubmodelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MobileDeviceSubmodel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MobileDeviceSubmodel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MobileDeviceSubmodel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMobileDeviceSubmodelsAsync</summary>
        public async Task ListMobileDeviceSubmodelsAsync()
        {
            // Snippet: ListMobileDeviceSubmodelsAsync(string, string, int?, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = await MobileDeviceSubmodelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> response = mobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MobileDeviceSubmodel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMobileDeviceSubmodelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MobileDeviceSubmodel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MobileDeviceSubmodel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MobileDeviceSubmodel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMobileDeviceSubmodels</summary>
        public void ListMobileDeviceSubmodelsResourceNames()
        {
            // Snippet: ListMobileDeviceSubmodels(NetworkName, string, int?, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = MobileDeviceSubmodelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> response = mobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MobileDeviceSubmodel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMobileDeviceSubmodelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MobileDeviceSubmodel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MobileDeviceSubmodel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MobileDeviceSubmodel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMobileDeviceSubmodelsAsync</summary>
        public async Task ListMobileDeviceSubmodelsResourceNamesAsync()
        {
            // Snippet: ListMobileDeviceSubmodelsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            MobileDeviceSubmodelServiceClient mobileDeviceSubmodelServiceClient = await MobileDeviceSubmodelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> response = mobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MobileDeviceSubmodel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMobileDeviceSubmodelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MobileDeviceSubmodel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MobileDeviceSubmodel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MobileDeviceSubmodel item in singlePage)
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
