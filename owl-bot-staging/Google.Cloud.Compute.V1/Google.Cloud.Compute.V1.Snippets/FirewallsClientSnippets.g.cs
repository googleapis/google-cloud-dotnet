// Copyright 2024 Google LLC
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
    public sealed class AllGeneratedFirewallsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteFirewallRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            DeleteFirewallRequest request = new DeleteFirewallRequest
            {
                RequestId = "",
                Project = "",
                Firewall = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteFirewallRequest, CallSettings)
            // Additional: DeleteAsync(DeleteFirewallRequest, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirewallRequest request = new DeleteFirewallRequest
            {
                RequestId = "",
                Project = "",
                Firewall = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Delete(project, firewall);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.DeleteAsync(project, firewall);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetFirewallRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            GetFirewallRequest request = new GetFirewallRequest
            {
                Project = "",
                Firewall = "",
            };
            // Make the request
            Firewall response = firewallsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetFirewallRequest, CallSettings)
            // Additional: GetAsync(GetFirewallRequest, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            GetFirewallRequest request = new GetFirewallRequest
            {
                Project = "",
                Firewall = "",
            };
            // Make the request
            Firewall response = await firewallsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            // Make the request
            Firewall response = firewallsClient.Get(project, firewall);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            // Make the request
            Firewall response = await firewallsClient.GetAsync(project, firewall);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertFirewallRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            InsertFirewallRequest request = new InsertFirewallRequest
            {
                RequestId = "",
                FirewallResource = new Firewall(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertFirewallRequest, CallSettings)
            // Additional: InsertAsync(InsertFirewallRequest, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            InsertFirewallRequest request = new InsertFirewallRequest
            {
                RequestId = "",
                FirewallResource = new Firewall(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, Firewall, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            string project = "";
            Firewall firewallResource = new Firewall();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Insert(project, firewallResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, Firewall, CallSettings)
            // Additional: InsertAsync(string, Firewall, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Firewall firewallResource = new Firewall();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.InsertAsync(project, firewallResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListFirewallsRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            ListFirewallsRequest request = new ListFirewallsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<FirewallList, Firewall> response = firewallsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Firewall item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FirewallList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Firewall item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Firewall> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Firewall item in singlePage)
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
            // Snippet: ListAsync(ListFirewallsRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            ListFirewallsRequest request = new ListFirewallsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<FirewallList, Firewall> response = firewallsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Firewall item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FirewallList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Firewall item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Firewall> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Firewall item in singlePage)
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
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<FirewallList, Firewall> response = firewallsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Firewall item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FirewallList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Firewall item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Firewall> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Firewall item in singlePage)
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
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<FirewallList, Firewall> response = firewallsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Firewall item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FirewallList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Firewall item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Firewall> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Firewall item in singlePage)
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
            // Snippet: Patch(PatchFirewallRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            PatchFirewallRequest request = new PatchFirewallRequest
            {
                RequestId = "",
                FirewallResource = new Firewall(),
                Project = "",
                Firewall = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchFirewallRequest, CallSettings)
            // Additional: PatchAsync(PatchFirewallRequest, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            PatchFirewallRequest request = new PatchFirewallRequest
            {
                RequestId = "",
                FirewallResource = new Firewall(),
                Project = "",
                Firewall = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, Firewall, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            Firewall firewallResource = new Firewall();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Patch(project, firewall, firewallResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, Firewall, CallSettings)
            // Additional: PatchAsync(string, string, Firewall, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            Firewall firewallResource = new Firewall();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.PatchAsync(project, firewall, firewallResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Update(UpdateFirewallRequest, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            UpdateFirewallRequest request = new UpdateFirewallRequest
            {
                RequestId = "",
                FirewallResource = new Firewall(),
                Project = "",
                Firewall = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateFirewallRequest, CallSettings)
            // Additional: UpdateAsync(UpdateFirewallRequest, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFirewallRequest request = new UpdateFirewallRequest
            {
                RequestId = "",
                FirewallResource = new Firewall(),
                Project = "",
                Firewall = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, Firewall, CallSettings)
            // Create client
            FirewallsClient firewallsClient = FirewallsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            Firewall firewallResource = new Firewall();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallsClient.Update(project, firewall, firewallResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, Firewall, CallSettings)
            // Additional: UpdateAsync(string, string, Firewall, CancellationToken)
            // Create client
            FirewallsClient firewallsClient = await FirewallsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewall = "";
            Firewall firewallResource = new Firewall();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallsClient.UpdateAsync(project, firewall, firewallResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallsClient.PollOnceUpdateAsync(operationName);
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
