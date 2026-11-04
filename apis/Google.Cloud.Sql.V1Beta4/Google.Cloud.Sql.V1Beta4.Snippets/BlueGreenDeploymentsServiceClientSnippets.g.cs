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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Sql.V1Beta4;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBlueGreenDeploymentsServiceClientSnippets
    {
        /// <summary>Snippet for CreateBlueGreenDeployment</summary>
        public void CreateBlueGreenDeploymentRequestObject()
        {
            // Snippet: CreateBlueGreenDeployment(CreateBlueGreenDeploymentRequest, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            CreateBlueGreenDeploymentRequest request = new CreateBlueGreenDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BlueGreenDeploymentId = "",
                BlueGreenDeployment = new BlueGreenDeployment(),
            };
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.CreateBlueGreenDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueGreenDeploymentAsync</summary>
        public async Task CreateBlueGreenDeploymentRequestObjectAsync()
        {
            // Snippet: CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest, CallSettings)
            // Additional: CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBlueGreenDeploymentRequest request = new CreateBlueGreenDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BlueGreenDeploymentId = "",
                BlueGreenDeployment = new BlueGreenDeployment(),
            };
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.CreateBlueGreenDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueGreenDeployment</summary>
        public void CreateBlueGreenDeployment()
        {
            // Snippet: CreateBlueGreenDeployment(string, BlueGreenDeployment, string, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BlueGreenDeployment blueGreenDeployment = new BlueGreenDeployment();
            string blueGreenDeploymentId = "";
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.CreateBlueGreenDeployment(parent, blueGreenDeployment, blueGreenDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueGreenDeploymentAsync</summary>
        public async Task CreateBlueGreenDeploymentAsync()
        {
            // Snippet: CreateBlueGreenDeploymentAsync(string, BlueGreenDeployment, string, CallSettings)
            // Additional: CreateBlueGreenDeploymentAsync(string, BlueGreenDeployment, string, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BlueGreenDeployment blueGreenDeployment = new BlueGreenDeployment();
            string blueGreenDeploymentId = "";
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.CreateBlueGreenDeploymentAsync(parent, blueGreenDeployment, blueGreenDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueGreenDeployment</summary>
        public void CreateBlueGreenDeploymentResourceNames()
        {
            // Snippet: CreateBlueGreenDeployment(LocationName, BlueGreenDeployment, string, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BlueGreenDeployment blueGreenDeployment = new BlueGreenDeployment();
            string blueGreenDeploymentId = "";
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.CreateBlueGreenDeployment(parent, blueGreenDeployment, blueGreenDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueGreenDeploymentAsync</summary>
        public async Task CreateBlueGreenDeploymentResourceNamesAsync()
        {
            // Snippet: CreateBlueGreenDeploymentAsync(LocationName, BlueGreenDeployment, string, CallSettings)
            // Additional: CreateBlueGreenDeploymentAsync(LocationName, BlueGreenDeployment, string, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BlueGreenDeployment blueGreenDeployment = new BlueGreenDeployment();
            string blueGreenDeploymentId = "";
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.CreateBlueGreenDeploymentAsync(parent, blueGreenDeployment, blueGreenDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for GetBlueGreenDeployment</summary>
        public void GetBlueGreenDeploymentRequestObject()
        {
            // Snippet: GetBlueGreenDeployment(GetBlueGreenDeploymentRequest, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GetBlueGreenDeploymentRequest request = new GetBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]"),
                View = GetBlueGreenDeploymentRequest.Types.BlueGreenDeploymentView.Unspecified,
            };
            // Make the request
            BlueGreenDeployment response = blueGreenDeploymentsServiceClient.GetBlueGreenDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetBlueGreenDeploymentAsync</summary>
        public async Task GetBlueGreenDeploymentRequestObjectAsync()
        {
            // Snippet: GetBlueGreenDeploymentAsync(GetBlueGreenDeploymentRequest, CallSettings)
            // Additional: GetBlueGreenDeploymentAsync(GetBlueGreenDeploymentRequest, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBlueGreenDeploymentRequest request = new GetBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]"),
                View = GetBlueGreenDeploymentRequest.Types.BlueGreenDeploymentView.Unspecified,
            };
            // Make the request
            BlueGreenDeployment response = await blueGreenDeploymentsServiceClient.GetBlueGreenDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBlueGreenDeployment</summary>
        public void GetBlueGreenDeployment()
        {
            // Snippet: GetBlueGreenDeployment(string, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/blueGreenDeployments/[BLUE_GREEN_DEPLOYMENT]";
            // Make the request
            BlueGreenDeployment response = blueGreenDeploymentsServiceClient.GetBlueGreenDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetBlueGreenDeploymentAsync</summary>
        public async Task GetBlueGreenDeploymentAsync()
        {
            // Snippet: GetBlueGreenDeploymentAsync(string, CallSettings)
            // Additional: GetBlueGreenDeploymentAsync(string, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/blueGreenDeployments/[BLUE_GREEN_DEPLOYMENT]";
            // Make the request
            BlueGreenDeployment response = await blueGreenDeploymentsServiceClient.GetBlueGreenDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBlueGreenDeployment</summary>
        public void GetBlueGreenDeploymentResourceNames()
        {
            // Snippet: GetBlueGreenDeployment(BlueGreenDeploymentName, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            BlueGreenDeploymentName name = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]");
            // Make the request
            BlueGreenDeployment response = blueGreenDeploymentsServiceClient.GetBlueGreenDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetBlueGreenDeploymentAsync</summary>
        public async Task GetBlueGreenDeploymentResourceNamesAsync()
        {
            // Snippet: GetBlueGreenDeploymentAsync(BlueGreenDeploymentName, CallSettings)
            // Additional: GetBlueGreenDeploymentAsync(BlueGreenDeploymentName, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BlueGreenDeploymentName name = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]");
            // Make the request
            BlueGreenDeployment response = await blueGreenDeploymentsServiceClient.GetBlueGreenDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBlueGreenDeployments</summary>
        public void ListBlueGreenDeploymentsRequestObject()
        {
            // Snippet: ListBlueGreenDeployments(ListBlueGreenDeploymentsRequest, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            ListBlueGreenDeploymentsRequest request = new ListBlueGreenDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> response = blueGreenDeploymentsServiceClient.ListBlueGreenDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BlueGreenDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueGreenDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BlueGreenDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BlueGreenDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BlueGreenDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueGreenDeploymentsAsync</summary>
        public async Task ListBlueGreenDeploymentsRequestObjectAsync()
        {
            // Snippet: ListBlueGreenDeploymentsAsync(ListBlueGreenDeploymentsRequest, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBlueGreenDeploymentsRequest request = new ListBlueGreenDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> response = blueGreenDeploymentsServiceClient.ListBlueGreenDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BlueGreenDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBlueGreenDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BlueGreenDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BlueGreenDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BlueGreenDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueGreenDeployments</summary>
        public void ListBlueGreenDeployments()
        {
            // Snippet: ListBlueGreenDeployments(string, string, int?, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> response = blueGreenDeploymentsServiceClient.ListBlueGreenDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BlueGreenDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueGreenDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BlueGreenDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BlueGreenDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BlueGreenDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueGreenDeploymentsAsync</summary>
        public async Task ListBlueGreenDeploymentsAsync()
        {
            // Snippet: ListBlueGreenDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> response = blueGreenDeploymentsServiceClient.ListBlueGreenDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BlueGreenDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBlueGreenDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BlueGreenDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BlueGreenDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BlueGreenDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueGreenDeployments</summary>
        public void ListBlueGreenDeploymentsResourceNames()
        {
            // Snippet: ListBlueGreenDeployments(LocationName, string, int?, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> response = blueGreenDeploymentsServiceClient.ListBlueGreenDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BlueGreenDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueGreenDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BlueGreenDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BlueGreenDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BlueGreenDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueGreenDeploymentsAsync</summary>
        public async Task ListBlueGreenDeploymentsResourceNamesAsync()
        {
            // Snippet: ListBlueGreenDeploymentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> response = blueGreenDeploymentsServiceClient.ListBlueGreenDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BlueGreenDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBlueGreenDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BlueGreenDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BlueGreenDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BlueGreenDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SwitchoverBlueGreenDeployment</summary>
        public void SwitchoverBlueGreenDeploymentRequestObject()
        {
            // Snippet: SwitchoverBlueGreenDeployment(SwitchoverBlueGreenDeploymentRequest, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            SwitchoverBlueGreenDeploymentRequest request = new SwitchoverBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]"),
            };
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for SwitchoverBlueGreenDeploymentAsync</summary>
        public async Task SwitchoverBlueGreenDeploymentRequestObjectAsync()
        {
            // Snippet: SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest, CallSettings)
            // Additional: SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SwitchoverBlueGreenDeploymentRequest request = new SwitchoverBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]"),
            };
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SwitchoverBlueGreenDeployment</summary>
        public void SwitchoverBlueGreenDeployment()
        {
            // Snippet: SwitchoverBlueGreenDeployment(string, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/blueGreenDeployments/[BLUE_GREEN_DEPLOYMENT]";
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for SwitchoverBlueGreenDeploymentAsync</summary>
        public async Task SwitchoverBlueGreenDeploymentAsync()
        {
            // Snippet: SwitchoverBlueGreenDeploymentAsync(string, CallSettings)
            // Additional: SwitchoverBlueGreenDeploymentAsync(string, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/blueGreenDeployments/[BLUE_GREEN_DEPLOYMENT]";
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SwitchoverBlueGreenDeployment</summary>
        public void SwitchoverBlueGreenDeploymentResourceNames()
        {
            // Snippet: SwitchoverBlueGreenDeployment(BlueGreenDeploymentName, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            BlueGreenDeploymentName name = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]");
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for SwitchoverBlueGreenDeploymentAsync</summary>
        public async Task SwitchoverBlueGreenDeploymentResourceNamesAsync()
        {
            // Snippet: SwitchoverBlueGreenDeploymentAsync(BlueGreenDeploymentName, CallSettings)
            // Additional: SwitchoverBlueGreenDeploymentAsync(BlueGreenDeploymentName, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BlueGreenDeploymentName name = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]");
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueGreenDeployment</summary>
        public void DeleteBlueGreenDeploymentRequestObject()
        {
            // Snippet: DeleteBlueGreenDeployment(DeleteBlueGreenDeploymentRequest, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            DeleteBlueGreenDeploymentRequest request = new DeleteBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]"),
                DeleteOldSource = false,
            };
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.DeleteBlueGreenDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueGreenDeploymentAsync</summary>
        public async Task DeleteBlueGreenDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest, CallSettings)
            // Additional: DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBlueGreenDeploymentRequest request = new DeleteBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]"),
                DeleteOldSource = false,
            };
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.DeleteBlueGreenDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueGreenDeployment</summary>
        public void DeleteBlueGreenDeployment()
        {
            // Snippet: DeleteBlueGreenDeployment(string, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/blueGreenDeployments/[BLUE_GREEN_DEPLOYMENT]";
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.DeleteBlueGreenDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueGreenDeploymentAsync</summary>
        public async Task DeleteBlueGreenDeploymentAsync()
        {
            // Snippet: DeleteBlueGreenDeploymentAsync(string, CallSettings)
            // Additional: DeleteBlueGreenDeploymentAsync(string, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/blueGreenDeployments/[BLUE_GREEN_DEPLOYMENT]";
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.DeleteBlueGreenDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueGreenDeployment</summary>
        public void DeleteBlueGreenDeploymentResourceNames()
        {
            // Snippet: DeleteBlueGreenDeployment(BlueGreenDeploymentName, CallSettings)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = BlueGreenDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            BlueGreenDeploymentName name = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]");
            // Make the request
            Operation response = blueGreenDeploymentsServiceClient.DeleteBlueGreenDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueGreenDeploymentAsync</summary>
        public async Task DeleteBlueGreenDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteBlueGreenDeploymentAsync(BlueGreenDeploymentName, CallSettings)
            // Additional: DeleteBlueGreenDeploymentAsync(BlueGreenDeploymentName, CancellationToken)
            // Create client
            BlueGreenDeploymentsServiceClient blueGreenDeploymentsServiceClient = await BlueGreenDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BlueGreenDeploymentName name = BlueGreenDeploymentName.FromProjectLocationBlueGreenDeployment("[PROJECT]", "[LOCATION]", "[BLUE_GREEN_DEPLOYMENT]");
            // Make the request
            Operation response = await blueGreenDeploymentsServiceClient.DeleteBlueGreenDeploymentAsync(name);
            // End snippet
        }
    }
}
