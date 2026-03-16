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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataProductServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataProduct</summary>
        public void CreateDataProductRequestObject()
        {
            // Snippet: CreateDataProduct(CreateDataProductRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateDataProductRequest request = new gcdv::CreateDataProductRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataProductId = "",
                DataProduct = new gcdv::DataProduct(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = dataProductServiceClient.CreateDataProduct(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceCreateDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataProductAsync</summary>
        public async Task CreateDataProductRequestObjectAsync()
        {
            // Snippet: CreateDataProductAsync(CreateDataProductRequest, CallSettings)
            // Additional: CreateDataProductAsync(CreateDataProductRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateDataProductRequest request = new gcdv::CreateDataProductRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataProductId = "",
                DataProduct = new gcdv::DataProduct(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = await dataProductServiceClient.CreateDataProductAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceCreateDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataProduct</summary>
        public void CreateDataProduct()
        {
            // Snippet: CreateDataProduct(string, DataProduct, string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataProduct dataProduct = new gcdv::DataProduct();
            string dataProductId = "";
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = dataProductServiceClient.CreateDataProduct(parent, dataProduct, dataProductId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceCreateDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataProductAsync</summary>
        public async Task CreateDataProductAsync()
        {
            // Snippet: CreateDataProductAsync(string, DataProduct, string, CallSettings)
            // Additional: CreateDataProductAsync(string, DataProduct, string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataProduct dataProduct = new gcdv::DataProduct();
            string dataProductId = "";
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = await dataProductServiceClient.CreateDataProductAsync(parent, dataProduct, dataProductId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceCreateDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataProduct</summary>
        public void CreateDataProductResourceNames()
        {
            // Snippet: CreateDataProduct(LocationName, DataProduct, string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataProduct dataProduct = new gcdv::DataProduct();
            string dataProductId = "";
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = dataProductServiceClient.CreateDataProduct(parent, dataProduct, dataProductId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceCreateDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataProductAsync</summary>
        public async Task CreateDataProductResourceNamesAsync()
        {
            // Snippet: CreateDataProductAsync(LocationName, DataProduct, string, CallSettings)
            // Additional: CreateDataProductAsync(LocationName, DataProduct, string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataProduct dataProduct = new gcdv::DataProduct();
            string dataProductId = "";
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = await dataProductServiceClient.CreateDataProductAsync(parent, dataProduct, dataProductId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceCreateDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataProduct</summary>
        public void DeleteDataProductRequestObject()
        {
            // Snippet: DeleteDataProduct(DeleteDataProductRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteDataProductRequest request = new gcdv::DeleteDataProductRequest
            {
                DataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataProductServiceClient.DeleteDataProduct(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceDeleteDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataProductAsync</summary>
        public async Task DeleteDataProductRequestObjectAsync()
        {
            // Snippet: DeleteDataProductAsync(DeleteDataProductRequest, CallSettings)
            // Additional: DeleteDataProductAsync(DeleteDataProductRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteDataProductRequest request = new gcdv::DeleteDataProductRequest
            {
                DataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataProductServiceClient.DeleteDataProductAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceDeleteDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataProduct</summary>
        public void DeleteDataProduct()
        {
            // Snippet: DeleteDataProduct(string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataProductServiceClient.DeleteDataProduct(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceDeleteDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataProductAsync</summary>
        public async Task DeleteDataProductAsync()
        {
            // Snippet: DeleteDataProductAsync(string, CallSettings)
            // Additional: DeleteDataProductAsync(string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataProductServiceClient.DeleteDataProductAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceDeleteDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataProduct</summary>
        public void DeleteDataProductResourceNames()
        {
            // Snippet: DeleteDataProduct(DataProductName, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataProductName name = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataProductServiceClient.DeleteDataProduct(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceDeleteDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataProductAsync</summary>
        public async Task DeleteDataProductResourceNamesAsync()
        {
            // Snippet: DeleteDataProductAsync(DataProductName, CallSettings)
            // Additional: DeleteDataProductAsync(DataProductName, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataProductName name = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataProductServiceClient.DeleteDataProductAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceDeleteDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataProduct</summary>
        public void GetDataProductRequestObject()
        {
            // Snippet: GetDataProduct(GetDataProductRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataProductRequest request = new gcdv::GetDataProductRequest
            {
                DataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
            };
            // Make the request
            gcdv::DataProduct response = dataProductServiceClient.GetDataProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataProductAsync</summary>
        public async Task GetDataProductRequestObjectAsync()
        {
            // Snippet: GetDataProductAsync(GetDataProductRequest, CallSettings)
            // Additional: GetDataProductAsync(GetDataProductRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataProductRequest request = new gcdv::GetDataProductRequest
            {
                DataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
            };
            // Make the request
            gcdv::DataProduct response = await dataProductServiceClient.GetDataProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataProduct</summary>
        public void GetDataProduct()
        {
            // Snippet: GetDataProduct(string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            // Make the request
            gcdv::DataProduct response = dataProductServiceClient.GetDataProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataProductAsync</summary>
        public async Task GetDataProductAsync()
        {
            // Snippet: GetDataProductAsync(string, CallSettings)
            // Additional: GetDataProductAsync(string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            // Make the request
            gcdv::DataProduct response = await dataProductServiceClient.GetDataProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataProduct</summary>
        public void GetDataProductResourceNames()
        {
            // Snippet: GetDataProduct(DataProductName, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataProductName name = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            // Make the request
            gcdv::DataProduct response = dataProductServiceClient.GetDataProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataProductAsync</summary>
        public async Task GetDataProductResourceNamesAsync()
        {
            // Snippet: GetDataProductAsync(DataProductName, CallSettings)
            // Additional: GetDataProductAsync(DataProductName, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataProductName name = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            // Make the request
            gcdv::DataProduct response = await dataProductServiceClient.GetDataProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataProducts</summary>
        public void ListDataProductsRequestObject()
        {
            // Snippet: ListDataProducts(ListDataProductsRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataProductsRequest request = new gcdv::ListDataProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataProductsResponse, gcdv::DataProduct> response = dataProductServiceClient.ListDataProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataProductsAsync</summary>
        public async Task ListDataProductsRequestObjectAsync()
        {
            // Snippet: ListDataProductsAsync(ListDataProductsRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataProductsRequest request = new gcdv::ListDataProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataProductsResponse, gcdv::DataProduct> response = dataProductServiceClient.ListDataProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DataProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListDataProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataProducts</summary>
        public void ListDataProducts()
        {
            // Snippet: ListDataProducts(string, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListDataProductsResponse, gcdv::DataProduct> response = dataProductServiceClient.ListDataProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataProductsAsync</summary>
        public async Task ListDataProductsAsync()
        {
            // Snippet: ListDataProductsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataProductsResponse, gcdv::DataProduct> response = dataProductServiceClient.ListDataProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DataProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListDataProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataProducts</summary>
        public void ListDataProductsResourceNames()
        {
            // Snippet: ListDataProducts(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListDataProductsResponse, gcdv::DataProduct> response = dataProductServiceClient.ListDataProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataProductsAsync</summary>
        public async Task ListDataProductsResourceNamesAsync()
        {
            // Snippet: ListDataProductsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataProductsResponse, gcdv::DataProduct> response = dataProductServiceClient.ListDataProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DataProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListDataProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateDataProduct</summary>
        public void UpdateDataProductRequestObject()
        {
            // Snippet: UpdateDataProduct(UpdateDataProductRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateDataProductRequest request = new gcdv::UpdateDataProductRequest
            {
                DataProduct = new gcdv::DataProduct(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = dataProductServiceClient.UpdateDataProduct(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceUpdateDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataProductAsync</summary>
        public async Task UpdateDataProductRequestObjectAsync()
        {
            // Snippet: UpdateDataProductAsync(UpdateDataProductRequest, CallSettings)
            // Additional: UpdateDataProductAsync(UpdateDataProductRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataProductRequest request = new gcdv::UpdateDataProductRequest
            {
                DataProduct = new gcdv::DataProduct(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = await dataProductServiceClient.UpdateDataProductAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceUpdateDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataProduct</summary>
        public void UpdateDataProduct()
        {
            // Snippet: UpdateDataProduct(DataProduct, FieldMask, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataProduct dataProduct = new gcdv::DataProduct();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = dataProductServiceClient.UpdateDataProduct(dataProduct, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceUpdateDataProduct(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataProductAsync</summary>
        public async Task UpdateDataProductAsync()
        {
            // Snippet: UpdateDataProductAsync(DataProduct, FieldMask, CallSettings)
            // Additional: UpdateDataProductAsync(DataProduct, FieldMask, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataProduct dataProduct = new gcdv::DataProduct();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> response = await dataProductServiceClient.UpdateDataProductAsync(dataProduct, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataProduct result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataProduct, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceUpdateDataProductAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataProduct retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAsset</summary>
        public void CreateDataAssetRequestObject()
        {
            // Snippet: CreateDataAsset(CreateDataAssetRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateDataAssetRequest request = new gcdv::CreateDataAssetRequest
            {
                ParentAsDataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
                DataAssetId = "",
                DataAsset = new gcdv::DataAsset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = dataProductServiceClient.CreateDataAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceCreateDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAssetAsync</summary>
        public async Task CreateDataAssetRequestObjectAsync()
        {
            // Snippet: CreateDataAssetAsync(CreateDataAssetRequest, CallSettings)
            // Additional: CreateDataAssetAsync(CreateDataAssetRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateDataAssetRequest request = new gcdv::CreateDataAssetRequest
            {
                ParentAsDataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
                DataAssetId = "",
                DataAsset = new gcdv::DataAsset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = await dataProductServiceClient.CreateDataAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceCreateDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAsset</summary>
        public void CreateDataAsset()
        {
            // Snippet: CreateDataAsset(string, DataAsset, string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            gcdv::DataAsset dataAsset = new gcdv::DataAsset();
            string dataAssetId = "";
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = dataProductServiceClient.CreateDataAsset(parent, dataAsset, dataAssetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceCreateDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAssetAsync</summary>
        public async Task CreateDataAssetAsync()
        {
            // Snippet: CreateDataAssetAsync(string, DataAsset, string, CallSettings)
            // Additional: CreateDataAssetAsync(string, DataAsset, string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            gcdv::DataAsset dataAsset = new gcdv::DataAsset();
            string dataAssetId = "";
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = await dataProductServiceClient.CreateDataAssetAsync(parent, dataAsset, dataAssetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceCreateDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAsset</summary>
        public void CreateDataAssetResourceNames()
        {
            // Snippet: CreateDataAsset(DataProductName, DataAsset, string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataProductName parent = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            gcdv::DataAsset dataAsset = new gcdv::DataAsset();
            string dataAssetId = "";
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = dataProductServiceClient.CreateDataAsset(parent, dataAsset, dataAssetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceCreateDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAssetAsync</summary>
        public async Task CreateDataAssetResourceNamesAsync()
        {
            // Snippet: CreateDataAssetAsync(DataProductName, DataAsset, string, CallSettings)
            // Additional: CreateDataAssetAsync(DataProductName, DataAsset, string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataProductName parent = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            gcdv::DataAsset dataAsset = new gcdv::DataAsset();
            string dataAssetId = "";
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = await dataProductServiceClient.CreateDataAssetAsync(parent, dataAsset, dataAssetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceCreateDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAsset</summary>
        public void UpdateDataAssetRequestObject()
        {
            // Snippet: UpdateDataAsset(UpdateDataAssetRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateDataAssetRequest request = new gcdv::UpdateDataAssetRequest
            {
                DataAsset = new gcdv::DataAsset(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = dataProductServiceClient.UpdateDataAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceUpdateDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAssetAsync</summary>
        public async Task UpdateDataAssetRequestObjectAsync()
        {
            // Snippet: UpdateDataAssetAsync(UpdateDataAssetRequest, CallSettings)
            // Additional: UpdateDataAssetAsync(UpdateDataAssetRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataAssetRequest request = new gcdv::UpdateDataAssetRequest
            {
                DataAsset = new gcdv::DataAsset(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = await dataProductServiceClient.UpdateDataAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceUpdateDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAsset</summary>
        public void UpdateDataAsset()
        {
            // Snippet: UpdateDataAsset(DataAsset, FieldMask, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAsset dataAsset = new gcdv::DataAsset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = dataProductServiceClient.UpdateDataAsset(dataAsset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceUpdateDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAssetAsync</summary>
        public async Task UpdateDataAssetAsync()
        {
            // Snippet: UpdateDataAssetAsync(DataAsset, FieldMask, CallSettings)
            // Additional: UpdateDataAssetAsync(DataAsset, FieldMask, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAsset dataAsset = new gcdv::DataAsset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> response = await dataProductServiceClient.UpdateDataAssetAsync(dataAsset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAsset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAsset, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceUpdateDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAsset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAsset</summary>
        public void DeleteDataAssetRequestObject()
        {
            // Snippet: DeleteDataAsset(DeleteDataAssetRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteDataAssetRequest request = new gcdv::DeleteDataAssetRequest
            {
                DataAssetName = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataProductServiceClient.DeleteDataAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceDeleteDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAssetAsync</summary>
        public async Task DeleteDataAssetRequestObjectAsync()
        {
            // Snippet: DeleteDataAssetAsync(DeleteDataAssetRequest, CallSettings)
            // Additional: DeleteDataAssetAsync(DeleteDataAssetRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteDataAssetRequest request = new gcdv::DeleteDataAssetRequest
            {
                DataAssetName = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataProductServiceClient.DeleteDataAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceDeleteDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAsset</summary>
        public void DeleteDataAsset()
        {
            // Snippet: DeleteDataAsset(string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]/dataAssets/[DATA_ASSET]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataProductServiceClient.DeleteDataAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceDeleteDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAssetAsync</summary>
        public async Task DeleteDataAssetAsync()
        {
            // Snippet: DeleteDataAssetAsync(string, CallSettings)
            // Additional: DeleteDataAssetAsync(string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]/dataAssets/[DATA_ASSET]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataProductServiceClient.DeleteDataAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceDeleteDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAsset</summary>
        public void DeleteDataAssetResourceNames()
        {
            // Snippet: DeleteDataAsset(DataAssetName, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAssetName name = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataProductServiceClient.DeleteDataAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataProductServiceClient.PollOnceDeleteDataAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAssetAsync</summary>
        public async Task DeleteDataAssetResourceNamesAsync()
        {
            // Snippet: DeleteDataAssetAsync(DataAssetName, CallSettings)
            // Additional: DeleteDataAssetAsync(DataAssetName, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAssetName name = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataProductServiceClient.DeleteDataAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataProductServiceClient.PollOnceDeleteDataAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataAsset</summary>
        public void GetDataAssetRequestObject()
        {
            // Snippet: GetDataAsset(GetDataAssetRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataAssetRequest request = new gcdv::GetDataAssetRequest
            {
                DataAssetName = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]"),
            };
            // Make the request
            gcdv::DataAsset response = dataProductServiceClient.GetDataAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAssetAsync</summary>
        public async Task GetDataAssetRequestObjectAsync()
        {
            // Snippet: GetDataAssetAsync(GetDataAssetRequest, CallSettings)
            // Additional: GetDataAssetAsync(GetDataAssetRequest, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataAssetRequest request = new gcdv::GetDataAssetRequest
            {
                DataAssetName = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]"),
            };
            // Make the request
            gcdv::DataAsset response = await dataProductServiceClient.GetDataAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAsset</summary>
        public void GetDataAsset()
        {
            // Snippet: GetDataAsset(string, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]/dataAssets/[DATA_ASSET]";
            // Make the request
            gcdv::DataAsset response = dataProductServiceClient.GetDataAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAssetAsync</summary>
        public async Task GetDataAssetAsync()
        {
            // Snippet: GetDataAssetAsync(string, CallSettings)
            // Additional: GetDataAssetAsync(string, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]/dataAssets/[DATA_ASSET]";
            // Make the request
            gcdv::DataAsset response = await dataProductServiceClient.GetDataAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAsset</summary>
        public void GetDataAssetResourceNames()
        {
            // Snippet: GetDataAsset(DataAssetName, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAssetName name = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]");
            // Make the request
            gcdv::DataAsset response = dataProductServiceClient.GetDataAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAssetAsync</summary>
        public async Task GetDataAssetResourceNamesAsync()
        {
            // Snippet: GetDataAssetAsync(DataAssetName, CallSettings)
            // Additional: GetDataAssetAsync(DataAssetName, CancellationToken)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAssetName name = gcdv::DataAssetName.FromProjectLocationDataProductDataAsset("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]", "[DATA_ASSET]");
            // Make the request
            gcdv::DataAsset response = await dataProductServiceClient.GetDataAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataAssets</summary>
        public void ListDataAssetsRequestObject()
        {
            // Snippet: ListDataAssets(ListDataAssetsRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataAssetsRequest request = new gcdv::ListDataAssetsRequest
            {
                ParentAsDataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataAssetsResponse, gcdv::DataAsset> response = dataProductServiceClient.ListDataAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAssetsAsync</summary>
        public async Task ListDataAssetsRequestObjectAsync()
        {
            // Snippet: ListDataAssetsAsync(ListDataAssetsRequest, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataAssetsRequest request = new gcdv::ListDataAssetsRequest
            {
                ParentAsDataProductName = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAssetsResponse, gcdv::DataAsset> response = dataProductServiceClient.ListDataAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DataAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListDataAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAssets</summary>
        public void ListDataAssets()
        {
            // Snippet: ListDataAssets(string, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            // Make the request
            PagedEnumerable<gcdv::ListDataAssetsResponse, gcdv::DataAsset> response = dataProductServiceClient.ListDataAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAssetsAsync</summary>
        public async Task ListDataAssetsAsync()
        {
            // Snippet: ListDataAssetsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataProducts/[DATA_PRODUCT]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAssetsResponse, gcdv::DataAsset> response = dataProductServiceClient.ListDataAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DataAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListDataAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAssets</summary>
        public void ListDataAssetsResourceNames()
        {
            // Snippet: ListDataAssets(DataProductName, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = gcdv::DataProductServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataProductName parent = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            // Make the request
            PagedEnumerable<gcdv::ListDataAssetsResponse, gcdv::DataAsset> response = dataProductServiceClient.ListDataAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAssetsAsync</summary>
        public async Task ListDataAssetsResourceNamesAsync()
        {
            // Snippet: ListDataAssetsAsync(DataProductName, string, int?, CallSettings)
            // Create client
            gcdv::DataProductServiceClient dataProductServiceClient = await gcdv::DataProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataProductName parent = gcdv::DataProductName.FromProjectLocationDataProduct("[PROJECT]", "[LOCATION]", "[DATA_PRODUCT]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAssetsResponse, gcdv::DataAsset> response = dataProductServiceClient.ListDataAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (gcdv::DataAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (gcdv::ListDataAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAsset item in singlePage)
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
