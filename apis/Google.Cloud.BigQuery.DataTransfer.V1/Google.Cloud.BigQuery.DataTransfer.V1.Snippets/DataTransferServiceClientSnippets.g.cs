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
    using Google.Api.Gax.ResourceNames;
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
    public class GeneratedDataTransferServiceClientSnippets
    {
        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceAsync()
        {
            // Snippet: GetDataSourceAsync(DataSourceNameOneof,CallSettings)
            // Additional: GetDataSourceAsync(DataSourceNameOneof,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            // Make the request
            DataSource response = await dataTransferServiceClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSource()
        {
            // Snippet: GetDataSource(DataSourceNameOneof,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            // Make the request
            DataSource response = dataTransferServiceClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceAsync_RequestObject()
        {
            // Snippet: GetDataSourceAsync(GetDataSourceRequest,CallSettings)
            // Additional: GetDataSourceAsync(GetDataSourceRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            // Make the request
            DataSource response = await dataTransferServiceClient.GetDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSource_RequestObject()
        {
            // Snippet: GetDataSource(GetDataSourceRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            // Make the request
            DataSource response = dataTransferServiceClient.GetDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesAsync()
        {
            // Snippet: ListDataSourcesAsync(ParentNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response =
                dataTransferServiceClient.ListDataSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSources()
        {
            // Snippet: ListDataSources(ParentNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response =
                dataTransferServiceClient.ListDataSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesAsync_RequestObject()
        {
            // Snippet: ListDataSourcesAsync(ListDataSourcesRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response =
                dataTransferServiceClient.ListDataSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSources_RequestObject()
        {
            // Snippet: ListDataSources(ListDataSourcesRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response =
                dataTransferServiceClient.ListDataSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigAsync()
        {
            // Snippet: CreateTransferConfigAsync(ParentNameOneof,TransferConfig,CallSettings)
            // Additional: CreateTransferConfigAsync(ParentNameOneof,TransferConfig,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfig()
        {
            // Snippet: CreateTransferConfig(ParentNameOneof,TransferConfig,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigAsync_RequestObject()
        {
            // Snippet: CreateTransferConfigAsync(CreateTransferConfigRequest,CallSettings)
            // Additional: CreateTransferConfigAsync(CreateTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                TransferConfig = new TransferConfig(),
            };
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfig_RequestObject()
        {
            // Snippet: CreateTransferConfig(CreateTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                TransferConfig = new TransferConfig(),
            };
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfigAsync</summary>
        public async Task UpdateTransferConfigAsync()
        {
            // Snippet: UpdateTransferConfigAsync(TransferConfig,FieldMask,CallSettings)
            // Additional: UpdateTransferConfigAsync(TransferConfig,FieldMask,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfig transferConfig = new TransferConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.UpdateTransferConfigAsync(transferConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfig</summary>
        public void UpdateTransferConfig()
        {
            // Snippet: UpdateTransferConfig(TransferConfig,FieldMask,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfig transferConfig = new TransferConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TransferConfig response = dataTransferServiceClient.UpdateTransferConfig(transferConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfigAsync</summary>
        public async Task UpdateTransferConfigAsync_RequestObject()
        {
            // Snippet: UpdateTransferConfigAsync(UpdateTransferConfigRequest,CallSettings)
            // Additional: UpdateTransferConfigAsync(UpdateTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TransferConfig response = await dataTransferServiceClient.UpdateTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfig</summary>
        public void UpdateTransferConfig_RequestObject()
        {
            // Snippet: UpdateTransferConfig(UpdateTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TransferConfig response = dataTransferServiceClient.UpdateTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        public async Task DeleteTransferConfigAsync()
        {
            // Snippet: DeleteTransferConfigAsync(TransferConfigNameOneof,CallSettings)
            // Additional: DeleteTransferConfigAsync(TransferConfigNameOneof,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfig</summary>
        public void DeleteTransferConfig()
        {
            // Snippet: DeleteTransferConfig(TransferConfigNameOneof,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            // Make the request
            dataTransferServiceClient.DeleteTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        public async Task DeleteTransferConfigAsync_RequestObject()
        {
            // Snippet: DeleteTransferConfigAsync(DeleteTransferConfigRequest,CallSettings)
            // Additional: DeleteTransferConfigAsync(DeleteTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfig</summary>
        public void DeleteTransferConfig_RequestObject()
        {
            // Snippet: DeleteTransferConfig(DeleteTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            // Make the request
            dataTransferServiceClient.DeleteTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfigAsync</summary>
        public async Task GetTransferConfigAsync()
        {
            // Snippet: GetTransferConfigAsync(TransferConfigNameOneof,CallSettings)
            // Additional: GetTransferConfigAsync(TransferConfigNameOneof,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            // Make the request
            TransferConfig response = await dataTransferServiceClient.GetTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfig</summary>
        public void GetTransferConfig()
        {
            // Snippet: GetTransferConfig(TransferConfigNameOneof,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigNameOneof name = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            // Make the request
            TransferConfig response = dataTransferServiceClient.GetTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfigAsync</summary>
        public async Task GetTransferConfigAsync_RequestObject()
        {
            // Snippet: GetTransferConfigAsync(GetTransferConfigRequest,CallSettings)
            // Additional: GetTransferConfigAsync(GetTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            // Make the request
            TransferConfig response = await dataTransferServiceClient.GetTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfig</summary>
        public void GetTransferConfig_RequestObject()
        {
            // Snippet: GetTransferConfig(GetTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            // Make the request
            TransferConfig response = dataTransferServiceClient.GetTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsAsync()
        {
            // Snippet: ListTransferConfigsAsync(ParentNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> response =
                dataTransferServiceClient.ListTransferConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferConfig item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigs()
        {
            // Snippet: ListTransferConfigs(ParentNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedEnumerable<ListTransferConfigsResponse, TransferConfig> response =
                dataTransferServiceClient.ListTransferConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferConfig item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsAsync_RequestObject()
        {
            // Snippet: ListTransferConfigsAsync(ListTransferConfigsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> response =
                dataTransferServiceClient.ListTransferConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferConfig item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigs_RequestObject()
        {
            // Snippet: ListTransferConfigs(ListTransferConfigsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedEnumerable<ListTransferConfigsResponse, TransferConfig> response =
                dataTransferServiceClient.ListTransferConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferConfig item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRunsAsync</summary>
        public async Task ScheduleTransferRunsAsync()
        {
            // Snippet: ScheduleTransferRunsAsync(TransferConfigNameOneof,Timestamp,Timestamp,CallSettings)
            // Additional: ScheduleTransferRunsAsync(TransferConfigNameOneof,Timestamp,Timestamp,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            ScheduleTransferRunsResponse response = await dataTransferServiceClient.ScheduleTransferRunsAsync(parent, startTime, endTime);
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRuns()
        {
            // Snippet: ScheduleTransferRuns(TransferConfigNameOneof,Timestamp,Timestamp,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(parent, startTime, endTime);
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRunsAsync</summary>
        public async Task ScheduleTransferRunsAsync_RequestObject()
        {
            // Snippet: ScheduleTransferRunsAsync(ScheduleTransferRunsRequest,CallSettings)
            // Additional: ScheduleTransferRunsAsync(ScheduleTransferRunsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            ScheduleTransferRunsResponse response = await dataTransferServiceClient.ScheduleTransferRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRuns_RequestObject()
        {
            // Snippet: ScheduleTransferRuns(ScheduleTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRunAsync</summary>
        public async Task GetTransferRunAsync()
        {
            // Snippet: GetTransferRunAsync(RunNameOneof,CallSettings)
            // Additional: GetTransferRunAsync(RunNameOneof,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            // Make the request
            TransferRun response = await dataTransferServiceClient.GetTransferRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRun</summary>
        public void GetTransferRun()
        {
            // Snippet: GetTransferRun(RunNameOneof,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            // Make the request
            TransferRun response = dataTransferServiceClient.GetTransferRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRunAsync</summary>
        public async Task GetTransferRunAsync_RequestObject()
        {
            // Snippet: GetTransferRunAsync(GetTransferRunRequest,CallSettings)
            // Additional: GetTransferRunAsync(GetTransferRunRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            // Make the request
            TransferRun response = await dataTransferServiceClient.GetTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRun</summary>
        public void GetTransferRun_RequestObject()
        {
            // Snippet: GetTransferRun(GetTransferRunRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            // Make the request
            TransferRun response = dataTransferServiceClient.GetTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRunAsync</summary>
        public async Task DeleteTransferRunAsync()
        {
            // Snippet: DeleteTransferRunAsync(RunNameOneof,CallSettings)
            // Additional: DeleteTransferRunAsync(RunNameOneof,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            // Make the request
            await dataTransferServiceClient.DeleteTransferRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRun</summary>
        public void DeleteTransferRun()
        {
            // Snippet: DeleteTransferRun(RunNameOneof,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            RunNameOneof name = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            // Make the request
            dataTransferServiceClient.DeleteTransferRun(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRunAsync</summary>
        public async Task DeleteTransferRunAsync_RequestObject()
        {
            // Snippet: DeleteTransferRunAsync(DeleteTransferRunRequest,CallSettings)
            // Additional: DeleteTransferRunAsync(DeleteTransferRunRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            // Make the request
            await dataTransferServiceClient.DeleteTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRun</summary>
        public void DeleteTransferRun_RequestObject()
        {
            // Snippet: DeleteTransferRun(DeleteTransferRunRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            // Make the request
            dataTransferServiceClient.DeleteTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferRunsAsync</summary>
        public async Task ListTransferRunsAsync()
        {
            // Snippet: ListTransferRunsAsync(TransferConfigNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            // Make the request
            PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> response =
                dataTransferServiceClient.ListTransferRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferRun item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferRun item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRuns</summary>
        public void ListTransferRuns()
        {
            // Snippet: ListTransferRuns(TransferConfigNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigNameOneof parent = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]"));
            // Make the request
            PagedEnumerable<ListTransferRunsResponse, TransferRun> response =
                dataTransferServiceClient.ListTransferRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferRun item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferRun item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRunsAsync</summary>
        public async Task ListTransferRunsAsync_RequestObject()
        {
            // Snippet: ListTransferRunsAsync(ListTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferRunsRequest request = new ListTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> response =
                dataTransferServiceClient.ListTransferRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferRun item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferRun item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRuns</summary>
        public void ListTransferRuns_RequestObject()
        {
            // Snippet: ListTransferRuns(ListTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferRunsRequest request = new ListTransferRunsRequest
            {
                ParentAsTransferConfigNameOneof = TransferConfigNameOneof.From(new ProjectTransferConfigName("[PROJECT]", "[TRANSFER_CONFIG]")),
            };
            // Make the request
            PagedEnumerable<ListTransferRunsResponse, TransferRun> response =
                dataTransferServiceClient.ListTransferRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferRun item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferRun item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogsAsync</summary>
        public async Task ListTransferLogsAsync()
        {
            // Snippet: ListTransferLogsAsync(RunNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunNameOneof parent = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            // Make the request
            PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> response =
                dataTransferServiceClient.ListTransferLogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferMessage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferMessage item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferMessage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferMessage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogs</summary>
        public void ListTransferLogs()
        {
            // Snippet: ListTransferLogs(RunNameOneof,string,int?,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            RunNameOneof parent = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"));
            // Make the request
            PagedEnumerable<ListTransferLogsResponse, TransferMessage> response =
                dataTransferServiceClient.ListTransferLogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferMessage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferMessage item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferMessage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferMessage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogsAsync</summary>
        public async Task ListTransferLogsAsync_RequestObject()
        {
            // Snippet: ListTransferLogsAsync(ListTransferLogsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferLogsRequest request = new ListTransferLogsRequest
            {
                ParentAsRunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> response =
                dataTransferServiceClient.ListTransferLogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferMessage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferMessage item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferMessage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferMessage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogs</summary>
        public void ListTransferLogs_RequestObject()
        {
            // Snippet: ListTransferLogs(ListTransferLogsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferLogsRequest request = new ListTransferLogsRequest
            {
                ParentAsRunNameOneof = RunNameOneof.From(new ProjectRunName("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]")),
            };
            // Make the request
            PagedEnumerable<ListTransferLogsResponse, TransferMessage> response =
                dataTransferServiceClient.ListTransferLogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferMessage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferMessage item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferMessage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferMessage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CheckValidCredsAsync</summary>
        public async Task CheckValidCredsAsync()
        {
            // Snippet: CheckValidCredsAsync(DataSourceNameOneof,CallSettings)
            // Additional: CheckValidCredsAsync(DataSourceNameOneof,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            // Make the request
            CheckValidCredsResponse response = await dataTransferServiceClient.CheckValidCredsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCreds</summary>
        public void CheckValidCreds()
        {
            // Snippet: CheckValidCreds(DataSourceNameOneof,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DataSourceNameOneof name = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]"));
            // Make the request
            CheckValidCredsResponse response = dataTransferServiceClient.CheckValidCreds(name);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCredsAsync</summary>
        public async Task CheckValidCredsAsync_RequestObject()
        {
            // Snippet: CheckValidCredsAsync(CheckValidCredsRequest,CallSettings)
            // Additional: CheckValidCredsAsync(CheckValidCredsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            // Make the request
            CheckValidCredsResponse response = await dataTransferServiceClient.CheckValidCredsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCreds</summary>
        public void CheckValidCreds_RequestObject()
        {
            // Snippet: CheckValidCreds(CheckValidCredsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceNameOneof = DataSourceNameOneof.From(new ProjectDataSourceName("[PROJECT]", "[DATA_SOURCE]")),
            };
            // Make the request
            CheckValidCredsResponse response = dataTransferServiceClient.CheckValidCreds(request);
            // End snippet
        }

        /// <summary>Snippet for StartManualTransferRunsAsync</summary>
        public async Task StartManualTransferRunsAsync_RequestObject()
        {
            // Snippet: StartManualTransferRunsAsync(StartManualTransferRunsRequest,CallSettings)
            // Additional: StartManualTransferRunsAsync(StartManualTransferRunsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            // Make the request
            StartManualTransferRunsResponse response = await dataTransferServiceClient.StartManualTransferRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartManualTransferRuns</summary>
        public void StartManualTransferRuns_RequestObject()
        {
            // Snippet: StartManualTransferRuns(StartManualTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            // Make the request
            StartManualTransferRunsResponse response = dataTransferServiceClient.StartManualTransferRuns(request);
            // End snippet
        }

    }
}
