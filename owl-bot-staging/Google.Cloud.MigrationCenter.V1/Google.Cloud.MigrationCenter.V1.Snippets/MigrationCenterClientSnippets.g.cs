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
    using Google.Cloud.MigrationCenter.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMigrationCenterClientSnippets
    {
        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsRequestObject()
        {
            // Snippet: ListAssets(ListAssetsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = AssetView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = migrationCenterClient.ListAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsRequestObjectAsync()
        {
            // Snippet: ListAssetsAsync(ListAssetsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = AssetView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = migrationCenterClient.ListAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssets()
        {
            // Snippet: ListAssets(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = migrationCenterClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsAsync()
        {
            // Snippet: ListAssetsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = migrationCenterClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsResourceNames()
        {
            // Snippet: ListAssets(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = migrationCenterClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsResourceNamesAsync()
        {
            // Snippet: ListAssetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = migrationCenterClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetRequestObject()
        {
            // Snippet: GetAsset(GetAssetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
                View = AssetView.Unspecified,
            };
            // Make the request
            Asset response = migrationCenterClient.GetAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetRequestObjectAsync()
        {
            // Snippet: GetAssetAsync(GetAssetRequest, CallSettings)
            // Additional: GetAssetAsync(GetAssetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
                View = AssetView.Unspecified,
            };
            // Make the request
            Asset response = await migrationCenterClient.GetAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAsset()
        {
            // Snippet: GetAsset(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/assets/[ASSET]";
            // Make the request
            Asset response = migrationCenterClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetAsync()
        {
            // Snippet: GetAssetAsync(string, CallSettings)
            // Additional: GetAssetAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/assets/[ASSET]";
            // Make the request
            Asset response = await migrationCenterClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetResourceNames()
        {
            // Snippet: GetAsset(AssetName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]");
            // Make the request
            Asset response = migrationCenterClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetResourceNamesAsync()
        {
            // Snippet: GetAssetAsync(AssetName, CallSettings)
            // Additional: GetAssetAsync(AssetName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]");
            // Make the request
            Asset response = await migrationCenterClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAssetRequestObject()
        {
            // Snippet: UpdateAsset(UpdateAssetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            UpdateAssetRequest request = new UpdateAssetRequest
            {
                UpdateMask = new FieldMask(),
                Asset = new Asset(),
                RequestId = "",
            };
            // Make the request
            Asset response = migrationCenterClient.UpdateAsset(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetRequestObjectAsync()
        {
            // Snippet: UpdateAssetAsync(UpdateAssetRequest, CallSettings)
            // Additional: UpdateAssetAsync(UpdateAssetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAssetRequest request = new UpdateAssetRequest
            {
                UpdateMask = new FieldMask(),
                Asset = new Asset(),
                RequestId = "",
            };
            // Make the request
            Asset response = await migrationCenterClient.UpdateAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAsset()
        {
            // Snippet: UpdateAsset(Asset, FieldMask, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            Asset asset = new Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Asset response = migrationCenterClient.UpdateAsset(asset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetAsync()
        {
            // Snippet: UpdateAssetAsync(Asset, FieldMask, CallSettings)
            // Additional: UpdateAssetAsync(Asset, FieldMask, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            Asset asset = new Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Asset response = await migrationCenterClient.UpdateAssetAsync(asset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAssets</summary>
        public void BatchUpdateAssetsRequestObject()
        {
            // Snippet: BatchUpdateAssets(BatchUpdateAssetsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            BatchUpdateAssetsRequest request = new BatchUpdateAssetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Requests =
                {
                    new UpdateAssetRequest(),
                },
            };
            // Make the request
            BatchUpdateAssetsResponse response = migrationCenterClient.BatchUpdateAssets(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAssetsAsync</summary>
        public async Task BatchUpdateAssetsRequestObjectAsync()
        {
            // Snippet: BatchUpdateAssetsAsync(BatchUpdateAssetsRequest, CallSettings)
            // Additional: BatchUpdateAssetsAsync(BatchUpdateAssetsRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateAssetsRequest request = new BatchUpdateAssetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Requests =
                {
                    new UpdateAssetRequest(),
                },
            };
            // Make the request
            BatchUpdateAssetsResponse response = await migrationCenterClient.BatchUpdateAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAssets</summary>
        public void BatchUpdateAssets()
        {
            // Snippet: BatchUpdateAssets(string, IEnumerable<UpdateAssetRequest>, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<UpdateAssetRequest> requests = new UpdateAssetRequest[]
            {
                new UpdateAssetRequest(),
            };
            // Make the request
            BatchUpdateAssetsResponse response = migrationCenterClient.BatchUpdateAssets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAssetsAsync</summary>
        public async Task BatchUpdateAssetsAsync()
        {
            // Snippet: BatchUpdateAssetsAsync(string, IEnumerable<UpdateAssetRequest>, CallSettings)
            // Additional: BatchUpdateAssetsAsync(string, IEnumerable<UpdateAssetRequest>, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<UpdateAssetRequest> requests = new UpdateAssetRequest[]
            {
                new UpdateAssetRequest(),
            };
            // Make the request
            BatchUpdateAssetsResponse response = await migrationCenterClient.BatchUpdateAssetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAssets</summary>
        public void BatchUpdateAssetsResourceNames()
        {
            // Snippet: BatchUpdateAssets(LocationName, IEnumerable<UpdateAssetRequest>, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<UpdateAssetRequest> requests = new UpdateAssetRequest[]
            {
                new UpdateAssetRequest(),
            };
            // Make the request
            BatchUpdateAssetsResponse response = migrationCenterClient.BatchUpdateAssets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAssetsAsync</summary>
        public async Task BatchUpdateAssetsResourceNamesAsync()
        {
            // Snippet: BatchUpdateAssetsAsync(LocationName, IEnumerable<UpdateAssetRequest>, CallSettings)
            // Additional: BatchUpdateAssetsAsync(LocationName, IEnumerable<UpdateAssetRequest>, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<UpdateAssetRequest> requests = new UpdateAssetRequest[]
            {
                new UpdateAssetRequest(),
            };
            // Make the request
            BatchUpdateAssetsResponse response = await migrationCenterClient.BatchUpdateAssetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetRequestObject()
        {
            // Snippet: DeleteAsset(DeleteAssetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteAssetRequest request = new DeleteAssetRequest
            {
                AssetName = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
                RequestId = "",
            };
            // Make the request
            migrationCenterClient.DeleteAsset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetRequestObjectAsync()
        {
            // Snippet: DeleteAssetAsync(DeleteAssetRequest, CallSettings)
            // Additional: DeleteAssetAsync(DeleteAssetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAssetRequest request = new DeleteAssetRequest
            {
                AssetName = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
                RequestId = "",
            };
            // Make the request
            await migrationCenterClient.DeleteAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAsset()
        {
            // Snippet: DeleteAsset(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/assets/[ASSET]";
            // Make the request
            migrationCenterClient.DeleteAsset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetAsync()
        {
            // Snippet: DeleteAssetAsync(string, CallSettings)
            // Additional: DeleteAssetAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/assets/[ASSET]";
            // Make the request
            await migrationCenterClient.DeleteAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetResourceNames()
        {
            // Snippet: DeleteAsset(AssetName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]");
            // Make the request
            migrationCenterClient.DeleteAsset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetResourceNamesAsync()
        {
            // Snippet: DeleteAssetAsync(AssetName, CallSettings)
            // Additional: DeleteAssetAsync(AssetName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]");
            // Make the request
            await migrationCenterClient.DeleteAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAssets</summary>
        public void BatchDeleteAssetsRequestObject()
        {
            // Snippet: BatchDeleteAssets(BatchDeleteAssetsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            BatchDeleteAssetsRequest request = new BatchDeleteAssetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AssetNames =
                {
                    AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
                },
                AllowMissing = false,
            };
            // Make the request
            migrationCenterClient.BatchDeleteAssets(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAssetsAsync</summary>
        public async Task BatchDeleteAssetsRequestObjectAsync()
        {
            // Snippet: BatchDeleteAssetsAsync(BatchDeleteAssetsRequest, CallSettings)
            // Additional: BatchDeleteAssetsAsync(BatchDeleteAssetsRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteAssetsRequest request = new BatchDeleteAssetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AssetNames =
                {
                    AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
                },
                AllowMissing = false,
            };
            // Make the request
            await migrationCenterClient.BatchDeleteAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAssets</summary>
        public void BatchDeleteAssets()
        {
            // Snippet: BatchDeleteAssets(string, IEnumerable<string>, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/assets/[ASSET]",
            };
            // Make the request
            migrationCenterClient.BatchDeleteAssets(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAssetsAsync</summary>
        public async Task BatchDeleteAssetsAsync()
        {
            // Snippet: BatchDeleteAssetsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteAssetsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/assets/[ASSET]",
            };
            // Make the request
            await migrationCenterClient.BatchDeleteAssetsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAssets</summary>
        public void BatchDeleteAssetsResourceNames()
        {
            // Snippet: BatchDeleteAssets(LocationName, IEnumerable<AssetName>, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<AssetName> names = new AssetName[]
            {
                AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
            };
            // Make the request
            migrationCenterClient.BatchDeleteAssets(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAssetsAsync</summary>
        public async Task BatchDeleteAssetsResourceNamesAsync()
        {
            // Snippet: BatchDeleteAssetsAsync(LocationName, IEnumerable<AssetName>, CallSettings)
            // Additional: BatchDeleteAssetsAsync(LocationName, IEnumerable<AssetName>, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<AssetName> names = new AssetName[]
            {
                AssetName.FromProjectLocationAsset("[PROJECT]", "[LOCATION]", "[ASSET]"),
            };
            // Make the request
            await migrationCenterClient.BatchDeleteAssetsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ReportAssetFrames</summary>
        public void ReportAssetFramesRequestObject()
        {
            // Snippet: ReportAssetFrames(ReportAssetFramesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportAssetFramesRequest request = new ReportAssetFramesRequest
            {
                Parent = "",
                Frames = new Frames(),
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            // Make the request
            ReportAssetFramesResponse response = migrationCenterClient.ReportAssetFrames(request);
            // End snippet
        }

        /// <summary>Snippet for ReportAssetFramesAsync</summary>
        public async Task ReportAssetFramesRequestObjectAsync()
        {
            // Snippet: ReportAssetFramesAsync(ReportAssetFramesRequest, CallSettings)
            // Additional: ReportAssetFramesAsync(ReportAssetFramesRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportAssetFramesRequest request = new ReportAssetFramesRequest
            {
                Parent = "",
                Frames = new Frames(),
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            // Make the request
            ReportAssetFramesResponse response = await migrationCenterClient.ReportAssetFramesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregateAssetsValues</summary>
        public void AggregateAssetsValuesRequestObject()
        {
            // Snippet: AggregateAssetsValues(AggregateAssetsValuesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            AggregateAssetsValuesRequest request = new AggregateAssetsValuesRequest
            {
                Parent = "",
                Aggregations = { new Aggregation(), },
                Filter = "",
            };
            // Make the request
            AggregateAssetsValuesResponse response = migrationCenterClient.AggregateAssetsValues(request);
            // End snippet
        }

        /// <summary>Snippet for AggregateAssetsValuesAsync</summary>
        public async Task AggregateAssetsValuesRequestObjectAsync()
        {
            // Snippet: AggregateAssetsValuesAsync(AggregateAssetsValuesRequest, CallSettings)
            // Additional: AggregateAssetsValuesAsync(AggregateAssetsValuesRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            AggregateAssetsValuesRequest request = new AggregateAssetsValuesRequest
            {
                Parent = "",
                Aggregations = { new Aggregation(), },
                Filter = "",
            };
            // Make the request
            AggregateAssetsValuesResponse response = await migrationCenterClient.AggregateAssetsValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJobRequestObject()
        {
            // Snippet: CreateImportJob(CreateImportJobRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ImportJobId = "",
                ImportJob = new ImportJob(),
                RequestId = "",
            };
            // Make the request
            Operation<ImportJob, OperationMetadata> response = migrationCenterClient.CreateImportJob(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobRequestObjectAsync()
        {
            // Snippet: CreateImportJobAsync(CreateImportJobRequest, CallSettings)
            // Additional: CreateImportJobAsync(CreateImportJobRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ImportJobId = "",
                ImportJob = new ImportJob(),
                RequestId = "",
            };
            // Make the request
            Operation<ImportJob, OperationMetadata> response = await migrationCenterClient.CreateImportJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob()
        {
            // Snippet: CreateImportJob(string, ImportJob, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ImportJob importJob = new ImportJob();
            string importJobId = "";
            // Make the request
            Operation<ImportJob, OperationMetadata> response = migrationCenterClient.CreateImportJob(parent, importJob, importJobId);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync()
        {
            // Snippet: CreateImportJobAsync(string, ImportJob, string, CallSettings)
            // Additional: CreateImportJobAsync(string, ImportJob, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ImportJob importJob = new ImportJob();
            string importJobId = "";
            // Make the request
            Operation<ImportJob, OperationMetadata> response = await migrationCenterClient.CreateImportJobAsync(parent, importJob, importJobId);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJobResourceNames()
        {
            // Snippet: CreateImportJob(LocationName, ImportJob, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ImportJob importJob = new ImportJob();
            string importJobId = "";
            // Make the request
            Operation<ImportJob, OperationMetadata> response = migrationCenterClient.CreateImportJob(parent, importJob, importJobId);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobResourceNamesAsync()
        {
            // Snippet: CreateImportJobAsync(LocationName, ImportJob, string, CallSettings)
            // Additional: CreateImportJobAsync(LocationName, ImportJob, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ImportJob importJob = new ImportJob();
            string importJobId = "";
            // Make the request
            Operation<ImportJob, OperationMetadata> response = await migrationCenterClient.CreateImportJobAsync(parent, importJob, importJobId);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobsRequestObject()
        {
            // Snippet: ListImportJobs(ListImportJobsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = ImportJobView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = migrationCenterClient.ListImportJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsRequestObjectAsync()
        {
            // Snippet: ListImportJobsAsync(ListImportJobsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = ImportJobView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = migrationCenterClient.ListImportJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs()
        {
            // Snippet: ListImportJobs(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = migrationCenterClient.ListImportJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsAsync()
        {
            // Snippet: ListImportJobsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = migrationCenterClient.ListImportJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobsResourceNames()
        {
            // Snippet: ListImportJobs(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = migrationCenterClient.ListImportJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobsAsync</summary>
        public async Task ListImportJobsResourceNamesAsync()
        {
            // Snippet: ListImportJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = migrationCenterClient.ListImportJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJobRequestObject()
        {
            // Snippet: GetImportJob(GetImportJobRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                View = ImportJobView.Unspecified,
            };
            // Make the request
            ImportJob response = migrationCenterClient.GetImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobRequestObjectAsync()
        {
            // Snippet: GetImportJobAsync(GetImportJobRequest, CallSettings)
            // Additional: GetImportJobAsync(GetImportJobRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                View = ImportJobView.Unspecified,
            };
            // Make the request
            ImportJob response = await migrationCenterClient.GetImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJob()
        {
            // Snippet: GetImportJob(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            ImportJob response = migrationCenterClient.GetImportJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobAsync()
        {
            // Snippet: GetImportJobAsync(string, CallSettings)
            // Additional: GetImportJobAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            ImportJob response = await migrationCenterClient.GetImportJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJobResourceNames()
        {
            // Snippet: GetImportJob(ImportJobName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            ImportJob response = migrationCenterClient.GetImportJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobResourceNamesAsync()
        {
            // Snippet: GetImportJobAsync(ImportJobName, CallSettings)
            // Additional: GetImportJobAsync(ImportJobName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            ImportJob response = await migrationCenterClient.GetImportJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteImportJob</summary>
        public void DeleteImportJobRequestObject()
        {
            // Snippet: DeleteImportJob(DeleteImportJobRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteImportJobRequest request = new DeleteImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteImportJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportJobAsync</summary>
        public async Task DeleteImportJobRequestObjectAsync()
        {
            // Snippet: DeleteImportJobAsync(DeleteImportJobRequest, CallSettings)
            // Additional: DeleteImportJobAsync(DeleteImportJobRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteImportJobRequest request = new DeleteImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteImportJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportJob</summary>
        public void DeleteImportJob()
        {
            // Snippet: DeleteImportJob(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteImportJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportJobAsync</summary>
        public async Task DeleteImportJobAsync()
        {
            // Snippet: DeleteImportJobAsync(string, CallSettings)
            // Additional: DeleteImportJobAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteImportJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportJob</summary>
        public void DeleteImportJobResourceNames()
        {
            // Snippet: DeleteImportJob(ImportJobName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteImportJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportJobAsync</summary>
        public async Task DeleteImportJobResourceNamesAsync()
        {
            // Snippet: DeleteImportJobAsync(ImportJobName, CallSettings)
            // Additional: DeleteImportJobAsync(ImportJobName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteImportJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateImportJob</summary>
        public void UpdateImportJobRequestObject()
        {
            // Snippet: UpdateImportJob(UpdateImportJobRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            UpdateImportJobRequest request = new UpdateImportJobRequest
            {
                UpdateMask = new FieldMask(),
                ImportJob = new ImportJob(),
                RequestId = "",
            };
            // Make the request
            Operation<ImportJob, OperationMetadata> response = migrationCenterClient.UpdateImportJob(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateImportJobAsync</summary>
        public async Task UpdateImportJobRequestObjectAsync()
        {
            // Snippet: UpdateImportJobAsync(UpdateImportJobRequest, CallSettings)
            // Additional: UpdateImportJobAsync(UpdateImportJobRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateImportJobRequest request = new UpdateImportJobRequest
            {
                UpdateMask = new FieldMask(),
                ImportJob = new ImportJob(),
                RequestId = "",
            };
            // Make the request
            Operation<ImportJob, OperationMetadata> response = await migrationCenterClient.UpdateImportJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateImportJob</summary>
        public void UpdateImportJob()
        {
            // Snippet: UpdateImportJob(ImportJob, FieldMask, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJob importJob = new ImportJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ImportJob, OperationMetadata> response = migrationCenterClient.UpdateImportJob(importJob, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateImportJobAsync</summary>
        public async Task UpdateImportJobAsync()
        {
            // Snippet: UpdateImportJobAsync(ImportJob, FieldMask, CallSettings)
            // Additional: UpdateImportJobAsync(ImportJob, FieldMask, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJob importJob = new ImportJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ImportJob, OperationMetadata> response = await migrationCenterClient.UpdateImportJobAsync(importJob, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ImportJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportJob, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateImportJob</summary>
        public void ValidateImportJobRequestObject()
        {
            // Snippet: ValidateImportJob(ValidateImportJobRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ValidateImportJobRequest request = new ValidateImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.ValidateImportJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceValidateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateImportJobAsync</summary>
        public async Task ValidateImportJobRequestObjectAsync()
        {
            // Snippet: ValidateImportJobAsync(ValidateImportJobRequest, CallSettings)
            // Additional: ValidateImportJobAsync(ValidateImportJobRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ValidateImportJobRequest request = new ValidateImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.ValidateImportJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceValidateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateImportJob</summary>
        public void ValidateImportJob()
        {
            // Snippet: ValidateImportJob(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.ValidateImportJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceValidateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateImportJobAsync</summary>
        public async Task ValidateImportJobAsync()
        {
            // Snippet: ValidateImportJobAsync(string, CallSettings)
            // Additional: ValidateImportJobAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.ValidateImportJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceValidateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateImportJob</summary>
        public void ValidateImportJobResourceNames()
        {
            // Snippet: ValidateImportJob(ImportJobName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.ValidateImportJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceValidateImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateImportJobAsync</summary>
        public async Task ValidateImportJobResourceNamesAsync()
        {
            // Snippet: ValidateImportJobAsync(ImportJobName, CallSettings)
            // Additional: ValidateImportJobAsync(ImportJobName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.ValidateImportJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceValidateImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunImportJob</summary>
        public void RunImportJobRequestObject()
        {
            // Snippet: RunImportJob(RunImportJobRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            RunImportJobRequest request = new RunImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.RunImportJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceRunImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunImportJobAsync</summary>
        public async Task RunImportJobRequestObjectAsync()
        {
            // Snippet: RunImportJobAsync(RunImportJobRequest, CallSettings)
            // Additional: RunImportJobAsync(RunImportJobRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            RunImportJobRequest request = new RunImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.RunImportJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceRunImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunImportJob</summary>
        public void RunImportJob()
        {
            // Snippet: RunImportJob(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.RunImportJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceRunImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunImportJobAsync</summary>
        public async Task RunImportJobAsync()
        {
            // Snippet: RunImportJobAsync(string, CallSettings)
            // Additional: RunImportJobAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.RunImportJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceRunImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunImportJob</summary>
        public void RunImportJobResourceNames()
        {
            // Snippet: RunImportJob(ImportJobName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.RunImportJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceRunImportJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunImportJobAsync</summary>
        public async Task RunImportJobResourceNamesAsync()
        {
            // Snippet: RunImportJobAsync(ImportJobName, CallSettings)
            // Additional: RunImportJobAsync(ImportJobName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName name = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.RunImportJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceRunImportJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetImportDataFile</summary>
        public void GetImportDataFileRequestObject()
        {
            // Snippet: GetImportDataFile(GetImportDataFileRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetImportDataFileRequest request = new GetImportDataFileRequest
            {
                ImportDataFileName = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]"),
            };
            // Make the request
            ImportDataFile response = migrationCenterClient.GetImportDataFile(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportDataFileAsync</summary>
        public async Task GetImportDataFileRequestObjectAsync()
        {
            // Snippet: GetImportDataFileAsync(GetImportDataFileRequest, CallSettings)
            // Additional: GetImportDataFileAsync(GetImportDataFileRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetImportDataFileRequest request = new GetImportDataFileRequest
            {
                ImportDataFileName = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]"),
            };
            // Make the request
            ImportDataFile response = await migrationCenterClient.GetImportDataFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportDataFile</summary>
        public void GetImportDataFile()
        {
            // Snippet: GetImportDataFile(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]/importDataFiles/[IMPORT_DATA_FILE]";
            // Make the request
            ImportDataFile response = migrationCenterClient.GetImportDataFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportDataFileAsync</summary>
        public async Task GetImportDataFileAsync()
        {
            // Snippet: GetImportDataFileAsync(string, CallSettings)
            // Additional: GetImportDataFileAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]/importDataFiles/[IMPORT_DATA_FILE]";
            // Make the request
            ImportDataFile response = await migrationCenterClient.GetImportDataFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportDataFile</summary>
        public void GetImportDataFileResourceNames()
        {
            // Snippet: GetImportDataFile(ImportDataFileName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportDataFileName name = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]");
            // Make the request
            ImportDataFile response = migrationCenterClient.GetImportDataFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetImportDataFileAsync</summary>
        public async Task GetImportDataFileResourceNamesAsync()
        {
            // Snippet: GetImportDataFileAsync(ImportDataFileName, CallSettings)
            // Additional: GetImportDataFileAsync(ImportDataFileName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataFileName name = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]");
            // Make the request
            ImportDataFile response = await migrationCenterClient.GetImportDataFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListImportDataFiles</summary>
        public void ListImportDataFilesRequestObject()
        {
            // Snippet: ListImportDataFiles(ListImportDataFilesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListImportDataFilesRequest request = new ListImportDataFilesRequest
            {
                ParentAsImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> response = migrationCenterClient.ListImportDataFiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportDataFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportDataFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportDataFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportDataFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportDataFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportDataFilesAsync</summary>
        public async Task ListImportDataFilesRequestObjectAsync()
        {
            // Snippet: ListImportDataFilesAsync(ListImportDataFilesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListImportDataFilesRequest request = new ListImportDataFilesRequest
            {
                ParentAsImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> response = migrationCenterClient.ListImportDataFilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportDataFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportDataFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportDataFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportDataFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportDataFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportDataFiles</summary>
        public void ListImportDataFiles()
        {
            // Snippet: ListImportDataFiles(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> response = migrationCenterClient.ListImportDataFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportDataFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportDataFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportDataFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportDataFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportDataFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportDataFilesAsync</summary>
        public async Task ListImportDataFilesAsync()
        {
            // Snippet: ListImportDataFilesAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            // Make the request
            PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> response = migrationCenterClient.ListImportDataFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportDataFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportDataFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportDataFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportDataFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportDataFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportDataFiles</summary>
        public void ListImportDataFilesResourceNames()
        {
            // Snippet: ListImportDataFiles(ImportJobName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJobName parent = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> response = migrationCenterClient.ListImportDataFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportDataFile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportDataFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportDataFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportDataFile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportDataFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportDataFilesAsync</summary>
        public async Task ListImportDataFilesResourceNamesAsync()
        {
            // Snippet: ListImportDataFilesAsync(ImportJobName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName parent = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            // Make the request
            PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> response = migrationCenterClient.ListImportDataFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportDataFile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportDataFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportDataFile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportDataFile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportDataFile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateImportDataFile</summary>
        public void CreateImportDataFileRequestObject()
        {
            // Snippet: CreateImportDataFile(CreateImportDataFileRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreateImportDataFileRequest request = new CreateImportDataFileRequest
            {
                ParentAsImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                ImportDataFileId = "",
                ImportDataFile = new ImportDataFile(),
                RequestId = "",
            };
            // Make the request
            Operation<ImportDataFile, OperationMetadata> response = migrationCenterClient.CreateImportDataFile(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataFile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataFile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataFile, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateImportDataFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataFile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportDataFileAsync</summary>
        public async Task CreateImportDataFileRequestObjectAsync()
        {
            // Snippet: CreateImportDataFileAsync(CreateImportDataFileRequest, CallSettings)
            // Additional: CreateImportDataFileAsync(CreateImportDataFileRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateImportDataFileRequest request = new CreateImportDataFileRequest
            {
                ParentAsImportJobName = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]"),
                ImportDataFileId = "",
                ImportDataFile = new ImportDataFile(),
                RequestId = "",
            };
            // Make the request
            Operation<ImportDataFile, OperationMetadata> response = await migrationCenterClient.CreateImportDataFileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataFile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataFile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataFile, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateImportDataFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataFile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportDataFile</summary>
        public void CreateImportDataFile()
        {
            // Snippet: CreateImportDataFile(string, ImportDataFile, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            ImportDataFile importDataFile = new ImportDataFile();
            string importDataFileId = "";
            // Make the request
            Operation<ImportDataFile, OperationMetadata> response = migrationCenterClient.CreateImportDataFile(parent, importDataFile, importDataFileId);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataFile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataFile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataFile, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateImportDataFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataFile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportDataFileAsync</summary>
        public async Task CreateImportDataFileAsync()
        {
            // Snippet: CreateImportDataFileAsync(string, ImportDataFile, string, CallSettings)
            // Additional: CreateImportDataFileAsync(string, ImportDataFile, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]";
            ImportDataFile importDataFile = new ImportDataFile();
            string importDataFileId = "";
            // Make the request
            Operation<ImportDataFile, OperationMetadata> response = await migrationCenterClient.CreateImportDataFileAsync(parent, importDataFile, importDataFileId);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataFile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataFile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataFile, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateImportDataFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataFile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportDataFile</summary>
        public void CreateImportDataFileResourceNames()
        {
            // Snippet: CreateImportDataFile(ImportJobName, ImportDataFile, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportJobName parent = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            ImportDataFile importDataFile = new ImportDataFile();
            string importDataFileId = "";
            // Make the request
            Operation<ImportDataFile, OperationMetadata> response = migrationCenterClient.CreateImportDataFile(parent, importDataFile, importDataFileId);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataFile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataFile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataFile, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateImportDataFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataFile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateImportDataFileAsync</summary>
        public async Task CreateImportDataFileResourceNamesAsync()
        {
            // Snippet: CreateImportDataFileAsync(ImportJobName, ImportDataFile, string, CallSettings)
            // Additional: CreateImportDataFileAsync(ImportJobName, ImportDataFile, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportJobName parent = ImportJobName.FromProjectLocationImportJob("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]");
            ImportDataFile importDataFile = new ImportDataFile();
            string importDataFileId = "";
            // Make the request
            Operation<ImportDataFile, OperationMetadata> response = await migrationCenterClient.CreateImportDataFileAsync(parent, importDataFile, importDataFileId);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataFile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataFile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataFile, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateImportDataFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataFile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportDataFile</summary>
        public void DeleteImportDataFileRequestObject()
        {
            // Snippet: DeleteImportDataFile(DeleteImportDataFileRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteImportDataFileRequest request = new DeleteImportDataFileRequest
            {
                ImportDataFileName = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteImportDataFile(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteImportDataFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportDataFileAsync</summary>
        public async Task DeleteImportDataFileRequestObjectAsync()
        {
            // Snippet: DeleteImportDataFileAsync(DeleteImportDataFileRequest, CallSettings)
            // Additional: DeleteImportDataFileAsync(DeleteImportDataFileRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteImportDataFileRequest request = new DeleteImportDataFileRequest
            {
                ImportDataFileName = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteImportDataFileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteImportDataFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportDataFile</summary>
        public void DeleteImportDataFile()
        {
            // Snippet: DeleteImportDataFile(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]/importDataFiles/[IMPORT_DATA_FILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteImportDataFile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteImportDataFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportDataFileAsync</summary>
        public async Task DeleteImportDataFileAsync()
        {
            // Snippet: DeleteImportDataFileAsync(string, CallSettings)
            // Additional: DeleteImportDataFileAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/importJobs/[IMPORT_JOB]/importDataFiles/[IMPORT_DATA_FILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteImportDataFileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteImportDataFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportDataFile</summary>
        public void DeleteImportDataFileResourceNames()
        {
            // Snippet: DeleteImportDataFile(ImportDataFileName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ImportDataFileName name = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteImportDataFile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteImportDataFile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteImportDataFileAsync</summary>
        public async Task DeleteImportDataFileResourceNamesAsync()
        {
            // Snippet: DeleteImportDataFileAsync(ImportDataFileName, CallSettings)
            // Additional: DeleteImportDataFileAsync(ImportDataFileName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataFileName name = ImportDataFileName.FromProjectLocationImportJobImportDataFile("[PROJECT]", "[LOCATION]", "[IMPORT_JOB]", "[IMPORT_DATA_FILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteImportDataFileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteImportDataFileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsRequestObject()
        {
            // Snippet: ListGroups(ListGroupsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = migrationCenterClient.ListGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsRequestObjectAsync()
        {
            // Snippet: ListGroupsAsync(ListGroupsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = migrationCenterClient.ListGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroups()
        {
            // Snippet: ListGroups(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = migrationCenterClient.ListGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsAsync()
        {
            // Snippet: ListGroupsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = migrationCenterClient.ListGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames()
        {
            // Snippet: ListGroups(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = migrationCenterClient.ListGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNamesAsync()
        {
            // Snippet: ListGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = migrationCenterClient.ListGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupRequestObject()
        {
            // Snippet: GetGroup(GetGroupRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            // Make the request
            Group response = migrationCenterClient.GetGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupRequestObjectAsync()
        {
            // Snippet: GetGroupAsync(GetGroupRequest, CallSettings)
            // Additional: GetGroupAsync(GetGroupRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            // Make the request
            Group response = await migrationCenterClient.GetGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup()
        {
            // Snippet: GetGroup(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Group response = migrationCenterClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(string, CallSettings)
            // Additional: GetGroupAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Group response = await migrationCenterClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupResourceNames()
        {
            // Snippet: GetGroup(GroupName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Group response = migrationCenterClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupResourceNamesAsync()
        {
            // Snippet: GetGroupAsync(GroupName, CallSettings)
            // Additional: GetGroupAsync(GroupName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Group response = await migrationCenterClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupRequestObject()
        {
            // Snippet: CreateGroup(CreateGroupRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreateGroupRequest request = new CreateGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GroupId = "",
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.CreateGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupRequestObjectAsync()
        {
            // Snippet: CreateGroupAsync(CreateGroupRequest, CallSettings)
            // Additional: CreateGroupAsync(CreateGroupRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateGroupRequest request = new CreateGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GroupId = "",
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.CreateGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroup()
        {
            // Snippet: CreateGroup(string, Group, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.CreateGroup(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupAsync()
        {
            // Snippet: CreateGroupAsync(string, Group, string, CallSettings)
            // Additional: CreateGroupAsync(string, Group, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.CreateGroupAsync(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupResourceNames()
        {
            // Snippet: CreateGroup(LocationName, Group, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.CreateGroup(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupResourceNamesAsync()
        {
            // Snippet: CreateGroupAsync(LocationName, Group, string, CallSettings)
            // Additional: CreateGroupAsync(LocationName, Group, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Group group = new Group();
            string groupId = "";
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.CreateGroupAsync(parent, group, groupId);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroupRequestObject()
        {
            // Snippet: UpdateGroup(UpdateGroupRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                UpdateMask = new FieldMask(),
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.UpdateGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupRequestObjectAsync()
        {
            // Snippet: UpdateGroupAsync(UpdateGroupRequest, CallSettings)
            // Additional: UpdateGroupAsync(UpdateGroupRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                UpdateMask = new FieldMask(),
                Group = new Group(),
                RequestId = "",
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.UpdateGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(Group, FieldMask, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            Group group = new Group();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.UpdateGroup(group, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(Group, FieldMask, CallSettings)
            // Additional: UpdateGroupAsync(Group, FieldMask, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            Group group = new Group();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.UpdateGroupAsync(group, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupRequestObject()
        {
            // Snippet: DeleteGroup(DeleteGroupRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupRequestObjectAsync()
        {
            // Snippet: DeleteGroupAsync(DeleteGroupRequest, CallSettings)
            // Additional: DeleteGroupAsync(DeleteGroupRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroup()
        {
            // Snippet: DeleteGroup(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupAsync()
        {
            // Snippet: DeleteGroupAsync(string, CallSettings)
            // Additional: DeleteGroupAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupResourceNames()
        {
            // Snippet: DeleteGroup(GroupName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupResourceNamesAsync()
        {
            // Snippet: DeleteGroupAsync(GroupName, CallSettings)
            // Additional: DeleteGroupAsync(GroupName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssetsToGroup</summary>
        public void AddAssetsToGroupRequestObject()
        {
            // Snippet: AddAssetsToGroup(AddAssetsToGroupRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            AddAssetsToGroupRequest request = new AddAssetsToGroupRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
                Assets = new AssetList(),
                AllowExisting = false,
            };
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.AddAssetsToGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceAddAssetsToGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssetsToGroupAsync</summary>
        public async Task AddAssetsToGroupRequestObjectAsync()
        {
            // Snippet: AddAssetsToGroupAsync(AddAssetsToGroupRequest, CallSettings)
            // Additional: AddAssetsToGroupAsync(AddAssetsToGroupRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            AddAssetsToGroupRequest request = new AddAssetsToGroupRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
                Assets = new AssetList(),
                AllowExisting = false,
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.AddAssetsToGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceAddAssetsToGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssetsToGroup</summary>
        public void AddAssetsToGroup()
        {
            // Snippet: AddAssetsToGroup(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.AddAssetsToGroup(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceAddAssetsToGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssetsToGroupAsync</summary>
        public async Task AddAssetsToGroupAsync()
        {
            // Snippet: AddAssetsToGroupAsync(string, CallSettings)
            // Additional: AddAssetsToGroupAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.AddAssetsToGroupAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceAddAssetsToGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssetsToGroup</summary>
        public void AddAssetsToGroupResourceNames()
        {
            // Snippet: AddAssetsToGroup(GroupName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.AddAssetsToGroup(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceAddAssetsToGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssetsToGroupAsync</summary>
        public async Task AddAssetsToGroupResourceNamesAsync()
        {
            // Snippet: AddAssetsToGroupAsync(GroupName, CallSettings)
            // Additional: AddAssetsToGroupAsync(GroupName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.AddAssetsToGroupAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceAddAssetsToGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssetsFromGroup</summary>
        public void RemoveAssetsFromGroupRequestObject()
        {
            // Snippet: RemoveAssetsFromGroup(RemoveAssetsFromGroupRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            RemoveAssetsFromGroupRequest request = new RemoveAssetsFromGroupRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
                Assets = new AssetList(),
                AllowMissing = false,
            };
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.RemoveAssetsFromGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceRemoveAssetsFromGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssetsFromGroupAsync</summary>
        public async Task RemoveAssetsFromGroupRequestObjectAsync()
        {
            // Snippet: RemoveAssetsFromGroupAsync(RemoveAssetsFromGroupRequest, CallSettings)
            // Additional: RemoveAssetsFromGroupAsync(RemoveAssetsFromGroupRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAssetsFromGroupRequest request = new RemoveAssetsFromGroupRequest
            {
                GroupAsGroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                RequestId = "",
                Assets = new AssetList(),
                AllowMissing = false,
            };
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.RemoveAssetsFromGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceRemoveAssetsFromGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssetsFromGroup</summary>
        public void RemoveAssetsFromGroup()
        {
            // Snippet: RemoveAssetsFromGroup(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.RemoveAssetsFromGroup(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceRemoveAssetsFromGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssetsFromGroupAsync</summary>
        public async Task RemoveAssetsFromGroupAsync()
        {
            // Snippet: RemoveAssetsFromGroupAsync(string, CallSettings)
            // Additional: RemoveAssetsFromGroupAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string group = "projects/[PROJECT]/locations/[LOCATION]/groups/[GROUP]";
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.RemoveAssetsFromGroupAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceRemoveAssetsFromGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssetsFromGroup</summary>
        public void RemoveAssetsFromGroupResourceNames()
        {
            // Snippet: RemoveAssetsFromGroup(GroupName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Group, OperationMetadata> response = migrationCenterClient.RemoveAssetsFromGroup(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceRemoveAssetsFromGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssetsFromGroupAsync</summary>
        public async Task RemoveAssetsFromGroupResourceNamesAsync()
        {
            // Snippet: RemoveAssetsFromGroupAsync(GroupName, CallSettings)
            // Additional: RemoveAssetsFromGroupAsync(GroupName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupName group = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]");
            // Make the request
            Operation<Group, OperationMetadata> response = await migrationCenterClient.RemoveAssetsFromGroupAsync(group);

            // Poll until the returned long-running operation is complete
            Operation<Group, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Group result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Group, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceRemoveAssetsFromGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Group retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListErrorFrames</summary>
        public void ListErrorFramesRequestObject()
        {
            // Snippet: ListErrorFrames(ListErrorFramesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListErrorFramesRequest request = new ListErrorFramesRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                View = ErrorFrameView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListErrorFramesResponse, ErrorFrame> response = migrationCenterClient.ListErrorFrames(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorFrame item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListErrorFramesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorFrame item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorFrame> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorFrame item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorFramesAsync</summary>
        public async Task ListErrorFramesRequestObjectAsync()
        {
            // Snippet: ListErrorFramesAsync(ListErrorFramesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListErrorFramesRequest request = new ListErrorFramesRequest
            {
                ParentAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                View = ErrorFrameView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> response = migrationCenterClient.ListErrorFramesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorFrame item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListErrorFramesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorFrame item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorFrame> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorFrame item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorFrames</summary>
        public void ListErrorFrames()
        {
            // Snippet: ListErrorFrames(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedEnumerable<ListErrorFramesResponse, ErrorFrame> response = migrationCenterClient.ListErrorFrames(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorFrame item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListErrorFramesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorFrame item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorFrame> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorFrame item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorFramesAsync</summary>
        public async Task ListErrorFramesAsync()
        {
            // Snippet: ListErrorFramesAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> response = migrationCenterClient.ListErrorFramesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorFrame item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListErrorFramesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorFrame item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorFrame> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorFrame item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorFrames</summary>
        public void ListErrorFramesResourceNames()
        {
            // Snippet: ListErrorFrames(SourceName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedEnumerable<ListErrorFramesResponse, ErrorFrame> response = migrationCenterClient.ListErrorFrames(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorFrame item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListErrorFramesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorFrame item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorFrame> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorFrame item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorFramesAsync</summary>
        public async Task ListErrorFramesResourceNamesAsync()
        {
            // Snippet: ListErrorFramesAsync(SourceName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> response = migrationCenterClient.ListErrorFramesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorFrame item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListErrorFramesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorFrame item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorFrame> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorFrame item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetErrorFrame</summary>
        public void GetErrorFrameRequestObject()
        {
            // Snippet: GetErrorFrame(GetErrorFrameRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetErrorFrameRequest request = new GetErrorFrameRequest
            {
                ErrorFrameName = ErrorFrameName.FromProjectLocationSourceErrorFrame("[PROJECT]", "[LOCATION]", "[SOURCE]", "[ERROR_FRAME]"),
                View = ErrorFrameView.Unspecified,
            };
            // Make the request
            ErrorFrame response = migrationCenterClient.GetErrorFrame(request);
            // End snippet
        }

        /// <summary>Snippet for GetErrorFrameAsync</summary>
        public async Task GetErrorFrameRequestObjectAsync()
        {
            // Snippet: GetErrorFrameAsync(GetErrorFrameRequest, CallSettings)
            // Additional: GetErrorFrameAsync(GetErrorFrameRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetErrorFrameRequest request = new GetErrorFrameRequest
            {
                ErrorFrameName = ErrorFrameName.FromProjectLocationSourceErrorFrame("[PROJECT]", "[LOCATION]", "[SOURCE]", "[ERROR_FRAME]"),
                View = ErrorFrameView.Unspecified,
            };
            // Make the request
            ErrorFrame response = await migrationCenterClient.GetErrorFrameAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetErrorFrame</summary>
        public void GetErrorFrame()
        {
            // Snippet: GetErrorFrame(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/errorFrames/[ERROR_FRAME]";
            // Make the request
            ErrorFrame response = migrationCenterClient.GetErrorFrame(name);
            // End snippet
        }

        /// <summary>Snippet for GetErrorFrameAsync</summary>
        public async Task GetErrorFrameAsync()
        {
            // Snippet: GetErrorFrameAsync(string, CallSettings)
            // Additional: GetErrorFrameAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]/errorFrames/[ERROR_FRAME]";
            // Make the request
            ErrorFrame response = await migrationCenterClient.GetErrorFrameAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetErrorFrame</summary>
        public void GetErrorFrameResourceNames()
        {
            // Snippet: GetErrorFrame(ErrorFrameName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ErrorFrameName name = ErrorFrameName.FromProjectLocationSourceErrorFrame("[PROJECT]", "[LOCATION]", "[SOURCE]", "[ERROR_FRAME]");
            // Make the request
            ErrorFrame response = migrationCenterClient.GetErrorFrame(name);
            // End snippet
        }

        /// <summary>Snippet for GetErrorFrameAsync</summary>
        public async Task GetErrorFrameResourceNamesAsync()
        {
            // Snippet: GetErrorFrameAsync(ErrorFrameName, CallSettings)
            // Additional: GetErrorFrameAsync(ErrorFrameName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ErrorFrameName name = ErrorFrameName.FromProjectLocationSourceErrorFrame("[PROJECT]", "[LOCATION]", "[SOURCE]", "[ERROR_FRAME]");
            // Make the request
            ErrorFrame response = await migrationCenterClient.GetErrorFrameAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesRequestObject()
        {
            // Snippet: ListSources(ListSourcesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = migrationCenterClient.ListSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesRequestObjectAsync()
        {
            // Snippet: ListSourcesAsync(ListSourcesRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = migrationCenterClient.ListSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSources()
        {
            // Snippet: ListSources(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = migrationCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesAsync()
        {
            // Snippet: ListSourcesAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = migrationCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSourcesResourceNames()
        {
            // Snippet: ListSources(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = migrationCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSourcesAsync</summary>
        public async Task ListSourcesResourceNamesAsync()
        {
            // Snippet: ListSourcesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = migrationCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSourceRequestObject()
        {
            // Snippet: GetSource(GetSourceRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = migrationCenterClient.GetSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceRequestObjectAsync()
        {
            // Snippet: GetSourceAsync(GetSourceRequest, CallSettings)
            // Additional: GetSourceAsync(GetSourceRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = await migrationCenterClient.GetSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSource()
        {
            // Snippet: GetSource(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Source response = migrationCenterClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceAsync()
        {
            // Snippet: GetSourceAsync(string, CallSettings)
            // Additional: GetSourceAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Source response = await migrationCenterClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSourceResourceNames()
        {
            // Snippet: GetSource(SourceName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Source response = migrationCenterClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceResourceNamesAsync()
        {
            // Snippet: GetSourceAsync(SourceName, CallSettings)
            // Additional: GetSourceAsync(SourceName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Source response = await migrationCenterClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSourceRequestObject()
        {
            // Snippet: CreateSource(CreateSourceRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceId = "",
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = migrationCenterClient.CreateSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceRequestObjectAsync()
        {
            // Snippet: CreateSourceAsync(CreateSourceRequest, CallSettings)
            // Additional: CreateSourceAsync(CreateSourceRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceId = "",
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = await migrationCenterClient.CreateSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSource()
        {
            // Snippet: CreateSource(string, Source, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = migrationCenterClient.CreateSource(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceAsync()
        {
            // Snippet: CreateSourceAsync(string, Source, string, CallSettings)
            // Additional: CreateSourceAsync(string, Source, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = await migrationCenterClient.CreateSourceAsync(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSourceResourceNames()
        {
            // Snippet: CreateSource(LocationName, Source, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = migrationCenterClient.CreateSource(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceResourceNamesAsync()
        {
            // Snippet: CreateSourceAsync(LocationName, Source, string, CallSettings)
            // Additional: CreateSourceAsync(LocationName, Source, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Source source = new Source();
            string sourceId = "";
            // Make the request
            Operation<Source, OperationMetadata> response = await migrationCenterClient.CreateSourceAsync(parent, source, sourceId);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSourceRequestObject()
        {
            // Snippet: UpdateSource(UpdateSourceRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                UpdateMask = new FieldMask(),
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = migrationCenterClient.UpdateSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceRequestObjectAsync()
        {
            // Snippet: UpdateSourceAsync(UpdateSourceRequest, CallSettings)
            // Additional: UpdateSourceAsync(UpdateSourceRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                UpdateMask = new FieldMask(),
                Source = new Source(),
                RequestId = "",
            };
            // Make the request
            Operation<Source, OperationMetadata> response = await migrationCenterClient.UpdateSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSource()
        {
            // Snippet: UpdateSource(Source, FieldMask, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            Source source = new Source();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Source, OperationMetadata> response = migrationCenterClient.UpdateSource(source, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceAsync()
        {
            // Snippet: UpdateSourceAsync(Source, FieldMask, CallSettings)
            // Additional: UpdateSourceAsync(Source, FieldMask, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            Source source = new Source();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Source, OperationMetadata> response = await migrationCenterClient.UpdateSourceAsync(source, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Source, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Source result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Source, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Source retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSource</summary>
        public void DeleteSourceRequestObject()
        {
            // Snippet: DeleteSource(DeleteSourceRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteSourceRequest request = new DeleteSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSourceAsync</summary>
        public async Task DeleteSourceRequestObjectAsync()
        {
            // Snippet: DeleteSourceAsync(DeleteSourceRequest, CallSettings)
            // Additional: DeleteSourceAsync(DeleteSourceRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSourceRequest request = new DeleteSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSource</summary>
        public void DeleteSource()
        {
            // Snippet: DeleteSource(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteSource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSourceAsync</summary>
        public async Task DeleteSourceAsync()
        {
            // Snippet: DeleteSourceAsync(string, CallSettings)
            // Additional: DeleteSourceAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sources/[SOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteSourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSource</summary>
        public void DeleteSourceResourceNames()
        {
            // Snippet: DeleteSource(SourceName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteSource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSourceAsync</summary>
        public async Task DeleteSourceResourceNamesAsync()
        {
            // Snippet: DeleteSourceAsync(SourceName, CallSettings)
            // Additional: DeleteSourceAsync(SourceName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName name = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteSourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPreferenceSets</summary>
        public void ListPreferenceSetsRequestObject()
        {
            // Snippet: ListPreferenceSets(ListPreferenceSetsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListPreferenceSetsRequest request = new ListPreferenceSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> response = migrationCenterClient.ListPreferenceSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PreferenceSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPreferenceSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreferenceSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreferenceSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreferenceSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreferenceSetsAsync</summary>
        public async Task ListPreferenceSetsRequestObjectAsync()
        {
            // Snippet: ListPreferenceSetsAsync(ListPreferenceSetsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListPreferenceSetsRequest request = new ListPreferenceSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> response = migrationCenterClient.ListPreferenceSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PreferenceSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPreferenceSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreferenceSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreferenceSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreferenceSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreferenceSets</summary>
        public void ListPreferenceSets()
        {
            // Snippet: ListPreferenceSets(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> response = migrationCenterClient.ListPreferenceSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PreferenceSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPreferenceSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreferenceSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreferenceSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreferenceSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreferenceSetsAsync</summary>
        public async Task ListPreferenceSetsAsync()
        {
            // Snippet: ListPreferenceSetsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> response = migrationCenterClient.ListPreferenceSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PreferenceSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPreferenceSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreferenceSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreferenceSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreferenceSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreferenceSets</summary>
        public void ListPreferenceSetsResourceNames()
        {
            // Snippet: ListPreferenceSets(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> response = migrationCenterClient.ListPreferenceSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PreferenceSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPreferenceSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreferenceSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreferenceSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreferenceSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPreferenceSetsAsync</summary>
        public async Task ListPreferenceSetsResourceNamesAsync()
        {
            // Snippet: ListPreferenceSetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> response = migrationCenterClient.ListPreferenceSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PreferenceSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPreferenceSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PreferenceSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PreferenceSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PreferenceSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPreferenceSet</summary>
        public void GetPreferenceSetRequestObject()
        {
            // Snippet: GetPreferenceSet(GetPreferenceSetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetPreferenceSetRequest request = new GetPreferenceSetRequest
            {
                PreferenceSetName = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]"),
            };
            // Make the request
            PreferenceSet response = migrationCenterClient.GetPreferenceSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetPreferenceSetAsync</summary>
        public async Task GetPreferenceSetRequestObjectAsync()
        {
            // Snippet: GetPreferenceSetAsync(GetPreferenceSetRequest, CallSettings)
            // Additional: GetPreferenceSetAsync(GetPreferenceSetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetPreferenceSetRequest request = new GetPreferenceSetRequest
            {
                PreferenceSetName = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]"),
            };
            // Make the request
            PreferenceSet response = await migrationCenterClient.GetPreferenceSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPreferenceSet</summary>
        public void GetPreferenceSet()
        {
            // Snippet: GetPreferenceSet(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/preferenceSets/[PREFERENCE_SET]";
            // Make the request
            PreferenceSet response = migrationCenterClient.GetPreferenceSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetPreferenceSetAsync</summary>
        public async Task GetPreferenceSetAsync()
        {
            // Snippet: GetPreferenceSetAsync(string, CallSettings)
            // Additional: GetPreferenceSetAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/preferenceSets/[PREFERENCE_SET]";
            // Make the request
            PreferenceSet response = await migrationCenterClient.GetPreferenceSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPreferenceSet</summary>
        public void GetPreferenceSetResourceNames()
        {
            // Snippet: GetPreferenceSet(PreferenceSetName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            PreferenceSetName name = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]");
            // Make the request
            PreferenceSet response = migrationCenterClient.GetPreferenceSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetPreferenceSetAsync</summary>
        public async Task GetPreferenceSetResourceNamesAsync()
        {
            // Snippet: GetPreferenceSetAsync(PreferenceSetName, CallSettings)
            // Additional: GetPreferenceSetAsync(PreferenceSetName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            PreferenceSetName name = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]");
            // Make the request
            PreferenceSet response = await migrationCenterClient.GetPreferenceSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePreferenceSet</summary>
        public void CreatePreferenceSetRequestObject()
        {
            // Snippet: CreatePreferenceSet(CreatePreferenceSetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreatePreferenceSetRequest request = new CreatePreferenceSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PreferenceSetId = "",
                PreferenceSet = new PreferenceSet(),
                RequestId = "",
            };
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = migrationCenterClient.CreatePreferenceSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreatePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreferenceSetAsync</summary>
        public async Task CreatePreferenceSetRequestObjectAsync()
        {
            // Snippet: CreatePreferenceSetAsync(CreatePreferenceSetRequest, CallSettings)
            // Additional: CreatePreferenceSetAsync(CreatePreferenceSetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreatePreferenceSetRequest request = new CreatePreferenceSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PreferenceSetId = "",
                PreferenceSet = new PreferenceSet(),
                RequestId = "",
            };
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = await migrationCenterClient.CreatePreferenceSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreatePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreferenceSet</summary>
        public void CreatePreferenceSet()
        {
            // Snippet: CreatePreferenceSet(string, PreferenceSet, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PreferenceSet preferenceSet = new PreferenceSet();
            string preferenceSetId = "";
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = migrationCenterClient.CreatePreferenceSet(parent, preferenceSet, preferenceSetId);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreatePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreferenceSetAsync</summary>
        public async Task CreatePreferenceSetAsync()
        {
            // Snippet: CreatePreferenceSetAsync(string, PreferenceSet, string, CallSettings)
            // Additional: CreatePreferenceSetAsync(string, PreferenceSet, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PreferenceSet preferenceSet = new PreferenceSet();
            string preferenceSetId = "";
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = await migrationCenterClient.CreatePreferenceSetAsync(parent, preferenceSet, preferenceSetId);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreatePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreferenceSet</summary>
        public void CreatePreferenceSetResourceNames()
        {
            // Snippet: CreatePreferenceSet(LocationName, PreferenceSet, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PreferenceSet preferenceSet = new PreferenceSet();
            string preferenceSetId = "";
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = migrationCenterClient.CreatePreferenceSet(parent, preferenceSet, preferenceSetId);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreatePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePreferenceSetAsync</summary>
        public async Task CreatePreferenceSetResourceNamesAsync()
        {
            // Snippet: CreatePreferenceSetAsync(LocationName, PreferenceSet, string, CallSettings)
            // Additional: CreatePreferenceSetAsync(LocationName, PreferenceSet, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PreferenceSet preferenceSet = new PreferenceSet();
            string preferenceSetId = "";
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = await migrationCenterClient.CreatePreferenceSetAsync(parent, preferenceSet, preferenceSetId);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreatePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePreferenceSet</summary>
        public void UpdatePreferenceSetRequestObject()
        {
            // Snippet: UpdatePreferenceSet(UpdatePreferenceSetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            UpdatePreferenceSetRequest request = new UpdatePreferenceSetRequest
            {
                UpdateMask = new FieldMask(),
                PreferenceSet = new PreferenceSet(),
                RequestId = "",
            };
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = migrationCenterClient.UpdatePreferenceSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdatePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePreferenceSetAsync</summary>
        public async Task UpdatePreferenceSetRequestObjectAsync()
        {
            // Snippet: UpdatePreferenceSetAsync(UpdatePreferenceSetRequest, CallSettings)
            // Additional: UpdatePreferenceSetAsync(UpdatePreferenceSetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePreferenceSetRequest request = new UpdatePreferenceSetRequest
            {
                UpdateMask = new FieldMask(),
                PreferenceSet = new PreferenceSet(),
                RequestId = "",
            };
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = await migrationCenterClient.UpdatePreferenceSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdatePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePreferenceSet</summary>
        public void UpdatePreferenceSet()
        {
            // Snippet: UpdatePreferenceSet(PreferenceSet, FieldMask, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            PreferenceSet preferenceSet = new PreferenceSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = migrationCenterClient.UpdatePreferenceSet(preferenceSet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdatePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePreferenceSetAsync</summary>
        public async Task UpdatePreferenceSetAsync()
        {
            // Snippet: UpdatePreferenceSetAsync(PreferenceSet, FieldMask, CallSettings)
            // Additional: UpdatePreferenceSetAsync(PreferenceSet, FieldMask, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            PreferenceSet preferenceSet = new PreferenceSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PreferenceSet, OperationMetadata> response = await migrationCenterClient.UpdatePreferenceSetAsync(preferenceSet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PreferenceSet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PreferenceSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PreferenceSet, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdatePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PreferenceSet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreferenceSet</summary>
        public void DeletePreferenceSetRequestObject()
        {
            // Snippet: DeletePreferenceSet(DeletePreferenceSetRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeletePreferenceSetRequest request = new DeletePreferenceSetRequest
            {
                PreferenceSetName = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeletePreferenceSet(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeletePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreferenceSetAsync</summary>
        public async Task DeletePreferenceSetRequestObjectAsync()
        {
            // Snippet: DeletePreferenceSetAsync(DeletePreferenceSetRequest, CallSettings)
            // Additional: DeletePreferenceSetAsync(DeletePreferenceSetRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeletePreferenceSetRequest request = new DeletePreferenceSetRequest
            {
                PreferenceSetName = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeletePreferenceSetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeletePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreferenceSet</summary>
        public void DeletePreferenceSet()
        {
            // Snippet: DeletePreferenceSet(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/preferenceSets/[PREFERENCE_SET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeletePreferenceSet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeletePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreferenceSetAsync</summary>
        public async Task DeletePreferenceSetAsync()
        {
            // Snippet: DeletePreferenceSetAsync(string, CallSettings)
            // Additional: DeletePreferenceSetAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/preferenceSets/[PREFERENCE_SET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeletePreferenceSetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeletePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreferenceSet</summary>
        public void DeletePreferenceSetResourceNames()
        {
            // Snippet: DeletePreferenceSet(PreferenceSetName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            PreferenceSetName name = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeletePreferenceSet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeletePreferenceSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePreferenceSetAsync</summary>
        public async Task DeletePreferenceSetResourceNamesAsync()
        {
            // Snippet: DeletePreferenceSetAsync(PreferenceSetName, CallSettings)
            // Additional: DeletePreferenceSetAsync(PreferenceSetName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            PreferenceSetName name = PreferenceSetName.FromProjectLocationPreferenceSet("[PROJECT]", "[LOCATION]", "[PREFERENCE_SET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeletePreferenceSetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeletePreferenceSetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsRequestObject()
        {
            // Snippet: GetSettings(GetSettingsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Settings response = migrationCenterClient.GetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Snippet: GetSettingsAsync(GetSettingsRequest, CallSettings)
            // Additional: GetSettingsAsync(GetSettingsRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Settings response = await migrationCenterClient.GetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettings()
        {
            // Snippet: GetSettings(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = migrationCenterClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsAsync()
        {
            // Snippet: GetSettingsAsync(string, CallSettings)
            // Additional: GetSettingsAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = await migrationCenterClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsResourceNames()
        {
            // Snippet: GetSettings(SettingsName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Settings response = migrationCenterClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsResourceNamesAsync()
        {
            // Snippet: GetSettingsAsync(SettingsName, CallSettings)
            // Additional: GetSettingsAsync(SettingsName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Settings response = await migrationCenterClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettingsRequestObject()
        {
            // Snippet: UpdateSettings(UpdateSettingsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                UpdateMask = new FieldMask(),
                Settings = new Settings(),
                RequestId = "",
            };
            // Make the request
            Operation<Settings, OperationMetadata> response = migrationCenterClient.UpdateSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsRequestObjectAsync()
        {
            // Snippet: UpdateSettingsAsync(UpdateSettingsRequest, CallSettings)
            // Additional: UpdateSettingsAsync(UpdateSettingsRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                UpdateMask = new FieldMask(),
                Settings = new Settings(),
                RequestId = "",
            };
            // Make the request
            Operation<Settings, OperationMetadata> response = await migrationCenterClient.UpdateSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettings()
        {
            // Snippet: UpdateSettings(Settings, FieldMask, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Settings, OperationMetadata> response = migrationCenterClient.UpdateSettings(settings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceUpdateSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsAsync()
        {
            // Snippet: UpdateSettingsAsync(Settings, FieldMask, CallSettings)
            // Additional: UpdateSettingsAsync(Settings, FieldMask, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Settings, OperationMetadata> response = await migrationCenterClient.UpdateSettingsAsync(settings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Settings, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Settings result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Settings, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceUpdateSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Settings retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfig</summary>
        public void CreateReportConfigRequestObject()
        {
            // Snippet: CreateReportConfig(CreateReportConfigRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreateReportConfigRequest request = new CreateReportConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReportConfigId = "",
                ReportConfig = new ReportConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<ReportConfig, OperationMetadata> response = migrationCenterClient.CreateReportConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<ReportConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReportConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReportConfig, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateReportConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReportConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfigAsync</summary>
        public async Task CreateReportConfigRequestObjectAsync()
        {
            // Snippet: CreateReportConfigAsync(CreateReportConfigRequest, CallSettings)
            // Additional: CreateReportConfigAsync(CreateReportConfigRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateReportConfigRequest request = new CreateReportConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReportConfigId = "",
                ReportConfig = new ReportConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<ReportConfig, OperationMetadata> response = await migrationCenterClient.CreateReportConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReportConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReportConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReportConfig, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateReportConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReportConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfig</summary>
        public void CreateReportConfig()
        {
            // Snippet: CreateReportConfig(string, ReportConfig, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ReportConfig reportConfig = new ReportConfig();
            string reportConfigId = "";
            // Make the request
            Operation<ReportConfig, OperationMetadata> response = migrationCenterClient.CreateReportConfig(parent, reportConfig, reportConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ReportConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReportConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReportConfig, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateReportConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReportConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfigAsync</summary>
        public async Task CreateReportConfigAsync()
        {
            // Snippet: CreateReportConfigAsync(string, ReportConfig, string, CallSettings)
            // Additional: CreateReportConfigAsync(string, ReportConfig, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ReportConfig reportConfig = new ReportConfig();
            string reportConfigId = "";
            // Make the request
            Operation<ReportConfig, OperationMetadata> response = await migrationCenterClient.CreateReportConfigAsync(parent, reportConfig, reportConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ReportConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReportConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReportConfig, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateReportConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReportConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfig</summary>
        public void CreateReportConfigResourceNames()
        {
            // Snippet: CreateReportConfig(LocationName, ReportConfig, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ReportConfig reportConfig = new ReportConfig();
            string reportConfigId = "";
            // Make the request
            Operation<ReportConfig, OperationMetadata> response = migrationCenterClient.CreateReportConfig(parent, reportConfig, reportConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ReportConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReportConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReportConfig, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateReportConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReportConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfigAsync</summary>
        public async Task CreateReportConfigResourceNamesAsync()
        {
            // Snippet: CreateReportConfigAsync(LocationName, ReportConfig, string, CallSettings)
            // Additional: CreateReportConfigAsync(LocationName, ReportConfig, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ReportConfig reportConfig = new ReportConfig();
            string reportConfigId = "";
            // Make the request
            Operation<ReportConfig, OperationMetadata> response = await migrationCenterClient.CreateReportConfigAsync(parent, reportConfig, reportConfigId);

            // Poll until the returned long-running operation is complete
            Operation<ReportConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReportConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReportConfig, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateReportConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReportConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetReportConfig</summary>
        public void GetReportConfigRequestObject()
        {
            // Snippet: GetReportConfig(GetReportConfigRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetReportConfigRequest request = new GetReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
            };
            // Make the request
            ReportConfig response = migrationCenterClient.GetReportConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfigAsync</summary>
        public async Task GetReportConfigRequestObjectAsync()
        {
            // Snippet: GetReportConfigAsync(GetReportConfigRequest, CallSettings)
            // Additional: GetReportConfigAsync(GetReportConfigRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetReportConfigRequest request = new GetReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
            };
            // Make the request
            ReportConfig response = await migrationCenterClient.GetReportConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfig</summary>
        public void GetReportConfig()
        {
            // Snippet: GetReportConfig(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            ReportConfig response = migrationCenterClient.GetReportConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfigAsync</summary>
        public async Task GetReportConfigAsync()
        {
            // Snippet: GetReportConfigAsync(string, CallSettings)
            // Additional: GetReportConfigAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            ReportConfig response = await migrationCenterClient.GetReportConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfig</summary>
        public void GetReportConfigResourceNames()
        {
            // Snippet: GetReportConfig(ReportConfigName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            ReportConfig response = migrationCenterClient.GetReportConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfigAsync</summary>
        public async Task GetReportConfigResourceNamesAsync()
        {
            // Snippet: GetReportConfigAsync(ReportConfigName, CallSettings)
            // Additional: GetReportConfigAsync(ReportConfigName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            ReportConfig response = await migrationCenterClient.GetReportConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigs</summary>
        public void ListReportConfigsRequestObject()
        {
            // Snippet: ListReportConfigs(ListReportConfigsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListReportConfigsRequest request = new ListReportConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReportConfigsResponse, ReportConfig> response = migrationCenterClient.ListReportConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigsAsync</summary>
        public async Task ListReportConfigsRequestObjectAsync()
        {
            // Snippet: ListReportConfigsAsync(ListReportConfigsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListReportConfigsRequest request = new ListReportConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> response = migrationCenterClient.ListReportConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigs</summary>
        public void ListReportConfigs()
        {
            // Snippet: ListReportConfigs(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReportConfigsResponse, ReportConfig> response = migrationCenterClient.ListReportConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigsAsync</summary>
        public async Task ListReportConfigsAsync()
        {
            // Snippet: ListReportConfigsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> response = migrationCenterClient.ListReportConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigs</summary>
        public void ListReportConfigsResourceNames()
        {
            // Snippet: ListReportConfigs(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReportConfigsResponse, ReportConfig> response = migrationCenterClient.ListReportConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigsAsync</summary>
        public async Task ListReportConfigsResourceNamesAsync()
        {
            // Snippet: ListReportConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> response = migrationCenterClient.ListReportConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfig</summary>
        public void DeleteReportConfigRequestObject()
        {
            // Snippet: DeleteReportConfig(DeleteReportConfigRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteReportConfigRequest request = new DeleteReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteReportConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteReportConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfigAsync</summary>
        public async Task DeleteReportConfigRequestObjectAsync()
        {
            // Snippet: DeleteReportConfigAsync(DeleteReportConfigRequest, CallSettings)
            // Additional: DeleteReportConfigAsync(DeleteReportConfigRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReportConfigRequest request = new DeleteReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteReportConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteReportConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfig</summary>
        public void DeleteReportConfig()
        {
            // Snippet: DeleteReportConfig(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteReportConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteReportConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfigAsync</summary>
        public async Task DeleteReportConfigAsync()
        {
            // Snippet: DeleteReportConfigAsync(string, CallSettings)
            // Additional: DeleteReportConfigAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteReportConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteReportConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfig</summary>
        public void DeleteReportConfigResourceNames()
        {
            // Snippet: DeleteReportConfig(ReportConfigName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteReportConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteReportConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfigAsync</summary>
        public async Task DeleteReportConfigResourceNamesAsync()
        {
            // Snippet: DeleteReportConfigAsync(ReportConfigName, CallSettings)
            // Additional: DeleteReportConfigAsync(ReportConfigName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteReportConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteReportConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReportRequestObject()
        {
            // Snippet: CreateReport(CreateReportRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            CreateReportRequest request = new CreateReportRequest
            {
                ParentAsReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                ReportId = "",
                Report = new Report(),
                RequestId = "",
            };
            // Make the request
            Operation<Report, OperationMetadata> response = migrationCenterClient.CreateReport(request);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportRequestObjectAsync()
        {
            // Snippet: CreateReportAsync(CreateReportRequest, CallSettings)
            // Additional: CreateReportAsync(CreateReportRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateReportRequest request = new CreateReportRequest
            {
                ParentAsReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                ReportId = "",
                Report = new Report(),
                RequestId = "",
            };
            // Make the request
            Operation<Report, OperationMetadata> response = await migrationCenterClient.CreateReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReport()
        {
            // Snippet: CreateReport(string, Report, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = migrationCenterClient.CreateReport(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportAsync()
        {
            // Snippet: CreateReportAsync(string, Report, string, CallSettings)
            // Additional: CreateReportAsync(string, Report, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = await migrationCenterClient.CreateReportAsync(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReportResourceNames()
        {
            // Snippet: CreateReport(ReportConfigName, Report, string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportConfigName parent = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = migrationCenterClient.CreateReport(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceCreateReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportResourceNamesAsync()
        {
            // Snippet: CreateReportAsync(ReportConfigName, Report, string, CallSettings)
            // Additional: CreateReportAsync(ReportConfigName, Report, string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName parent = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = await migrationCenterClient.CreateReportAsync(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceCreateReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReportRequestObject()
        {
            // Snippet: GetReport(GetReportRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            GetReportRequest request = new GetReportRequest
            {
                ReportName = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]"),
                View = ReportView.Unspecified,
            };
            // Make the request
            Report response = migrationCenterClient.GetReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportRequestObjectAsync()
        {
            // Snippet: GetReportAsync(GetReportRequest, CallSettings)
            // Additional: GetReportAsync(GetReportRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetReportRequest request = new GetReportRequest
            {
                ReportName = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]"),
                View = ReportView.Unspecified,
            };
            // Make the request
            Report response = await migrationCenterClient.GetReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReport()
        {
            // Snippet: GetReport(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]/reports/[REPORT]";
            // Make the request
            Report response = migrationCenterClient.GetReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportAsync()
        {
            // Snippet: GetReportAsync(string, CallSettings)
            // Additional: GetReportAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]/reports/[REPORT]";
            // Make the request
            Report response = await migrationCenterClient.GetReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReportResourceNames()
        {
            // Snippet: GetReport(ReportName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]");
            // Make the request
            Report response = migrationCenterClient.GetReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportResourceNamesAsync()
        {
            // Snippet: GetReportAsync(ReportName, CallSettings)
            // Additional: GetReportAsync(ReportName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]");
            // Make the request
            Report response = await migrationCenterClient.GetReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReportsRequestObject()
        {
            // Snippet: ListReports(ListReportsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                Filter = "",
                OrderBy = "",
                View = ReportView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = migrationCenterClient.ListReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportsAsync</summary>
        public async Task ListReportsRequestObjectAsync()
        {
            // Snippet: ListReportsAsync(ListReportsRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                Filter = "",
                OrderBy = "",
                View = ReportView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = migrationCenterClient.ListReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReports()
        {
            // Snippet: ListReports(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = migrationCenterClient.ListReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportsAsync</summary>
        public async Task ListReportsAsync()
        {
            // Snippet: ListReportsAsync(string, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = migrationCenterClient.ListReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReportsResourceNames()
        {
            // Snippet: ListReports(ReportConfigName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportConfigName parent = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = migrationCenterClient.ListReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportsAsync</summary>
        public async Task ListReportsResourceNamesAsync()
        {
            // Snippet: ListReportsAsync(ReportConfigName, string, int?, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName parent = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = migrationCenterClient.ListReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteReport</summary>
        public void DeleteReportRequestObject()
        {
            // Snippet: DeleteReport(DeleteReportRequest, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            DeleteReportRequest request = new DeleteReportRequest
            {
                ReportName = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteReport(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportAsync</summary>
        public async Task DeleteReportRequestObjectAsync()
        {
            // Snippet: DeleteReportAsync(DeleteReportRequest, CallSettings)
            // Additional: DeleteReportAsync(DeleteReportRequest, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReportRequest request = new DeleteReportRequest
            {
                ReportName = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReport</summary>
        public void DeleteReport()
        {
            // Snippet: DeleteReport(string, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]/reports/[REPORT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteReport(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportAsync</summary>
        public async Task DeleteReportAsync()
        {
            // Snippet: DeleteReportAsync(string, CallSettings)
            // Additional: DeleteReportAsync(string, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]/reports/[REPORT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReport</summary>
        public void DeleteReportResourceNames()
        {
            // Snippet: DeleteReport(ReportName, CallSettings)
            // Create client
            MigrationCenterClient migrationCenterClient = MigrationCenterClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = migrationCenterClient.DeleteReport(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = migrationCenterClient.PollOnceDeleteReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReportAsync</summary>
        public async Task DeleteReportResourceNamesAsync()
        {
            // Snippet: DeleteReportAsync(ReportName, CallSettings)
            // Additional: DeleteReportAsync(ReportName, CancellationToken)
            // Create client
            MigrationCenterClient migrationCenterClient = await MigrationCenterClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReportConfigReport("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await migrationCenterClient.DeleteReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await migrationCenterClient.PollOnceDeleteReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
