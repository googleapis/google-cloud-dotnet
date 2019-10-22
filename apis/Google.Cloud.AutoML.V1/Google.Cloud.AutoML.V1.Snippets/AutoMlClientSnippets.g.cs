// Copyright 2019 Google LLC
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

namespace Google.Cloud.AutoML.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.AutoML.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedAutoMlClientSnippets
    {
        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(LocationName,Dataset,CallSettings)
            // Additional: CreateDatasetAsync(LocationName,Dataset,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, OperationMetadata> response =
                await autoMlClient.CreateDatasetAsync(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceCreateDatasetAsync(operationName);
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
            // Snippet: CreateDataset(LocationName,Dataset,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Dataset dataset = new Dataset();
            // Make the request
            Operation<Dataset, OperationMetadata> response =
                autoMlClient.CreateDataset(parent, dataset);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync_RequestObject()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, OperationMetadata> response =
                await autoMlClient.CreateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset_RequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Operation<Dataset, OperationMetadata> response =
                autoMlClient.CreateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetAsync()
        {
            // Snippet: UpdateDatasetAsync(Dataset,FieldMask,CallSettings)
            // Additional: UpdateDatasetAsync(Dataset,FieldMask,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = await autoMlClient.UpdateDatasetAsync(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDataset()
        {
            // Snippet: UpdateDataset(Dataset,FieldMask,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = autoMlClient.UpdateDataset(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetAsync_RequestObject()
        {
            // Snippet: UpdateDatasetAsync(UpdateDatasetRequest,CallSettings)
            // Additional: UpdateDatasetAsync(UpdateDatasetRequest,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = await autoMlClient.UpdateDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDataset_RequestObject()
        {
            // Snippet: UpdateDataset(UpdateDatasetRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = autoMlClient.UpdateDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName,CallSettings)
            // Additional: GetDatasetAsync(DatasetName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = await autoMlClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(DatasetName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Dataset response = autoMlClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync_RequestObject()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest,CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Dataset response = await autoMlClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset_RequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Dataset response = autoMlClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsAsync()
        {
            // Snippet: ListDatasetsAsync(LocationName,string,int?,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response =
                autoMlClient.ListDatasetsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasets()
        {
            // Snippet: ListDatasets(LocationName,string,int?,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response =
                autoMlClient.ListDatasets(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsAsync_RequestObject()
        {
            // Snippet: ListDatasetsAsync(ListDatasetsRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response =
                autoMlClient.ListDatasetsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasets_RequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response =
                autoMlClient.ListDatasets(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName,CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(DatasetName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync_RequestObject()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.DeleteDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset_RequestObject()
        {
            // Snippet: DeleteDataset(DeleteDatasetRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.DeleteDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataAsync()
        {
            // Snippet: ImportDataAsync(DatasetName,InputConfig,CallSettings)
            // Additional: ImportDataAsync(DatasetName,InputConfig,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.ImportDataAsync(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportData()
        {
            // Snippet: ImportData(DatasetName,InputConfig,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.ImportData(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataAsync_RequestObject()
        {
            // Snippet: ImportDataAsync(ImportDataRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
                InputConfig = new InputConfig(),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.ImportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportData_RequestObject()
        {
            // Snippet: ImportData(ImportDataRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
                InputConfig = new InputConfig(),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.ImportData(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataAsync()
        {
            // Snippet: ExportDataAsync(DatasetName,OutputConfig,CallSettings)
            // Additional: ExportDataAsync(DatasetName,OutputConfig,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.ExportDataAsync(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportData()
        {
            // Snippet: ExportData(DatasetName,OutputConfig,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DatasetName name = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]");
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.ExportData(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataAsync_RequestObject()
        {
            // Snippet: ExportDataAsync(ExportDataRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.ExportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportData_RequestObject()
        {
            // Snippet: ExportData(ExportDataRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = new DatasetName("[PROJECT]", "[LOCATION]", "[DATASET]"),
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.ExportData(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecAsync</summary>
        public async Task GetAnnotationSpecAsync()
        {
            // Snippet: GetAnnotationSpecAsync(AnnotationSpecName,CallSettings)
            // Additional: GetAnnotationSpecAsync(AnnotationSpecName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            AnnotationSpecName name = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]");
            // Make the request
            AnnotationSpec response = await autoMlClient.GetAnnotationSpecAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpec</summary>
        public void GetAnnotationSpec()
        {
            // Snippet: GetAnnotationSpec(AnnotationSpecName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            AnnotationSpecName name = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]");
            // Make the request
            AnnotationSpec response = autoMlClient.GetAnnotationSpec(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecAsync</summary>
        public async Task GetAnnotationSpecAsync_RequestObject()
        {
            // Snippet: GetAnnotationSpecAsync(GetAnnotationSpecRequest,CallSettings)
            // Additional: GetAnnotationSpecAsync(GetAnnotationSpecRequest,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            // Make the request
            AnnotationSpec response = await autoMlClient.GetAnnotationSpecAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpec</summary>
        public void GetAnnotationSpec_RequestObject()
        {
            // Snippet: GetAnnotationSpec(GetAnnotationSpecRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            GetAnnotationSpecRequest request = new GetAnnotationSpecRequest
            {
                AnnotationSpecName = new AnnotationSpecName("[PROJECT]", "[LOCATION]", "[DATASET]", "[ANNOTATION_SPEC]"),
            };
            // Make the request
            AnnotationSpec response = autoMlClient.GetAnnotationSpec(request);
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelAsync()
        {
            // Snippet: CreateModelAsync(LocationName,Model,CallSettings)
            // Additional: CreateModelAsync(LocationName,Model,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Model model = new Model();
            // Make the request
            Operation<Model, OperationMetadata> response =
                await autoMlClient.CreateModelAsync(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModel()
        {
            // Snippet: CreateModel(LocationName,Model,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Model model = new Model();
            // Make the request
            Operation<Model, OperationMetadata> response =
                autoMlClient.CreateModel(parent, model);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelAsync_RequestObject()
        {
            // Snippet: CreateModelAsync(CreateModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Model = new Model(),
            };
            // Make the request
            Operation<Model, OperationMetadata> response =
                await autoMlClient.CreateModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModel_RequestObject()
        {
            // Snippet: CreateModel(CreateModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Model = new Model(),
            };
            // Make the request
            Operation<Model, OperationMetadata> response =
                autoMlClient.CreateModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync()
        {
            // Snippet: GetModelAsync(ModelName,CallSettings)
            // Additional: GetModelAsync(ModelName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Model response = await autoMlClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel()
        {
            // Snippet: GetModel(ModelName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Model response = autoMlClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync_RequestObject()
        {
            // Snippet: GetModelAsync(GetModelRequest,CallSettings)
            // Additional: GetModelAsync(GetModelRequest,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Model response = await autoMlClient.GetModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel_RequestObject()
        {
            // Snippet: GetModel(GetModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Model response = autoMlClient.GetModel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateModelAsync</summary>
        public async Task UpdateModelAsync()
        {
            // Snippet: UpdateModelAsync(Model,FieldMask,CallSettings)
            // Additional: UpdateModelAsync(Model,FieldMask,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Model response = await autoMlClient.UpdateModelAsync(model, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateModel</summary>
        public void UpdateModel()
        {
            // Snippet: UpdateModel(Model,FieldMask,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Model response = autoMlClient.UpdateModel(model, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateModelAsync</summary>
        public async Task UpdateModelAsync_RequestObject()
        {
            // Snippet: UpdateModelAsync(UpdateModelRequest,CallSettings)
            // Additional: UpdateModelAsync(UpdateModelRequest,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Model response = await autoMlClient.UpdateModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateModel</summary>
        public void UpdateModel_RequestObject()
        {
            // Snippet: UpdateModel(UpdateModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Model response = autoMlClient.UpdateModel(request);
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync()
        {
            // Snippet: ListModelsAsync(LocationName,string,int?,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response =
                autoMlClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels()
        {
            // Snippet: ListModels(LocationName,string,int?,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response =
                autoMlClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync_RequestObject()
        {
            // Snippet: ListModelsAsync(ListModelsRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response =
                autoMlClient.ListModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels_RequestObject()
        {
            // Snippet: ListModels(ListModelsRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response =
                autoMlClient.ListModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelAsync()
        {
            // Snippet: DeleteModelAsync(ModelName,CallSettings)
            // Additional: DeleteModelAsync(ModelName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel()
        {
            // Snippet: DeleteModel(ModelName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelAsync_RequestObject()
        {
            // Snippet: DeleteModelAsync(DeleteModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.DeleteModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel_RequestObject()
        {
            // Snippet: DeleteModel(DeleteModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.DeleteModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModelAsync</summary>
        public async Task DeployModelAsync()
        {
            // Snippet: DeployModelAsync(ModelName,CallSettings)
            // Additional: DeployModelAsync(ModelName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.DeployModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceDeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModel</summary>
        public void DeployModel()
        {
            // Snippet: DeployModel(ModelName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.DeployModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceDeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModelAsync</summary>
        public async Task DeployModelAsync_RequestObject()
        {
            // Snippet: DeployModelAsync(DeployModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            DeployModelRequest request = new DeployModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.DeployModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceDeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeployModel</summary>
        public void DeployModel_RequestObject()
        {
            // Snippet: DeployModel(DeployModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            DeployModelRequest request = new DeployModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.DeployModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceDeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModelAsync</summary>
        public async Task UndeployModelAsync()
        {
            // Snippet: UndeployModelAsync(ModelName,CallSettings)
            // Additional: UndeployModelAsync(ModelName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.UndeployModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceUndeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModel</summary>
        public void UndeployModel()
        {
            // Snippet: UndeployModel(ModelName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.UndeployModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceUndeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModelAsync</summary>
        public async Task UndeployModelAsync_RequestObject()
        {
            // Snippet: UndeployModelAsync(UndeployModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            UndeployModelRequest request = new UndeployModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.UndeployModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceUndeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployModel</summary>
        public void UndeployModel_RequestObject()
        {
            // Snippet: UndeployModel(UndeployModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            UndeployModelRequest request = new UndeployModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.UndeployModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceUndeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelAsync</summary>
        public async Task ExportModelAsync_RequestObject()
        {
            // Snippet: ExportModelAsync(ExportModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ExportModelRequest request = new ExportModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                OutputConfig = new ModelExportOutputConfig(),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                await autoMlClient.ExportModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                await autoMlClient.PollOnceExportModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModel</summary>
        public void ExportModel_RequestObject()
        {
            // Snippet: ExportModel(ExportModelRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ExportModelRequest request = new ExportModelRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                OutputConfig = new ModelExportOutputConfig(),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response =
                autoMlClient.ExportModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse =
                autoMlClient.PollOnceExportModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationAsync</summary>
        public async Task GetModelEvaluationAsync()
        {
            // Snippet: GetModelEvaluationAsync(ModelEvaluationName,CallSettings)
            // Additional: GetModelEvaluationAsync(ModelEvaluationName,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ModelEvaluationName name = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]");
            // Make the request
            ModelEvaluation response = await autoMlClient.GetModelEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluation</summary>
        public void GetModelEvaluation()
        {
            // Snippet: GetModelEvaluation(ModelEvaluationName,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ModelEvaluationName name = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]");
            // Make the request
            ModelEvaluation response = autoMlClient.GetModelEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluationAsync</summary>
        public async Task GetModelEvaluationAsync_RequestObject()
        {
            // Snippet: GetModelEvaluationAsync(GetModelEvaluationRequest,CallSettings)
            // Additional: GetModelEvaluationAsync(GetModelEvaluationRequest,CancellationToken)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]"),
            };
            // Make the request
            ModelEvaluation response = await autoMlClient.GetModelEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelEvaluation</summary>
        public void GetModelEvaluation_RequestObject()
        {
            // Snippet: GetModelEvaluation(GetModelEvaluationRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = new ModelEvaluationName("[PROJECT]", "[LOCATION]", "[MODEL]", "[MODEL_EVALUATION]"),
            };
            // Make the request
            ModelEvaluation response = autoMlClient.GetModelEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationsAsync</summary>
        public async Task ListModelEvaluationsAsync()
        {
            // Snippet: ListModelEvaluationsAsync(ModelName,string,string,int?,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ModelName parent = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response =
                autoMlClient.ListModelEvaluationsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluations</summary>
        public void ListModelEvaluations()
        {
            // Snippet: ListModelEvaluations(ModelName,string,string,int?,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ModelName parent = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response =
                autoMlClient.ListModelEvaluations(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluationsAsync</summary>
        public async Task ListModelEvaluationsAsync_RequestObject()
        {
            // Snippet: ListModelEvaluationsAsync(ListModelEvaluationsRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response =
                autoMlClient.ListModelEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ModelEvaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelEvaluations</summary>
        public void ListModelEvaluations_RequestObject()
        {
            // Snippet: ListModelEvaluations(ListModelEvaluationsRequest,CallSettings)
            // Create client
            AutoMlClient autoMlClient = AutoMlClient.Create();
            // Initialize request argument(s)
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> response =
                autoMlClient.ListModelEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ModelEvaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ModelEvaluation item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ModelEvaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ModelEvaluation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
