// Copyright 2026 Google LLC
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
    using Google.DevicesAndServices.Health.V4;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataPointsServiceClientSnippets
    {
        /// <summary>Snippet for ListDataPoints</summary>
        public void ListDataPointsRequestObject()
        {
            // Snippet: ListDataPoints(ListDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            ListDataPointsRequest request = new ListDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataPointsResponse, DataPoint> response = dataPointsServiceClient.ListDataPoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPointsAsync</summary>
        public async Task ListDataPointsRequestObjectAsync()
        {
            // Snippet: ListDataPointsAsync(ListDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataPointsRequest request = new ListDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> response = dataPointsServiceClient.ListDataPointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPoints</summary>
        public void ListDataPoints()
        {
            // Snippet: ListDataPoints(string, string, int?, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "users/[USER]/dataTypes/[DATA_TYPE]";
            // Make the request
            PagedEnumerable<ListDataPointsResponse, DataPoint> response = dataPointsServiceClient.ListDataPoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPointsAsync</summary>
        public async Task ListDataPointsAsync()
        {
            // Snippet: ListDataPointsAsync(string, string, int?, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]/dataTypes/[DATA_TYPE]";
            // Make the request
            PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> response = dataPointsServiceClient.ListDataPointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPoints</summary>
        public void ListDataPointsResourceNames()
        {
            // Snippet: ListDataPoints(DataTypeName, string, int?, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            DataTypeName parent = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]");
            // Make the request
            PagedEnumerable<ListDataPointsResponse, DataPoint> response = dataPointsServiceClient.ListDataPoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataPointsAsync</summary>
        public async Task ListDataPointsResourceNamesAsync()
        {
            // Snippet: ListDataPointsAsync(DataTypeName, string, int?, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTypeName parent = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]");
            // Make the request
            PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> response = dataPointsServiceClient.ListDataPointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDataPoint</summary>
        public void CreateDataPointRequestObject()
        {
            // Snippet: CreateDataPoint(CreateDataPointRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            CreateDataPointRequest request = new CreateDataPointRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                DataPoint = new DataPoint(),
            };
            // Make the request
            Operation<DataPoint, CreateDataPointOperationMetadata> response = dataPointsServiceClient.CreateDataPoint(request);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, CreateDataPointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, CreateDataPointOperationMetadata> retrievedResponse = dataPointsServiceClient.PollOnceCreateDataPoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataPointAsync</summary>
        public async Task CreateDataPointRequestObjectAsync()
        {
            // Snippet: CreateDataPointAsync(CreateDataPointRequest, CallSettings)
            // Additional: CreateDataPointAsync(CreateDataPointRequest, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataPointRequest request = new CreateDataPointRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                DataPoint = new DataPoint(),
            };
            // Make the request
            Operation<DataPoint, CreateDataPointOperationMetadata> response = await dataPointsServiceClient.CreateDataPointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, CreateDataPointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, CreateDataPointOperationMetadata> retrievedResponse = await dataPointsServiceClient.PollOnceCreateDataPointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataPoint</summary>
        public void CreateDataPoint()
        {
            // Snippet: CreateDataPoint(string, DataPoint, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "users/[USER]/dataTypes/[DATA_TYPE]";
            DataPoint dataPoint = new DataPoint();
            // Make the request
            Operation<DataPoint, CreateDataPointOperationMetadata> response = dataPointsServiceClient.CreateDataPoint(parent, dataPoint);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, CreateDataPointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, CreateDataPointOperationMetadata> retrievedResponse = dataPointsServiceClient.PollOnceCreateDataPoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataPointAsync</summary>
        public async Task CreateDataPointAsync()
        {
            // Snippet: CreateDataPointAsync(string, DataPoint, CallSettings)
            // Additional: CreateDataPointAsync(string, DataPoint, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "users/[USER]/dataTypes/[DATA_TYPE]";
            DataPoint dataPoint = new DataPoint();
            // Make the request
            Operation<DataPoint, CreateDataPointOperationMetadata> response = await dataPointsServiceClient.CreateDataPointAsync(parent, dataPoint);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, CreateDataPointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, CreateDataPointOperationMetadata> retrievedResponse = await dataPointsServiceClient.PollOnceCreateDataPointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataPoint</summary>
        public void CreateDataPointResourceNames()
        {
            // Snippet: CreateDataPoint(DataTypeName, DataPoint, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            DataTypeName parent = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]");
            DataPoint dataPoint = new DataPoint();
            // Make the request
            Operation<DataPoint, CreateDataPointOperationMetadata> response = dataPointsServiceClient.CreateDataPoint(parent, dataPoint);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, CreateDataPointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, CreateDataPointOperationMetadata> retrievedResponse = dataPointsServiceClient.PollOnceCreateDataPoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataPointAsync</summary>
        public async Task CreateDataPointResourceNamesAsync()
        {
            // Snippet: CreateDataPointAsync(DataTypeName, DataPoint, CallSettings)
            // Additional: CreateDataPointAsync(DataTypeName, DataPoint, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTypeName parent = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]");
            DataPoint dataPoint = new DataPoint();
            // Make the request
            Operation<DataPoint, CreateDataPointOperationMetadata> response = await dataPointsServiceClient.CreateDataPointAsync(parent, dataPoint);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, CreateDataPointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, CreateDataPointOperationMetadata> retrievedResponse = await dataPointsServiceClient.PollOnceCreateDataPointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPoint</summary>
        public void UpdateDataPointRequestObject()
        {
            // Snippet: UpdateDataPoint(UpdateDataPointRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataPointRequest request = new UpdateDataPointRequest
            {
                DataPoint = new DataPoint(),
            };
            // Make the request
            Operation<DataPoint, UpdateDataPointOperationMetadata> response = dataPointsServiceClient.UpdateDataPoint(request);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, UpdateDataPointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, UpdateDataPointOperationMetadata> retrievedResponse = dataPointsServiceClient.PollOnceUpdateDataPoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPointAsync</summary>
        public async Task UpdateDataPointRequestObjectAsync()
        {
            // Snippet: UpdateDataPointAsync(UpdateDataPointRequest, CallSettings)
            // Additional: UpdateDataPointAsync(UpdateDataPointRequest, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataPointRequest request = new UpdateDataPointRequest
            {
                DataPoint = new DataPoint(),
            };
            // Make the request
            Operation<DataPoint, UpdateDataPointOperationMetadata> response = await dataPointsServiceClient.UpdateDataPointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, UpdateDataPointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, UpdateDataPointOperationMetadata> retrievedResponse = await dataPointsServiceClient.PollOnceUpdateDataPointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPoint</summary>
        public void UpdateDataPoint()
        {
            // Snippet: UpdateDataPoint(DataPoint, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            DataPoint dataPoint = new DataPoint();
            // Make the request
            Operation<DataPoint, UpdateDataPointOperationMetadata> response = dataPointsServiceClient.UpdateDataPoint(dataPoint);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, UpdateDataPointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, UpdateDataPointOperationMetadata> retrievedResponse = dataPointsServiceClient.PollOnceUpdateDataPoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataPointAsync</summary>
        public async Task UpdateDataPointAsync()
        {
            // Snippet: UpdateDataPointAsync(DataPoint, CallSettings)
            // Additional: UpdateDataPointAsync(DataPoint, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataPoint dataPoint = new DataPoint();
            // Make the request
            Operation<DataPoint, UpdateDataPointOperationMetadata> response = await dataPointsServiceClient.UpdateDataPointAsync(dataPoint);

            // Poll until the returned long-running operation is complete
            Operation<DataPoint, UpdateDataPointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataPoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataPoint, UpdateDataPointOperationMetadata> retrievedResponse = await dataPointsServiceClient.PollOnceUpdateDataPointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataPoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataPoints</summary>
        public void BatchDeleteDataPointsRequestObject()
        {
            // Snippet: BatchDeleteDataPoints(BatchDeleteDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteDataPointsRequest request = new BatchDeleteDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                DataPointNames =
                {
                    DataPointName.FromUserDataTypeDataPoint("[USER]", "[DATA_TYPE]", "[DATA_POINT]"),
                },
            };
            // Make the request
            Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> response = dataPointsServiceClient.BatchDeleteDataPoints(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeleteDataPointsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> retrievedResponse = dataPointsServiceClient.PollOnceBatchDeleteDataPoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteDataPointsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataPointsAsync</summary>
        public async Task BatchDeleteDataPointsRequestObjectAsync()
        {
            // Snippet: BatchDeleteDataPointsAsync(BatchDeleteDataPointsRequest, CallSettings)
            // Additional: BatchDeleteDataPointsAsync(BatchDeleteDataPointsRequest, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteDataPointsRequest request = new BatchDeleteDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                DataPointNames =
                {
                    DataPointName.FromUserDataTypeDataPoint("[USER]", "[DATA_TYPE]", "[DATA_POINT]"),
                },
            };
            // Make the request
            Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> response = await dataPointsServiceClient.BatchDeleteDataPointsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeleteDataPointsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> retrievedResponse = await dataPointsServiceClient.PollOnceBatchDeleteDataPointsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteDataPointsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconcileDataPoints</summary>
        public void ReconcileDataPointsRequestObject()
        {
            // Snippet: ReconcileDataPoints(ReconcileDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            ReconcileDataPointsRequest request = new ReconcileDataPointsRequest
            {
                Parent = "",
                Filter = "",
                DataSourceFamily = "",
            };
            // Make the request
            PagedEnumerable<ReconcileDataPointsResponse, ReconciledDataPoint> response = dataPointsServiceClient.ReconcileDataPoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReconciledDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReconcileDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReconciledDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReconciledDataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReconciledDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReconcileDataPointsAsync</summary>
        public async Task ReconcileDataPointsRequestObjectAsync()
        {
            // Snippet: ReconcileDataPointsAsync(ReconcileDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReconcileDataPointsRequest request = new ReconcileDataPointsRequest
            {
                Parent = "",
                Filter = "",
                DataSourceFamily = "",
            };
            // Make the request
            PagedAsyncEnumerable<ReconcileDataPointsResponse, ReconciledDataPoint> response = dataPointsServiceClient.ReconcileDataPointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReconciledDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReconcileDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReconciledDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReconciledDataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReconciledDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RollUpDataPoints</summary>
        public void RollUpDataPointsRequestObject()
        {
            // Snippet: RollUpDataPoints(RollUpDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            RollUpDataPointsRequest request = new RollUpDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                Range = new Interval(),
                WindowSize = new Duration(),
                DataSourceFamily = "",
            };
            // Make the request
            PagedEnumerable<RollUpDataPointsResponse, RollupDataPoint> response = dataPointsServiceClient.RollUpDataPoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RollupDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RollUpDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupDataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RollUpDataPointsAsync</summary>
        public async Task RollUpDataPointsRequestObjectAsync()
        {
            // Snippet: RollUpDataPointsAsync(RollUpDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RollUpDataPointsRequest request = new RollUpDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                Range = new Interval(),
                WindowSize = new Duration(),
                DataSourceFamily = "",
            };
            // Make the request
            PagedAsyncEnumerable<RollUpDataPointsResponse, RollupDataPoint> response = dataPointsServiceClient.RollUpDataPointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RollupDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RollUpDataPointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupDataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DailyRollUpDataPoints</summary>
        public void DailyRollUpDataPointsRequestObject()
        {
            // Snippet: DailyRollUpDataPoints(DailyRollUpDataPointsRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            DailyRollUpDataPointsRequest request = new DailyRollUpDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                Range = new CivilTimeInterval(),
                WindowSizeDays = 0,
                PageSize = 0,
                PageToken = "",
                DataSourceFamily = "",
            };
            // Make the request
            DailyRollUpDataPointsResponse response = dataPointsServiceClient.DailyRollUpDataPoints(request);
            // End snippet
        }

        /// <summary>Snippet for DailyRollUpDataPointsAsync</summary>
        public async Task DailyRollUpDataPointsRequestObjectAsync()
        {
            // Snippet: DailyRollUpDataPointsAsync(DailyRollUpDataPointsRequest, CallSettings)
            // Additional: DailyRollUpDataPointsAsync(DailyRollUpDataPointsRequest, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DailyRollUpDataPointsRequest request = new DailyRollUpDataPointsRequest
            {
                ParentAsDataTypeName = DataTypeName.FromUserDataType("[USER]", "[DATA_TYPE]"),
                Range = new CivilTimeInterval(),
                WindowSizeDays = 0,
                PageSize = 0,
                PageToken = "",
                DataSourceFamily = "",
            };
            // Make the request
            DailyRollUpDataPointsResponse response = await dataPointsServiceClient.DailyRollUpDataPointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportExerciseTcx</summary>
        public void ExportExerciseTcxRequestObject()
        {
            // Snippet: ExportExerciseTcx(ExportExerciseTcxRequest, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            ExportExerciseTcxRequest request = new ExportExerciseTcxRequest
            {
                DataPointName = DataPointName.FromUserDataTypeDataPoint("[USER]", "[DATA_TYPE]", "[DATA_POINT]"),
                PartialData = false,
            };
            // Make the request
            ExportExerciseTcxResponse response = dataPointsServiceClient.ExportExerciseTcx(request);
            // End snippet
        }

        /// <summary>Snippet for ExportExerciseTcxAsync</summary>
        public async Task ExportExerciseTcxRequestObjectAsync()
        {
            // Snippet: ExportExerciseTcxAsync(ExportExerciseTcxRequest, CallSettings)
            // Additional: ExportExerciseTcxAsync(ExportExerciseTcxRequest, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportExerciseTcxRequest request = new ExportExerciseTcxRequest
            {
                DataPointName = DataPointName.FromUserDataTypeDataPoint("[USER]", "[DATA_TYPE]", "[DATA_POINT]"),
                PartialData = false,
            };
            // Make the request
            ExportExerciseTcxResponse response = await dataPointsServiceClient.ExportExerciseTcxAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportExerciseTcx</summary>
        public void ExportExerciseTcx()
        {
            // Snippet: ExportExerciseTcx(string, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/dataTypes/[DATA_TYPE]/dataPoints/[DATA_POINT]";
            // Make the request
            ExportExerciseTcxResponse response = dataPointsServiceClient.ExportExerciseTcx(name);
            // End snippet
        }

        /// <summary>Snippet for ExportExerciseTcxAsync</summary>
        public async Task ExportExerciseTcxAsync()
        {
            // Snippet: ExportExerciseTcxAsync(string, CallSettings)
            // Additional: ExportExerciseTcxAsync(string, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/dataTypes/[DATA_TYPE]/dataPoints/[DATA_POINT]";
            // Make the request
            ExportExerciseTcxResponse response = await dataPointsServiceClient.ExportExerciseTcxAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportExerciseTcx</summary>
        public void ExportExerciseTcxResourceNames()
        {
            // Snippet: ExportExerciseTcx(DataPointName, CallSettings)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = DataPointsServiceClient.Create();
            // Initialize request argument(s)
            DataPointName name = DataPointName.FromUserDataTypeDataPoint("[USER]", "[DATA_TYPE]", "[DATA_POINT]");
            // Make the request
            ExportExerciseTcxResponse response = dataPointsServiceClient.ExportExerciseTcx(name);
            // End snippet
        }

        /// <summary>Snippet for ExportExerciseTcxAsync</summary>
        public async Task ExportExerciseTcxResourceNamesAsync()
        {
            // Snippet: ExportExerciseTcxAsync(DataPointName, CallSettings)
            // Additional: ExportExerciseTcxAsync(DataPointName, CancellationToken)
            // Create client
            DataPointsServiceClient dataPointsServiceClient = await DataPointsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataPointName name = DataPointName.FromUserDataTypeDataPoint("[USER]", "[DATA_TYPE]", "[DATA_POINT]");
            // Make the request
            ExportExerciseTcxResponse response = await dataPointsServiceClient.ExportExerciseTcxAsync(name);
            // End snippet
        }
    }
}
