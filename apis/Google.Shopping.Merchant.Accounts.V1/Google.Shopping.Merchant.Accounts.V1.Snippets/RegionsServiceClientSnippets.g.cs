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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionsServiceClientSnippets
    {
        /// <summary>Snippet for GetRegion</summary>
        public void GetRegionRequestObject()
        {
            // Snippet: GetRegion(GetRegionRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            GetRegionRequest request = new GetRegionRequest
            {
                RegionName = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]"),
            };
            // Make the request
            Region response = regionsServiceClient.GetRegion(request);
            // End snippet
        }

        /// <summary>Snippet for GetRegionAsync</summary>
        public async Task GetRegionRequestObjectAsync()
        {
            // Snippet: GetRegionAsync(GetRegionRequest, CallSettings)
            // Additional: GetRegionAsync(GetRegionRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionRequest request = new GetRegionRequest
            {
                RegionName = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]"),
            };
            // Make the request
            Region response = await regionsServiceClient.GetRegionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRegion</summary>
        public void GetRegion()
        {
            // Snippet: GetRegion(string, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/regions/[REGION]";
            // Make the request
            Region response = regionsServiceClient.GetRegion(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegionAsync</summary>
        public async Task GetRegionAsync()
        {
            // Snippet: GetRegionAsync(string, CallSettings)
            // Additional: GetRegionAsync(string, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/regions/[REGION]";
            // Make the request
            Region response = await regionsServiceClient.GetRegionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegion</summary>
        public void GetRegionResourceNames()
        {
            // Snippet: GetRegion(RegionName, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            RegionName name = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]");
            // Make the request
            Region response = regionsServiceClient.GetRegion(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegionAsync</summary>
        public async Task GetRegionResourceNamesAsync()
        {
            // Snippet: GetRegionAsync(RegionName, CallSettings)
            // Additional: GetRegionAsync(RegionName, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegionName name = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]");
            // Make the request
            Region response = await regionsServiceClient.GetRegionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRegion</summary>
        public void CreateRegionRequestObject()
        {
            // Snippet: CreateRegion(CreateRegionRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            CreateRegionRequest request = new CreateRegionRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                RegionId = "",
                Region = new Region(),
            };
            // Make the request
            Region response = regionsServiceClient.CreateRegion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRegionAsync</summary>
        public async Task CreateRegionRequestObjectAsync()
        {
            // Snippet: CreateRegionAsync(CreateRegionRequest, CallSettings)
            // Additional: CreateRegionAsync(CreateRegionRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRegionRequest request = new CreateRegionRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                RegionId = "",
                Region = new Region(),
            };
            // Make the request
            Region response = await regionsServiceClient.CreateRegionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRegion</summary>
        public void CreateRegion()
        {
            // Snippet: CreateRegion(string, Region, string, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            Region region = new Region();
            string regionId = "";
            // Make the request
            Region response = regionsServiceClient.CreateRegion(parent, region, regionId);
            // End snippet
        }

        /// <summary>Snippet for CreateRegionAsync</summary>
        public async Task CreateRegionAsync()
        {
            // Snippet: CreateRegionAsync(string, Region, string, CallSettings)
            // Additional: CreateRegionAsync(string, Region, string, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            Region region = new Region();
            string regionId = "";
            // Make the request
            Region response = await regionsServiceClient.CreateRegionAsync(parent, region, regionId);
            // End snippet
        }

        /// <summary>Snippet for CreateRegion</summary>
        public void CreateRegionResourceNames()
        {
            // Snippet: CreateRegion(AccountName, Region, string, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            Region region = new Region();
            string regionId = "";
            // Make the request
            Region response = regionsServiceClient.CreateRegion(parent, region, regionId);
            // End snippet
        }

        /// <summary>Snippet for CreateRegionAsync</summary>
        public async Task CreateRegionResourceNamesAsync()
        {
            // Snippet: CreateRegionAsync(AccountName, Region, string, CallSettings)
            // Additional: CreateRegionAsync(AccountName, Region, string, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            Region region = new Region();
            string regionId = "";
            // Make the request
            Region response = await regionsServiceClient.CreateRegionAsync(parent, region, regionId);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRegions</summary>
        public void BatchCreateRegionsRequestObject()
        {
            // Snippet: BatchCreateRegions(BatchCreateRegionsRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateRegionsRequest request = new BatchCreateRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new CreateRegionRequest(),
                },
            };
            // Make the request
            BatchCreateRegionsResponse response = regionsServiceClient.BatchCreateRegions(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRegionsAsync</summary>
        public async Task BatchCreateRegionsRequestObjectAsync()
        {
            // Snippet: BatchCreateRegionsAsync(BatchCreateRegionsRequest, CallSettings)
            // Additional: BatchCreateRegionsAsync(BatchCreateRegionsRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateRegionsRequest request = new BatchCreateRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new CreateRegionRequest(),
                },
            };
            // Make the request
            BatchCreateRegionsResponse response = await regionsServiceClient.BatchCreateRegionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegion</summary>
        public void UpdateRegionRequestObject()
        {
            // Snippet: UpdateRegion(UpdateRegionRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            UpdateRegionRequest request = new UpdateRegionRequest
            {
                Region = new Region(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Region response = regionsServiceClient.UpdateRegion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegionAsync</summary>
        public async Task UpdateRegionRequestObjectAsync()
        {
            // Snippet: UpdateRegionAsync(UpdateRegionRequest, CallSettings)
            // Additional: UpdateRegionAsync(UpdateRegionRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionRequest request = new UpdateRegionRequest
            {
                Region = new Region(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Region response = await regionsServiceClient.UpdateRegionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegion</summary>
        public void UpdateRegion()
        {
            // Snippet: UpdateRegion(Region, FieldMask, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            Region region = new Region();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Region response = regionsServiceClient.UpdateRegion(region, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegionAsync</summary>
        public async Task UpdateRegionAsync()
        {
            // Snippet: UpdateRegionAsync(Region, FieldMask, CallSettings)
            // Additional: UpdateRegionAsync(Region, FieldMask, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Region region = new Region();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Region response = await regionsServiceClient.UpdateRegionAsync(region, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateRegions</summary>
        public void BatchUpdateRegionsRequestObject()
        {
            // Snippet: BatchUpdateRegions(BatchUpdateRegionsRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateRegionsRequest request = new BatchUpdateRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateRegionRequest(),
                },
            };
            // Make the request
            BatchUpdateRegionsResponse response = regionsServiceClient.BatchUpdateRegions(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateRegionsAsync</summary>
        public async Task BatchUpdateRegionsRequestObjectAsync()
        {
            // Snippet: BatchUpdateRegionsAsync(BatchUpdateRegionsRequest, CallSettings)
            // Additional: BatchUpdateRegionsAsync(BatchUpdateRegionsRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateRegionsRequest request = new BatchUpdateRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateRegionRequest(),
                },
            };
            // Make the request
            BatchUpdateRegionsResponse response = await regionsServiceClient.BatchUpdateRegionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegion</summary>
        public void DeleteRegionRequestObject()
        {
            // Snippet: DeleteRegion(DeleteRegionRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            DeleteRegionRequest request = new DeleteRegionRequest
            {
                RegionName = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]"),
            };
            // Make the request
            regionsServiceClient.DeleteRegion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionAsync</summary>
        public async Task DeleteRegionRequestObjectAsync()
        {
            // Snippet: DeleteRegionAsync(DeleteRegionRequest, CallSettings)
            // Additional: DeleteRegionAsync(DeleteRegionRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionRequest request = new DeleteRegionRequest
            {
                RegionName = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]"),
            };
            // Make the request
            await regionsServiceClient.DeleteRegionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegion</summary>
        public void DeleteRegion()
        {
            // Snippet: DeleteRegion(string, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/regions/[REGION]";
            // Make the request
            regionsServiceClient.DeleteRegion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionAsync</summary>
        public async Task DeleteRegionAsync()
        {
            // Snippet: DeleteRegionAsync(string, CallSettings)
            // Additional: DeleteRegionAsync(string, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/regions/[REGION]";
            // Make the request
            await regionsServiceClient.DeleteRegionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegion</summary>
        public void DeleteRegionResourceNames()
        {
            // Snippet: DeleteRegion(RegionName, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            RegionName name = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]");
            // Make the request
            regionsServiceClient.DeleteRegion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionAsync</summary>
        public async Task DeleteRegionResourceNamesAsync()
        {
            // Snippet: DeleteRegionAsync(RegionName, CallSettings)
            // Additional: DeleteRegionAsync(RegionName, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegionName name = RegionName.FromAccountRegion("[ACCOUNT]", "[REGION]");
            // Make the request
            await regionsServiceClient.DeleteRegionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRegions</summary>
        public void BatchDeleteRegionsRequestObject()
        {
            // Snippet: BatchDeleteRegions(BatchDeleteRegionsRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteRegionsRequest request = new BatchDeleteRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteRegionRequest(),
                },
            };
            // Make the request
            regionsServiceClient.BatchDeleteRegions(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRegionsAsync</summary>
        public async Task BatchDeleteRegionsRequestObjectAsync()
        {
            // Snippet: BatchDeleteRegionsAsync(BatchDeleteRegionsRequest, CallSettings)
            // Additional: BatchDeleteRegionsAsync(BatchDeleteRegionsRequest, CancellationToken)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteRegionsRequest request = new BatchDeleteRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteRegionRequest(),
                },
            };
            // Make the request
            await regionsServiceClient.BatchDeleteRegionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListRegions</summary>
        public void ListRegionsRequestObject()
        {
            // Snippet: ListRegions(ListRegionsRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            ListRegionsRequest request = new ListRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListRegionsResponse, Region> response = regionsServiceClient.ListRegions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Region item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Region item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Region> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Region item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionsAsync</summary>
        public async Task ListRegionsRequestObjectAsync()
        {
            // Snippet: ListRegionsAsync(ListRegionsRequest, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionsRequest request = new ListRegionsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRegionsResponse, Region> response = regionsServiceClient.ListRegionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Region item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Region item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Region> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Region item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegions</summary>
        public void ListRegions()
        {
            // Snippet: ListRegions(string, string, int?, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListRegionsResponse, Region> response = regionsServiceClient.ListRegions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Region item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Region item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Region> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Region item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionsAsync</summary>
        public async Task ListRegionsAsync()
        {
            // Snippet: ListRegionsAsync(string, string, int?, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListRegionsResponse, Region> response = regionsServiceClient.ListRegionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Region item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Region item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Region> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Region item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegions</summary>
        public void ListRegionsResourceNames()
        {
            // Snippet: ListRegions(AccountName, string, int?, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = RegionsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListRegionsResponse, Region> response = regionsServiceClient.ListRegions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Region item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Region item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Region> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Region item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionsAsync</summary>
        public async Task ListRegionsResourceNamesAsync()
        {
            // Snippet: ListRegionsAsync(AccountName, string, int?, CallSettings)
            // Create client
            RegionsServiceClient regionsServiceClient = await RegionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListRegionsResponse, Region> response = regionsServiceClient.ListRegionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Region item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Region item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Region> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Region item in singlePage)
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
