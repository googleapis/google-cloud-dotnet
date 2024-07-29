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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelMonitoringServiceClientSnippets
    {
        /// <summary>Snippet for CreateModelMonitor</summary>
        public void CreateModelMonitorRequestObject()
        {
            // Snippet: CreateModelMonitor(CreateModelMonitorRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            CreateModelMonitorRequest request = new CreateModelMonitorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelMonitor = new ModelMonitor(),
                ModelMonitorId = "",
            };
            // Make the request
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> response = modelMonitoringServiceClient.CreateModelMonitor(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceCreateModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitorAsync</summary>
        public async Task CreateModelMonitorRequestObjectAsync()
        {
            // Snippet: CreateModelMonitorAsync(CreateModelMonitorRequest, CallSettings)
            // Additional: CreateModelMonitorAsync(CreateModelMonitorRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelMonitorRequest request = new CreateModelMonitorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ModelMonitor = new ModelMonitor(),
                ModelMonitorId = "",
            };
            // Make the request
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> response = await modelMonitoringServiceClient.CreateModelMonitorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceCreateModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitor</summary>
        public void CreateModelMonitor()
        {
            // Snippet: CreateModelMonitor(string, ModelMonitor, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ModelMonitor modelMonitor = new ModelMonitor();
            // Make the request
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> response = modelMonitoringServiceClient.CreateModelMonitor(parent, modelMonitor);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceCreateModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitorAsync</summary>
        public async Task CreateModelMonitorAsync()
        {
            // Snippet: CreateModelMonitorAsync(string, ModelMonitor, CallSettings)
            // Additional: CreateModelMonitorAsync(string, ModelMonitor, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ModelMonitor modelMonitor = new ModelMonitor();
            // Make the request
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> response = await modelMonitoringServiceClient.CreateModelMonitorAsync(parent, modelMonitor);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceCreateModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitor</summary>
        public void CreateModelMonitorResourceNames()
        {
            // Snippet: CreateModelMonitor(LocationName, ModelMonitor, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ModelMonitor modelMonitor = new ModelMonitor();
            // Make the request
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> response = modelMonitoringServiceClient.CreateModelMonitor(parent, modelMonitor);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceCreateModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitorAsync</summary>
        public async Task CreateModelMonitorResourceNamesAsync()
        {
            // Snippet: CreateModelMonitorAsync(LocationName, ModelMonitor, CallSettings)
            // Additional: CreateModelMonitorAsync(LocationName, ModelMonitor, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ModelMonitor modelMonitor = new ModelMonitor();
            // Make the request
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> response = await modelMonitoringServiceClient.CreateModelMonitorAsync(parent, modelMonitor);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, CreateModelMonitorOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceCreateModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelMonitor</summary>
        public void UpdateModelMonitorRequestObject()
        {
            // Snippet: UpdateModelMonitor(UpdateModelMonitorRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            UpdateModelMonitorRequest request = new UpdateModelMonitorRequest
            {
                ModelMonitor = new ModelMonitor(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> response = modelMonitoringServiceClient.UpdateModelMonitor(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceUpdateModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelMonitorAsync</summary>
        public async Task UpdateModelMonitorRequestObjectAsync()
        {
            // Snippet: UpdateModelMonitorAsync(UpdateModelMonitorRequest, CallSettings)
            // Additional: UpdateModelMonitorAsync(UpdateModelMonitorRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateModelMonitorRequest request = new UpdateModelMonitorRequest
            {
                ModelMonitor = new ModelMonitor(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> response = await modelMonitoringServiceClient.UpdateModelMonitorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceUpdateModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelMonitor</summary>
        public void UpdateModelMonitor()
        {
            // Snippet: UpdateModelMonitor(ModelMonitor, FieldMask, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitor modelMonitor = new ModelMonitor();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> response = modelMonitoringServiceClient.UpdateModelMonitor(modelMonitor, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceUpdateModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelMonitorAsync</summary>
        public async Task UpdateModelMonitorAsync()
        {
            // Snippet: UpdateModelMonitorAsync(ModelMonitor, FieldMask, CallSettings)
            // Additional: UpdateModelMonitorAsync(ModelMonitor, FieldMask, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitor modelMonitor = new ModelMonitor();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> response = await modelMonitoringServiceClient.UpdateModelMonitorAsync(modelMonitor, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ModelMonitor result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceUpdateModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelMonitor retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitor</summary>
        public void GetModelMonitorRequestObject()
        {
            // Snippet: GetModelMonitor(GetModelMonitorRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            GetModelMonitorRequest request = new GetModelMonitorRequest
            {
                ModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
            };
            // Make the request
            ModelMonitor response = modelMonitoringServiceClient.GetModelMonitor(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitorAsync</summary>
        public async Task GetModelMonitorRequestObjectAsync()
        {
            // Snippet: GetModelMonitorAsync(GetModelMonitorRequest, CallSettings)
            // Additional: GetModelMonitorAsync(GetModelMonitorRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelMonitorRequest request = new GetModelMonitorRequest
            {
                ModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
            };
            // Make the request
            ModelMonitor response = await modelMonitoringServiceClient.GetModelMonitorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitor</summary>
        public void GetModelMonitor()
        {
            // Snippet: GetModelMonitor(string, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            ModelMonitor response = modelMonitoringServiceClient.GetModelMonitor(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitorAsync</summary>
        public async Task GetModelMonitorAsync()
        {
            // Snippet: GetModelMonitorAsync(string, CallSettings)
            // Additional: GetModelMonitorAsync(string, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            ModelMonitor response = await modelMonitoringServiceClient.GetModelMonitorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitor</summary>
        public void GetModelMonitorResourceNames()
        {
            // Snippet: GetModelMonitor(ModelMonitorName, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitorName name = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            ModelMonitor response = modelMonitoringServiceClient.GetModelMonitor(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitorAsync</summary>
        public async Task GetModelMonitorResourceNamesAsync()
        {
            // Snippet: GetModelMonitorAsync(ModelMonitorName, CallSettings)
            // Additional: GetModelMonitorAsync(ModelMonitorName, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitorName name = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            ModelMonitor response = await modelMonitoringServiceClient.GetModelMonitorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitors</summary>
        public void ListModelMonitorsRequestObject()
        {
            // Snippet: ListModelMonitors(ListModelMonitorsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ListModelMonitorsRequest request = new ListModelMonitorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> response = modelMonitoringServiceClient.ListModelMonitors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelMonitorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitorsAsync</summary>
        public async Task ListModelMonitorsRequestObjectAsync()
        {
            // Snippet: ListModelMonitorsAsync(ListModelMonitorsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelMonitorsRequest request = new ListModelMonitorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> response = modelMonitoringServiceClient.ListModelMonitorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelMonitorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitors</summary>
        public void ListModelMonitors()
        {
            // Snippet: ListModelMonitors(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> response = modelMonitoringServiceClient.ListModelMonitors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelMonitorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitorsAsync</summary>
        public async Task ListModelMonitorsAsync()
        {
            // Snippet: ListModelMonitorsAsync(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> response = modelMonitoringServiceClient.ListModelMonitorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelMonitorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitors</summary>
        public void ListModelMonitorsResourceNames()
        {
            // Snippet: ListModelMonitors(LocationName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> response = modelMonitoringServiceClient.ListModelMonitors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelMonitorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitorsAsync</summary>
        public async Task ListModelMonitorsResourceNamesAsync()
        {
            // Snippet: ListModelMonitorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> response = modelMonitoringServiceClient.ListModelMonitorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelMonitorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitor</summary>
        public void DeleteModelMonitorRequestObject()
        {
            // Snippet: DeleteModelMonitor(DeleteModelMonitorRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelMonitorRequest request = new DeleteModelMonitorRequest
            {
                ModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelMonitoringServiceClient.DeleteModelMonitor(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceDeleteModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitorAsync</summary>
        public async Task DeleteModelMonitorRequestObjectAsync()
        {
            // Snippet: DeleteModelMonitorAsync(DeleteModelMonitorRequest, CallSettings)
            // Additional: DeleteModelMonitorAsync(DeleteModelMonitorRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelMonitorRequest request = new DeleteModelMonitorRequest
            {
                ModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelMonitoringServiceClient.DeleteModelMonitorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceDeleteModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitor</summary>
        public void DeleteModelMonitor()
        {
            // Snippet: DeleteModelMonitor(string, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelMonitoringServiceClient.DeleteModelMonitor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceDeleteModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitorAsync</summary>
        public async Task DeleteModelMonitorAsync()
        {
            // Snippet: DeleteModelMonitorAsync(string, CallSettings)
            // Additional: DeleteModelMonitorAsync(string, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelMonitoringServiceClient.DeleteModelMonitorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceDeleteModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitor</summary>
        public void DeleteModelMonitorResourceNames()
        {
            // Snippet: DeleteModelMonitor(ModelMonitorName, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitorName name = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelMonitoringServiceClient.DeleteModelMonitor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceDeleteModelMonitor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitorAsync</summary>
        public async Task DeleteModelMonitorResourceNamesAsync()
        {
            // Snippet: DeleteModelMonitorAsync(ModelMonitorName, CallSettings)
            // Additional: DeleteModelMonitorAsync(ModelMonitorName, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitorName name = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelMonitoringServiceClient.DeleteModelMonitorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceDeleteModelMonitorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitoringJob</summary>
        public void CreateModelMonitoringJobRequestObject()
        {
            // Snippet: CreateModelMonitoringJob(CreateModelMonitoringJobRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            CreateModelMonitoringJobRequest request = new CreateModelMonitoringJobRequest
            {
                ParentAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                ModelMonitoringJob = new ModelMonitoringJob(),
                ModelMonitoringJobId = "",
            };
            // Make the request
            ModelMonitoringJob response = modelMonitoringServiceClient.CreateModelMonitoringJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitoringJobAsync</summary>
        public async Task CreateModelMonitoringJobRequestObjectAsync()
        {
            // Snippet: CreateModelMonitoringJobAsync(CreateModelMonitoringJobRequest, CallSettings)
            // Additional: CreateModelMonitoringJobAsync(CreateModelMonitoringJobRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelMonitoringJobRequest request = new CreateModelMonitoringJobRequest
            {
                ParentAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                ModelMonitoringJob = new ModelMonitoringJob(),
                ModelMonitoringJobId = "",
            };
            // Make the request
            ModelMonitoringJob response = await modelMonitoringServiceClient.CreateModelMonitoringJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitoringJob</summary>
        public void CreateModelMonitoringJob()
        {
            // Snippet: CreateModelMonitoringJob(string, ModelMonitoringJob, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            ModelMonitoringJob modelMonitoringJob = new ModelMonitoringJob();
            // Make the request
            ModelMonitoringJob response = modelMonitoringServiceClient.CreateModelMonitoringJob(parent, modelMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitoringJobAsync</summary>
        public async Task CreateModelMonitoringJobAsync()
        {
            // Snippet: CreateModelMonitoringJobAsync(string, ModelMonitoringJob, CallSettings)
            // Additional: CreateModelMonitoringJobAsync(string, ModelMonitoringJob, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            ModelMonitoringJob modelMonitoringJob = new ModelMonitoringJob();
            // Make the request
            ModelMonitoringJob response = await modelMonitoringServiceClient.CreateModelMonitoringJobAsync(parent, modelMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitoringJob</summary>
        public void CreateModelMonitoringJobResourceNames()
        {
            // Snippet: CreateModelMonitoringJob(ModelMonitorName, ModelMonitoringJob, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitorName parent = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            ModelMonitoringJob modelMonitoringJob = new ModelMonitoringJob();
            // Make the request
            ModelMonitoringJob response = modelMonitoringServiceClient.CreateModelMonitoringJob(parent, modelMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for CreateModelMonitoringJobAsync</summary>
        public async Task CreateModelMonitoringJobResourceNamesAsync()
        {
            // Snippet: CreateModelMonitoringJobAsync(ModelMonitorName, ModelMonitoringJob, CallSettings)
            // Additional: CreateModelMonitoringJobAsync(ModelMonitorName, ModelMonitoringJob, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitorName parent = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            ModelMonitoringJob modelMonitoringJob = new ModelMonitoringJob();
            // Make the request
            ModelMonitoringJob response = await modelMonitoringServiceClient.CreateModelMonitoringJobAsync(parent, modelMonitoringJob);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitoringJob</summary>
        public void GetModelMonitoringJobRequestObject()
        {
            // Snippet: GetModelMonitoringJob(GetModelMonitoringJobRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            GetModelMonitoringJobRequest request = new GetModelMonitoringJobRequest
            {
                ModelMonitoringJobName = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]"),
            };
            // Make the request
            ModelMonitoringJob response = modelMonitoringServiceClient.GetModelMonitoringJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitoringJobAsync</summary>
        public async Task GetModelMonitoringJobRequestObjectAsync()
        {
            // Snippet: GetModelMonitoringJobAsync(GetModelMonitoringJobRequest, CallSettings)
            // Additional: GetModelMonitoringJobAsync(GetModelMonitoringJobRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelMonitoringJobRequest request = new GetModelMonitoringJobRequest
            {
                ModelMonitoringJobName = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]"),
            };
            // Make the request
            ModelMonitoringJob response = await modelMonitoringServiceClient.GetModelMonitoringJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitoringJob</summary>
        public void GetModelMonitoringJob()
        {
            // Snippet: GetModelMonitoringJob(string, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]/modelMonitoringJobs/[MODEL_MONITORING_JOB]";
            // Make the request
            ModelMonitoringJob response = modelMonitoringServiceClient.GetModelMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitoringJobAsync</summary>
        public async Task GetModelMonitoringJobAsync()
        {
            // Snippet: GetModelMonitoringJobAsync(string, CallSettings)
            // Additional: GetModelMonitoringJobAsync(string, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]/modelMonitoringJobs/[MODEL_MONITORING_JOB]";
            // Make the request
            ModelMonitoringJob response = await modelMonitoringServiceClient.GetModelMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitoringJob</summary>
        public void GetModelMonitoringJobResourceNames()
        {
            // Snippet: GetModelMonitoringJob(ModelMonitoringJobName, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitoringJobName name = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]");
            // Make the request
            ModelMonitoringJob response = modelMonitoringServiceClient.GetModelMonitoringJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelMonitoringJobAsync</summary>
        public async Task GetModelMonitoringJobResourceNamesAsync()
        {
            // Snippet: GetModelMonitoringJobAsync(ModelMonitoringJobName, CallSettings)
            // Additional: GetModelMonitoringJobAsync(ModelMonitoringJobName, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitoringJobName name = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]");
            // Make the request
            ModelMonitoringJob response = await modelMonitoringServiceClient.GetModelMonitoringJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitoringJobs</summary>
        public void ListModelMonitoringJobsRequestObject()
        {
            // Snippet: ListModelMonitoringJobs(ListModelMonitoringJobsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ListModelMonitoringJobsRequest request = new ListModelMonitoringJobsRequest
            {
                ParentAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> response = modelMonitoringServiceClient.ListModelMonitoringJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelMonitoringJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitoringJobsAsync</summary>
        public async Task ListModelMonitoringJobsRequestObjectAsync()
        {
            // Snippet: ListModelMonitoringJobsAsync(ListModelMonitoringJobsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelMonitoringJobsRequest request = new ListModelMonitoringJobsRequest
            {
                ParentAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> response = modelMonitoringServiceClient.ListModelMonitoringJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelMonitoringJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitoringJobs</summary>
        public void ListModelMonitoringJobs()
        {
            // Snippet: ListModelMonitoringJobs(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> response = modelMonitoringServiceClient.ListModelMonitoringJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelMonitoringJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitoringJobsAsync</summary>
        public async Task ListModelMonitoringJobsAsync()
        {
            // Snippet: ListModelMonitoringJobsAsync(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> response = modelMonitoringServiceClient.ListModelMonitoringJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelMonitoringJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitoringJobs</summary>
        public void ListModelMonitoringJobsResourceNames()
        {
            // Snippet: ListModelMonitoringJobs(ModelMonitorName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitorName parent = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> response = modelMonitoringServiceClient.ListModelMonitoringJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelMonitoringJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelMonitoringJobsAsync</summary>
        public async Task ListModelMonitoringJobsResourceNamesAsync()
        {
            // Snippet: ListModelMonitoringJobsAsync(ModelMonitorName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitorName parent = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> response = modelMonitoringServiceClient.ListModelMonitoringJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelMonitoringJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitoringJob</summary>
        public void DeleteModelMonitoringJobRequestObject()
        {
            // Snippet: DeleteModelMonitoringJob(DeleteModelMonitoringJobRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            DeleteModelMonitoringJobRequest request = new DeleteModelMonitoringJobRequest
            {
                ModelMonitoringJobName = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelMonitoringServiceClient.DeleteModelMonitoringJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceDeleteModelMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitoringJobAsync</summary>
        public async Task DeleteModelMonitoringJobRequestObjectAsync()
        {
            // Snippet: DeleteModelMonitoringJobAsync(DeleteModelMonitoringJobRequest, CallSettings)
            // Additional: DeleteModelMonitoringJobAsync(DeleteModelMonitoringJobRequest, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelMonitoringJobRequest request = new DeleteModelMonitoringJobRequest
            {
                ModelMonitoringJobName = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelMonitoringServiceClient.DeleteModelMonitoringJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceDeleteModelMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitoringJob</summary>
        public void DeleteModelMonitoringJob()
        {
            // Snippet: DeleteModelMonitoringJob(string, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]/modelMonitoringJobs/[MODEL_MONITORING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelMonitoringServiceClient.DeleteModelMonitoringJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceDeleteModelMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitoringJobAsync</summary>
        public async Task DeleteModelMonitoringJobAsync()
        {
            // Snippet: DeleteModelMonitoringJobAsync(string, CallSettings)
            // Additional: DeleteModelMonitoringJobAsync(string, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]/modelMonitoringJobs/[MODEL_MONITORING_JOB]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelMonitoringServiceClient.DeleteModelMonitoringJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceDeleteModelMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitoringJob</summary>
        public void DeleteModelMonitoringJobResourceNames()
        {
            // Snippet: DeleteModelMonitoringJob(ModelMonitoringJobName, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitoringJobName name = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = modelMonitoringServiceClient.DeleteModelMonitoringJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = modelMonitoringServiceClient.PollOnceDeleteModelMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelMonitoringJobAsync</summary>
        public async Task DeleteModelMonitoringJobResourceNamesAsync()
        {
            // Snippet: DeleteModelMonitoringJobAsync(ModelMonitoringJobName, CallSettings)
            // Additional: DeleteModelMonitoringJobAsync(ModelMonitoringJobName, CancellationToken)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitoringJobName name = ModelMonitoringJobName.FromProjectLocationModelMonitorModelMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]", "[MODEL_MONITORING_JOB]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await modelMonitoringServiceClient.DeleteModelMonitoringJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await modelMonitoringServiceClient.PollOnceDeleteModelMonitoringJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringStats</summary>
        public void SearchModelMonitoringStatsRequestObject()
        {
            // Snippet: SearchModelMonitoringStats(SearchModelMonitoringStatsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            SearchModelMonitoringStatsRequest request = new SearchModelMonitoringStatsRequest
            {
                ModelMonitorAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                StatsFilter = new SearchModelMonitoringStatsFilter(),
                TimeInterval = new Interval(),
            };
            // Make the request
            PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> response = modelMonitoringServiceClient.SearchModelMonitoringStats(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelMonitoringStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringStatsAsync</summary>
        public async Task SearchModelMonitoringStatsRequestObjectAsync()
        {
            // Snippet: SearchModelMonitoringStatsAsync(SearchModelMonitoringStatsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchModelMonitoringStatsRequest request = new SearchModelMonitoringStatsRequest
            {
                ModelMonitorAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                StatsFilter = new SearchModelMonitoringStatsFilter(),
                TimeInterval = new Interval(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> response = modelMonitoringServiceClient.SearchModelMonitoringStatsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelMonitoringStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringStats</summary>
        public void SearchModelMonitoringStats()
        {
            // Snippet: SearchModelMonitoringStats(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string modelMonitor = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> response = modelMonitoringServiceClient.SearchModelMonitoringStats(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelMonitoringStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringStatsAsync</summary>
        public async Task SearchModelMonitoringStatsAsync()
        {
            // Snippet: SearchModelMonitoringStatsAsync(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string modelMonitor = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> response = modelMonitoringServiceClient.SearchModelMonitoringStatsAsync(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelMonitoringStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringStats</summary>
        public void SearchModelMonitoringStatsResourceNames()
        {
            // Snippet: SearchModelMonitoringStats(ModelMonitorName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitorName modelMonitor = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> response = modelMonitoringServiceClient.SearchModelMonitoringStats(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelMonitoringStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringStatsAsync</summary>
        public async Task SearchModelMonitoringStatsResourceNamesAsync()
        {
            // Snippet: SearchModelMonitoringStatsAsync(ModelMonitorName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitorName modelMonitor = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> response = modelMonitoringServiceClient.SearchModelMonitoringStatsAsync(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelMonitoringStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringAlerts</summary>
        public void SearchModelMonitoringAlertsRequestObject()
        {
            // Snippet: SearchModelMonitoringAlerts(SearchModelMonitoringAlertsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            SearchModelMonitoringAlertsRequest request = new SearchModelMonitoringAlertsRequest
            {
                ModelMonitorAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                ModelMonitoringJob = "",
                AlertTimeInterval = new Interval(),
                StatsName = "",
                ObjectiveType = "",
            };
            // Make the request
            PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> response = modelMonitoringServiceClient.SearchModelMonitoringAlerts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringAlert item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelMonitoringAlertsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringAlert item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringAlert> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringAlert item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringAlertsAsync</summary>
        public async Task SearchModelMonitoringAlertsRequestObjectAsync()
        {
            // Snippet: SearchModelMonitoringAlertsAsync(SearchModelMonitoringAlertsRequest, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchModelMonitoringAlertsRequest request = new SearchModelMonitoringAlertsRequest
            {
                ModelMonitorAsModelMonitorName = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]"),
                ModelMonitoringJob = "",
                AlertTimeInterval = new Interval(),
                StatsName = "",
                ObjectiveType = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> response = modelMonitoringServiceClient.SearchModelMonitoringAlertsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringAlert item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelMonitoringAlertsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringAlert item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringAlert> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringAlert item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringAlerts</summary>
        public void SearchModelMonitoringAlerts()
        {
            // Snippet: SearchModelMonitoringAlerts(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string modelMonitor = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> response = modelMonitoringServiceClient.SearchModelMonitoringAlerts(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringAlert item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelMonitoringAlertsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringAlert item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringAlert> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringAlert item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringAlertsAsync</summary>
        public async Task SearchModelMonitoringAlertsAsync()
        {
            // Snippet: SearchModelMonitoringAlertsAsync(string, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string modelMonitor = "projects/[PROJECT]/locations/[LOCATION]/modelMonitors/[MODEL_MONITOR]";
            // Make the request
            PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> response = modelMonitoringServiceClient.SearchModelMonitoringAlertsAsync(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringAlert item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelMonitoringAlertsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringAlert item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringAlert> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringAlert item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringAlerts</summary>
        public void SearchModelMonitoringAlertsResourceNames()
        {
            // Snippet: SearchModelMonitoringAlerts(ModelMonitorName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = ModelMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ModelMonitorName modelMonitor = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> response = modelMonitoringServiceClient.SearchModelMonitoringAlerts(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelMonitoringAlert item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchModelMonitoringAlertsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringAlert item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringAlert> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringAlert item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchModelMonitoringAlertsAsync</summary>
        public async Task SearchModelMonitoringAlertsResourceNamesAsync()
        {
            // Snippet: SearchModelMonitoringAlertsAsync(ModelMonitorName, string, int?, CallSettings)
            // Create client
            ModelMonitoringServiceClient modelMonitoringServiceClient = await ModelMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelMonitorName modelMonitor = ModelMonitorName.FromProjectLocationModelMonitor("[PROJECT]", "[LOCATION]", "[MODEL_MONITOR]");
            // Make the request
            PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> response = modelMonitoringServiceClient.SearchModelMonitoringAlertsAsync(modelMonitor);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelMonitoringAlert item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchModelMonitoringAlertsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelMonitoringAlert item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelMonitoringAlert> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelMonitoringAlert item in singlePage)
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
