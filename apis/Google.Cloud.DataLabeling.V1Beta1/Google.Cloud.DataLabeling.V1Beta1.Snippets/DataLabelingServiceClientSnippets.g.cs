// Copyright 2022 Google LLC
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

namespace Google.Cloud.DataLabeling.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataLabelingServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetRequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Dataset response = dataLabelingServiceClient.CreateDataset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Dataset response = await dataLabelingServiceClient.CreateDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset()
        {
            // Snippet: CreateDataset(string, Dataset, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = dataLabelingServiceClient.CreateDataset(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(string, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(string, Dataset, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = await dataLabelingServiceClient.CreateDatasetAsync(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetResourceNames()
        {
            // Snippet: CreateDataset(ProjectName, Dataset, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = dataLabelingServiceClient.CreateDataset(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetResourceNamesAsync()
        {
            // Snippet: CreateDatasetAsync(ProjectName, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(ProjectName, Dataset, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = await dataLabelingServiceClient.CreateDatasetAsync(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            Dataset response = dataLabelingServiceClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            Dataset response = await dataLabelingServiceClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            Dataset response = dataLabelingServiceClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            Dataset response = await dataLabelingServiceClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            Dataset response = dataLabelingServiceClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            Dataset response = await dataLabelingServiceClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsRequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = dataLabelingServiceClient.ListDatasets(request);

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
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = dataLabelingServiceClient.ListDatasetsAsync(request);

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
            // Snippet: ListDatasets(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = dataLabelingServiceClient.ListDatasets(parent, filter);

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
            // Snippet: ListDatasetsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = dataLabelingServiceClient.ListDatasetsAsync(parent, filter);

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
            // Snippet: ListDatasets(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = dataLabelingServiceClient.ListDatasets(parent, filter);

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
            // Snippet: ListDatasetsAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = dataLabelingServiceClient.ListDatasetsAsync(parent, filter);

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
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            dataLabelingServiceClient.DeleteDataset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetRequestObjectAsync()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest, CallSettings)
            // Additional: DeleteDatasetAsync(DeleteDatasetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            await dataLabelingServiceClient.DeleteDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            dataLabelingServiceClient.DeleteDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(string, CallSettings)
            // Additional: DeleteDatasetAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            await dataLabelingServiceClient.DeleteDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetResourceNames()
        {
            // Snippet: DeleteDataset(DatasetName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            dataLabelingServiceClient.DeleteDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetResourceNamesAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            await dataLabelingServiceClient.DeleteDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataRequestObject()
        {
            // Snippet: ImportData(ImportDataRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                InputConfig = new InputConfig(),
                UserEmailAddress = "",
            };
            // Make the request
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> response = dataLabelingServiceClient.ImportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataRequestObjectAsync()
        {
            // Snippet: ImportDataAsync(ImportDataRequest, CallSettings)
            // Additional: ImportDataAsync(ImportDataRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                InputConfig = new InputConfig(),
                UserEmailAddress = "",
            };
            // Make the request
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> response = await dataLabelingServiceClient.ImportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportData()
        {
            // Snippet: ImportData(string, InputConfig, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> response = dataLabelingServiceClient.ImportData(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataAsync()
        {
            // Snippet: ImportDataAsync(string, InputConfig, CallSettings)
            // Additional: ImportDataAsync(string, InputConfig, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> response = await dataLabelingServiceClient.ImportDataAsync(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataResourceNames()
        {
            // Snippet: ImportData(DatasetName, InputConfig, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> response = dataLabelingServiceClient.ImportData(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataResourceNamesAsync()
        {
            // Snippet: ImportDataAsync(DatasetName, InputConfig, CallSettings)
            // Additional: ImportDataAsync(DatasetName, InputConfig, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> response = await dataLabelingServiceClient.ImportDataAsync(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataOperationResponse, ImportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportDataRequestObject()
        {
            // Snippet: ExportData(ExportDataRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                AnnotatedDatasetAsAnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                Filter = "",
                OutputConfig = new OutputConfig(),
                UserEmailAddress = "",
            };
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = dataLabelingServiceClient.ExportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataRequestObjectAsync()
        {
            // Snippet: ExportDataAsync(ExportDataRequest, CallSettings)
            // Additional: ExportDataAsync(ExportDataRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                AnnotatedDatasetAsAnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                Filter = "",
                OutputConfig = new OutputConfig(),
                UserEmailAddress = "",
            };
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = await dataLabelingServiceClient.ExportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportData()
        {
            // Snippet: ExportData(string, string, string, OutputConfig, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            string annotatedDataset = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            string filter = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = dataLabelingServiceClient.ExportData(name, annotatedDataset, filter, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataAsync()
        {
            // Snippet: ExportDataAsync(string, string, string, OutputConfig, CallSettings)
            // Additional: ExportDataAsync(string, string, string, OutputConfig, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            string annotatedDataset = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            string filter = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = await dataLabelingServiceClient.ExportDataAsync(name, annotatedDataset, filter, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportDataResourceNames()
        {
            // Snippet: ExportData(DatasetName, AnnotatedDatasetName, string, OutputConfig, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            AnnotatedDatasetName annotatedDataset = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]");
            string filter = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = dataLabelingServiceClient.ExportData(name, annotatedDataset, filter, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataResourceNamesAsync()
        {
            // Snippet: ExportDataAsync(DatasetName, AnnotatedDatasetName, string, OutputConfig, CallSettings)
            // Additional: ExportDataAsync(DatasetName, AnnotatedDatasetName, string, OutputConfig, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            AnnotatedDatasetName annotatedDataset = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]");
            string filter = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = await dataLabelingServiceClient.ExportDataAsync(name, annotatedDataset, filter, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDataItem</summary>
        public void GetDataItemRequestObject()
        {
            // Snippet: GetDataItem(GetDataItemRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            // Make the request
            DataItem response = dataLabelingServiceClient.GetDataItem(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataItemAsync</summary>
        public async Task GetDataItemRequestObjectAsync()
        {
            // Snippet: GetDataItemAsync(GetDataItemRequest, CallSettings)
            // Additional: GetDataItemAsync(GetDataItemRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataItemRequest request = new GetDataItemRequest
            {
                DataItemName = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]"),
            };
            // Make the request
            DataItem response = await dataLabelingServiceClient.GetDataItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataItem</summary>
        public void GetDataItem()
        {
            // Snippet: GetDataItem(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/dataItems/[DATA_ITEM]";
            // Make the request
            DataItem response = dataLabelingServiceClient.GetDataItem(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataItemAsync</summary>
        public async Task GetDataItemAsync()
        {
            // Snippet: GetDataItemAsync(string, CallSettings)
            // Additional: GetDataItemAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/dataItems/[DATA_ITEM]";
            // Make the request
            DataItem response = await dataLabelingServiceClient.GetDataItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataItem</summary>
        public void GetDataItemResourceNames()
        {
            // Snippet: GetDataItem(DataItemName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DataItemName name = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]");
            // Make the request
            DataItem response = dataLabelingServiceClient.GetDataItem(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataItemAsync</summary>
        public async Task GetDataItemResourceNamesAsync()
        {
            // Snippet: GetDataItemAsync(DataItemName, CallSettings)
            // Additional: GetDataItemAsync(DataItemName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataItemName name = DataItemName.FromProjectDatasetDataItem("[PROJECT]", "[DATASET]", "[DATA_ITEM]");
            // Make the request
            DataItem response = await dataLabelingServiceClient.GetDataItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataItems</summary>
        public void ListDataItemsRequestObject()
        {
            // Snippet: ListDataItems(ListDataItemsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListDataItemsRequest request = new ListDataItemsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataItemsResponse, DataItem> response = dataLabelingServiceClient.ListDataItems(request);

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
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataItemsRequest request = new ListDataItemsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataItemsResponse, DataItem> response = dataLabelingServiceClient.ListDataItemsAsync(request);

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
            // Snippet: ListDataItems(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListDataItemsResponse, DataItem> response = dataLabelingServiceClient.ListDataItems(parent, filter);

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
            // Snippet: ListDataItemsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListDataItemsResponse, DataItem> response = dataLabelingServiceClient.ListDataItemsAsync(parent, filter);

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
            // Snippet: ListDataItems(DatasetName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListDataItemsResponse, DataItem> response = dataLabelingServiceClient.ListDataItems(parent, filter);

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
            // Snippet: ListDataItemsAsync(DatasetName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListDataItemsResponse, DataItem> response = dataLabelingServiceClient.ListDataItemsAsync(parent, filter);

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

        /// <summary>Snippet for GetAnnotatedDataset</summary>
        public void GetAnnotatedDatasetRequestObject()
        {
            // Snippet: GetAnnotatedDataset(GetAnnotatedDatasetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            // Make the request
            AnnotatedDataset response = dataLabelingServiceClient.GetAnnotatedDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotatedDatasetAsync</summary>
        public async Task GetAnnotatedDatasetRequestObjectAsync()
        {
            // Snippet: GetAnnotatedDatasetAsync(GetAnnotatedDatasetRequest, CallSettings)
            // Additional: GetAnnotatedDatasetAsync(GetAnnotatedDatasetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAnnotatedDatasetRequest request = new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            // Make the request
            AnnotatedDataset response = await dataLabelingServiceClient.GetAnnotatedDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotatedDataset</summary>
        public void GetAnnotatedDataset()
        {
            // Snippet: GetAnnotatedDataset(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            // Make the request
            AnnotatedDataset response = dataLabelingServiceClient.GetAnnotatedDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotatedDatasetAsync</summary>
        public async Task GetAnnotatedDatasetAsync()
        {
            // Snippet: GetAnnotatedDatasetAsync(string, CallSettings)
            // Additional: GetAnnotatedDatasetAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            // Make the request
            AnnotatedDataset response = await dataLabelingServiceClient.GetAnnotatedDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotatedDataset</summary>
        public void GetAnnotatedDatasetResourceNames()
        {
            // Snippet: GetAnnotatedDataset(AnnotatedDatasetName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            AnnotatedDatasetName name = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]");
            // Make the request
            AnnotatedDataset response = dataLabelingServiceClient.GetAnnotatedDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotatedDatasetAsync</summary>
        public async Task GetAnnotatedDatasetResourceNamesAsync()
        {
            // Snippet: GetAnnotatedDatasetAsync(AnnotatedDatasetName, CallSettings)
            // Additional: GetAnnotatedDatasetAsync(AnnotatedDatasetName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotatedDatasetName name = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]");
            // Make the request
            AnnotatedDataset response = await dataLabelingServiceClient.GetAnnotatedDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnnotatedDatasets</summary>
        public void ListAnnotatedDatasetsRequestObject()
        {
            // Snippet: ListAnnotatedDatasets(ListAnnotatedDatasetsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListAnnotatedDatasetsRequest request = new ListAnnotatedDatasetsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> response = dataLabelingServiceClient.ListAnnotatedDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnnotatedDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotatedDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotatedDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotatedDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotatedDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotatedDatasetsAsync</summary>
        public async Task ListAnnotatedDatasetsRequestObjectAsync()
        {
            // Snippet: ListAnnotatedDatasetsAsync(ListAnnotatedDatasetsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnnotatedDatasetsRequest request = new ListAnnotatedDatasetsRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> response = dataLabelingServiceClient.ListAnnotatedDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnnotatedDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotatedDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotatedDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotatedDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotatedDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotatedDatasets</summary>
        public void ListAnnotatedDatasets()
        {
            // Snippet: ListAnnotatedDatasets(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> response = dataLabelingServiceClient.ListAnnotatedDatasets(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnnotatedDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotatedDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotatedDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotatedDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotatedDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotatedDatasetsAsync</summary>
        public async Task ListAnnotatedDatasetsAsync()
        {
            // Snippet: ListAnnotatedDatasetsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> response = dataLabelingServiceClient.ListAnnotatedDatasetsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnnotatedDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotatedDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotatedDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotatedDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotatedDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotatedDatasets</summary>
        public void ListAnnotatedDatasetsResourceNames()
        {
            // Snippet: ListAnnotatedDatasets(DatasetName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> response = dataLabelingServiceClient.ListAnnotatedDatasets(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnnotatedDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotatedDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotatedDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotatedDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotatedDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotatedDatasetsAsync</summary>
        public async Task ListAnnotatedDatasetsResourceNamesAsync()
        {
            // Snippet: ListAnnotatedDatasetsAsync(DatasetName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> response = dataLabelingServiceClient.ListAnnotatedDatasetsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnnotatedDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotatedDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotatedDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotatedDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotatedDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotatedDataset</summary>
        public void DeleteAnnotatedDatasetRequestObject()
        {
            // Snippet: DeleteAnnotatedDataset(DeleteAnnotatedDatasetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DeleteAnnotatedDatasetRequest request = new DeleteAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            // Make the request
            dataLabelingServiceClient.DeleteAnnotatedDataset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotatedDatasetAsync</summary>
        public async Task DeleteAnnotatedDatasetRequestObjectAsync()
        {
            // Snippet: DeleteAnnotatedDatasetAsync(DeleteAnnotatedDatasetRequest, CallSettings)
            // Additional: DeleteAnnotatedDatasetAsync(DeleteAnnotatedDatasetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAnnotatedDatasetRequest request = new DeleteAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
            };
            // Make the request
            await dataLabelingServiceClient.DeleteAnnotatedDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LabelImage</summary>
        public void LabelImageRequestObject()
        {
            // Snippet: LabelImage(LabelImageRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            LabelImageRequest request = new LabelImageRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                BasicConfig = new HumanAnnotationConfig(),
                Feature = LabelImageRequest.Types.Feature.Unspecified,
                ImageClassificationConfig = new ImageClassificationConfig(),
            };
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelImage(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelImage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelImageAsync</summary>
        public async Task LabelImageRequestObjectAsync()
        {
            // Snippet: LabelImageAsync(LabelImageRequest, CallSettings)
            // Additional: LabelImageAsync(LabelImageRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            LabelImageRequest request = new LabelImageRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                BasicConfig = new HumanAnnotationConfig(),
                Feature = LabelImageRequest.Types.Feature.Unspecified,
                ImageClassificationConfig = new ImageClassificationConfig(),
            };
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelImageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelImageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelImage</summary>
        public void LabelImage()
        {
            // Snippet: LabelImage(string, HumanAnnotationConfig, LabelImageRequest.Types.Feature, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelImageRequest.Types.Feature feature = LabelImageRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelImage(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelImage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelImageAsync</summary>
        public async Task LabelImageAsync()
        {
            // Snippet: LabelImageAsync(string, HumanAnnotationConfig, LabelImageRequest.Types.Feature, CallSettings)
            // Additional: LabelImageAsync(string, HumanAnnotationConfig, LabelImageRequest.Types.Feature, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelImageRequest.Types.Feature feature = LabelImageRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelImageAsync(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelImageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelImage</summary>
        public void LabelImageResourceNames()
        {
            // Snippet: LabelImage(DatasetName, HumanAnnotationConfig, LabelImageRequest.Types.Feature, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelImageRequest.Types.Feature feature = LabelImageRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelImage(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelImage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelImageAsync</summary>
        public async Task LabelImageResourceNamesAsync()
        {
            // Snippet: LabelImageAsync(DatasetName, HumanAnnotationConfig, LabelImageRequest.Types.Feature, CallSettings)
            // Additional: LabelImageAsync(DatasetName, HumanAnnotationConfig, LabelImageRequest.Types.Feature, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelImageRequest.Types.Feature feature = LabelImageRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelImageAsync(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelImageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelVideo</summary>
        public void LabelVideoRequestObject()
        {
            // Snippet: LabelVideo(LabelVideoRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            LabelVideoRequest request = new LabelVideoRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                BasicConfig = new HumanAnnotationConfig(),
                Feature = LabelVideoRequest.Types.Feature.Unspecified,
                VideoClassificationConfig = new VideoClassificationConfig(),
            };
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelVideo(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelVideoAsync</summary>
        public async Task LabelVideoRequestObjectAsync()
        {
            // Snippet: LabelVideoAsync(LabelVideoRequest, CallSettings)
            // Additional: LabelVideoAsync(LabelVideoRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            LabelVideoRequest request = new LabelVideoRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                BasicConfig = new HumanAnnotationConfig(),
                Feature = LabelVideoRequest.Types.Feature.Unspecified,
                VideoClassificationConfig = new VideoClassificationConfig(),
            };
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelVideoAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelVideo</summary>
        public void LabelVideo()
        {
            // Snippet: LabelVideo(string, HumanAnnotationConfig, LabelVideoRequest.Types.Feature, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelVideoRequest.Types.Feature feature = LabelVideoRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelVideo(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelVideoAsync</summary>
        public async Task LabelVideoAsync()
        {
            // Snippet: LabelVideoAsync(string, HumanAnnotationConfig, LabelVideoRequest.Types.Feature, CallSettings)
            // Additional: LabelVideoAsync(string, HumanAnnotationConfig, LabelVideoRequest.Types.Feature, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelVideoRequest.Types.Feature feature = LabelVideoRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelVideoAsync(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelVideo</summary>
        public void LabelVideoResourceNames()
        {
            // Snippet: LabelVideo(DatasetName, HumanAnnotationConfig, LabelVideoRequest.Types.Feature, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelVideoRequest.Types.Feature feature = LabelVideoRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelVideo(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelVideoAsync</summary>
        public async Task LabelVideoResourceNamesAsync()
        {
            // Snippet: LabelVideoAsync(DatasetName, HumanAnnotationConfig, LabelVideoRequest.Types.Feature, CallSettings)
            // Additional: LabelVideoAsync(DatasetName, HumanAnnotationConfig, LabelVideoRequest.Types.Feature, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelVideoRequest.Types.Feature feature = LabelVideoRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelVideoAsync(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelText</summary>
        public void LabelTextRequestObject()
        {
            // Snippet: LabelText(LabelTextRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            LabelTextRequest request = new LabelTextRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                BasicConfig = new HumanAnnotationConfig(),
                TextClassificationConfig = new TextClassificationConfig(),
                Feature = LabelTextRequest.Types.Feature.Unspecified,
            };
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelText(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelText(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelTextAsync</summary>
        public async Task LabelTextRequestObjectAsync()
        {
            // Snippet: LabelTextAsync(LabelTextRequest, CallSettings)
            // Additional: LabelTextAsync(LabelTextRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            LabelTextRequest request = new LabelTextRequest
            {
                ParentAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                BasicConfig = new HumanAnnotationConfig(),
                TextClassificationConfig = new TextClassificationConfig(),
                Feature = LabelTextRequest.Types.Feature.Unspecified,
            };
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelTextAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelTextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelText</summary>
        public void LabelText()
        {
            // Snippet: LabelText(string, HumanAnnotationConfig, LabelTextRequest.Types.Feature, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelTextRequest.Types.Feature feature = LabelTextRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelText(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelText(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelTextAsync</summary>
        public async Task LabelTextAsync()
        {
            // Snippet: LabelTextAsync(string, HumanAnnotationConfig, LabelTextRequest.Types.Feature, CallSettings)
            // Additional: LabelTextAsync(string, HumanAnnotationConfig, LabelTextRequest.Types.Feature, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]";
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelTextRequest.Types.Feature feature = LabelTextRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelTextAsync(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelTextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelText</summary>
        public void LabelTextResourceNames()
        {
            // Snippet: LabelText(DatasetName, HumanAnnotationConfig, LabelTextRequest.Types.Feature, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelTextRequest.Types.Feature feature = LabelTextRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = dataLabelingServiceClient.LabelText(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceLabelText(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LabelTextAsync</summary>
        public async Task LabelTextResourceNamesAsync()
        {
            // Snippet: LabelTextAsync(DatasetName, HumanAnnotationConfig, LabelTextRequest.Types.Feature, CallSettings)
            // Additional: LabelTextAsync(DatasetName, HumanAnnotationConfig, LabelTextRequest.Types.Feature, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName parent = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            HumanAnnotationConfig basicConfig = new HumanAnnotationConfig();
            LabelTextRequest.Types.Feature feature = LabelTextRequest.Types.Feature.Unspecified;
            // Make the request
            Operation<AnnotatedDataset, LabelOperationMetadata> response = await dataLabelingServiceClient.LabelTextAsync(parent, basicConfig, feature);

            // Poll until the returned long-running operation is complete
            Operation<AnnotatedDataset, LabelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotatedDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotatedDataset, LabelOperationMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceLabelTextAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotatedDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExampleRequestObject()
        {
            // Snippet: GetExample(GetExampleRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "",
            };
            // Make the request
            Example response = dataLabelingServiceClient.GetExample(request);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleRequestObjectAsync()
        {
            // Snippet: GetExampleAsync(GetExampleRequest, CallSettings)
            // Additional: GetExampleAsync(GetExampleRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExampleRequest request = new GetExampleRequest
            {
                ExampleName = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]"),
                Filter = "",
            };
            // Make the request
            Example response = await dataLabelingServiceClient.GetExampleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExample()
        {
            // Snippet: GetExample(string, string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]/examples/[EXAMPLE]";
            string filter = "";
            // Make the request
            Example response = dataLabelingServiceClient.GetExample(name, filter);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleAsync()
        {
            // Snippet: GetExampleAsync(string, string, CallSettings)
            // Additional: GetExampleAsync(string, string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]/examples/[EXAMPLE]";
            string filter = "";
            // Make the request
            Example response = await dataLabelingServiceClient.GetExampleAsync(name, filter);
            // End snippet
        }

        /// <summary>Snippet for GetExample</summary>
        public void GetExampleResourceNames()
        {
            // Snippet: GetExample(ExampleName, string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]");
            string filter = "";
            // Make the request
            Example response = dataLabelingServiceClient.GetExample(name, filter);
            // End snippet
        }

        /// <summary>Snippet for GetExampleAsync</summary>
        public async Task GetExampleResourceNamesAsync()
        {
            // Snippet: GetExampleAsync(ExampleName, string, CallSettings)
            // Additional: GetExampleAsync(ExampleName, string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExampleName name = ExampleName.FromProjectDatasetAnnotatedDatasetExample("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]", "[EXAMPLE]");
            string filter = "";
            // Make the request
            Example response = await dataLabelingServiceClient.GetExampleAsync(name, filter);
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesRequestObject()
        {
            // Snippet: ListExamples(ListExamplesRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsAnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = dataLabelingServiceClient.ListExamples(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesRequestObjectAsync()
        {
            // Snippet: ListExamplesAsync(ListExamplesRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsAnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = dataLabelingServiceClient.ListExamplesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamples()
        {
            // Snippet: ListExamples(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = dataLabelingServiceClient.ListExamples(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesAsync()
        {
            // Snippet: ListExamplesAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/annotatedDatasets/[ANNOTATED_DATASET]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = dataLabelingServiceClient.ListExamplesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamples</summary>
        public void ListExamplesResourceNames()
        {
            // Snippet: ListExamples(AnnotatedDatasetName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            AnnotatedDatasetName parent = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListExamplesResponse, Example> response = dataLabelingServiceClient.ListExamples(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExamplesAsync</summary>
        public async Task ListExamplesResourceNamesAsync()
        {
            // Snippet: ListExamplesAsync(AnnotatedDatasetName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotatedDatasetName parent = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListExamplesResponse, Example> response = dataLabelingServiceClient.ListExamplesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationSpecSet</summary>
        public void CreateAnnotationSpecSetRequestObject()
        {
            // Snippet: CreateAnnotationSpecSet(CreateAnnotationSpecSetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.CreateAnnotationSpecSet(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationSpecSetAsync</summary>
        public async Task CreateAnnotationSpecSetRequestObjectAsync()
        {
            // Snippet: CreateAnnotationSpecSetAsync(CreateAnnotationSpecSetRequest, CallSettings)
            // Additional: CreateAnnotationSpecSetAsync(CreateAnnotationSpecSetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnnotationSpecSetRequest request = new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AnnotationSpecSet = new AnnotationSpecSet(),
            };
            // Make the request
            AnnotationSpecSet response = await dataLabelingServiceClient.CreateAnnotationSpecSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationSpecSet</summary>
        public void CreateAnnotationSpecSet()
        {
            // Snippet: CreateAnnotationSpecSet(string, AnnotationSpecSet, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            AnnotationSpecSet annotationSpecSet = new AnnotationSpecSet();
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.CreateAnnotationSpecSet(parent, annotationSpecSet);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationSpecSetAsync</summary>
        public async Task CreateAnnotationSpecSetAsync()
        {
            // Snippet: CreateAnnotationSpecSetAsync(string, AnnotationSpecSet, CallSettings)
            // Additional: CreateAnnotationSpecSetAsync(string, AnnotationSpecSet, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            AnnotationSpecSet annotationSpecSet = new AnnotationSpecSet();
            // Make the request
            AnnotationSpecSet response = await dataLabelingServiceClient.CreateAnnotationSpecSetAsync(parent, annotationSpecSet);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationSpecSet</summary>
        public void CreateAnnotationSpecSetResourceNames()
        {
            // Snippet: CreateAnnotationSpecSet(ProjectName, AnnotationSpecSet, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            AnnotationSpecSet annotationSpecSet = new AnnotationSpecSet();
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.CreateAnnotationSpecSet(parent, annotationSpecSet);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationSpecSetAsync</summary>
        public async Task CreateAnnotationSpecSetResourceNamesAsync()
        {
            // Snippet: CreateAnnotationSpecSetAsync(ProjectName, AnnotationSpecSet, CallSettings)
            // Additional: CreateAnnotationSpecSetAsync(ProjectName, AnnotationSpecSet, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            AnnotationSpecSet annotationSpecSet = new AnnotationSpecSet();
            // Make the request
            AnnotationSpecSet response = await dataLabelingServiceClient.CreateAnnotationSpecSetAsync(parent, annotationSpecSet);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecSet</summary>
        public void GetAnnotationSpecSetRequestObject()
        {
            // Snippet: GetAnnotationSpecSet(GetAnnotationSpecSetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.GetAnnotationSpecSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecSetAsync</summary>
        public async Task GetAnnotationSpecSetRequestObjectAsync()
        {
            // Snippet: GetAnnotationSpecSetAsync(GetAnnotationSpecSetRequest, CallSettings)
            // Additional: GetAnnotationSpecSetAsync(GetAnnotationSpecSetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAnnotationSpecSetRequest request = new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            // Make the request
            AnnotationSpecSet response = await dataLabelingServiceClient.GetAnnotationSpecSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecSet</summary>
        public void GetAnnotationSpecSet()
        {
            // Snippet: GetAnnotationSpecSet(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/annotationSpecSets/[ANNOTATION_SPEC_SET]";
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.GetAnnotationSpecSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecSetAsync</summary>
        public async Task GetAnnotationSpecSetAsync()
        {
            // Snippet: GetAnnotationSpecSetAsync(string, CallSettings)
            // Additional: GetAnnotationSpecSetAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/annotationSpecSets/[ANNOTATION_SPEC_SET]";
            // Make the request
            AnnotationSpecSet response = await dataLabelingServiceClient.GetAnnotationSpecSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecSet</summary>
        public void GetAnnotationSpecSetResourceNames()
        {
            // Snippet: GetAnnotationSpecSet(AnnotationSpecSetName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            AnnotationSpecSetName name = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]");
            // Make the request
            AnnotationSpecSet response = dataLabelingServiceClient.GetAnnotationSpecSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnnotationSpecSetAsync</summary>
        public async Task GetAnnotationSpecSetResourceNamesAsync()
        {
            // Snippet: GetAnnotationSpecSetAsync(AnnotationSpecSetName, CallSettings)
            // Additional: GetAnnotationSpecSetAsync(AnnotationSpecSetName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotationSpecSetName name = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]");
            // Make the request
            AnnotationSpecSet response = await dataLabelingServiceClient.GetAnnotationSpecSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationSpecSets</summary>
        public void ListAnnotationSpecSetsRequestObject()
        {
            // Snippet: ListAnnotationSpecSets(ListAnnotationSpecSetsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListAnnotationSpecSetsRequest request = new ListAnnotationSpecSetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> response = dataLabelingServiceClient.ListAnnotationSpecSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnnotationSpecSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationSpecSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotationSpecSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotationSpecSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotationSpecSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationSpecSetsAsync</summary>
        public async Task ListAnnotationSpecSetsRequestObjectAsync()
        {
            // Snippet: ListAnnotationSpecSetsAsync(ListAnnotationSpecSetsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnnotationSpecSetsRequest request = new ListAnnotationSpecSetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> response = dataLabelingServiceClient.ListAnnotationSpecSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnnotationSpecSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationSpecSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotationSpecSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotationSpecSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotationSpecSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationSpecSets</summary>
        public void ListAnnotationSpecSets()
        {
            // Snippet: ListAnnotationSpecSets(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> response = dataLabelingServiceClient.ListAnnotationSpecSets(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnnotationSpecSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationSpecSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotationSpecSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotationSpecSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotationSpecSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationSpecSetsAsync</summary>
        public async Task ListAnnotationSpecSetsAsync()
        {
            // Snippet: ListAnnotationSpecSetsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> response = dataLabelingServiceClient.ListAnnotationSpecSetsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnnotationSpecSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationSpecSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotationSpecSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotationSpecSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotationSpecSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationSpecSets</summary>
        public void ListAnnotationSpecSetsResourceNames()
        {
            // Snippet: ListAnnotationSpecSets(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> response = dataLabelingServiceClient.ListAnnotationSpecSets(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnnotationSpecSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationSpecSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotationSpecSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotationSpecSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotationSpecSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationSpecSetsAsync</summary>
        public async Task ListAnnotationSpecSetsResourceNamesAsync()
        {
            // Snippet: ListAnnotationSpecSetsAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> response = dataLabelingServiceClient.ListAnnotationSpecSetsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnnotationSpecSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationSpecSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnnotationSpecSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnnotationSpecSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnnotationSpecSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationSpecSet</summary>
        public void DeleteAnnotationSpecSetRequestObject()
        {
            // Snippet: DeleteAnnotationSpecSet(DeleteAnnotationSpecSetRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            // Make the request
            dataLabelingServiceClient.DeleteAnnotationSpecSet(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationSpecSetAsync</summary>
        public async Task DeleteAnnotationSpecSetRequestObjectAsync()
        {
            // Snippet: DeleteAnnotationSpecSetAsync(DeleteAnnotationSpecSetRequest, CallSettings)
            // Additional: DeleteAnnotationSpecSetAsync(DeleteAnnotationSpecSetRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAnnotationSpecSetRequest request = new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]"),
            };
            // Make the request
            await dataLabelingServiceClient.DeleteAnnotationSpecSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationSpecSet</summary>
        public void DeleteAnnotationSpecSet()
        {
            // Snippet: DeleteAnnotationSpecSet(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/annotationSpecSets/[ANNOTATION_SPEC_SET]";
            // Make the request
            dataLabelingServiceClient.DeleteAnnotationSpecSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationSpecSetAsync</summary>
        public async Task DeleteAnnotationSpecSetAsync()
        {
            // Snippet: DeleteAnnotationSpecSetAsync(string, CallSettings)
            // Additional: DeleteAnnotationSpecSetAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/annotationSpecSets/[ANNOTATION_SPEC_SET]";
            // Make the request
            await dataLabelingServiceClient.DeleteAnnotationSpecSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationSpecSet</summary>
        public void DeleteAnnotationSpecSetResourceNames()
        {
            // Snippet: DeleteAnnotationSpecSet(AnnotationSpecSetName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            AnnotationSpecSetName name = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]");
            // Make the request
            dataLabelingServiceClient.DeleteAnnotationSpecSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnnotationSpecSetAsync</summary>
        public async Task DeleteAnnotationSpecSetResourceNamesAsync()
        {
            // Snippet: DeleteAnnotationSpecSetAsync(AnnotationSpecSetName, CallSettings)
            // Additional: DeleteAnnotationSpecSetAsync(AnnotationSpecSetName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotationSpecSetName name = AnnotationSpecSetName.FromProjectAnnotationSpecSet("[PROJECT]", "[ANNOTATION_SPEC_SET]");
            // Make the request
            await dataLabelingServiceClient.DeleteAnnotationSpecSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstruction</summary>
        public void CreateInstructionRequestObject()
        {
            // Snippet: CreateInstruction(CreateInstructionRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            CreateInstructionRequest request = new CreateInstructionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Instruction = new Instruction(),
            };
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = dataLabelingServiceClient.CreateInstruction(request);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceCreateInstruction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstructionAsync</summary>
        public async Task CreateInstructionRequestObjectAsync()
        {
            // Snippet: CreateInstructionAsync(CreateInstructionRequest, CallSettings)
            // Additional: CreateInstructionAsync(CreateInstructionRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstructionRequest request = new CreateInstructionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Instruction = new Instruction(),
            };
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = await dataLabelingServiceClient.CreateInstructionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceCreateInstructionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstruction</summary>
        public void CreateInstruction()
        {
            // Snippet: CreateInstruction(string, Instruction, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Instruction instruction = new Instruction();
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = dataLabelingServiceClient.CreateInstruction(parent, instruction);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceCreateInstruction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstructionAsync</summary>
        public async Task CreateInstructionAsync()
        {
            // Snippet: CreateInstructionAsync(string, Instruction, CallSettings)
            // Additional: CreateInstructionAsync(string, Instruction, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Instruction instruction = new Instruction();
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = await dataLabelingServiceClient.CreateInstructionAsync(parent, instruction);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceCreateInstructionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstruction</summary>
        public void CreateInstructionResourceNames()
        {
            // Snippet: CreateInstruction(ProjectName, Instruction, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Instruction instruction = new Instruction();
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = dataLabelingServiceClient.CreateInstruction(parent, instruction);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceCreateInstruction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstructionAsync</summary>
        public async Task CreateInstructionResourceNamesAsync()
        {
            // Snippet: CreateInstructionAsync(ProjectName, Instruction, CallSettings)
            // Additional: CreateInstructionAsync(ProjectName, Instruction, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Instruction instruction = new Instruction();
            // Make the request
            Operation<Instruction, CreateInstructionMetadata> response = await dataLabelingServiceClient.CreateInstructionAsync(parent, instruction);

            // Poll until the returned long-running operation is complete
            Operation<Instruction, CreateInstructionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instruction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instruction, CreateInstructionMetadata> retrievedResponse = await dataLabelingServiceClient.PollOnceCreateInstructionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instruction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetInstruction</summary>
        public void GetInstructionRequestObject()
        {
            // Snippet: GetInstruction(GetInstructionRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            // Make the request
            Instruction response = dataLabelingServiceClient.GetInstruction(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstructionAsync</summary>
        public async Task GetInstructionRequestObjectAsync()
        {
            // Snippet: GetInstructionAsync(GetInstructionRequest, CallSettings)
            // Additional: GetInstructionAsync(GetInstructionRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInstructionRequest request = new GetInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            // Make the request
            Instruction response = await dataLabelingServiceClient.GetInstructionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstruction</summary>
        public void GetInstruction()
        {
            // Snippet: GetInstruction(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instructions/[INSTRUCTION]";
            // Make the request
            Instruction response = dataLabelingServiceClient.GetInstruction(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstructionAsync</summary>
        public async Task GetInstructionAsync()
        {
            // Snippet: GetInstructionAsync(string, CallSettings)
            // Additional: GetInstructionAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instructions/[INSTRUCTION]";
            // Make the request
            Instruction response = await dataLabelingServiceClient.GetInstructionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstruction</summary>
        public void GetInstructionResourceNames()
        {
            // Snippet: GetInstruction(InstructionName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            InstructionName name = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]");
            // Make the request
            Instruction response = dataLabelingServiceClient.GetInstruction(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstructionAsync</summary>
        public async Task GetInstructionResourceNamesAsync()
        {
            // Snippet: GetInstructionAsync(InstructionName, CallSettings)
            // Additional: GetInstructionAsync(InstructionName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstructionName name = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]");
            // Make the request
            Instruction response = await dataLabelingServiceClient.GetInstructionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInstructions</summary>
        public void ListInstructionsRequestObject()
        {
            // Snippet: ListInstructions(ListInstructionsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListInstructionsRequest request = new ListInstructionsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListInstructionsResponse, Instruction> response = dataLabelingServiceClient.ListInstructions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instruction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstructionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instruction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instruction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instruction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstructionsAsync</summary>
        public async Task ListInstructionsRequestObjectAsync()
        {
            // Snippet: ListInstructionsAsync(ListInstructionsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInstructionsRequest request = new ListInstructionsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstructionsResponse, Instruction> response = dataLabelingServiceClient.ListInstructionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instruction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstructionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instruction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instruction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instruction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstructions</summary>
        public void ListInstructions()
        {
            // Snippet: ListInstructions(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListInstructionsResponse, Instruction> response = dataLabelingServiceClient.ListInstructions(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instruction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstructionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instruction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instruction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instruction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstructionsAsync</summary>
        public async Task ListInstructionsAsync()
        {
            // Snippet: ListInstructionsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListInstructionsResponse, Instruction> response = dataLabelingServiceClient.ListInstructionsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instruction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstructionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instruction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instruction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instruction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstructions</summary>
        public void ListInstructionsResourceNames()
        {
            // Snippet: ListInstructions(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListInstructionsResponse, Instruction> response = dataLabelingServiceClient.ListInstructions(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instruction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstructionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instruction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instruction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instruction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstructionsAsync</summary>
        public async Task ListInstructionsResourceNamesAsync()
        {
            // Snippet: ListInstructionsAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListInstructionsResponse, Instruction> response = dataLabelingServiceClient.ListInstructionsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instruction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstructionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instruction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instruction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instruction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteInstruction</summary>
        public void DeleteInstructionRequestObject()
        {
            // Snippet: DeleteInstruction(DeleteInstructionRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            // Make the request
            dataLabelingServiceClient.DeleteInstruction(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstructionAsync</summary>
        public async Task DeleteInstructionRequestObjectAsync()
        {
            // Snippet: DeleteInstructionAsync(DeleteInstructionRequest, CallSettings)
            // Additional: DeleteInstructionAsync(DeleteInstructionRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstructionRequest request = new DeleteInstructionRequest
            {
                InstructionName = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]"),
            };
            // Make the request
            await dataLabelingServiceClient.DeleteInstructionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstruction</summary>
        public void DeleteInstruction()
        {
            // Snippet: DeleteInstruction(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instructions/[INSTRUCTION]";
            // Make the request
            dataLabelingServiceClient.DeleteInstruction(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstructionAsync</summary>
        public async Task DeleteInstructionAsync()
        {
            // Snippet: DeleteInstructionAsync(string, CallSettings)
            // Additional: DeleteInstructionAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instructions/[INSTRUCTION]";
            // Make the request
            await dataLabelingServiceClient.DeleteInstructionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstruction</summary>
        public void DeleteInstructionResourceNames()
        {
            // Snippet: DeleteInstruction(InstructionName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            InstructionName name = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]");
            // Make the request
            dataLabelingServiceClient.DeleteInstruction(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstructionAsync</summary>
        public async Task DeleteInstructionResourceNamesAsync()
        {
            // Snippet: DeleteInstructionAsync(InstructionName, CallSettings)
            // Additional: DeleteInstructionAsync(InstructionName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstructionName name = InstructionName.FromProjectInstruction("[PROJECT]", "[INSTRUCTION]");
            // Make the request
            await dataLabelingServiceClient.DeleteInstructionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationRequestObject()
        {
            // Snippet: GetEvaluation(GetEvaluationRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = dataLabelingServiceClient.GetEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationRequestObjectAsync()
        {
            // Snippet: GetEvaluationAsync(GetEvaluationRequest, CallSettings)
            // Additional: GetEvaluationAsync(GetEvaluationRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = await dataLabelingServiceClient.GetEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluation()
        {
            // Snippet: GetEvaluation(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = dataLabelingServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationAsync()
        {
            // Snippet: GetEvaluationAsync(string, CallSettings)
            // Additional: GetEvaluationAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = await dataLabelingServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationResourceNames()
        {
            // Snippet: GetEvaluation(EvaluationName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]");
            // Make the request
            Evaluation response = dataLabelingServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationResourceNamesAsync()
        {
            // Snippet: GetEvaluationAsync(EvaluationName, CallSettings)
            // Additional: GetEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]");
            // Make the request
            Evaluation response = await dataLabelingServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchEvaluations</summary>
        public void SearchEvaluationsRequestObject()
        {
            // Snippet: SearchEvaluations(SearchEvaluationsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            SearchEvaluationsRequest request = new SearchEvaluationsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchEvaluationsResponse, Evaluation> response = dataLabelingServiceClient.SearchEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEvaluationsAsync</summary>
        public async Task SearchEvaluationsRequestObjectAsync()
        {
            // Snippet: SearchEvaluationsAsync(SearchEvaluationsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchEvaluationsRequest request = new SearchEvaluationsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> response = dataLabelingServiceClient.SearchEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEvaluations</summary>
        public void SearchEvaluations()
        {
            // Snippet: SearchEvaluations(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/evaluations/[EVALUATION]";
            string filter = "";
            // Make the request
            PagedEnumerable<SearchEvaluationsResponse, Evaluation> response = dataLabelingServiceClient.SearchEvaluations(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEvaluationsAsync</summary>
        public async Task SearchEvaluationsAsync()
        {
            // Snippet: SearchEvaluationsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/evaluations/[EVALUATION]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> response = dataLabelingServiceClient.SearchEvaluationsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEvaluations</summary>
        public void SearchEvaluationsResourceNames()
        {
            // Snippet: SearchEvaluations(EvaluationName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]");
            string filter = "";
            // Make the request
            PagedEnumerable<SearchEvaluationsResponse, Evaluation> response = dataLabelingServiceClient.SearchEvaluations(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEvaluationsAsync</summary>
        public async Task SearchEvaluationsResourceNamesAsync()
        {
            // Snippet: SearchEvaluationsAsync(EvaluationName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> response = dataLabelingServiceClient.SearchEvaluationsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchExampleComparisons</summary>
        public void SearchExampleComparisonsRequestObject()
        {
            // Snippet: SearchExampleComparisons(SearchExampleComparisonsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            SearchExampleComparisonsRequest request = new SearchExampleComparisonsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            // Make the request
            PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> response = dataLabelingServiceClient.SearchExampleComparisons(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchExampleComparisonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchExampleComparisonsResponse.Types.ExampleComparison> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchExampleComparisonsAsync</summary>
        public async Task SearchExampleComparisonsRequestObjectAsync()
        {
            // Snippet: SearchExampleComparisonsAsync(SearchExampleComparisonsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchExampleComparisonsRequest request = new SearchExampleComparisonsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> response = dataLabelingServiceClient.SearchExampleComparisonsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchExampleComparisonsResponse.Types.ExampleComparison item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchExampleComparisonsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchExampleComparisonsResponse.Types.ExampleComparison> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchExampleComparisons</summary>
        public void SearchExampleComparisons()
        {
            // Snippet: SearchExampleComparisons(string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/evaluations/[EVALUATION]";
            // Make the request
            PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> response = dataLabelingServiceClient.SearchExampleComparisons(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchExampleComparisonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchExampleComparisonsResponse.Types.ExampleComparison> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchExampleComparisonsAsync</summary>
        public async Task SearchExampleComparisonsAsync()
        {
            // Snippet: SearchExampleComparisonsAsync(string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/evaluations/[EVALUATION]";
            // Make the request
            PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> response = dataLabelingServiceClient.SearchExampleComparisonsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchExampleComparisonsResponse.Types.ExampleComparison item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchExampleComparisonsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchExampleComparisonsResponse.Types.ExampleComparison> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchExampleComparisons</summary>
        public void SearchExampleComparisonsResourceNames()
        {
            // Snippet: SearchExampleComparisons(EvaluationName, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]");
            // Make the request
            PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> response = dataLabelingServiceClient.SearchExampleComparisons(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchExampleComparisonsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchExampleComparisonsResponse.Types.ExampleComparison> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchExampleComparisonsAsync</summary>
        public async Task SearchExampleComparisonsResourceNamesAsync()
        {
            // Snippet: SearchExampleComparisonsAsync(EvaluationName, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectDatasetEvaluation("[PROJECT]", "[DATASET]", "[EVALUATION]");
            // Make the request
            PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> response = dataLabelingServiceClient.SearchExampleComparisonsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchExampleComparisonsResponse.Types.ExampleComparison item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchExampleComparisonsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchExampleComparisonsResponse.Types.ExampleComparison> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchExampleComparisonsResponse.Types.ExampleComparison item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationJob</summary>
        public void CreateEvaluationJobRequestObject()
        {
            // Snippet: CreateEvaluationJob(CreateEvaluationJobRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob(),
            };
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.CreateEvaluationJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationJobAsync</summary>
        public async Task CreateEvaluationJobRequestObjectAsync()
        {
            // Snippet: CreateEvaluationJobAsync(CreateEvaluationJobRequest, CallSettings)
            // Additional: CreateEvaluationJobAsync(CreateEvaluationJobRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEvaluationJobRequest request = new CreateEvaluationJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Job = new EvaluationJob(),
            };
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.CreateEvaluationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationJob</summary>
        public void CreateEvaluationJob()
        {
            // Snippet: CreateEvaluationJob(string, EvaluationJob, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            EvaluationJob job = new EvaluationJob();
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.CreateEvaluationJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationJobAsync</summary>
        public async Task CreateEvaluationJobAsync()
        {
            // Snippet: CreateEvaluationJobAsync(string, EvaluationJob, CallSettings)
            // Additional: CreateEvaluationJobAsync(string, EvaluationJob, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            EvaluationJob job = new EvaluationJob();
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.CreateEvaluationJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationJob</summary>
        public void CreateEvaluationJobResourceNames()
        {
            // Snippet: CreateEvaluationJob(ProjectName, EvaluationJob, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            EvaluationJob job = new EvaluationJob();
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.CreateEvaluationJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationJobAsync</summary>
        public async Task CreateEvaluationJobResourceNamesAsync()
        {
            // Snippet: CreateEvaluationJobAsync(ProjectName, EvaluationJob, CallSettings)
            // Additional: CreateEvaluationJobAsync(ProjectName, EvaluationJob, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            EvaluationJob job = new EvaluationJob();
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.CreateEvaluationJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationJob</summary>
        public void UpdateEvaluationJobRequestObject()
        {
            // Snippet: UpdateEvaluationJob(UpdateEvaluationJobRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            UpdateEvaluationJobRequest request = new UpdateEvaluationJobRequest
            {
                EvaluationJob = new EvaluationJob(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.UpdateEvaluationJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationJobAsync</summary>
        public async Task UpdateEvaluationJobRequestObjectAsync()
        {
            // Snippet: UpdateEvaluationJobAsync(UpdateEvaluationJobRequest, CallSettings)
            // Additional: UpdateEvaluationJobAsync(UpdateEvaluationJobRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEvaluationJobRequest request = new UpdateEvaluationJobRequest
            {
                EvaluationJob = new EvaluationJob(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.UpdateEvaluationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationJob</summary>
        public void UpdateEvaluationJob()
        {
            // Snippet: UpdateEvaluationJob(EvaluationJob, FieldMask, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationJob evaluationJob = new EvaluationJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.UpdateEvaluationJob(evaluationJob, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationJobAsync</summary>
        public async Task UpdateEvaluationJobAsync()
        {
            // Snippet: UpdateEvaluationJobAsync(EvaluationJob, FieldMask, CallSettings)
            // Additional: UpdateEvaluationJobAsync(EvaluationJob, FieldMask, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationJob evaluationJob = new EvaluationJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.UpdateEvaluationJobAsync(evaluationJob, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationJob</summary>
        public void GetEvaluationJobRequestObject()
        {
            // Snippet: GetEvaluationJob(GetEvaluationJobRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.GetEvaluationJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationJobAsync</summary>
        public async Task GetEvaluationJobRequestObjectAsync()
        {
            // Snippet: GetEvaluationJobAsync(GetEvaluationJobRequest, CallSettings)
            // Additional: GetEvaluationJobAsync(GetEvaluationJobRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationJobRequest request = new GetEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.GetEvaluationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationJob</summary>
        public void GetEvaluationJob()
        {
            // Snippet: GetEvaluationJob(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.GetEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationJobAsync</summary>
        public async Task GetEvaluationJobAsync()
        {
            // Snippet: GetEvaluationJobAsync(string, CallSettings)
            // Additional: GetEvaluationJobAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.GetEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationJob</summary>
        public void GetEvaluationJobResourceNames()
        {
            // Snippet: GetEvaluationJob(EvaluationJobName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            EvaluationJob response = dataLabelingServiceClient.GetEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationJobAsync</summary>
        public async Task GetEvaluationJobResourceNamesAsync()
        {
            // Snippet: GetEvaluationJobAsync(EvaluationJobName, CallSettings)
            // Additional: GetEvaluationJobAsync(EvaluationJobName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            EvaluationJob response = await dataLabelingServiceClient.GetEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEvaluationJob</summary>
        public void PauseEvaluationJobRequestObject()
        {
            // Snippet: PauseEvaluationJob(PauseEvaluationJobRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            dataLabelingServiceClient.PauseEvaluationJob(request);
            // End snippet
        }

        /// <summary>Snippet for PauseEvaluationJobAsync</summary>
        public async Task PauseEvaluationJobRequestObjectAsync()
        {
            // Snippet: PauseEvaluationJobAsync(PauseEvaluationJobRequest, CallSettings)
            // Additional: PauseEvaluationJobAsync(PauseEvaluationJobRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            PauseEvaluationJobRequest request = new PauseEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            await dataLabelingServiceClient.PauseEvaluationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseEvaluationJob</summary>
        public void PauseEvaluationJob()
        {
            // Snippet: PauseEvaluationJob(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            dataLabelingServiceClient.PauseEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEvaluationJobAsync</summary>
        public async Task PauseEvaluationJobAsync()
        {
            // Snippet: PauseEvaluationJobAsync(string, CallSettings)
            // Additional: PauseEvaluationJobAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            await dataLabelingServiceClient.PauseEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEvaluationJob</summary>
        public void PauseEvaluationJobResourceNames()
        {
            // Snippet: PauseEvaluationJob(EvaluationJobName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            dataLabelingServiceClient.PauseEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEvaluationJobAsync</summary>
        public async Task PauseEvaluationJobResourceNamesAsync()
        {
            // Snippet: PauseEvaluationJobAsync(EvaluationJobName, CallSettings)
            // Additional: PauseEvaluationJobAsync(EvaluationJobName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            await dataLabelingServiceClient.PauseEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEvaluationJob</summary>
        public void ResumeEvaluationJobRequestObject()
        {
            // Snippet: ResumeEvaluationJob(ResumeEvaluationJobRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            dataLabelingServiceClient.ResumeEvaluationJob(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeEvaluationJobAsync</summary>
        public async Task ResumeEvaluationJobRequestObjectAsync()
        {
            // Snippet: ResumeEvaluationJobAsync(ResumeEvaluationJobRequest, CallSettings)
            // Additional: ResumeEvaluationJobAsync(ResumeEvaluationJobRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeEvaluationJobRequest request = new ResumeEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            await dataLabelingServiceClient.ResumeEvaluationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeEvaluationJob</summary>
        public void ResumeEvaluationJob()
        {
            // Snippet: ResumeEvaluationJob(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            dataLabelingServiceClient.ResumeEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEvaluationJobAsync</summary>
        public async Task ResumeEvaluationJobAsync()
        {
            // Snippet: ResumeEvaluationJobAsync(string, CallSettings)
            // Additional: ResumeEvaluationJobAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            await dataLabelingServiceClient.ResumeEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEvaluationJob</summary>
        public void ResumeEvaluationJobResourceNames()
        {
            // Snippet: ResumeEvaluationJob(EvaluationJobName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            dataLabelingServiceClient.ResumeEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEvaluationJobAsync</summary>
        public async Task ResumeEvaluationJobResourceNamesAsync()
        {
            // Snippet: ResumeEvaluationJobAsync(EvaluationJobName, CallSettings)
            // Additional: ResumeEvaluationJobAsync(EvaluationJobName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            await dataLabelingServiceClient.ResumeEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationJob</summary>
        public void DeleteEvaluationJobRequestObject()
        {
            // Snippet: DeleteEvaluationJob(DeleteEvaluationJobRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            dataLabelingServiceClient.DeleteEvaluationJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationJobAsync</summary>
        public async Task DeleteEvaluationJobRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationJobAsync(DeleteEvaluationJobRequest, CallSettings)
            // Additional: DeleteEvaluationJobAsync(DeleteEvaluationJobRequest, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationJobRequest request = new DeleteEvaluationJobRequest
            {
                EvaluationJobName = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]"),
            };
            // Make the request
            await dataLabelingServiceClient.DeleteEvaluationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationJob</summary>
        public void DeleteEvaluationJob()
        {
            // Snippet: DeleteEvaluationJob(string, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            dataLabelingServiceClient.DeleteEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationJobAsync</summary>
        public async Task DeleteEvaluationJobAsync()
        {
            // Snippet: DeleteEvaluationJobAsync(string, CallSettings)
            // Additional: DeleteEvaluationJobAsync(string, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/evaluationJobs/[EVALUATION_JOB]";
            // Make the request
            await dataLabelingServiceClient.DeleteEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationJob</summary>
        public void DeleteEvaluationJobResourceNames()
        {
            // Snippet: DeleteEvaluationJob(EvaluationJobName, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            dataLabelingServiceClient.DeleteEvaluationJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationJobAsync</summary>
        public async Task DeleteEvaluationJobResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationJobAsync(EvaluationJobName, CallSettings)
            // Additional: DeleteEvaluationJobAsync(EvaluationJobName, CancellationToken)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationJobName name = EvaluationJobName.FromProjectEvaluationJob("[PROJECT]", "[EVALUATION_JOB]");
            // Make the request
            await dataLabelingServiceClient.DeleteEvaluationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationJobs</summary>
        public void ListEvaluationJobsRequestObject()
        {
            // Snippet: ListEvaluationJobs(ListEvaluationJobsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationJobsRequest request = new ListEvaluationJobsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> response = dataLabelingServiceClient.ListEvaluationJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationJobsAsync</summary>
        public async Task ListEvaluationJobsRequestObjectAsync()
        {
            // Snippet: ListEvaluationJobsAsync(ListEvaluationJobsRequest, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationJobsRequest request = new ListEvaluationJobsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> response = dataLabelingServiceClient.ListEvaluationJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EvaluationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationJobs</summary>
        public void ListEvaluationJobs()
        {
            // Snippet: ListEvaluationJobs(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> response = dataLabelingServiceClient.ListEvaluationJobs(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationJobsAsync</summary>
        public async Task ListEvaluationJobsAsync()
        {
            // Snippet: ListEvaluationJobsAsync(string, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> response = dataLabelingServiceClient.ListEvaluationJobsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EvaluationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationJobs</summary>
        public void ListEvaluationJobsResourceNames()
        {
            // Snippet: ListEvaluationJobs(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> response = dataLabelingServiceClient.ListEvaluationJobs(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationJobsAsync</summary>
        public async Task ListEvaluationJobsResourceNamesAsync()
        {
            // Snippet: ListEvaluationJobsAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = await DataLabelingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> response = dataLabelingServiceClient.ListEvaluationJobsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EvaluationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationJob item in singlePage)
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
