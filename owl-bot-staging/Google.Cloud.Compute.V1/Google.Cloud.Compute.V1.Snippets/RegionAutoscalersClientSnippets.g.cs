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
    public sealed class AllGeneratedRegionAutoscalersClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionAutoscalerRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            DeleteRegionAutoscalerRequest request = new DeleteRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionAutoscalerRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionAutoscalerRequest, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionAutoscalerRequest request = new DeleteRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOnceDeleteAsync(operationName);
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
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string autoscaler = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Delete(project, region, autoscaler);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOnceDelete(operationName);
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
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string autoscaler = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.DeleteAsync(project, region, autoscaler);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionAutoscalerRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            GetRegionAutoscalerRequest request = new GetRegionAutoscalerRequest
            {
                Region = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            Autoscaler response = regionAutoscalersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionAutoscalerRequest, CallSettings)
            // Additional: GetAsync(GetRegionAutoscalerRequest, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionAutoscalerRequest request = new GetRegionAutoscalerRequest
            {
                Region = "",
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            Autoscaler response = await regionAutoscalersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string autoscaler = "";
            // Make the request
            Autoscaler response = regionAutoscalersClient.Get(project, region, autoscaler);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string autoscaler = "";
            // Make the request
            Autoscaler response = await regionAutoscalersClient.GetAsync(project, region, autoscaler);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionAutoscalerRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            InsertRegionAutoscalerRequest request = new InsertRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionAutoscalerRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionAutoscalerRequest, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionAutoscalerRequest request = new InsertRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Autoscaler, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Insert(project, region, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Autoscaler, CallSettings)
            // Additional: InsertAsync(string, string, Autoscaler, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.InsertAsync(project, region, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionAutoscalersRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            ListRegionAutoscalersRequest request = new ListRegionAutoscalersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionAutoscalerList, Autoscaler> response = regionAutoscalersClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Autoscaler item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionAutoscalerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            // Snippet: ListAsync(ListRegionAutoscalersRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionAutoscalersRequest request = new ListRegionAutoscalersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionAutoscalerList, Autoscaler> response = regionAutoscalersClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Autoscaler item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionAutoscalerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<RegionAutoscalerList, Autoscaler> response = regionAutoscalersClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Autoscaler item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionAutoscalerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<RegionAutoscalerList, Autoscaler> response = regionAutoscalersClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Autoscaler item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionAutoscalerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Autoscaler item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Autoscaler> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Autoscaler item in singlePage)
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
            // Snippet: Patch(PatchRegionAutoscalerRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            PatchRegionAutoscalerRequest request = new PatchRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionAutoscalerRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionAutoscalerRequest, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionAutoscalerRequest request = new PatchRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, Autoscaler, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Patch(project, region, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, Autoscaler, CallSettings)
            // Additional: PatchAsync(string, string, Autoscaler, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.PatchAsync(project, region, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOncePatchAsync(operationName);
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
            // Snippet: Update(UpdateRegionAutoscalerRequest, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            UpdateRegionAutoscalerRequest request = new UpdateRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateRegionAutoscalerRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRegionAutoscalerRequest, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionAutoscalerRequest request = new UpdateRegionAutoscalerRequest
            {
                RequestId = "",
                Region = "",
                AutoscalerResource = new Autoscaler(),
                Project = "",
                Autoscaler = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, Autoscaler, CallSettings)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = RegionAutoscalersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = regionAutoscalersClient.Update(project, region, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionAutoscalersClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, Autoscaler, CallSettings)
            // Additional: UpdateAsync(string, string, Autoscaler, CancellationToken)
            // Create client
            RegionAutoscalersClient regionAutoscalersClient = await RegionAutoscalersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Autoscaler autoscalerResource = new Autoscaler();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionAutoscalersClient.UpdateAsync(project, region, autoscalerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionAutoscalersClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
