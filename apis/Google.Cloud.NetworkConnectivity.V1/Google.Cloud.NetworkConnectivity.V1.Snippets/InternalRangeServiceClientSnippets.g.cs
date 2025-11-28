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
    using Google.Cloud.NetworkConnectivity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInternalRangeServiceClientSnippets
    {
        /// <summary>Snippet for ListInternalRanges</summary>
        public void ListInternalRangesRequestObject()
        {
            // Snippet: ListInternalRanges(ListInternalRangesRequest, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            ListInternalRangesRequest request = new ListInternalRangesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInternalRangesResponse, InternalRange> response = internalRangeServiceClient.ListInternalRanges(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InternalRange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInternalRangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InternalRange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InternalRange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InternalRange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInternalRangesAsync</summary>
        public async Task ListInternalRangesRequestObjectAsync()
        {
            // Snippet: ListInternalRangesAsync(ListInternalRangesRequest, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInternalRangesRequest request = new ListInternalRangesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> response = internalRangeServiceClient.ListInternalRangesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InternalRange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInternalRangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InternalRange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InternalRange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InternalRange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInternalRanges</summary>
        public void ListInternalRanges()
        {
            // Snippet: ListInternalRanges(string, string, int?, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInternalRangesResponse, InternalRange> response = internalRangeServiceClient.ListInternalRanges(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InternalRange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInternalRangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InternalRange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InternalRange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InternalRange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInternalRangesAsync</summary>
        public async Task ListInternalRangesAsync()
        {
            // Snippet: ListInternalRangesAsync(string, string, int?, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> response = internalRangeServiceClient.ListInternalRangesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InternalRange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInternalRangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InternalRange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InternalRange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InternalRange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInternalRanges</summary>
        public void ListInternalRangesResourceNames()
        {
            // Snippet: ListInternalRanges(LocationName, string, int?, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInternalRangesResponse, InternalRange> response = internalRangeServiceClient.ListInternalRanges(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InternalRange item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInternalRangesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InternalRange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InternalRange> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InternalRange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInternalRangesAsync</summary>
        public async Task ListInternalRangesResourceNamesAsync()
        {
            // Snippet: ListInternalRangesAsync(LocationName, string, int?, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> response = internalRangeServiceClient.ListInternalRangesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InternalRange item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInternalRangesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InternalRange item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InternalRange> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InternalRange item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInternalRange</summary>
        public void GetInternalRangeRequestObject()
        {
            // Snippet: GetInternalRange(GetInternalRangeRequest, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            GetInternalRangeRequest request = new GetInternalRangeRequest
            {
                InternalRangeName = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]"),
            };
            // Make the request
            InternalRange response = internalRangeServiceClient.GetInternalRange(request);
            // End snippet
        }

        /// <summary>Snippet for GetInternalRangeAsync</summary>
        public async Task GetInternalRangeRequestObjectAsync()
        {
            // Snippet: GetInternalRangeAsync(GetInternalRangeRequest, CallSettings)
            // Additional: GetInternalRangeAsync(GetInternalRangeRequest, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInternalRangeRequest request = new GetInternalRangeRequest
            {
                InternalRangeName = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]"),
            };
            // Make the request
            InternalRange response = await internalRangeServiceClient.GetInternalRangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInternalRange</summary>
        public void GetInternalRange()
        {
            // Snippet: GetInternalRange(string, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/internalRanges/[INTERNAL_RANGE]";
            // Make the request
            InternalRange response = internalRangeServiceClient.GetInternalRange(name);
            // End snippet
        }

        /// <summary>Snippet for GetInternalRangeAsync</summary>
        public async Task GetInternalRangeAsync()
        {
            // Snippet: GetInternalRangeAsync(string, CallSettings)
            // Additional: GetInternalRangeAsync(string, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/internalRanges/[INTERNAL_RANGE]";
            // Make the request
            InternalRange response = await internalRangeServiceClient.GetInternalRangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInternalRange</summary>
        public void GetInternalRangeResourceNames()
        {
            // Snippet: GetInternalRange(InternalRangeName, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            InternalRangeName name = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]");
            // Make the request
            InternalRange response = internalRangeServiceClient.GetInternalRange(name);
            // End snippet
        }

        /// <summary>Snippet for GetInternalRangeAsync</summary>
        public async Task GetInternalRangeResourceNamesAsync()
        {
            // Snippet: GetInternalRangeAsync(InternalRangeName, CallSettings)
            // Additional: GetInternalRangeAsync(InternalRangeName, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            InternalRangeName name = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]");
            // Make the request
            InternalRange response = await internalRangeServiceClient.GetInternalRangeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInternalRange</summary>
        public void CreateInternalRangeRequestObject()
        {
            // Snippet: CreateInternalRange(CreateInternalRangeRequest, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            CreateInternalRangeRequest request = new CreateInternalRangeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InternalRangeId = "",
                InternalRange = new InternalRange(),
                RequestId = "",
            };
            // Make the request
            Operation<InternalRange, OperationMetadata> response = internalRangeServiceClient.CreateInternalRange(request);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceCreateInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInternalRangeAsync</summary>
        public async Task CreateInternalRangeRequestObjectAsync()
        {
            // Snippet: CreateInternalRangeAsync(CreateInternalRangeRequest, CallSettings)
            // Additional: CreateInternalRangeAsync(CreateInternalRangeRequest, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInternalRangeRequest request = new CreateInternalRangeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InternalRangeId = "",
                InternalRange = new InternalRange(),
                RequestId = "",
            };
            // Make the request
            Operation<InternalRange, OperationMetadata> response = await internalRangeServiceClient.CreateInternalRangeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceCreateInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInternalRange</summary>
        public void CreateInternalRange()
        {
            // Snippet: CreateInternalRange(string, InternalRange, string, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InternalRange internalRange = new InternalRange();
            string internalRangeId = "";
            // Make the request
            Operation<InternalRange, OperationMetadata> response = internalRangeServiceClient.CreateInternalRange(parent, internalRange, internalRangeId);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceCreateInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInternalRangeAsync</summary>
        public async Task CreateInternalRangeAsync()
        {
            // Snippet: CreateInternalRangeAsync(string, InternalRange, string, CallSettings)
            // Additional: CreateInternalRangeAsync(string, InternalRange, string, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InternalRange internalRange = new InternalRange();
            string internalRangeId = "";
            // Make the request
            Operation<InternalRange, OperationMetadata> response = await internalRangeServiceClient.CreateInternalRangeAsync(parent, internalRange, internalRangeId);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceCreateInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInternalRange</summary>
        public void CreateInternalRangeResourceNames()
        {
            // Snippet: CreateInternalRange(LocationName, InternalRange, string, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InternalRange internalRange = new InternalRange();
            string internalRangeId = "";
            // Make the request
            Operation<InternalRange, OperationMetadata> response = internalRangeServiceClient.CreateInternalRange(parent, internalRange, internalRangeId);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceCreateInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInternalRangeAsync</summary>
        public async Task CreateInternalRangeResourceNamesAsync()
        {
            // Snippet: CreateInternalRangeAsync(LocationName, InternalRange, string, CallSettings)
            // Additional: CreateInternalRangeAsync(LocationName, InternalRange, string, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InternalRange internalRange = new InternalRange();
            string internalRangeId = "";
            // Make the request
            Operation<InternalRange, OperationMetadata> response = await internalRangeServiceClient.CreateInternalRangeAsync(parent, internalRange, internalRangeId);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceCreateInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInternalRange</summary>
        public void UpdateInternalRangeRequestObject()
        {
            // Snippet: UpdateInternalRange(UpdateInternalRangeRequest, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            UpdateInternalRangeRequest request = new UpdateInternalRangeRequest
            {
                UpdateMask = new FieldMask(),
                InternalRange = new InternalRange(),
                RequestId = "",
            };
            // Make the request
            Operation<InternalRange, OperationMetadata> response = internalRangeServiceClient.UpdateInternalRange(request);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceUpdateInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInternalRangeAsync</summary>
        public async Task UpdateInternalRangeRequestObjectAsync()
        {
            // Snippet: UpdateInternalRangeAsync(UpdateInternalRangeRequest, CallSettings)
            // Additional: UpdateInternalRangeAsync(UpdateInternalRangeRequest, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInternalRangeRequest request = new UpdateInternalRangeRequest
            {
                UpdateMask = new FieldMask(),
                InternalRange = new InternalRange(),
                RequestId = "",
            };
            // Make the request
            Operation<InternalRange, OperationMetadata> response = await internalRangeServiceClient.UpdateInternalRangeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceUpdateInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInternalRange</summary>
        public void UpdateInternalRange()
        {
            // Snippet: UpdateInternalRange(InternalRange, FieldMask, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            InternalRange internalRange = new InternalRange();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InternalRange, OperationMetadata> response = internalRangeServiceClient.UpdateInternalRange(internalRange, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceUpdateInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInternalRangeAsync</summary>
        public async Task UpdateInternalRangeAsync()
        {
            // Snippet: UpdateInternalRangeAsync(InternalRange, FieldMask, CallSettings)
            // Additional: UpdateInternalRangeAsync(InternalRange, FieldMask, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            InternalRange internalRange = new InternalRange();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InternalRange, OperationMetadata> response = await internalRangeServiceClient.UpdateInternalRangeAsync(internalRange, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InternalRange, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InternalRange result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InternalRange, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceUpdateInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InternalRange retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInternalRange</summary>
        public void DeleteInternalRangeRequestObject()
        {
            // Snippet: DeleteInternalRange(DeleteInternalRangeRequest, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            DeleteInternalRangeRequest request = new DeleteInternalRangeRequest
            {
                InternalRangeName = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = internalRangeServiceClient.DeleteInternalRange(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceDeleteInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInternalRangeAsync</summary>
        public async Task DeleteInternalRangeRequestObjectAsync()
        {
            // Snippet: DeleteInternalRangeAsync(DeleteInternalRangeRequest, CallSettings)
            // Additional: DeleteInternalRangeAsync(DeleteInternalRangeRequest, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInternalRangeRequest request = new DeleteInternalRangeRequest
            {
                InternalRangeName = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await internalRangeServiceClient.DeleteInternalRangeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceDeleteInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInternalRange</summary>
        public void DeleteInternalRange()
        {
            // Snippet: DeleteInternalRange(string, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/internalRanges/[INTERNAL_RANGE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = internalRangeServiceClient.DeleteInternalRange(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceDeleteInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInternalRangeAsync</summary>
        public async Task DeleteInternalRangeAsync()
        {
            // Snippet: DeleteInternalRangeAsync(string, CallSettings)
            // Additional: DeleteInternalRangeAsync(string, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/internalRanges/[INTERNAL_RANGE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await internalRangeServiceClient.DeleteInternalRangeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceDeleteInternalRangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInternalRange</summary>
        public void DeleteInternalRangeResourceNames()
        {
            // Snippet: DeleteInternalRange(InternalRangeName, CallSettings)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = InternalRangeServiceClient.Create();
            // Initialize request argument(s)
            InternalRangeName name = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = internalRangeServiceClient.DeleteInternalRange(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = internalRangeServiceClient.PollOnceDeleteInternalRange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInternalRangeAsync</summary>
        public async Task DeleteInternalRangeResourceNamesAsync()
        {
            // Snippet: DeleteInternalRangeAsync(InternalRangeName, CallSettings)
            // Additional: DeleteInternalRangeAsync(InternalRangeName, CancellationToken)
            // Create client
            InternalRangeServiceClient internalRangeServiceClient = await InternalRangeServiceClient.CreateAsync();
            // Initialize request argument(s)
            InternalRangeName name = InternalRangeName.FromProjectLocationInternalRange("[PROJECT]", "[LOCATION]", "[INTERNAL_RANGE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await internalRangeServiceClient.DeleteInternalRangeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await internalRangeServiceClient.PollOnceDeleteInternalRangeAsync(operationName);
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
