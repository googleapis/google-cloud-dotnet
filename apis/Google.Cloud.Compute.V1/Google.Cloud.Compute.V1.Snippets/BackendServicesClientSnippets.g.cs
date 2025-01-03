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
    public sealed class AllGeneratedBackendServicesClientSnippets
    {
        /// <summary>Snippet for AddSignedUrlKey</summary>
        public void AddSignedUrlKeyRequestObject()
        {
            // Snippet: AddSignedUrlKey(AddSignedUrlKeyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                SignedUrlKeyResource = new SignedUrlKey(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.AddSignedUrlKey(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceAddSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKeyAsync</summary>
        public async Task AddSignedUrlKeyRequestObjectAsync()
        {
            // Snippet: AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest, CallSettings)
            // Additional: AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            AddSignedUrlKeyBackendServiceRequest request = new AddSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                SignedUrlKeyResource = new SignedUrlKey(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.AddSignedUrlKeyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceAddSignedUrlKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKey</summary>
        public void AddSignedUrlKey()
        {
            // Snippet: AddSignedUrlKey(string, string, SignedUrlKey, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SignedUrlKey signedUrlKeyResource = new SignedUrlKey();
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.AddSignedUrlKey(project, backendService, signedUrlKeyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceAddSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddSignedUrlKeyAsync</summary>
        public async Task AddSignedUrlKeyAsync()
        {
            // Snippet: AddSignedUrlKeyAsync(string, string, SignedUrlKey, CallSettings)
            // Additional: AddSignedUrlKeyAsync(string, string, SignedUrlKey, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SignedUrlKey signedUrlKeyResource = new SignedUrlKey();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.AddSignedUrlKeyAsync(project, backendService, signedUrlKeyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceAddSignedUrlKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendServiceAggregatedList, KeyValuePair<string, BackendServicesScopedList>> response = backendServicesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, BackendServicesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, BackendServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, BackendServicesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, BackendServicesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListBackendServicesRequest request = new AggregatedListBackendServicesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendServiceAggregatedList, KeyValuePair<string, BackendServicesScopedList>> response = backendServicesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, BackendServicesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, BackendServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, BackendServicesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, BackendServicesScopedList> item in singlePage)
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
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<BackendServiceAggregatedList, KeyValuePair<string, BackendServicesScopedList>> response = backendServicesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, BackendServicesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, BackendServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, BackendServicesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, BackendServicesScopedList> item in singlePage)
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
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<BackendServiceAggregatedList, KeyValuePair<string, BackendServicesScopedList>> response = backendServicesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, BackendServicesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, BackendServicesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, BackendServicesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, BackendServicesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteBackendServiceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackendServiceRequest request = new DeleteBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceDeleteAsync(operationName);
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
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Delete(project, backendService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceDelete(operationName);
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
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.DeleteAsync(project, backendService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKey</summary>
        public void DeleteSignedUrlKeyRequestObject()
        {
            // Snippet: DeleteSignedUrlKey(DeleteSignedUrlKeyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                KeyName = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.DeleteSignedUrlKey(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceDeleteSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKeyAsync</summary>
        public async Task DeleteSignedUrlKeyRequestObjectAsync()
        {
            // Snippet: DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest, CallSettings)
            // Additional: DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSignedUrlKeyBackendServiceRequest request = new DeleteSignedUrlKeyBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                KeyName = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.DeleteSignedUrlKeyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceDeleteSignedUrlKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKey</summary>
        public void DeleteSignedUrlKey()
        {
            // Snippet: DeleteSignedUrlKey(string, string, string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            string keyName = "";
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.DeleteSignedUrlKey(project, backendService, keyName);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceDeleteSignedUrlKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSignedUrlKeyAsync</summary>
        public async Task DeleteSignedUrlKeyAsync()
        {
            // Snippet: DeleteSignedUrlKeyAsync(string, string, string, CallSettings)
            // Additional: DeleteSignedUrlKeyAsync(string, string, string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            string keyName = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.DeleteSignedUrlKeyAsync(project, backendService, keyName);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceDeleteSignedUrlKeyAsync(operationName);
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
            // Snippet: Get(GetBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendService response = backendServicesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetBackendServiceRequest, CallSettings)
            // Additional: GetAsync(GetBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetBackendServiceRequest request = new GetBackendServiceRequest
            {
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendService response = await backendServicesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            BackendService response = backendServicesClient.Get(project, backendService);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            // Make the request
            BackendService response = await backendServicesClient.GetAsync(project, backendService);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealthRequestObject()
        {
            // Snippet: GetHealth(GetHealthBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendServiceGroupHealth response = backendServicesClient.GetHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthRequestObjectAsync()
        {
            // Snippet: GetHealthAsync(GetHealthBackendServiceRequest, CallSettings)
            // Additional: GetHealthAsync(GetHealthBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthBackendServiceRequest request = new GetHealthBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendServiceGroupHealth response = await backendServicesClient.GetHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealth()
        {
            // Snippet: GetHealth(string, string, ResourceGroupReference, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            ResourceGroupReference resourceGroupReferenceResource = new ResourceGroupReference();
            // Make the request
            BackendServiceGroupHealth response = backendServicesClient.GetHealth(project, backendService, resourceGroupReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthAsync()
        {
            // Snippet: GetHealthAsync(string, string, ResourceGroupReference, CallSettings)
            // Additional: GetHealthAsync(string, string, ResourceGroupReference, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            ResourceGroupReference resourceGroupReferenceResource = new ResourceGroupReference();
            // Make the request
            BackendServiceGroupHealth response = await backendServicesClient.GetHealthAsync(project, backendService, resourceGroupReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyBackendServiceRequest request = new GetIamPolicyBackendServiceRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = backendServicesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyBackendServiceRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyBackendServiceRequest request = new GetIamPolicyBackendServiceRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await backendServicesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = backendServicesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await backendServicesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertBackendServiceRequest, CallSettings)
            // Additional: InsertAsync(InsertBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            InsertBackendServiceRequest request = new InsertBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, BackendService, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Insert(project, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, BackendService, CallSettings)
            // Additional: InsertAsync(string, BackendService, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.InsertAsync(project, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendServiceList, BackendService> response = backendServicesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            // Snippet: ListAsync(ListBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListBackendServicesRequest request = new ListBackendServicesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendServiceList, BackendService> response = backendServicesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<BackendServiceList, BackendService> response = backendServicesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<BackendServiceList, BackendService> response = backendServicesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsableRequestObject()
        {
            // Snippet: ListUsable(ListUsableBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            ListUsableBackendServicesRequest request = new ListUsableBackendServicesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendServiceListUsable, BackendService> response = backendServicesClient.ListUsable(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceListUsable page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableRequestObjectAsync()
        {
            // Snippet: ListUsableAsync(ListUsableBackendServicesRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableBackendServicesRequest request = new ListUsableBackendServicesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendServiceListUsable, BackendService> response = backendServicesClient.ListUsableAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceListUsable page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsable</summary>
        public void ListUsable()
        {
            // Snippet: ListUsable(string, string, int?, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<BackendServiceListUsable, BackendService> response = backendServicesClient.ListUsable(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceListUsable page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableAsync</summary>
        public async Task ListUsableAsync()
        {
            // Snippet: ListUsableAsync(string, string, int?, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<BackendServiceListUsable, BackendService> response = backendServicesClient.ListUsableAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceListUsable page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            // Snippet: Patch(PatchBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchBackendServiceRequest, CallSettings)
            // Additional: PatchAsync(PatchBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            PatchBackendServiceRequest request = new PatchBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, BackendService, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Patch(project, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, BackendService, CallSettings)
            // Additional: PatchAsync(string, string, BackendService, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.PatchAsync(project, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicy</summary>
        public void SetEdgeSecurityPolicyRequestObject()
        {
            // Snippet: SetEdgeSecurityPolicy(SetEdgeSecurityPolicyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            SetEdgeSecurityPolicyBackendServiceRequest request = new SetEdgeSecurityPolicyBackendServiceRequest
            {
                RequestId = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.SetEdgeSecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceSetEdgeSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicyAsync</summary>
        public async Task SetEdgeSecurityPolicyRequestObjectAsync()
        {
            // Snippet: SetEdgeSecurityPolicyAsync(SetEdgeSecurityPolicyBackendServiceRequest, CallSettings)
            // Additional: SetEdgeSecurityPolicyAsync(SetEdgeSecurityPolicyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            SetEdgeSecurityPolicyBackendServiceRequest request = new SetEdgeSecurityPolicyBackendServiceRequest
            {
                RequestId = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.SetEdgeSecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceSetEdgeSecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicy</summary>
        public void SetEdgeSecurityPolicy()
        {
            // Snippet: SetEdgeSecurityPolicy(string, string, SecurityPolicyReference, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.SetEdgeSecurityPolicy(project, backendService, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceSetEdgeSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetEdgeSecurityPolicyAsync</summary>
        public async Task SetEdgeSecurityPolicyAsync()
        {
            // Snippet: SetEdgeSecurityPolicyAsync(string, string, SecurityPolicyReference, CallSettings)
            // Additional: SetEdgeSecurityPolicyAsync(string, string, SecurityPolicyReference, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.SetEdgeSecurityPolicyAsync(project, backendService, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceSetEdgeSecurityPolicyAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyBackendServiceRequest request = new SetIamPolicyBackendServiceRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = backendServicesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyBackendServiceRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyBackendServiceRequest request = new SetIamPolicyBackendServiceRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await backendServicesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = backendServicesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await backendServicesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicyRequestObject()
        {
            // Snippet: SetSecurityPolicy(SetSecurityPolicyBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                RequestId = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.SetSecurityPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceSetSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicyAsync</summary>
        public async Task SetSecurityPolicyRequestObjectAsync()
        {
            // Snippet: SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest, CallSettings)
            // Additional: SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            SetSecurityPolicyBackendServiceRequest request = new SetSecurityPolicyBackendServiceRequest
            {
                RequestId = "",
                SecurityPolicyReferenceResource = new SecurityPolicyReference(),
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.SetSecurityPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceSetSecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicy</summary>
        public void SetSecurityPolicy()
        {
            // Snippet: SetSecurityPolicy(string, string, SecurityPolicyReference, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.SetSecurityPolicy(project, backendService, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceSetSecurityPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSecurityPolicyAsync</summary>
        public async Task SetSecurityPolicyAsync()
        {
            // Snippet: SetSecurityPolicyAsync(string, string, SecurityPolicyReference, CallSettings)
            // Additional: SetSecurityPolicyAsync(string, string, SecurityPolicyReference, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            SecurityPolicyReference securityPolicyReferenceResource = new SecurityPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.SetSecurityPolicyAsync(project, backendService, securityPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceSetSecurityPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsBackendServiceRequest request = new TestIamPermissionsBackendServiceRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = backendServicesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsBackendServiceRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsBackendServiceRequest request = new TestIamPermissionsBackendServiceRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await backendServicesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = backendServicesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await backendServicesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateBackendServiceRequest, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateBackendServiceRequest, CallSettings)
            // Additional: UpdateAsync(UpdateBackendServiceRequest, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackendServiceRequest request = new UpdateBackendServiceRequest
            {
                RequestId = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, BackendService, CallSettings)
            // Create client
            BackendServicesClient backendServicesClient = BackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = backendServicesClient.Update(project, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = backendServicesClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, BackendService, CallSettings)
            // Additional: UpdateAsync(string, string, BackendService, CancellationToken)
            // Create client
            BackendServicesClient backendServicesClient = await BackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = await backendServicesClient.UpdateAsync(project, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await backendServicesClient.PollOnceUpdateAsync(operationName);
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
