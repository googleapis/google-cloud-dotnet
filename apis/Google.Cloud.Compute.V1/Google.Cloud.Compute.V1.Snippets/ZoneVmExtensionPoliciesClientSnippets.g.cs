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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedZoneVmExtensionPoliciesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteZoneVmExtensionPolicyRequest, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteZoneVmExtensionPolicyRequest request = new DeleteZoneVmExtensionPolicyRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                VmExtensionPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = zoneVmExtensionPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = zoneVmExtensionPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteZoneVmExtensionPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteZoneVmExtensionPolicyRequest, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteZoneVmExtensionPolicyRequest request = new DeleteZoneVmExtensionPolicyRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                VmExtensionPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await zoneVmExtensionPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await zoneVmExtensionPoliciesClient.PollOnceDeleteAsync(operationName);
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
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string vmExtensionPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = zoneVmExtensionPoliciesClient.Delete(project, zone, vmExtensionPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = zoneVmExtensionPoliciesClient.PollOnceDelete(operationName);
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
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string vmExtensionPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await zoneVmExtensionPoliciesClient.DeleteAsync(project, zone, vmExtensionPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await zoneVmExtensionPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetZoneVmExtensionPolicyRequest, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            GetZoneVmExtensionPolicyRequest request = new GetZoneVmExtensionPolicyRequest
            {
                Zone = "",
                Project = "",
                VmExtensionPolicy = "",
            };
            // Make the request
            VmExtensionPolicy response = zoneVmExtensionPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetZoneVmExtensionPolicyRequest, CallSettings)
            // Additional: GetAsync(GetZoneVmExtensionPolicyRequest, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetZoneVmExtensionPolicyRequest request = new GetZoneVmExtensionPolicyRequest
            {
                Zone = "",
                Project = "",
                VmExtensionPolicy = "",
            };
            // Make the request
            VmExtensionPolicy response = await zoneVmExtensionPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string vmExtensionPolicy = "";
            // Make the request
            VmExtensionPolicy response = zoneVmExtensionPoliciesClient.Get(project, zone, vmExtensionPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string vmExtensionPolicy = "";
            // Make the request
            VmExtensionPolicy response = await zoneVmExtensionPoliciesClient.GetAsync(project, zone, vmExtensionPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertZoneVmExtensionPolicyRequest, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            InsertZoneVmExtensionPolicyRequest request = new InsertZoneVmExtensionPolicyRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                VmExtensionPolicyResource = new VmExtensionPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = zoneVmExtensionPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = zoneVmExtensionPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertZoneVmExtensionPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertZoneVmExtensionPolicyRequest, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertZoneVmExtensionPolicyRequest request = new InsertZoneVmExtensionPolicyRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                VmExtensionPolicyResource = new VmExtensionPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await zoneVmExtensionPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await zoneVmExtensionPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, VmExtensionPolicy, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            VmExtensionPolicy vmExtensionPolicyResource = new VmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = zoneVmExtensionPoliciesClient.Insert(project, zone, vmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = zoneVmExtensionPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, VmExtensionPolicy, CallSettings)
            // Additional: InsertAsync(string, string, VmExtensionPolicy, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            VmExtensionPolicy vmExtensionPolicyResource = new VmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await zoneVmExtensionPoliciesClient.InsertAsync(project, zone, vmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await zoneVmExtensionPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListZoneVmExtensionPoliciesRequest, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            ListZoneVmExtensionPoliciesRequest request = new ListZoneVmExtensionPoliciesRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VmExtensionPolicyList, VmExtensionPolicy> response = zoneVmExtensionPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmExtensionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmExtensionPolicy item in singlePage)
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
            // Snippet: ListAsync(ListZoneVmExtensionPoliciesRequest, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListZoneVmExtensionPoliciesRequest request = new ListZoneVmExtensionPoliciesRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VmExtensionPolicyList, VmExtensionPolicy> response = zoneVmExtensionPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (VmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (VmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmExtensionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmExtensionPolicy item in singlePage)
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
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<VmExtensionPolicyList, VmExtensionPolicy> response = zoneVmExtensionPoliciesClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmExtensionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmExtensionPolicy item in singlePage)
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
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<VmExtensionPolicyList, VmExtensionPolicy> response = zoneVmExtensionPoliciesClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (VmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (VmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmExtensionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmExtensionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateZoneVmExtensionPolicyRequest, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            UpdateZoneVmExtensionPolicyRequest request = new UpdateZoneVmExtensionPolicyRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                VmExtensionPolicy = "",
                VmExtensionPolicyResource = new VmExtensionPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = zoneVmExtensionPoliciesClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = zoneVmExtensionPoliciesClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateZoneVmExtensionPolicyRequest, CallSettings)
            // Additional: UpdateAsync(UpdateZoneVmExtensionPolicyRequest, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateZoneVmExtensionPolicyRequest request = new UpdateZoneVmExtensionPolicyRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                VmExtensionPolicy = "",
                VmExtensionPolicyResource = new VmExtensionPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await zoneVmExtensionPoliciesClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await zoneVmExtensionPoliciesClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, VmExtensionPolicy, CallSettings)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = ZoneVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string vmExtensionPolicy = "";
            VmExtensionPolicy vmExtensionPolicyResource = new VmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = zoneVmExtensionPoliciesClient.Update(project, zone, vmExtensionPolicy, vmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = zoneVmExtensionPoliciesClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, VmExtensionPolicy, CallSettings)
            // Additional: UpdateAsync(string, string, string, VmExtensionPolicy, CancellationToken)
            // Create client
            ZoneVmExtensionPoliciesClient zoneVmExtensionPoliciesClient = await ZoneVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string vmExtensionPolicy = "";
            VmExtensionPolicy vmExtensionPolicyResource = new VmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await zoneVmExtensionPoliciesClient.UpdateAsync(project, zone, vmExtensionPolicy, vmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await zoneVmExtensionPoliciesClient.PollOnceUpdateAsync(operationName);
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
