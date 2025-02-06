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
    using Google.Cloud.AppEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDomainMappingsClientSnippets
    {
        /// <summary>Snippet for ListDomainMappings</summary>
        public void ListDomainMappingsRequestObject()
        {
            // Snippet: ListDomainMappings(ListDomainMappingsRequest, CallSettings)
            // Create client
            DomainMappingsClient domainMappingsClient = DomainMappingsClient.Create();
            // Initialize request argument(s)
            ListDomainMappingsRequest request = new ListDomainMappingsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListDomainMappingsResponse, DomainMapping> response = domainMappingsClient.ListDomainMappings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DomainMapping item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainMappingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DomainMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DomainMapping> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DomainMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainMappingsAsync</summary>
        public async Task ListDomainMappingsRequestObjectAsync()
        {
            // Snippet: ListDomainMappingsAsync(ListDomainMappingsRequest, CallSettings)
            // Create client
            DomainMappingsClient domainMappingsClient = await DomainMappingsClient.CreateAsync();
            // Initialize request argument(s)
            ListDomainMappingsRequest request = new ListDomainMappingsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListDomainMappingsResponse, DomainMapping> response = domainMappingsClient.ListDomainMappingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DomainMapping item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDomainMappingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DomainMapping item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DomainMapping> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DomainMapping item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDomainMapping</summary>
        public void GetDomainMappingRequestObject()
        {
            // Snippet: GetDomainMapping(GetDomainMappingRequest, CallSettings)
            // Create client
            DomainMappingsClient domainMappingsClient = DomainMappingsClient.Create();
            // Initialize request argument(s)
            GetDomainMappingRequest request = new GetDomainMappingRequest { Name = "", };
            // Make the request
            DomainMapping response = domainMappingsClient.GetDomainMapping(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomainMappingAsync</summary>
        public async Task GetDomainMappingRequestObjectAsync()
        {
            // Snippet: GetDomainMappingAsync(GetDomainMappingRequest, CallSettings)
            // Additional: GetDomainMappingAsync(GetDomainMappingRequest, CancellationToken)
            // Create client
            DomainMappingsClient domainMappingsClient = await DomainMappingsClient.CreateAsync();
            // Initialize request argument(s)
            GetDomainMappingRequest request = new GetDomainMappingRequest { Name = "", };
            // Make the request
            DomainMapping response = await domainMappingsClient.GetDomainMappingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDomainMapping</summary>
        public void CreateDomainMappingRequestObject()
        {
            // Snippet: CreateDomainMapping(CreateDomainMappingRequest, CallSettings)
            // Create client
            DomainMappingsClient domainMappingsClient = DomainMappingsClient.Create();
            // Initialize request argument(s)
            CreateDomainMappingRequest request = new CreateDomainMappingRequest
            {
                Parent = "",
                DomainMapping = new DomainMapping(),
                OverrideStrategy = DomainOverrideStrategy.UnspecifiedDomainOverrideStrategy,
            };
            // Make the request
            Operation<DomainMapping, OperationMetadataV1> response = domainMappingsClient.CreateDomainMapping(request);

            // Poll until the returned long-running operation is complete
            Operation<DomainMapping, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DomainMapping result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DomainMapping, OperationMetadataV1> retrievedResponse = domainMappingsClient.PollOnceCreateDomainMapping(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DomainMapping retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDomainMappingAsync</summary>
        public async Task CreateDomainMappingRequestObjectAsync()
        {
            // Snippet: CreateDomainMappingAsync(CreateDomainMappingRequest, CallSettings)
            // Additional: CreateDomainMappingAsync(CreateDomainMappingRequest, CancellationToken)
            // Create client
            DomainMappingsClient domainMappingsClient = await DomainMappingsClient.CreateAsync();
            // Initialize request argument(s)
            CreateDomainMappingRequest request = new CreateDomainMappingRequest
            {
                Parent = "",
                DomainMapping = new DomainMapping(),
                OverrideStrategy = DomainOverrideStrategy.UnspecifiedDomainOverrideStrategy,
            };
            // Make the request
            Operation<DomainMapping, OperationMetadataV1> response = await domainMappingsClient.CreateDomainMappingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DomainMapping, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DomainMapping result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DomainMapping, OperationMetadataV1> retrievedResponse = await domainMappingsClient.PollOnceCreateDomainMappingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DomainMapping retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDomainMapping</summary>
        public void UpdateDomainMappingRequestObject()
        {
            // Snippet: UpdateDomainMapping(UpdateDomainMappingRequest, CallSettings)
            // Create client
            DomainMappingsClient domainMappingsClient = DomainMappingsClient.Create();
            // Initialize request argument(s)
            UpdateDomainMappingRequest request = new UpdateDomainMappingRequest
            {
                Name = "",
                DomainMapping = new DomainMapping(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<DomainMapping, OperationMetadataV1> response = domainMappingsClient.UpdateDomainMapping(request);

            // Poll until the returned long-running operation is complete
            Operation<DomainMapping, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DomainMapping result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DomainMapping, OperationMetadataV1> retrievedResponse = domainMappingsClient.PollOnceUpdateDomainMapping(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DomainMapping retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDomainMappingAsync</summary>
        public async Task UpdateDomainMappingRequestObjectAsync()
        {
            // Snippet: UpdateDomainMappingAsync(UpdateDomainMappingRequest, CallSettings)
            // Additional: UpdateDomainMappingAsync(UpdateDomainMappingRequest, CancellationToken)
            // Create client
            DomainMappingsClient domainMappingsClient = await DomainMappingsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDomainMappingRequest request = new UpdateDomainMappingRequest
            {
                Name = "",
                DomainMapping = new DomainMapping(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<DomainMapping, OperationMetadataV1> response = await domainMappingsClient.UpdateDomainMappingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DomainMapping, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DomainMapping result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DomainMapping, OperationMetadataV1> retrievedResponse = await domainMappingsClient.PollOnceUpdateDomainMappingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DomainMapping retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomainMapping</summary>
        public void DeleteDomainMappingRequestObject()
        {
            // Snippet: DeleteDomainMapping(DeleteDomainMappingRequest, CallSettings)
            // Create client
            DomainMappingsClient domainMappingsClient = DomainMappingsClient.Create();
            // Initialize request argument(s)
            DeleteDomainMappingRequest request = new DeleteDomainMappingRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadataV1> response = domainMappingsClient.DeleteDomainMapping(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = domainMappingsClient.PollOnceDeleteDomainMapping(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomainMappingAsync</summary>
        public async Task DeleteDomainMappingRequestObjectAsync()
        {
            // Snippet: DeleteDomainMappingAsync(DeleteDomainMappingRequest, CallSettings)
            // Additional: DeleteDomainMappingAsync(DeleteDomainMappingRequest, CancellationToken)
            // Create client
            DomainMappingsClient domainMappingsClient = await DomainMappingsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDomainMappingRequest request = new DeleteDomainMappingRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadataV1> response = await domainMappingsClient.DeleteDomainMappingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = await domainMappingsClient.PollOnceDeleteDomainMappingAsync(operationName);
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
