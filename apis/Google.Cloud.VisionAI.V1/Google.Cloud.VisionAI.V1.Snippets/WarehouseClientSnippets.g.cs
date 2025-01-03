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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcvv = Google.Cloud.VisionAI.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWarehouseClientSnippets
    {
        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAssetRequestObject()
        {
            // Snippet: CreateAsset(CreateAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateAssetRequest request = new gcvv::CreateAssetRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Asset = new gcvv::Asset(),
                AssetId = "",
            };
            // Make the request
            gcvv::Asset response = warehouseClient.CreateAsset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetRequestObjectAsync()
        {
            // Snippet: CreateAssetAsync(CreateAssetRequest, CallSettings)
            // Additional: CreateAssetAsync(CreateAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateAssetRequest request = new gcvv::CreateAssetRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Asset = new gcvv::Asset(),
                AssetId = "",
            };
            // Make the request
            gcvv::Asset response = await warehouseClient.CreateAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAsset()
        {
            // Snippet: CreateAsset(string, Asset, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::Asset asset = new gcvv::Asset();
            string assetId = "";
            // Make the request
            gcvv::Asset response = warehouseClient.CreateAsset(parent, asset, assetId);
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetAsync()
        {
            // Snippet: CreateAssetAsync(string, Asset, string, CallSettings)
            // Additional: CreateAssetAsync(string, Asset, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::Asset asset = new gcvv::Asset();
            string assetId = "";
            // Make the request
            gcvv::Asset response = await warehouseClient.CreateAssetAsync(parent, asset, assetId);
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAssetResourceNames()
        {
            // Snippet: CreateAsset(CorpusName, Asset, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::Asset asset = new gcvv::Asset();
            string assetId = "";
            // Make the request
            gcvv::Asset response = warehouseClient.CreateAsset(parent, asset, assetId);
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetResourceNamesAsync()
        {
            // Snippet: CreateAssetAsync(CorpusName, Asset, string, CallSettings)
            // Additional: CreateAssetAsync(CorpusName, Asset, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::Asset asset = new gcvv::Asset();
            string assetId = "";
            // Make the request
            gcvv::Asset response = await warehouseClient.CreateAssetAsync(parent, asset, assetId);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAssetRequestObject()
        {
            // Snippet: UpdateAsset(UpdateAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateAssetRequest request = new gcvv::UpdateAssetRequest
            {
                Asset = new gcvv::Asset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Asset response = warehouseClient.UpdateAsset(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetRequestObjectAsync()
        {
            // Snippet: UpdateAssetAsync(UpdateAssetRequest, CallSettings)
            // Additional: UpdateAssetAsync(UpdateAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateAssetRequest request = new gcvv::UpdateAssetRequest
            {
                Asset = new gcvv::Asset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Asset response = await warehouseClient.UpdateAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAsset()
        {
            // Snippet: UpdateAsset(Asset, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::Asset asset = new gcvv::Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Asset response = warehouseClient.UpdateAsset(asset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetAsync()
        {
            // Snippet: UpdateAssetAsync(Asset, FieldMask, CallSettings)
            // Additional: UpdateAssetAsync(Asset, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::Asset asset = new gcvv::Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Asset response = await warehouseClient.UpdateAssetAsync(asset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetRequestObject()
        {
            // Snippet: GetAsset(GetAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetAssetRequest request = new gcvv::GetAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            gcvv::Asset response = warehouseClient.GetAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetRequestObjectAsync()
        {
            // Snippet: GetAssetAsync(GetAssetRequest, CallSettings)
            // Additional: GetAssetAsync(GetAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetAssetRequest request = new gcvv::GetAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            gcvv::Asset response = await warehouseClient.GetAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAsset()
        {
            // Snippet: GetAsset(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            // Make the request
            gcvv::Asset response = warehouseClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetAsync()
        {
            // Snippet: GetAssetAsync(string, CallSettings)
            // Additional: GetAssetAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            // Make the request
            gcvv::Asset response = await warehouseClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetResourceNames()
        {
            // Snippet: GetAsset(AssetName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AssetName name = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            // Make the request
            gcvv::Asset response = warehouseClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetResourceNamesAsync()
        {
            // Snippet: GetAssetAsync(AssetName, CallSettings)
            // Additional: GetAssetAsync(AssetName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AssetName name = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            // Make the request
            gcvv::Asset response = await warehouseClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsRequestObject()
        {
            // Snippet: ListAssets(ListAssetsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListAssetsRequest request = new gcvv::ListAssetsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ListAssetsResponse, gcvv::Asset> response = warehouseClient.ListAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Asset item in singlePage)
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
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListAssetsRequest request = new gcvv::ListAssetsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListAssetsResponse, gcvv::Asset> response = warehouseClient.ListAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Asset item in singlePage)
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
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedEnumerable<gcvv::ListAssetsResponse, gcvv::Asset> response = warehouseClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Asset item in singlePage)
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
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListAssetsResponse, gcvv::Asset> response = warehouseClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Asset item in singlePage)
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
            // Snippet: ListAssets(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedEnumerable<gcvv::ListAssetsResponse, gcvv::Asset> response = warehouseClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Asset item in singlePage)
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
            // Snippet: ListAssetsAsync(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListAssetsResponse, gcvv::Asset> response = warehouseClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetRequestObject()
        {
            // Snippet: DeleteAsset(DeleteAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteAssetRequest request = new gcvv::DeleteAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteAssetMetadata> response = warehouseClient.DeleteAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteAssetMetadata> retrievedResponse = warehouseClient.PollOnceDeleteAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetRequestObjectAsync()
        {
            // Snippet: DeleteAssetAsync(DeleteAssetRequest, CallSettings)
            // Additional: DeleteAssetAsync(DeleteAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteAssetRequest request = new gcvv::DeleteAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteAssetMetadata> response = await warehouseClient.DeleteAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteAssetMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAsset()
        {
            // Snippet: DeleteAsset(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            // Make the request
            Operation<Empty, gcvv::DeleteAssetMetadata> response = warehouseClient.DeleteAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteAssetMetadata> retrievedResponse = warehouseClient.PollOnceDeleteAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetAsync()
        {
            // Snippet: DeleteAssetAsync(string, CallSettings)
            // Additional: DeleteAssetAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            // Make the request
            Operation<Empty, gcvv::DeleteAssetMetadata> response = await warehouseClient.DeleteAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteAssetMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetResourceNames()
        {
            // Snippet: DeleteAsset(AssetName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AssetName name = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            // Make the request
            Operation<Empty, gcvv::DeleteAssetMetadata> response = warehouseClient.DeleteAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteAssetMetadata> retrievedResponse = warehouseClient.PollOnceDeleteAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetResourceNamesAsync()
        {
            // Snippet: DeleteAssetAsync(AssetName, CallSettings)
            // Additional: DeleteAssetAsync(AssetName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AssetName name = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            // Make the request
            Operation<Empty, gcvv::DeleteAssetMetadata> response = await warehouseClient.DeleteAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteAssetMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadAsset</summary>
        public void UploadAssetRequestObject()
        {
            // Snippet: UploadAsset(UploadAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UploadAssetRequest request = new gcvv::UploadAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                AssetSource = new gcvv::AssetSource(),
            };
            // Make the request
            Operation<gcvv::UploadAssetResponse, gcvv::UploadAssetMetadata> response = warehouseClient.UploadAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::UploadAssetResponse, gcvv::UploadAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::UploadAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::UploadAssetResponse, gcvv::UploadAssetMetadata> retrievedResponse = warehouseClient.PollOnceUploadAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::UploadAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadAssetAsync</summary>
        public async Task UploadAssetRequestObjectAsync()
        {
            // Snippet: UploadAssetAsync(UploadAssetRequest, CallSettings)
            // Additional: UploadAssetAsync(UploadAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UploadAssetRequest request = new gcvv::UploadAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                AssetSource = new gcvv::AssetSource(),
            };
            // Make the request
            Operation<gcvv::UploadAssetResponse, gcvv::UploadAssetMetadata> response = await warehouseClient.UploadAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::UploadAssetResponse, gcvv::UploadAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::UploadAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::UploadAssetResponse, gcvv::UploadAssetMetadata> retrievedResponse = await warehouseClient.PollOnceUploadAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::UploadAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateRetrievalUrl</summary>
        public void GenerateRetrievalUrlRequestObject()
        {
            // Snippet: GenerateRetrievalUrl(GenerateRetrievalUrlRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GenerateRetrievalUrlRequest request = new gcvv::GenerateRetrievalUrlRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            gcvv::GenerateRetrievalUrlResponse response = warehouseClient.GenerateRetrievalUrl(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateRetrievalUrlAsync</summary>
        public async Task GenerateRetrievalUrlRequestObjectAsync()
        {
            // Snippet: GenerateRetrievalUrlAsync(GenerateRetrievalUrlRequest, CallSettings)
            // Additional: GenerateRetrievalUrlAsync(GenerateRetrievalUrlRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GenerateRetrievalUrlRequest request = new gcvv::GenerateRetrievalUrlRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            gcvv::GenerateRetrievalUrlResponse response = await warehouseClient.GenerateRetrievalUrlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeAsset</summary>
        public void AnalyzeAssetRequestObject()
        {
            // Snippet: AnalyzeAsset(AnalyzeAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AnalyzeAssetRequest request = new gcvv::AnalyzeAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            Operation<gcvv::AnalyzeAssetResponse, gcvv::AnalyzeAssetMetadata> response = warehouseClient.AnalyzeAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::AnalyzeAssetResponse, gcvv::AnalyzeAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::AnalyzeAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::AnalyzeAssetResponse, gcvv::AnalyzeAssetMetadata> retrievedResponse = warehouseClient.PollOnceAnalyzeAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::AnalyzeAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeAssetAsync</summary>
        public async Task AnalyzeAssetRequestObjectAsync()
        {
            // Snippet: AnalyzeAssetAsync(AnalyzeAssetRequest, CallSettings)
            // Additional: AnalyzeAssetAsync(AnalyzeAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AnalyzeAssetRequest request = new gcvv::AnalyzeAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
            };
            // Make the request
            Operation<gcvv::AnalyzeAssetResponse, gcvv::AnalyzeAssetMetadata> response = await warehouseClient.AnalyzeAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::AnalyzeAssetResponse, gcvv::AnalyzeAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::AnalyzeAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::AnalyzeAssetResponse, gcvv::AnalyzeAssetMetadata> retrievedResponse = await warehouseClient.PollOnceAnalyzeAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::AnalyzeAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IndexAsset</summary>
        public void IndexAssetRequestObject()
        {
            // Snippet: IndexAsset(IndexAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexAssetRequest request = new gcvv::IndexAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                IndexAsIndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            Operation<gcvv::IndexAssetResponse, gcvv::IndexAssetMetadata> response = warehouseClient.IndexAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexAssetResponse, gcvv::IndexAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::IndexAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexAssetResponse, gcvv::IndexAssetMetadata> retrievedResponse = warehouseClient.PollOnceIndexAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IndexAssetAsync</summary>
        public async Task IndexAssetRequestObjectAsync()
        {
            // Snippet: IndexAssetAsync(IndexAssetRequest, CallSettings)
            // Additional: IndexAssetAsync(IndexAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexAssetRequest request = new gcvv::IndexAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                IndexAsIndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            Operation<gcvv::IndexAssetResponse, gcvv::IndexAssetMetadata> response = await warehouseClient.IndexAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexAssetResponse, gcvv::IndexAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::IndexAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexAssetResponse, gcvv::IndexAssetMetadata> retrievedResponse = await warehouseClient.PollOnceIndexAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveIndexAsset</summary>
        public void RemoveIndexAssetRequestObject()
        {
            // Snippet: RemoveIndexAsset(RemoveIndexAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::RemoveIndexAssetRequest request = new gcvv::RemoveIndexAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                IndexAsIndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            Operation<gcvv::RemoveIndexAssetResponse, gcvv::RemoveIndexAssetMetadata> response = warehouseClient.RemoveIndexAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::RemoveIndexAssetResponse, gcvv::RemoveIndexAssetMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::RemoveIndexAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::RemoveIndexAssetResponse, gcvv::RemoveIndexAssetMetadata> retrievedResponse = warehouseClient.PollOnceRemoveIndexAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::RemoveIndexAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveIndexAssetAsync</summary>
        public async Task RemoveIndexAssetRequestObjectAsync()
        {
            // Snippet: RemoveIndexAssetAsync(RemoveIndexAssetRequest, CallSettings)
            // Additional: RemoveIndexAssetAsync(RemoveIndexAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::RemoveIndexAssetRequest request = new gcvv::RemoveIndexAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                IndexAsIndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            Operation<gcvv::RemoveIndexAssetResponse, gcvv::RemoveIndexAssetMetadata> response = await warehouseClient.RemoveIndexAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::RemoveIndexAssetResponse, gcvv::RemoveIndexAssetMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::RemoveIndexAssetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::RemoveIndexAssetResponse, gcvv::RemoveIndexAssetMetadata> retrievedResponse = await warehouseClient.PollOnceRemoveIndexAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::RemoveIndexAssetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ViewIndexedAssets</summary>
        public void ViewIndexedAssetsRequestObject()
        {
            // Snippet: ViewIndexedAssets(ViewIndexedAssetsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ViewIndexedAssetsRequest request = new gcvv::ViewIndexedAssetsRequest
            {
                IndexAsIndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ViewIndexedAssetsResponse, gcvv::IndexedAsset> response = warehouseClient.ViewIndexedAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::IndexedAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ViewIndexedAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexedAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewIndexedAssetsAsync</summary>
        public async Task ViewIndexedAssetsRequestObjectAsync()
        {
            // Snippet: ViewIndexedAssetsAsync(ViewIndexedAssetsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ViewIndexedAssetsRequest request = new gcvv::ViewIndexedAssetsRequest
            {
                IndexAsIndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ViewIndexedAssetsResponse, gcvv::IndexedAsset> response = warehouseClient.ViewIndexedAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::IndexedAsset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ViewIndexedAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexedAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewIndexedAssets</summary>
        public void ViewIndexedAssets()
        {
            // Snippet: ViewIndexedAssets(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string index = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/indexes/[INDEX]";
            // Make the request
            PagedEnumerable<gcvv::ViewIndexedAssetsResponse, gcvv::IndexedAsset> response = warehouseClient.ViewIndexedAssets(index);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::IndexedAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ViewIndexedAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexedAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewIndexedAssetsAsync</summary>
        public async Task ViewIndexedAssetsAsync()
        {
            // Snippet: ViewIndexedAssetsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string index = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/indexes/[INDEX]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ViewIndexedAssetsResponse, gcvv::IndexedAsset> response = warehouseClient.ViewIndexedAssetsAsync(index);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::IndexedAsset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ViewIndexedAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexedAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewIndexedAssets</summary>
        public void ViewIndexedAssetsResourceNames()
        {
            // Snippet: ViewIndexedAssets(IndexName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexName index = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]");
            // Make the request
            PagedEnumerable<gcvv::ViewIndexedAssetsResponse, gcvv::IndexedAsset> response = warehouseClient.ViewIndexedAssets(index);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::IndexedAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ViewIndexedAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexedAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewIndexedAssetsAsync</summary>
        public async Task ViewIndexedAssetsResourceNamesAsync()
        {
            // Snippet: ViewIndexedAssetsAsync(IndexName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexName index = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ViewIndexedAssetsResponse, gcvv::IndexedAsset> response = warehouseClient.ViewIndexedAssetsAsync(index);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::IndexedAsset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ViewIndexedAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexedAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexRequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateIndexRequest request = new gcvv::CreateIndexRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                IndexId = "",
                Index = new gcvv::Index(),
            };
            // Make the request
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> response = warehouseClient.CreateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> retrievedResponse = warehouseClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexRequestObjectAsync()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest, CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateIndexRequest request = new gcvv::CreateIndexRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                IndexId = "",
                Index = new gcvv::Index(),
            };
            // Make the request
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> response = await warehouseClient.CreateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> retrievedResponse = await warehouseClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex()
        {
            // Snippet: CreateIndex(string, Index, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> response = warehouseClient.CreateIndex(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> retrievedResponse = warehouseClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync()
        {
            // Snippet: CreateIndexAsync(string, Index, string, CallSettings)
            // Additional: CreateIndexAsync(string, Index, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> response = await warehouseClient.CreateIndexAsync(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> retrievedResponse = await warehouseClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexResourceNames()
        {
            // Snippet: CreateIndex(CorpusName, Index, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> response = warehouseClient.CreateIndex(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> retrievedResponse = warehouseClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexResourceNamesAsync()
        {
            // Snippet: CreateIndexAsync(CorpusName, Index, string, CallSettings)
            // Additional: CreateIndexAsync(CorpusName, Index, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::Index index = new gcvv::Index();
            string indexId = "";
            // Make the request
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> response = await warehouseClient.CreateIndexAsync(parent, index, indexId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::CreateIndexMetadata> retrievedResponse = await warehouseClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndex</summary>
        public void UpdateIndexRequestObject()
        {
            // Snippet: UpdateIndex(UpdateIndexRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateIndexRequest request = new gcvv::UpdateIndexRequest
            {
                Index = new gcvv::Index(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> response = warehouseClient.UpdateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> retrievedResponse = warehouseClient.PollOnceUpdateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexAsync</summary>
        public async Task UpdateIndexRequestObjectAsync()
        {
            // Snippet: UpdateIndexAsync(UpdateIndexRequest, CallSettings)
            // Additional: UpdateIndexAsync(UpdateIndexRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateIndexRequest request = new gcvv::UpdateIndexRequest
            {
                Index = new gcvv::Index(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> response = await warehouseClient.UpdateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> retrievedResponse = await warehouseClient.PollOnceUpdateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndex</summary>
        public void UpdateIndex()
        {
            // Snippet: UpdateIndex(Index, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::Index index = new gcvv::Index();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> response = warehouseClient.UpdateIndex(index, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> retrievedResponse = warehouseClient.PollOnceUpdateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexAsync</summary>
        public async Task UpdateIndexAsync()
        {
            // Snippet: UpdateIndexAsync(Index, FieldMask, CallSettings)
            // Additional: UpdateIndexAsync(Index, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::Index index = new gcvv::Index();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> response = await warehouseClient.UpdateIndexAsync(index, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Index, gcvv::UpdateIndexMetadata> retrievedResponse = await warehouseClient.PollOnceUpdateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexRequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetIndexRequest request = new gcvv::GetIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            gcvv::Index response = warehouseClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexRequestObjectAsync()
        {
            // Snippet: GetIndexAsync(GetIndexRequest, CallSettings)
            // Additional: GetIndexAsync(GetIndexRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetIndexRequest request = new gcvv::GetIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            gcvv::Index response = await warehouseClient.GetIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex()
        {
            // Snippet: GetIndex(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/indexes/[INDEX]";
            // Make the request
            gcvv::Index response = warehouseClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync()
        {
            // Snippet: GetIndexAsync(string, CallSettings)
            // Additional: GetIndexAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/indexes/[INDEX]";
            // Make the request
            gcvv::Index response = await warehouseClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexResourceNames()
        {
            // Snippet: GetIndex(IndexName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]");
            // Make the request
            gcvv::Index response = warehouseClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexResourceNamesAsync()
        {
            // Snippet: GetIndexAsync(IndexName, CallSettings)
            // Additional: GetIndexAsync(IndexName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]");
            // Make the request
            gcvv::Index response = await warehouseClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesRequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListIndexesRequest request = new gcvv::ListIndexesRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = warehouseClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesRequestObjectAsync()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListIndexesRequest request = new gcvv::ListIndexesRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = warehouseClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes()
        {
            // Snippet: ListIndexes(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = warehouseClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesAsync()
        {
            // Snippet: ListIndexesAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = warehouseClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesResourceNames()
        {
            // Snippet: ListIndexes(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = warehouseClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesResourceNamesAsync()
        {
            // Snippet: ListIndexesAsync(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexesResponse, gcvv::Index> response = warehouseClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexRequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteIndexRequest request = new gcvv::DeleteIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteIndexMetadata> response = warehouseClient.DeleteIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexMetadata> retrievedResponse = warehouseClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexRequestObjectAsync()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest, CallSettings)
            // Additional: DeleteIndexAsync(DeleteIndexRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteIndexRequest request = new gcvv::DeleteIndexRequest
            {
                IndexName = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteIndexMetadata> response = await warehouseClient.DeleteIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex()
        {
            // Snippet: DeleteIndex(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/indexes/[INDEX]";
            // Make the request
            Operation<Empty, gcvv::DeleteIndexMetadata> response = warehouseClient.DeleteIndex(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexMetadata> retrievedResponse = warehouseClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync()
        {
            // Snippet: DeleteIndexAsync(string, CallSettings)
            // Additional: DeleteIndexAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/indexes/[INDEX]";
            // Make the request
            Operation<Empty, gcvv::DeleteIndexMetadata> response = await warehouseClient.DeleteIndexAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexResourceNames()
        {
            // Snippet: DeleteIndex(IndexName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]");
            // Make the request
            Operation<Empty, gcvv::DeleteIndexMetadata> response = warehouseClient.DeleteIndex(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexMetadata> retrievedResponse = warehouseClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexResourceNamesAsync()
        {
            // Snippet: DeleteIndexAsync(IndexName, CallSettings)
            // Additional: DeleteIndexAsync(IndexName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexName name = gcvv::IndexName.FromProjectNumberLocationCorpusIndex("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[INDEX]");
            // Make the request
            Operation<Empty, gcvv::DeleteIndexMetadata> response = await warehouseClient.DeleteIndexAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCorpus</summary>
        public void CreateCorpusRequestObject()
        {
            // Snippet: CreateCorpus(CreateCorpusRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateCorpusRequest request = new gcvv::CreateCorpusRequest
            {
                Parent = "",
                Corpus = new gcvv::Corpus(),
            };
            // Make the request
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> response = warehouseClient.CreateCorpus(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Corpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> retrievedResponse = warehouseClient.PollOnceCreateCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Corpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCorpusAsync</summary>
        public async Task CreateCorpusRequestObjectAsync()
        {
            // Snippet: CreateCorpusAsync(CreateCorpusRequest, CallSettings)
            // Additional: CreateCorpusAsync(CreateCorpusRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateCorpusRequest request = new gcvv::CreateCorpusRequest
            {
                Parent = "",
                Corpus = new gcvv::Corpus(),
            };
            // Make the request
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> response = await warehouseClient.CreateCorpusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Corpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> retrievedResponse = await warehouseClient.PollOnceCreateCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Corpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCorpus</summary>
        public void CreateCorpus()
        {
            // Snippet: CreateCorpus(string, Corpus, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gcvv::Corpus corpus = new gcvv::Corpus();
            // Make the request
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> response = warehouseClient.CreateCorpus(parent, corpus);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Corpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> retrievedResponse = warehouseClient.PollOnceCreateCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Corpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCorpusAsync</summary>
        public async Task CreateCorpusAsync()
        {
            // Snippet: CreateCorpusAsync(string, Corpus, CallSettings)
            // Additional: CreateCorpusAsync(string, Corpus, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gcvv::Corpus corpus = new gcvv::Corpus();
            // Make the request
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> response = await warehouseClient.CreateCorpusAsync(parent, corpus);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Corpus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Corpus, gcvv::CreateCorpusMetadata> retrievedResponse = await warehouseClient.PollOnceCreateCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Corpus retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCorpus</summary>
        public void GetCorpusRequestObject()
        {
            // Snippet: GetCorpus(GetCorpusRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetCorpusRequest request = new gcvv::GetCorpusRequest
            {
                CorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            gcvv::Corpus response = warehouseClient.GetCorpus(request);
            // End snippet
        }

        /// <summary>Snippet for GetCorpusAsync</summary>
        public async Task GetCorpusRequestObjectAsync()
        {
            // Snippet: GetCorpusAsync(GetCorpusRequest, CallSettings)
            // Additional: GetCorpusAsync(GetCorpusRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetCorpusRequest request = new gcvv::GetCorpusRequest
            {
                CorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            gcvv::Corpus response = await warehouseClient.GetCorpusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCorpus</summary>
        public void GetCorpus()
        {
            // Snippet: GetCorpus(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            gcvv::Corpus response = warehouseClient.GetCorpus(name);
            // End snippet
        }

        /// <summary>Snippet for GetCorpusAsync</summary>
        public async Task GetCorpusAsync()
        {
            // Snippet: GetCorpusAsync(string, CallSettings)
            // Additional: GetCorpusAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            gcvv::Corpus response = await warehouseClient.GetCorpusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCorpus</summary>
        public void GetCorpusResourceNames()
        {
            // Snippet: GetCorpus(CorpusName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName name = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            gcvv::Corpus response = warehouseClient.GetCorpus(name);
            // End snippet
        }

        /// <summary>Snippet for GetCorpusAsync</summary>
        public async Task GetCorpusResourceNamesAsync()
        {
            // Snippet: GetCorpusAsync(CorpusName, CallSettings)
            // Additional: GetCorpusAsync(CorpusName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName name = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            gcvv::Corpus response = await warehouseClient.GetCorpusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCorpus</summary>
        public void UpdateCorpusRequestObject()
        {
            // Snippet: UpdateCorpus(UpdateCorpusRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateCorpusRequest request = new gcvv::UpdateCorpusRequest
            {
                Corpus = new gcvv::Corpus(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Corpus response = warehouseClient.UpdateCorpus(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCorpusAsync</summary>
        public async Task UpdateCorpusRequestObjectAsync()
        {
            // Snippet: UpdateCorpusAsync(UpdateCorpusRequest, CallSettings)
            // Additional: UpdateCorpusAsync(UpdateCorpusRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateCorpusRequest request = new gcvv::UpdateCorpusRequest
            {
                Corpus = new gcvv::Corpus(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Corpus response = await warehouseClient.UpdateCorpusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCorpus</summary>
        public void UpdateCorpus()
        {
            // Snippet: UpdateCorpus(Corpus, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::Corpus corpus = new gcvv::Corpus();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Corpus response = warehouseClient.UpdateCorpus(corpus, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCorpusAsync</summary>
        public async Task UpdateCorpusAsync()
        {
            // Snippet: UpdateCorpusAsync(Corpus, FieldMask, CallSettings)
            // Additional: UpdateCorpusAsync(Corpus, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::Corpus corpus = new gcvv::Corpus();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Corpus response = await warehouseClient.UpdateCorpusAsync(corpus, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListCorpora</summary>
        public void ListCorporaRequestObject()
        {
            // Snippet: ListCorpora(ListCorporaRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListCorporaRequest request = new gcvv::ListCorporaRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ListCorporaResponse, gcvv::Corpus> response = warehouseClient.ListCorpora(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Corpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCorporaResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Corpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Corpus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Corpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCorporaAsync</summary>
        public async Task ListCorporaRequestObjectAsync()
        {
            // Snippet: ListCorporaAsync(ListCorporaRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListCorporaRequest request = new gcvv::ListCorporaRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCorporaResponse, gcvv::Corpus> response = warehouseClient.ListCorporaAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Corpus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListCorporaResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Corpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Corpus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Corpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCorpora</summary>
        public void ListCorpora()
        {
            // Snippet: ListCorpora(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcvv::ListCorporaResponse, gcvv::Corpus> response = warehouseClient.ListCorpora(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Corpus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCorporaResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Corpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Corpus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Corpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCorporaAsync</summary>
        public async Task ListCorporaAsync()
        {
            // Snippet: ListCorporaAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCorporaResponse, gcvv::Corpus> response = warehouseClient.ListCorporaAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Corpus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListCorporaResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Corpus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Corpus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Corpus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteCorpus</summary>
        public void DeleteCorpusRequestObject()
        {
            // Snippet: DeleteCorpus(DeleteCorpusRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteCorpusRequest request = new gcvv::DeleteCorpusRequest
            {
                CorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            warehouseClient.DeleteCorpus(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCorpusAsync</summary>
        public async Task DeleteCorpusRequestObjectAsync()
        {
            // Snippet: DeleteCorpusAsync(DeleteCorpusRequest, CallSettings)
            // Additional: DeleteCorpusAsync(DeleteCorpusRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteCorpusRequest request = new gcvv::DeleteCorpusRequest
            {
                CorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            await warehouseClient.DeleteCorpusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCorpus</summary>
        public void DeleteCorpus()
        {
            // Snippet: DeleteCorpus(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            warehouseClient.DeleteCorpus(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCorpusAsync</summary>
        public async Task DeleteCorpusAsync()
        {
            // Snippet: DeleteCorpusAsync(string, CallSettings)
            // Additional: DeleteCorpusAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            await warehouseClient.DeleteCorpusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCorpus</summary>
        public void DeleteCorpusResourceNames()
        {
            // Snippet: DeleteCorpus(CorpusName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName name = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            warehouseClient.DeleteCorpus(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCorpusAsync</summary>
        public async Task DeleteCorpusResourceNamesAsync()
        {
            // Snippet: DeleteCorpusAsync(CorpusName, CallSettings)
            // Additional: DeleteCorpusAsync(CorpusName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName name = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            await warehouseClient.DeleteCorpusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeCorpus</summary>
        public void AnalyzeCorpusRequestObject()
        {
            // Snippet: AnalyzeCorpus(AnalyzeCorpusRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AnalyzeCorpusRequest request = new gcvv::AnalyzeCorpusRequest
            {
                CorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            Operation<gcvv::AnalyzeCorpusResponse, gcvv::AnalyzeCorpusMetadata> response = warehouseClient.AnalyzeCorpus(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::AnalyzeCorpusResponse, gcvv::AnalyzeCorpusMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::AnalyzeCorpusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::AnalyzeCorpusResponse, gcvv::AnalyzeCorpusMetadata> retrievedResponse = warehouseClient.PollOnceAnalyzeCorpus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::AnalyzeCorpusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeCorpusAsync</summary>
        public async Task AnalyzeCorpusRequestObjectAsync()
        {
            // Snippet: AnalyzeCorpusAsync(AnalyzeCorpusRequest, CallSettings)
            // Additional: AnalyzeCorpusAsync(AnalyzeCorpusRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AnalyzeCorpusRequest request = new gcvv::AnalyzeCorpusRequest
            {
                CorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            Operation<gcvv::AnalyzeCorpusResponse, gcvv::AnalyzeCorpusMetadata> response = await warehouseClient.AnalyzeCorpusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::AnalyzeCorpusResponse, gcvv::AnalyzeCorpusMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::AnalyzeCorpusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::AnalyzeCorpusResponse, gcvv::AnalyzeCorpusMetadata> retrievedResponse = await warehouseClient.PollOnceAnalyzeCorpusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::AnalyzeCorpusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataSchema</summary>
        public void CreateDataSchemaRequestObject()
        {
            // Snippet: CreateDataSchema(CreateDataSchemaRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateDataSchemaRequest request = new gcvv::CreateDataSchemaRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                DataSchema = new gcvv::DataSchema(),
            };
            // Make the request
            gcvv::DataSchema response = warehouseClient.CreateDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSchemaAsync</summary>
        public async Task CreateDataSchemaRequestObjectAsync()
        {
            // Snippet: CreateDataSchemaAsync(CreateDataSchemaRequest, CallSettings)
            // Additional: CreateDataSchemaAsync(CreateDataSchemaRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateDataSchemaRequest request = new gcvv::CreateDataSchemaRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                DataSchema = new gcvv::DataSchema(),
            };
            // Make the request
            gcvv::DataSchema response = await warehouseClient.CreateDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSchema</summary>
        public void CreateDataSchema()
        {
            // Snippet: CreateDataSchema(string, DataSchema, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::DataSchema dataSchema = new gcvv::DataSchema();
            // Make the request
            gcvv::DataSchema response = warehouseClient.CreateDataSchema(parent, dataSchema);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSchemaAsync</summary>
        public async Task CreateDataSchemaAsync()
        {
            // Snippet: CreateDataSchemaAsync(string, DataSchema, CallSettings)
            // Additional: CreateDataSchemaAsync(string, DataSchema, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::DataSchema dataSchema = new gcvv::DataSchema();
            // Make the request
            gcvv::DataSchema response = await warehouseClient.CreateDataSchemaAsync(parent, dataSchema);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSchema</summary>
        public void CreateDataSchemaResourceNames()
        {
            // Snippet: CreateDataSchema(CorpusName, DataSchema, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::DataSchema dataSchema = new gcvv::DataSchema();
            // Make the request
            gcvv::DataSchema response = warehouseClient.CreateDataSchema(parent, dataSchema);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSchemaAsync</summary>
        public async Task CreateDataSchemaResourceNamesAsync()
        {
            // Snippet: CreateDataSchemaAsync(CorpusName, DataSchema, CallSettings)
            // Additional: CreateDataSchemaAsync(CorpusName, DataSchema, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::DataSchema dataSchema = new gcvv::DataSchema();
            // Make the request
            gcvv::DataSchema response = await warehouseClient.CreateDataSchemaAsync(parent, dataSchema);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSchema</summary>
        public void UpdateDataSchemaRequestObject()
        {
            // Snippet: UpdateDataSchema(UpdateDataSchemaRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateDataSchemaRequest request = new gcvv::UpdateDataSchemaRequest
            {
                DataSchema = new gcvv::DataSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::DataSchema response = warehouseClient.UpdateDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSchemaAsync</summary>
        public async Task UpdateDataSchemaRequestObjectAsync()
        {
            // Snippet: UpdateDataSchemaAsync(UpdateDataSchemaRequest, CallSettings)
            // Additional: UpdateDataSchemaAsync(UpdateDataSchemaRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateDataSchemaRequest request = new gcvv::UpdateDataSchemaRequest
            {
                DataSchema = new gcvv::DataSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::DataSchema response = await warehouseClient.UpdateDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSchema</summary>
        public void UpdateDataSchema()
        {
            // Snippet: UpdateDataSchema(DataSchema, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DataSchema dataSchema = new gcvv::DataSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::DataSchema response = warehouseClient.UpdateDataSchema(dataSchema, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSchemaAsync</summary>
        public async Task UpdateDataSchemaAsync()
        {
            // Snippet: UpdateDataSchemaAsync(DataSchema, FieldMask, CallSettings)
            // Additional: UpdateDataSchemaAsync(DataSchema, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DataSchema dataSchema = new gcvv::DataSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::DataSchema response = await warehouseClient.UpdateDataSchemaAsync(dataSchema, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDataSchema</summary>
        public void GetDataSchemaRequestObject()
        {
            // Snippet: GetDataSchema(GetDataSchemaRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetDataSchemaRequest request = new gcvv::GetDataSchemaRequest
            {
                DataSchemaName = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]"),
            };
            // Make the request
            gcvv::DataSchema response = warehouseClient.GetDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSchemaAsync</summary>
        public async Task GetDataSchemaRequestObjectAsync()
        {
            // Snippet: GetDataSchemaAsync(GetDataSchemaRequest, CallSettings)
            // Additional: GetDataSchemaAsync(GetDataSchemaRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetDataSchemaRequest request = new gcvv::GetDataSchemaRequest
            {
                DataSchemaName = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]"),
            };
            // Make the request
            gcvv::DataSchema response = await warehouseClient.GetDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSchema</summary>
        public void GetDataSchema()
        {
            // Snippet: GetDataSchema(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/dataSchemas/[DATA_SCHEMA]";
            // Make the request
            gcvv::DataSchema response = warehouseClient.GetDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSchemaAsync</summary>
        public async Task GetDataSchemaAsync()
        {
            // Snippet: GetDataSchemaAsync(string, CallSettings)
            // Additional: GetDataSchemaAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/dataSchemas/[DATA_SCHEMA]";
            // Make the request
            gcvv::DataSchema response = await warehouseClient.GetDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSchema</summary>
        public void GetDataSchemaResourceNames()
        {
            // Snippet: GetDataSchema(DataSchemaName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DataSchemaName name = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]");
            // Make the request
            gcvv::DataSchema response = warehouseClient.GetDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSchemaAsync</summary>
        public async Task GetDataSchemaResourceNamesAsync()
        {
            // Snippet: GetDataSchemaAsync(DataSchemaName, CallSettings)
            // Additional: GetDataSchemaAsync(DataSchemaName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DataSchemaName name = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]");
            // Make the request
            gcvv::DataSchema response = await warehouseClient.GetDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSchema</summary>
        public void DeleteDataSchemaRequestObject()
        {
            // Snippet: DeleteDataSchema(DeleteDataSchemaRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteDataSchemaRequest request = new gcvv::DeleteDataSchemaRequest
            {
                DataSchemaName = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]"),
            };
            // Make the request
            warehouseClient.DeleteDataSchema(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSchemaAsync</summary>
        public async Task DeleteDataSchemaRequestObjectAsync()
        {
            // Snippet: DeleteDataSchemaAsync(DeleteDataSchemaRequest, CallSettings)
            // Additional: DeleteDataSchemaAsync(DeleteDataSchemaRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteDataSchemaRequest request = new gcvv::DeleteDataSchemaRequest
            {
                DataSchemaName = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]"),
            };
            // Make the request
            await warehouseClient.DeleteDataSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSchema</summary>
        public void DeleteDataSchema()
        {
            // Snippet: DeleteDataSchema(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/dataSchemas/[DATA_SCHEMA]";
            // Make the request
            warehouseClient.DeleteDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSchemaAsync</summary>
        public async Task DeleteDataSchemaAsync()
        {
            // Snippet: DeleteDataSchemaAsync(string, CallSettings)
            // Additional: DeleteDataSchemaAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/dataSchemas/[DATA_SCHEMA]";
            // Make the request
            await warehouseClient.DeleteDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSchema</summary>
        public void DeleteDataSchemaResourceNames()
        {
            // Snippet: DeleteDataSchema(DataSchemaName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DataSchemaName name = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]");
            // Make the request
            warehouseClient.DeleteDataSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSchemaAsync</summary>
        public async Task DeleteDataSchemaResourceNamesAsync()
        {
            // Snippet: DeleteDataSchemaAsync(DataSchemaName, CallSettings)
            // Additional: DeleteDataSchemaAsync(DataSchemaName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DataSchemaName name = gcvv::DataSchemaName.FromProjectNumberLocationCorpusDataSchema("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[DATA_SCHEMA]");
            // Make the request
            await warehouseClient.DeleteDataSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataSchemas</summary>
        public void ListDataSchemasRequestObject()
        {
            // Snippet: ListDataSchemas(ListDataSchemasRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListDataSchemasRequest request = new gcvv::ListDataSchemasRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedEnumerable<gcvv::ListDataSchemasResponse, gcvv::DataSchema> response = warehouseClient.ListDataSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::DataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::DataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::DataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::DataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSchemasAsync</summary>
        public async Task ListDataSchemasRequestObjectAsync()
        {
            // Snippet: ListDataSchemasAsync(ListDataSchemasRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListDataSchemasRequest request = new gcvv::ListDataSchemasRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListDataSchemasResponse, gcvv::DataSchema> response = warehouseClient.ListDataSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::DataSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListDataSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::DataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::DataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::DataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSchemas</summary>
        public void ListDataSchemas()
        {
            // Snippet: ListDataSchemas(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedEnumerable<gcvv::ListDataSchemasResponse, gcvv::DataSchema> response = warehouseClient.ListDataSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::DataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::DataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::DataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::DataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSchemasAsync</summary>
        public async Task ListDataSchemasAsync()
        {
            // Snippet: ListDataSchemasAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListDataSchemasResponse, gcvv::DataSchema> response = warehouseClient.ListDataSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::DataSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListDataSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::DataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::DataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::DataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSchemas</summary>
        public void ListDataSchemasResourceNames()
        {
            // Snippet: ListDataSchemas(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedEnumerable<gcvv::ListDataSchemasResponse, gcvv::DataSchema> response = warehouseClient.ListDataSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::DataSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListDataSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::DataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::DataSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::DataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSchemasAsync</summary>
        public async Task ListDataSchemasResourceNamesAsync()
        {
            // Snippet: ListDataSchemasAsync(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListDataSchemasResponse, gcvv::DataSchema> response = warehouseClient.ListDataSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::DataSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListDataSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::DataSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::DataSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::DataSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotationRequestObject()
        {
            // Snippet: CreateAnnotation(CreateAnnotationRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateAnnotationRequest request = new gcvv::CreateAnnotationRequest
            {
                ParentAsAssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                Annotation = new gcvv::Annotation(),
                AnnotationId = "",
            };
            // Make the request
            gcvv::Annotation response = warehouseClient.CreateAnnotation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationRequestObjectAsync()
        {
            // Snippet: CreateAnnotationAsync(CreateAnnotationRequest, CallSettings)
            // Additional: CreateAnnotationAsync(CreateAnnotationRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateAnnotationRequest request = new gcvv::CreateAnnotationRequest
            {
                ParentAsAssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                Annotation = new gcvv::Annotation(),
                AnnotationId = "",
            };
            // Make the request
            gcvv::Annotation response = await warehouseClient.CreateAnnotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotation()
        {
            // Snippet: CreateAnnotation(string, Annotation, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            gcvv::Annotation annotation = new gcvv::Annotation();
            string annotationId = "";
            // Make the request
            gcvv::Annotation response = warehouseClient.CreateAnnotation(parent, annotation, annotationId);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationAsync()
        {
            // Snippet: CreateAnnotationAsync(string, Annotation, string, CallSettings)
            // Additional: CreateAnnotationAsync(string, Annotation, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            gcvv::Annotation annotation = new gcvv::Annotation();
            string annotationId = "";
            // Make the request
            gcvv::Annotation response = await warehouseClient.CreateAnnotationAsync(parent, annotation, annotationId);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotationResourceNames()
        {
            // Snippet: CreateAnnotation(AssetName, Annotation, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AssetName parent = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            gcvv::Annotation annotation = new gcvv::Annotation();
            string annotationId = "";
            // Make the request
            gcvv::Annotation response = warehouseClient.CreateAnnotation(parent, annotation, annotationId);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationResourceNamesAsync()
        {
            // Snippet: CreateAnnotationAsync(AssetName, Annotation, string, CallSettings)
            // Additional: CreateAnnotationAsync(AssetName, Annotation, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AssetName parent = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            gcvv::Annotation annotation = new gcvv::Annotation();
            string annotationId = "";
            // Make the request
            gcvv::Annotation response = await warehouseClient.CreateAnnotationAsync(parent, annotation, annotationId);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotation</summary>
        public void GetAnnotationRequestObject()
        {
            // Snippet: GetAnnotation(GetAnnotationRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetAnnotationRequest request = new gcvv::GetAnnotationRequest
            {
                AnnotationName = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]"),
            };
            // Make the request
            gcvv::Annotation response = warehouseClient.GetAnnotation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationAsync</summary>
        public async Task GetAnnotationRequestObjectAsync()
        {
            // Snippet: GetAnnotationAsync(GetAnnotationRequest, CallSettings)
            // Additional: GetAnnotationAsync(GetAnnotationRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetAnnotationRequest request = new gcvv::GetAnnotationRequest
            {
                AnnotationName = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]"),
            };
            // Make the request
            gcvv::Annotation response = await warehouseClient.GetAnnotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotation</summary>
        public void GetAnnotation()
        {
            // Snippet: GetAnnotation(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]/annotations/[ANNOTATION]";
            // Make the request
            gcvv::Annotation response = warehouseClient.GetAnnotation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationAsync</summary>
        public async Task GetAnnotationAsync()
        {
            // Snippet: GetAnnotationAsync(string, CallSettings)
            // Additional: GetAnnotationAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]/annotations/[ANNOTATION]";
            // Make the request
            gcvv::Annotation response = await warehouseClient.GetAnnotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotation</summary>
        public void GetAnnotationResourceNames()
        {
            // Snippet: GetAnnotation(AnnotationName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AnnotationName name = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]");
            // Make the request
            gcvv::Annotation response = warehouseClient.GetAnnotation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationAsync</summary>
        public async Task GetAnnotationResourceNamesAsync()
        {
            // Snippet: GetAnnotationAsync(AnnotationName, CallSettings)
            // Additional: GetAnnotationAsync(AnnotationName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AnnotationName name = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]");
            // Make the request
            gcvv::Annotation response = await warehouseClient.GetAnnotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotationsRequestObject()
        {
            // Snippet: ListAnnotations(ListAnnotationsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListAnnotationsRequest request = new gcvv::ListAnnotationsRequest
            {
                ParentAsAssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ListAnnotationsResponse, gcvv::Annotation> response = warehouseClient.ListAnnotations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsRequestObjectAsync()
        {
            // Snippet: ListAnnotationsAsync(ListAnnotationsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListAnnotationsRequest request = new gcvv::ListAnnotationsRequest
            {
                ParentAsAssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListAnnotationsResponse, gcvv::Annotation> response = warehouseClient.ListAnnotationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotations()
        {
            // Snippet: ListAnnotations(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            // Make the request
            PagedEnumerable<gcvv::ListAnnotationsResponse, gcvv::Annotation> response = warehouseClient.ListAnnotations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsAsync()
        {
            // Snippet: ListAnnotationsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListAnnotationsResponse, gcvv::Annotation> response = warehouseClient.ListAnnotationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotationsResourceNames()
        {
            // Snippet: ListAnnotations(AssetName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AssetName parent = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            // Make the request
            PagedEnumerable<gcvv::ListAnnotationsResponse, gcvv::Annotation> response = warehouseClient.ListAnnotations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsResourceNamesAsync()
        {
            // Snippet: ListAnnotationsAsync(AssetName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AssetName parent = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListAnnotationsResponse, gcvv::Annotation> response = warehouseClient.ListAnnotationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateAnnotation</summary>
        public void UpdateAnnotationRequestObject()
        {
            // Snippet: UpdateAnnotation(UpdateAnnotationRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateAnnotationRequest request = new gcvv::UpdateAnnotationRequest
            {
                Annotation = new gcvv::Annotation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Annotation response = warehouseClient.UpdateAnnotation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAnnotationAsync</summary>
        public async Task UpdateAnnotationRequestObjectAsync()
        {
            // Snippet: UpdateAnnotationAsync(UpdateAnnotationRequest, CallSettings)
            // Additional: UpdateAnnotationAsync(UpdateAnnotationRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateAnnotationRequest request = new gcvv::UpdateAnnotationRequest
            {
                Annotation = new gcvv::Annotation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Annotation response = await warehouseClient.UpdateAnnotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAnnotation</summary>
        public void UpdateAnnotation()
        {
            // Snippet: UpdateAnnotation(Annotation, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::Annotation annotation = new gcvv::Annotation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Annotation response = warehouseClient.UpdateAnnotation(annotation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAnnotationAsync</summary>
        public async Task UpdateAnnotationAsync()
        {
            // Snippet: UpdateAnnotationAsync(Annotation, FieldMask, CallSettings)
            // Additional: UpdateAnnotationAsync(Annotation, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::Annotation annotation = new gcvv::Annotation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Annotation response = await warehouseClient.UpdateAnnotationAsync(annotation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotation</summary>
        public void DeleteAnnotationRequestObject()
        {
            // Snippet: DeleteAnnotation(DeleteAnnotationRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteAnnotationRequest request = new gcvv::DeleteAnnotationRequest
            {
                AnnotationName = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]"),
            };
            // Make the request
            warehouseClient.DeleteAnnotation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationAsync</summary>
        public async Task DeleteAnnotationRequestObjectAsync()
        {
            // Snippet: DeleteAnnotationAsync(DeleteAnnotationRequest, CallSettings)
            // Additional: DeleteAnnotationAsync(DeleteAnnotationRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteAnnotationRequest request = new gcvv::DeleteAnnotationRequest
            {
                AnnotationName = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]"),
            };
            // Make the request
            await warehouseClient.DeleteAnnotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotation</summary>
        public void DeleteAnnotation()
        {
            // Snippet: DeleteAnnotation(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]/annotations/[ANNOTATION]";
            // Make the request
            warehouseClient.DeleteAnnotation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationAsync</summary>
        public async Task DeleteAnnotationAsync()
        {
            // Snippet: DeleteAnnotationAsync(string, CallSettings)
            // Additional: DeleteAnnotationAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/assets/[ASSET]/annotations/[ANNOTATION]";
            // Make the request
            await warehouseClient.DeleteAnnotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotation</summary>
        public void DeleteAnnotationResourceNames()
        {
            // Snippet: DeleteAnnotation(AnnotationName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AnnotationName name = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]");
            // Make the request
            warehouseClient.DeleteAnnotation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationAsync</summary>
        public async Task DeleteAnnotationResourceNamesAsync()
        {
            // Snippet: DeleteAnnotationAsync(AnnotationName, CallSettings)
            // Additional: DeleteAnnotationAsync(AnnotationName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AnnotationName name = gcvv::AnnotationName.FromProjectNumberLocationCorpusAssetAnnotation("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]", "[ANNOTATION]");
            // Make the request
            await warehouseClient.DeleteAnnotationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for IngestAsset</summary>
        public async Task IngestAsset()
        {
            // Snippet: IngestAsset(CallSettings, BidirectionalStreamingSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize streaming call, retrieving the stream object
            using gcvv::WarehouseClient.IngestAssetStream response = warehouseClient.IngestAsset();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<gcvv::IngestAssetResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    gcvv::IngestAssetResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                gcvv::IngestAssetRequest request = new gcvv::IngestAssetRequest
                {
                    Config = new gcvv::IngestAssetRequest.Types.Config(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for ClipAsset</summary>
        public void ClipAssetRequestObject()
        {
            // Snippet: ClipAsset(ClipAssetRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ClipAssetRequest request = new gcvv::ClipAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                TemporalPartition = new gcvv::Partition.Types.TemporalPartition(),
            };
            // Make the request
            gcvv::ClipAssetResponse response = warehouseClient.ClipAsset(request);
            // End snippet
        }

        /// <summary>Snippet for ClipAssetAsync</summary>
        public async Task ClipAssetRequestObjectAsync()
        {
            // Snippet: ClipAssetAsync(ClipAssetRequest, CallSettings)
            // Additional: ClipAssetAsync(ClipAssetRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ClipAssetRequest request = new gcvv::ClipAssetRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                TemporalPartition = new gcvv::Partition.Types.TemporalPartition(),
            };
            // Make the request
            gcvv::ClipAssetResponse response = await warehouseClient.ClipAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateHlsUri</summary>
        public void GenerateHlsUriRequestObject()
        {
            // Snippet: GenerateHlsUri(GenerateHlsUriRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GenerateHlsUriRequest request = new gcvv::GenerateHlsUriRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                TemporalPartitions =
                {
                    new gcvv::Partition.Types.TemporalPartition(),
                },
                LiveViewEnabled = false,
            };
            // Make the request
            gcvv::GenerateHlsUriResponse response = warehouseClient.GenerateHlsUri(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateHlsUriAsync</summary>
        public async Task GenerateHlsUriRequestObjectAsync()
        {
            // Snippet: GenerateHlsUriAsync(GenerateHlsUriRequest, CallSettings)
            // Additional: GenerateHlsUriAsync(GenerateHlsUriRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GenerateHlsUriRequest request = new gcvv::GenerateHlsUriRequest
            {
                AssetName = gcvv::AssetName.FromProjectNumberLocationCorpusAsset("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[ASSET]"),
                TemporalPartitions =
                {
                    new gcvv::Partition.Types.TemporalPartition(),
                },
                LiveViewEnabled = false,
            };
            // Make the request
            gcvv::GenerateHlsUriResponse response = await warehouseClient.GenerateHlsUriAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportAssets</summary>
        public void ImportAssetsRequestObject()
        {
            // Snippet: ImportAssets(ImportAssetsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ImportAssetsRequest request = new gcvv::ImportAssetsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                AssetsGcsUri = "",
            };
            // Make the request
            Operation<gcvv::ImportAssetsResponse, gcvv::ImportAssetsMetadata> response = warehouseClient.ImportAssets(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::ImportAssetsResponse, gcvv::ImportAssetsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::ImportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::ImportAssetsResponse, gcvv::ImportAssetsMetadata> retrievedResponse = warehouseClient.PollOnceImportAssets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::ImportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAssetsAsync</summary>
        public async Task ImportAssetsRequestObjectAsync()
        {
            // Snippet: ImportAssetsAsync(ImportAssetsRequest, CallSettings)
            // Additional: ImportAssetsAsync(ImportAssetsRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ImportAssetsRequest request = new gcvv::ImportAssetsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                AssetsGcsUri = "",
            };
            // Make the request
            Operation<gcvv::ImportAssetsResponse, gcvv::ImportAssetsMetadata> response = await warehouseClient.ImportAssetsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::ImportAssetsResponse, gcvv::ImportAssetsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::ImportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::ImportAssetsResponse, gcvv::ImportAssetsMetadata> retrievedResponse = await warehouseClient.PollOnceImportAssetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::ImportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSearchConfig</summary>
        public void CreateSearchConfigRequestObject()
        {
            // Snippet: CreateSearchConfig(CreateSearchConfigRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateSearchConfigRequest request = new gcvv::CreateSearchConfigRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                SearchConfig = new gcvv::SearchConfig(),
                SearchConfigId = "",
            };
            // Make the request
            gcvv::SearchConfig response = warehouseClient.CreateSearchConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchConfigAsync</summary>
        public async Task CreateSearchConfigRequestObjectAsync()
        {
            // Snippet: CreateSearchConfigAsync(CreateSearchConfigRequest, CallSettings)
            // Additional: CreateSearchConfigAsync(CreateSearchConfigRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateSearchConfigRequest request = new gcvv::CreateSearchConfigRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                SearchConfig = new gcvv::SearchConfig(),
                SearchConfigId = "",
            };
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.CreateSearchConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchConfig</summary>
        public void CreateSearchConfig()
        {
            // Snippet: CreateSearchConfig(string, SearchConfig, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::SearchConfig searchConfig = new gcvv::SearchConfig();
            string searchConfigId = "";
            // Make the request
            gcvv::SearchConfig response = warehouseClient.CreateSearchConfig(parent, searchConfig, searchConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchConfigAsync</summary>
        public async Task CreateSearchConfigAsync()
        {
            // Snippet: CreateSearchConfigAsync(string, SearchConfig, string, CallSettings)
            // Additional: CreateSearchConfigAsync(string, SearchConfig, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::SearchConfig searchConfig = new gcvv::SearchConfig();
            string searchConfigId = "";
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.CreateSearchConfigAsync(parent, searchConfig, searchConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchConfig</summary>
        public void CreateSearchConfigResourceNames()
        {
            // Snippet: CreateSearchConfig(CorpusName, SearchConfig, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::SearchConfig searchConfig = new gcvv::SearchConfig();
            string searchConfigId = "";
            // Make the request
            gcvv::SearchConfig response = warehouseClient.CreateSearchConfig(parent, searchConfig, searchConfigId);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchConfigAsync</summary>
        public async Task CreateSearchConfigResourceNamesAsync()
        {
            // Snippet: CreateSearchConfigAsync(CorpusName, SearchConfig, string, CallSettings)
            // Additional: CreateSearchConfigAsync(CorpusName, SearchConfig, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::SearchConfig searchConfig = new gcvv::SearchConfig();
            string searchConfigId = "";
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.CreateSearchConfigAsync(parent, searchConfig, searchConfigId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchConfig</summary>
        public void UpdateSearchConfigRequestObject()
        {
            // Snippet: UpdateSearchConfig(UpdateSearchConfigRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateSearchConfigRequest request = new gcvv::UpdateSearchConfigRequest
            {
                SearchConfig = new gcvv::SearchConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::SearchConfig response = warehouseClient.UpdateSearchConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchConfigAsync</summary>
        public async Task UpdateSearchConfigRequestObjectAsync()
        {
            // Snippet: UpdateSearchConfigAsync(UpdateSearchConfigRequest, CallSettings)
            // Additional: UpdateSearchConfigAsync(UpdateSearchConfigRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateSearchConfigRequest request = new gcvv::UpdateSearchConfigRequest
            {
                SearchConfig = new gcvv::SearchConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.UpdateSearchConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchConfig</summary>
        public void UpdateSearchConfig()
        {
            // Snippet: UpdateSearchConfig(SearchConfig, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchConfig searchConfig = new gcvv::SearchConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::SearchConfig response = warehouseClient.UpdateSearchConfig(searchConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchConfigAsync</summary>
        public async Task UpdateSearchConfigAsync()
        {
            // Snippet: UpdateSearchConfigAsync(SearchConfig, FieldMask, CallSettings)
            // Additional: UpdateSearchConfigAsync(SearchConfig, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchConfig searchConfig = new gcvv::SearchConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.UpdateSearchConfigAsync(searchConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetSearchConfig</summary>
        public void GetSearchConfigRequestObject()
        {
            // Snippet: GetSearchConfig(GetSearchConfigRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetSearchConfigRequest request = new gcvv::GetSearchConfigRequest
            {
                SearchConfigName = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]"),
            };
            // Make the request
            gcvv::SearchConfig response = warehouseClient.GetSearchConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchConfigAsync</summary>
        public async Task GetSearchConfigRequestObjectAsync()
        {
            // Snippet: GetSearchConfigAsync(GetSearchConfigRequest, CallSettings)
            // Additional: GetSearchConfigAsync(GetSearchConfigRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetSearchConfigRequest request = new gcvv::GetSearchConfigRequest
            {
                SearchConfigName = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]"),
            };
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.GetSearchConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchConfig</summary>
        public void GetSearchConfig()
        {
            // Snippet: GetSearchConfig(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchConfigs/[SEARCH_CONFIG]";
            // Make the request
            gcvv::SearchConfig response = warehouseClient.GetSearchConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchConfigAsync</summary>
        public async Task GetSearchConfigAsync()
        {
            // Snippet: GetSearchConfigAsync(string, CallSettings)
            // Additional: GetSearchConfigAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchConfigs/[SEARCH_CONFIG]";
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.GetSearchConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchConfig</summary>
        public void GetSearchConfigResourceNames()
        {
            // Snippet: GetSearchConfig(SearchConfigName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchConfigName name = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]");
            // Make the request
            gcvv::SearchConfig response = warehouseClient.GetSearchConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchConfigAsync</summary>
        public async Task GetSearchConfigResourceNamesAsync()
        {
            // Snippet: GetSearchConfigAsync(SearchConfigName, CallSettings)
            // Additional: GetSearchConfigAsync(SearchConfigName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchConfigName name = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]");
            // Make the request
            gcvv::SearchConfig response = await warehouseClient.GetSearchConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchConfig</summary>
        public void DeleteSearchConfigRequestObject()
        {
            // Snippet: DeleteSearchConfig(DeleteSearchConfigRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteSearchConfigRequest request = new gcvv::DeleteSearchConfigRequest
            {
                SearchConfigName = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]"),
            };
            // Make the request
            warehouseClient.DeleteSearchConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchConfigAsync</summary>
        public async Task DeleteSearchConfigRequestObjectAsync()
        {
            // Snippet: DeleteSearchConfigAsync(DeleteSearchConfigRequest, CallSettings)
            // Additional: DeleteSearchConfigAsync(DeleteSearchConfigRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteSearchConfigRequest request = new gcvv::DeleteSearchConfigRequest
            {
                SearchConfigName = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]"),
            };
            // Make the request
            await warehouseClient.DeleteSearchConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchConfig</summary>
        public void DeleteSearchConfig()
        {
            // Snippet: DeleteSearchConfig(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchConfigs/[SEARCH_CONFIG]";
            // Make the request
            warehouseClient.DeleteSearchConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchConfigAsync</summary>
        public async Task DeleteSearchConfigAsync()
        {
            // Snippet: DeleteSearchConfigAsync(string, CallSettings)
            // Additional: DeleteSearchConfigAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchConfigs/[SEARCH_CONFIG]";
            // Make the request
            await warehouseClient.DeleteSearchConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchConfig</summary>
        public void DeleteSearchConfigResourceNames()
        {
            // Snippet: DeleteSearchConfig(SearchConfigName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchConfigName name = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]");
            // Make the request
            warehouseClient.DeleteSearchConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchConfigAsync</summary>
        public async Task DeleteSearchConfigResourceNamesAsync()
        {
            // Snippet: DeleteSearchConfigAsync(SearchConfigName, CallSettings)
            // Additional: DeleteSearchConfigAsync(SearchConfigName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchConfigName name = gcvv::SearchConfigName.FromProjectNumberLocationCorpusSearchConfig("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_CONFIG]");
            // Make the request
            await warehouseClient.DeleteSearchConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSearchConfigs</summary>
        public void ListSearchConfigsRequestObject()
        {
            // Snippet: ListSearchConfigs(ListSearchConfigsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListSearchConfigsRequest request = new gcvv::ListSearchConfigsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedEnumerable<gcvv::ListSearchConfigsResponse, gcvv::SearchConfig> response = warehouseClient.ListSearchConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListSearchConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchConfigsAsync</summary>
        public async Task ListSearchConfigsRequestObjectAsync()
        {
            // Snippet: ListSearchConfigsAsync(ListSearchConfigsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListSearchConfigsRequest request = new gcvv::ListSearchConfigsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListSearchConfigsResponse, gcvv::SearchConfig> response = warehouseClient.ListSearchConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListSearchConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchConfigs</summary>
        public void ListSearchConfigs()
        {
            // Snippet: ListSearchConfigs(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedEnumerable<gcvv::ListSearchConfigsResponse, gcvv::SearchConfig> response = warehouseClient.ListSearchConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListSearchConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchConfigsAsync</summary>
        public async Task ListSearchConfigsAsync()
        {
            // Snippet: ListSearchConfigsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListSearchConfigsResponse, gcvv::SearchConfig> response = warehouseClient.ListSearchConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListSearchConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchConfigs</summary>
        public void ListSearchConfigsResourceNames()
        {
            // Snippet: ListSearchConfigs(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedEnumerable<gcvv::ListSearchConfigsResponse, gcvv::SearchConfig> response = warehouseClient.ListSearchConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListSearchConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchConfigsAsync</summary>
        public async Task ListSearchConfigsResourceNamesAsync()
        {
            // Snippet: ListSearchConfigsAsync(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListSearchConfigsResponse, gcvv::SearchConfig> response = warehouseClient.ListSearchConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListSearchConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSearchHypernym</summary>
        public void CreateSearchHypernymRequestObject()
        {
            // Snippet: CreateSearchHypernym(CreateSearchHypernymRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateSearchHypernymRequest request = new gcvv::CreateSearchHypernymRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                SearchHypernym = new gcvv::SearchHypernym(),
                SearchHypernymId = "",
            };
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.CreateSearchHypernym(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchHypernymAsync</summary>
        public async Task CreateSearchHypernymRequestObjectAsync()
        {
            // Snippet: CreateSearchHypernymAsync(CreateSearchHypernymRequest, CallSettings)
            // Additional: CreateSearchHypernymAsync(CreateSearchHypernymRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateSearchHypernymRequest request = new gcvv::CreateSearchHypernymRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                SearchHypernym = new gcvv::SearchHypernym(),
                SearchHypernymId = "",
            };
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.CreateSearchHypernymAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchHypernym</summary>
        public void CreateSearchHypernym()
        {
            // Snippet: CreateSearchHypernym(string, SearchHypernym, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::SearchHypernym searchHypernym = new gcvv::SearchHypernym();
            string searchHypernymId = "";
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.CreateSearchHypernym(parent, searchHypernym, searchHypernymId);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchHypernymAsync</summary>
        public async Task CreateSearchHypernymAsync()
        {
            // Snippet: CreateSearchHypernymAsync(string, SearchHypernym, string, CallSettings)
            // Additional: CreateSearchHypernymAsync(string, SearchHypernym, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::SearchHypernym searchHypernym = new gcvv::SearchHypernym();
            string searchHypernymId = "";
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.CreateSearchHypernymAsync(parent, searchHypernym, searchHypernymId);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchHypernym</summary>
        public void CreateSearchHypernymResourceNames()
        {
            // Snippet: CreateSearchHypernym(CorpusName, SearchHypernym, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::SearchHypernym searchHypernym = new gcvv::SearchHypernym();
            string searchHypernymId = "";
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.CreateSearchHypernym(parent, searchHypernym, searchHypernymId);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchHypernymAsync</summary>
        public async Task CreateSearchHypernymResourceNamesAsync()
        {
            // Snippet: CreateSearchHypernymAsync(CorpusName, SearchHypernym, string, CallSettings)
            // Additional: CreateSearchHypernymAsync(CorpusName, SearchHypernym, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::SearchHypernym searchHypernym = new gcvv::SearchHypernym();
            string searchHypernymId = "";
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.CreateSearchHypernymAsync(parent, searchHypernym, searchHypernymId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchHypernym</summary>
        public void UpdateSearchHypernymRequestObject()
        {
            // Snippet: UpdateSearchHypernym(UpdateSearchHypernymRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateSearchHypernymRequest request = new gcvv::UpdateSearchHypernymRequest
            {
                SearchHypernym = new gcvv::SearchHypernym(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.UpdateSearchHypernym(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchHypernymAsync</summary>
        public async Task UpdateSearchHypernymRequestObjectAsync()
        {
            // Snippet: UpdateSearchHypernymAsync(UpdateSearchHypernymRequest, CallSettings)
            // Additional: UpdateSearchHypernymAsync(UpdateSearchHypernymRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateSearchHypernymRequest request = new gcvv::UpdateSearchHypernymRequest
            {
                SearchHypernym = new gcvv::SearchHypernym(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.UpdateSearchHypernymAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchHypernym</summary>
        public void UpdateSearchHypernym()
        {
            // Snippet: UpdateSearchHypernym(SearchHypernym, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchHypernym searchHypernym = new gcvv::SearchHypernym();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.UpdateSearchHypernym(searchHypernym, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchHypernymAsync</summary>
        public async Task UpdateSearchHypernymAsync()
        {
            // Snippet: UpdateSearchHypernymAsync(SearchHypernym, FieldMask, CallSettings)
            // Additional: UpdateSearchHypernymAsync(SearchHypernym, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchHypernym searchHypernym = new gcvv::SearchHypernym();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.UpdateSearchHypernymAsync(searchHypernym, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetSearchHypernym</summary>
        public void GetSearchHypernymRequestObject()
        {
            // Snippet: GetSearchHypernym(GetSearchHypernymRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetSearchHypernymRequest request = new gcvv::GetSearchHypernymRequest
            {
                SearchHypernymName = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]"),
            };
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.GetSearchHypernym(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchHypernymAsync</summary>
        public async Task GetSearchHypernymRequestObjectAsync()
        {
            // Snippet: GetSearchHypernymAsync(GetSearchHypernymRequest, CallSettings)
            // Additional: GetSearchHypernymAsync(GetSearchHypernymRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetSearchHypernymRequest request = new gcvv::GetSearchHypernymRequest
            {
                SearchHypernymName = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]"),
            };
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.GetSearchHypernymAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchHypernym</summary>
        public void GetSearchHypernym()
        {
            // Snippet: GetSearchHypernym(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchHypernyms/[SEARCH_HYPERNYM]";
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.GetSearchHypernym(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchHypernymAsync</summary>
        public async Task GetSearchHypernymAsync()
        {
            // Snippet: GetSearchHypernymAsync(string, CallSettings)
            // Additional: GetSearchHypernymAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchHypernyms/[SEARCH_HYPERNYM]";
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.GetSearchHypernymAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchHypernym</summary>
        public void GetSearchHypernymResourceNames()
        {
            // Snippet: GetSearchHypernym(SearchHypernymName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchHypernymName name = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]");
            // Make the request
            gcvv::SearchHypernym response = warehouseClient.GetSearchHypernym(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchHypernymAsync</summary>
        public async Task GetSearchHypernymResourceNamesAsync()
        {
            // Snippet: GetSearchHypernymAsync(SearchHypernymName, CallSettings)
            // Additional: GetSearchHypernymAsync(SearchHypernymName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchHypernymName name = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]");
            // Make the request
            gcvv::SearchHypernym response = await warehouseClient.GetSearchHypernymAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchHypernym</summary>
        public void DeleteSearchHypernymRequestObject()
        {
            // Snippet: DeleteSearchHypernym(DeleteSearchHypernymRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteSearchHypernymRequest request = new gcvv::DeleteSearchHypernymRequest
            {
                SearchHypernymName = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]"),
            };
            // Make the request
            warehouseClient.DeleteSearchHypernym(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchHypernymAsync</summary>
        public async Task DeleteSearchHypernymRequestObjectAsync()
        {
            // Snippet: DeleteSearchHypernymAsync(DeleteSearchHypernymRequest, CallSettings)
            // Additional: DeleteSearchHypernymAsync(DeleteSearchHypernymRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteSearchHypernymRequest request = new gcvv::DeleteSearchHypernymRequest
            {
                SearchHypernymName = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]"),
            };
            // Make the request
            await warehouseClient.DeleteSearchHypernymAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchHypernym</summary>
        public void DeleteSearchHypernym()
        {
            // Snippet: DeleteSearchHypernym(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchHypernyms/[SEARCH_HYPERNYM]";
            // Make the request
            warehouseClient.DeleteSearchHypernym(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchHypernymAsync</summary>
        public async Task DeleteSearchHypernymAsync()
        {
            // Snippet: DeleteSearchHypernymAsync(string, CallSettings)
            // Additional: DeleteSearchHypernymAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/searchHypernyms/[SEARCH_HYPERNYM]";
            // Make the request
            await warehouseClient.DeleteSearchHypernymAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchHypernym</summary>
        public void DeleteSearchHypernymResourceNames()
        {
            // Snippet: DeleteSearchHypernym(SearchHypernymName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchHypernymName name = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]");
            // Make the request
            warehouseClient.DeleteSearchHypernym(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchHypernymAsync</summary>
        public async Task DeleteSearchHypernymResourceNamesAsync()
        {
            // Snippet: DeleteSearchHypernymAsync(SearchHypernymName, CallSettings)
            // Additional: DeleteSearchHypernymAsync(SearchHypernymName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchHypernymName name = gcvv::SearchHypernymName.FromProjectNumberLocationCorpusSearchHypernym("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[SEARCH_HYPERNYM]");
            // Make the request
            await warehouseClient.DeleteSearchHypernymAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSearchHypernyms</summary>
        public void ListSearchHypernymsRequestObject()
        {
            // Snippet: ListSearchHypernyms(ListSearchHypernymsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListSearchHypernymsRequest request = new gcvv::ListSearchHypernymsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedEnumerable<gcvv::ListSearchHypernymsResponse, gcvv::SearchHypernym> response = warehouseClient.ListSearchHypernyms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchHypernym item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListSearchHypernymsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchHypernym item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchHypernym> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchHypernym item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchHypernymsAsync</summary>
        public async Task ListSearchHypernymsRequestObjectAsync()
        {
            // Snippet: ListSearchHypernymsAsync(ListSearchHypernymsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListSearchHypernymsRequest request = new gcvv::ListSearchHypernymsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListSearchHypernymsResponse, gcvv::SearchHypernym> response = warehouseClient.ListSearchHypernymsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchHypernym item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListSearchHypernymsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchHypernym item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchHypernym> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchHypernym item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchHypernyms</summary>
        public void ListSearchHypernyms()
        {
            // Snippet: ListSearchHypernyms(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedEnumerable<gcvv::ListSearchHypernymsResponse, gcvv::SearchHypernym> response = warehouseClient.ListSearchHypernyms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchHypernym item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListSearchHypernymsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchHypernym item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchHypernym> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchHypernym item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchHypernymsAsync</summary>
        public async Task ListSearchHypernymsAsync()
        {
            // Snippet: ListSearchHypernymsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListSearchHypernymsResponse, gcvv::SearchHypernym> response = warehouseClient.ListSearchHypernymsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchHypernym item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListSearchHypernymsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchHypernym item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchHypernym> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchHypernym item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchHypernyms</summary>
        public void ListSearchHypernymsResourceNames()
        {
            // Snippet: ListSearchHypernyms(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedEnumerable<gcvv::ListSearchHypernymsResponse, gcvv::SearchHypernym> response = warehouseClient.ListSearchHypernyms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchHypernym item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListSearchHypernymsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchHypernym item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchHypernym> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchHypernym item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchHypernymsAsync</summary>
        public async Task ListSearchHypernymsResourceNamesAsync()
        {
            // Snippet: ListSearchHypernymsAsync(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListSearchHypernymsResponse, gcvv::SearchHypernym> response = warehouseClient.ListSearchHypernymsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchHypernym item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListSearchHypernymsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchHypernym item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchHypernym> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchHypernym item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssets</summary>
        public void SearchAssetsRequestObject()
        {
            // Snippet: SearchAssets(SearchAssetsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchAssetsRequest request = new gcvv::SearchAssetsRequest
            {
                CorpusAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Criteria =
                {
                    new gcvv::Criteria(),
                },
                ContentTimeRanges = new gcvv::DateTimeRangeArray(),
                FacetSelections =
                {
                    new gcvv::FacetGroup(),
                },
                ResultAnnotationKeys = { "", },
                SchemaKeySortingStrategy = new gcvv::SchemaKeySortingStrategy(),
                SearchQuery = "",
            };
            // Make the request
            PagedEnumerable<gcvv::SearchAssetsResponse, gcvv::SearchResultItem> response = warehouseClient.SearchAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchResultItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::SearchAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchResultItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchResultItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchResultItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssetsAsync</summary>
        public async Task SearchAssetsRequestObjectAsync()
        {
            // Snippet: SearchAssetsAsync(SearchAssetsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchAssetsRequest request = new gcvv::SearchAssetsRequest
            {
                CorpusAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Criteria =
                {
                    new gcvv::Criteria(),
                },
                ContentTimeRanges = new gcvv::DateTimeRangeArray(),
                FacetSelections =
                {
                    new gcvv::FacetGroup(),
                },
                ResultAnnotationKeys = { "", },
                SchemaKeySortingStrategy = new gcvv::SchemaKeySortingStrategy(),
                SearchQuery = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::SearchAssetsResponse, gcvv::SearchResultItem> response = warehouseClient.SearchAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchResultItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::SearchAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchResultItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchResultItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchResultItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchIndexEndpoint</summary>
        public void SearchIndexEndpointRequestObject()
        {
            // Snippet: SearchIndexEndpoint(SearchIndexEndpointRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::SearchIndexEndpointRequest request = new gcvv::SearchIndexEndpointRequest
            {
                IndexEndpointAsIndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                ImageQuery = new gcvv::ImageQuery(),
                Criteria =
                {
                    new gcvv::Criteria(),
                },
                ExclusionCriteria =
                {
                    new gcvv::Criteria(),
                },
            };
            // Make the request
            PagedEnumerable<gcvv::SearchIndexEndpointResponse, gcvv::SearchResultItem> response = warehouseClient.SearchIndexEndpoint(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::SearchResultItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::SearchIndexEndpointResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchResultItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchResultItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchResultItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchIndexEndpointAsync</summary>
        public async Task SearchIndexEndpointRequestObjectAsync()
        {
            // Snippet: SearchIndexEndpointAsync(SearchIndexEndpointRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::SearchIndexEndpointRequest request = new gcvv::SearchIndexEndpointRequest
            {
                IndexEndpointAsIndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                ImageQuery = new gcvv::ImageQuery(),
                Criteria =
                {
                    new gcvv::Criteria(),
                },
                ExclusionCriteria =
                {
                    new gcvv::Criteria(),
                },
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::SearchIndexEndpointResponse, gcvv::SearchResultItem> response = warehouseClient.SearchIndexEndpointAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::SearchResultItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::SearchIndexEndpointResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::SearchResultItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::SearchResultItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::SearchResultItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpoint</summary>
        public void CreateIndexEndpointRequestObject()
        {
            // Snippet: CreateIndexEndpoint(CreateIndexEndpointRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateIndexEndpointRequest request = new gcvv::CreateIndexEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IndexEndpointId = "",
                IndexEndpoint = new gcvv::IndexEndpoint(),
            };
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> response = warehouseClient.CreateIndexEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpointAsync</summary>
        public async Task CreateIndexEndpointRequestObjectAsync()
        {
            // Snippet: CreateIndexEndpointAsync(CreateIndexEndpointRequest, CallSettings)
            // Additional: CreateIndexEndpointAsync(CreateIndexEndpointRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateIndexEndpointRequest request = new gcvv::CreateIndexEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IndexEndpointId = "",
                IndexEndpoint = new gcvv::IndexEndpoint(),
            };
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> response = await warehouseClient.CreateIndexEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceCreateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpoint</summary>
        public void CreateIndexEndpoint()
        {
            // Snippet: CreateIndexEndpoint(string, IndexEndpoint, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcvv::IndexEndpoint indexEndpoint = new gcvv::IndexEndpoint();
            string indexEndpointId = "";
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> response = warehouseClient.CreateIndexEndpoint(parent, indexEndpoint, indexEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpointAsync</summary>
        public async Task CreateIndexEndpointAsync()
        {
            // Snippet: CreateIndexEndpointAsync(string, IndexEndpoint, string, CallSettings)
            // Additional: CreateIndexEndpointAsync(string, IndexEndpoint, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcvv::IndexEndpoint indexEndpoint = new gcvv::IndexEndpoint();
            string indexEndpointId = "";
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> response = await warehouseClient.CreateIndexEndpointAsync(parent, indexEndpoint, indexEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceCreateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpoint</summary>
        public void CreateIndexEndpointResourceNames()
        {
            // Snippet: CreateIndexEndpoint(LocationName, IndexEndpoint, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcvv::IndexEndpoint indexEndpoint = new gcvv::IndexEndpoint();
            string indexEndpointId = "";
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> response = warehouseClient.CreateIndexEndpoint(parent, indexEndpoint, indexEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpointAsync</summary>
        public async Task CreateIndexEndpointResourceNamesAsync()
        {
            // Snippet: CreateIndexEndpointAsync(LocationName, IndexEndpoint, string, CallSettings)
            // Additional: CreateIndexEndpointAsync(LocationName, IndexEndpoint, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcvv::IndexEndpoint indexEndpoint = new gcvv::IndexEndpoint();
            string indexEndpointId = "";
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> response = await warehouseClient.CreateIndexEndpointAsync(parent, indexEndpoint, indexEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::CreateIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceCreateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpoint</summary>
        public void GetIndexEndpointRequestObject()
        {
            // Snippet: GetIndexEndpoint(GetIndexEndpointRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetIndexEndpointRequest request = new gcvv::GetIndexEndpointRequest
            {
                IndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            gcvv::IndexEndpoint response = warehouseClient.GetIndexEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpointAsync</summary>
        public async Task GetIndexEndpointRequestObjectAsync()
        {
            // Snippet: GetIndexEndpointAsync(GetIndexEndpointRequest, CallSettings)
            // Additional: GetIndexEndpointAsync(GetIndexEndpointRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetIndexEndpointRequest request = new gcvv::GetIndexEndpointRequest
            {
                IndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            gcvv::IndexEndpoint response = await warehouseClient.GetIndexEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpoint</summary>
        public void GetIndexEndpoint()
        {
            // Snippet: GetIndexEndpoint(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            gcvv::IndexEndpoint response = warehouseClient.GetIndexEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpointAsync</summary>
        public async Task GetIndexEndpointAsync()
        {
            // Snippet: GetIndexEndpointAsync(string, CallSettings)
            // Additional: GetIndexEndpointAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            gcvv::IndexEndpoint response = await warehouseClient.GetIndexEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpoint</summary>
        public void GetIndexEndpointResourceNames()
        {
            // Snippet: GetIndexEndpoint(IndexEndpointName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexEndpointName name = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            gcvv::IndexEndpoint response = warehouseClient.GetIndexEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpointAsync</summary>
        public async Task GetIndexEndpointResourceNamesAsync()
        {
            // Snippet: GetIndexEndpointAsync(IndexEndpointName, CallSettings)
            // Additional: GetIndexEndpointAsync(IndexEndpointName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexEndpointName name = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            gcvv::IndexEndpoint response = await warehouseClient.GetIndexEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpoints</summary>
        public void ListIndexEndpointsRequestObject()
        {
            // Snippet: ListIndexEndpoints(ListIndexEndpointsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListIndexEndpointsRequest request = new gcvv::ListIndexEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcvv::ListIndexEndpointsResponse, gcvv::IndexEndpoint> response = warehouseClient.ListIndexEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::IndexEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpointsAsync</summary>
        public async Task ListIndexEndpointsRequestObjectAsync()
        {
            // Snippet: ListIndexEndpointsAsync(ListIndexEndpointsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListIndexEndpointsRequest request = new gcvv::ListIndexEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexEndpointsResponse, gcvv::IndexEndpoint> response = warehouseClient.ListIndexEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::IndexEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListIndexEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpoints</summary>
        public void ListIndexEndpoints()
        {
            // Snippet: ListIndexEndpoints(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcvv::ListIndexEndpointsResponse, gcvv::IndexEndpoint> response = warehouseClient.ListIndexEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::IndexEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpointsAsync</summary>
        public async Task ListIndexEndpointsAsync()
        {
            // Snippet: ListIndexEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexEndpointsResponse, gcvv::IndexEndpoint> response = warehouseClient.ListIndexEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::IndexEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListIndexEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpoints</summary>
        public void ListIndexEndpointsResourceNames()
        {
            // Snippet: ListIndexEndpoints(LocationName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcvv::ListIndexEndpointsResponse, gcvv::IndexEndpoint> response = warehouseClient.ListIndexEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::IndexEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListIndexEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpointsAsync</summary>
        public async Task ListIndexEndpointsResourceNamesAsync()
        {
            // Snippet: ListIndexEndpointsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListIndexEndpointsResponse, gcvv::IndexEndpoint> response = warehouseClient.ListIndexEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::IndexEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListIndexEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::IndexEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpoint</summary>
        public void UpdateIndexEndpointRequestObject()
        {
            // Snippet: UpdateIndexEndpoint(UpdateIndexEndpointRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateIndexEndpointRequest request = new gcvv::UpdateIndexEndpointRequest
            {
                IndexEndpoint = new gcvv::IndexEndpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> response = warehouseClient.UpdateIndexEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceUpdateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpointAsync</summary>
        public async Task UpdateIndexEndpointRequestObjectAsync()
        {
            // Snippet: UpdateIndexEndpointAsync(UpdateIndexEndpointRequest, CallSettings)
            // Additional: UpdateIndexEndpointAsync(UpdateIndexEndpointRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateIndexEndpointRequest request = new gcvv::UpdateIndexEndpointRequest
            {
                IndexEndpoint = new gcvv::IndexEndpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> response = await warehouseClient.UpdateIndexEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceUpdateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpoint</summary>
        public void UpdateIndexEndpoint()
        {
            // Snippet: UpdateIndexEndpoint(IndexEndpoint, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexEndpoint indexEndpoint = new gcvv::IndexEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> response = warehouseClient.UpdateIndexEndpoint(indexEndpoint, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceUpdateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpointAsync</summary>
        public async Task UpdateIndexEndpointAsync()
        {
            // Snippet: UpdateIndexEndpointAsync(IndexEndpoint, FieldMask, CallSettings)
            // Additional: UpdateIndexEndpointAsync(IndexEndpoint, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexEndpoint indexEndpoint = new gcvv::IndexEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> response = await warehouseClient.UpdateIndexEndpointAsync(indexEndpoint, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::IndexEndpoint, gcvv::UpdateIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceUpdateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpoint</summary>
        public void DeleteIndexEndpointRequestObject()
        {
            // Snippet: DeleteIndexEndpoint(DeleteIndexEndpointRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteIndexEndpointRequest request = new gcvv::DeleteIndexEndpointRequest
            {
                IndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> response = warehouseClient.DeleteIndexEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceDeleteIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpointAsync</summary>
        public async Task DeleteIndexEndpointRequestObjectAsync()
        {
            // Snippet: DeleteIndexEndpointAsync(DeleteIndexEndpointRequest, CallSettings)
            // Additional: DeleteIndexEndpointAsync(DeleteIndexEndpointRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteIndexEndpointRequest request = new gcvv::DeleteIndexEndpointRequest
            {
                IndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> response = await warehouseClient.DeleteIndexEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpoint</summary>
        public void DeleteIndexEndpoint()
        {
            // Snippet: DeleteIndexEndpoint(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> response = warehouseClient.DeleteIndexEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceDeleteIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpointAsync</summary>
        public async Task DeleteIndexEndpointAsync()
        {
            // Snippet: DeleteIndexEndpointAsync(string, CallSettings)
            // Additional: DeleteIndexEndpointAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> response = await warehouseClient.DeleteIndexEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpoint</summary>
        public void DeleteIndexEndpointResourceNames()
        {
            // Snippet: DeleteIndexEndpoint(IndexEndpointName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::IndexEndpointName name = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> response = warehouseClient.DeleteIndexEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> retrievedResponse = warehouseClient.PollOnceDeleteIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpointAsync</summary>
        public async Task DeleteIndexEndpointResourceNamesAsync()
        {
            // Snippet: DeleteIndexEndpointAsync(IndexEndpointName, CallSettings)
            // Additional: DeleteIndexEndpointAsync(IndexEndpointName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::IndexEndpointName name = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> response = await warehouseClient.DeleteIndexEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteIndexEndpointMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndex</summary>
        public void DeployIndexRequestObject()
        {
            // Snippet: DeployIndex(DeployIndexRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeployIndexRequest request = new gcvv::DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new gcvv::DeployedIndex(),
            };
            // Make the request
            Operation<gcvv::DeployIndexResponse, gcvv::DeployIndexMetadata> response = warehouseClient.DeployIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::DeployIndexResponse, gcvv::DeployIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::DeployIndexResponse, gcvv::DeployIndexMetadata> retrievedResponse = warehouseClient.PollOnceDeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndexAsync</summary>
        public async Task DeployIndexRequestObjectAsync()
        {
            // Snippet: DeployIndexAsync(DeployIndexRequest, CallSettings)
            // Additional: DeployIndexAsync(DeployIndexRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeployIndexRequest request = new gcvv::DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new gcvv::DeployedIndex(),
            };
            // Make the request
            Operation<gcvv::DeployIndexResponse, gcvv::DeployIndexMetadata> response = await warehouseClient.DeployIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::DeployIndexResponse, gcvv::DeployIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::DeployIndexResponse, gcvv::DeployIndexMetadata> retrievedResponse = await warehouseClient.PollOnceDeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndex</summary>
        public void UndeployIndexRequestObject()
        {
            // Snippet: UndeployIndex(UndeployIndexRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UndeployIndexRequest request = new gcvv::UndeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            Operation<gcvv::UndeployIndexResponse, gcvv::UndeployIndexMetadata> response = warehouseClient.UndeployIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::UndeployIndexResponse, gcvv::UndeployIndexMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::UndeployIndexResponse, gcvv::UndeployIndexMetadata> retrievedResponse = warehouseClient.PollOnceUndeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndexAsync</summary>
        public async Task UndeployIndexRequestObjectAsync()
        {
            // Snippet: UndeployIndexAsync(UndeployIndexRequest, CallSettings)
            // Additional: UndeployIndexAsync(UndeployIndexRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UndeployIndexRequest request = new gcvv::UndeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gcvv::IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            Operation<gcvv::UndeployIndexResponse, gcvv::UndeployIndexMetadata> response = await warehouseClient.UndeployIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::UndeployIndexResponse, gcvv::UndeployIndexMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::UndeployIndexResponse, gcvv::UndeployIndexMetadata> retrievedResponse = await warehouseClient.PollOnceUndeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollection</summary>
        public void CreateCollectionRequestObject()
        {
            // Snippet: CreateCollection(CreateCollectionRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CreateCollectionRequest request = new gcvv::CreateCollectionRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Collection = new gcvv::Collection(),
                CollectionId = "",
            };
            // Make the request
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> response = warehouseClient.CreateCollection(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> retrievedResponse = warehouseClient.PollOnceCreateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectionAsync</summary>
        public async Task CreateCollectionRequestObjectAsync()
        {
            // Snippet: CreateCollectionAsync(CreateCollectionRequest, CallSettings)
            // Additional: CreateCollectionAsync(CreateCollectionRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CreateCollectionRequest request = new gcvv::CreateCollectionRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
                Collection = new gcvv::Collection(),
                CollectionId = "",
            };
            // Make the request
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> response = await warehouseClient.CreateCollectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> retrievedResponse = await warehouseClient.PollOnceCreateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollection</summary>
        public void CreateCollection()
        {
            // Snippet: CreateCollection(string, Collection, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> response = warehouseClient.CreateCollection(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> retrievedResponse = warehouseClient.PollOnceCreateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectionAsync</summary>
        public async Task CreateCollectionAsync()
        {
            // Snippet: CreateCollectionAsync(string, Collection, string, CallSettings)
            // Additional: CreateCollectionAsync(string, Collection, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> response = await warehouseClient.CreateCollectionAsync(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> retrievedResponse = await warehouseClient.PollOnceCreateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollection</summary>
        public void CreateCollectionResourceNames()
        {
            // Snippet: CreateCollection(CorpusName, Collection, string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> response = warehouseClient.CreateCollection(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> retrievedResponse = warehouseClient.PollOnceCreateCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCollectionAsync</summary>
        public async Task CreateCollectionResourceNamesAsync()
        {
            // Snippet: CreateCollectionAsync(CorpusName, Collection, string, CallSettings)
            // Additional: CreateCollectionAsync(CorpusName, Collection, string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            gcvv::Collection collection = new gcvv::Collection();
            string collectionId = "";
            // Make the request
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> response = await warehouseClient.CreateCollectionAsync(parent, collection, collectionId);

            // Poll until the returned long-running operation is complete
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcvv::Collection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcvv::Collection, gcvv::CreateCollectionMetadata> retrievedResponse = await warehouseClient.PollOnceCreateCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcvv::Collection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollectionRequestObject()
        {
            // Snippet: DeleteCollection(DeleteCollectionRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::DeleteCollectionRequest request = new gcvv::DeleteCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteCollectionMetadata> response = warehouseClient.DeleteCollection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteCollectionMetadata> retrievedResponse = warehouseClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionRequestObjectAsync()
        {
            // Snippet: DeleteCollectionAsync(DeleteCollectionRequest, CallSettings)
            // Additional: DeleteCollectionAsync(DeleteCollectionRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::DeleteCollectionRequest request = new gcvv::DeleteCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]"),
            };
            // Make the request
            Operation<Empty, gcvv::DeleteCollectionMetadata> response = await warehouseClient.DeleteCollectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteCollectionMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollection()
        {
            // Snippet: DeleteCollection(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/collections/[COLLECTION]";
            // Make the request
            Operation<Empty, gcvv::DeleteCollectionMetadata> response = warehouseClient.DeleteCollection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteCollectionMetadata> retrievedResponse = warehouseClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionAsync()
        {
            // Snippet: DeleteCollectionAsync(string, CallSettings)
            // Additional: DeleteCollectionAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/collections/[COLLECTION]";
            // Make the request
            Operation<Empty, gcvv::DeleteCollectionMetadata> response = await warehouseClient.DeleteCollectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteCollectionMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollection</summary>
        public void DeleteCollectionResourceNames()
        {
            // Snippet: DeleteCollection(CollectionName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]");
            // Make the request
            Operation<Empty, gcvv::DeleteCollectionMetadata> response = warehouseClient.DeleteCollection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteCollectionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteCollectionMetadata> retrievedResponse = warehouseClient.PollOnceDeleteCollection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCollectionAsync</summary>
        public async Task DeleteCollectionResourceNamesAsync()
        {
            // Snippet: DeleteCollectionAsync(CollectionName, CallSettings)
            // Additional: DeleteCollectionAsync(CollectionName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]");
            // Make the request
            Operation<Empty, gcvv::DeleteCollectionMetadata> response = await warehouseClient.DeleteCollectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcvv::DeleteCollectionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcvv::DeleteCollectionMetadata> retrievedResponse = await warehouseClient.PollOnceDeleteCollectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCollection</summary>
        public void GetCollectionRequestObject()
        {
            // Snippet: GetCollection(GetCollectionRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::GetCollectionRequest request = new gcvv::GetCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]"),
            };
            // Make the request
            gcvv::Collection response = warehouseClient.GetCollection(request);
            // End snippet
        }

        /// <summary>Snippet for GetCollectionAsync</summary>
        public async Task GetCollectionRequestObjectAsync()
        {
            // Snippet: GetCollectionAsync(GetCollectionRequest, CallSettings)
            // Additional: GetCollectionAsync(GetCollectionRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::GetCollectionRequest request = new gcvv::GetCollectionRequest
            {
                CollectionName = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]"),
            };
            // Make the request
            gcvv::Collection response = await warehouseClient.GetCollectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCollection</summary>
        public void GetCollection()
        {
            // Snippet: GetCollection(string, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/collections/[COLLECTION]";
            // Make the request
            gcvv::Collection response = warehouseClient.GetCollection(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollectionAsync</summary>
        public async Task GetCollectionAsync()
        {
            // Snippet: GetCollectionAsync(string, CallSettings)
            // Additional: GetCollectionAsync(string, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/collections/[COLLECTION]";
            // Make the request
            gcvv::Collection response = await warehouseClient.GetCollectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollection</summary>
        public void GetCollectionResourceNames()
        {
            // Snippet: GetCollection(CollectionName, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]");
            // Make the request
            gcvv::Collection response = warehouseClient.GetCollection(name);
            // End snippet
        }

        /// <summary>Snippet for GetCollectionAsync</summary>
        public async Task GetCollectionResourceNamesAsync()
        {
            // Snippet: GetCollectionAsync(CollectionName, CallSettings)
            // Additional: GetCollectionAsync(CollectionName, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName name = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]");
            // Make the request
            gcvv::Collection response = await warehouseClient.GetCollectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCollection</summary>
        public void UpdateCollectionRequestObject()
        {
            // Snippet: UpdateCollection(UpdateCollectionRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::UpdateCollectionRequest request = new gcvv::UpdateCollectionRequest
            {
                Collection = new gcvv::Collection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Collection response = warehouseClient.UpdateCollection(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCollectionAsync</summary>
        public async Task UpdateCollectionRequestObjectAsync()
        {
            // Snippet: UpdateCollectionAsync(UpdateCollectionRequest, CallSettings)
            // Additional: UpdateCollectionAsync(UpdateCollectionRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::UpdateCollectionRequest request = new gcvv::UpdateCollectionRequest
            {
                Collection = new gcvv::Collection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcvv::Collection response = await warehouseClient.UpdateCollectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCollection</summary>
        public void UpdateCollection()
        {
            // Snippet: UpdateCollection(Collection, FieldMask, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::Collection collection = new gcvv::Collection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Collection response = warehouseClient.UpdateCollection(collection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCollectionAsync</summary>
        public async Task UpdateCollectionAsync()
        {
            // Snippet: UpdateCollectionAsync(Collection, FieldMask, CallSettings)
            // Additional: UpdateCollectionAsync(Collection, FieldMask, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::Collection collection = new gcvv::Collection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcvv::Collection response = await warehouseClient.UpdateCollectionAsync(collection, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListCollections</summary>
        public void ListCollectionsRequestObject()
        {
            // Snippet: ListCollections(ListCollectionsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ListCollectionsRequest request = new gcvv::ListCollectionsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = warehouseClient.ListCollections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionsAsync</summary>
        public async Task ListCollectionsRequestObjectAsync()
        {
            // Snippet: ListCollectionsAsync(ListCollectionsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ListCollectionsRequest request = new gcvv::ListCollectionsRequest
            {
                ParentAsCorpusName = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = warehouseClient.ListCollectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Collection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListCollectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollections</summary>
        public void ListCollections()
        {
            // Snippet: ListCollections(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = warehouseClient.ListCollections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionsAsync</summary>
        public async Task ListCollectionsAsync()
        {
            // Snippet: ListCollectionsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = warehouseClient.ListCollectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Collection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListCollectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollections</summary>
        public void ListCollectionsResourceNames()
        {
            // Snippet: ListCollections(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = warehouseClient.ListCollections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::Collection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ListCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionsAsync</summary>
        public async Task ListCollectionsResourceNamesAsync()
        {
            // Snippet: ListCollectionsAsync(CorpusName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CorpusName parent = gcvv::CorpusName.FromProjectNumberLocationCorpus("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ListCollectionsResponse, gcvv::Collection> response = warehouseClient.ListCollectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::Collection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ListCollectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::Collection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::Collection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::Collection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AddCollectionItem</summary>
        public void AddCollectionItemRequestObject()
        {
            // Snippet: AddCollectionItem(AddCollectionItemRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::AddCollectionItemRequest request = new gcvv::AddCollectionItemRequest
            {
                Item = new gcvv::CollectionItem(),
            };
            // Make the request
            gcvv::AddCollectionItemResponse response = warehouseClient.AddCollectionItem(request);
            // End snippet
        }

        /// <summary>Snippet for AddCollectionItemAsync</summary>
        public async Task AddCollectionItemRequestObjectAsync()
        {
            // Snippet: AddCollectionItemAsync(AddCollectionItemRequest, CallSettings)
            // Additional: AddCollectionItemAsync(AddCollectionItemRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::AddCollectionItemRequest request = new gcvv::AddCollectionItemRequest
            {
                Item = new gcvv::CollectionItem(),
            };
            // Make the request
            gcvv::AddCollectionItemResponse response = await warehouseClient.AddCollectionItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddCollectionItem</summary>
        public void AddCollectionItem()
        {
            // Snippet: AddCollectionItem(CollectionItem, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionItem item = new gcvv::CollectionItem();
            // Make the request
            gcvv::AddCollectionItemResponse response = warehouseClient.AddCollectionItem(item);
            // End snippet
        }

        /// <summary>Snippet for AddCollectionItemAsync</summary>
        public async Task AddCollectionItemAsync()
        {
            // Snippet: AddCollectionItemAsync(CollectionItem, CallSettings)
            // Additional: AddCollectionItemAsync(CollectionItem, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionItem item = new gcvv::CollectionItem();
            // Make the request
            gcvv::AddCollectionItemResponse response = await warehouseClient.AddCollectionItemAsync(item);
            // End snippet
        }

        /// <summary>Snippet for RemoveCollectionItem</summary>
        public void RemoveCollectionItemRequestObject()
        {
            // Snippet: RemoveCollectionItem(RemoveCollectionItemRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::RemoveCollectionItemRequest request = new gcvv::RemoveCollectionItemRequest
            {
                Item = new gcvv::CollectionItem(),
            };
            // Make the request
            gcvv::RemoveCollectionItemResponse response = warehouseClient.RemoveCollectionItem(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveCollectionItemAsync</summary>
        public async Task RemoveCollectionItemRequestObjectAsync()
        {
            // Snippet: RemoveCollectionItemAsync(RemoveCollectionItemRequest, CallSettings)
            // Additional: RemoveCollectionItemAsync(RemoveCollectionItemRequest, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::RemoveCollectionItemRequest request = new gcvv::RemoveCollectionItemRequest
            {
                Item = new gcvv::CollectionItem(),
            };
            // Make the request
            gcvv::RemoveCollectionItemResponse response = await warehouseClient.RemoveCollectionItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveCollectionItem</summary>
        public void RemoveCollectionItem()
        {
            // Snippet: RemoveCollectionItem(CollectionItem, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionItem item = new gcvv::CollectionItem();
            // Make the request
            gcvv::RemoveCollectionItemResponse response = warehouseClient.RemoveCollectionItem(item);
            // End snippet
        }

        /// <summary>Snippet for RemoveCollectionItemAsync</summary>
        public async Task RemoveCollectionItemAsync()
        {
            // Snippet: RemoveCollectionItemAsync(CollectionItem, CallSettings)
            // Additional: RemoveCollectionItemAsync(CollectionItem, CancellationToken)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionItem item = new gcvv::CollectionItem();
            // Make the request
            gcvv::RemoveCollectionItemResponse response = await warehouseClient.RemoveCollectionItemAsync(item);
            // End snippet
        }

        /// <summary>Snippet for ViewCollectionItems</summary>
        public void ViewCollectionItemsRequestObject()
        {
            // Snippet: ViewCollectionItems(ViewCollectionItemsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::ViewCollectionItemsRequest request = new gcvv::ViewCollectionItemsRequest
            {
                CollectionAsCollectionName = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]"),
            };
            // Make the request
            PagedEnumerable<gcvv::ViewCollectionItemsResponse, gcvv::CollectionItem> response = warehouseClient.ViewCollectionItems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::CollectionItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ViewCollectionItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::CollectionItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::CollectionItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::CollectionItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewCollectionItemsAsync</summary>
        public async Task ViewCollectionItemsRequestObjectAsync()
        {
            // Snippet: ViewCollectionItemsAsync(ViewCollectionItemsRequest, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::ViewCollectionItemsRequest request = new gcvv::ViewCollectionItemsRequest
            {
                CollectionAsCollectionName = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcvv::ViewCollectionItemsResponse, gcvv::CollectionItem> response = warehouseClient.ViewCollectionItemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::CollectionItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ViewCollectionItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::CollectionItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::CollectionItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::CollectionItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewCollectionItems</summary>
        public void ViewCollectionItems()
        {
            // Snippet: ViewCollectionItems(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            string collection = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/collections/[COLLECTION]";
            // Make the request
            PagedEnumerable<gcvv::ViewCollectionItemsResponse, gcvv::CollectionItem> response = warehouseClient.ViewCollectionItems(collection);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::CollectionItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ViewCollectionItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::CollectionItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::CollectionItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::CollectionItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewCollectionItemsAsync</summary>
        public async Task ViewCollectionItemsAsync()
        {
            // Snippet: ViewCollectionItemsAsync(string, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            string collection = "projects/[PROJECT_NUMBER]/locations/[LOCATION]/corpora/[CORPUS]/collections/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<gcvv::ViewCollectionItemsResponse, gcvv::CollectionItem> response = warehouseClient.ViewCollectionItemsAsync(collection);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::CollectionItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ViewCollectionItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::CollectionItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::CollectionItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::CollectionItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewCollectionItems</summary>
        public void ViewCollectionItemsResourceNames()
        {
            // Snippet: ViewCollectionItems(CollectionName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = gcvv::WarehouseClient.Create();
            // Initialize request argument(s)
            gcvv::CollectionName collection = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<gcvv::ViewCollectionItemsResponse, gcvv::CollectionItem> response = warehouseClient.ViewCollectionItems(collection);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcvv::CollectionItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcvv::ViewCollectionItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::CollectionItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::CollectionItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::CollectionItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ViewCollectionItemsAsync</summary>
        public async Task ViewCollectionItemsResourceNamesAsync()
        {
            // Snippet: ViewCollectionItemsAsync(CollectionName, string, int?, CallSettings)
            // Create client
            gcvv::WarehouseClient warehouseClient = await gcvv::WarehouseClient.CreateAsync();
            // Initialize request argument(s)
            gcvv::CollectionName collection = gcvv::CollectionName.FromProjectNumberLocationCorpusCollection("[PROJECT_NUMBER]", "[LOCATION]", "[CORPUS]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<gcvv::ViewCollectionItemsResponse, gcvv::CollectionItem> response = warehouseClient.ViewCollectionItemsAsync(collection);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcvv::CollectionItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcvv::ViewCollectionItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcvv::CollectionItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcvv::CollectionItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcvv::CollectionItem item in singlePage)
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
