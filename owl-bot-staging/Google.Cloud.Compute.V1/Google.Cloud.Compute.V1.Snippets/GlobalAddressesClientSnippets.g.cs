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
    public sealed class AllGeneratedGlobalAddressesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                RequestId = "",
                Project = "",
                Address = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteGlobalAddressRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                RequestId = "",
                Project = "",
                Address = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceDeleteAsync(operationName);
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
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.Delete(project, address);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceDelete(operationName);
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
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.DeleteAsync(project, address);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "",
                Address = "",
            };
            // Make the request
            Address response = globalAddressesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalAddressRequest, CallSettings)
            // Additional: GetAsync(GetGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "",
                Address = "",
            };
            // Make the request
            Address response = await globalAddressesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            Address response = globalAddressesClient.Get(project, address);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            // Make the request
            Address response = await globalAddressesClient.GetAsync(project, address);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                RequestId = "",
                Project = "",
                AddressResource = new Address(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertGlobalAddressRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                RequestId = "",
                Project = "",
                AddressResource = new Address(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, Address, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            Address addressResource = new Address();
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.Insert(project, addressResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, Address, CallSettings)
            // Additional: InsertAsync(string, Address, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Address addressResource = new Address();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.InsertAsync(project, addressResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListGlobalAddressesRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<AddressList, Address> response = globalAddressesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Address item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AddressList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Address item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Address> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Address item in singlePage)
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
            // Snippet: ListAsync(ListGlobalAddressesRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<AddressList, Address> response = globalAddressesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Address item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AddressList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Address item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Address> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Address item in singlePage)
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
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<AddressList, Address> response = globalAddressesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Address item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AddressList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Address item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Address> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Address item in singlePage)
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
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<AddressList, Address> response = globalAddressesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Address item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AddressList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Address item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Address> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Address item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Move</summary>
        public void MoveRequestObject()
        {
            // Snippet: Move(MoveGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            MoveGlobalAddressRequest request = new MoveGlobalAddressRequest
            {
                RequestId = "",
                Project = "",
                GlobalAddressesMoveRequestResource = new GlobalAddressesMoveRequest(),
                Address = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.Move(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceMove(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveAsync</summary>
        public async Task MoveRequestObjectAsync()
        {
            // Snippet: MoveAsync(MoveGlobalAddressRequest, CallSettings)
            // Additional: MoveAsync(MoveGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            MoveGlobalAddressRequest request = new MoveGlobalAddressRequest
            {
                RequestId = "",
                Project = "",
                GlobalAddressesMoveRequestResource = new GlobalAddressesMoveRequest(),
                Address = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.MoveAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceMoveAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Move</summary>
        public void Move()
        {
            // Snippet: Move(string, string, GlobalAddressesMoveRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            GlobalAddressesMoveRequest globalAddressesMoveRequestResource = new GlobalAddressesMoveRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.Move(project, address, globalAddressesMoveRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceMove(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveAsync</summary>
        public async Task MoveAsync()
        {
            // Snippet: MoveAsync(string, string, GlobalAddressesMoveRequest, CallSettings)
            // Additional: MoveAsync(string, string, GlobalAddressesMoveRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string address = "";
            GlobalAddressesMoveRequest globalAddressesMoveRequestResource = new GlobalAddressesMoveRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.MoveAsync(project, address, globalAddressesMoveRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceMoveAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsGlobalAddressRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            SetLabelsGlobalAddressRequest request = new SetLabelsGlobalAddressRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsGlobalAddressRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsGlobalAddressRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsGlobalAddressRequest request = new SetLabelsGlobalAddressRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            GlobalAddressesClient globalAddressesClient = GlobalAddressesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = globalAddressesClient.SetLabels(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalAddressesClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            GlobalAddressesClient globalAddressesClient = await GlobalAddressesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalAddressesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalAddressesClient.PollOnceSetLabelsAsync(operationName);
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
