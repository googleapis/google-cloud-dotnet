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
    public sealed class AllGeneratedDatasetServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetRequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = datasetServiceClient.CreateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = await datasetServiceClient.CreateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset()
        {
            // Snippet: CreateDataset(string, Dataset, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = datasetServiceClient.CreateDataset(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(string, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(string, Dataset, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = await datasetServiceClient.CreateDatasetAsync(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetResourceNames()
        {
            // Snippet: CreateDataset(LocationName, Dataset, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = datasetServiceClient.CreateDataset(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetResourceNamesAsync()
        {
            // Snippet: CreateDatasetAsync(LocationName, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(LocationName, Dataset, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, CreateDatasetOperationMetadata> response = await datasetServiceClient.CreateDatasetAsync(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, CreateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, CreateDatasetOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            Dataset response = datasetServiceClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            Dataset response = await datasetServiceClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Dataset response = datasetServiceClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Dataset response = await datasetServiceClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = datasetServiceClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = await datasetServiceClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDatasetRequestObject()
        {
            // Snippet: UpdateDataset(UpdateDatasetRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = datasetServiceClient.UpdateDataset(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetRequestObjectAsync()
        {
            // Snippet: UpdateDatasetAsync(UpdateDatasetRequest, CallSettings)
            // Additional: UpdateDatasetAsync(UpdateDatasetRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = await datasetServiceClient.UpdateDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDataset()
        {
            // Snippet: UpdateDataset(Dataset, FieldMask, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = datasetServiceClient.UpdateDataset(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetAsync()
        {
            // Snippet: UpdateDatasetAsync(Dataset, FieldMask, CallSettings)
            // Additional: UpdateDatasetAsync(Dataset, FieldMask, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = await datasetServiceClient.UpdateDatasetAsync(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsRequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = datasetServiceClient.ListDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsRequestObjectAsync()
        {
            // Snippet: ListDatasetsAsync(ListDatasetsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = datasetServiceClient.ListDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasets()
        {
            // Snippet: ListDatasets(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = datasetServiceClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsAsync()
        {
            // Snippet: ListDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = datasetServiceClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsResourceNames()
        {
            // Snippet: ListDatasets(LocationName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = datasetServiceClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsResourceNamesAsync()
        {
            // Snippet: ListDatasetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = datasetServiceClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetRequestObject()
        {
            // Snippet: DeleteDataset(DeleteDatasetRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetRequestObjectAsync()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest, CallSettings)
            // Additional: DeleteDatasetAsync(DeleteDatasetRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(string, CallSettings)
            // Additional: DeleteDatasetAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetResourceNames()
        {
            // Snippet: DeleteDataset(DatasetName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetResourceNamesAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataRequestObject()
        {
            // Snippet: ImportData(ImportDataRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ImportConfigs =
                {
                    new ImportDataConfig(),
                },
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataOperationMetadata> response = datasetServiceClient.ImportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataRequestObjectAsync()
        {
            // Snippet: ImportDataAsync(ImportDataRequest, CallSettings)
            // Additional: ImportDataAsync(ImportDataRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ImportConfigs =
                {
                    new ImportDataConfig(),
                },
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataOperationMetadata> response = await datasetServiceClient.ImportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportData()
        {
            // Snippet: ImportData(string, IEnumerable<ImportDataConfig>, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            IEnumerable<ImportDataConfig> importConfigs = new ImportDataConfig[]
            {
                new ImportDataConfig(),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataOperationMetadata> response = datasetServiceClient.ImportData(name, importConfigs);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataAsync()
        {
            // Snippet: ImportDataAsync(string, IEnumerable<ImportDataConfig>, CallSettings)
            // Additional: ImportDataAsync(string, IEnumerable<ImportDataConfig>, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            IEnumerable<ImportDataConfig> importConfigs = new ImportDataConfig[]
            {
                new ImportDataConfig(),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataOperationMetadata> response = await datasetServiceClient.ImportDataAsync(name, importConfigs);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataResourceNames()
        {
            // Snippet: ImportData(DatasetName, IEnumerable<ImportDataConfig>, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            IEnumerable<ImportDataConfig> importConfigs = new ImportDataConfig[]
            {
                new ImportDataConfig(),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataOperationMetadata> response = datasetServiceClient.ImportData(name, importConfigs);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataResourceNamesAsync()
        {
            // Snippet: ImportDataAsync(DatasetName, IEnumerable<ImportDataConfig>, CallSettings)
            // Additional: ImportDataAsync(DatasetName, IEnumerable<ImportDataConfig>, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            IEnumerable<ImportDataConfig> importConfigs = new ImportDataConfig[]
            {
                new ImportDataConfig(),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataOperationMetadata> response = await datasetServiceClient.ImportDataAsync(name, importConfigs);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportDataRequestObject()
        {
            // Snippet: ExportData(ExportDataRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ExportConfig = new ExportDataConfig(),
            };
            // Make the request
            Operation<ExportDataResponse, ExportDataOperationMetadata> response = datasetServiceClient.ExportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataRequestObjectAsync()
        {
            // Snippet: ExportDataAsync(ExportDataRequest, CallSettings)
            // Additional: ExportDataAsync(ExportDataRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                ExportConfig = new ExportDataConfig(),
            };
            // Make the request
            Operation<ExportDataResponse, ExportDataOperationMetadata> response = await datasetServiceClient.ExportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportData()
        {
            // Snippet: ExportData(string, ExportDataConfig, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            ExportDataConfig exportConfig = new ExportDataConfig();
            // Make the request
            Operation<ExportDataResponse, ExportDataOperationMetadata> response = datasetServiceClient.ExportData(name, exportConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataAsync()
        {
            // Snippet: ExportDataAsync(string, ExportDataConfig, CallSettings)
            // Additional: ExportDataAsync(string, ExportDataConfig, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            ExportDataConfig exportConfig = new ExportDataConfig();
            // Make the request
            Operation<ExportDataResponse, ExportDataOperationMetadata> response = await datasetServiceClient.ExportDataAsync(name, exportConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportDataResourceNames()
        {
            // Snippet: ExportData(DatasetName, ExportDataConfig, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            ExportDataConfig exportConfig = new ExportDataConfig();
            // Make the request
            Operation<ExportDataResponse, ExportDataOperationMetadata> response = datasetServiceClient.ExportData(name, exportConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataResourceNamesAsync()
        {
            // Snippet: ExportDataAsync(DatasetName, ExportDataConfig, CallSettings)
            // Additional: ExportDataAsync(DatasetName, ExportDataConfig, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            ExportDataConfig exportConfig = new ExportDataConfig();
            // Make the request
            Operation<ExportDataResponse, ExportDataOperationMetadata> response = await datasetServiceClient.ExportDataAsync(name, exportConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetVersion</summary>
        public void CreateDatasetVersionRequestObject()
        {
            // Snippet: CreateDatasetVersion(CreateDatasetVersionRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            CreateDatasetVersionRequest request = new CreateDatasetVersionRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DatasetVersion = new DatasetVersion(),
            };
            // Make the request
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> response = datasetServiceClient.CreateDatasetVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetVersionAsync</summary>
        public async Task CreateDatasetVersionRequestObjectAsync()
        {
            // Snippet: CreateDatasetVersionAsync(CreateDatasetVersionRequest, CallSettings)
            // Additional: CreateDatasetVersionAsync(CreateDatasetVersionRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetVersionRequest request = new CreateDatasetVersionRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DatasetVersion = new DatasetVersion(),
            };
            // Make the request
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> response = await datasetServiceClient.CreateDatasetVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetVersion</summary>
        public void CreateDatasetVersion()
        {
            // Snippet: CreateDatasetVersion(string, DatasetVersion, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            DatasetVersion datasetVersion = new DatasetVersion();
            // Make the request
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> response = datasetServiceClient.CreateDatasetVersion(parent, datasetVersion);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetVersionAsync</summary>
        public async Task CreateDatasetVersionAsync()
        {
            // Snippet: CreateDatasetVersionAsync(string, DatasetVersion, CallSettings)
            // Additional: CreateDatasetVersionAsync(string, DatasetVersion, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            DatasetVersion datasetVersion = new DatasetVersion();
            // Make the request
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> response = await datasetServiceClient.CreateDatasetVersionAsync(parent, datasetVersion);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetVersion</summary>
        public void CreateDatasetVersionResourceNames()
        {
            // Snippet: CreateDatasetVersion(DatasetName, DatasetVersion, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            DatasetVersion datasetVersion = new DatasetVersion();
            // Make the request
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> response = datasetServiceClient.CreateDatasetVersion(parent, datasetVersion);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceCreateDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetVersionAsync</summary>
        public async Task CreateDatasetVersionResourceNamesAsync()
        {
            // Snippet: CreateDatasetVersionAsync(DatasetName, DatasetVersion, CallSettings)
            // Additional: CreateDatasetVersionAsync(DatasetName, DatasetVersion, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            DatasetVersion datasetVersion = new DatasetVersion();
            // Make the request
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> response = await datasetServiceClient.CreateDatasetVersionAsync(parent, datasetVersion);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, CreateDatasetVersionOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceCreateDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetVersion</summary>
        public void UpdateDatasetVersionRequestObject()
        {
            // Snippet: UpdateDatasetVersion(UpdateDatasetVersionRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            UpdateDatasetVersionRequest request = new UpdateDatasetVersionRequest
            {
                DatasetVersion = new DatasetVersion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DatasetVersion response = datasetServiceClient.UpdateDatasetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetVersionAsync</summary>
        public async Task UpdateDatasetVersionRequestObjectAsync()
        {
            // Snippet: UpdateDatasetVersionAsync(UpdateDatasetVersionRequest, CallSettings)
            // Additional: UpdateDatasetVersionAsync(UpdateDatasetVersionRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetVersionRequest request = new UpdateDatasetVersionRequest
            {
                DatasetVersion = new DatasetVersion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DatasetVersion response = await datasetServiceClient.UpdateDatasetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetVersion</summary>
        public void UpdateDatasetVersion()
        {
            // Snippet: UpdateDatasetVersion(DatasetVersion, FieldMask, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetVersion datasetVersion = new DatasetVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DatasetVersion response = datasetServiceClient.UpdateDatasetVersion(datasetVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetVersionAsync</summary>
        public async Task UpdateDatasetVersionAsync()
        {
            // Snippet: UpdateDatasetVersionAsync(DatasetVersion, FieldMask, CallSettings)
            // Additional: UpdateDatasetVersionAsync(DatasetVersion, FieldMask, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetVersion datasetVersion = new DatasetVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DatasetVersion response = await datasetServiceClient.UpdateDatasetVersionAsync(datasetVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersion</summary>
        public void DeleteDatasetVersionRequestObject()
        {
            // Snippet: DeleteDatasetVersion(DeleteDatasetVersionRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DeleteDatasetVersionRequest request = new DeleteDatasetVersionRequest
            {
                DatasetVersionName = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteDatasetVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersionAsync</summary>
        public async Task DeleteDatasetVersionRequestObjectAsync()
        {
            // Snippet: DeleteDatasetVersionAsync(DeleteDatasetVersionRequest, CallSettings)
            // Additional: DeleteDatasetVersionAsync(DeleteDatasetVersionRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetVersionRequest request = new DeleteDatasetVersionRequest
            {
                DatasetVersionName = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteDatasetVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersion</summary>
        public void DeleteDatasetVersion()
        {
            // Snippet: DeleteDatasetVersion(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/datasetVersions/[DATASET_VERSION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteDatasetVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersionAsync</summary>
        public async Task DeleteDatasetVersionAsync()
        {
            // Snippet: DeleteDatasetVersionAsync(string, CallSettings)
            // Additional: DeleteDatasetVersionAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/datasetVersions/[DATASET_VERSION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteDatasetVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersion</summary>
        public void DeleteDatasetVersionResourceNames()
        {
            // Snippet: DeleteDatasetVersion(DatasetVersionName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetVersionName name = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteDatasetVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersionAsync</summary>
        public async Task DeleteDatasetVersionResourceNamesAsync()
        {
            // Snippet: DeleteDatasetVersionAsync(DatasetVersionName, CallSettings)
            // Additional: DeleteDatasetVersionAsync(DatasetVersionName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetVersionName name = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteDatasetVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDatasetVersion</summary>
        public void GetDatasetVersionRequestObject()
        {
            // Snippet: GetDatasetVersion(GetDatasetVersionRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            GetDatasetVersionRequest request = new GetDatasetVersionRequest
            {
                DatasetVersionName = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            DatasetVersion response = datasetServiceClient.GetDatasetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetVersionAsync</summary>
        public async Task GetDatasetVersionRequestObjectAsync()
        {
            // Snippet: GetDatasetVersionAsync(GetDatasetVersionRequest, CallSettings)
            // Additional: GetDatasetVersionAsync(GetDatasetVersionRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetVersionRequest request = new GetDatasetVersionRequest
            {
                DatasetVersionName = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            DatasetVersion response = await datasetServiceClient.GetDatasetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetVersion</summary>
        public void GetDatasetVersion()
        {
            // Snippet: GetDatasetVersion(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/datasetVersions/[DATASET_VERSION]";
            // Make the request
            DatasetVersion response = datasetServiceClient.GetDatasetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetVersionAsync</summary>
        public async Task GetDatasetVersionAsync()
        {
            // Snippet: GetDatasetVersionAsync(string, CallSettings)
            // Additional: GetDatasetVersionAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/datasetVersions/[DATASET_VERSION]";
            // Make the request
            DatasetVersion response = await datasetServiceClient.GetDatasetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetVersion</summary>
        public void GetDatasetVersionResourceNames()
        {
            // Snippet: GetDatasetVersion(DatasetVersionName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetVersionName name = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]");
            // Make the request
            DatasetVersion response = datasetServiceClient.GetDatasetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetVersionAsync</summary>
        public async Task GetDatasetVersionResourceNamesAsync()
        {
            // Snippet: GetDatasetVersionAsync(DatasetVersionName, CallSettings)
            // Additional: GetDatasetVersionAsync(DatasetVersionName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetVersionName name = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]");
            // Make the request
            DatasetVersion response = await datasetServiceClient.GetDatasetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersions</summary>
        public void ListDatasetVersionsRequestObject()
        {
            // Snippet: ListDatasetVersions(ListDatasetVersionsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ListDatasetVersionsRequest request = new ListDatasetVersionsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDatasetVersionsResponse, DatasetVersion> response = datasetServiceClient.ListDatasetVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatasetVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersionsAsync</summary>
        public async Task ListDatasetVersionsRequestObjectAsync()
        {
            // Snippet: ListDatasetVersionsAsync(ListDatasetVersionsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetVersionsRequest request = new ListDatasetVersionsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetVersionsResponse, DatasetVersion> response = datasetServiceClient.ListDatasetVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatasetVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersions</summary>
        public void ListDatasetVersions()
        {
            // Snippet: ListDatasetVersions(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListDatasetVersionsResponse, DatasetVersion> response = datasetServiceClient.ListDatasetVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatasetVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersionsAsync</summary>
        public async Task ListDatasetVersionsAsync()
        {
            // Snippet: ListDatasetVersionsAsync(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetVersionsResponse, DatasetVersion> response = datasetServiceClient.ListDatasetVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatasetVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersions</summary>
        public void ListDatasetVersionsResourceNames()
        {
            // Snippet: ListDatasetVersions(DatasetName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListDatasetVersionsResponse, DatasetVersion> response = datasetServiceClient.ListDatasetVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatasetVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersionsAsync</summary>
        public async Task ListDatasetVersionsResourceNamesAsync()
        {
            // Snippet: ListDatasetVersionsAsync(DatasetName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetVersionsResponse, DatasetVersion> response = datasetServiceClient.ListDatasetVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatasetVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RestoreDatasetVersion</summary>
        public void RestoreDatasetVersionRequestObject()
        {
            // Snippet: RestoreDatasetVersion(RestoreDatasetVersionRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            RestoreDatasetVersionRequest request = new RestoreDatasetVersionRequest
            {
                DatasetVersionName = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]"),
            };
            // Make the request
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> response = datasetServiceClient.RestoreDatasetVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceRestoreDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatasetVersionAsync</summary>
        public async Task RestoreDatasetVersionRequestObjectAsync()
        {
            // Snippet: RestoreDatasetVersionAsync(RestoreDatasetVersionRequest, CallSettings)
            // Additional: RestoreDatasetVersionAsync(RestoreDatasetVersionRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreDatasetVersionRequest request = new RestoreDatasetVersionRequest
            {
                DatasetVersionName = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]"),
            };
            // Make the request
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> response = await datasetServiceClient.RestoreDatasetVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceRestoreDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatasetVersion</summary>
        public void RestoreDatasetVersion()
        {
            // Snippet: RestoreDatasetVersion(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/datasetVersions/[DATASET_VERSION]";
            // Make the request
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> response = datasetServiceClient.RestoreDatasetVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceRestoreDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatasetVersionAsync</summary>
        public async Task RestoreDatasetVersionAsync()
        {
            // Snippet: RestoreDatasetVersionAsync(string, CallSettings)
            // Additional: RestoreDatasetVersionAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/datasetVersions/[DATASET_VERSION]";
            // Make the request
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> response = await datasetServiceClient.RestoreDatasetVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceRestoreDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatasetVersion</summary>
        public void RestoreDatasetVersionResourceNames()
        {
            // Snippet: RestoreDatasetVersion(DatasetVersionName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetVersionName name = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]");
            // Make the request
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> response = datasetServiceClient.RestoreDatasetVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceRestoreDatasetVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatasetVersionAsync</summary>
        public async Task RestoreDatasetVersionResourceNamesAsync()
        {
            // Snippet: RestoreDatasetVersionAsync(DatasetVersionName, CallSettings)
            // Additional: RestoreDatasetVersionAsync(DatasetVersionName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetVersionName name = DatasetVersionName.FromProjectLocationDatasetDatasetVersion("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATASET_VERSION]");
            // Make the request
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> response = await datasetServiceClient.RestoreDatasetVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetVersion result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetVersion, RestoreDatasetVersionOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceRestoreDatasetVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetVersion retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDataItems</summary>
        public void ListDataItemsRequestObject()
        {
            // Snippet: ListDataItems(ListDataItemsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ListDataItemsRequest request = new ListDataItemsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDataItemsResponse, DataItem> response = datasetServiceClient.ListDataItems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataItemsAsync</summary>
        public async Task ListDataItemsRequestObjectAsync()
        {
            // Snippet: ListDataItemsAsync(ListDataItemsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataItemsRequest request = new ListDataItemsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataItemsResponse, DataItem> response = datasetServiceClient.ListDataItemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataItems</summary>
        public void ListDataItems()
        {
            // Snippet: ListDataItems(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListDataItemsResponse, DataItem> response = datasetServiceClient.ListDataItems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataItemsAsync</summary>
        public async Task ListDataItemsAsync()
        {
            // Snippet: ListDataItemsAsync(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListDataItemsResponse, DataItem> response = datasetServiceClient.ListDataItemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataItems</summary>
        public void ListDataItemsResourceNames()
        {
            // Snippet: ListDataItems(DatasetName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListDataItemsResponse, DataItem> response = datasetServiceClient.ListDataItems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataItemsAsync</summary>
        public async Task ListDataItemsResourceNamesAsync()
        {
            // Snippet: ListDataItemsAsync(DatasetName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListDataItemsResponse, DataItem> response = datasetServiceClient.ListDataItemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDataItems</summary>
        public void SearchDataItemsRequestObject()
        {
            // Snippet: SearchDataItems(SearchDataItemsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            SearchDataItemsRequest request = new SearchDataItemsRequest
            {
                DatasetAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DataLabelingJob = "",
                DataItemFilter = "",
                FieldMask = new FieldMask(),
                AnnotationsLimit = 0,
                AnnotationFilters = { "", },
                OrderByDataItem = "",
            };
            // Make the request
            PagedEnumerable<SearchDataItemsResponse, DataItemView> response = datasetServiceClient.SearchDataItems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataItemView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchDataItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItemView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItemView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItemView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDataItemsAsync</summary>
        public async Task SearchDataItemsRequestObjectAsync()
        {
            // Snippet: SearchDataItemsAsync(SearchDataItemsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchDataItemsRequest request = new SearchDataItemsRequest
            {
                DatasetAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                DataLabelingJob = "",
                DataItemFilter = "",
                FieldMask = new FieldMask(),
                AnnotationsLimit = 0,
                AnnotationFilters = { "", },
                OrderByDataItem = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchDataItemsResponse, DataItemView> response = datasetServiceClient.SearchDataItemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataItemView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchDataItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataItemView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataItemView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataItemView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueriesRequestObject()
        {
            // Snippet: ListSavedQueries(ListSavedQueriesRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ListSavedQueriesRequest request = new ListSavedQueriesRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = datasetServiceClient.ListSavedQueries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesRequestObjectAsync()
        {
            // Snippet: ListSavedQueriesAsync(ListSavedQueriesRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSavedQueriesRequest request = new ListSavedQueriesRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = datasetServiceClient.ListSavedQueriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueries()
        {
            // Snippet: ListSavedQueries(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = datasetServiceClient.ListSavedQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesAsync()
        {
            // Snippet: ListSavedQueriesAsync(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = datasetServiceClient.ListSavedQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueriesResourceNames()
        {
            // Snippet: ListSavedQueries(DatasetName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = datasetServiceClient.ListSavedQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesResourceNamesAsync()
        {
            // Snippet: ListSavedQueriesAsync(DatasetName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = datasetServiceClient.ListSavedQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQuery</summary>
        public void DeleteSavedQueryRequestObject()
        {
            // Snippet: DeleteSavedQuery(DeleteSavedQueryRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectLocationDatasetSavedQuery("[PROJECT]", "[LOCATION]", "[DATASET]", "[SAVED_QUERY]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteSavedQuery(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteSavedQuery(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQueryAsync</summary>
        public async Task DeleteSavedQueryRequestObjectAsync()
        {
            // Snippet: DeleteSavedQueryAsync(DeleteSavedQueryRequest, CallSettings)
            // Additional: DeleteSavedQueryAsync(DeleteSavedQueryRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectLocationDatasetSavedQuery("[PROJECT]", "[LOCATION]", "[DATASET]", "[SAVED_QUERY]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteSavedQueryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteSavedQueryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQuery</summary>
        public void DeleteSavedQuery()
        {
            // Snippet: DeleteSavedQuery(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/savedQueries/[SAVED_QUERY]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteSavedQuery(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteSavedQuery(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQueryAsync</summary>
        public async Task DeleteSavedQueryAsync()
        {
            // Snippet: DeleteSavedQueryAsync(string, CallSettings)
            // Additional: DeleteSavedQueryAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/savedQueries/[SAVED_QUERY]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteSavedQueryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteSavedQueryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQuery</summary>
        public void DeleteSavedQueryResourceNames()
        {
            // Snippet: DeleteSavedQuery(SavedQueryName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            SavedQueryName name = SavedQueryName.FromProjectLocationDatasetSavedQuery("[PROJECT]", "[LOCATION]", "[DATASET]", "[SAVED_QUERY]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = datasetServiceClient.DeleteSavedQuery(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = datasetServiceClient.PollOnceDeleteSavedQuery(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQueryAsync</summary>
        public async Task DeleteSavedQueryResourceNamesAsync()
        {
            // Snippet: DeleteSavedQueryAsync(SavedQueryName, CallSettings)
            // Additional: DeleteSavedQueryAsync(SavedQueryName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SavedQueryName name = SavedQueryName.FromProjectLocationDatasetSavedQuery("[PROJECT]", "[LOCATION]", "[DATASET]", "[SAVED_QUERY]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await datasetServiceClient.DeleteSavedQueryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await datasetServiceClient.PollOnceDeleteSavedQueryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpec</summary>
        public void GetAnnotationSpecRequestObject()
        {
            // Snippet: GetAnnotationSpec(GetAnnotationSpecRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            AnnotationSpec response = datasetServiceClient.GetAnnotationSpec(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecAsync</summary>
        public async Task GetAnnotationSpecRequestObjectAsync()
        {
            // Snippet: GetAnnotationSpecAsync(GetAnnotationSpecRequest, CallSettings)
            // Additional: GetAnnotationSpecAsync(GetAnnotationSpecRequest, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            AnnotationSpec response = await datasetServiceClient.GetAnnotationSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpec</summary>
        public void GetAnnotationSpec()
        {
            // Snippet: GetAnnotationSpec(string, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/annotationSpecs/[ANNOTATION_SPEC]";
            // Make the request
            AnnotationSpec response = datasetServiceClient.GetAnnotationSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecAsync</summary>
        public async Task GetAnnotationSpecAsync()
        {
            // Snippet: GetAnnotationSpecAsync(string, CallSettings)
            // Additional: GetAnnotationSpecAsync(string, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/annotationSpecs/[ANNOTATION_SPEC]";
            // Make the request
            AnnotationSpec response = await datasetServiceClient.GetAnnotationSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpec</summary>
        public void GetAnnotationSpecResourceNames()
        {
            // Snippet: GetAnnotationSpec(AnnotationSpecName, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            AnnotationSpecName name = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]");
            // Make the request
            AnnotationSpec response = datasetServiceClient.GetAnnotationSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecAsync</summary>
        public async Task GetAnnotationSpecResourceNamesAsync()
        {
            // Snippet: GetAnnotationSpecAsync(AnnotationSpecName, CallSettings)
            // Additional: GetAnnotationSpecAsync(AnnotationSpecName, CancellationToken)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotationSpecName name = AnnotationSpecName.FromProjectLocationDatasetAnnotationSpec("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]");
            // Make the request
            AnnotationSpec response = await datasetServiceClient.GetAnnotationSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotationsRequestObject()
        {
            // Snippet: ListAnnotations(ListAnnotationsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            ListAnnotationsRequest request = new ListAnnotationsRequest
            {
                ParentAsDataItemName = DataItemName.FromProjectLocationDatasetDataItem("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAnnotationsResponse, Annotation> response = datasetServiceClient.ListAnnotations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsRequestObjectAsync()
        {
            // Snippet: ListAnnotationsAsync(ListAnnotationsRequest, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnnotationsRequest request = new ListAnnotationsRequest
            {
                ParentAsDataItemName = DataItemName.FromProjectLocationDatasetDataItem("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]"),
                Filter = "",
                ReadMask = new FieldMask(),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> response = datasetServiceClient.ListAnnotationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotations()
        {
            // Snippet: ListAnnotations(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/dataItems/[DATA_ITEM]";
            // Make the request
            PagedEnumerable<ListAnnotationsResponse, Annotation> response = datasetServiceClient.ListAnnotations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsAsync()
        {
            // Snippet: ListAnnotationsAsync(string, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/datasets/[DATASET]/dataItems/[DATA_ITEM]";
            // Make the request
            PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> response = datasetServiceClient.ListAnnotationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotationsResourceNames()
        {
            // Snippet: ListAnnotations(DataItemName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = DatasetServiceClient.Create();
            // Initialize request argument(s)
            DataItemName parent = DataItemName.FromProjectLocationDatasetDataItem("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]");
            // Make the request
            PagedEnumerable<ListAnnotationsResponse, Annotation> response = datasetServiceClient.ListAnnotations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsResourceNamesAsync()
        {
            // Snippet: ListAnnotationsAsync(DataItemName, string, int?, CallSettings)
            // Create client
            DatasetServiceClient datasetServiceClient = await DatasetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataItemName parent = DataItemName.FromProjectLocationDatasetDataItem("[PROJECT]", "[LOCATION]", "[DATASET]", "[DATA_ITEM]");
            // Make the request
            PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> response = datasetServiceClient.ListAnnotationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
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
