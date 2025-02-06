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
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkAttachmentsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNetworkAttachmentsRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            AggregatedListNetworkAttachmentsRequest request = new AggregatedListNetworkAttachmentsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkAttachmentAggregatedList, KeyValuePair<string, NetworkAttachmentsScopedList>> response = networkAttachmentsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkAttachmentAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkAttachmentsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNetworkAttachmentsRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNetworkAttachmentsRequest request = new AggregatedListNetworkAttachmentsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkAttachmentAggregatedList, KeyValuePair<string, NetworkAttachmentsScopedList>> response = networkAttachmentsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NetworkAttachmentsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkAttachmentAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkAttachmentsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<NetworkAttachmentAggregatedList, KeyValuePair<string, NetworkAttachmentsScopedList>> response = networkAttachmentsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkAttachmentAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkAttachmentsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<NetworkAttachmentAggregatedList, KeyValuePair<string, NetworkAttachmentsScopedList>> response = networkAttachmentsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, NetworkAttachmentsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkAttachmentAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, NetworkAttachmentsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, NetworkAttachmentsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            DeleteNetworkAttachmentRequest request = new DeleteNetworkAttachmentRequest
            {
                RequestId = "",
                Region = "",
                NetworkAttachment = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkAttachmentsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkAttachmentsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteNetworkAttachmentRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkAttachmentRequest request = new DeleteNetworkAttachmentRequest
            {
                RequestId = "",
                Region = "",
                NetworkAttachment = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkAttachmentsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkAttachmentsClient.PollOnceDeleteAsync(operationName);
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
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkAttachment = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkAttachmentsClient.Delete(project, region, networkAttachment);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkAttachmentsClient.PollOnceDelete(operationName);
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
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkAttachment = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkAttachmentsClient.DeleteAsync(project, region, networkAttachment);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkAttachmentsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            GetNetworkAttachmentRequest request = new GetNetworkAttachmentRequest
            {
                Region = "",
                NetworkAttachment = "",
                Project = "",
            };
            // Make the request
            NetworkAttachment response = networkAttachmentsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNetworkAttachmentRequest, CallSettings)
            // Additional: GetAsync(GetNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkAttachmentRequest request = new GetNetworkAttachmentRequest
            {
                Region = "",
                NetworkAttachment = "",
                Project = "",
            };
            // Make the request
            NetworkAttachment response = await networkAttachmentsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkAttachment = "";
            // Make the request
            NetworkAttachment response = networkAttachmentsClient.Get(project, region, networkAttachment);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkAttachment = "";
            // Make the request
            NetworkAttachment response = await networkAttachmentsClient.GetAsync(project, region, networkAttachment);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyNetworkAttachmentRequest request = new GetIamPolicyNetworkAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = networkAttachmentsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyNetworkAttachmentRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyNetworkAttachmentRequest request = new GetIamPolicyNetworkAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await networkAttachmentsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = networkAttachmentsClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await networkAttachmentsClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            InsertNetworkAttachmentRequest request = new InsertNetworkAttachmentRequest
            {
                RequestId = "",
                Region = "",
                NetworkAttachmentResource = new NetworkAttachment(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkAttachmentsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkAttachmentsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertNetworkAttachmentRequest, CallSettings)
            // Additional: InsertAsync(InsertNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            InsertNetworkAttachmentRequest request = new InsertNetworkAttachmentRequest
            {
                RequestId = "",
                Region = "",
                NetworkAttachmentResource = new NetworkAttachment(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkAttachmentsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkAttachmentsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, NetworkAttachment, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NetworkAttachment networkAttachmentResource = new NetworkAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = networkAttachmentsClient.Insert(project, region, networkAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkAttachmentsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, NetworkAttachment, CallSettings)
            // Additional: InsertAsync(string, string, NetworkAttachment, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NetworkAttachment networkAttachmentResource = new NetworkAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkAttachmentsClient.InsertAsync(project, region, networkAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkAttachmentsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListNetworkAttachmentsRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            ListNetworkAttachmentsRequest request = new ListNetworkAttachmentsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkAttachmentList, NetworkAttachment> response = networkAttachmentsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkAttachmentList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkAttachment item in singlePage)
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
            // Snippet: ListAsync(ListNetworkAttachmentsRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkAttachmentsRequest request = new ListNetworkAttachmentsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkAttachmentList, NetworkAttachment> response = networkAttachmentsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkAttachmentList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkAttachment item in singlePage)
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
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<NetworkAttachmentList, NetworkAttachment> response = networkAttachmentsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkAttachmentList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkAttachment item in singlePage)
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
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<NetworkAttachmentList, NetworkAttachment> response = networkAttachmentsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkAttachmentList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkAttachment item in singlePage)
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
            // Snippet: Patch(PatchNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            PatchNetworkAttachmentRequest request = new PatchNetworkAttachmentRequest
            {
                RequestId = "",
                Region = "",
                NetworkAttachmentResource = new NetworkAttachment(),
                NetworkAttachment = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkAttachmentsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkAttachmentsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchNetworkAttachmentRequest, CallSettings)
            // Additional: PatchAsync(PatchNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            PatchNetworkAttachmentRequest request = new PatchNetworkAttachmentRequest
            {
                RequestId = "",
                Region = "",
                NetworkAttachmentResource = new NetworkAttachment(),
                NetworkAttachment = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkAttachmentsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkAttachmentsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, NetworkAttachment, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkAttachment = "";
            NetworkAttachment networkAttachmentResource = new NetworkAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = networkAttachmentsClient.Patch(project, region, networkAttachment, networkAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkAttachmentsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, NetworkAttachment, CallSettings)
            // Additional: PatchAsync(string, string, string, NetworkAttachment, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkAttachment = "";
            NetworkAttachment networkAttachmentResource = new NetworkAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkAttachmentsClient.PatchAsync(project, region, networkAttachment, networkAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkAttachmentsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyNetworkAttachmentRequest request = new SetIamPolicyNetworkAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = networkAttachmentsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyNetworkAttachmentRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyNetworkAttachmentRequest request = new SetIamPolicyNetworkAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await networkAttachmentsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = networkAttachmentsClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await networkAttachmentsClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsNetworkAttachmentRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNetworkAttachmentRequest request = new TestIamPermissionsNetworkAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = networkAttachmentsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNetworkAttachmentRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNetworkAttachmentRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNetworkAttachmentRequest request = new TestIamPermissionsNetworkAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await networkAttachmentsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = NetworkAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = networkAttachmentsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NetworkAttachmentsClient networkAttachmentsClient = await NetworkAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await networkAttachmentsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
