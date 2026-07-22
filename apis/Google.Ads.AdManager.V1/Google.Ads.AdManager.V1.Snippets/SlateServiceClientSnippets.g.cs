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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSlateServiceClientSnippets
    {
        /// <summary>Snippet for GetSlate</summary>
        public void GetSlateRequestObject()
        {
            // Snippet: GetSlate(GetSlateRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
            };
            // Make the request
            Slate response = slateServiceClient.GetSlate(request);
            // End snippet
        }

        /// <summary>Snippet for GetSlateAsync</summary>
        public async Task GetSlateRequestObjectAsync()
        {
            // Snippet: GetSlateAsync(GetSlateRequest, CallSettings)
            // Additional: GetSlateAsync(GetSlateRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
            };
            // Make the request
            Slate response = await slateServiceClient.GetSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSlate</summary>
        public void GetSlate()
        {
            // Snippet: GetSlate(string, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/slates/[SLATE]";
            // Make the request
            Slate response = slateServiceClient.GetSlate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSlateAsync</summary>
        public async Task GetSlateAsync()
        {
            // Snippet: GetSlateAsync(string, CallSettings)
            // Additional: GetSlateAsync(string, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/slates/[SLATE]";
            // Make the request
            Slate response = await slateServiceClient.GetSlateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSlate</summary>
        public void GetSlateResourceNames()
        {
            // Snippet: GetSlate(SlateName, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            SlateName name = SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]");
            // Make the request
            Slate response = slateServiceClient.GetSlate(name);
            // End snippet
        }

        /// <summary>Snippet for GetSlateAsync</summary>
        public async Task GetSlateResourceNamesAsync()
        {
            // Snippet: GetSlateAsync(SlateName, CallSettings)
            // Additional: GetSlateAsync(SlateName, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            SlateName name = SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]");
            // Make the request
            Slate response = await slateServiceClient.GetSlateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSlates</summary>
        public void ListSlatesRequestObject()
        {
            // Snippet: ListSlates(ListSlatesRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            ListSlatesRequest request = new ListSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListSlatesResponse, Slate> response = slateServiceClient.ListSlates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlatesAsync</summary>
        public async Task ListSlatesRequestObjectAsync()
        {
            // Snippet: ListSlatesAsync(ListSlatesRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSlatesRequest request = new ListSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListSlatesResponse, Slate> response = slateServiceClient.ListSlatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlates</summary>
        public void ListSlates()
        {
            // Snippet: ListSlates(string, string, int?, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListSlatesResponse, Slate> response = slateServiceClient.ListSlates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlatesAsync</summary>
        public async Task ListSlatesAsync()
        {
            // Snippet: ListSlatesAsync(string, string, int?, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListSlatesResponse, Slate> response = slateServiceClient.ListSlatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlates</summary>
        public void ListSlatesResourceNames()
        {
            // Snippet: ListSlates(NetworkName, string, int?, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListSlatesResponse, Slate> response = slateServiceClient.ListSlates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSlatesAsync</summary>
        public async Task ListSlatesResourceNamesAsync()
        {
            // Snippet: ListSlatesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListSlatesResponse, Slate> response = slateServiceClient.ListSlatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Slate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSlatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Slate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Slate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Slate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSlate</summary>
        public void CreateSlateRequestObject()
        {
            // Snippet: CreateSlate(CreateSlateRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Slate = new Slate(),
            };
            // Make the request
            Slate response = slateServiceClient.CreateSlate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSlateAsync</summary>
        public async Task CreateSlateRequestObjectAsync()
        {
            // Snippet: CreateSlateAsync(CreateSlateRequest, CallSettings)
            // Additional: CreateSlateAsync(CreateSlateRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Slate = new Slate(),
            };
            // Make the request
            Slate response = await slateServiceClient.CreateSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSlate</summary>
        public void CreateSlate()
        {
            // Snippet: CreateSlate(string, Slate, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Slate slate = new Slate();
            // Make the request
            Slate response = slateServiceClient.CreateSlate(parent, slate);
            // End snippet
        }

        /// <summary>Snippet for CreateSlateAsync</summary>
        public async Task CreateSlateAsync()
        {
            // Snippet: CreateSlateAsync(string, Slate, CallSettings)
            // Additional: CreateSlateAsync(string, Slate, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Slate slate = new Slate();
            // Make the request
            Slate response = await slateServiceClient.CreateSlateAsync(parent, slate);
            // End snippet
        }

        /// <summary>Snippet for CreateSlate</summary>
        public void CreateSlateResourceNames()
        {
            // Snippet: CreateSlate(NetworkName, Slate, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Slate slate = new Slate();
            // Make the request
            Slate response = slateServiceClient.CreateSlate(parent, slate);
            // End snippet
        }

        /// <summary>Snippet for CreateSlateAsync</summary>
        public async Task CreateSlateResourceNamesAsync()
        {
            // Snippet: CreateSlateAsync(NetworkName, Slate, CallSettings)
            // Additional: CreateSlateAsync(NetworkName, Slate, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Slate slate = new Slate();
            // Make the request
            Slate response = await slateServiceClient.CreateSlateAsync(parent, slate);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSlates</summary>
        public void BatchCreateSlatesRequestObject()
        {
            // Snippet: BatchCreateSlates(BatchCreateSlatesRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateSlatesRequest request = new BatchCreateSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateSlateRequest(),
                },
            };
            // Make the request
            BatchCreateSlatesResponse response = slateServiceClient.BatchCreateSlates(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSlatesAsync</summary>
        public async Task BatchCreateSlatesRequestObjectAsync()
        {
            // Snippet: BatchCreateSlatesAsync(BatchCreateSlatesRequest, CallSettings)
            // Additional: BatchCreateSlatesAsync(BatchCreateSlatesRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateSlatesRequest request = new BatchCreateSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateSlateRequest(),
                },
            };
            // Make the request
            BatchCreateSlatesResponse response = await slateServiceClient.BatchCreateSlatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSlates</summary>
        public void BatchCreateSlates()
        {
            // Snippet: BatchCreateSlates(string, IEnumerable<CreateSlateRequest>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateSlateRequest> requests = new CreateSlateRequest[]
            {
                new CreateSlateRequest(),
            };
            // Make the request
            BatchCreateSlatesResponse response = slateServiceClient.BatchCreateSlates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSlatesAsync</summary>
        public async Task BatchCreateSlatesAsync()
        {
            // Snippet: BatchCreateSlatesAsync(string, IEnumerable<CreateSlateRequest>, CallSettings)
            // Additional: BatchCreateSlatesAsync(string, IEnumerable<CreateSlateRequest>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateSlateRequest> requests = new CreateSlateRequest[]
            {
                new CreateSlateRequest(),
            };
            // Make the request
            BatchCreateSlatesResponse response = await slateServiceClient.BatchCreateSlatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSlates</summary>
        public void BatchCreateSlatesResourceNames()
        {
            // Snippet: BatchCreateSlates(NetworkName, IEnumerable<CreateSlateRequest>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateSlateRequest> requests = new CreateSlateRequest[]
            {
                new CreateSlateRequest(),
            };
            // Make the request
            BatchCreateSlatesResponse response = slateServiceClient.BatchCreateSlates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSlatesAsync</summary>
        public async Task BatchCreateSlatesResourceNamesAsync()
        {
            // Snippet: BatchCreateSlatesAsync(NetworkName, IEnumerable<CreateSlateRequest>, CallSettings)
            // Additional: BatchCreateSlatesAsync(NetworkName, IEnumerable<CreateSlateRequest>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateSlateRequest> requests = new CreateSlateRequest[]
            {
                new CreateSlateRequest(),
            };
            // Make the request
            BatchCreateSlatesResponse response = await slateServiceClient.BatchCreateSlatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlate</summary>
        public void UpdateSlateRequestObject()
        {
            // Snippet: UpdateSlate(UpdateSlateRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Slate response = slateServiceClient.UpdateSlate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlateAsync</summary>
        public async Task UpdateSlateRequestObjectAsync()
        {
            // Snippet: UpdateSlateAsync(UpdateSlateRequest, CallSettings)
            // Additional: UpdateSlateAsync(UpdateSlateRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Slate response = await slateServiceClient.UpdateSlateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlate</summary>
        public void UpdateSlate()
        {
            // Snippet: UpdateSlate(Slate, FieldMask, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            Slate slate = new Slate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Slate response = slateServiceClient.UpdateSlate(slate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSlateAsync</summary>
        public async Task UpdateSlateAsync()
        {
            // Snippet: UpdateSlateAsync(Slate, FieldMask, CallSettings)
            // Additional: UpdateSlateAsync(Slate, FieldMask, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            Slate slate = new Slate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Slate response = await slateServiceClient.UpdateSlateAsync(slate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSlates</summary>
        public void BatchUpdateSlatesRequestObject()
        {
            // Snippet: BatchUpdateSlates(BatchUpdateSlatesRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateSlatesRequest request = new BatchUpdateSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateSlateRequest(),
                },
            };
            // Make the request
            BatchUpdateSlatesResponse response = slateServiceClient.BatchUpdateSlates(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSlatesAsync</summary>
        public async Task BatchUpdateSlatesRequestObjectAsync()
        {
            // Snippet: BatchUpdateSlatesAsync(BatchUpdateSlatesRequest, CallSettings)
            // Additional: BatchUpdateSlatesAsync(BatchUpdateSlatesRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateSlatesRequest request = new BatchUpdateSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateSlateRequest(),
                },
            };
            // Make the request
            BatchUpdateSlatesResponse response = await slateServiceClient.BatchUpdateSlatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSlates</summary>
        public void BatchUpdateSlates()
        {
            // Snippet: BatchUpdateSlates(string, IEnumerable<UpdateSlateRequest>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateSlateRequest> requests = new UpdateSlateRequest[]
            {
                new UpdateSlateRequest(),
            };
            // Make the request
            BatchUpdateSlatesResponse response = slateServiceClient.BatchUpdateSlates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSlatesAsync</summary>
        public async Task BatchUpdateSlatesAsync()
        {
            // Snippet: BatchUpdateSlatesAsync(string, IEnumerable<UpdateSlateRequest>, CallSettings)
            // Additional: BatchUpdateSlatesAsync(string, IEnumerable<UpdateSlateRequest>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateSlateRequest> requests = new UpdateSlateRequest[]
            {
                new UpdateSlateRequest(),
            };
            // Make the request
            BatchUpdateSlatesResponse response = await slateServiceClient.BatchUpdateSlatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSlates</summary>
        public void BatchUpdateSlatesResourceNames()
        {
            // Snippet: BatchUpdateSlates(NetworkName, IEnumerable<UpdateSlateRequest>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateSlateRequest> requests = new UpdateSlateRequest[]
            {
                new UpdateSlateRequest(),
            };
            // Make the request
            BatchUpdateSlatesResponse response = slateServiceClient.BatchUpdateSlates(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSlatesAsync</summary>
        public async Task BatchUpdateSlatesResourceNamesAsync()
        {
            // Snippet: BatchUpdateSlatesAsync(NetworkName, IEnumerable<UpdateSlateRequest>, CallSettings)
            // Additional: BatchUpdateSlatesAsync(NetworkName, IEnumerable<UpdateSlateRequest>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateSlateRequest> requests = new UpdateSlateRequest[]
            {
                new UpdateSlateRequest(),
            };
            // Make the request
            BatchUpdateSlatesResponse response = await slateServiceClient.BatchUpdateSlatesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveSlates</summary>
        public void BatchArchiveSlatesRequestObject()
        {
            // Snippet: BatchArchiveSlates(BatchArchiveSlatesRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveSlatesRequest request = new BatchArchiveSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                SlateNames =
                {
                    SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
                },
            };
            // Make the request
            BatchArchiveSlatesResponse response = slateServiceClient.BatchArchiveSlates(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveSlatesAsync</summary>
        public async Task BatchArchiveSlatesRequestObjectAsync()
        {
            // Snippet: BatchArchiveSlatesAsync(BatchArchiveSlatesRequest, CallSettings)
            // Additional: BatchArchiveSlatesAsync(BatchArchiveSlatesRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveSlatesRequest request = new BatchArchiveSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                SlateNames =
                {
                    SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
                },
            };
            // Make the request
            BatchArchiveSlatesResponse response = await slateServiceClient.BatchArchiveSlatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveSlates</summary>
        public void BatchArchiveSlates()
        {
            // Snippet: BatchArchiveSlates(string, IEnumerable<string>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/slates/[SLATE]",
            };
            // Make the request
            BatchArchiveSlatesResponse response = slateServiceClient.BatchArchiveSlates(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveSlatesAsync</summary>
        public async Task BatchArchiveSlatesAsync()
        {
            // Snippet: BatchArchiveSlatesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveSlatesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/slates/[SLATE]",
            };
            // Make the request
            BatchArchiveSlatesResponse response = await slateServiceClient.BatchArchiveSlatesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveSlates</summary>
        public void BatchArchiveSlatesResourceNames()
        {
            // Snippet: BatchArchiveSlates(NetworkName, IEnumerable<SlateName>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<SlateName> names = new SlateName[]
            {
                SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
            };
            // Make the request
            BatchArchiveSlatesResponse response = slateServiceClient.BatchArchiveSlates(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveSlatesAsync</summary>
        public async Task BatchArchiveSlatesResourceNamesAsync()
        {
            // Snippet: BatchArchiveSlatesAsync(NetworkName, IEnumerable<SlateName>, CallSettings)
            // Additional: BatchArchiveSlatesAsync(NetworkName, IEnumerable<SlateName>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<SlateName> names = new SlateName[]
            {
                SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
            };
            // Make the request
            BatchArchiveSlatesResponse response = await slateServiceClient.BatchArchiveSlatesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveSlates</summary>
        public void BatchUnarchiveSlatesRequestObject()
        {
            // Snippet: BatchUnarchiveSlates(BatchUnarchiveSlatesRequest, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            BatchUnarchiveSlatesRequest request = new BatchUnarchiveSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                SlateNames =
                {
                    SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
                },
            };
            // Make the request
            BatchUnarchiveSlatesResponse response = slateServiceClient.BatchUnarchiveSlates(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveSlatesAsync</summary>
        public async Task BatchUnarchiveSlatesRequestObjectAsync()
        {
            // Snippet: BatchUnarchiveSlatesAsync(BatchUnarchiveSlatesRequest, CallSettings)
            // Additional: BatchUnarchiveSlatesAsync(BatchUnarchiveSlatesRequest, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUnarchiveSlatesRequest request = new BatchUnarchiveSlatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                SlateNames =
                {
                    SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
                },
            };
            // Make the request
            BatchUnarchiveSlatesResponse response = await slateServiceClient.BatchUnarchiveSlatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveSlates</summary>
        public void BatchUnarchiveSlates()
        {
            // Snippet: BatchUnarchiveSlates(string, IEnumerable<string>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/slates/[SLATE]",
            };
            // Make the request
            BatchUnarchiveSlatesResponse response = slateServiceClient.BatchUnarchiveSlates(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveSlatesAsync</summary>
        public async Task BatchUnarchiveSlatesAsync()
        {
            // Snippet: BatchUnarchiveSlatesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchUnarchiveSlatesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/slates/[SLATE]",
            };
            // Make the request
            BatchUnarchiveSlatesResponse response = await slateServiceClient.BatchUnarchiveSlatesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveSlates</summary>
        public void BatchUnarchiveSlatesResourceNames()
        {
            // Snippet: BatchUnarchiveSlates(NetworkName, IEnumerable<SlateName>, CallSettings)
            // Create client
            SlateServiceClient slateServiceClient = SlateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<SlateName> names = new SlateName[]
            {
                SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
            };
            // Make the request
            BatchUnarchiveSlatesResponse response = slateServiceClient.BatchUnarchiveSlates(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveSlatesAsync</summary>
        public async Task BatchUnarchiveSlatesResourceNamesAsync()
        {
            // Snippet: BatchUnarchiveSlatesAsync(NetworkName, IEnumerable<SlateName>, CallSettings)
            // Additional: BatchUnarchiveSlatesAsync(NetworkName, IEnumerable<SlateName>, CancellationToken)
            // Create client
            SlateServiceClient slateServiceClient = await SlateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<SlateName> names = new SlateName[]
            {
                SlateName.FromNetworkCodeSlate("[NETWORK_CODE]", "[SLATE]"),
            };
            // Make the request
            BatchUnarchiveSlatesResponse response = await slateServiceClient.BatchUnarchiveSlatesAsync(parent, names);
            // End snippet
        }
    }
}
