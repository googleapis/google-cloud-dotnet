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
    using Google.Cloud.Metastore.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataprocMetastoreFederationClientSnippets
    {
        /// <summary>Snippet for ListFederations</summary>
        public void ListFederationsRequestObject()
        {
            // Snippet: ListFederations(ListFederationsRequest, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            ListFederationsRequest request = new ListFederationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFederationsResponse, Federation> response = dataprocMetastoreFederationClient.ListFederations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Federation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFederationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Federation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Federation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Federation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFederationsAsync</summary>
        public async Task ListFederationsRequestObjectAsync()
        {
            // Snippet: ListFederationsAsync(ListFederationsRequest, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            ListFederationsRequest request = new ListFederationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFederationsResponse, Federation> response = dataprocMetastoreFederationClient.ListFederationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Federation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFederationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Federation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Federation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Federation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFederations</summary>
        public void ListFederations()
        {
            // Snippet: ListFederations(string, string, int?, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFederationsResponse, Federation> response = dataprocMetastoreFederationClient.ListFederations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Federation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFederationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Federation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Federation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Federation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFederationsAsync</summary>
        public async Task ListFederationsAsync()
        {
            // Snippet: ListFederationsAsync(string, string, int?, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFederationsResponse, Federation> response = dataprocMetastoreFederationClient.ListFederationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Federation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFederationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Federation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Federation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Federation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFederations</summary>
        public void ListFederationsResourceNames()
        {
            // Snippet: ListFederations(LocationName, string, int?, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFederationsResponse, Federation> response = dataprocMetastoreFederationClient.ListFederations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Federation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFederationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Federation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Federation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Federation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFederationsAsync</summary>
        public async Task ListFederationsResourceNamesAsync()
        {
            // Snippet: ListFederationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFederationsResponse, Federation> response = dataprocMetastoreFederationClient.ListFederationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Federation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFederationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Federation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Federation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Federation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFederation</summary>
        public void GetFederationRequestObject()
        {
            // Snippet: GetFederation(GetFederationRequest, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            GetFederationRequest request = new GetFederationRequest
            {
                FederationName = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]"),
            };
            // Make the request
            Federation response = dataprocMetastoreFederationClient.GetFederation(request);
            // End snippet
        }

        /// <summary>Snippet for GetFederationAsync</summary>
        public async Task GetFederationRequestObjectAsync()
        {
            // Snippet: GetFederationAsync(GetFederationRequest, CallSettings)
            // Additional: GetFederationAsync(GetFederationRequest, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            GetFederationRequest request = new GetFederationRequest
            {
                FederationName = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]"),
            };
            // Make the request
            Federation response = await dataprocMetastoreFederationClient.GetFederationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFederation</summary>
        public void GetFederation()
        {
            // Snippet: GetFederation(string, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/federations/[FEDERATION]";
            // Make the request
            Federation response = dataprocMetastoreFederationClient.GetFederation(name);
            // End snippet
        }

        /// <summary>Snippet for GetFederationAsync</summary>
        public async Task GetFederationAsync()
        {
            // Snippet: GetFederationAsync(string, CallSettings)
            // Additional: GetFederationAsync(string, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/federations/[FEDERATION]";
            // Make the request
            Federation response = await dataprocMetastoreFederationClient.GetFederationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFederation</summary>
        public void GetFederationResourceNames()
        {
            // Snippet: GetFederation(FederationName, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            FederationName name = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]");
            // Make the request
            Federation response = dataprocMetastoreFederationClient.GetFederation(name);
            // End snippet
        }

        /// <summary>Snippet for GetFederationAsync</summary>
        public async Task GetFederationResourceNamesAsync()
        {
            // Snippet: GetFederationAsync(FederationName, CallSettings)
            // Additional: GetFederationAsync(FederationName, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            FederationName name = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]");
            // Make the request
            Federation response = await dataprocMetastoreFederationClient.GetFederationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFederation</summary>
        public void CreateFederationRequestObject()
        {
            // Snippet: CreateFederation(CreateFederationRequest, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            CreateFederationRequest request = new CreateFederationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FederationId = "",
                Federation = new Federation(),
                RequestId = "",
            };
            // Make the request
            Operation<Federation, OperationMetadata> response = dataprocMetastoreFederationClient.CreateFederation(request);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceCreateFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFederationAsync</summary>
        public async Task CreateFederationRequestObjectAsync()
        {
            // Snippet: CreateFederationAsync(CreateFederationRequest, CallSettings)
            // Additional: CreateFederationAsync(CreateFederationRequest, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            CreateFederationRequest request = new CreateFederationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FederationId = "",
                Federation = new Federation(),
                RequestId = "",
            };
            // Make the request
            Operation<Federation, OperationMetadata> response = await dataprocMetastoreFederationClient.CreateFederationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceCreateFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFederation</summary>
        public void CreateFederation()
        {
            // Snippet: CreateFederation(string, Federation, string, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Federation federation = new Federation();
            string federationId = "";
            // Make the request
            Operation<Federation, OperationMetadata> response = dataprocMetastoreFederationClient.CreateFederation(parent, federation, federationId);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceCreateFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFederationAsync</summary>
        public async Task CreateFederationAsync()
        {
            // Snippet: CreateFederationAsync(string, Federation, string, CallSettings)
            // Additional: CreateFederationAsync(string, Federation, string, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Federation federation = new Federation();
            string federationId = "";
            // Make the request
            Operation<Federation, OperationMetadata> response = await dataprocMetastoreFederationClient.CreateFederationAsync(parent, federation, federationId);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceCreateFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFederation</summary>
        public void CreateFederationResourceNames()
        {
            // Snippet: CreateFederation(LocationName, Federation, string, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Federation federation = new Federation();
            string federationId = "";
            // Make the request
            Operation<Federation, OperationMetadata> response = dataprocMetastoreFederationClient.CreateFederation(parent, federation, federationId);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceCreateFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFederationAsync</summary>
        public async Task CreateFederationResourceNamesAsync()
        {
            // Snippet: CreateFederationAsync(LocationName, Federation, string, CallSettings)
            // Additional: CreateFederationAsync(LocationName, Federation, string, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Federation federation = new Federation();
            string federationId = "";
            // Make the request
            Operation<Federation, OperationMetadata> response = await dataprocMetastoreFederationClient.CreateFederationAsync(parent, federation, federationId);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceCreateFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFederation</summary>
        public void UpdateFederationRequestObject()
        {
            // Snippet: UpdateFederation(UpdateFederationRequest, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            UpdateFederationRequest request = new UpdateFederationRequest
            {
                UpdateMask = new FieldMask(),
                Federation = new Federation(),
                RequestId = "",
            };
            // Make the request
            Operation<Federation, OperationMetadata> response = dataprocMetastoreFederationClient.UpdateFederation(request);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceUpdateFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFederationAsync</summary>
        public async Task UpdateFederationRequestObjectAsync()
        {
            // Snippet: UpdateFederationAsync(UpdateFederationRequest, CallSettings)
            // Additional: UpdateFederationAsync(UpdateFederationRequest, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFederationRequest request = new UpdateFederationRequest
            {
                UpdateMask = new FieldMask(),
                Federation = new Federation(),
                RequestId = "",
            };
            // Make the request
            Operation<Federation, OperationMetadata> response = await dataprocMetastoreFederationClient.UpdateFederationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceUpdateFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFederation</summary>
        public void UpdateFederation()
        {
            // Snippet: UpdateFederation(Federation, FieldMask, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            Federation federation = new Federation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Federation, OperationMetadata> response = dataprocMetastoreFederationClient.UpdateFederation(federation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceUpdateFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFederationAsync</summary>
        public async Task UpdateFederationAsync()
        {
            // Snippet: UpdateFederationAsync(Federation, FieldMask, CallSettings)
            // Additional: UpdateFederationAsync(Federation, FieldMask, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            Federation federation = new Federation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Federation, OperationMetadata> response = await dataprocMetastoreFederationClient.UpdateFederationAsync(federation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Federation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Federation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Federation, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceUpdateFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Federation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFederation</summary>
        public void DeleteFederationRequestObject()
        {
            // Snippet: DeleteFederation(DeleteFederationRequest, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            DeleteFederationRequest request = new DeleteFederationRequest
            {
                FederationName = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataprocMetastoreFederationClient.DeleteFederation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceDeleteFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFederationAsync</summary>
        public async Task DeleteFederationRequestObjectAsync()
        {
            // Snippet: DeleteFederationAsync(DeleteFederationRequest, CallSettings)
            // Additional: DeleteFederationAsync(DeleteFederationRequest, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFederationRequest request = new DeleteFederationRequest
            {
                FederationName = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataprocMetastoreFederationClient.DeleteFederationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceDeleteFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFederation</summary>
        public void DeleteFederation()
        {
            // Snippet: DeleteFederation(string, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/federations/[FEDERATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataprocMetastoreFederationClient.DeleteFederation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceDeleteFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFederationAsync</summary>
        public async Task DeleteFederationAsync()
        {
            // Snippet: DeleteFederationAsync(string, CallSettings)
            // Additional: DeleteFederationAsync(string, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/federations/[FEDERATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataprocMetastoreFederationClient.DeleteFederationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceDeleteFederationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFederation</summary>
        public void DeleteFederationResourceNames()
        {
            // Snippet: DeleteFederation(FederationName, CallSettings)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = DataprocMetastoreFederationClient.Create();
            // Initialize request argument(s)
            FederationName name = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataprocMetastoreFederationClient.DeleteFederation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataprocMetastoreFederationClient.PollOnceDeleteFederation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFederationAsync</summary>
        public async Task DeleteFederationResourceNamesAsync()
        {
            // Snippet: DeleteFederationAsync(FederationName, CallSettings)
            // Additional: DeleteFederationAsync(FederationName, CancellationToken)
            // Create client
            DataprocMetastoreFederationClient dataprocMetastoreFederationClient = await DataprocMetastoreFederationClient.CreateAsync();
            // Initialize request argument(s)
            FederationName name = FederationName.FromProjectLocationFederation("[PROJECT]", "[LOCATION]", "[FEDERATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataprocMetastoreFederationClient.DeleteFederationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataprocMetastoreFederationClient.PollOnceDeleteFederationAsync(operationName);
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
