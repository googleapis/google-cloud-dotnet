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

namespace Google.Cloud.BigQuery.DataTransfer.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.BigQuery.DataTransfer.V1;
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
    public class GeneratedDataSourceServiceClientSnippets
    {
        /// <summary>Snippet for UpdateTransferRunAsync</summary>
        public async Task UpdateTransferRunAsync_RequestObject()
        {
            // Snippet: UpdateTransferRunAsync(UpdateTransferRunRequest,CallSettings)
            // Additional: UpdateTransferRunAsync(UpdateTransferRunRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransferRunRequest request = new UpdateTransferRunRequest();
            // Make the request
            TransferRun response = await dataSourceServiceClient.UpdateTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferRun</summary>
        public void UpdateTransferRun_RequestObject()
        {
            // Snippet: UpdateTransferRun(UpdateTransferRunRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            UpdateTransferRunRequest request = new UpdateTransferRunRequest();
            // Make the request
            TransferRun response = dataSourceServiceClient.UpdateTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for LogTransferRunMessagesAsync</summary>
        public async Task LogTransferRunMessagesAsync_RequestObject()
        {
            // Snippet: LogTransferRunMessagesAsync(LogTransferRunMessagesRequest,CallSettings)
            // Additional: LogTransferRunMessagesAsync(LogTransferRunMessagesRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            LogTransferRunMessagesRequest request = new LogTransferRunMessagesRequest();
            // Make the request
            await dataSourceServiceClient.LogTransferRunMessagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LogTransferRunMessages</summary>
        public void LogTransferRunMessages_RequestObject()
        {
            // Snippet: LogTransferRunMessages(LogTransferRunMessagesRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            LogTransferRunMessagesRequest request = new LogTransferRunMessagesRequest();
            // Make the request
            dataSourceServiceClient.LogTransferRunMessages(request);
            // End snippet
        }

        /// <summary>Snippet for StartBigQueryJobsAsync</summary>
        public async Task StartBigQueryJobsAsync_RequestObject()
        {
            // Snippet: StartBigQueryJobsAsync(StartBigQueryJobsRequest,CallSettings)
            // Additional: StartBigQueryJobsAsync(StartBigQueryJobsRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartBigQueryJobsRequest request = new StartBigQueryJobsRequest();
            // Make the request
            await dataSourceServiceClient.StartBigQueryJobsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartBigQueryJobs</summary>
        public void StartBigQueryJobs_RequestObject()
        {
            // Snippet: StartBigQueryJobs(StartBigQueryJobsRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            StartBigQueryJobsRequest request = new StartBigQueryJobsRequest();
            // Make the request
            dataSourceServiceClient.StartBigQueryJobs(request);
            // End snippet
        }

        /// <summary>Snippet for FinishRunAsync</summary>
        public async Task FinishRunAsync_RequestObject()
        {
            // Snippet: FinishRunAsync(FinishRunRequest,CallSettings)
            // Additional: FinishRunAsync(FinishRunRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            FinishRunRequest request = new FinishRunRequest();
            // Make the request
            await dataSourceServiceClient.FinishRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FinishRun</summary>
        public void FinishRun_RequestObject()
        {
            // Snippet: FinishRun(FinishRunRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            FinishRunRequest request = new FinishRunRequest();
            // Make the request
            dataSourceServiceClient.FinishRun(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSourceDefinitionAsync</summary>
        public async Task CreateDataSourceDefinitionAsync_RequestObject()
        {
            // Snippet: CreateDataSourceDefinitionAsync(CreateDataSourceDefinitionRequest,CallSettings)
            // Additional: CreateDataSourceDefinitionAsync(CreateDataSourceDefinitionRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataSourceDefinitionRequest request = new CreateDataSourceDefinitionRequest();
            // Make the request
            DataSourceDefinition response = await dataSourceServiceClient.CreateDataSourceDefinitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSourceDefinition</summary>
        public void CreateDataSourceDefinition_RequestObject()
        {
            // Snippet: CreateDataSourceDefinition(CreateDataSourceDefinitionRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            CreateDataSourceDefinitionRequest request = new CreateDataSourceDefinitionRequest();
            // Make the request
            DataSourceDefinition response = dataSourceServiceClient.CreateDataSourceDefinition(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSourceDefinitionAsync</summary>
        public async Task UpdateDataSourceDefinitionAsync_RequestObject()
        {
            // Snippet: UpdateDataSourceDefinitionAsync(UpdateDataSourceDefinitionRequest,CallSettings)
            // Additional: UpdateDataSourceDefinitionAsync(UpdateDataSourceDefinitionRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataSourceDefinitionRequest request = new UpdateDataSourceDefinitionRequest();
            // Make the request
            DataSourceDefinition response = await dataSourceServiceClient.UpdateDataSourceDefinitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSourceDefinition</summary>
        public void UpdateDataSourceDefinition_RequestObject()
        {
            // Snippet: UpdateDataSourceDefinition(UpdateDataSourceDefinitionRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataSourceDefinitionRequest request = new UpdateDataSourceDefinitionRequest();
            // Make the request
            DataSourceDefinition response = dataSourceServiceClient.UpdateDataSourceDefinition(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSourceDefinitionAsync</summary>
        public async Task DeleteDataSourceDefinitionAsync_RequestObject()
        {
            // Snippet: DeleteDataSourceDefinitionAsync(DeleteDataSourceDefinitionRequest,CallSettings)
            // Additional: DeleteDataSourceDefinitionAsync(DeleteDataSourceDefinitionRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataSourceDefinitionRequest request = new DeleteDataSourceDefinitionRequest();
            // Make the request
            await dataSourceServiceClient.DeleteDataSourceDefinitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSourceDefinition</summary>
        public void DeleteDataSourceDefinition_RequestObject()
        {
            // Snippet: DeleteDataSourceDefinition(DeleteDataSourceDefinitionRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataSourceDefinitionRequest request = new DeleteDataSourceDefinitionRequest();
            // Make the request
            dataSourceServiceClient.DeleteDataSourceDefinition(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceDefinitionAsync</summary>
        public async Task GetDataSourceDefinitionAsync_RequestObject()
        {
            // Snippet: GetDataSourceDefinitionAsync(GetDataSourceDefinitionRequest,CallSettings)
            // Additional: GetDataSourceDefinitionAsync(GetDataSourceDefinitionRequest,CancellationToken)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSourceDefinitionRequest request = new GetDataSourceDefinitionRequest();
            // Make the request
            DataSourceDefinition response = await dataSourceServiceClient.GetDataSourceDefinitionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceDefinition</summary>
        public void GetDataSourceDefinition_RequestObject()
        {
            // Snippet: GetDataSourceDefinition(GetDataSourceDefinitionRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            GetDataSourceDefinitionRequest request = new GetDataSourceDefinitionRequest();
            // Make the request
            DataSourceDefinition response = dataSourceServiceClient.GetDataSourceDefinition(request);
            // End snippet
        }

        /// <summary>Snippet for ListDataSourceDefinitionsAsync</summary>
        public async Task ListDataSourceDefinitionsAsync_RequestObject()
        {
            // Snippet: ListDataSourceDefinitionsAsync(ListDataSourceDefinitionsRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = await DataSourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataSourceDefinitionsRequest request = new ListDataSourceDefinitionsRequest();
            // Make the request
            PagedAsyncEnumerable<ListDataSourceDefinitionsResponse, DataSourceDefinition> response =
                dataSourceServiceClient.ListDataSourceDefinitionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataSourceDefinition item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataSourceDefinitionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSourceDefinition item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSourceDefinition> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSourceDefinition item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourceDefinitions</summary>
        public void ListDataSourceDefinitions_RequestObject()
        {
            // Snippet: ListDataSourceDefinitions(ListDataSourceDefinitionsRequest,CallSettings)
            // Create client
            DataSourceServiceClient dataSourceServiceClient = DataSourceServiceClient.Create();
            // Initialize request argument(s)
            ListDataSourceDefinitionsRequest request = new ListDataSourceDefinitionsRequest();
            // Make the request
            PagedEnumerable<ListDataSourceDefinitionsResponse, DataSourceDefinition> response =
                dataSourceServiceClient.ListDataSourceDefinitions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataSourceDefinition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataSourceDefinitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSourceDefinition item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSourceDefinition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSourceDefinition item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
