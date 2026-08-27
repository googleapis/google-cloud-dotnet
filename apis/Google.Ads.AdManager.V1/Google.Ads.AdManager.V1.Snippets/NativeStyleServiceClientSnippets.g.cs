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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNativeStyleServiceClientSnippets
    {
        /// <summary>Snippet for GetNativeStyle</summary>
        public void GetNativeStyleRequestObject()
        {
            // Snippet: GetNativeStyle(GetNativeStyleRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            GetNativeStyleRequest request = new GetNativeStyleRequest
            {
                NativeStyleName = NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            NativeStyle response = nativeStyleServiceClient.GetNativeStyle(request);
            // End snippet
        }

        /// <summary>Snippet for GetNativeStyleAsync</summary>
        public async Task GetNativeStyleRequestObjectAsync()
        {
            // Snippet: GetNativeStyleAsync(GetNativeStyleRequest, CallSettings)
            // Additional: GetNativeStyleAsync(GetNativeStyleRequest, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNativeStyleRequest request = new GetNativeStyleRequest
            {
                NativeStyleName = NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            NativeStyle response = await nativeStyleServiceClient.GetNativeStyleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNativeStyle</summary>
        public void GetNativeStyle()
        {
            // Snippet: GetNativeStyle(string, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]";
            // Make the request
            NativeStyle response = nativeStyleServiceClient.GetNativeStyle(name);
            // End snippet
        }

        /// <summary>Snippet for GetNativeStyleAsync</summary>
        public async Task GetNativeStyleAsync()
        {
            // Snippet: GetNativeStyleAsync(string, CallSettings)
            // Additional: GetNativeStyleAsync(string, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]";
            // Make the request
            NativeStyle response = await nativeStyleServiceClient.GetNativeStyleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNativeStyle</summary>
        public void GetNativeStyleResourceNames()
        {
            // Snippet: GetNativeStyle(NativeStyleName, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NativeStyleName name = NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]");
            // Make the request
            NativeStyle response = nativeStyleServiceClient.GetNativeStyle(name);
            // End snippet
        }

        /// <summary>Snippet for GetNativeStyleAsync</summary>
        public async Task GetNativeStyleResourceNamesAsync()
        {
            // Snippet: GetNativeStyleAsync(NativeStyleName, CallSettings)
            // Additional: GetNativeStyleAsync(NativeStyleName, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeStyleName name = NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]");
            // Make the request
            NativeStyle response = await nativeStyleServiceClient.GetNativeStyleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNativeStyles</summary>
        public void ListNativeStylesRequestObject()
        {
            // Snippet: ListNativeStyles(ListNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            ListNativeStylesRequest request = new ListNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListNativeStylesResponse, NativeStyle> response = nativeStyleServiceClient.ListNativeStyles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NativeStyle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNativeStylesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeStyle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeStyle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeStyle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeStylesAsync</summary>
        public async Task ListNativeStylesRequestObjectAsync()
        {
            // Snippet: ListNativeStylesAsync(ListNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNativeStylesRequest request = new ListNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> response = nativeStyleServiceClient.ListNativeStylesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (NativeStyle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNativeStylesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeStyle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeStyle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeStyle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeStyles</summary>
        public void ListNativeStyles()
        {
            // Snippet: ListNativeStyles(string, string, int?, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListNativeStylesResponse, NativeStyle> response = nativeStyleServiceClient.ListNativeStyles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NativeStyle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNativeStylesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeStyle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeStyle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeStyle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeStylesAsync</summary>
        public async Task ListNativeStylesAsync()
        {
            // Snippet: ListNativeStylesAsync(string, string, int?, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> response = nativeStyleServiceClient.ListNativeStylesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (NativeStyle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNativeStylesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeStyle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeStyle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeStyle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeStyles</summary>
        public void ListNativeStylesResourceNames()
        {
            // Snippet: ListNativeStyles(NetworkName, string, int?, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListNativeStylesResponse, NativeStyle> response = nativeStyleServiceClient.ListNativeStyles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NativeStyle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNativeStylesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeStyle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeStyle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeStyle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeStylesAsync</summary>
        public async Task ListNativeStylesResourceNamesAsync()
        {
            // Snippet: ListNativeStylesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> response = nativeStyleServiceClient.ListNativeStylesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (NativeStyle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNativeStylesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeStyle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeStyle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeStyle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNativeStyles</summary>
        public void BatchCreateNativeStylesRequestObject()
        {
            // Snippet: BatchCreateNativeStyles(BatchCreateNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateNativeStylesRequest request = new BatchCreateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateNativeStyleRequest(),
                },
            };
            // Make the request
            BatchCreateNativeStylesResponse response = nativeStyleServiceClient.BatchCreateNativeStyles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNativeStylesAsync</summary>
        public async Task BatchCreateNativeStylesRequestObjectAsync()
        {
            // Snippet: BatchCreateNativeStylesAsync(BatchCreateNativeStylesRequest, CallSettings)
            // Additional: BatchCreateNativeStylesAsync(BatchCreateNativeStylesRequest, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateNativeStylesRequest request = new BatchCreateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateNativeStyleRequest(),
                },
            };
            // Make the request
            BatchCreateNativeStylesResponse response = await nativeStyleServiceClient.BatchCreateNativeStylesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNativeStyles</summary>
        public void BatchCreateNativeStyles()
        {
            // Snippet: BatchCreateNativeStyles(string, IEnumerable<CreateNativeStyleRequest>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateNativeStyleRequest> requests = new CreateNativeStyleRequest[]
            {
                new CreateNativeStyleRequest(),
            };
            // Make the request
            BatchCreateNativeStylesResponse response = nativeStyleServiceClient.BatchCreateNativeStyles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNativeStylesAsync</summary>
        public async Task BatchCreateNativeStylesAsync()
        {
            // Snippet: BatchCreateNativeStylesAsync(string, IEnumerable<CreateNativeStyleRequest>, CallSettings)
            // Additional: BatchCreateNativeStylesAsync(string, IEnumerable<CreateNativeStyleRequest>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateNativeStyleRequest> requests = new CreateNativeStyleRequest[]
            {
                new CreateNativeStyleRequest(),
            };
            // Make the request
            BatchCreateNativeStylesResponse response = await nativeStyleServiceClient.BatchCreateNativeStylesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNativeStyles</summary>
        public void BatchCreateNativeStylesResourceNames()
        {
            // Snippet: BatchCreateNativeStyles(NetworkName, IEnumerable<CreateNativeStyleRequest>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateNativeStyleRequest> requests = new CreateNativeStyleRequest[]
            {
                new CreateNativeStyleRequest(),
            };
            // Make the request
            BatchCreateNativeStylesResponse response = nativeStyleServiceClient.BatchCreateNativeStyles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNativeStylesAsync</summary>
        public async Task BatchCreateNativeStylesResourceNamesAsync()
        {
            // Snippet: BatchCreateNativeStylesAsync(NetworkName, IEnumerable<CreateNativeStyleRequest>, CallSettings)
            // Additional: BatchCreateNativeStylesAsync(NetworkName, IEnumerable<CreateNativeStyleRequest>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateNativeStyleRequest> requests = new CreateNativeStyleRequest[]
            {
                new CreateNativeStyleRequest(),
            };
            // Make the request
            BatchCreateNativeStylesResponse response = await nativeStyleServiceClient.BatchCreateNativeStylesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateNativeStyles</summary>
        public void BatchUpdateNativeStylesRequestObject()
        {
            // Snippet: BatchUpdateNativeStyles(BatchUpdateNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateNativeStylesRequest request = new BatchUpdateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateNativeStyleRequest(),
                },
            };
            // Make the request
            BatchUpdateNativeStylesResponse response = nativeStyleServiceClient.BatchUpdateNativeStyles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateNativeStylesAsync</summary>
        public async Task BatchUpdateNativeStylesRequestObjectAsync()
        {
            // Snippet: BatchUpdateNativeStylesAsync(BatchUpdateNativeStylesRequest, CallSettings)
            // Additional: BatchUpdateNativeStylesAsync(BatchUpdateNativeStylesRequest, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateNativeStylesRequest request = new BatchUpdateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateNativeStyleRequest(),
                },
            };
            // Make the request
            BatchUpdateNativeStylesResponse response = await nativeStyleServiceClient.BatchUpdateNativeStylesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateNativeStyles</summary>
        public void BatchUpdateNativeStyles()
        {
            // Snippet: BatchUpdateNativeStyles(string, IEnumerable<UpdateNativeStyleRequest>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateNativeStyleRequest> requests = new UpdateNativeStyleRequest[]
            {
                new UpdateNativeStyleRequest(),
            };
            // Make the request
            BatchUpdateNativeStylesResponse response = nativeStyleServiceClient.BatchUpdateNativeStyles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateNativeStylesAsync</summary>
        public async Task BatchUpdateNativeStylesAsync()
        {
            // Snippet: BatchUpdateNativeStylesAsync(string, IEnumerable<UpdateNativeStyleRequest>, CallSettings)
            // Additional: BatchUpdateNativeStylesAsync(string, IEnumerable<UpdateNativeStyleRequest>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateNativeStyleRequest> requests = new UpdateNativeStyleRequest[]
            {
                new UpdateNativeStyleRequest(),
            };
            // Make the request
            BatchUpdateNativeStylesResponse response = await nativeStyleServiceClient.BatchUpdateNativeStylesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateNativeStyles</summary>
        public void BatchUpdateNativeStylesResourceNames()
        {
            // Snippet: BatchUpdateNativeStyles(NetworkName, IEnumerable<UpdateNativeStyleRequest>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateNativeStyleRequest> requests = new UpdateNativeStyleRequest[]
            {
                new UpdateNativeStyleRequest(),
            };
            // Make the request
            BatchUpdateNativeStylesResponse response = nativeStyleServiceClient.BatchUpdateNativeStyles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateNativeStylesAsync</summary>
        public async Task BatchUpdateNativeStylesResourceNamesAsync()
        {
            // Snippet: BatchUpdateNativeStylesAsync(NetworkName, IEnumerable<UpdateNativeStyleRequest>, CallSettings)
            // Additional: BatchUpdateNativeStylesAsync(NetworkName, IEnumerable<UpdateNativeStyleRequest>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateNativeStyleRequest> requests = new UpdateNativeStyleRequest[]
            {
                new UpdateNativeStyleRequest(),
            };
            // Make the request
            BatchUpdateNativeStylesResponse response = await nativeStyleServiceClient.BatchUpdateNativeStylesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateNativeStyles</summary>
        public void BatchActivateNativeStylesRequestObject()
        {
            // Snippet: BatchActivateNativeStyles(BatchActivateNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateNativeStylesRequest request = new BatchActivateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                NativeStyleNames =
                {
                    NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
                },
            };
            // Make the request
            BatchActivateNativeStylesResponse response = nativeStyleServiceClient.BatchActivateNativeStyles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateNativeStylesAsync</summary>
        public async Task BatchActivateNativeStylesRequestObjectAsync()
        {
            // Snippet: BatchActivateNativeStylesAsync(BatchActivateNativeStylesRequest, CallSettings)
            // Additional: BatchActivateNativeStylesAsync(BatchActivateNativeStylesRequest, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateNativeStylesRequest request = new BatchActivateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                NativeStyleNames =
                {
                    NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
                },
            };
            // Make the request
            BatchActivateNativeStylesResponse response = await nativeStyleServiceClient.BatchActivateNativeStylesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateNativeStyles</summary>
        public void BatchActivateNativeStyles()
        {
            // Snippet: BatchActivateNativeStyles(string, IEnumerable<string>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]",
            };
            // Make the request
            BatchActivateNativeStylesResponse response = nativeStyleServiceClient.BatchActivateNativeStyles(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateNativeStylesAsync</summary>
        public async Task BatchActivateNativeStylesAsync()
        {
            // Snippet: BatchActivateNativeStylesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateNativeStylesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]",
            };
            // Make the request
            BatchActivateNativeStylesResponse response = await nativeStyleServiceClient.BatchActivateNativeStylesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateNativeStyles</summary>
        public void BatchActivateNativeStylesResourceNames()
        {
            // Snippet: BatchActivateNativeStyles(NetworkName, IEnumerable<NativeStyleName>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<NativeStyleName> names = new NativeStyleName[]
            {
                NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            BatchActivateNativeStylesResponse response = nativeStyleServiceClient.BatchActivateNativeStyles(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateNativeStylesAsync</summary>
        public async Task BatchActivateNativeStylesResourceNamesAsync()
        {
            // Snippet: BatchActivateNativeStylesAsync(NetworkName, IEnumerable<NativeStyleName>, CallSettings)
            // Additional: BatchActivateNativeStylesAsync(NetworkName, IEnumerable<NativeStyleName>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<NativeStyleName> names = new NativeStyleName[]
            {
                NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            BatchActivateNativeStylesResponse response = await nativeStyleServiceClient.BatchActivateNativeStylesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateNativeStyles</summary>
        public void BatchDeactivateNativeStylesRequestObject()
        {
            // Snippet: BatchDeactivateNativeStyles(BatchDeactivateNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateNativeStylesRequest request = new BatchDeactivateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                NativeStyleNames =
                {
                    NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
                },
            };
            // Make the request
            BatchDeactivateNativeStylesResponse response = nativeStyleServiceClient.BatchDeactivateNativeStyles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateNativeStylesAsync</summary>
        public async Task BatchDeactivateNativeStylesRequestObjectAsync()
        {
            // Snippet: BatchDeactivateNativeStylesAsync(BatchDeactivateNativeStylesRequest, CallSettings)
            // Additional: BatchDeactivateNativeStylesAsync(BatchDeactivateNativeStylesRequest, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateNativeStylesRequest request = new BatchDeactivateNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                NativeStyleNames =
                {
                    NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
                },
            };
            // Make the request
            BatchDeactivateNativeStylesResponse response = await nativeStyleServiceClient.BatchDeactivateNativeStylesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateNativeStyles</summary>
        public void BatchDeactivateNativeStyles()
        {
            // Snippet: BatchDeactivateNativeStyles(string, IEnumerable<string>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]",
            };
            // Make the request
            BatchDeactivateNativeStylesResponse response = nativeStyleServiceClient.BatchDeactivateNativeStyles(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateNativeStylesAsync</summary>
        public async Task BatchDeactivateNativeStylesAsync()
        {
            // Snippet: BatchDeactivateNativeStylesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateNativeStylesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]",
            };
            // Make the request
            BatchDeactivateNativeStylesResponse response = await nativeStyleServiceClient.BatchDeactivateNativeStylesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateNativeStyles</summary>
        public void BatchDeactivateNativeStylesResourceNames()
        {
            // Snippet: BatchDeactivateNativeStyles(NetworkName, IEnumerable<NativeStyleName>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<NativeStyleName> names = new NativeStyleName[]
            {
                NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            BatchDeactivateNativeStylesResponse response = nativeStyleServiceClient.BatchDeactivateNativeStyles(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateNativeStylesAsync</summary>
        public async Task BatchDeactivateNativeStylesResourceNamesAsync()
        {
            // Snippet: BatchDeactivateNativeStylesAsync(NetworkName, IEnumerable<NativeStyleName>, CallSettings)
            // Additional: BatchDeactivateNativeStylesAsync(NetworkName, IEnumerable<NativeStyleName>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<NativeStyleName> names = new NativeStyleName[]
            {
                NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            BatchDeactivateNativeStylesResponse response = await nativeStyleServiceClient.BatchDeactivateNativeStylesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveNativeStyles</summary>
        public void BatchArchiveNativeStylesRequestObject()
        {
            // Snippet: BatchArchiveNativeStyles(BatchArchiveNativeStylesRequest, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveNativeStylesRequest request = new BatchArchiveNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                NativeStyleNames =
                {
                    NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
                },
            };
            // Make the request
            BatchArchiveNativeStylesResponse response = nativeStyleServiceClient.BatchArchiveNativeStyles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveNativeStylesAsync</summary>
        public async Task BatchArchiveNativeStylesRequestObjectAsync()
        {
            // Snippet: BatchArchiveNativeStylesAsync(BatchArchiveNativeStylesRequest, CallSettings)
            // Additional: BatchArchiveNativeStylesAsync(BatchArchiveNativeStylesRequest, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveNativeStylesRequest request = new BatchArchiveNativeStylesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                NativeStyleNames =
                {
                    NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
                },
            };
            // Make the request
            BatchArchiveNativeStylesResponse response = await nativeStyleServiceClient.BatchArchiveNativeStylesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveNativeStyles</summary>
        public void BatchArchiveNativeStyles()
        {
            // Snippet: BatchArchiveNativeStyles(string, IEnumerable<string>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]",
            };
            // Make the request
            BatchArchiveNativeStylesResponse response = nativeStyleServiceClient.BatchArchiveNativeStyles(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveNativeStylesAsync</summary>
        public async Task BatchArchiveNativeStylesAsync()
        {
            // Snippet: BatchArchiveNativeStylesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveNativeStylesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/nativeStyles/[NATIVE_STYLE]",
            };
            // Make the request
            BatchArchiveNativeStylesResponse response = await nativeStyleServiceClient.BatchArchiveNativeStylesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveNativeStyles</summary>
        public void BatchArchiveNativeStylesResourceNames()
        {
            // Snippet: BatchArchiveNativeStyles(NetworkName, IEnumerable<NativeStyleName>, CallSettings)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = NativeStyleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<NativeStyleName> names = new NativeStyleName[]
            {
                NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            BatchArchiveNativeStylesResponse response = nativeStyleServiceClient.BatchArchiveNativeStyles(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveNativeStylesAsync</summary>
        public async Task BatchArchiveNativeStylesResourceNamesAsync()
        {
            // Snippet: BatchArchiveNativeStylesAsync(NetworkName, IEnumerable<NativeStyleName>, CallSettings)
            // Additional: BatchArchiveNativeStylesAsync(NetworkName, IEnumerable<NativeStyleName>, CancellationToken)
            // Create client
            NativeStyleServiceClient nativeStyleServiceClient = await NativeStyleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<NativeStyleName> names = new NativeStyleName[]
            {
                NativeStyleName.FromNetworkCodeNativeStyle("[NETWORK_CODE]", "[NATIVE_STYLE]"),
            };
            // Make the request
            BatchArchiveNativeStylesResponse response = await nativeStyleServiceClient.BatchArchiveNativeStylesAsync(parent, names);
            // End snippet
        }
    }
}
