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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.DataSources.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataSourcesServiceClientSnippets
    {
        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSourceRequestObject()
        {
            // Snippet: GetDataSource(GetDataSourceRequest, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]"),
            };
            // Make the request
            DataSource response = dataSourcesServiceClient.GetDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceRequestObjectAsync()
        {
            // Snippet: GetDataSourceAsync(GetDataSourceRequest, CallSettings)
            // Additional: GetDataSourceAsync(GetDataSourceRequest, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]"),
            };
            // Make the request
            DataSource response = await dataSourcesServiceClient.GetDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSource()
        {
            // Snippet: GetDataSource(string, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSources/[DATASOURCE]";
            // Make the request
            DataSource response = dataSourcesServiceClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceAsync()
        {
            // Snippet: GetDataSourceAsync(string, CallSettings)
            // Additional: GetDataSourceAsync(string, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSources/[DATASOURCE]";
            // Make the request
            DataSource response = await dataSourcesServiceClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSourceResourceNames()
        {
            // Snippet: GetDataSource(DataSourceName, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]");
            // Make the request
            DataSource response = dataSourcesServiceClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceResourceNamesAsync()
        {
            // Snippet: GetDataSourceAsync(DataSourceName, CallSettings)
            // Additional: GetDataSourceAsync(DataSourceName, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]");
            // Make the request
            DataSource response = await dataSourcesServiceClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSourcesRequestObject()
        {
            // Snippet: ListDataSources(ListDataSourcesRequest, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataSourcesServiceClient.ListDataSources(request);

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
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataSourcesServiceClient.ListDataSourcesAsync(request);

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
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataSourcesServiceClient.ListDataSources(parent);

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
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataSourcesServiceClient.ListDataSourcesAsync(parent);

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
        public void ListDataSourcesResourceNames()
        {
            // Snippet: ListDataSources(AccountName, string, int?, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = dataSourcesServiceClient.ListDataSources(parent);

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
        public async Task ListDataSourcesResourceNamesAsync()
        {
            // Snippet: ListDataSourcesAsync(AccountName, string, int?, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = dataSourcesServiceClient.ListDataSourcesAsync(parent);

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

        /// <summary>Snippet for CreateDataSource</summary>
        public void CreateDataSourceRequestObject()
        {
            // Snippet: CreateDataSource(CreateDataSourceRequest, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            CreateDataSourceRequest request = new CreateDataSourceRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                DataSource = new DataSource(),
            };
            // Make the request
            DataSource response = dataSourcesServiceClient.CreateDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSourceAsync</summary>
        public async Task CreateDataSourceRequestObjectAsync()
        {
            // Snippet: CreateDataSourceAsync(CreateDataSourceRequest, CallSettings)
            // Additional: CreateDataSourceAsync(CreateDataSourceRequest, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataSourceRequest request = new CreateDataSourceRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                DataSource = new DataSource(),
            };
            // Make the request
            DataSource response = await dataSourcesServiceClient.CreateDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSource</summary>
        public void CreateDataSource()
        {
            // Snippet: CreateDataSource(string, DataSource, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            DataSource dataSource = new DataSource();
            // Make the request
            DataSource response = dataSourcesServiceClient.CreateDataSource(parent, dataSource);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSourceAsync</summary>
        public async Task CreateDataSourceAsync()
        {
            // Snippet: CreateDataSourceAsync(string, DataSource, CallSettings)
            // Additional: CreateDataSourceAsync(string, DataSource, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            DataSource dataSource = new DataSource();
            // Make the request
            DataSource response = await dataSourcesServiceClient.CreateDataSourceAsync(parent, dataSource);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSource</summary>
        public void CreateDataSourceResourceNames()
        {
            // Snippet: CreateDataSource(AccountName, DataSource, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            DataSource dataSource = new DataSource();
            // Make the request
            DataSource response = dataSourcesServiceClient.CreateDataSource(parent, dataSource);
            // End snippet
        }

        /// <summary>Snippet for CreateDataSourceAsync</summary>
        public async Task CreateDataSourceResourceNamesAsync()
        {
            // Snippet: CreateDataSourceAsync(AccountName, DataSource, CallSettings)
            // Additional: CreateDataSourceAsync(AccountName, DataSource, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            DataSource dataSource = new DataSource();
            // Make the request
            DataSource response = await dataSourcesServiceClient.CreateDataSourceAsync(parent, dataSource);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSource</summary>
        public void UpdateDataSourceRequestObject()
        {
            // Snippet: UpdateDataSource(UpdateDataSourceRequest, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataSourceRequest request = new UpdateDataSourceRequest
            {
                DataSource = new DataSource(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataSource response = dataSourcesServiceClient.UpdateDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSourceAsync</summary>
        public async Task UpdateDataSourceRequestObjectAsync()
        {
            // Snippet: UpdateDataSourceAsync(UpdateDataSourceRequest, CallSettings)
            // Additional: UpdateDataSourceAsync(UpdateDataSourceRequest, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataSourceRequest request = new UpdateDataSourceRequest
            {
                DataSource = new DataSource(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataSource response = await dataSourcesServiceClient.UpdateDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSource</summary>
        public void UpdateDataSource()
        {
            // Snippet: UpdateDataSource(DataSource, FieldMask, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            DataSource dataSource = new DataSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataSource response = dataSourcesServiceClient.UpdateDataSource(dataSource, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSourceAsync</summary>
        public async Task UpdateDataSourceAsync()
        {
            // Snippet: UpdateDataSourceAsync(DataSource, FieldMask, CallSettings)
            // Additional: UpdateDataSourceAsync(DataSource, FieldMask, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSource dataSource = new DataSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataSource response = await dataSourcesServiceClient.UpdateDataSourceAsync(dataSource, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSource</summary>
        public void DeleteDataSourceRequestObject()
        {
            // Snippet: DeleteDataSource(DeleteDataSourceRequest, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataSourceRequest request = new DeleteDataSourceRequest
            {
                DataSourceName = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]"),
            };
            // Make the request
            dataSourcesServiceClient.DeleteDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSourceAsync</summary>
        public async Task DeleteDataSourceRequestObjectAsync()
        {
            // Snippet: DeleteDataSourceAsync(DeleteDataSourceRequest, CallSettings)
            // Additional: DeleteDataSourceAsync(DeleteDataSourceRequest, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataSourceRequest request = new DeleteDataSourceRequest
            {
                DataSourceName = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]"),
            };
            // Make the request
            await dataSourcesServiceClient.DeleteDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSource</summary>
        public void DeleteDataSource()
        {
            // Snippet: DeleteDataSource(string, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSources/[DATASOURCE]";
            // Make the request
            dataSourcesServiceClient.DeleteDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSourceAsync</summary>
        public async Task DeleteDataSourceAsync()
        {
            // Snippet: DeleteDataSourceAsync(string, CallSettings)
            // Additional: DeleteDataSourceAsync(string, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSources/[DATASOURCE]";
            // Make the request
            await dataSourcesServiceClient.DeleteDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSource</summary>
        public void DeleteDataSourceResourceNames()
        {
            // Snippet: DeleteDataSource(DataSourceName, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]");
            // Make the request
            dataSourcesServiceClient.DeleteDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataSourceAsync</summary>
        public async Task DeleteDataSourceResourceNamesAsync()
        {
            // Snippet: DeleteDataSourceAsync(DataSourceName, CallSettings)
            // Additional: DeleteDataSourceAsync(DataSourceName, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]");
            // Make the request
            await dataSourcesServiceClient.DeleteDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchDataSource</summary>
        public void FetchDataSourceRequestObject()
        {
            // Snippet: FetchDataSource(FetchDataSourceRequest, CallSettings)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = DataSourcesServiceClient.Create();
            // Initialize request argument(s)
            FetchDataSourceRequest request = new FetchDataSourceRequest
            {
                DataSourceName = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]"),
            };
            // Make the request
            dataSourcesServiceClient.FetchDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for FetchDataSourceAsync</summary>
        public async Task FetchDataSourceRequestObjectAsync()
        {
            // Snippet: FetchDataSourceAsync(FetchDataSourceRequest, CallSettings)
            // Additional: FetchDataSourceAsync(FetchDataSourceRequest, CancellationToken)
            // Create client
            DataSourcesServiceClient dataSourcesServiceClient = await DataSourcesServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchDataSourceRequest request = new FetchDataSourceRequest
            {
                DataSourceName = DataSourceName.FromAccountDatasource("[ACCOUNT]", "[DATASOURCE]"),
            };
            // Make the request
            await dataSourcesServiceClient.FetchDataSourceAsync(request);
            // End snippet
        }
    }
}
