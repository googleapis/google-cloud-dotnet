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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.ServiceUsage.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServiceUsageClientSnippets
    {
        /// <summary>Snippet for EnableService</summary>
        public void EnableServiceRequestObject()
        {
            // Snippet: EnableService(EnableServiceRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            EnableServiceRequest request = new EnableServiceRequest { Name = "", };
            // Make the request
            Operation<EnableServiceResponse, OperationMetadata> response = serviceUsageClient.EnableService(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableServiceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnableServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableServiceResponse, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceEnableService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAsync</summary>
        public async Task EnableServiceRequestObjectAsync()
        {
            // Snippet: EnableServiceAsync(EnableServiceRequest, CallSettings)
            // Additional: EnableServiceAsync(EnableServiceRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            EnableServiceRequest request = new EnableServiceRequest { Name = "", };
            // Make the request
            Operation<EnableServiceResponse, OperationMetadata> response = await serviceUsageClient.EnableServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableServiceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnableServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableServiceResponse, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceEnableServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableService</summary>
        public void DisableServiceRequestObject()
        {
            // Snippet: DisableService(DisableServiceRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            DisableServiceRequest request = new DisableServiceRequest
            {
                Name = "",
                DisableDependentServices = false,
                CheckIfServiceHasUsage = DisableServiceRequest.Types.CheckIfServiceHasUsage.Unspecified,
            };
            // Make the request
            Operation<DisableServiceResponse, OperationMetadata> response = serviceUsageClient.DisableService(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableServiceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisableServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableServiceResponse, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceDisableService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAsync</summary>
        public async Task DisableServiceRequestObjectAsync()
        {
            // Snippet: DisableServiceAsync(DisableServiceRequest, CallSettings)
            // Additional: DisableServiceAsync(DisableServiceRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            DisableServiceRequest request = new DisableServiceRequest
            {
                Name = "",
                DisableDependentServices = false,
                CheckIfServiceHasUsage = DisableServiceRequest.Types.CheckIfServiceHasUsage.Unspecified,
            };
            // Make the request
            Operation<DisableServiceResponse, OperationMetadata> response = await serviceUsageClient.DisableServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableServiceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisableServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableServiceResponse, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceDisableServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { Name = "", };
            // Make the request
            Service response = serviceUsageClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { Name = "", };
            // Make the request
            Service response = await serviceUsageClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceUsageClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceUsageClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchEnableServices</summary>
        public void BatchEnableServicesRequestObject()
        {
            // Snippet: BatchEnableServices(BatchEnableServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            BatchEnableServicesRequest request = new BatchEnableServicesRequest
            {
                Parent = "",
                ServiceIds = { "", },
            };
            // Make the request
            Operation<BatchEnableServicesResponse, OperationMetadata> response = serviceUsageClient.BatchEnableServices(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchEnableServicesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchEnableServicesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchEnableServicesResponse, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceBatchEnableServices(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchEnableServicesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchEnableServicesAsync</summary>
        public async Task BatchEnableServicesRequestObjectAsync()
        {
            // Snippet: BatchEnableServicesAsync(BatchEnableServicesRequest, CallSettings)
            // Additional: BatchEnableServicesAsync(BatchEnableServicesRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            BatchEnableServicesRequest request = new BatchEnableServicesRequest
            {
                Parent = "",
                ServiceIds = { "", },
            };
            // Make the request
            Operation<BatchEnableServicesResponse, OperationMetadata> response = await serviceUsageClient.BatchEnableServicesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchEnableServicesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchEnableServicesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchEnableServicesResponse, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceBatchEnableServicesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchEnableServicesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchGetServices</summary>
        public void BatchGetServicesRequestObject()
        {
            // Snippet: BatchGetServices(BatchGetServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            BatchGetServicesRequest request = new BatchGetServicesRequest
            {
                Parent = "",
                Names = { "", },
            };
            // Make the request
            BatchGetServicesResponse response = serviceUsageClient.BatchGetServices(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetServicesAsync</summary>
        public async Task BatchGetServicesRequestObjectAsync()
        {
            // Snippet: BatchGetServicesAsync(BatchGetServicesRequest, CallSettings)
            // Additional: BatchGetServicesAsync(BatchGetServicesRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetServicesRequest request = new BatchGetServicesRequest
            {
                Parent = "",
                Names = { "", },
            };
            // Make the request
            BatchGetServicesResponse response = await serviceUsageClient.BatchGetServicesAsync(request);
            // End snippet
        }
    }
}
