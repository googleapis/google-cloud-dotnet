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
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInterconnectAttachmentsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectAttachmentAggregatedList, KeyValuePair<string, InterconnectAttachmentsScopedList>> response = interconnectAttachmentsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectAttachmentAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InterconnectAttachmentsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectAttachmentAggregatedList, KeyValuePair<string, InterconnectAttachmentsScopedList>> response = interconnectAttachmentsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InterconnectAttachmentsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectAttachmentAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InterconnectAttachmentsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in singlePage)
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
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InterconnectAttachmentAggregatedList, KeyValuePair<string, InterconnectAttachmentsScopedList>> response = interconnectAttachmentsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectAttachmentAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InterconnectAttachmentsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in singlePage)
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
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectAttachmentAggregatedList, KeyValuePair<string, InterconnectAttachmentsScopedList>> response = interconnectAttachmentsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InterconnectAttachmentsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectAttachmentAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InterconnectAttachmentsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InterconnectAttachmentsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InterconnectAttachment = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteInterconnectAttachmentRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InterconnectAttachment = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOnceDeleteAsync(operationName);
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
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.Delete(project, region, interconnectAttachment);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOnceDelete(operationName);
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
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.DeleteAsync(project, region, interconnectAttachment);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "",
                Project = "",
                InterconnectAttachment = "",
            };
            // Make the request
            InterconnectAttachment response = interconnectAttachmentsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectAttachmentRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "",
                Project = "",
                InterconnectAttachment = "",
            };
            // Make the request
            InterconnectAttachment response = await interconnectAttachmentsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            InterconnectAttachment response = interconnectAttachmentsClient.Get(project, region, interconnectAttachment);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            InterconnectAttachment response = await interconnectAttachmentsClient.GetAsync(project, region, interconnectAttachment);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertInterconnectAttachmentRequest, CallSettings)
            // Additional: InsertAsync(InsertInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, InterconnectAttachment, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.Insert(project, region, interconnectAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, InterconnectAttachment, CallSettings)
            // Additional: InsertAsync(string, string, InterconnectAttachment, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.InsertAsync(project, region, interconnectAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectAttachmentList, InterconnectAttachment> response = interconnectAttachmentsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectAttachmentList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
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
            // Snippet: ListAsync(ListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectAttachmentList, InterconnectAttachment> response = interconnectAttachmentsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectAttachmentList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
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
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<InterconnectAttachmentList, InterconnectAttachment> response = interconnectAttachmentsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectAttachmentList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
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
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectAttachmentList, InterconnectAttachment> response = interconnectAttachmentsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectAttachmentList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
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
            // Snippet: Patch(PatchInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
                InterconnectAttachment = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchInterconnectAttachmentRequest, CallSettings)
            // Additional: PatchAsync(PatchInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
                InterconnectAttachment = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, InterconnectAttachment, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.Patch(project, region, interconnectAttachment, interconnectAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, InterconnectAttachment, CallSettings)
            // Additional: PatchAsync(string, string, string, InterconnectAttachment, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.PatchAsync(project, region, interconnectAttachment, interconnectAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOncePatchAsync(operationName);
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
            // Snippet: SetLabels(SetLabelsInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            SetLabelsInterconnectAttachmentRequest request = new SetLabelsInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsInterconnectAttachmentRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsInterconnectAttachmentRequest request = new SetLabelsInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOnceSetLabelsAsync(operationName);
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
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentsClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentsClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentsClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentsClient.PollOnceSetLabelsAsync(operationName);
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
