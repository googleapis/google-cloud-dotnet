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
    public sealed class AllGeneratedForecastAdjustmentServiceClientSnippets
    {
        /// <summary>Snippet for GetForecastAdjustment</summary>
        public void GetForecastAdjustmentRequestObject()
        {
            // Snippet: GetForecastAdjustment(GetForecastAdjustmentRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            GetForecastAdjustmentRequest request = new GetForecastAdjustmentRequest
            {
                ForecastAdjustmentName = ForecastAdjustmentName.FromNetworkCodeForecastAdjustment("[NETWORK_CODE]", "[FORECAST_ADJUSTMENT]"),
            };
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.GetForecastAdjustment(request);
            // End snippet
        }

        /// <summary>Snippet for GetForecastAdjustmentAsync</summary>
        public async Task GetForecastAdjustmentRequestObjectAsync()
        {
            // Snippet: GetForecastAdjustmentAsync(GetForecastAdjustmentRequest, CallSettings)
            // Additional: GetForecastAdjustmentAsync(GetForecastAdjustmentRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetForecastAdjustmentRequest request = new GetForecastAdjustmentRequest
            {
                ForecastAdjustmentName = ForecastAdjustmentName.FromNetworkCodeForecastAdjustment("[NETWORK_CODE]", "[FORECAST_ADJUSTMENT]"),
            };
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.GetForecastAdjustmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetForecastAdjustment</summary>
        public void GetForecastAdjustment()
        {
            // Snippet: GetForecastAdjustment(string, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/forecastAdjustments/[FORECAST_ADJUSTMENT]";
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.GetForecastAdjustment(name);
            // End snippet
        }

        /// <summary>Snippet for GetForecastAdjustmentAsync</summary>
        public async Task GetForecastAdjustmentAsync()
        {
            // Snippet: GetForecastAdjustmentAsync(string, CallSettings)
            // Additional: GetForecastAdjustmentAsync(string, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/forecastAdjustments/[FORECAST_ADJUSTMENT]";
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.GetForecastAdjustmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetForecastAdjustment</summary>
        public void GetForecastAdjustmentResourceNames()
        {
            // Snippet: GetForecastAdjustment(ForecastAdjustmentName, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            ForecastAdjustmentName name = ForecastAdjustmentName.FromNetworkCodeForecastAdjustment("[NETWORK_CODE]", "[FORECAST_ADJUSTMENT]");
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.GetForecastAdjustment(name);
            // End snippet
        }

        /// <summary>Snippet for GetForecastAdjustmentAsync</summary>
        public async Task GetForecastAdjustmentResourceNamesAsync()
        {
            // Snippet: GetForecastAdjustmentAsync(ForecastAdjustmentName, CallSettings)
            // Additional: GetForecastAdjustmentAsync(ForecastAdjustmentName, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ForecastAdjustmentName name = ForecastAdjustmentName.FromNetworkCodeForecastAdjustment("[NETWORK_CODE]", "[FORECAST_ADJUSTMENT]");
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.GetForecastAdjustmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListForecastAdjustments</summary>
        public void ListForecastAdjustmentsRequestObject()
        {
            // Snippet: ListForecastAdjustments(ListForecastAdjustmentsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            ListForecastAdjustmentsRequest request = new ListForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> response = forecastAdjustmentServiceClient.ListForecastAdjustments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForecastAdjustment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListForecastAdjustmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastAdjustment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastAdjustment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastAdjustment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListForecastAdjustmentsAsync</summary>
        public async Task ListForecastAdjustmentsRequestObjectAsync()
        {
            // Snippet: ListForecastAdjustmentsAsync(ListForecastAdjustmentsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListForecastAdjustmentsRequest request = new ListForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> response = forecastAdjustmentServiceClient.ListForecastAdjustmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ForecastAdjustment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListForecastAdjustmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastAdjustment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastAdjustment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastAdjustment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListForecastAdjustments</summary>
        public void ListForecastAdjustments()
        {
            // Snippet: ListForecastAdjustments(string, string, int?, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> response = forecastAdjustmentServiceClient.ListForecastAdjustments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForecastAdjustment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListForecastAdjustmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastAdjustment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastAdjustment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastAdjustment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListForecastAdjustmentsAsync</summary>
        public async Task ListForecastAdjustmentsAsync()
        {
            // Snippet: ListForecastAdjustmentsAsync(string, string, int?, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> response = forecastAdjustmentServiceClient.ListForecastAdjustmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ForecastAdjustment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListForecastAdjustmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastAdjustment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastAdjustment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastAdjustment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListForecastAdjustments</summary>
        public void ListForecastAdjustmentsResourceNames()
        {
            // Snippet: ListForecastAdjustments(NetworkName, string, int?, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> response = forecastAdjustmentServiceClient.ListForecastAdjustments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForecastAdjustment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListForecastAdjustmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastAdjustment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastAdjustment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastAdjustment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListForecastAdjustmentsAsync</summary>
        public async Task ListForecastAdjustmentsResourceNamesAsync()
        {
            // Snippet: ListForecastAdjustmentsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> response = forecastAdjustmentServiceClient.ListForecastAdjustmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ForecastAdjustment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListForecastAdjustmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastAdjustment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastAdjustment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastAdjustment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateForecastAdjustment</summary>
        public void CreateForecastAdjustmentRequestObject()
        {
            // Snippet: CreateForecastAdjustment(CreateForecastAdjustmentRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            CreateForecastAdjustmentRequest request = new CreateForecastAdjustmentRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ForecastAdjustment = new ForecastAdjustment(),
            };
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.CreateForecastAdjustment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateForecastAdjustmentAsync</summary>
        public async Task CreateForecastAdjustmentRequestObjectAsync()
        {
            // Snippet: CreateForecastAdjustmentAsync(CreateForecastAdjustmentRequest, CallSettings)
            // Additional: CreateForecastAdjustmentAsync(CreateForecastAdjustmentRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateForecastAdjustmentRequest request = new CreateForecastAdjustmentRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ForecastAdjustment = new ForecastAdjustment(),
            };
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.CreateForecastAdjustmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateForecastAdjustment</summary>
        public void CreateForecastAdjustment()
        {
            // Snippet: CreateForecastAdjustment(string, ForecastAdjustment, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.CreateForecastAdjustment(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for CreateForecastAdjustmentAsync</summary>
        public async Task CreateForecastAdjustmentAsync()
        {
            // Snippet: CreateForecastAdjustmentAsync(string, ForecastAdjustment, CallSettings)
            // Additional: CreateForecastAdjustmentAsync(string, ForecastAdjustment, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.CreateForecastAdjustmentAsync(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for CreateForecastAdjustment</summary>
        public void CreateForecastAdjustmentResourceNames()
        {
            // Snippet: CreateForecastAdjustment(NetworkName, ForecastAdjustment, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.CreateForecastAdjustment(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for CreateForecastAdjustmentAsync</summary>
        public async Task CreateForecastAdjustmentResourceNamesAsync()
        {
            // Snippet: CreateForecastAdjustmentAsync(NetworkName, ForecastAdjustment, CallSettings)
            // Additional: CreateForecastAdjustmentAsync(NetworkName, ForecastAdjustment, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.CreateForecastAdjustmentAsync(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateForecastAdjustments</summary>
        public void BatchCreateForecastAdjustmentsRequestObject()
        {
            // Snippet: BatchCreateForecastAdjustments(BatchCreateForecastAdjustmentsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateForecastAdjustmentsRequest request = new BatchCreateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateForecastAdjustmentRequest(),
                },
            };
            // Make the request
            BatchCreateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchCreateForecastAdjustments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateForecastAdjustmentsAsync</summary>
        public async Task BatchCreateForecastAdjustmentsRequestObjectAsync()
        {
            // Snippet: BatchCreateForecastAdjustmentsAsync(BatchCreateForecastAdjustmentsRequest, CallSettings)
            // Additional: BatchCreateForecastAdjustmentsAsync(BatchCreateForecastAdjustmentsRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateForecastAdjustmentsRequest request = new BatchCreateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateForecastAdjustmentRequest(),
                },
            };
            // Make the request
            BatchCreateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchCreateForecastAdjustmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateForecastAdjustments</summary>
        public void BatchCreateForecastAdjustments()
        {
            // Snippet: BatchCreateForecastAdjustments(string, IEnumerable<CreateForecastAdjustmentRequest>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateForecastAdjustmentRequest> requests = new CreateForecastAdjustmentRequest[]
            {
                new CreateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchCreateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchCreateForecastAdjustments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateForecastAdjustmentsAsync</summary>
        public async Task BatchCreateForecastAdjustmentsAsync()
        {
            // Snippet: BatchCreateForecastAdjustmentsAsync(string, IEnumerable<CreateForecastAdjustmentRequest>, CallSettings)
            // Additional: BatchCreateForecastAdjustmentsAsync(string, IEnumerable<CreateForecastAdjustmentRequest>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateForecastAdjustmentRequest> requests = new CreateForecastAdjustmentRequest[]
            {
                new CreateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchCreateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchCreateForecastAdjustmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateForecastAdjustments</summary>
        public void BatchCreateForecastAdjustmentsResourceNames()
        {
            // Snippet: BatchCreateForecastAdjustments(NetworkName, IEnumerable<CreateForecastAdjustmentRequest>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateForecastAdjustmentRequest> requests = new CreateForecastAdjustmentRequest[]
            {
                new CreateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchCreateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchCreateForecastAdjustments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateForecastAdjustmentsAsync</summary>
        public async Task BatchCreateForecastAdjustmentsResourceNamesAsync()
        {
            // Snippet: BatchCreateForecastAdjustmentsAsync(NetworkName, IEnumerable<CreateForecastAdjustmentRequest>, CallSettings)
            // Additional: BatchCreateForecastAdjustmentsAsync(NetworkName, IEnumerable<CreateForecastAdjustmentRequest>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateForecastAdjustmentRequest> requests = new CreateForecastAdjustmentRequest[]
            {
                new CreateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchCreateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchCreateForecastAdjustmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateForecastAdjustments</summary>
        public void BatchActivateForecastAdjustmentsRequestObject()
        {
            // Snippet: BatchActivateForecastAdjustments(BatchActivateForecastAdjustmentsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateForecastAdjustmentsRequest request = new BatchActivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchActivateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchActivateForecastAdjustments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateForecastAdjustmentsAsync</summary>
        public async Task BatchActivateForecastAdjustmentsRequestObjectAsync()
        {
            // Snippet: BatchActivateForecastAdjustmentsAsync(BatchActivateForecastAdjustmentsRequest, CallSettings)
            // Additional: BatchActivateForecastAdjustmentsAsync(BatchActivateForecastAdjustmentsRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateForecastAdjustmentsRequest request = new BatchActivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchActivateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchActivateForecastAdjustmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateForecastAdjustments</summary>
        public void BatchActivateForecastAdjustments()
        {
            // Snippet: BatchActivateForecastAdjustments(string, IEnumerable<string>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchActivateForecastAdjustments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateForecastAdjustmentsAsync</summary>
        public async Task BatchActivateForecastAdjustmentsAsync()
        {
            // Snippet: BatchActivateForecastAdjustmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateForecastAdjustmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchActivateForecastAdjustmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateForecastAdjustments</summary>
        public void BatchActivateForecastAdjustmentsResourceNames()
        {
            // Snippet: BatchActivateForecastAdjustments(NetworkName, IEnumerable<string>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchActivateForecastAdjustments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateForecastAdjustmentsAsync</summary>
        public async Task BatchActivateForecastAdjustmentsResourceNamesAsync()
        {
            // Snippet: BatchActivateForecastAdjustmentsAsync(NetworkName, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateForecastAdjustmentsAsync(NetworkName, IEnumerable<string>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchActivateForecastAdjustmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateForecastAdjustments</summary>
        public void BatchDeactivateForecastAdjustmentsRequestObject()
        {
            // Snippet: BatchDeactivateForecastAdjustments(BatchDeactivateForecastAdjustmentsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateForecastAdjustmentsRequest request = new BatchDeactivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchDeactivateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchDeactivateForecastAdjustments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateForecastAdjustmentsAsync</summary>
        public async Task BatchDeactivateForecastAdjustmentsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateForecastAdjustmentsAsync(BatchDeactivateForecastAdjustmentsRequest, CallSettings)
            // Additional: BatchDeactivateForecastAdjustmentsAsync(BatchDeactivateForecastAdjustmentsRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateForecastAdjustmentsRequest request = new BatchDeactivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchDeactivateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchDeactivateForecastAdjustmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateForecastAdjustments</summary>
        public void BatchDeactivateForecastAdjustments()
        {
            // Snippet: BatchDeactivateForecastAdjustments(string, IEnumerable<string>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchDeactivateForecastAdjustments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateForecastAdjustmentsAsync</summary>
        public async Task BatchDeactivateForecastAdjustmentsAsync()
        {
            // Snippet: BatchDeactivateForecastAdjustmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateForecastAdjustmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchDeactivateForecastAdjustmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateForecastAdjustments</summary>
        public void BatchDeactivateForecastAdjustmentsResourceNames()
        {
            // Snippet: BatchDeactivateForecastAdjustments(NetworkName, IEnumerable<string>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchDeactivateForecastAdjustments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateForecastAdjustmentsAsync</summary>
        public async Task BatchDeactivateForecastAdjustmentsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateForecastAdjustmentsAsync(NetworkName, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateForecastAdjustmentsAsync(NetworkName, IEnumerable<string>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchDeactivateForecastAdjustmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for UpdateForecastAdjustment</summary>
        public void UpdateForecastAdjustmentRequestObject()
        {
            // Snippet: UpdateForecastAdjustment(UpdateForecastAdjustmentRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            UpdateForecastAdjustmentRequest request = new UpdateForecastAdjustmentRequest
            {
                ForecastAdjustment = new ForecastAdjustment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.UpdateForecastAdjustment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateForecastAdjustmentAsync</summary>
        public async Task UpdateForecastAdjustmentRequestObjectAsync()
        {
            // Snippet: UpdateForecastAdjustmentAsync(UpdateForecastAdjustmentRequest, CallSettings)
            // Additional: UpdateForecastAdjustmentAsync(UpdateForecastAdjustmentRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateForecastAdjustmentRequest request = new UpdateForecastAdjustmentRequest
            {
                ForecastAdjustment = new ForecastAdjustment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.UpdateForecastAdjustmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateForecastAdjustment</summary>
        public void UpdateForecastAdjustment()
        {
            // Snippet: UpdateForecastAdjustment(ForecastAdjustment, FieldMask, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ForecastAdjustment response = forecastAdjustmentServiceClient.UpdateForecastAdjustment(forecastAdjustment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateForecastAdjustmentAsync</summary>
        public async Task UpdateForecastAdjustmentAsync()
        {
            // Snippet: UpdateForecastAdjustmentAsync(ForecastAdjustment, FieldMask, CallSettings)
            // Additional: UpdateForecastAdjustmentAsync(ForecastAdjustment, FieldMask, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ForecastAdjustment response = await forecastAdjustmentServiceClient.UpdateForecastAdjustmentAsync(forecastAdjustment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateForecastAdjustments</summary>
        public void BatchUpdateForecastAdjustmentsRequestObject()
        {
            // Snippet: BatchUpdateForecastAdjustments(BatchUpdateForecastAdjustmentsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateForecastAdjustmentsRequest request = new BatchUpdateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateForecastAdjustmentRequest(),
                },
            };
            // Make the request
            BatchUpdateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchUpdateForecastAdjustments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateForecastAdjustmentsAsync</summary>
        public async Task BatchUpdateForecastAdjustmentsRequestObjectAsync()
        {
            // Snippet: BatchUpdateForecastAdjustmentsAsync(BatchUpdateForecastAdjustmentsRequest, CallSettings)
            // Additional: BatchUpdateForecastAdjustmentsAsync(BatchUpdateForecastAdjustmentsRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateForecastAdjustmentsRequest request = new BatchUpdateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateForecastAdjustmentRequest(),
                },
            };
            // Make the request
            BatchUpdateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchUpdateForecastAdjustmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateForecastAdjustments</summary>
        public void BatchUpdateForecastAdjustments()
        {
            // Snippet: BatchUpdateForecastAdjustments(string, IEnumerable<UpdateForecastAdjustmentRequest>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateForecastAdjustmentRequest> requests = new UpdateForecastAdjustmentRequest[]
            {
                new UpdateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchUpdateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchUpdateForecastAdjustments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateForecastAdjustmentsAsync</summary>
        public async Task BatchUpdateForecastAdjustmentsAsync()
        {
            // Snippet: BatchUpdateForecastAdjustmentsAsync(string, IEnumerable<UpdateForecastAdjustmentRequest>, CallSettings)
            // Additional: BatchUpdateForecastAdjustmentsAsync(string, IEnumerable<UpdateForecastAdjustmentRequest>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateForecastAdjustmentRequest> requests = new UpdateForecastAdjustmentRequest[]
            {
                new UpdateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchUpdateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchUpdateForecastAdjustmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateForecastAdjustments</summary>
        public void BatchUpdateForecastAdjustmentsResourceNames()
        {
            // Snippet: BatchUpdateForecastAdjustments(NetworkName, IEnumerable<UpdateForecastAdjustmentRequest>, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateForecastAdjustmentRequest> requests = new UpdateForecastAdjustmentRequest[]
            {
                new UpdateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchUpdateForecastAdjustmentsResponse response = forecastAdjustmentServiceClient.BatchUpdateForecastAdjustments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateForecastAdjustmentsAsync</summary>
        public async Task BatchUpdateForecastAdjustmentsResourceNamesAsync()
        {
            // Snippet: BatchUpdateForecastAdjustmentsAsync(NetworkName, IEnumerable<UpdateForecastAdjustmentRequest>, CallSettings)
            // Additional: BatchUpdateForecastAdjustmentsAsync(NetworkName, IEnumerable<UpdateForecastAdjustmentRequest>, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateForecastAdjustmentRequest> requests = new UpdateForecastAdjustmentRequest[]
            {
                new UpdateForecastAdjustmentRequest(),
            };
            // Make the request
            BatchUpdateForecastAdjustmentsResponse response = await forecastAdjustmentServiceClient.BatchUpdateForecastAdjustmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for CalculateDailyAdOpportunityCounts</summary>
        public void CalculateDailyAdOpportunityCountsRequestObject()
        {
            // Snippet: CalculateDailyAdOpportunityCounts(CalculateDailyAdOpportunityCountsRequest, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            CalculateDailyAdOpportunityCountsRequest request = new CalculateDailyAdOpportunityCountsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ForecastAdjustment = new ForecastAdjustment(),
            };
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCounts(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateDailyAdOpportunityCountsAsync</summary>
        public async Task CalculateDailyAdOpportunityCountsRequestObjectAsync()
        {
            // Snippet: CalculateDailyAdOpportunityCountsAsync(CalculateDailyAdOpportunityCountsRequest, CallSettings)
            // Additional: CalculateDailyAdOpportunityCountsAsync(CalculateDailyAdOpportunityCountsRequest, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculateDailyAdOpportunityCountsRequest request = new CalculateDailyAdOpportunityCountsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ForecastAdjustment = new ForecastAdjustment(),
            };
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = await forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCountsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateDailyAdOpportunityCounts</summary>
        public void CalculateDailyAdOpportunityCounts()
        {
            // Snippet: CalculateDailyAdOpportunityCounts(string, ForecastAdjustment, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCounts(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for CalculateDailyAdOpportunityCountsAsync</summary>
        public async Task CalculateDailyAdOpportunityCountsAsync()
        {
            // Snippet: CalculateDailyAdOpportunityCountsAsync(string, ForecastAdjustment, CallSettings)
            // Additional: CalculateDailyAdOpportunityCountsAsync(string, ForecastAdjustment, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = await forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCountsAsync(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for CalculateDailyAdOpportunityCounts</summary>
        public void CalculateDailyAdOpportunityCountsResourceNames()
        {
            // Snippet: CalculateDailyAdOpportunityCounts(NetworkName, ForecastAdjustment, CallSettings)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = ForecastAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCounts(parent, forecastAdjustment);
            // End snippet
        }

        /// <summary>Snippet for CalculateDailyAdOpportunityCountsAsync</summary>
        public async Task CalculateDailyAdOpportunityCountsResourceNamesAsync()
        {
            // Snippet: CalculateDailyAdOpportunityCountsAsync(NetworkName, ForecastAdjustment, CallSettings)
            // Additional: CalculateDailyAdOpportunityCountsAsync(NetworkName, ForecastAdjustment, CancellationToken)
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = await forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCountsAsync(parent, forecastAdjustment);
            // End snippet
        }
    }
}
