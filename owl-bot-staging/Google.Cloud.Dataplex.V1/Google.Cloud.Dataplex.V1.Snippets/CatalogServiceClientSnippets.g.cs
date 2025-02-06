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
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCatalogServiceClientSnippets
    {
        /// <summary>Snippet for CreateEntryType</summary>
        public void CreateEntryTypeRequestObject()
        {
            // Snippet: CreateEntryType(CreateEntryTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEntryTypeRequest request = new gcdv::CreateEntryTypeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryTypeId = "",
                EntryType = new gcdv::EntryType(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = catalogServiceClient.CreateEntryType(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryTypeAsync</summary>
        public async Task CreateEntryTypeRequestObjectAsync()
        {
            // Snippet: CreateEntryTypeAsync(CreateEntryTypeRequest, CallSettings)
            // Additional: CreateEntryTypeAsync(CreateEntryTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEntryTypeRequest request = new gcdv::CreateEntryTypeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryTypeId = "",
                EntryType = new gcdv::EntryType(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = await catalogServiceClient.CreateEntryTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryType</summary>
        public void CreateEntryType()
        {
            // Snippet: CreateEntryType(string, EntryType, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::EntryType entryType = new gcdv::EntryType();
            string entryTypeId = "";
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = catalogServiceClient.CreateEntryType(parent, entryType, entryTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryTypeAsync</summary>
        public async Task CreateEntryTypeAsync()
        {
            // Snippet: CreateEntryTypeAsync(string, EntryType, string, CallSettings)
            // Additional: CreateEntryTypeAsync(string, EntryType, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::EntryType entryType = new gcdv::EntryType();
            string entryTypeId = "";
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = await catalogServiceClient.CreateEntryTypeAsync(parent, entryType, entryTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryType</summary>
        public void CreateEntryTypeResourceNames()
        {
            // Snippet: CreateEntryType(LocationName, EntryType, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::EntryType entryType = new gcdv::EntryType();
            string entryTypeId = "";
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = catalogServiceClient.CreateEntryType(parent, entryType, entryTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryTypeAsync</summary>
        public async Task CreateEntryTypeResourceNamesAsync()
        {
            // Snippet: CreateEntryTypeAsync(LocationName, EntryType, string, CallSettings)
            // Additional: CreateEntryTypeAsync(LocationName, EntryType, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::EntryType entryType = new gcdv::EntryType();
            string entryTypeId = "";
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = await catalogServiceClient.CreateEntryTypeAsync(parent, entryType, entryTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryType</summary>
        public void UpdateEntryTypeRequestObject()
        {
            // Snippet: UpdateEntryType(UpdateEntryTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEntryTypeRequest request = new gcdv::UpdateEntryTypeRequest
            {
                EntryType = new gcdv::EntryType(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = catalogServiceClient.UpdateEntryType(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceUpdateEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryTypeAsync</summary>
        public async Task UpdateEntryTypeRequestObjectAsync()
        {
            // Snippet: UpdateEntryTypeAsync(UpdateEntryTypeRequest, CallSettings)
            // Additional: UpdateEntryTypeAsync(UpdateEntryTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEntryTypeRequest request = new gcdv::UpdateEntryTypeRequest
            {
                EntryType = new gcdv::EntryType(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateEntryTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryType</summary>
        public void UpdateEntryType()
        {
            // Snippet: UpdateEntryType(EntryType, FieldMask, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryType entryType = new gcdv::EntryType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = catalogServiceClient.UpdateEntryType(entryType, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceUpdateEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryTypeAsync</summary>
        public async Task UpdateEntryTypeAsync()
        {
            // Snippet: UpdateEntryTypeAsync(EntryType, FieldMask, CallSettings)
            // Additional: UpdateEntryTypeAsync(EntryType, FieldMask, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryType entryType = new gcdv::EntryType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::EntryType, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateEntryTypeAsync(entryType, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryType</summary>
        public void DeleteEntryTypeRequestObject()
        {
            // Snippet: DeleteEntryType(DeleteEntryTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEntryTypeRequest request = new gcdv::DeleteEntryTypeRequest
            {
                EntryTypeName = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteEntryType(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryTypeAsync</summary>
        public async Task DeleteEntryTypeRequestObjectAsync()
        {
            // Snippet: DeleteEntryTypeAsync(DeleteEntryTypeRequest, CallSettings)
            // Additional: DeleteEntryTypeAsync(DeleteEntryTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEntryTypeRequest request = new gcdv::DeleteEntryTypeRequest
            {
                EntryTypeName = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteEntryTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryType</summary>
        public void DeleteEntryType()
        {
            // Snippet: DeleteEntryType(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryTypes/[ENTRY_TYPE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteEntryType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryTypeAsync</summary>
        public async Task DeleteEntryTypeAsync()
        {
            // Snippet: DeleteEntryTypeAsync(string, CallSettings)
            // Additional: DeleteEntryTypeAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryTypes/[ENTRY_TYPE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteEntryTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryType</summary>
        public void DeleteEntryTypeResourceNames()
        {
            // Snippet: DeleteEntryType(EntryTypeName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryTypeName name = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteEntryType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteEntryType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryTypeAsync</summary>
        public async Task DeleteEntryTypeResourceNamesAsync()
        {
            // Snippet: DeleteEntryTypeAsync(EntryTypeName, CallSettings)
            // Additional: DeleteEntryTypeAsync(EntryTypeName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryTypeName name = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteEntryTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteEntryTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEntryTypes</summary>
        public void ListEntryTypesRequestObject()
        {
            // Snippet: ListEntryTypes(ListEntryTypesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEntryTypesRequest request = new gcdv::ListEntryTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListEntryTypesResponse, gcdv::EntryType> response = catalogServiceClient.ListEntryTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EntryType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntryTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryTypesAsync</summary>
        public async Task ListEntryTypesRequestObjectAsync()
        {
            // Snippet: ListEntryTypesAsync(ListEntryTypesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEntryTypesRequest request = new gcdv::ListEntryTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntryTypesResponse, gcdv::EntryType> response = catalogServiceClient.ListEntryTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EntryType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntryTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryTypes</summary>
        public void ListEntryTypes()
        {
            // Snippet: ListEntryTypes(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListEntryTypesResponse, gcdv::EntryType> response = catalogServiceClient.ListEntryTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EntryType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntryTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryTypesAsync</summary>
        public async Task ListEntryTypesAsync()
        {
            // Snippet: ListEntryTypesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntryTypesResponse, gcdv::EntryType> response = catalogServiceClient.ListEntryTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EntryType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntryTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryTypes</summary>
        public void ListEntryTypesResourceNames()
        {
            // Snippet: ListEntryTypes(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListEntryTypesResponse, gcdv::EntryType> response = catalogServiceClient.ListEntryTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EntryType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntryTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryTypesAsync</summary>
        public async Task ListEntryTypesResourceNamesAsync()
        {
            // Snippet: ListEntryTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntryTypesResponse, gcdv::EntryType> response = catalogServiceClient.ListEntryTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EntryType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntryTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntryType</summary>
        public void GetEntryTypeRequestObject()
        {
            // Snippet: GetEntryType(GetEntryTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEntryTypeRequest request = new gcdv::GetEntryTypeRequest
            {
                EntryTypeName = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]"),
            };
            // Make the request
            gcdv::EntryType response = catalogServiceClient.GetEntryType(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryTypeAsync</summary>
        public async Task GetEntryTypeRequestObjectAsync()
        {
            // Snippet: GetEntryTypeAsync(GetEntryTypeRequest, CallSettings)
            // Additional: GetEntryTypeAsync(GetEntryTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEntryTypeRequest request = new gcdv::GetEntryTypeRequest
            {
                EntryTypeName = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]"),
            };
            // Make the request
            gcdv::EntryType response = await catalogServiceClient.GetEntryTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryType</summary>
        public void GetEntryType()
        {
            // Snippet: GetEntryType(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryTypes/[ENTRY_TYPE]";
            // Make the request
            gcdv::EntryType response = catalogServiceClient.GetEntryType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryTypeAsync</summary>
        public async Task GetEntryTypeAsync()
        {
            // Snippet: GetEntryTypeAsync(string, CallSettings)
            // Additional: GetEntryTypeAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryTypes/[ENTRY_TYPE]";
            // Make the request
            gcdv::EntryType response = await catalogServiceClient.GetEntryTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryType</summary>
        public void GetEntryTypeResourceNames()
        {
            // Snippet: GetEntryType(EntryTypeName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryTypeName name = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]");
            // Make the request
            gcdv::EntryType response = catalogServiceClient.GetEntryType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryTypeAsync</summary>
        public async Task GetEntryTypeResourceNamesAsync()
        {
            // Snippet: GetEntryTypeAsync(EntryTypeName, CallSettings)
            // Additional: GetEntryTypeAsync(EntryTypeName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryTypeName name = gcdv::EntryTypeName.FromProjectLocationEntryType("[PROJECT]", "[LOCATION]", "[ENTRY_TYPE]");
            // Make the request
            gcdv::EntryType response = await catalogServiceClient.GetEntryTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAspectType</summary>
        public void CreateAspectTypeRequestObject()
        {
            // Snippet: CreateAspectType(CreateAspectTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateAspectTypeRequest request = new gcdv::CreateAspectTypeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AspectTypeId = "",
                AspectType = new gcdv::AspectType(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = catalogServiceClient.CreateAspectType(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAspectTypeAsync</summary>
        public async Task CreateAspectTypeRequestObjectAsync()
        {
            // Snippet: CreateAspectTypeAsync(CreateAspectTypeRequest, CallSettings)
            // Additional: CreateAspectTypeAsync(CreateAspectTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateAspectTypeRequest request = new gcdv::CreateAspectTypeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AspectTypeId = "",
                AspectType = new gcdv::AspectType(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = await catalogServiceClient.CreateAspectTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAspectType</summary>
        public void CreateAspectType()
        {
            // Snippet: CreateAspectType(string, AspectType, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::AspectType aspectType = new gcdv::AspectType();
            string aspectTypeId = "";
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = catalogServiceClient.CreateAspectType(parent, aspectType, aspectTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAspectTypeAsync</summary>
        public async Task CreateAspectTypeAsync()
        {
            // Snippet: CreateAspectTypeAsync(string, AspectType, string, CallSettings)
            // Additional: CreateAspectTypeAsync(string, AspectType, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::AspectType aspectType = new gcdv::AspectType();
            string aspectTypeId = "";
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = await catalogServiceClient.CreateAspectTypeAsync(parent, aspectType, aspectTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAspectType</summary>
        public void CreateAspectTypeResourceNames()
        {
            // Snippet: CreateAspectType(LocationName, AspectType, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::AspectType aspectType = new gcdv::AspectType();
            string aspectTypeId = "";
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = catalogServiceClient.CreateAspectType(parent, aspectType, aspectTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAspectTypeAsync</summary>
        public async Task CreateAspectTypeResourceNamesAsync()
        {
            // Snippet: CreateAspectTypeAsync(LocationName, AspectType, string, CallSettings)
            // Additional: CreateAspectTypeAsync(LocationName, AspectType, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::AspectType aspectType = new gcdv::AspectType();
            string aspectTypeId = "";
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = await catalogServiceClient.CreateAspectTypeAsync(parent, aspectType, aspectTypeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAspectType</summary>
        public void UpdateAspectTypeRequestObject()
        {
            // Snippet: UpdateAspectType(UpdateAspectTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateAspectTypeRequest request = new gcdv::UpdateAspectTypeRequest
            {
                AspectType = new gcdv::AspectType(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = catalogServiceClient.UpdateAspectType(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceUpdateAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAspectTypeAsync</summary>
        public async Task UpdateAspectTypeRequestObjectAsync()
        {
            // Snippet: UpdateAspectTypeAsync(UpdateAspectTypeRequest, CallSettings)
            // Additional: UpdateAspectTypeAsync(UpdateAspectTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateAspectTypeRequest request = new gcdv::UpdateAspectTypeRequest
            {
                AspectType = new gcdv::AspectType(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateAspectTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAspectType</summary>
        public void UpdateAspectType()
        {
            // Snippet: UpdateAspectType(AspectType, FieldMask, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::AspectType aspectType = new gcdv::AspectType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = catalogServiceClient.UpdateAspectType(aspectType, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceUpdateAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAspectTypeAsync</summary>
        public async Task UpdateAspectTypeAsync()
        {
            // Snippet: UpdateAspectTypeAsync(AspectType, FieldMask, CallSettings)
            // Additional: UpdateAspectTypeAsync(AspectType, FieldMask, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AspectType aspectType = new gcdv::AspectType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::AspectType, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateAspectTypeAsync(aspectType, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::AspectType, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::AspectType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::AspectType, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::AspectType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAspectType</summary>
        public void DeleteAspectTypeRequestObject()
        {
            // Snippet: DeleteAspectType(DeleteAspectTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteAspectTypeRequest request = new gcdv::DeleteAspectTypeRequest
            {
                AspectTypeName = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteAspectType(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAspectTypeAsync</summary>
        public async Task DeleteAspectTypeRequestObjectAsync()
        {
            // Snippet: DeleteAspectTypeAsync(DeleteAspectTypeRequest, CallSettings)
            // Additional: DeleteAspectTypeAsync(DeleteAspectTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteAspectTypeRequest request = new gcdv::DeleteAspectTypeRequest
            {
                AspectTypeName = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteAspectTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAspectType</summary>
        public void DeleteAspectType()
        {
            // Snippet: DeleteAspectType(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aspectTypes/[ASPECT_TYPE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteAspectType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAspectTypeAsync</summary>
        public async Task DeleteAspectTypeAsync()
        {
            // Snippet: DeleteAspectTypeAsync(string, CallSettings)
            // Additional: DeleteAspectTypeAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aspectTypes/[ASPECT_TYPE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteAspectTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAspectType</summary>
        public void DeleteAspectTypeResourceNames()
        {
            // Snippet: DeleteAspectType(AspectTypeName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::AspectTypeName name = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteAspectType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteAspectType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAspectTypeAsync</summary>
        public async Task DeleteAspectTypeResourceNamesAsync()
        {
            // Snippet: DeleteAspectTypeAsync(AspectTypeName, CallSettings)
            // Additional: DeleteAspectTypeAsync(AspectTypeName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AspectTypeName name = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteAspectTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteAspectTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAspectTypes</summary>
        public void ListAspectTypesRequestObject()
        {
            // Snippet: ListAspectTypes(ListAspectTypesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListAspectTypesRequest request = new gcdv::ListAspectTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListAspectTypesResponse, gcdv::AspectType> response = catalogServiceClient.ListAspectTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::AspectType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListAspectTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::AspectType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::AspectType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::AspectType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAspectTypesAsync</summary>
        public async Task ListAspectTypesRequestObjectAsync()
        {
            // Snippet: ListAspectTypesAsync(ListAspectTypesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListAspectTypesRequest request = new gcdv::ListAspectTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListAspectTypesResponse, gcdv::AspectType> response = catalogServiceClient.ListAspectTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::AspectType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListAspectTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::AspectType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::AspectType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::AspectType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAspectTypes</summary>
        public void ListAspectTypes()
        {
            // Snippet: ListAspectTypes(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListAspectTypesResponse, gcdv::AspectType> response = catalogServiceClient.ListAspectTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::AspectType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListAspectTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::AspectType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::AspectType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::AspectType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAspectTypesAsync</summary>
        public async Task ListAspectTypesAsync()
        {
            // Snippet: ListAspectTypesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListAspectTypesResponse, gcdv::AspectType> response = catalogServiceClient.ListAspectTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::AspectType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListAspectTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::AspectType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::AspectType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::AspectType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAspectTypes</summary>
        public void ListAspectTypesResourceNames()
        {
            // Snippet: ListAspectTypes(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListAspectTypesResponse, gcdv::AspectType> response = catalogServiceClient.ListAspectTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::AspectType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListAspectTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::AspectType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::AspectType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::AspectType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAspectTypesAsync</summary>
        public async Task ListAspectTypesResourceNamesAsync()
        {
            // Snippet: ListAspectTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListAspectTypesResponse, gcdv::AspectType> response = catalogServiceClient.ListAspectTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::AspectType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListAspectTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::AspectType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::AspectType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::AspectType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAspectType</summary>
        public void GetAspectTypeRequestObject()
        {
            // Snippet: GetAspectType(GetAspectTypeRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetAspectTypeRequest request = new gcdv::GetAspectTypeRequest
            {
                AspectTypeName = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]"),
            };
            // Make the request
            gcdv::AspectType response = catalogServiceClient.GetAspectType(request);
            // End snippet
        }

        /// <summary>Snippet for GetAspectTypeAsync</summary>
        public async Task GetAspectTypeRequestObjectAsync()
        {
            // Snippet: GetAspectTypeAsync(GetAspectTypeRequest, CallSettings)
            // Additional: GetAspectTypeAsync(GetAspectTypeRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetAspectTypeRequest request = new gcdv::GetAspectTypeRequest
            {
                AspectTypeName = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]"),
            };
            // Make the request
            gcdv::AspectType response = await catalogServiceClient.GetAspectTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAspectType</summary>
        public void GetAspectType()
        {
            // Snippet: GetAspectType(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aspectTypes/[ASPECT_TYPE]";
            // Make the request
            gcdv::AspectType response = catalogServiceClient.GetAspectType(name);
            // End snippet
        }

        /// <summary>Snippet for GetAspectTypeAsync</summary>
        public async Task GetAspectTypeAsync()
        {
            // Snippet: GetAspectTypeAsync(string, CallSettings)
            // Additional: GetAspectTypeAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/aspectTypes/[ASPECT_TYPE]";
            // Make the request
            gcdv::AspectType response = await catalogServiceClient.GetAspectTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAspectType</summary>
        public void GetAspectTypeResourceNames()
        {
            // Snippet: GetAspectType(AspectTypeName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::AspectTypeName name = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]");
            // Make the request
            gcdv::AspectType response = catalogServiceClient.GetAspectType(name);
            // End snippet
        }

        /// <summary>Snippet for GetAspectTypeAsync</summary>
        public async Task GetAspectTypeResourceNamesAsync()
        {
            // Snippet: GetAspectTypeAsync(AspectTypeName, CallSettings)
            // Additional: GetAspectTypeAsync(AspectTypeName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AspectTypeName name = gcdv::AspectTypeName.FromProjectLocationAspectType("[PROJECT]", "[LOCATION]", "[ASPECT_TYPE]");
            // Make the request
            gcdv::AspectType response = await catalogServiceClient.GetAspectTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroup</summary>
        public void CreateEntryGroupRequestObject()
        {
            // Snippet: CreateEntryGroup(CreateEntryGroupRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEntryGroupRequest request = new gcdv::CreateEntryGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroupId = "",
                EntryGroup = new gcdv::EntryGroup(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = catalogServiceClient.CreateEntryGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroupAsync</summary>
        public async Task CreateEntryGroupRequestObjectAsync()
        {
            // Snippet: CreateEntryGroupAsync(CreateEntryGroupRequest, CallSettings)
            // Additional: CreateEntryGroupAsync(CreateEntryGroupRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEntryGroupRequest request = new gcdv::CreateEntryGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroupId = "",
                EntryGroup = new gcdv::EntryGroup(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = await catalogServiceClient.CreateEntryGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroup</summary>
        public void CreateEntryGroup()
        {
            // Snippet: CreateEntryGroup(string, EntryGroup, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::EntryGroup entryGroup = new gcdv::EntryGroup();
            string entryGroupId = "";
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = catalogServiceClient.CreateEntryGroup(parent, entryGroup, entryGroupId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroupAsync</summary>
        public async Task CreateEntryGroupAsync()
        {
            // Snippet: CreateEntryGroupAsync(string, EntryGroup, string, CallSettings)
            // Additional: CreateEntryGroupAsync(string, EntryGroup, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::EntryGroup entryGroup = new gcdv::EntryGroup();
            string entryGroupId = "";
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = await catalogServiceClient.CreateEntryGroupAsync(parent, entryGroup, entryGroupId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroup</summary>
        public void CreateEntryGroupResourceNames()
        {
            // Snippet: CreateEntryGroup(LocationName, EntryGroup, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::EntryGroup entryGroup = new gcdv::EntryGroup();
            string entryGroupId = "";
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = catalogServiceClient.CreateEntryGroup(parent, entryGroup, entryGroupId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroupAsync</summary>
        public async Task CreateEntryGroupResourceNamesAsync()
        {
            // Snippet: CreateEntryGroupAsync(LocationName, EntryGroup, string, CallSettings)
            // Additional: CreateEntryGroupAsync(LocationName, EntryGroup, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::EntryGroup entryGroup = new gcdv::EntryGroup();
            string entryGroupId = "";
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = await catalogServiceClient.CreateEntryGroupAsync(parent, entryGroup, entryGroupId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroup</summary>
        public void UpdateEntryGroupRequestObject()
        {
            // Snippet: UpdateEntryGroup(UpdateEntryGroupRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEntryGroupRequest request = new gcdv::UpdateEntryGroupRequest
            {
                EntryGroup = new gcdv::EntryGroup(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = catalogServiceClient.UpdateEntryGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceUpdateEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroupAsync</summary>
        public async Task UpdateEntryGroupRequestObjectAsync()
        {
            // Snippet: UpdateEntryGroupAsync(UpdateEntryGroupRequest, CallSettings)
            // Additional: UpdateEntryGroupAsync(UpdateEntryGroupRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEntryGroupRequest request = new gcdv::UpdateEntryGroupRequest
            {
                EntryGroup = new gcdv::EntryGroup(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateEntryGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroup</summary>
        public void UpdateEntryGroup()
        {
            // Snippet: UpdateEntryGroup(EntryGroup, FieldMask, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryGroup entryGroup = new gcdv::EntryGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = catalogServiceClient.UpdateEntryGroup(entryGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceUpdateEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroupAsync</summary>
        public async Task UpdateEntryGroupAsync()
        {
            // Snippet: UpdateEntryGroupAsync(EntryGroup, FieldMask, CallSettings)
            // Additional: UpdateEntryGroupAsync(EntryGroup, FieldMask, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryGroup entryGroup = new gcdv::EntryGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> response = await catalogServiceClient.UpdateEntryGroupAsync(entryGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EntryGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EntryGroup, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceUpdateEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EntryGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroup</summary>
        public void DeleteEntryGroupRequestObject()
        {
            // Snippet: DeleteEntryGroup(DeleteEntryGroupRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEntryGroupRequest request = new gcdv::DeleteEntryGroupRequest
            {
                EntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteEntryGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupRequestObjectAsync()
        {
            // Snippet: DeleteEntryGroupAsync(DeleteEntryGroupRequest, CallSettings)
            // Additional: DeleteEntryGroupAsync(DeleteEntryGroupRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEntryGroupRequest request = new gcdv::DeleteEntryGroupRequest
            {
                EntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteEntryGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroup</summary>
        public void DeleteEntryGroup()
        {
            // Snippet: DeleteEntryGroup(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteEntryGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupAsync()
        {
            // Snippet: DeleteEntryGroupAsync(string, CallSettings)
            // Additional: DeleteEntryGroupAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteEntryGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroup</summary>
        public void DeleteEntryGroupResourceNames()
        {
            // Snippet: DeleteEntryGroup(EntryGroupName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryGroupName name = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = catalogServiceClient.DeleteEntryGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceDeleteEntryGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupResourceNamesAsync()
        {
            // Snippet: DeleteEntryGroupAsync(EntryGroupName, CallSettings)
            // Additional: DeleteEntryGroupAsync(EntryGroupName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryGroupName name = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await catalogServiceClient.DeleteEntryGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceDeleteEntryGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroups</summary>
        public void ListEntryGroupsRequestObject()
        {
            // Snippet: ListEntryGroups(ListEntryGroupsRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEntryGroupsRequest request = new gcdv::ListEntryGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListEntryGroupsResponse, gcdv::EntryGroup> response = catalogServiceClient.ListEntryGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EntryGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntryGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroupsAsync</summary>
        public async Task ListEntryGroupsRequestObjectAsync()
        {
            // Snippet: ListEntryGroupsAsync(ListEntryGroupsRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEntryGroupsRequest request = new gcdv::ListEntryGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntryGroupsResponse, gcdv::EntryGroup> response = catalogServiceClient.ListEntryGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EntryGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntryGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroups</summary>
        public void ListEntryGroups()
        {
            // Snippet: ListEntryGroups(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListEntryGroupsResponse, gcdv::EntryGroup> response = catalogServiceClient.ListEntryGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EntryGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntryGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroupsAsync</summary>
        public async Task ListEntryGroupsAsync()
        {
            // Snippet: ListEntryGroupsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntryGroupsResponse, gcdv::EntryGroup> response = catalogServiceClient.ListEntryGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EntryGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntryGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroups</summary>
        public void ListEntryGroupsResourceNames()
        {
            // Snippet: ListEntryGroups(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListEntryGroupsResponse, gcdv::EntryGroup> response = catalogServiceClient.ListEntryGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::EntryGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntryGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroupsAsync</summary>
        public async Task ListEntryGroupsResourceNamesAsync()
        {
            // Snippet: ListEntryGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntryGroupsResponse, gcdv::EntryGroup> response = catalogServiceClient.ListEntryGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::EntryGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntryGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::EntryGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroupRequestObject()
        {
            // Snippet: GetEntryGroup(GetEntryGroupRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEntryGroupRequest request = new gcdv::GetEntryGroupRequest
            {
                EntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            // Make the request
            gcdv::EntryGroup response = catalogServiceClient.GetEntryGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroupRequestObjectAsync()
        {
            // Snippet: GetEntryGroupAsync(GetEntryGroupRequest, CallSettings)
            // Additional: GetEntryGroupAsync(GetEntryGroupRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEntryGroupRequest request = new gcdv::GetEntryGroupRequest
            {
                EntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
            };
            // Make the request
            gcdv::EntryGroup response = await catalogServiceClient.GetEntryGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroup()
        {
            // Snippet: GetEntryGroup(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            gcdv::EntryGroup response = catalogServiceClient.GetEntryGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroupAsync()
        {
            // Snippet: GetEntryGroupAsync(string, CallSettings)
            // Additional: GetEntryGroupAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            gcdv::EntryGroup response = await catalogServiceClient.GetEntryGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroupResourceNames()
        {
            // Snippet: GetEntryGroup(EntryGroupName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryGroupName name = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            gcdv::EntryGroup response = catalogServiceClient.GetEntryGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroupResourceNamesAsync()
        {
            // Snippet: GetEntryGroupAsync(EntryGroupName, CallSettings)
            // Additional: GetEntryGroupAsync(EntryGroupName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryGroupName name = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            gcdv::EntryGroup response = await catalogServiceClient.GetEntryGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEntry</summary>
        public void CreateEntryRequestObject()
        {
            // Snippet: CreateEntry(CreateEntryRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEntryRequest request = new gcdv::CreateEntryRequest
            {
                ParentAsEntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                EntryId = "",
                Entry = new gcdv::Entry(),
            };
            // Make the request
            gcdv::Entry response = catalogServiceClient.CreateEntry(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryAsync</summary>
        public async Task CreateEntryRequestObjectAsync()
        {
            // Snippet: CreateEntryAsync(CreateEntryRequest, CallSettings)
            // Additional: CreateEntryAsync(CreateEntryRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEntryRequest request = new gcdv::CreateEntryRequest
            {
                ParentAsEntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                EntryId = "",
                Entry = new gcdv::Entry(),
            };
            // Make the request
            gcdv::Entry response = await catalogServiceClient.CreateEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntry</summary>
        public void CreateEntry()
        {
            // Snippet: CreateEntry(string, Entry, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            gcdv::Entry entry = new gcdv::Entry();
            string entryId = "";
            // Make the request
            gcdv::Entry response = catalogServiceClient.CreateEntry(parent, entry, entryId);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryAsync</summary>
        public async Task CreateEntryAsync()
        {
            // Snippet: CreateEntryAsync(string, Entry, string, CallSettings)
            // Additional: CreateEntryAsync(string, Entry, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            gcdv::Entry entry = new gcdv::Entry();
            string entryId = "";
            // Make the request
            gcdv::Entry response = await catalogServiceClient.CreateEntryAsync(parent, entry, entryId);
            // End snippet
        }

        /// <summary>Snippet for CreateEntry</summary>
        public void CreateEntryResourceNames()
        {
            // Snippet: CreateEntry(EntryGroupName, Entry, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryGroupName parent = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            gcdv::Entry entry = new gcdv::Entry();
            string entryId = "";
            // Make the request
            gcdv::Entry response = catalogServiceClient.CreateEntry(parent, entry, entryId);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryAsync</summary>
        public async Task CreateEntryResourceNamesAsync()
        {
            // Snippet: CreateEntryAsync(EntryGroupName, Entry, string, CallSettings)
            // Additional: CreateEntryAsync(EntryGroupName, Entry, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryGroupName parent = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            gcdv::Entry entry = new gcdv::Entry();
            string entryId = "";
            // Make the request
            gcdv::Entry response = await catalogServiceClient.CreateEntryAsync(parent, entry, entryId);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntry</summary>
        public void UpdateEntryRequestObject()
        {
            // Snippet: UpdateEntry(UpdateEntryRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEntryRequest request = new gcdv::UpdateEntryRequest
            {
                Entry = new gcdv::Entry(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                DeleteMissingAspects = false,
                AspectKeys = { "", },
            };
            // Make the request
            gcdv::Entry response = catalogServiceClient.UpdateEntry(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryAsync</summary>
        public async Task UpdateEntryRequestObjectAsync()
        {
            // Snippet: UpdateEntryAsync(UpdateEntryRequest, CallSettings)
            // Additional: UpdateEntryAsync(UpdateEntryRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEntryRequest request = new gcdv::UpdateEntryRequest
            {
                Entry = new gcdv::Entry(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                DeleteMissingAspects = false,
                AspectKeys = { "", },
            };
            // Make the request
            gcdv::Entry response = await catalogServiceClient.UpdateEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntry</summary>
        public void UpdateEntry()
        {
            // Snippet: UpdateEntry(Entry, FieldMask, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Entry entry = new gcdv::Entry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Entry response = catalogServiceClient.UpdateEntry(entry, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryAsync</summary>
        public async Task UpdateEntryAsync()
        {
            // Snippet: UpdateEntryAsync(Entry, FieldMask, CallSettings)
            // Additional: UpdateEntryAsync(Entry, FieldMask, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Entry entry = new gcdv::Entry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::Entry response = await catalogServiceClient.UpdateEntryAsync(entry, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntry</summary>
        public void DeleteEntryRequestObject()
        {
            // Snippet: DeleteEntry(DeleteEntryRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEntryRequest request = new gcdv::DeleteEntryRequest
            {
                EntryName = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            gcdv::Entry response = catalogServiceClient.DeleteEntry(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryAsync</summary>
        public async Task DeleteEntryRequestObjectAsync()
        {
            // Snippet: DeleteEntryAsync(DeleteEntryRequest, CallSettings)
            // Additional: DeleteEntryAsync(DeleteEntryRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEntryRequest request = new gcdv::DeleteEntryRequest
            {
                EntryName = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            gcdv::Entry response = await catalogServiceClient.DeleteEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntry</summary>
        public void DeleteEntry()
        {
            // Snippet: DeleteEntry(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            gcdv::Entry response = catalogServiceClient.DeleteEntry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryAsync</summary>
        public async Task DeleteEntryAsync()
        {
            // Snippet: DeleteEntryAsync(string, CallSettings)
            // Additional: DeleteEntryAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            gcdv::Entry response = await catalogServiceClient.DeleteEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntry</summary>
        public void DeleteEntryResourceNames()
        {
            // Snippet: DeleteEntry(EntryName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryName name = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            gcdv::Entry response = catalogServiceClient.DeleteEntry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryAsync</summary>
        public async Task DeleteEntryResourceNamesAsync()
        {
            // Snippet: DeleteEntryAsync(EntryName, CallSettings)
            // Additional: DeleteEntryAsync(EntryName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryName name = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            gcdv::Entry response = await catalogServiceClient.DeleteEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntries</summary>
        public void ListEntriesRequestObject()
        {
            // Snippet: ListEntries(ListEntriesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEntriesRequest request = new gcdv::ListEntriesRequest
            {
                ParentAsEntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListEntriesResponse, gcdv::Entry> response = catalogServiceClient.ListEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntriesAsync</summary>
        public async Task ListEntriesRequestObjectAsync()
        {
            // Snippet: ListEntriesAsync(ListEntriesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEntriesRequest request = new gcdv::ListEntriesRequest
            {
                ParentAsEntryGroupName = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntriesResponse, gcdv::Entry> response = catalogServiceClient.ListEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntries</summary>
        public void ListEntries()
        {
            // Snippet: ListEntries(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            PagedEnumerable<gcdv::ListEntriesResponse, gcdv::Entry> response = catalogServiceClient.ListEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntriesAsync</summary>
        public async Task ListEntriesAsync()
        {
            // Snippet: ListEntriesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntriesResponse, gcdv::Entry> response = catalogServiceClient.ListEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntries</summary>
        public void ListEntriesResourceNames()
        {
            // Snippet: ListEntries(EntryGroupName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryGroupName parent = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            PagedEnumerable<gcdv::ListEntriesResponse, gcdv::Entry> response = catalogServiceClient.ListEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntriesAsync</summary>
        public async Task ListEntriesResourceNamesAsync()
        {
            // Snippet: ListEntriesAsync(EntryGroupName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryGroupName parent = gcdv::EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEntriesResponse, gcdv::Entry> response = catalogServiceClient.ListEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntry</summary>
        public void GetEntryRequestObject()
        {
            // Snippet: GetEntry(GetEntryRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEntryRequest request = new gcdv::GetEntryRequest
            {
                EntryName = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                View = gcdv::EntryView.Unspecified,
                AspectTypes = { "", },
                Paths = { "", },
            };
            // Make the request
            gcdv::Entry response = catalogServiceClient.GetEntry(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryRequestObjectAsync()
        {
            // Snippet: GetEntryAsync(GetEntryRequest, CallSettings)
            // Additional: GetEntryAsync(GetEntryRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEntryRequest request = new gcdv::GetEntryRequest
            {
                EntryName = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                View = gcdv::EntryView.Unspecified,
                AspectTypes = { "", },
                Paths = { "", },
            };
            // Make the request
            gcdv::Entry response = await catalogServiceClient.GetEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntry</summary>
        public void GetEntry()
        {
            // Snippet: GetEntry(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            gcdv::Entry response = catalogServiceClient.GetEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryAsync()
        {
            // Snippet: GetEntryAsync(string, CallSettings)
            // Additional: GetEntryAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            gcdv::Entry response = await catalogServiceClient.GetEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntry</summary>
        public void GetEntryResourceNames()
        {
            // Snippet: GetEntry(EntryName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EntryName name = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            gcdv::Entry response = catalogServiceClient.GetEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryResourceNamesAsync()
        {
            // Snippet: GetEntryAsync(EntryName, CallSettings)
            // Additional: GetEntryAsync(EntryName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EntryName name = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            gcdv::Entry response = await catalogServiceClient.GetEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupEntry</summary>
        public void LookupEntryRequestObject()
        {
            // Snippet: LookupEntry(LookupEntryRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LookupEntryRequest request = new gcdv::LookupEntryRequest
            {
                Name = "",
                View = gcdv::EntryView.Unspecified,
                AspectTypes = { "", },
                Paths = { "", },
                EntryAsEntryName = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            gcdv::Entry response = catalogServiceClient.LookupEntry(request);
            // End snippet
        }

        /// <summary>Snippet for LookupEntryAsync</summary>
        public async Task LookupEntryRequestObjectAsync()
        {
            // Snippet: LookupEntryAsync(LookupEntryRequest, CallSettings)
            // Additional: LookupEntryAsync(LookupEntryRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LookupEntryRequest request = new gcdv::LookupEntryRequest
            {
                Name = "",
                View = gcdv::EntryView.Unspecified,
                AspectTypes = { "", },
                Paths = { "", },
                EntryAsEntryName = gcdv::EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            gcdv::Entry response = await catalogServiceClient.LookupEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchEntries</summary>
        public void SearchEntriesRequestObject()
        {
            // Snippet: SearchEntries(SearchEntriesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::SearchEntriesRequest request = new gcdv::SearchEntriesRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                OrderBy = "",
                Scope = "",
            };
            // Make the request
            PagedEnumerable<gcdv::SearchEntriesResponse, gcdv::SearchEntriesResult> response = catalogServiceClient.SearchEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::SearchEntriesResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::SearchEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchEntriesResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchEntriesResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchEntriesResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntriesAsync</summary>
        public async Task SearchEntriesRequestObjectAsync()
        {
            // Snippet: SearchEntriesAsync(SearchEntriesRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::SearchEntriesRequest request = new gcdv::SearchEntriesRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                OrderBy = "",
                Scope = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::SearchEntriesResponse, gcdv::SearchEntriesResult> response = catalogServiceClient.SearchEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::SearchEntriesResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::SearchEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchEntriesResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchEntriesResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchEntriesResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntries</summary>
        public void SearchEntries()
        {
            // Snippet: SearchEntries(string, string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedEnumerable<gcdv::SearchEntriesResponse, gcdv::SearchEntriesResult> response = catalogServiceClient.SearchEntries(name, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::SearchEntriesResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::SearchEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchEntriesResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchEntriesResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchEntriesResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntriesAsync</summary>
        public async Task SearchEntriesAsync()
        {
            // Snippet: SearchEntriesAsync(string, string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<gcdv::SearchEntriesResponse, gcdv::SearchEntriesResult> response = catalogServiceClient.SearchEntriesAsync(name, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::SearchEntriesResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::SearchEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchEntriesResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchEntriesResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchEntriesResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntries</summary>
        public void SearchEntriesResourceNames()
        {
            // Snippet: SearchEntries(LocationName, string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedEnumerable<gcdv::SearchEntriesResponse, gcdv::SearchEntriesResult> response = catalogServiceClient.SearchEntries(name, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::SearchEntriesResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::SearchEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchEntriesResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchEntriesResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchEntriesResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntriesAsync</summary>
        public async Task SearchEntriesResourceNamesAsync()
        {
            // Snippet: SearchEntriesAsync(LocationName, string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<gcdv::SearchEntriesResponse, gcdv::SearchEntriesResult> response = catalogServiceClient.SearchEntriesAsync(name, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::SearchEntriesResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::SearchEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::SearchEntriesResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::SearchEntriesResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::SearchEntriesResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataJob</summary>
        public void CreateMetadataJobRequestObject()
        {
            // Snippet: CreateMetadataJob(CreateMetadataJobRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateMetadataJobRequest request = new gcdv::CreateMetadataJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MetadataJob = new gcdv::MetadataJob(),
                MetadataJobId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> response = catalogServiceClient.CreateMetadataJob(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::MetadataJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateMetadataJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::MetadataJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataJobAsync</summary>
        public async Task CreateMetadataJobRequestObjectAsync()
        {
            // Snippet: CreateMetadataJobAsync(CreateMetadataJobRequest, CallSettings)
            // Additional: CreateMetadataJobAsync(CreateMetadataJobRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateMetadataJobRequest request = new gcdv::CreateMetadataJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MetadataJob = new gcdv::MetadataJob(),
                MetadataJobId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> response = await catalogServiceClient.CreateMetadataJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::MetadataJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateMetadataJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::MetadataJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataJob</summary>
        public void CreateMetadataJob()
        {
            // Snippet: CreateMetadataJob(string, MetadataJob, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::MetadataJob metadataJob = new gcdv::MetadataJob();
            string metadataJobId = "";
            // Make the request
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> response = catalogServiceClient.CreateMetadataJob(parent, metadataJob, metadataJobId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::MetadataJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateMetadataJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::MetadataJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataJobAsync</summary>
        public async Task CreateMetadataJobAsync()
        {
            // Snippet: CreateMetadataJobAsync(string, MetadataJob, string, CallSettings)
            // Additional: CreateMetadataJobAsync(string, MetadataJob, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::MetadataJob metadataJob = new gcdv::MetadataJob();
            string metadataJobId = "";
            // Make the request
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> response = await catalogServiceClient.CreateMetadataJobAsync(parent, metadataJob, metadataJobId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::MetadataJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateMetadataJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::MetadataJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataJob</summary>
        public void CreateMetadataJobResourceNames()
        {
            // Snippet: CreateMetadataJob(LocationName, MetadataJob, string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::MetadataJob metadataJob = new gcdv::MetadataJob();
            string metadataJobId = "";
            // Make the request
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> response = catalogServiceClient.CreateMetadataJob(parent, metadataJob, metadataJobId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::MetadataJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> retrievedResponse = catalogServiceClient.PollOnceCreateMetadataJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::MetadataJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMetadataJobAsync</summary>
        public async Task CreateMetadataJobResourceNamesAsync()
        {
            // Snippet: CreateMetadataJobAsync(LocationName, MetadataJob, string, CallSettings)
            // Additional: CreateMetadataJobAsync(LocationName, MetadataJob, string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::MetadataJob metadataJob = new gcdv::MetadataJob();
            string metadataJobId = "";
            // Make the request
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> response = await catalogServiceClient.CreateMetadataJobAsync(parent, metadataJob, metadataJobId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::MetadataJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::MetadataJob, gcdv::OperationMetadata> retrievedResponse = await catalogServiceClient.PollOnceCreateMetadataJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::MetadataJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetMetadataJob</summary>
        public void GetMetadataJobRequestObject()
        {
            // Snippet: GetMetadataJob(GetMetadataJobRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetMetadataJobRequest request = new gcdv::GetMetadataJobRequest
            {
                MetadataJobName = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]"),
            };
            // Make the request
            gcdv::MetadataJob response = catalogServiceClient.GetMetadataJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataJobAsync</summary>
        public async Task GetMetadataJobRequestObjectAsync()
        {
            // Snippet: GetMetadataJobAsync(GetMetadataJobRequest, CallSettings)
            // Additional: GetMetadataJobAsync(GetMetadataJobRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetMetadataJobRequest request = new gcdv::GetMetadataJobRequest
            {
                MetadataJobName = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]"),
            };
            // Make the request
            gcdv::MetadataJob response = await catalogServiceClient.GetMetadataJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataJob</summary>
        public void GetMetadataJob()
        {
            // Snippet: GetMetadataJob(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataJobs/[METADATAJOB]";
            // Make the request
            gcdv::MetadataJob response = catalogServiceClient.GetMetadataJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataJobAsync</summary>
        public async Task GetMetadataJobAsync()
        {
            // Snippet: GetMetadataJobAsync(string, CallSettings)
            // Additional: GetMetadataJobAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataJobs/[METADATAJOB]";
            // Make the request
            gcdv::MetadataJob response = await catalogServiceClient.GetMetadataJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataJob</summary>
        public void GetMetadataJobResourceNames()
        {
            // Snippet: GetMetadataJob(MetadataJobName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::MetadataJobName name = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]");
            // Make the request
            gcdv::MetadataJob response = catalogServiceClient.GetMetadataJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataJobAsync</summary>
        public async Task GetMetadataJobResourceNamesAsync()
        {
            // Snippet: GetMetadataJobAsync(MetadataJobName, CallSettings)
            // Additional: GetMetadataJobAsync(MetadataJobName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MetadataJobName name = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]");
            // Make the request
            gcdv::MetadataJob response = await catalogServiceClient.GetMetadataJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMetadataJobs</summary>
        public void ListMetadataJobsRequestObject()
        {
            // Snippet: ListMetadataJobs(ListMetadataJobsRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListMetadataJobsRequest request = new gcdv::ListMetadataJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListMetadataJobsResponse, gcdv::MetadataJob> response = catalogServiceClient.ListMetadataJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::MetadataJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListMetadataJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::MetadataJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::MetadataJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::MetadataJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataJobsAsync</summary>
        public async Task ListMetadataJobsRequestObjectAsync()
        {
            // Snippet: ListMetadataJobsAsync(ListMetadataJobsRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListMetadataJobsRequest request = new gcdv::ListMetadataJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListMetadataJobsResponse, gcdv::MetadataJob> response = catalogServiceClient.ListMetadataJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::MetadataJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListMetadataJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::MetadataJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::MetadataJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::MetadataJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataJobs</summary>
        public void ListMetadataJobs()
        {
            // Snippet: ListMetadataJobs(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListMetadataJobsResponse, gcdv::MetadataJob> response = catalogServiceClient.ListMetadataJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::MetadataJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListMetadataJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::MetadataJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::MetadataJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::MetadataJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataJobsAsync</summary>
        public async Task ListMetadataJobsAsync()
        {
            // Snippet: ListMetadataJobsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListMetadataJobsResponse, gcdv::MetadataJob> response = catalogServiceClient.ListMetadataJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::MetadataJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListMetadataJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::MetadataJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::MetadataJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::MetadataJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataJobs</summary>
        public void ListMetadataJobsResourceNames()
        {
            // Snippet: ListMetadataJobs(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListMetadataJobsResponse, gcdv::MetadataJob> response = catalogServiceClient.ListMetadataJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::MetadataJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListMetadataJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::MetadataJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::MetadataJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::MetadataJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetadataJobsAsync</summary>
        public async Task ListMetadataJobsResourceNamesAsync()
        {
            // Snippet: ListMetadataJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListMetadataJobsResponse, gcdv::MetadataJob> response = catalogServiceClient.ListMetadataJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::MetadataJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListMetadataJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::MetadataJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::MetadataJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::MetadataJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CancelMetadataJob</summary>
        public void CancelMetadataJobRequestObject()
        {
            // Snippet: CancelMetadataJob(CancelMetadataJobRequest, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CancelMetadataJobRequest request = new gcdv::CancelMetadataJobRequest
            {
                MetadataJobName = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]"),
            };
            // Make the request
            catalogServiceClient.CancelMetadataJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelMetadataJobAsync</summary>
        public async Task CancelMetadataJobRequestObjectAsync()
        {
            // Snippet: CancelMetadataJobAsync(CancelMetadataJobRequest, CallSettings)
            // Additional: CancelMetadataJobAsync(CancelMetadataJobRequest, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CancelMetadataJobRequest request = new gcdv::CancelMetadataJobRequest
            {
                MetadataJobName = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]"),
            };
            // Make the request
            await catalogServiceClient.CancelMetadataJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelMetadataJob</summary>
        public void CancelMetadataJob()
        {
            // Snippet: CancelMetadataJob(string, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataJobs/[METADATAJOB]";
            // Make the request
            catalogServiceClient.CancelMetadataJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelMetadataJobAsync</summary>
        public async Task CancelMetadataJobAsync()
        {
            // Snippet: CancelMetadataJobAsync(string, CallSettings)
            // Additional: CancelMetadataJobAsync(string, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/metadataJobs/[METADATAJOB]";
            // Make the request
            await catalogServiceClient.CancelMetadataJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelMetadataJob</summary>
        public void CancelMetadataJobResourceNames()
        {
            // Snippet: CancelMetadataJob(MetadataJobName, CallSettings)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = gcdv::CatalogServiceClient.Create();
            // Initialize request argument(s)
            gcdv::MetadataJobName name = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]");
            // Make the request
            catalogServiceClient.CancelMetadataJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelMetadataJobAsync</summary>
        public async Task CancelMetadataJobResourceNamesAsync()
        {
            // Snippet: CancelMetadataJobAsync(MetadataJobName, CallSettings)
            // Additional: CancelMetadataJobAsync(MetadataJobName, CancellationToken)
            // Create client
            gcdv::CatalogServiceClient catalogServiceClient = await gcdv::CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::MetadataJobName name = gcdv::MetadataJobName.FromProjectLocationMetadataJob("[PROJECT]", "[LOCATION]", "[METADATAJOB]");
            // Make the request
            await catalogServiceClient.CancelMetadataJobAsync(name);
            // End snippet
        }
    }
}
