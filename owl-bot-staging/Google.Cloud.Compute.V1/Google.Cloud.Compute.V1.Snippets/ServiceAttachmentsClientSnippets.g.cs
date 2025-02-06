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
    public sealed class AllGeneratedServiceAttachmentsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListServiceAttachmentsRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            AggregatedListServiceAttachmentsRequest request = new AggregatedListServiceAttachmentsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ServiceAttachmentAggregatedList, KeyValuePair<string, ServiceAttachmentsScopedList>> response = serviceAttachmentsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ServiceAttachmentAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ServiceAttachmentsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListServiceAttachmentsRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListServiceAttachmentsRequest request = new AggregatedListServiceAttachmentsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ServiceAttachmentAggregatedList, KeyValuePair<string, ServiceAttachmentsScopedList>> response = serviceAttachmentsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ServiceAttachmentsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ServiceAttachmentAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ServiceAttachmentsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in singlePage)
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
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ServiceAttachmentAggregatedList, KeyValuePair<string, ServiceAttachmentsScopedList>> response = serviceAttachmentsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ServiceAttachmentAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ServiceAttachmentsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in singlePage)
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
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ServiceAttachmentAggregatedList, KeyValuePair<string, ServiceAttachmentsScopedList>> response = serviceAttachmentsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ServiceAttachmentsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ServiceAttachmentAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ServiceAttachmentsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ServiceAttachmentsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            DeleteServiceAttachmentRequest request = new DeleteServiceAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ServiceAttachment = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = serviceAttachmentsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = serviceAttachmentsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteServiceAttachmentRequest, CallSettings)
            // Additional: DeleteAsync(DeleteServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceAttachmentRequest request = new DeleteServiceAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ServiceAttachment = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await serviceAttachmentsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await serviceAttachmentsClient.PollOnceDeleteAsync(operationName);
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
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string serviceAttachment = "";
            // Make the request
            lro::Operation<Operation, Operation> response = serviceAttachmentsClient.Delete(project, region, serviceAttachment);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = serviceAttachmentsClient.PollOnceDelete(operationName);
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
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string serviceAttachment = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await serviceAttachmentsClient.DeleteAsync(project, region, serviceAttachment);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await serviceAttachmentsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            GetServiceAttachmentRequest request = new GetServiceAttachmentRequest
            {
                Region = "",
                Project = "",
                ServiceAttachment = "",
            };
            // Make the request
            ServiceAttachment response = serviceAttachmentsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetServiceAttachmentRequest, CallSettings)
            // Additional: GetAsync(GetServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceAttachmentRequest request = new GetServiceAttachmentRequest
            {
                Region = "",
                Project = "",
                ServiceAttachment = "",
            };
            // Make the request
            ServiceAttachment response = await serviceAttachmentsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string serviceAttachment = "";
            // Make the request
            ServiceAttachment response = serviceAttachmentsClient.Get(project, region, serviceAttachment);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string serviceAttachment = "";
            // Make the request
            ServiceAttachment response = await serviceAttachmentsClient.GetAsync(project, region, serviceAttachment);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyServiceAttachmentRequest request = new GetIamPolicyServiceAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = serviceAttachmentsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyServiceAttachmentRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyServiceAttachmentRequest request = new GetIamPolicyServiceAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await serviceAttachmentsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = serviceAttachmentsClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await serviceAttachmentsClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            InsertServiceAttachmentRequest request = new InsertServiceAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ServiceAttachmentResource = new ServiceAttachment(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = serviceAttachmentsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = serviceAttachmentsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertServiceAttachmentRequest, CallSettings)
            // Additional: InsertAsync(InsertServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            InsertServiceAttachmentRequest request = new InsertServiceAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ServiceAttachmentResource = new ServiceAttachment(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await serviceAttachmentsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await serviceAttachmentsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, ServiceAttachment, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ServiceAttachment serviceAttachmentResource = new ServiceAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = serviceAttachmentsClient.Insert(project, region, serviceAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = serviceAttachmentsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, ServiceAttachment, CallSettings)
            // Additional: InsertAsync(string, string, ServiceAttachment, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ServiceAttachment serviceAttachmentResource = new ServiceAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = await serviceAttachmentsClient.InsertAsync(project, region, serviceAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await serviceAttachmentsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListServiceAttachmentsRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            ListServiceAttachmentsRequest request = new ListServiceAttachmentsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ServiceAttachmentList, ServiceAttachment> response = serviceAttachmentsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ServiceAttachmentList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAttachment item in singlePage)
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
            // Snippet: ListAsync(ListServiceAttachmentsRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceAttachmentsRequest request = new ListServiceAttachmentsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ServiceAttachmentList, ServiceAttachment> response = serviceAttachmentsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ServiceAttachmentList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAttachment item in singlePage)
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
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<ServiceAttachmentList, ServiceAttachment> response = serviceAttachmentsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ServiceAttachmentList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAttachment item in singlePage)
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
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ServiceAttachmentList, ServiceAttachment> response = serviceAttachmentsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ServiceAttachmentList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAttachment item in singlePage)
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
            // Snippet: Patch(PatchServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            PatchServiceAttachmentRequest request = new PatchServiceAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ServiceAttachment = "",
                ServiceAttachmentResource = new ServiceAttachment(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = serviceAttachmentsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = serviceAttachmentsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchServiceAttachmentRequest, CallSettings)
            // Additional: PatchAsync(PatchServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            PatchServiceAttachmentRequest request = new PatchServiceAttachmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ServiceAttachment = "",
                ServiceAttachmentResource = new ServiceAttachment(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await serviceAttachmentsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await serviceAttachmentsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, ServiceAttachment, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string serviceAttachment = "";
            ServiceAttachment serviceAttachmentResource = new ServiceAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = serviceAttachmentsClient.Patch(project, region, serviceAttachment, serviceAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = serviceAttachmentsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, ServiceAttachment, CallSettings)
            // Additional: PatchAsync(string, string, string, ServiceAttachment, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string serviceAttachment = "";
            ServiceAttachment serviceAttachmentResource = new ServiceAttachment();
            // Make the request
            lro::Operation<Operation, Operation> response = await serviceAttachmentsClient.PatchAsync(project, region, serviceAttachment, serviceAttachmentResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await serviceAttachmentsClient.PollOncePatchAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyServiceAttachmentRequest request = new SetIamPolicyServiceAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = serviceAttachmentsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyServiceAttachmentRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyServiceAttachmentRequest request = new SetIamPolicyServiceAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await serviceAttachmentsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = serviceAttachmentsClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await serviceAttachmentsClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsServiceAttachmentRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsServiceAttachmentRequest request = new TestIamPermissionsServiceAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = serviceAttachmentsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsServiceAttachmentRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsServiceAttachmentRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsServiceAttachmentRequest request = new TestIamPermissionsServiceAttachmentRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await serviceAttachmentsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = ServiceAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = serviceAttachmentsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ServiceAttachmentsClient serviceAttachmentsClient = await ServiceAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await serviceAttachmentsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
