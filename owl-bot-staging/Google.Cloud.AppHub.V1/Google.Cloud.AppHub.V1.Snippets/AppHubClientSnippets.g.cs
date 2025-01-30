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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AppHub.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppHubClientSnippets
    {
        /// <summary>Snippet for LookupServiceProjectAttachment</summary>
        public void LookupServiceProjectAttachmentRequestObject()
        {
            // Snippet: LookupServiceProjectAttachment(LookupServiceProjectAttachmentRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LookupServiceProjectAttachmentRequest request = new LookupServiceProjectAttachmentRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            LookupServiceProjectAttachmentResponse response = appHubClient.LookupServiceProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for LookupServiceProjectAttachmentAsync</summary>
        public async Task LookupServiceProjectAttachmentRequestObjectAsync()
        {
            // Snippet: LookupServiceProjectAttachmentAsync(LookupServiceProjectAttachmentRequest, CallSettings)
            // Additional: LookupServiceProjectAttachmentAsync(LookupServiceProjectAttachmentRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LookupServiceProjectAttachmentRequest request = new LookupServiceProjectAttachmentRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            LookupServiceProjectAttachmentResponse response = await appHubClient.LookupServiceProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupServiceProjectAttachment</summary>
        public void LookupServiceProjectAttachment()
        {
            // Snippet: LookupServiceProjectAttachment(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            LookupServiceProjectAttachmentResponse response = appHubClient.LookupServiceProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for LookupServiceProjectAttachmentAsync</summary>
        public async Task LookupServiceProjectAttachmentAsync()
        {
            // Snippet: LookupServiceProjectAttachmentAsync(string, CallSettings)
            // Additional: LookupServiceProjectAttachmentAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            LookupServiceProjectAttachmentResponse response = await appHubClient.LookupServiceProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupServiceProjectAttachment</summary>
        public void LookupServiceProjectAttachmentResourceNames()
        {
            // Snippet: LookupServiceProjectAttachment(LocationName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            LookupServiceProjectAttachmentResponse response = appHubClient.LookupServiceProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for LookupServiceProjectAttachmentAsync</summary>
        public async Task LookupServiceProjectAttachmentResourceNamesAsync()
        {
            // Snippet: LookupServiceProjectAttachmentAsync(LocationName, CallSettings)
            // Additional: LookupServiceProjectAttachmentAsync(LocationName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            LookupServiceProjectAttachmentResponse response = await appHubClient.LookupServiceProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServiceProjectAttachments</summary>
        public void ListServiceProjectAttachmentsRequestObject()
        {
            // Snippet: ListServiceProjectAttachments(ListServiceProjectAttachmentsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ListServiceProjectAttachmentsRequest request = new ListServiceProjectAttachmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> response = appHubClient.ListServiceProjectAttachments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceProjectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceProjectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceProjectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceProjectAttachmentsAsync</summary>
        public async Task ListServiceProjectAttachmentsRequestObjectAsync()
        {
            // Snippet: ListServiceProjectAttachmentsAsync(ListServiceProjectAttachmentsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceProjectAttachmentsRequest request = new ListServiceProjectAttachmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> response = appHubClient.ListServiceProjectAttachmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceProjectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceProjectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceProjectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceProjectAttachments</summary>
        public void ListServiceProjectAttachments()
        {
            // Snippet: ListServiceProjectAttachments(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> response = appHubClient.ListServiceProjectAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceProjectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceProjectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceProjectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceProjectAttachmentsAsync</summary>
        public async Task ListServiceProjectAttachmentsAsync()
        {
            // Snippet: ListServiceProjectAttachmentsAsync(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> response = appHubClient.ListServiceProjectAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceProjectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceProjectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceProjectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceProjectAttachments</summary>
        public void ListServiceProjectAttachmentsResourceNames()
        {
            // Snippet: ListServiceProjectAttachments(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> response = appHubClient.ListServiceProjectAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceProjectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceProjectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceProjectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceProjectAttachmentsAsync</summary>
        public async Task ListServiceProjectAttachmentsResourceNamesAsync()
        {
            // Snippet: ListServiceProjectAttachmentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> response = appHubClient.ListServiceProjectAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceProjectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceProjectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceProjectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceProjectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceProjectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateServiceProjectAttachment</summary>
        public void CreateServiceProjectAttachmentRequestObject()
        {
            // Snippet: CreateServiceProjectAttachment(CreateServiceProjectAttachmentRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            CreateServiceProjectAttachmentRequest request = new CreateServiceProjectAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceProjectAttachmentId = "",
                ServiceProjectAttachment = new ServiceProjectAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceProjectAttachment, OperationMetadata> response = appHubClient.CreateServiceProjectAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceProjectAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceProjectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceProjectAttachment, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateServiceProjectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceProjectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceProjectAttachmentAsync</summary>
        public async Task CreateServiceProjectAttachmentRequestObjectAsync()
        {
            // Snippet: CreateServiceProjectAttachmentAsync(CreateServiceProjectAttachmentRequest, CallSettings)
            // Additional: CreateServiceProjectAttachmentAsync(CreateServiceProjectAttachmentRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceProjectAttachmentRequest request = new CreateServiceProjectAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceProjectAttachmentId = "",
                ServiceProjectAttachment = new ServiceProjectAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceProjectAttachment, OperationMetadata> response = await appHubClient.CreateServiceProjectAttachmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceProjectAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceProjectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceProjectAttachment, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateServiceProjectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceProjectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceProjectAttachment</summary>
        public void CreateServiceProjectAttachment()
        {
            // Snippet: CreateServiceProjectAttachment(string, ServiceProjectAttachment, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceProjectAttachment serviceProjectAttachment = new ServiceProjectAttachment();
            string serviceProjectAttachmentId = "";
            // Make the request
            Operation<ServiceProjectAttachment, OperationMetadata> response = appHubClient.CreateServiceProjectAttachment(parent, serviceProjectAttachment, serviceProjectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceProjectAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceProjectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceProjectAttachment, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateServiceProjectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceProjectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceProjectAttachmentAsync</summary>
        public async Task CreateServiceProjectAttachmentAsync()
        {
            // Snippet: CreateServiceProjectAttachmentAsync(string, ServiceProjectAttachment, string, CallSettings)
            // Additional: CreateServiceProjectAttachmentAsync(string, ServiceProjectAttachment, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceProjectAttachment serviceProjectAttachment = new ServiceProjectAttachment();
            string serviceProjectAttachmentId = "";
            // Make the request
            Operation<ServiceProjectAttachment, OperationMetadata> response = await appHubClient.CreateServiceProjectAttachmentAsync(parent, serviceProjectAttachment, serviceProjectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceProjectAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceProjectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceProjectAttachment, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateServiceProjectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceProjectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceProjectAttachment</summary>
        public void CreateServiceProjectAttachmentResourceNames()
        {
            // Snippet: CreateServiceProjectAttachment(LocationName, ServiceProjectAttachment, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceProjectAttachment serviceProjectAttachment = new ServiceProjectAttachment();
            string serviceProjectAttachmentId = "";
            // Make the request
            Operation<ServiceProjectAttachment, OperationMetadata> response = appHubClient.CreateServiceProjectAttachment(parent, serviceProjectAttachment, serviceProjectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceProjectAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceProjectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceProjectAttachment, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateServiceProjectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceProjectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceProjectAttachmentAsync</summary>
        public async Task CreateServiceProjectAttachmentResourceNamesAsync()
        {
            // Snippet: CreateServiceProjectAttachmentAsync(LocationName, ServiceProjectAttachment, string, CallSettings)
            // Additional: CreateServiceProjectAttachmentAsync(LocationName, ServiceProjectAttachment, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceProjectAttachment serviceProjectAttachment = new ServiceProjectAttachment();
            string serviceProjectAttachmentId = "";
            // Make the request
            Operation<ServiceProjectAttachment, OperationMetadata> response = await appHubClient.CreateServiceProjectAttachmentAsync(parent, serviceProjectAttachment, serviceProjectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceProjectAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceProjectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceProjectAttachment, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateServiceProjectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceProjectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetServiceProjectAttachment</summary>
        public void GetServiceProjectAttachmentRequestObject()
        {
            // Snippet: GetServiceProjectAttachment(GetServiceProjectAttachmentRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            GetServiceProjectAttachmentRequest request = new GetServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]"),
            };
            // Make the request
            ServiceProjectAttachment response = appHubClient.GetServiceProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceProjectAttachmentAsync</summary>
        public async Task GetServiceProjectAttachmentRequestObjectAsync()
        {
            // Snippet: GetServiceProjectAttachmentAsync(GetServiceProjectAttachmentRequest, CallSettings)
            // Additional: GetServiceProjectAttachmentAsync(GetServiceProjectAttachmentRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceProjectAttachmentRequest request = new GetServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]"),
            };
            // Make the request
            ServiceProjectAttachment response = await appHubClient.GetServiceProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceProjectAttachment</summary>
        public void GetServiceProjectAttachment()
        {
            // Snippet: GetServiceProjectAttachment(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceProjectAttachments/[SERVICE_PROJECT_ATTACHMENT]";
            // Make the request
            ServiceProjectAttachment response = appHubClient.GetServiceProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceProjectAttachmentAsync</summary>
        public async Task GetServiceProjectAttachmentAsync()
        {
            // Snippet: GetServiceProjectAttachmentAsync(string, CallSettings)
            // Additional: GetServiceProjectAttachmentAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceProjectAttachments/[SERVICE_PROJECT_ATTACHMENT]";
            // Make the request
            ServiceProjectAttachment response = await appHubClient.GetServiceProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceProjectAttachment</summary>
        public void GetServiceProjectAttachmentResourceNames()
        {
            // Snippet: GetServiceProjectAttachment(ServiceProjectAttachmentName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ServiceProjectAttachmentName name = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]");
            // Make the request
            ServiceProjectAttachment response = appHubClient.GetServiceProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceProjectAttachmentAsync</summary>
        public async Task GetServiceProjectAttachmentResourceNamesAsync()
        {
            // Snippet: GetServiceProjectAttachmentAsync(ServiceProjectAttachmentName, CallSettings)
            // Additional: GetServiceProjectAttachmentAsync(ServiceProjectAttachmentName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ServiceProjectAttachmentName name = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]");
            // Make the request
            ServiceProjectAttachment response = await appHubClient.GetServiceProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceProjectAttachment</summary>
        public void DeleteServiceProjectAttachmentRequestObject()
        {
            // Snippet: DeleteServiceProjectAttachment(DeleteServiceProjectAttachmentRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DeleteServiceProjectAttachmentRequest request = new DeleteServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteServiceProjectAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteServiceProjectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceProjectAttachmentAsync</summary>
        public async Task DeleteServiceProjectAttachmentRequestObjectAsync()
        {
            // Snippet: DeleteServiceProjectAttachmentAsync(DeleteServiceProjectAttachmentRequest, CallSettings)
            // Additional: DeleteServiceProjectAttachmentAsync(DeleteServiceProjectAttachmentRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceProjectAttachmentRequest request = new DeleteServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteServiceProjectAttachmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteServiceProjectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceProjectAttachment</summary>
        public void DeleteServiceProjectAttachment()
        {
            // Snippet: DeleteServiceProjectAttachment(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceProjectAttachments/[SERVICE_PROJECT_ATTACHMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteServiceProjectAttachment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteServiceProjectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceProjectAttachmentAsync</summary>
        public async Task DeleteServiceProjectAttachmentAsync()
        {
            // Snippet: DeleteServiceProjectAttachmentAsync(string, CallSettings)
            // Additional: DeleteServiceProjectAttachmentAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceProjectAttachments/[SERVICE_PROJECT_ATTACHMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteServiceProjectAttachmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteServiceProjectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceProjectAttachment</summary>
        public void DeleteServiceProjectAttachmentResourceNames()
        {
            // Snippet: DeleteServiceProjectAttachment(ServiceProjectAttachmentName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ServiceProjectAttachmentName name = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteServiceProjectAttachment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteServiceProjectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceProjectAttachmentAsync</summary>
        public async Task DeleteServiceProjectAttachmentResourceNamesAsync()
        {
            // Snippet: DeleteServiceProjectAttachmentAsync(ServiceProjectAttachmentName, CallSettings)
            // Additional: DeleteServiceProjectAttachmentAsync(ServiceProjectAttachmentName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ServiceProjectAttachmentName name = ServiceProjectAttachmentName.FromProjectLocationServiceProjectAttachment("[PROJECT]", "[LOCATION]", "[SERVICE_PROJECT_ATTACHMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteServiceProjectAttachmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteServiceProjectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachServiceProjectAttachment</summary>
        public void DetachServiceProjectAttachmentRequestObject()
        {
            // Snippet: DetachServiceProjectAttachment(DetachServiceProjectAttachmentRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DetachServiceProjectAttachmentRequest request = new DetachServiceProjectAttachmentRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            DetachServiceProjectAttachmentResponse response = appHubClient.DetachServiceProjectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for DetachServiceProjectAttachmentAsync</summary>
        public async Task DetachServiceProjectAttachmentRequestObjectAsync()
        {
            // Snippet: DetachServiceProjectAttachmentAsync(DetachServiceProjectAttachmentRequest, CallSettings)
            // Additional: DetachServiceProjectAttachmentAsync(DetachServiceProjectAttachmentRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DetachServiceProjectAttachmentRequest request = new DetachServiceProjectAttachmentRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            DetachServiceProjectAttachmentResponse response = await appHubClient.DetachServiceProjectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DetachServiceProjectAttachment</summary>
        public void DetachServiceProjectAttachment()
        {
            // Snippet: DetachServiceProjectAttachment(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            DetachServiceProjectAttachmentResponse response = appHubClient.DetachServiceProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for DetachServiceProjectAttachmentAsync</summary>
        public async Task DetachServiceProjectAttachmentAsync()
        {
            // Snippet: DetachServiceProjectAttachmentAsync(string, CallSettings)
            // Additional: DetachServiceProjectAttachmentAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            DetachServiceProjectAttachmentResponse response = await appHubClient.DetachServiceProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DetachServiceProjectAttachment</summary>
        public void DetachServiceProjectAttachmentResourceNames()
        {
            // Snippet: DetachServiceProjectAttachment(LocationName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            DetachServiceProjectAttachmentResponse response = appHubClient.DetachServiceProjectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for DetachServiceProjectAttachmentAsync</summary>
        public async Task DetachServiceProjectAttachmentResourceNamesAsync()
        {
            // Snippet: DetachServiceProjectAttachmentAsync(LocationName, CallSettings)
            // Additional: DetachServiceProjectAttachmentAsync(LocationName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            DetachServiceProjectAttachmentResponse response = await appHubClient.DetachServiceProjectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredServices</summary>
        public void ListDiscoveredServicesRequestObject()
        {
            // Snippet: ListDiscoveredServices(ListDiscoveredServicesRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ListDiscoveredServicesRequest request = new ListDiscoveredServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> response = appHubClient.ListDiscoveredServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredServicesAsync</summary>
        public async Task ListDiscoveredServicesRequestObjectAsync()
        {
            // Snippet: ListDiscoveredServicesAsync(ListDiscoveredServicesRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ListDiscoveredServicesRequest request = new ListDiscoveredServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> response = appHubClient.ListDiscoveredServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredServices</summary>
        public void ListDiscoveredServices()
        {
            // Snippet: ListDiscoveredServices(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> response = appHubClient.ListDiscoveredServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredServicesAsync</summary>
        public async Task ListDiscoveredServicesAsync()
        {
            // Snippet: ListDiscoveredServicesAsync(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> response = appHubClient.ListDiscoveredServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredServices</summary>
        public void ListDiscoveredServicesResourceNames()
        {
            // Snippet: ListDiscoveredServices(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> response = appHubClient.ListDiscoveredServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredServicesAsync</summary>
        public async Task ListDiscoveredServicesResourceNamesAsync()
        {
            // Snippet: ListDiscoveredServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> response = appHubClient.ListDiscoveredServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredService</summary>
        public void GetDiscoveredServiceRequestObject()
        {
            // Snippet: GetDiscoveredService(GetDiscoveredServiceRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            GetDiscoveredServiceRequest request = new GetDiscoveredServiceRequest
            {
                DiscoveredServiceName = DiscoveredServiceName.FromProjectLocationDiscoveredService("[PROJECT]", "[LOCATION]", "[DISCOVERED_SERVICE]"),
            };
            // Make the request
            DiscoveredService response = appHubClient.GetDiscoveredService(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredServiceAsync</summary>
        public async Task GetDiscoveredServiceRequestObjectAsync()
        {
            // Snippet: GetDiscoveredServiceAsync(GetDiscoveredServiceRequest, CallSettings)
            // Additional: GetDiscoveredServiceAsync(GetDiscoveredServiceRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            GetDiscoveredServiceRequest request = new GetDiscoveredServiceRequest
            {
                DiscoveredServiceName = DiscoveredServiceName.FromProjectLocationDiscoveredService("[PROJECT]", "[LOCATION]", "[DISCOVERED_SERVICE]"),
            };
            // Make the request
            DiscoveredService response = await appHubClient.GetDiscoveredServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredService</summary>
        public void GetDiscoveredService()
        {
            // Snippet: GetDiscoveredService(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredServices/[DISCOVERED_SERVICE]";
            // Make the request
            DiscoveredService response = appHubClient.GetDiscoveredService(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredServiceAsync</summary>
        public async Task GetDiscoveredServiceAsync()
        {
            // Snippet: GetDiscoveredServiceAsync(string, CallSettings)
            // Additional: GetDiscoveredServiceAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredServices/[DISCOVERED_SERVICE]";
            // Make the request
            DiscoveredService response = await appHubClient.GetDiscoveredServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredService</summary>
        public void GetDiscoveredServiceResourceNames()
        {
            // Snippet: GetDiscoveredService(DiscoveredServiceName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DiscoveredServiceName name = DiscoveredServiceName.FromProjectLocationDiscoveredService("[PROJECT]", "[LOCATION]", "[DISCOVERED_SERVICE]");
            // Make the request
            DiscoveredService response = appHubClient.GetDiscoveredService(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredServiceAsync</summary>
        public async Task GetDiscoveredServiceResourceNamesAsync()
        {
            // Snippet: GetDiscoveredServiceAsync(DiscoveredServiceName, CallSettings)
            // Additional: GetDiscoveredServiceAsync(DiscoveredServiceName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveredServiceName name = DiscoveredServiceName.FromProjectLocationDiscoveredService("[PROJECT]", "[LOCATION]", "[DISCOVERED_SERVICE]");
            // Make the request
            DiscoveredService response = await appHubClient.GetDiscoveredServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredService</summary>
        public void LookupDiscoveredServiceRequestObject()
        {
            // Snippet: LookupDiscoveredService(LookupDiscoveredServiceRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LookupDiscoveredServiceRequest request = new LookupDiscoveredServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Uri = "",
            };
            // Make the request
            LookupDiscoveredServiceResponse response = appHubClient.LookupDiscoveredService(request);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredServiceAsync</summary>
        public async Task LookupDiscoveredServiceRequestObjectAsync()
        {
            // Snippet: LookupDiscoveredServiceAsync(LookupDiscoveredServiceRequest, CallSettings)
            // Additional: LookupDiscoveredServiceAsync(LookupDiscoveredServiceRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LookupDiscoveredServiceRequest request = new LookupDiscoveredServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Uri = "",
            };
            // Make the request
            LookupDiscoveredServiceResponse response = await appHubClient.LookupDiscoveredServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredService</summary>
        public void LookupDiscoveredService()
        {
            // Snippet: LookupDiscoveredService(string, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string uri = "";
            // Make the request
            LookupDiscoveredServiceResponse response = appHubClient.LookupDiscoveredService(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredServiceAsync</summary>
        public async Task LookupDiscoveredServiceAsync()
        {
            // Snippet: LookupDiscoveredServiceAsync(string, string, CallSettings)
            // Additional: LookupDiscoveredServiceAsync(string, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string uri = "";
            // Make the request
            LookupDiscoveredServiceResponse response = await appHubClient.LookupDiscoveredServiceAsync(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredService</summary>
        public void LookupDiscoveredServiceResourceNames()
        {
            // Snippet: LookupDiscoveredService(LocationName, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string uri = "";
            // Make the request
            LookupDiscoveredServiceResponse response = appHubClient.LookupDiscoveredService(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredServiceAsync</summary>
        public async Task LookupDiscoveredServiceResourceNamesAsync()
        {
            // Snippet: LookupDiscoveredServiceAsync(LocationName, string, CallSettings)
            // Additional: LookupDiscoveredServiceAsync(LocationName, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string uri = "";
            // Make the request
            LookupDiscoveredServiceResponse response = await appHubClient.LookupDiscoveredServiceAsync(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = appHubClient.ListServices(request);

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
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = appHubClient.ListServicesAsync(request);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = appHubClient.ListServices(parent);

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
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = appHubClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames()
        {
            // Snippet: ListServices(ApplicationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = appHubClient.ListServices(parent);

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
        public async Task ListServicesResourceNamesAsync()
        {
            // Snippet: ListServicesAsync(ApplicationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = appHubClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceRequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ServiceId = "",
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = appHubClient.CreateService(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                ServiceId = "",
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = await appHubClient.CreateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(string, Service, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = appHubClient.CreateService(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(string, Service, string, CallSettings)
            // Additional: CreateServiceAsync(string, Service, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = await appHubClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames()
        {
            // Snippet: CreateService(ApplicationName, Service, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = appHubClient.CreateService(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNamesAsync()
        {
            // Snippet: CreateServiceAsync(ApplicationName, Service, string, CallSettings)
            // Additional: CreateServiceAsync(ApplicationName, Service, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = await appHubClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]"),
            };
            // Make the request
            Service response = appHubClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]"),
            };
            // Make the request
            Service response = await appHubClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/services/[SERVICE]";
            // Make the request
            Service response = appHubClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/services/[SERVICE]";
            // Make the request
            Service response = await appHubClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames()
        {
            // Snippet: GetService(ServiceName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]");
            // Make the request
            Service response = appHubClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNamesAsync()
        {
            // Snippet: GetServiceAsync(ServiceName, CallSettings)
            // Additional: GetServiceAsync(ServiceName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]");
            // Make the request
            Service response = await appHubClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateServiceRequestObject()
        {
            // Snippet: UpdateService(UpdateServiceRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                UpdateMask = new FieldMask(),
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = appHubClient.UpdateService(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = appHubClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceRequestObjectAsync()
        {
            // Snippet: UpdateServiceAsync(UpdateServiceRequest, CallSettings)
            // Additional: UpdateServiceAsync(UpdateServiceRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                UpdateMask = new FieldMask(),
                Service = new Service(),
                RequestId = "",
            };
            // Make the request
            Operation<Service, OperationMetadata> response = await appHubClient.UpdateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await appHubClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService()
        {
            // Snippet: UpdateService(Service, FieldMask, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            Service service = new Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Service, OperationMetadata> response = appHubClient.UpdateService(service, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = appHubClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceAsync()
        {
            // Snippet: UpdateServiceAsync(Service, FieldMask, CallSettings)
            // Additional: UpdateServiceAsync(Service, FieldMask, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            Service service = new Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Service, OperationMetadata> response = await appHubClient.UpdateServiceAsync(service, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await appHubClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceRequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteService(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceRequestObjectAsync()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest, CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/services/[SERVICE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteService(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(string, CallSettings)
            // Additional: DeleteServiceAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/services/[SERVICE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceResourceNames()
        {
            // Snippet: DeleteService(ServiceName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteService(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceResourceNamesAsync()
        {
            // Snippet: DeleteServiceAsync(ServiceName, CallSettings)
            // Additional: DeleteServiceAsync(ServiceName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationApplicationService("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[SERVICE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredWorkloads</summary>
        public void ListDiscoveredWorkloadsRequestObject()
        {
            // Snippet: ListDiscoveredWorkloads(ListDiscoveredWorkloadsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ListDiscoveredWorkloadsRequest request = new ListDiscoveredWorkloadsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> response = appHubClient.ListDiscoveredWorkloads(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredWorkload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredWorkload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredWorkloadsAsync</summary>
        public async Task ListDiscoveredWorkloadsRequestObjectAsync()
        {
            // Snippet: ListDiscoveredWorkloadsAsync(ListDiscoveredWorkloadsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ListDiscoveredWorkloadsRequest request = new ListDiscoveredWorkloadsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> response = appHubClient.ListDiscoveredWorkloadsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredWorkload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredWorkload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredWorkloads</summary>
        public void ListDiscoveredWorkloads()
        {
            // Snippet: ListDiscoveredWorkloads(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> response = appHubClient.ListDiscoveredWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredWorkload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredWorkload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredWorkloadsAsync</summary>
        public async Task ListDiscoveredWorkloadsAsync()
        {
            // Snippet: ListDiscoveredWorkloadsAsync(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> response = appHubClient.ListDiscoveredWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredWorkload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredWorkload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredWorkloads</summary>
        public void ListDiscoveredWorkloadsResourceNames()
        {
            // Snippet: ListDiscoveredWorkloads(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> response = appHubClient.ListDiscoveredWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredWorkload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredWorkload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredWorkloadsAsync</summary>
        public async Task ListDiscoveredWorkloadsResourceNamesAsync()
        {
            // Snippet: ListDiscoveredWorkloadsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> response = appHubClient.ListDiscoveredWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredWorkload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredWorkload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredWorkload</summary>
        public void GetDiscoveredWorkloadRequestObject()
        {
            // Snippet: GetDiscoveredWorkload(GetDiscoveredWorkloadRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            GetDiscoveredWorkloadRequest request = new GetDiscoveredWorkloadRequest
            {
                DiscoveredWorkloadName = DiscoveredWorkloadName.FromProjectLocationDiscoveredWorkload("[PROJECT]", "[LOCATION]", "[DISCOVERED_WORKLOAD]"),
            };
            // Make the request
            DiscoveredWorkload response = appHubClient.GetDiscoveredWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredWorkloadAsync</summary>
        public async Task GetDiscoveredWorkloadRequestObjectAsync()
        {
            // Snippet: GetDiscoveredWorkloadAsync(GetDiscoveredWorkloadRequest, CallSettings)
            // Additional: GetDiscoveredWorkloadAsync(GetDiscoveredWorkloadRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            GetDiscoveredWorkloadRequest request = new GetDiscoveredWorkloadRequest
            {
                DiscoveredWorkloadName = DiscoveredWorkloadName.FromProjectLocationDiscoveredWorkload("[PROJECT]", "[LOCATION]", "[DISCOVERED_WORKLOAD]"),
            };
            // Make the request
            DiscoveredWorkload response = await appHubClient.GetDiscoveredWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredWorkload</summary>
        public void GetDiscoveredWorkload()
        {
            // Snippet: GetDiscoveredWorkload(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredWorkloads/[DISCOVERED_WORKLOAD]";
            // Make the request
            DiscoveredWorkload response = appHubClient.GetDiscoveredWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredWorkloadAsync</summary>
        public async Task GetDiscoveredWorkloadAsync()
        {
            // Snippet: GetDiscoveredWorkloadAsync(string, CallSettings)
            // Additional: GetDiscoveredWorkloadAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredWorkloads/[DISCOVERED_WORKLOAD]";
            // Make the request
            DiscoveredWorkload response = await appHubClient.GetDiscoveredWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredWorkload</summary>
        public void GetDiscoveredWorkloadResourceNames()
        {
            // Snippet: GetDiscoveredWorkload(DiscoveredWorkloadName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DiscoveredWorkloadName name = DiscoveredWorkloadName.FromProjectLocationDiscoveredWorkload("[PROJECT]", "[LOCATION]", "[DISCOVERED_WORKLOAD]");
            // Make the request
            DiscoveredWorkload response = appHubClient.GetDiscoveredWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredWorkloadAsync</summary>
        public async Task GetDiscoveredWorkloadResourceNamesAsync()
        {
            // Snippet: GetDiscoveredWorkloadAsync(DiscoveredWorkloadName, CallSettings)
            // Additional: GetDiscoveredWorkloadAsync(DiscoveredWorkloadName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveredWorkloadName name = DiscoveredWorkloadName.FromProjectLocationDiscoveredWorkload("[PROJECT]", "[LOCATION]", "[DISCOVERED_WORKLOAD]");
            // Make the request
            DiscoveredWorkload response = await appHubClient.GetDiscoveredWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredWorkload</summary>
        public void LookupDiscoveredWorkloadRequestObject()
        {
            // Snippet: LookupDiscoveredWorkload(LookupDiscoveredWorkloadRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LookupDiscoveredWorkloadRequest request = new LookupDiscoveredWorkloadRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Uri = "",
            };
            // Make the request
            LookupDiscoveredWorkloadResponse response = appHubClient.LookupDiscoveredWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredWorkloadAsync</summary>
        public async Task LookupDiscoveredWorkloadRequestObjectAsync()
        {
            // Snippet: LookupDiscoveredWorkloadAsync(LookupDiscoveredWorkloadRequest, CallSettings)
            // Additional: LookupDiscoveredWorkloadAsync(LookupDiscoveredWorkloadRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LookupDiscoveredWorkloadRequest request = new LookupDiscoveredWorkloadRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Uri = "",
            };
            // Make the request
            LookupDiscoveredWorkloadResponse response = await appHubClient.LookupDiscoveredWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredWorkload</summary>
        public void LookupDiscoveredWorkload()
        {
            // Snippet: LookupDiscoveredWorkload(string, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string uri = "";
            // Make the request
            LookupDiscoveredWorkloadResponse response = appHubClient.LookupDiscoveredWorkload(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredWorkloadAsync</summary>
        public async Task LookupDiscoveredWorkloadAsync()
        {
            // Snippet: LookupDiscoveredWorkloadAsync(string, string, CallSettings)
            // Additional: LookupDiscoveredWorkloadAsync(string, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string uri = "";
            // Make the request
            LookupDiscoveredWorkloadResponse response = await appHubClient.LookupDiscoveredWorkloadAsync(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredWorkload</summary>
        public void LookupDiscoveredWorkloadResourceNames()
        {
            // Snippet: LookupDiscoveredWorkload(LocationName, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string uri = "";
            // Make the request
            LookupDiscoveredWorkloadResponse response = appHubClient.LookupDiscoveredWorkload(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for LookupDiscoveredWorkloadAsync</summary>
        public async Task LookupDiscoveredWorkloadResourceNamesAsync()
        {
            // Snippet: LookupDiscoveredWorkloadAsync(LocationName, string, CallSettings)
            // Additional: LookupDiscoveredWorkloadAsync(LocationName, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string uri = "";
            // Make the request
            LookupDiscoveredWorkloadResponse response = await appHubClient.LookupDiscoveredWorkloadAsync(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsRequestObject()
        {
            // Snippet: ListWorkloads(ListWorkloadsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = appHubClient.ListWorkloads(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsRequestObjectAsync()
        {
            // Snippet: ListWorkloadsAsync(ListWorkloadsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = appHubClient.ListWorkloadsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloads()
        {
            // Snippet: ListWorkloads(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = appHubClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsAsync()
        {
            // Snippet: ListWorkloadsAsync(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = appHubClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsResourceNames()
        {
            // Snippet: ListWorkloads(ApplicationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = appHubClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsResourceNamesAsync()
        {
            // Snippet: ListWorkloadsAsync(ApplicationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = appHubClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateWorkload</summary>
        public void CreateWorkloadRequestObject()
        {
            // Snippet: CreateWorkload(CreateWorkloadRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            CreateWorkloadRequest request = new CreateWorkloadRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                WorkloadId = "",
                Workload = new Workload(),
                RequestId = "",
            };
            // Make the request
            Operation<Workload, OperationMetadata> response = appHubClient.CreateWorkload(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadAsync</summary>
        public async Task CreateWorkloadRequestObjectAsync()
        {
            // Snippet: CreateWorkloadAsync(CreateWorkloadRequest, CallSettings)
            // Additional: CreateWorkloadAsync(CreateWorkloadRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkloadRequest request = new CreateWorkloadRequest
            {
                ParentAsApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                WorkloadId = "",
                Workload = new Workload(),
                RequestId = "",
            };
            // Make the request
            Operation<Workload, OperationMetadata> response = await appHubClient.CreateWorkloadAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkload</summary>
        public void CreateWorkload()
        {
            // Snippet: CreateWorkload(string, Workload, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            Workload workload = new Workload();
            string workloadId = "";
            // Make the request
            Operation<Workload, OperationMetadata> response = appHubClient.CreateWorkload(parent, workload, workloadId);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadAsync</summary>
        public async Task CreateWorkloadAsync()
        {
            // Snippet: CreateWorkloadAsync(string, Workload, string, CallSettings)
            // Additional: CreateWorkloadAsync(string, Workload, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            Workload workload = new Workload();
            string workloadId = "";
            // Make the request
            Operation<Workload, OperationMetadata> response = await appHubClient.CreateWorkloadAsync(parent, workload, workloadId);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkload</summary>
        public void CreateWorkloadResourceNames()
        {
            // Snippet: CreateWorkload(ApplicationName, Workload, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            Workload workload = new Workload();
            string workloadId = "";
            // Make the request
            Operation<Workload, OperationMetadata> response = appHubClient.CreateWorkload(parent, workload, workloadId);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadAsync</summary>
        public async Task CreateWorkloadResourceNamesAsync()
        {
            // Snippet: CreateWorkloadAsync(ApplicationName, Workload, string, CallSettings)
            // Additional: CreateWorkloadAsync(ApplicationName, Workload, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName parent = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            Workload workload = new Workload();
            string workloadId = "";
            // Make the request
            Operation<Workload, OperationMetadata> response = await appHubClient.CreateWorkloadAsync(parent, workload, workloadId);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkloadRequestObject()
        {
            // Snippet: GetWorkload(GetWorkloadRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]"),
            };
            // Make the request
            Workload response = appHubClient.GetWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadRequestObjectAsync()
        {
            // Snippet: GetWorkloadAsync(GetWorkloadRequest, CallSettings)
            // Additional: GetWorkloadAsync(GetWorkloadRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]"),
            };
            // Make the request
            Workload response = await appHubClient.GetWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkload()
        {
            // Snippet: GetWorkload(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/workloads/[WORKLOAD]";
            // Make the request
            Workload response = appHubClient.GetWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadAsync()
        {
            // Snippet: GetWorkloadAsync(string, CallSettings)
            // Additional: GetWorkloadAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/workloads/[WORKLOAD]";
            // Make the request
            Workload response = await appHubClient.GetWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkloadResourceNames()
        {
            // Snippet: GetWorkload(WorkloadName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]");
            // Make the request
            Workload response = appHubClient.GetWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadResourceNamesAsync()
        {
            // Snippet: GetWorkloadAsync(WorkloadName, CallSettings)
            // Additional: GetWorkloadAsync(WorkloadName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]");
            // Make the request
            Workload response = await appHubClient.GetWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkload</summary>
        public void UpdateWorkloadRequestObject()
        {
            // Snippet: UpdateWorkload(UpdateWorkloadRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                UpdateMask = new FieldMask(),
                Workload = new Workload(),
                RequestId = "",
            };
            // Make the request
            Operation<Workload, OperationMetadata> response = appHubClient.UpdateWorkload(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = appHubClient.PollOnceUpdateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadAsync</summary>
        public async Task UpdateWorkloadRequestObjectAsync()
        {
            // Snippet: UpdateWorkloadAsync(UpdateWorkloadRequest, CallSettings)
            // Additional: UpdateWorkloadAsync(UpdateWorkloadRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                UpdateMask = new FieldMask(),
                Workload = new Workload(),
                RequestId = "",
            };
            // Make the request
            Operation<Workload, OperationMetadata> response = await appHubClient.UpdateWorkloadAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = await appHubClient.PollOnceUpdateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkload</summary>
        public void UpdateWorkload()
        {
            // Snippet: UpdateWorkload(Workload, FieldMask, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            Workload workload = new Workload();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Workload, OperationMetadata> response = appHubClient.UpdateWorkload(workload, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = appHubClient.PollOnceUpdateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadAsync</summary>
        public async Task UpdateWorkloadAsync()
        {
            // Snippet: UpdateWorkloadAsync(Workload, FieldMask, CallSettings)
            // Additional: UpdateWorkloadAsync(Workload, FieldMask, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            Workload workload = new Workload();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Workload, OperationMetadata> response = await appHubClient.UpdateWorkloadAsync(workload, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Workload, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, OperationMetadata> retrievedResponse = await appHubClient.PollOnceUpdateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkload</summary>
        public void DeleteWorkloadRequestObject()
        {
            // Snippet: DeleteWorkload(DeleteWorkloadRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteWorkload(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadAsync</summary>
        public async Task DeleteWorkloadRequestObjectAsync()
        {
            // Snippet: DeleteWorkloadAsync(DeleteWorkloadRequest, CallSettings)
            // Additional: DeleteWorkloadAsync(DeleteWorkloadRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteWorkloadAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkload</summary>
        public void DeleteWorkload()
        {
            // Snippet: DeleteWorkload(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/workloads/[WORKLOAD]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteWorkload(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadAsync</summary>
        public async Task DeleteWorkloadAsync()
        {
            // Snippet: DeleteWorkloadAsync(string, CallSettings)
            // Additional: DeleteWorkloadAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]/workloads/[WORKLOAD]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteWorkloadAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkload</summary>
        public void DeleteWorkloadResourceNames()
        {
            // Snippet: DeleteWorkload(WorkloadName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteWorkload(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadAsync</summary>
        public async Task DeleteWorkloadResourceNamesAsync()
        {
            // Snippet: DeleteWorkloadAsync(WorkloadName, CallSettings)
            // Additional: DeleteWorkloadAsync(WorkloadName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromProjectLocationApplicationWorkload("[PROJECT]", "[LOCATION]", "[APPLICATION]", "[WORKLOAD]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteWorkloadAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsRequestObject()
        {
            // Snippet: ListApplications(ListApplicationsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = appHubClient.ListApplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsRequestObjectAsync()
        {
            // Snippet: ListApplicationsAsync(ListApplicationsRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = appHubClient.ListApplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplications()
        {
            // Snippet: ListApplications(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = appHubClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsAsync()
        {
            // Snippet: ListApplicationsAsync(string, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = appHubClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsResourceNames()
        {
            // Snippet: ListApplications(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = appHubClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsResourceNamesAsync()
        {
            // Snippet: ListApplicationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = appHubClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationRequestObject()
        {
            // Snippet: CreateApplication(CreateApplicationRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApplicationId = "",
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = appHubClient.CreateApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationRequestObjectAsync()
        {
            // Snippet: CreateApplicationAsync(CreateApplicationRequest, CallSettings)
            // Additional: CreateApplicationAsync(CreateApplicationRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApplicationId = "",
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = await appHubClient.CreateApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplication()
        {
            // Snippet: CreateApplication(string, Application, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Operation<Application, OperationMetadata> response = appHubClient.CreateApplication(parent, application, applicationId);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationAsync()
        {
            // Snippet: CreateApplicationAsync(string, Application, string, CallSettings)
            // Additional: CreateApplicationAsync(string, Application, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Operation<Application, OperationMetadata> response = await appHubClient.CreateApplicationAsync(parent, application, applicationId);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationResourceNames()
        {
            // Snippet: CreateApplication(LocationName, Application, string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Operation<Application, OperationMetadata> response = appHubClient.CreateApplication(parent, application, applicationId);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appHubClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationResourceNamesAsync()
        {
            // Snippet: CreateApplicationAsync(LocationName, Application, string, CallSettings)
            // Additional: CreateApplicationAsync(LocationName, Application, string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Application application = new Application();
            string applicationId = "";
            // Make the request
            Operation<Application, OperationMetadata> response = await appHubClient.CreateApplicationAsync(parent, application, applicationId);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appHubClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationRequestObject()
        {
            // Snippet: GetApplication(GetApplicationRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
            };
            // Make the request
            Application response = appHubClient.GetApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationRequestObjectAsync()
        {
            // Snippet: GetApplicationAsync(GetApplicationRequest, CallSettings)
            // Additional: GetApplicationAsync(GetApplicationRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
            };
            // Make the request
            Application response = await appHubClient.GetApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplication()
        {
            // Snippet: GetApplication(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Application response = appHubClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationAsync()
        {
            // Snippet: GetApplicationAsync(string, CallSettings)
            // Additional: GetApplicationAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Application response = await appHubClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationResourceNames()
        {
            // Snippet: GetApplication(ApplicationName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Application response = appHubClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationResourceNamesAsync()
        {
            // Snippet: GetApplicationAsync(ApplicationName, CallSettings)
            // Additional: GetApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Application response = await appHubClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplicationRequestObject()
        {
            // Snippet: UpdateApplication(UpdateApplicationRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                UpdateMask = new FieldMask(),
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = appHubClient.UpdateApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appHubClient.PollOnceUpdateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationRequestObjectAsync()
        {
            // Snippet: UpdateApplicationAsync(UpdateApplicationRequest, CallSettings)
            // Additional: UpdateApplicationAsync(UpdateApplicationRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                UpdateMask = new FieldMask(),
                Application = new Application(),
                RequestId = "",
            };
            // Make the request
            Operation<Application, OperationMetadata> response = await appHubClient.UpdateApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appHubClient.PollOnceUpdateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplication()
        {
            // Snippet: UpdateApplication(Application, FieldMask, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Application, OperationMetadata> response = appHubClient.UpdateApplication(application, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = appHubClient.PollOnceUpdateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationAsync()
        {
            // Snippet: UpdateApplicationAsync(Application, FieldMask, CallSettings)
            // Additional: UpdateApplicationAsync(Application, FieldMask, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Application, OperationMetadata> response = await appHubClient.UpdateApplicationAsync(application, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadata> retrievedResponse = await appHubClient.PollOnceUpdateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationRequestObject()
        {
            // Snippet: DeleteApplication(DeleteApplicationRequest, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationRequestObjectAsync()
        {
            // Snippet: DeleteApplicationAsync(DeleteApplicationRequest, CallSettings)
            // Additional: DeleteApplicationAsync(DeleteApplicationRequest, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteApplicationRequest request = new DeleteApplicationRequest
            {
                ApplicationName = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplication()
        {
            // Snippet: DeleteApplication(string, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationAsync()
        {
            // Snippet: DeleteApplicationAsync(string, CallSettings)
            // Additional: DeleteApplicationAsync(string, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/applications/[APPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplication</summary>
        public void DeleteApplicationResourceNames()
        {
            // Snippet: DeleteApplication(ApplicationName, CallSettings)
            // Create client
            AppHubClient appHubClient = AppHubClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = appHubClient.DeleteApplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = appHubClient.PollOnceDeleteApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteApplicationAsync</summary>
        public async Task DeleteApplicationResourceNamesAsync()
        {
            // Snippet: DeleteApplicationAsync(ApplicationName, CallSettings)
            // Additional: DeleteApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            AppHubClient appHubClient = await AppHubClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromProjectLocationApplication("[PROJECT]", "[LOCATION]", "[APPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await appHubClient.DeleteApplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await appHubClient.PollOnceDeleteApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
