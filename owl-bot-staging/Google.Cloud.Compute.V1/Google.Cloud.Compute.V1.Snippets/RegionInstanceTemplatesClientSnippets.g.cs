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
    public sealed class AllGeneratedRegionInstanceTemplatesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionInstanceTemplateRequest, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            DeleteRegionInstanceTemplateRequest request = new DeleteRegionInstanceTemplateRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceTemplate = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceTemplatesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceTemplatesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionInstanceTemplateRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionInstanceTemplateRequest, CancellationToken)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionInstanceTemplateRequest request = new DeleteRegionInstanceTemplateRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceTemplate = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceTemplatesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceTemplatesClient.PollOnceDeleteAsync(operationName);
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
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceTemplate = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceTemplatesClient.Delete(project, region, instanceTemplate);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceTemplatesClient.PollOnceDelete(operationName);
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
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceTemplate = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceTemplatesClient.DeleteAsync(project, region, instanceTemplate);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceTemplatesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionInstanceTemplateRequest, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            GetRegionInstanceTemplateRequest request = new GetRegionInstanceTemplateRequest
            {
                Region = "",
                Project = "",
                InstanceTemplate = "",
            };
            // Make the request
            InstanceTemplate response = regionInstanceTemplatesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstanceTemplateRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstanceTemplateRequest, CancellationToken)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstanceTemplateRequest request = new GetRegionInstanceTemplateRequest
            {
                Region = "",
                Project = "",
                InstanceTemplate = "",
            };
            // Make the request
            InstanceTemplate response = await regionInstanceTemplatesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceTemplate = "";
            // Make the request
            InstanceTemplate response = regionInstanceTemplatesClient.Get(project, region, instanceTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceTemplate = "";
            // Make the request
            InstanceTemplate response = await regionInstanceTemplatesClient.GetAsync(project, region, instanceTemplate);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionInstanceTemplateRequest, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            InsertRegionInstanceTemplateRequest request = new InsertRegionInstanceTemplateRequest
            {
                InstanceTemplateResource = new InstanceTemplate(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceTemplatesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceTemplatesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionInstanceTemplateRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionInstanceTemplateRequest, CancellationToken)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionInstanceTemplateRequest request = new InsertRegionInstanceTemplateRequest
            {
                InstanceTemplateResource = new InstanceTemplate(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceTemplatesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceTemplatesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, InstanceTemplate, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstanceTemplate instanceTemplateResource = new InstanceTemplate();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceTemplatesClient.Insert(project, region, instanceTemplateResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceTemplatesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, InstanceTemplate, CallSettings)
            // Additional: InsertAsync(string, string, InstanceTemplate, CancellationToken)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstanceTemplate instanceTemplateResource = new InstanceTemplate();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceTemplatesClient.InsertAsync(project, region, instanceTemplateResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceTemplatesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionInstanceTemplatesRequest, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            ListRegionInstanceTemplatesRequest request = new ListRegionInstanceTemplatesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceTemplateList, InstanceTemplate> response = regionInstanceTemplatesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceTemplateList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceTemplate item in singlePage)
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
            // Snippet: ListAsync(ListRegionInstanceTemplatesRequest, CallSettings)
            // Create client
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstanceTemplatesRequest request = new ListRegionInstanceTemplatesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceTemplateList, InstanceTemplate> response = regionInstanceTemplatesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceTemplateList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceTemplate item in singlePage)
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
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = RegionInstanceTemplatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<InstanceTemplateList, InstanceTemplate> response = regionInstanceTemplatesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceTemplateList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceTemplate item in singlePage)
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
            RegionInstanceTemplatesClient regionInstanceTemplatesClient = await RegionInstanceTemplatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<InstanceTemplateList, InstanceTemplate> response = regionInstanceTemplatesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceTemplateList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceTemplate item in singlePage)
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
