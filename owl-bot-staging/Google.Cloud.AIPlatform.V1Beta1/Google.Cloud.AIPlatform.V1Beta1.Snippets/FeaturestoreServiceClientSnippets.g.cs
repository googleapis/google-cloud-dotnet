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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeaturestoreServiceClientSnippets
    {
        /// <summary>Snippet for CreateFeaturestore</summary>
        public void CreateFeaturestoreRequestObject()
        {
            // Snippet: CreateFeaturestore(CreateFeaturestoreRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            CreateFeaturestoreRequest request = new CreateFeaturestoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Featurestore = new Featurestore(),
                FeaturestoreId = "",
            };
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = featurestoreServiceClient.CreateFeaturestore(request);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestoreAsync</summary>
        public async Task CreateFeaturestoreRequestObjectAsync()
        {
            // Snippet: CreateFeaturestoreAsync(CreateFeaturestoreRequest, CallSettings)
            // Additional: CreateFeaturestoreAsync(CreateFeaturestoreRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeaturestoreRequest request = new CreateFeaturestoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Featurestore = new Featurestore(),
                FeaturestoreId = "",
            };
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.CreateFeaturestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestore</summary>
        public void CreateFeaturestore1()
        {
            // Snippet: CreateFeaturestore(string, Featurestore, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Featurestore featurestore = new Featurestore();
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = featurestoreServiceClient.CreateFeaturestore(parent, featurestore);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestoreAsync</summary>
        public async Task CreateFeaturestore1Async()
        {
            // Snippet: CreateFeaturestoreAsync(string, Featurestore, CallSettings)
            // Additional: CreateFeaturestoreAsync(string, Featurestore, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Featurestore featurestore = new Featurestore();
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.CreateFeaturestoreAsync(parent, featurestore);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestore</summary>
        public void CreateFeaturestore1ResourceNames()
        {
            // Snippet: CreateFeaturestore(LocationName, Featurestore, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Featurestore featurestore = new Featurestore();
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = featurestoreServiceClient.CreateFeaturestore(parent, featurestore);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestoreAsync</summary>
        public async Task CreateFeaturestore1ResourceNamesAsync()
        {
            // Snippet: CreateFeaturestoreAsync(LocationName, Featurestore, CallSettings)
            // Additional: CreateFeaturestoreAsync(LocationName, Featurestore, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Featurestore featurestore = new Featurestore();
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.CreateFeaturestoreAsync(parent, featurestore);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestore</summary>
        public void CreateFeaturestore2()
        {
            // Snippet: CreateFeaturestore(string, Featurestore, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Featurestore featurestore = new Featurestore();
            string featurestoreId = "";
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = featurestoreServiceClient.CreateFeaturestore(parent, featurestore, featurestoreId);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestoreAsync</summary>
        public async Task CreateFeaturestore2Async()
        {
            // Snippet: CreateFeaturestoreAsync(string, Featurestore, string, CallSettings)
            // Additional: CreateFeaturestoreAsync(string, Featurestore, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Featurestore featurestore = new Featurestore();
            string featurestoreId = "";
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.CreateFeaturestoreAsync(parent, featurestore, featurestoreId);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestore</summary>
        public void CreateFeaturestore2ResourceNames()
        {
            // Snippet: CreateFeaturestore(LocationName, Featurestore, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Featurestore featurestore = new Featurestore();
            string featurestoreId = "";
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = featurestoreServiceClient.CreateFeaturestore(parent, featurestore, featurestoreId);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeaturestoreAsync</summary>
        public async Task CreateFeaturestore2ResourceNamesAsync()
        {
            // Snippet: CreateFeaturestoreAsync(LocationName, Featurestore, string, CallSettings)
            // Additional: CreateFeaturestoreAsync(LocationName, Featurestore, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Featurestore featurestore = new Featurestore();
            string featurestoreId = "";
            // Make the request
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.CreateFeaturestoreAsync(parent, featurestore, featurestoreId);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, CreateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeaturestore</summary>
        public void GetFeaturestoreRequestObject()
        {
            // Snippet: GetFeaturestore(GetFeaturestoreRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            // Make the request
            Featurestore response = featurestoreServiceClient.GetFeaturestore(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturestoreAsync</summary>
        public async Task GetFeaturestoreRequestObjectAsync()
        {
            // Snippet: GetFeaturestoreAsync(GetFeaturestoreRequest, CallSettings)
            // Additional: GetFeaturestoreAsync(GetFeaturestoreRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeaturestoreRequest request = new GetFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
            };
            // Make the request
            Featurestore response = await featurestoreServiceClient.GetFeaturestoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturestore</summary>
        public void GetFeaturestore()
        {
            // Snippet: GetFeaturestore(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            Featurestore response = featurestoreServiceClient.GetFeaturestore(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturestoreAsync</summary>
        public async Task GetFeaturestoreAsync()
        {
            // Snippet: GetFeaturestoreAsync(string, CallSettings)
            // Additional: GetFeaturestoreAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            Featurestore response = await featurestoreServiceClient.GetFeaturestoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturestore</summary>
        public void GetFeaturestoreResourceNames()
        {
            // Snippet: GetFeaturestore(FeaturestoreName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName name = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            Featurestore response = featurestoreServiceClient.GetFeaturestore(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturestoreAsync</summary>
        public async Task GetFeaturestoreResourceNamesAsync()
        {
            // Snippet: GetFeaturestoreAsync(FeaturestoreName, CallSettings)
            // Additional: GetFeaturestoreAsync(FeaturestoreName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName name = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            Featurestore response = await featurestoreServiceClient.GetFeaturestoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeaturestores</summary>
        public void ListFeaturestoresRequestObject()
        {
            // Snippet: ListFeaturestores(ListFeaturestoresRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            ListFeaturestoresRequest request = new ListFeaturestoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListFeaturestoresResponse, Featurestore> response = featurestoreServiceClient.ListFeaturestores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Featurestore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Featurestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Featurestore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Featurestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturestoresAsync</summary>
        public async Task ListFeaturestoresRequestObjectAsync()
        {
            // Snippet: ListFeaturestoresAsync(ListFeaturestoresRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeaturestoresRequest request = new ListFeaturestoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> response = featurestoreServiceClient.ListFeaturestoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Featurestore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Featurestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Featurestore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Featurestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturestores</summary>
        public void ListFeaturestores()
        {
            // Snippet: ListFeaturestores(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFeaturestoresResponse, Featurestore> response = featurestoreServiceClient.ListFeaturestores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Featurestore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Featurestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Featurestore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Featurestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturestoresAsync</summary>
        public async Task ListFeaturestoresAsync()
        {
            // Snippet: ListFeaturestoresAsync(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> response = featurestoreServiceClient.ListFeaturestoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Featurestore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Featurestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Featurestore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Featurestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturestores</summary>
        public void ListFeaturestoresResourceNames()
        {
            // Snippet: ListFeaturestores(LocationName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFeaturestoresResponse, Featurestore> response = featurestoreServiceClient.ListFeaturestores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Featurestore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturestoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Featurestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Featurestore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Featurestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturestoresAsync</summary>
        public async Task ListFeaturestoresResourceNamesAsync()
        {
            // Snippet: ListFeaturestoresAsync(LocationName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturestoresResponse, Featurestore> response = featurestoreServiceClient.ListFeaturestoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Featurestore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturestoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Featurestore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Featurestore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Featurestore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFeaturestore</summary>
        public void UpdateFeaturestoreRequestObject()
        {
            // Snippet: UpdateFeaturestore(UpdateFeaturestoreRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeaturestoreRequest request = new UpdateFeaturestoreRequest
            {
                Featurestore = new Featurestore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> response = featurestoreServiceClient.UpdateFeaturestore(request);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceUpdateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeaturestoreAsync</summary>
        public async Task UpdateFeaturestoreRequestObjectAsync()
        {
            // Snippet: UpdateFeaturestoreAsync(UpdateFeaturestoreRequest, CallSettings)
            // Additional: UpdateFeaturestoreAsync(UpdateFeaturestoreRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeaturestoreRequest request = new UpdateFeaturestoreRequest
            {
                Featurestore = new Featurestore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.UpdateFeaturestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceUpdateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeaturestore</summary>
        public void UpdateFeaturestore()
        {
            // Snippet: UpdateFeaturestore(Featurestore, FieldMask, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            Featurestore featurestore = new Featurestore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> response = featurestoreServiceClient.UpdateFeaturestore(featurestore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceUpdateFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeaturestoreAsync</summary>
        public async Task UpdateFeaturestoreAsync()
        {
            // Snippet: UpdateFeaturestoreAsync(Featurestore, FieldMask, CallSettings)
            // Additional: UpdateFeaturestoreAsync(Featurestore, FieldMask, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            Featurestore featurestore = new Featurestore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> response = await featurestoreServiceClient.UpdateFeaturestoreAsync(featurestore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Featurestore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Featurestore, UpdateFeaturestoreOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceUpdateFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Featurestore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestore</summary>
        public void DeleteFeaturestoreRequestObject()
        {
            // Snippet: DeleteFeaturestore(DeleteFeaturestoreRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeaturestoreRequest request = new DeleteFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeaturestore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestoreAsync</summary>
        public async Task DeleteFeaturestoreRequestObjectAsync()
        {
            // Snippet: DeleteFeaturestoreAsync(DeleteFeaturestoreRequest, CallSettings)
            // Additional: DeleteFeaturestoreAsync(DeleteFeaturestoreRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeaturestoreRequest request = new DeleteFeaturestoreRequest
            {
                FeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeaturestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestore</summary>
        public void DeleteFeaturestore1()
        {
            // Snippet: DeleteFeaturestore(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeaturestore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestoreAsync</summary>
        public async Task DeleteFeaturestore1Async()
        {
            // Snippet: DeleteFeaturestoreAsync(string, CallSettings)
            // Additional: DeleteFeaturestoreAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeaturestoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestore</summary>
        public void DeleteFeaturestore1ResourceNames()
        {
            // Snippet: DeleteFeaturestore(FeaturestoreName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName name = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeaturestore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestoreAsync</summary>
        public async Task DeleteFeaturestore1ResourceNamesAsync()
        {
            // Snippet: DeleteFeaturestoreAsync(FeaturestoreName, CallSettings)
            // Additional: DeleteFeaturestoreAsync(FeaturestoreName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName name = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeaturestoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestore</summary>
        public void DeleteFeaturestore2()
        {
            // Snippet: DeleteFeaturestore(string, bool, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeaturestore(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestoreAsync</summary>
        public async Task DeleteFeaturestore2Async()
        {
            // Snippet: DeleteFeaturestoreAsync(string, bool, CallSettings)
            // Additional: DeleteFeaturestoreAsync(string, bool, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeaturestoreAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestore</summary>
        public void DeleteFeaturestore2ResourceNames()
        {
            // Snippet: DeleteFeaturestore(FeaturestoreName, bool, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName name = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeaturestore(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeaturestore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeaturestoreAsync</summary>
        public async Task DeleteFeaturestore2ResourceNamesAsync()
        {
            // Snippet: DeleteFeaturestoreAsync(FeaturestoreName, bool, CallSettings)
            // Additional: DeleteFeaturestoreAsync(FeaturestoreName, bool, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName name = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeaturestoreAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeaturestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityTypeRequestObject()
        {
            // Snippet: CreateEntityType(CreateEntityTypeRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                EntityType = new EntityType(),
                EntityTypeId = "",
            };
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = featurestoreServiceClient.CreateEntityType(request);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityTypeRequestObjectAsync()
        {
            // Snippet: CreateEntityTypeAsync(CreateEntityTypeRequest, CallSettings)
            // Additional: CreateEntityTypeAsync(CreateEntityTypeRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                EntityType = new EntityType(),
                EntityTypeId = "",
            };
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = await featurestoreServiceClient.CreateEntityTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType1()
        {
            // Snippet: CreateEntityType(string, EntityType, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            EntityType entityType = new EntityType();
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = featurestoreServiceClient.CreateEntityType(parent, entityType);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType1Async()
        {
            // Snippet: CreateEntityTypeAsync(string, EntityType, CallSettings)
            // Additional: CreateEntityTypeAsync(string, EntityType, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            EntityType entityType = new EntityType();
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = await featurestoreServiceClient.CreateEntityTypeAsync(parent, entityType);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType1ResourceNames()
        {
            // Snippet: CreateEntityType(FeaturestoreName, EntityType, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName parent = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            EntityType entityType = new EntityType();
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = featurestoreServiceClient.CreateEntityType(parent, entityType);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType1ResourceNamesAsync()
        {
            // Snippet: CreateEntityTypeAsync(FeaturestoreName, EntityType, CallSettings)
            // Additional: CreateEntityTypeAsync(FeaturestoreName, EntityType, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName parent = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            EntityType entityType = new EntityType();
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = await featurestoreServiceClient.CreateEntityTypeAsync(parent, entityType);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType2()
        {
            // Snippet: CreateEntityType(string, EntityType, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            EntityType entityType = new EntityType();
            string entityTypeId = "";
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = featurestoreServiceClient.CreateEntityType(parent, entityType, entityTypeId);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType2Async()
        {
            // Snippet: CreateEntityTypeAsync(string, EntityType, string, CallSettings)
            // Additional: CreateEntityTypeAsync(string, EntityType, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            EntityType entityType = new EntityType();
            string entityTypeId = "";
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = await featurestoreServiceClient.CreateEntityTypeAsync(parent, entityType, entityTypeId);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityType</summary>
        public void CreateEntityType2ResourceNames()
        {
            // Snippet: CreateEntityType(FeaturestoreName, EntityType, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName parent = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            EntityType entityType = new EntityType();
            string entityTypeId = "";
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = featurestoreServiceClient.CreateEntityType(parent, entityType, entityTypeId);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntityTypeAsync</summary>
        public async Task CreateEntityType2ResourceNamesAsync()
        {
            // Snippet: CreateEntityTypeAsync(FeaturestoreName, EntityType, string, CallSettings)
            // Additional: CreateEntityTypeAsync(FeaturestoreName, EntityType, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName parent = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            EntityType entityType = new EntityType();
            string entityTypeId = "";
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = await featurestoreServiceClient.CreateEntityTypeAsync(parent, entityType, entityTypeId);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityTypeRequestObject()
        {
            // Snippet: GetEntityType(GetEntityTypeRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            // Make the request
            EntityType response = featurestoreServiceClient.GetEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeRequestObjectAsync()
        {
            // Snippet: GetEntityTypeAsync(GetEntityTypeRequest, CallSettings)
            // Additional: GetEntityTypeAsync(GetEntityTypeRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEntityTypeRequest request = new GetEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
            };
            // Make the request
            EntityType response = await featurestoreServiceClient.GetEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityType()
        {
            // Snippet: GetEntityType(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            EntityType response = featurestoreServiceClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeAsync()
        {
            // Snippet: GetEntityTypeAsync(string, CallSettings)
            // Additional: GetEntityTypeAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            EntityType response = await featurestoreServiceClient.GetEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityType</summary>
        public void GetEntityTypeResourceNames()
        {
            // Snippet: GetEntityType(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = featurestoreServiceClient.GetEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityTypeAsync</summary>
        public async Task GetEntityTypeResourceNamesAsync()
        {
            // Snippet: GetEntityTypeAsync(EntityTypeName, CallSettings)
            // Additional: GetEntityTypeAsync(EntityTypeName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            EntityType response = await featurestoreServiceClient.GetEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypesRequestObject()
        {
            // Snippet: ListEntityTypes(ListEntityTypesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = featurestoreServiceClient.ListEntityTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesRequestObjectAsync()
        {
            // Snippet: ListEntityTypesAsync(ListEntityTypesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = featurestoreServiceClient.ListEntityTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypes()
        {
            // Snippet: ListEntityTypes(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = featurestoreServiceClient.ListEntityTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesAsync()
        {
            // Snippet: ListEntityTypesAsync(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = featurestoreServiceClient.ListEntityTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypes</summary>
        public void ListEntityTypesResourceNames()
        {
            // Snippet: ListEntityTypes(FeaturestoreName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName parent = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = featurestoreServiceClient.ListEntityTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityTypesAsync</summary>
        public async Task ListEntityTypesResourceNamesAsync()
        {
            // Snippet: ListEntityTypesAsync(FeaturestoreName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName parent = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> response = featurestoreServiceClient.ListEntityTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityTypeRequestObject()
        {
            // Snippet: UpdateEntityType(UpdateEntityTypeRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntityType response = featurestoreServiceClient.UpdateEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityTypeRequestObjectAsync()
        {
            // Snippet: UpdateEntityTypeAsync(UpdateEntityTypeRequest, CallSettings)
            // Additional: UpdateEntityTypeAsync(UpdateEntityTypeRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntityTypeRequest request = new UpdateEntityTypeRequest
            {
                EntityType = new EntityType(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntityType response = await featurestoreServiceClient.UpdateEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityType</summary>
        public void UpdateEntityType()
        {
            // Snippet: UpdateEntityType(EntityType, FieldMask, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntityType response = featurestoreServiceClient.UpdateEntityType(entityType, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntityTypeAsync</summary>
        public async Task UpdateEntityTypeAsync()
        {
            // Snippet: UpdateEntityTypeAsync(EntityType, FieldMask, CallSettings)
            // Additional: UpdateEntityTypeAsync(EntityType, FieldMask, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityType entityType = new EntityType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntityType response = await featurestoreServiceClient.UpdateEntityTypeAsync(entityType, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityTypeRequestObject()
        {
            // Snippet: DeleteEntityType(DeleteEntityTypeRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteEntityType(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityTypeRequestObjectAsync()
        {
            // Snippet: DeleteEntityTypeAsync(DeleteEntityTypeRequest, CallSettings)
            // Additional: DeleteEntityTypeAsync(DeleteEntityTypeRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntityTypeRequest request = new DeleteEntityTypeRequest
            {
                EntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteEntityTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType1()
        {
            // Snippet: DeleteEntityType(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteEntityType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityType1Async()
        {
            // Snippet: DeleteEntityTypeAsync(string, CallSettings)
            // Additional: DeleteEntityTypeAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteEntityTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType1ResourceNames()
        {
            // Snippet: DeleteEntityType(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteEntityType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityType1ResourceNamesAsync()
        {
            // Snippet: DeleteEntityTypeAsync(EntityTypeName, CallSettings)
            // Additional: DeleteEntityTypeAsync(EntityTypeName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteEntityTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType2()
        {
            // Snippet: DeleteEntityType(string, bool, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteEntityType(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityType2Async()
        {
            // Snippet: DeleteEntityTypeAsync(string, bool, CallSettings)
            // Additional: DeleteEntityTypeAsync(string, bool, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteEntityTypeAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityType</summary>
        public void DeleteEntityType2ResourceNames()
        {
            // Snippet: DeleteEntityType(EntityTypeName, bool, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteEntityType(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityTypeAsync</summary>
        public async Task DeleteEntityType2ResourceNamesAsync()
        {
            // Snippet: DeleteEntityTypeAsync(EntityTypeName, bool, CallSettings)
            // Additional: DeleteEntityTypeAsync(EntityTypeName, bool, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName name = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            bool force = false;
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteEntityTypeAsync(name, force);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteEntityTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeatureRequestObject()
        {
            // Snippet: CreateFeature(CreateFeatureRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            CreateFeatureRequest request = new CreateFeatureRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Feature = new Feature(),
                FeatureId = "",
            };
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureRequestObjectAsync()
        {
            // Snippet: CreateFeatureAsync(CreateFeatureRequest, CallSettings)
            // Additional: CreateFeatureAsync(CreateFeatureRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureRequest request = new CreateFeatureRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Feature = new Feature(),
                FeatureId = "",
            };
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature1()
        {
            // Snippet: CreateFeature(string, Feature, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            Feature feature = new Feature();
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(parent, feature);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeature1Async()
        {
            // Snippet: CreateFeatureAsync(string, Feature, CallSettings)
            // Additional: CreateFeatureAsync(string, Feature, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            Feature feature = new Feature();
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(parent, feature);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature1ResourceNames1()
        {
            // Snippet: CreateFeature(EntityTypeName, Feature, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            Feature feature = new Feature();
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(parent, feature);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeature1ResourceNames1Async()
        {
            // Snippet: CreateFeatureAsync(EntityTypeName, Feature, CallSettings)
            // Additional: CreateFeatureAsync(EntityTypeName, Feature, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            Feature feature = new Feature();
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(parent, feature);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature1ResourceNames2()
        {
            // Snippet: CreateFeature(FeatureGroupName, Feature, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            Feature feature = new Feature();
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(parent, feature);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeature1ResourceNames2Async()
        {
            // Snippet: CreateFeatureAsync(FeatureGroupName, Feature, CallSettings)
            // Additional: CreateFeatureAsync(FeatureGroupName, Feature, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            Feature feature = new Feature();
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(parent, feature);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature2()
        {
            // Snippet: CreateFeature(string, Feature, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeature2Async()
        {
            // Snippet: CreateFeatureAsync(string, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(string, Feature, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature2ResourceNames1()
        {
            // Snippet: CreateFeature(EntityTypeName, Feature, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeature2ResourceNames1Async()
        {
            // Snippet: CreateFeatureAsync(EntityTypeName, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(EntityTypeName, Feature, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature2ResourceNames2()
        {
            // Snippet: CreateFeature(FeatureGroupName, Feature, string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = featurestoreServiceClient.CreateFeature(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeature2ResourceNames2Async()
        {
            // Snippet: CreateFeatureAsync(FeatureGroupName, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(FeatureGroupName, Feature, string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            Feature feature = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, CreateFeatureOperationMetadata> response = await featurestoreServiceClient.CreateFeatureAsync(parent, feature, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, CreateFeatureOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, CreateFeatureOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeaturesRequestObject()
        {
            // Snippet: BatchCreateFeatures(BatchCreateFeaturesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateFeaturesRequest request = new BatchCreateFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Requests =
                {
                    new CreateFeatureRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featurestoreServiceClient.BatchCreateFeatures(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesRequestObjectAsync()
        {
            // Snippet: BatchCreateFeaturesAsync(BatchCreateFeaturesRequest, CallSettings)
            // Additional: BatchCreateFeaturesAsync(BatchCreateFeaturesRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateFeaturesRequest request = new BatchCreateFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Requests =
                {
                    new CreateFeatureRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featurestoreServiceClient.BatchCreateFeaturesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeatures()
        {
            // Snippet: BatchCreateFeatures(string, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featurestoreServiceClient.BatchCreateFeatures(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesAsync()
        {
            // Snippet: BatchCreateFeaturesAsync(string, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Additional: BatchCreateFeaturesAsync(string, IEnumerable<CreateFeatureRequest>, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featurestoreServiceClient.BatchCreateFeaturesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeaturesResourceNames1()
        {
            // Snippet: BatchCreateFeatures(EntityTypeName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featurestoreServiceClient.BatchCreateFeatures(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesResourceNames1Async()
        {
            // Snippet: BatchCreateFeaturesAsync(EntityTypeName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Additional: BatchCreateFeaturesAsync(EntityTypeName, IEnumerable<CreateFeatureRequest>, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featurestoreServiceClient.BatchCreateFeaturesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeatures</summary>
        public void BatchCreateFeaturesResourceNames2()
        {
            // Snippet: BatchCreateFeatures(FeatureGroupName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = featurestoreServiceClient.BatchCreateFeatures(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchCreateFeatures(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateFeaturesAsync</summary>
        public async Task BatchCreateFeaturesResourceNames2Async()
        {
            // Snippet: BatchCreateFeaturesAsync(FeatureGroupName, IEnumerable<CreateFeatureRequest>, CallSettings)
            // Additional: BatchCreateFeaturesAsync(FeatureGroupName, IEnumerable<CreateFeatureRequest>, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            IEnumerable<CreateFeatureRequest> requests = new CreateFeatureRequest[]
            {
                new CreateFeatureRequest(),
            };
            // Make the request
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> response = await featurestoreServiceClient.BatchCreateFeaturesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateFeaturesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateFeaturesResponse, BatchCreateFeaturesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchCreateFeaturesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateFeaturesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeatureRequestObject()
        {
            // Snippet: GetFeature(GetFeatureRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                FeatureStatsAndAnomalySpec = new FeatureStatsAndAnomalySpec(),
            };
            // Make the request
            Feature response = featurestoreServiceClient.GetFeature(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureRequestObjectAsync()
        {
            // Snippet: GetFeatureAsync(GetFeatureRequest, CallSettings)
            // Additional: GetFeatureAsync(GetFeatureRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
                FeatureStatsAndAnomalySpec = new FeatureStatsAndAnomalySpec(),
            };
            // Make the request
            Feature response = await featurestoreServiceClient.GetFeatureAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeature()
        {
            // Snippet: GetFeature(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Feature response = featurestoreServiceClient.GetFeature(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureAsync()
        {
            // Snippet: GetFeatureAsync(string, CallSettings)
            // Additional: GetFeatureAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Feature response = await featurestoreServiceClient.GetFeatureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeatureResourceNames()
        {
            // Snippet: GetFeature(FeatureName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Feature response = featurestoreServiceClient.GetFeature(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureResourceNamesAsync()
        {
            // Snippet: GetFeatureAsync(FeatureName, CallSettings)
            // Additional: GetFeatureAsync(FeatureName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Feature response = await featurestoreServiceClient.GetFeatureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesRequestObject()
        {
            // Snippet: ListFeatures(ListFeaturesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
                LatestStatsCount = 0,
            };
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeatures(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesRequestObjectAsync()
        {
            // Snippet: ListFeaturesAsync(ListFeaturesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
                LatestStatsCount = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeaturesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeatures()
        {
            // Snippet: ListFeatures(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesAsync()
        {
            // Snippet: ListFeaturesAsync(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesResourceNames1()
        {
            // Snippet: ListFeatures(EntityTypeName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesResourceNames1Async()
        {
            // Snippet: ListFeaturesAsync(EntityTypeName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName parent = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesResourceNames2()
        {
            // Snippet: ListFeatures(FeatureGroupName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesResourceNames2Async()
        {
            // Snippet: ListFeaturesAsync(FeatureGroupName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureGroupName parent = FeatureGroupName.FromProjectLocationFeatureGroup("[PROJECT]", "[LOCATION]", "[FEATURE_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = featurestoreServiceClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeatureRequestObject()
        {
            // Snippet: UpdateFeature(UpdateFeatureRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feature response = featurestoreServiceClient.UpdateFeature(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureRequestObjectAsync()
        {
            // Snippet: UpdateFeatureAsync(UpdateFeatureRequest, CallSettings)
            // Additional: UpdateFeatureAsync(UpdateFeatureRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                Feature = new Feature(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feature response = await featurestoreServiceClient.UpdateFeatureAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeature()
        {
            // Snippet: UpdateFeature(Feature, FieldMask, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            Feature feature = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Feature response = featurestoreServiceClient.UpdateFeature(feature, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureAsync()
        {
            // Snippet: UpdateFeatureAsync(Feature, FieldMask, CallSettings)
            // Additional: UpdateFeatureAsync(Feature, FieldMask, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            Feature feature = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Feature response = await featurestoreServiceClient.UpdateFeatureAsync(feature, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeatureRequestObject()
        {
            // Snippet: DeleteFeature(DeleteFeatureRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureRequest request = new DeleteFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureRequestObjectAsync()
        {
            // Snippet: DeleteFeatureAsync(DeleteFeatureRequest, CallSettings)
            // Additional: DeleteFeatureAsync(DeleteFeatureRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureRequest request = new DeleteFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeature()
        {
            // Snippet: DeleteFeature(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeature(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureAsync()
        {
            // Snippet: DeleteFeatureAsync(string, CallSettings)
            // Additional: DeleteFeatureAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]/features/[FEATURE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeatureResourceNames()
        {
            // Snippet: DeleteFeature(FeatureName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = featurestoreServiceClient.DeleteFeature(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureResourceNamesAsync()
        {
            // Snippet: DeleteFeatureAsync(FeatureName, CallSettings)
            // Additional: DeleteFeatureAsync(FeatureName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeaturestoreEntityTypeFeature("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]", "[FEATURE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFeatureValues</summary>
        public void ImportFeatureValuesRequestObject()
        {
            // Snippet: ImportFeatureValues(ImportFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            ImportFeatureValuesRequest request = new ImportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                AvroSource = new AvroSource(),
                EntityIdField = "",
                FeatureTimeField = "",
                FeatureSpecs =
                {
                    new ImportFeatureValuesRequest.Types.FeatureSpec(),
                },
                DisableOnlineServing = false,
                WorkerCount = 0,
                DisableIngestionAnalysis = false,
            };
            // Make the request
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> response = featurestoreServiceClient.ImportFeatureValues(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceImportFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFeatureValuesAsync</summary>
        public async Task ImportFeatureValuesRequestObjectAsync()
        {
            // Snippet: ImportFeatureValuesAsync(ImportFeatureValuesRequest, CallSettings)
            // Additional: ImportFeatureValuesAsync(ImportFeatureValuesRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportFeatureValuesRequest request = new ImportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                AvroSource = new AvroSource(),
                EntityIdField = "",
                FeatureTimeField = "",
                FeatureSpecs =
                {
                    new ImportFeatureValuesRequest.Types.FeatureSpec(),
                },
                DisableOnlineServing = false,
                WorkerCount = 0,
                DisableIngestionAnalysis = false,
            };
            // Make the request
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> response = await featurestoreServiceClient.ImportFeatureValuesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceImportFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFeatureValues</summary>
        public void ImportFeatureValues()
        {
            // Snippet: ImportFeatureValues(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> response = featurestoreServiceClient.ImportFeatureValues(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceImportFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFeatureValuesAsync</summary>
        public async Task ImportFeatureValuesAsync()
        {
            // Snippet: ImportFeatureValuesAsync(string, CallSettings)
            // Additional: ImportFeatureValuesAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> response = await featurestoreServiceClient.ImportFeatureValuesAsync(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceImportFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFeatureValues</summary>
        public void ImportFeatureValuesResourceNames()
        {
            // Snippet: ImportFeatureValues(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> response = featurestoreServiceClient.ImportFeatureValues(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceImportFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportFeatureValuesAsync</summary>
        public async Task ImportFeatureValuesResourceNamesAsync()
        {
            // Snippet: ImportFeatureValuesAsync(EntityTypeName, CallSettings)
            // Additional: ImportFeatureValuesAsync(EntityTypeName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> response = await featurestoreServiceClient.ImportFeatureValuesAsync(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportFeatureValuesResponse, ImportFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceImportFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadFeatureValues</summary>
        public void BatchReadFeatureValuesRequestObject()
        {
            // Snippet: BatchReadFeatureValues(BatchReadFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            BatchReadFeatureValuesRequest request = new BatchReadFeatureValuesRequest
            {
                FeaturestoreAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CsvReadInstances = new CsvSource(),
                Destination = new FeatureValueDestination(),
                EntityTypeSpecs =
                {
                    new BatchReadFeatureValuesRequest.Types.EntityTypeSpec(),
                },
                PassThroughFields =
                {
                    new BatchReadFeatureValuesRequest.Types.PassThroughField(),
                },
                StartTime = new Timestamp(),
            };
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = featurestoreServiceClient.BatchReadFeatureValues(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchReadFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadFeatureValuesAsync</summary>
        public async Task BatchReadFeatureValuesRequestObjectAsync()
        {
            // Snippet: BatchReadFeatureValuesAsync(BatchReadFeatureValuesRequest, CallSettings)
            // Additional: BatchReadFeatureValuesAsync(BatchReadFeatureValuesRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchReadFeatureValuesRequest request = new BatchReadFeatureValuesRequest
            {
                FeaturestoreAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                CsvReadInstances = new CsvSource(),
                Destination = new FeatureValueDestination(),
                EntityTypeSpecs =
                {
                    new BatchReadFeatureValuesRequest.Types.EntityTypeSpec(),
                },
                PassThroughFields =
                {
                    new BatchReadFeatureValuesRequest.Types.PassThroughField(),
                },
                StartTime = new Timestamp(),
            };
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = await featurestoreServiceClient.BatchReadFeatureValuesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchReadFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadFeatureValues</summary>
        public void BatchReadFeatureValues()
        {
            // Snippet: BatchReadFeatureValues(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string featurestore = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = featurestoreServiceClient.BatchReadFeatureValues(featurestore);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchReadFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadFeatureValuesAsync</summary>
        public async Task BatchReadFeatureValuesAsync()
        {
            // Snippet: BatchReadFeatureValuesAsync(string, CallSettings)
            // Additional: BatchReadFeatureValuesAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string featurestore = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]";
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = await featurestoreServiceClient.BatchReadFeatureValuesAsync(featurestore);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchReadFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadFeatureValues</summary>
        public void BatchReadFeatureValuesResourceNames()
        {
            // Snippet: BatchReadFeatureValues(FeaturestoreName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            FeaturestoreName featurestore = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = featurestoreServiceClient.BatchReadFeatureValues(featurestore);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceBatchReadFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadFeatureValuesAsync</summary>
        public async Task BatchReadFeatureValuesResourceNamesAsync()
        {
            // Snippet: BatchReadFeatureValuesAsync(FeaturestoreName, CallSettings)
            // Additional: BatchReadFeatureValuesAsync(FeaturestoreName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturestoreName featurestore = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]");
            // Make the request
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> response = await featurestoreServiceClient.BatchReadFeatureValuesAsync(featurestore);

            // Poll until the returned long-running operation is complete
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchReadFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchReadFeatureValuesResponse, BatchReadFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceBatchReadFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchReadFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFeatureValues</summary>
        public void ExportFeatureValuesRequestObject()
        {
            // Snippet: ExportFeatureValues(ExportFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            ExportFeatureValuesRequest request = new ExportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                SnapshotExport = new ExportFeatureValuesRequest.Types.SnapshotExport(),
                Destination = new FeatureValueDestination(),
                FeatureSelector = new FeatureSelector(),
                Settings =
                {
                    new DestinationFeatureSetting(),
                },
            };
            // Make the request
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> response = featurestoreServiceClient.ExportFeatureValues(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceExportFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFeatureValuesAsync</summary>
        public async Task ExportFeatureValuesRequestObjectAsync()
        {
            // Snippet: ExportFeatureValuesAsync(ExportFeatureValuesRequest, CallSettings)
            // Additional: ExportFeatureValuesAsync(ExportFeatureValuesRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportFeatureValuesRequest request = new ExportFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                SnapshotExport = new ExportFeatureValuesRequest.Types.SnapshotExport(),
                Destination = new FeatureValueDestination(),
                FeatureSelector = new FeatureSelector(),
                Settings =
                {
                    new DestinationFeatureSetting(),
                },
            };
            // Make the request
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> response = await featurestoreServiceClient.ExportFeatureValuesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceExportFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFeatureValues</summary>
        public void ExportFeatureValues()
        {
            // Snippet: ExportFeatureValues(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> response = featurestoreServiceClient.ExportFeatureValues(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceExportFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFeatureValuesAsync</summary>
        public async Task ExportFeatureValuesAsync()
        {
            // Snippet: ExportFeatureValuesAsync(string, CallSettings)
            // Additional: ExportFeatureValuesAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> response = await featurestoreServiceClient.ExportFeatureValuesAsync(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceExportFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFeatureValues</summary>
        public void ExportFeatureValuesResourceNames()
        {
            // Snippet: ExportFeatureValues(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> response = featurestoreServiceClient.ExportFeatureValues(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceExportFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportFeatureValuesAsync</summary>
        public async Task ExportFeatureValuesResourceNamesAsync()
        {
            // Snippet: ExportFeatureValuesAsync(EntityTypeName, CallSettings)
            // Additional: ExportFeatureValuesAsync(EntityTypeName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> response = await featurestoreServiceClient.ExportFeatureValuesAsync(entityType);

            // Poll until the returned long-running operation is complete
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportFeatureValuesResponse, ExportFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceExportFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureValues</summary>
        public void DeleteFeatureValuesRequestObject()
        {
            // Snippet: DeleteFeatureValues(DeleteFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeatureValuesRequest request = new DeleteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                SelectEntity = new DeleteFeatureValuesRequest.Types.SelectEntity(),
            };
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = featurestoreServiceClient.DeleteFeatureValues(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureValuesAsync</summary>
        public async Task DeleteFeatureValuesRequestObjectAsync()
        {
            // Snippet: DeleteFeatureValuesAsync(DeleteFeatureValuesRequest, CallSettings)
            // Additional: DeleteFeatureValuesAsync(DeleteFeatureValuesRequest, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureValuesRequest request = new DeleteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                SelectEntity = new DeleteFeatureValuesRequest.Types.SelectEntity(),
            };
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureValuesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureValues</summary>
        public void DeleteFeatureValues()
        {
            // Snippet: DeleteFeatureValues(string, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = featurestoreServiceClient.DeleteFeatureValues(entityType);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureValuesAsync</summary>
        public async Task DeleteFeatureValuesAsync()
        {
            // Snippet: DeleteFeatureValuesAsync(string, CallSettings)
            // Additional: DeleteFeatureValuesAsync(string, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureValuesAsync(entityType);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureValues</summary>
        public void DeleteFeatureValuesResourceNames()
        {
            // Snippet: DeleteFeatureValues(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = featurestoreServiceClient.DeleteFeatureValues(entityType);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceDeleteFeatureValues(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureValuesAsync</summary>
        public async Task DeleteFeatureValuesResourceNamesAsync()
        {
            // Snippet: DeleteFeatureValuesAsync(EntityTypeName, CallSettings)
            // Additional: DeleteFeatureValuesAsync(EntityTypeName, CancellationToken)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureValuesAsync(entityType);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SearchFeatures</summary>
        public void SearchFeaturesRequestObject()
        {
            // Snippet: SearchFeatures(SearchFeaturesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeatures(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeaturesAsync</summary>
        public async Task SearchFeaturesRequestObjectAsync()
        {
            // Snippet: SearchFeaturesAsync(SearchFeaturesRequest, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchFeaturesRequest request = new SearchFeaturesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeaturesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeatures</summary>
        public void SearchFeatures1()
        {
            // Snippet: SearchFeatures(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeatures(location);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeaturesAsync</summary>
        public async Task SearchFeatures1Async()
        {
            // Snippet: SearchFeaturesAsync(string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeaturesAsync(location);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeatures</summary>
        public void SearchFeatures1ResourceNames()
        {
            // Snippet: SearchFeatures(LocationName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeatures(location);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeaturesAsync</summary>
        public async Task SearchFeatures1ResourceNamesAsync()
        {
            // Snippet: SearchFeaturesAsync(LocationName, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeaturesAsync(location);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeatures</summary>
        public void SearchFeatures2()
        {
            // Snippet: SearchFeatures(string, string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeatures(location, query: query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeaturesAsync</summary>
        public async Task SearchFeatures2Async()
        {
            // Snippet: SearchFeaturesAsync(string, string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeaturesAsync(location, query: query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeatures</summary>
        public void SearchFeatures2ResourceNames()
        {
            // Snippet: SearchFeatures(LocationName, string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeatures(location, query: query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchFeaturesAsync</summary>
        public async Task SearchFeatures2ResourceNamesAsync()
        {
            // Snippet: SearchFeaturesAsync(LocationName, string, string, int?, CallSettings)
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchFeaturesResponse, Feature> response = featurestoreServiceClient.SearchFeaturesAsync(location, query: query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Feature item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchFeaturesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
