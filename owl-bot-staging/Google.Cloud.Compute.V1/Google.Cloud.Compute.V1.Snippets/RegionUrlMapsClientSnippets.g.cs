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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionUrlMapsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionUrlMapRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            DeleteRegionUrlMapRequest request = new DeleteRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionUrlMapRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionUrlMapRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionUrlMapRequest request = new DeleteRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Delete(project, region, urlMap);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.DeleteAsync(project, region, urlMap);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionUrlMapRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            GetRegionUrlMapRequest request = new GetRegionUrlMapRequest
            {
                Region = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            UrlMap response = regionUrlMapsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionUrlMapRequest, CallSettings)
            // Additional: GetAsync(GetRegionUrlMapRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionUrlMapRequest request = new GetRegionUrlMapRequest
            {
                Region = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            UrlMap response = await regionUrlMapsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            // Make the request
            UrlMap response = regionUrlMapsClient.Get(project, region, urlMap);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            // Make the request
            UrlMap response = await regionUrlMapsClient.GetAsync(project, region, urlMap);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionUrlMapRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            InsertRegionUrlMapRequest request = new InsertRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionUrlMapRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionUrlMapRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionUrlMapRequest request = new InsertRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, UrlMap, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Insert(project, region, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, UrlMap, CallSettings)
            // Additional: InsertAsync(string, string, UrlMap, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.InsertAsync(project, region, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionUrlMapsRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            ListRegionUrlMapsRequest request = new ListRegionUrlMapsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<UrlMapList, UrlMap> response = regionUrlMapsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UrlMapList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionUrlMapsRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionUrlMapsRequest request = new ListRegionUrlMapsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<UrlMapList, UrlMap> response = regionUrlMapsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UrlMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UrlMapList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<UrlMapList, UrlMap> response = regionUrlMapsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UrlMapList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<UrlMapList, UrlMap> response = regionUrlMapsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UrlMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UrlMapList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRegionUrlMapRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            PatchRegionUrlMapRequest request = new PatchRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchRegionUrlMapRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionUrlMapRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionUrlMapRequest request = new PatchRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, UrlMap, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Patch(project, region, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, UrlMap, CallSettings)
            // Additional: PatchAsync(string, string, string, UrlMap, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.PatchAsync(project, region, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateRegionUrlMapRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            UpdateRegionUrlMapRequest request = new UpdateRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateRegionUrlMapRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRegionUrlMapRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionUrlMapRequest request = new UpdateRegionUrlMapRequest
            {
                RequestId = "",
                Region = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, string, UrlMap, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = regionUrlMapsClient.Update(project, region, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionUrlMapsClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, string, UrlMap, CallSettings)
            // Additional: UpdateAsync(string, string, string, UrlMap, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionUrlMapsClient.UpdateAsync(project, region, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionUrlMapsClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Validate</summary>
        public void ValidateRequestObject()
        {
            // Snippet: Validate(ValidateRegionUrlMapRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            ValidateRegionUrlMapRequest request = new ValidateRegionUrlMapRequest
            {
                RegionUrlMapsValidateRequestResource = new RegionUrlMapsValidateRequest(),
                Region = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            UrlMapsValidateResponse response = regionUrlMapsClient.Validate(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateAsync</summary>
        public async Task ValidateRequestObjectAsync()
        {
            // Snippet: ValidateAsync(ValidateRegionUrlMapRequest, CallSettings)
            // Additional: ValidateAsync(ValidateRegionUrlMapRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ValidateRegionUrlMapRequest request = new ValidateRegionUrlMapRequest
            {
                RegionUrlMapsValidateRequestResource = new RegionUrlMapsValidateRequest(),
                Region = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            UrlMapsValidateResponse response = await regionUrlMapsClient.ValidateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Validate</summary>
        public void Validate()
        {
            // Snippet: Validate(string, string, string, RegionUrlMapsValidateRequest, CallSettings)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = RegionUrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            RegionUrlMapsValidateRequest regionUrlMapsValidateRequestResource = new RegionUrlMapsValidateRequest();
            // Make the request
            UrlMapsValidateResponse response = regionUrlMapsClient.Validate(project, region, urlMap, regionUrlMapsValidateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ValidateAsync</summary>
        public async Task ValidateAsync()
        {
            // Snippet: ValidateAsync(string, string, string, RegionUrlMapsValidateRequest, CallSettings)
            // Additional: ValidateAsync(string, string, string, RegionUrlMapsValidateRequest, CancellationToken)
            // Create client
            RegionUrlMapsClient regionUrlMapsClient = await RegionUrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string urlMap = "";
            RegionUrlMapsValidateRequest regionUrlMapsValidateRequestResource = new RegionUrlMapsValidateRequest();
            // Make the request
            UrlMapsValidateResponse response = await regionUrlMapsClient.ValidateAsync(project, region, urlMap, regionUrlMapsValidateRequestResource);
            // End snippet
        }
    }
}
