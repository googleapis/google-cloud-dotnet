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
    using Google.Cloud.BigQuery.DataTransfer.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataTransferServiceClientSnippets
    {
        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSourceRequestObject()
        {
            // Snippet: GetDataSource(GetDataSourceRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            // Make the request
            DataSource response = dataTransferServiceClient.GetDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceRequestObjectAsync()
        {
            // Snippet: GetDataSourceAsync(GetDataSourceRequest, CallSettings)
            // Additional: GetDataSourceAsync(GetDataSourceRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            // Make the request
            DataSource response = await dataTransferServiceClient.GetDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSource()
        {
            // Snippet: GetDataSource(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dataSources/[DATA_SOURCE]";
            // Make the request
            DataSource response = dataTransferServiceClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceAsync()
        {
            // Snippet: GetDataSourceAsync(string, CallSettings)
            // Additional: GetDataSourceAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dataSources/[DATA_SOURCE]";
            // Make the request
            DataSource response = await dataTransferServiceClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSourceResourceNames()
        {
            // Snippet: GetDataSource(DataSourceName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]");
            // Make the request
            DataSource response = dataTransferServiceClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceResourceNamesAsync()
        {
            // Snippet: GetDataSourceAsync(DataSourceName, CallSettings)
            // Additional: GetDataSourceAsync(DataSourceName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]");
            // Make the request
            DataSource response = await dataTransferServiceClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSourcesRequestObject()
        {
            // Snippet: ListDataSources(ListDataSourcesRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSources(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesRequestObjectAsync()
        {
            // Snippet: ListDataSourcesAsync(ListDataSourcesRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSourcesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSources()
        {
            // Snippet: ListDataSources(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSources(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesAsync()
        {
            // Snippet: ListDataSourcesAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSourcesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSourcesResourceNames1()
        {
            // Snippet: ListDataSources(ProjectName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSources(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesResourceNames1Async()
        {
            // Snippet: ListDataSourcesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSourcesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSourcesResourceNames2()
        {
            // Snippet: ListDataSources(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSources(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesResourceNames2Async()
        {
            // Snippet: ListDataSourcesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataTransferServiceClient.ListDataSourcesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfigRequestObject()
        {
            // Snippet: CreateTransferConfig(CreateTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
                VersionInfo = "",
                ServiceAccountName = "",
            };
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigRequestObjectAsync()
        {
            // Snippet: CreateTransferConfigAsync(CreateTransferConfigRequest, CallSettings)
            // Additional: CreateTransferConfigAsync(CreateTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransferConfigRequest request = new CreateTransferConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                TransferConfig = new TransferConfig(),
                VersionInfo = "",
                ServiceAccountName = "",
            };
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfig()
        {
            // Snippet: CreateTransferConfig(string, TransferConfig, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigAsync()
        {
            // Snippet: CreateTransferConfigAsync(string, TransferConfig, CallSettings)
            // Additional: CreateTransferConfigAsync(string, TransferConfig, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfigResourceNames1()
        {
            // Snippet: CreateTransferConfig(ProjectName, TransferConfig, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigResourceNames1Async()
        {
            // Snippet: CreateTransferConfigAsync(ProjectName, TransferConfig, CallSettings)
            // Additional: CreateTransferConfigAsync(ProjectName, TransferConfig, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfigResourceNames2()
        {
            // Snippet: CreateTransferConfig(LocationName, TransferConfig, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigResourceNames2Async()
        {
            // Snippet: CreateTransferConfigAsync(LocationName, TransferConfig, CallSettings)
            // Additional: CreateTransferConfigAsync(LocationName, TransferConfig, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TransferConfig transferConfig = new TransferConfig();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(parent, transferConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfig</summary>
        public void UpdateTransferConfigRequestObject()
        {
            // Snippet: UpdateTransferConfig(UpdateTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
                VersionInfo = "",
                ServiceAccountName = "",
            };
            // Make the request
            TransferConfig response = dataTransferServiceClient.UpdateTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfigAsync</summary>
        public async Task UpdateTransferConfigRequestObjectAsync()
        {
            // Snippet: UpdateTransferConfigAsync(UpdateTransferConfigRequest, CallSettings)
            // Additional: UpdateTransferConfigAsync(UpdateTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest
            {
                TransferConfig = new TransferConfig(),
                UpdateMask = new FieldMask(),
                VersionInfo = "",
                ServiceAccountName = "",
            };
            // Make the request
            TransferConfig response = await dataTransferServiceClient.UpdateTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfig</summary>
        public void UpdateTransferConfig()
        {
            // Snippet: UpdateTransferConfig(TransferConfig, FieldMask, CallSettings)
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
        public async Task UpdateTransferConfigAsync()
        {
            // Snippet: UpdateTransferConfigAsync(TransferConfig, FieldMask, CallSettings)
            // Additional: UpdateTransferConfigAsync(TransferConfig, FieldMask, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfig transferConfig = new TransferConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.UpdateTransferConfigAsync(transferConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfig</summary>
        public void DeleteTransferConfigRequestObject()
        {
            // Snippet: DeleteTransferConfig(DeleteTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            // Make the request
            dataTransferServiceClient.DeleteTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        public async Task DeleteTransferConfigRequestObjectAsync()
        {
            // Snippet: DeleteTransferConfigAsync(DeleteTransferConfigRequest, CallSettings)
            // Additional: DeleteTransferConfigAsync(DeleteTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfig</summary>
        public void DeleteTransferConfig()
        {
            // Snippet: DeleteTransferConfig(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            // Make the request
            dataTransferServiceClient.DeleteTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        public async Task DeleteTransferConfigAsync()
        {
            // Snippet: DeleteTransferConfigAsync(string, CallSettings)
            // Additional: DeleteTransferConfigAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfig</summary>
        public void DeleteTransferConfigResourceNames()
        {
            // Snippet: DeleteTransferConfig(TransferConfigName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigName name = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            dataTransferServiceClient.DeleteTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        public async Task DeleteTransferConfigResourceNamesAsync()
        {
            // Snippet: DeleteTransferConfigAsync(TransferConfigName, CallSettings)
            // Additional: DeleteTransferConfigAsync(TransferConfigName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigName name = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfig</summary>
        public void GetTransferConfigRequestObject()
        {
            // Snippet: GetTransferConfig(GetTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            // Make the request
            TransferConfig response = dataTransferServiceClient.GetTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfigAsync</summary>
        public async Task GetTransferConfigRequestObjectAsync()
        {
            // Snippet: GetTransferConfigAsync(GetTransferConfigRequest, CallSettings)
            // Additional: GetTransferConfigAsync(GetTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferConfigRequest request = new GetTransferConfigRequest
            {
                TransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
            };
            // Make the request
            TransferConfig response = await dataTransferServiceClient.GetTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfig</summary>
        public void GetTransferConfig()
        {
            // Snippet: GetTransferConfig(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            // Make the request
            TransferConfig response = dataTransferServiceClient.GetTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfigAsync</summary>
        public async Task GetTransferConfigAsync()
        {
            // Snippet: GetTransferConfigAsync(string, CallSettings)
            // Additional: GetTransferConfigAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            // Make the request
            TransferConfig response = await dataTransferServiceClient.GetTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfig</summary>
        public void GetTransferConfigResourceNames()
        {
            // Snippet: GetTransferConfig(TransferConfigName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigName name = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            TransferConfig response = dataTransferServiceClient.GetTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfigAsync</summary>
        public async Task GetTransferConfigResourceNamesAsync()
        {
            // Snippet: GetTransferConfigAsync(TransferConfigName, CallSettings)
            // Additional: GetTransferConfigAsync(TransferConfigName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigName name = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            TransferConfig response = await dataTransferServiceClient.GetTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigsRequestObject()
        {
            // Snippet: ListTransferConfigs(ListTransferConfigsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DataSourceIds = { "", },
            };
            // Make the request
            PagedEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigs(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsRequestObjectAsync()
        {
            // Snippet: ListTransferConfigsAsync(ListTransferConfigsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferConfigsRequest request = new ListTransferConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DataSourceIds = { "", },
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigs()
        {
            // Snippet: ListTransferConfigs(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsAsync()
        {
            // Snippet: ListTransferConfigsAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigsResourceNames1()
        {
            // Snippet: ListTransferConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsResourceNames1Async()
        {
            // Snippet: ListTransferConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigsResourceNames2()
        {
            // Snippet: ListTransferConfigs(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsResourceNames2Async()
        {
            // Snippet: ListTransferConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> response = dataTransferServiceClient.ListTransferConfigsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRunsRequestObject()
        {
            // Snippet: ScheduleTransferRuns(ScheduleTransferRunsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRunsAsync</summary>
        public async Task ScheduleTransferRunsRequestObjectAsync()
        {
            // Snippet: ScheduleTransferRunsAsync(ScheduleTransferRunsRequest, CallSettings)
            // Additional: ScheduleTransferRunsAsync(ScheduleTransferRunsRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = await dataTransferServiceClient.ScheduleTransferRunsAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRuns()
        {
            // Snippet: ScheduleTransferRuns(string, Timestamp, Timestamp, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(parent, startTime, endTime);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRunsAsync</summary>
        public async Task ScheduleTransferRunsAsync()
        {
            // Snippet: ScheduleTransferRunsAsync(string, Timestamp, Timestamp, CallSettings)
            // Additional: ScheduleTransferRunsAsync(string, Timestamp, Timestamp, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = await dataTransferServiceClient.ScheduleTransferRunsAsync(parent, startTime, endTime);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRunsResourceNames()
        {
            // Snippet: ScheduleTransferRuns(TransferConfigName, Timestamp, Timestamp, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigName parent = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(parent, startTime, endTime);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRunsAsync</summary>
        public async Task ScheduleTransferRunsResourceNamesAsync()
        {
            // Snippet: ScheduleTransferRunsAsync(TransferConfigName, Timestamp, Timestamp, CallSettings)
            // Additional: ScheduleTransferRunsAsync(TransferConfigName, Timestamp, Timestamp, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigName parent = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
#pragma warning disable CS0612
            ScheduleTransferRunsResponse response = await dataTransferServiceClient.ScheduleTransferRunsAsync(parent, startTime, endTime);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for StartManualTransferRuns</summary>
        public void StartManualTransferRunsRequestObject()
        {
            // Snippet: StartManualTransferRuns(StartManualTransferRunsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                RequestedTimeRange = new StartManualTransferRunsRequest.Types.TimeRange(),
            };
            // Make the request
            StartManualTransferRunsResponse response = dataTransferServiceClient.StartManualTransferRuns(request);
            // End snippet
        }

        /// <summary>Snippet for StartManualTransferRunsAsync</summary>
        public async Task StartManualTransferRunsRequestObjectAsync()
        {
            // Snippet: StartManualTransferRunsAsync(StartManualTransferRunsRequest, CallSettings)
            // Additional: StartManualTransferRunsAsync(StartManualTransferRunsRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                RequestedTimeRange = new StartManualTransferRunsRequest.Types.TimeRange(),
            };
            // Make the request
            StartManualTransferRunsResponse response = await dataTransferServiceClient.StartManualTransferRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRun</summary>
        public void GetTransferRunRequestObject()
        {
            // Snippet: GetTransferRun(GetTransferRunRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            // Make the request
            TransferRun response = dataTransferServiceClient.GetTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRunAsync</summary>
        public async Task GetTransferRunRequestObjectAsync()
        {
            // Snippet: GetTransferRunAsync(GetTransferRunRequest, CallSettings)
            // Additional: GetTransferRunAsync(GetTransferRunRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferRunRequest request = new GetTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            // Make the request
            TransferRun response = await dataTransferServiceClient.GetTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRun</summary>
        public void GetTransferRun()
        {
            // Snippet: GetTransferRun(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]/runs/[RUN]";
            // Make the request
            TransferRun response = dataTransferServiceClient.GetTransferRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRunAsync</summary>
        public async Task GetTransferRunAsync()
        {
            // Snippet: GetTransferRunAsync(string, CallSettings)
            // Additional: GetTransferRunAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]/runs/[RUN]";
            // Make the request
            TransferRun response = await dataTransferServiceClient.GetTransferRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRun</summary>
        public void GetTransferRunResourceNames()
        {
            // Snippet: GetTransferRun(RunName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]");
            // Make the request
            TransferRun response = dataTransferServiceClient.GetTransferRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRunAsync</summary>
        public async Task GetTransferRunResourceNamesAsync()
        {
            // Snippet: GetTransferRunAsync(RunName, CallSettings)
            // Additional: GetTransferRunAsync(RunName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]");
            // Make the request
            TransferRun response = await dataTransferServiceClient.GetTransferRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRun</summary>
        public void DeleteTransferRunRequestObject()
        {
            // Snippet: DeleteTransferRun(DeleteTransferRunRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            // Make the request
            dataTransferServiceClient.DeleteTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRunAsync</summary>
        public async Task DeleteTransferRunRequestObjectAsync()
        {
            // Snippet: DeleteTransferRunAsync(DeleteTransferRunRequest, CallSettings)
            // Additional: DeleteTransferRunAsync(DeleteTransferRunRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferRunRequest request = new DeleteTransferRunRequest
            {
                RunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
            };
            // Make the request
            await dataTransferServiceClient.DeleteTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRun</summary>
        public void DeleteTransferRun()
        {
            // Snippet: DeleteTransferRun(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]/runs/[RUN]";
            // Make the request
            dataTransferServiceClient.DeleteTransferRun(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRunAsync</summary>
        public async Task DeleteTransferRunAsync()
        {
            // Snippet: DeleteTransferRunAsync(string, CallSettings)
            // Additional: DeleteTransferRunAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]/runs/[RUN]";
            // Make the request
            await dataTransferServiceClient.DeleteTransferRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRun</summary>
        public void DeleteTransferRunResourceNames()
        {
            // Snippet: DeleteTransferRun(RunName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]");
            // Make the request
            dataTransferServiceClient.DeleteTransferRun(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRunAsync</summary>
        public async Task DeleteTransferRunResourceNamesAsync()
        {
            // Snippet: DeleteTransferRunAsync(RunName, CallSettings)
            // Additional: DeleteTransferRunAsync(RunName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]");
            // Make the request
            await dataTransferServiceClient.DeleteTransferRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTransferRuns</summary>
        public void ListTransferRunsRequestObject()
        {
            // Snippet: ListTransferRuns(ListTransferRunsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferRunsRequest request = new ListTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                States =
                {
                    TransferState.Unspecified,
                },
                RunAttempt = ListTransferRunsRequest.Types.RunAttempt.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListTransferRunsResponse, TransferRun> response = dataTransferServiceClient.ListTransferRuns(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRunsAsync</summary>
        public async Task ListTransferRunsRequestObjectAsync()
        {
            // Snippet: ListTransferRunsAsync(ListTransferRunsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferRunsRequest request = new ListTransferRunsRequest
            {
                ParentAsTransferConfigName = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]"),
                States =
                {
                    TransferState.Unspecified,
                },
                RunAttempt = ListTransferRunsRequest.Types.RunAttempt.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> response = dataTransferServiceClient.ListTransferRunsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRuns</summary>
        public void ListTransferRuns()
        {
            // Snippet: ListTransferRuns(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            // Make the request
            PagedEnumerable<ListTransferRunsResponse, TransferRun> response = dataTransferServiceClient.ListTransferRuns(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRunsAsync</summary>
        public async Task ListTransferRunsAsync()
        {
            // Snippet: ListTransferRunsAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> response = dataTransferServiceClient.ListTransferRunsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRuns</summary>
        public void ListTransferRunsResourceNames()
        {
            // Snippet: ListTransferRuns(TransferConfigName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            TransferConfigName parent = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            PagedEnumerable<ListTransferRunsResponse, TransferRun> response = dataTransferServiceClient.ListTransferRuns(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferRunsAsync</summary>
        public async Task ListTransferRunsResourceNamesAsync()
        {
            // Snippet: ListTransferRunsAsync(TransferConfigName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            TransferConfigName parent = TransferConfigName.FromProjectTransferConfig("[PROJECT]", "[TRANSFER_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> response = dataTransferServiceClient.ListTransferRunsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogs</summary>
        public void ListTransferLogsRequestObject()
        {
            // Snippet: ListTransferLogs(ListTransferLogsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferLogsRequest request = new ListTransferLogsRequest
            {
                ParentAsRunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                MessageTypes =
                {
                    TransferMessage.Types.MessageSeverity.Unspecified,
                },
            };
            // Make the request
            PagedEnumerable<ListTransferLogsResponse, TransferMessage> response = dataTransferServiceClient.ListTransferLogs(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogsAsync</summary>
        public async Task ListTransferLogsRequestObjectAsync()
        {
            // Snippet: ListTransferLogsAsync(ListTransferLogsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferLogsRequest request = new ListTransferLogsRequest
            {
                ParentAsRunName = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]"),
                MessageTypes =
                {
                    TransferMessage.Types.MessageSeverity.Unspecified,
                },
            };
            // Make the request
            PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> response = dataTransferServiceClient.ListTransferLogsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogs</summary>
        public void ListTransferLogs()
        {
            // Snippet: ListTransferLogs(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]/runs/[RUN]";
            // Make the request
            PagedEnumerable<ListTransferLogsResponse, TransferMessage> response = dataTransferServiceClient.ListTransferLogs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogsAsync</summary>
        public async Task ListTransferLogsAsync()
        {
            // Snippet: ListTransferLogsAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/transferConfigs/[TRANSFER_CONFIG]/runs/[RUN]";
            // Make the request
            PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> response = dataTransferServiceClient.ListTransferLogsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogs</summary>
        public void ListTransferLogsResourceNames()
        {
            // Snippet: ListTransferLogs(RunName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            RunName parent = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]");
            // Make the request
            PagedEnumerable<ListTransferLogsResponse, TransferMessage> response = dataTransferServiceClient.ListTransferLogs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogsAsync</summary>
        public async Task ListTransferLogsResourceNamesAsync()
        {
            // Snippet: ListTransferLogsAsync(RunName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunName parent = RunName.FromProjectTransferConfigRun("[PROJECT]", "[TRANSFER_CONFIG]", "[RUN]");
            // Make the request
            PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> response = dataTransferServiceClient.ListTransferLogsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CheckValidCreds</summary>
        public void CheckValidCredsRequestObject()
        {
            // Snippet: CheckValidCreds(CheckValidCredsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            // Make the request
            CheckValidCredsResponse response = dataTransferServiceClient.CheckValidCreds(request);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCredsAsync</summary>
        public async Task CheckValidCredsRequestObjectAsync()
        {
            // Snippet: CheckValidCredsAsync(CheckValidCredsRequest, CallSettings)
            // Additional: CheckValidCredsAsync(CheckValidCredsRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckValidCredsRequest request = new CheckValidCredsRequest
            {
                DataSourceName = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]"),
            };
            // Make the request
            CheckValidCredsResponse response = await dataTransferServiceClient.CheckValidCredsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCreds</summary>
        public void CheckValidCreds()
        {
            // Snippet: CheckValidCreds(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dataSources/[DATA_SOURCE]";
            // Make the request
            CheckValidCredsResponse response = dataTransferServiceClient.CheckValidCreds(name);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCredsAsync</summary>
        public async Task CheckValidCredsAsync()
        {
            // Snippet: CheckValidCredsAsync(string, CallSettings)
            // Additional: CheckValidCredsAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dataSources/[DATA_SOURCE]";
            // Make the request
            CheckValidCredsResponse response = await dataTransferServiceClient.CheckValidCredsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCreds</summary>
        public void CheckValidCredsResourceNames()
        {
            // Snippet: CheckValidCreds(DataSourceName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]");
            // Make the request
            CheckValidCredsResponse response = dataTransferServiceClient.CheckValidCreds(name);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCredsAsync</summary>
        public async Task CheckValidCredsResourceNamesAsync()
        {
            // Snippet: CheckValidCredsAsync(DataSourceName, CallSettings)
            // Additional: CheckValidCredsAsync(DataSourceName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectDataSource("[PROJECT]", "[DATA_SOURCE]");
            // Make the request
            CheckValidCredsResponse response = await dataTransferServiceClient.CheckValidCredsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnrollDataSources</summary>
        public void EnrollDataSourcesRequestObject()
        {
            // Snippet: EnrollDataSources(EnrollDataSourcesRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            EnrollDataSourcesRequest request = new EnrollDataSourcesRequest
            {
                Name = "",
                DataSourceIds = { "", },
            };
            // Make the request
            dataTransferServiceClient.EnrollDataSources(request);
            // End snippet
        }

        /// <summary>Snippet for EnrollDataSourcesAsync</summary>
        public async Task EnrollDataSourcesRequestObjectAsync()
        {
            // Snippet: EnrollDataSourcesAsync(EnrollDataSourcesRequest, CallSettings)
            // Additional: EnrollDataSourcesAsync(EnrollDataSourcesRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnrollDataSourcesRequest request = new EnrollDataSourcesRequest
            {
                Name = "",
                DataSourceIds = { "", },
            };
            // Make the request
            await dataTransferServiceClient.EnrollDataSourcesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UnenrollDataSources</summary>
        public void UnenrollDataSourcesRequestObject()
        {
            // Snippet: UnenrollDataSources(UnenrollDataSourcesRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            UnenrollDataSourcesRequest request = new UnenrollDataSourcesRequest
            {
                Name = "",
                DataSourceIds = { "", },
            };
            // Make the request
            dataTransferServiceClient.UnenrollDataSources(request);
            // End snippet
        }

        /// <summary>Snippet for UnenrollDataSourcesAsync</summary>
        public async Task UnenrollDataSourcesRequestObjectAsync()
        {
            // Snippet: UnenrollDataSourcesAsync(UnenrollDataSourcesRequest, CallSettings)
            // Additional: UnenrollDataSourcesAsync(UnenrollDataSourcesRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UnenrollDataSourcesRequest request = new UnenrollDataSourcesRequest
            {
                Name = "",
                DataSourceIds = { "", },
            };
            // Make the request
            await dataTransferServiceClient.UnenrollDataSourcesAsync(request);
            // End snippet
        }
    }
}
