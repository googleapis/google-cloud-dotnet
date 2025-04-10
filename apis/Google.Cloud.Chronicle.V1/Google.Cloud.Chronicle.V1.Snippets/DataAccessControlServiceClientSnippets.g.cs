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
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataAccessControlServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataAccessLabel</summary>
        public void CreateDataAccessLabelRequestObject()
        {
            // Snippet: CreateDataAccessLabel(CreateDataAccessLabelRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            CreateDataAccessLabelRequest request = new CreateDataAccessLabelRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataAccessLabel = new DataAccessLabel(),
                DataAccessLabelId = "",
            };
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.CreateDataAccessLabel(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessLabelAsync</summary>
        public async Task CreateDataAccessLabelRequestObjectAsync()
        {
            // Snippet: CreateDataAccessLabelAsync(CreateDataAccessLabelRequest, CallSettings)
            // Additional: CreateDataAccessLabelAsync(CreateDataAccessLabelRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataAccessLabelRequest request = new CreateDataAccessLabelRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataAccessLabel = new DataAccessLabel(),
                DataAccessLabelId = "",
            };
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.CreateDataAccessLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessLabel</summary>
        public void CreateDataAccessLabel()
        {
            // Snippet: CreateDataAccessLabel(string, DataAccessLabel, string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DataAccessLabel dataAccessLabel = new DataAccessLabel();
            string dataAccessLabelId = "";
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.CreateDataAccessLabel(parent, dataAccessLabel, dataAccessLabelId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessLabelAsync</summary>
        public async Task CreateDataAccessLabelAsync()
        {
            // Snippet: CreateDataAccessLabelAsync(string, DataAccessLabel, string, CallSettings)
            // Additional: CreateDataAccessLabelAsync(string, DataAccessLabel, string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DataAccessLabel dataAccessLabel = new DataAccessLabel();
            string dataAccessLabelId = "";
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.CreateDataAccessLabelAsync(parent, dataAccessLabel, dataAccessLabelId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessLabel</summary>
        public void CreateDataAccessLabelResourceNames()
        {
            // Snippet: CreateDataAccessLabel(InstanceName, DataAccessLabel, string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DataAccessLabel dataAccessLabel = new DataAccessLabel();
            string dataAccessLabelId = "";
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.CreateDataAccessLabel(parent, dataAccessLabel, dataAccessLabelId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessLabelAsync</summary>
        public async Task CreateDataAccessLabelResourceNamesAsync()
        {
            // Snippet: CreateDataAccessLabelAsync(InstanceName, DataAccessLabel, string, CallSettings)
            // Additional: CreateDataAccessLabelAsync(InstanceName, DataAccessLabel, string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DataAccessLabel dataAccessLabel = new DataAccessLabel();
            string dataAccessLabelId = "";
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.CreateDataAccessLabelAsync(parent, dataAccessLabel, dataAccessLabelId);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessLabel</summary>
        public void GetDataAccessLabelRequestObject()
        {
            // Snippet: GetDataAccessLabel(GetDataAccessLabelRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            GetDataAccessLabelRequest request = new GetDataAccessLabelRequest
            {
                DataAccessLabelName = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]"),
            };
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.GetDataAccessLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessLabelAsync</summary>
        public async Task GetDataAccessLabelRequestObjectAsync()
        {
            // Snippet: GetDataAccessLabelAsync(GetDataAccessLabelRequest, CallSettings)
            // Additional: GetDataAccessLabelAsync(GetDataAccessLabelRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataAccessLabelRequest request = new GetDataAccessLabelRequest
            {
                DataAccessLabelName = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]"),
            };
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.GetDataAccessLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessLabel</summary>
        public void GetDataAccessLabel()
        {
            // Snippet: GetDataAccessLabel(string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessLabels/[DATA_ACCESS_LABEL]";
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.GetDataAccessLabel(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessLabelAsync</summary>
        public async Task GetDataAccessLabelAsync()
        {
            // Snippet: GetDataAccessLabelAsync(string, CallSettings)
            // Additional: GetDataAccessLabelAsync(string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessLabels/[DATA_ACCESS_LABEL]";
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.GetDataAccessLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessLabel</summary>
        public void GetDataAccessLabelResourceNames()
        {
            // Snippet: GetDataAccessLabel(DataAccessLabelName, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DataAccessLabelName name = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]");
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.GetDataAccessLabel(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessLabelAsync</summary>
        public async Task GetDataAccessLabelResourceNamesAsync()
        {
            // Snippet: GetDataAccessLabelAsync(DataAccessLabelName, CallSettings)
            // Additional: GetDataAccessLabelAsync(DataAccessLabelName, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAccessLabelName name = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]");
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.GetDataAccessLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessLabels</summary>
        public void ListDataAccessLabelsRequestObject()
        {
            // Snippet: ListDataAccessLabels(ListDataAccessLabelsRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            ListDataAccessLabelsRequest request = new ListDataAccessLabelsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> response = dataAccessControlServiceClient.ListDataAccessLabels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAccessLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAccessLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessLabelsAsync</summary>
        public async Task ListDataAccessLabelsRequestObjectAsync()
        {
            // Snippet: ListDataAccessLabelsAsync(ListDataAccessLabelsRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataAccessLabelsRequest request = new ListDataAccessLabelsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> response = dataAccessControlServiceClient.ListDataAccessLabelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAccessLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAccessLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessLabels</summary>
        public void ListDataAccessLabels()
        {
            // Snippet: ListDataAccessLabels(string, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> response = dataAccessControlServiceClient.ListDataAccessLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAccessLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAccessLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessLabelsAsync</summary>
        public async Task ListDataAccessLabelsAsync()
        {
            // Snippet: ListDataAccessLabelsAsync(string, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> response = dataAccessControlServiceClient.ListDataAccessLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAccessLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAccessLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessLabels</summary>
        public void ListDataAccessLabelsResourceNames()
        {
            // Snippet: ListDataAccessLabels(InstanceName, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> response = dataAccessControlServiceClient.ListDataAccessLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAccessLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAccessLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessLabelsAsync</summary>
        public async Task ListDataAccessLabelsResourceNamesAsync()
        {
            // Snippet: ListDataAccessLabelsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> response = dataAccessControlServiceClient.ListDataAccessLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAccessLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAccessLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessLabel</summary>
        public void UpdateDataAccessLabelRequestObject()
        {
            // Snippet: UpdateDataAccessLabel(UpdateDataAccessLabelRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataAccessLabelRequest request = new UpdateDataAccessLabelRequest
            {
                DataAccessLabel = new DataAccessLabel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.UpdateDataAccessLabel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessLabelAsync</summary>
        public async Task UpdateDataAccessLabelRequestObjectAsync()
        {
            // Snippet: UpdateDataAccessLabelAsync(UpdateDataAccessLabelRequest, CallSettings)
            // Additional: UpdateDataAccessLabelAsync(UpdateDataAccessLabelRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataAccessLabelRequest request = new UpdateDataAccessLabelRequest
            {
                DataAccessLabel = new DataAccessLabel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.UpdateDataAccessLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessLabel</summary>
        public void UpdateDataAccessLabel()
        {
            // Snippet: UpdateDataAccessLabel(DataAccessLabel, FieldMask, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DataAccessLabel dataAccessLabel = new DataAccessLabel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataAccessLabel response = dataAccessControlServiceClient.UpdateDataAccessLabel(dataAccessLabel, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessLabelAsync</summary>
        public async Task UpdateDataAccessLabelAsync()
        {
            // Snippet: UpdateDataAccessLabelAsync(DataAccessLabel, FieldMask, CallSettings)
            // Additional: UpdateDataAccessLabelAsync(DataAccessLabel, FieldMask, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAccessLabel dataAccessLabel = new DataAccessLabel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataAccessLabel response = await dataAccessControlServiceClient.UpdateDataAccessLabelAsync(dataAccessLabel, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessLabel</summary>
        public void DeleteDataAccessLabelRequestObject()
        {
            // Snippet: DeleteDataAccessLabel(DeleteDataAccessLabelRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataAccessLabelRequest request = new DeleteDataAccessLabelRequest
            {
                DataAccessLabelName = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]"),
            };
            // Make the request
            dataAccessControlServiceClient.DeleteDataAccessLabel(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessLabelAsync</summary>
        public async Task DeleteDataAccessLabelRequestObjectAsync()
        {
            // Snippet: DeleteDataAccessLabelAsync(DeleteDataAccessLabelRequest, CallSettings)
            // Additional: DeleteDataAccessLabelAsync(DeleteDataAccessLabelRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataAccessLabelRequest request = new DeleteDataAccessLabelRequest
            {
                DataAccessLabelName = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]"),
            };
            // Make the request
            await dataAccessControlServiceClient.DeleteDataAccessLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessLabel</summary>
        public void DeleteDataAccessLabel()
        {
            // Snippet: DeleteDataAccessLabel(string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessLabels/[DATA_ACCESS_LABEL]";
            // Make the request
            dataAccessControlServiceClient.DeleteDataAccessLabel(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessLabelAsync</summary>
        public async Task DeleteDataAccessLabelAsync()
        {
            // Snippet: DeleteDataAccessLabelAsync(string, CallSettings)
            // Additional: DeleteDataAccessLabelAsync(string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessLabels/[DATA_ACCESS_LABEL]";
            // Make the request
            await dataAccessControlServiceClient.DeleteDataAccessLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessLabel</summary>
        public void DeleteDataAccessLabelResourceNames()
        {
            // Snippet: DeleteDataAccessLabel(DataAccessLabelName, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DataAccessLabelName name = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]");
            // Make the request
            dataAccessControlServiceClient.DeleteDataAccessLabel(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessLabelAsync</summary>
        public async Task DeleteDataAccessLabelResourceNamesAsync()
        {
            // Snippet: DeleteDataAccessLabelAsync(DataAccessLabelName, CallSettings)
            // Additional: DeleteDataAccessLabelAsync(DataAccessLabelName, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAccessLabelName name = DataAccessLabelName.FromProjectLocationInstanceDataAccessLabel("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_LABEL]");
            // Make the request
            await dataAccessControlServiceClient.DeleteDataAccessLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessScope</summary>
        public void CreateDataAccessScopeRequestObject()
        {
            // Snippet: CreateDataAccessScope(CreateDataAccessScopeRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            CreateDataAccessScopeRequest request = new CreateDataAccessScopeRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataAccessScope = new DataAccessScope(),
                DataAccessScopeId = "",
            };
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.CreateDataAccessScope(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessScopeAsync</summary>
        public async Task CreateDataAccessScopeRequestObjectAsync()
        {
            // Snippet: CreateDataAccessScopeAsync(CreateDataAccessScopeRequest, CallSettings)
            // Additional: CreateDataAccessScopeAsync(CreateDataAccessScopeRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataAccessScopeRequest request = new CreateDataAccessScopeRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataAccessScope = new DataAccessScope(),
                DataAccessScopeId = "",
            };
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.CreateDataAccessScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessScope</summary>
        public void CreateDataAccessScope()
        {
            // Snippet: CreateDataAccessScope(string, DataAccessScope, string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DataAccessScope dataAccessScope = new DataAccessScope();
            string dataAccessScopeId = "";
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.CreateDataAccessScope(parent, dataAccessScope, dataAccessScopeId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessScopeAsync</summary>
        public async Task CreateDataAccessScopeAsync()
        {
            // Snippet: CreateDataAccessScopeAsync(string, DataAccessScope, string, CallSettings)
            // Additional: CreateDataAccessScopeAsync(string, DataAccessScope, string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DataAccessScope dataAccessScope = new DataAccessScope();
            string dataAccessScopeId = "";
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.CreateDataAccessScopeAsync(parent, dataAccessScope, dataAccessScopeId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessScope</summary>
        public void CreateDataAccessScopeResourceNames()
        {
            // Snippet: CreateDataAccessScope(InstanceName, DataAccessScope, string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DataAccessScope dataAccessScope = new DataAccessScope();
            string dataAccessScopeId = "";
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.CreateDataAccessScope(parent, dataAccessScope, dataAccessScopeId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAccessScopeAsync</summary>
        public async Task CreateDataAccessScopeResourceNamesAsync()
        {
            // Snippet: CreateDataAccessScopeAsync(InstanceName, DataAccessScope, string, CallSettings)
            // Additional: CreateDataAccessScopeAsync(InstanceName, DataAccessScope, string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DataAccessScope dataAccessScope = new DataAccessScope();
            string dataAccessScopeId = "";
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.CreateDataAccessScopeAsync(parent, dataAccessScope, dataAccessScopeId);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessScope</summary>
        public void GetDataAccessScopeRequestObject()
        {
            // Snippet: GetDataAccessScope(GetDataAccessScopeRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            GetDataAccessScopeRequest request = new GetDataAccessScopeRequest
            {
                DataAccessScopeName = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]"),
            };
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.GetDataAccessScope(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessScopeAsync</summary>
        public async Task GetDataAccessScopeRequestObjectAsync()
        {
            // Snippet: GetDataAccessScopeAsync(GetDataAccessScopeRequest, CallSettings)
            // Additional: GetDataAccessScopeAsync(GetDataAccessScopeRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataAccessScopeRequest request = new GetDataAccessScopeRequest
            {
                DataAccessScopeName = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]"),
            };
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.GetDataAccessScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessScope</summary>
        public void GetDataAccessScope()
        {
            // Snippet: GetDataAccessScope(string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessScopes/[DATA_ACCESS_SCOPE]";
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.GetDataAccessScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessScopeAsync</summary>
        public async Task GetDataAccessScopeAsync()
        {
            // Snippet: GetDataAccessScopeAsync(string, CallSettings)
            // Additional: GetDataAccessScopeAsync(string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessScopes/[DATA_ACCESS_SCOPE]";
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.GetDataAccessScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessScope</summary>
        public void GetDataAccessScopeResourceNames()
        {
            // Snippet: GetDataAccessScope(DataAccessScopeName, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DataAccessScopeName name = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]");
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.GetDataAccessScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAccessScopeAsync</summary>
        public async Task GetDataAccessScopeResourceNamesAsync()
        {
            // Snippet: GetDataAccessScopeAsync(DataAccessScopeName, CallSettings)
            // Additional: GetDataAccessScopeAsync(DataAccessScopeName, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAccessScopeName name = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]");
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.GetDataAccessScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessScopes</summary>
        public void ListDataAccessScopesRequestObject()
        {
            // Snippet: ListDataAccessScopes(ListDataAccessScopesRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            ListDataAccessScopesRequest request = new ListDataAccessScopesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> response = dataAccessControlServiceClient.ListDataAccessScopes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAccessScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAccessScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessScopesAsync</summary>
        public async Task ListDataAccessScopesRequestObjectAsync()
        {
            // Snippet: ListDataAccessScopesAsync(ListDataAccessScopesRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataAccessScopesRequest request = new ListDataAccessScopesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> response = dataAccessControlServiceClient.ListDataAccessScopesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAccessScope item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAccessScopesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessScopes</summary>
        public void ListDataAccessScopes()
        {
            // Snippet: ListDataAccessScopes(string, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> response = dataAccessControlServiceClient.ListDataAccessScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAccessScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAccessScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessScopesAsync</summary>
        public async Task ListDataAccessScopesAsync()
        {
            // Snippet: ListDataAccessScopesAsync(string, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> response = dataAccessControlServiceClient.ListDataAccessScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAccessScope item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAccessScopesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessScopes</summary>
        public void ListDataAccessScopesResourceNames()
        {
            // Snippet: ListDataAccessScopes(InstanceName, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> response = dataAccessControlServiceClient.ListDataAccessScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAccessScope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAccessScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessScope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAccessScopesAsync</summary>
        public async Task ListDataAccessScopesResourceNamesAsync()
        {
            // Snippet: ListDataAccessScopesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> response = dataAccessControlServiceClient.ListDataAccessScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAccessScope item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAccessScopesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAccessScope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAccessScope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAccessScope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessScope</summary>
        public void UpdateDataAccessScopeRequestObject()
        {
            // Snippet: UpdateDataAccessScope(UpdateDataAccessScopeRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataAccessScopeRequest request = new UpdateDataAccessScopeRequest
            {
                DataAccessScope = new DataAccessScope(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.UpdateDataAccessScope(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessScopeAsync</summary>
        public async Task UpdateDataAccessScopeRequestObjectAsync()
        {
            // Snippet: UpdateDataAccessScopeAsync(UpdateDataAccessScopeRequest, CallSettings)
            // Additional: UpdateDataAccessScopeAsync(UpdateDataAccessScopeRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataAccessScopeRequest request = new UpdateDataAccessScopeRequest
            {
                DataAccessScope = new DataAccessScope(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.UpdateDataAccessScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessScope</summary>
        public void UpdateDataAccessScope()
        {
            // Snippet: UpdateDataAccessScope(DataAccessScope, FieldMask, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DataAccessScope dataAccessScope = new DataAccessScope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataAccessScope response = dataAccessControlServiceClient.UpdateDataAccessScope(dataAccessScope, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAccessScopeAsync</summary>
        public async Task UpdateDataAccessScopeAsync()
        {
            // Snippet: UpdateDataAccessScopeAsync(DataAccessScope, FieldMask, CallSettings)
            // Additional: UpdateDataAccessScopeAsync(DataAccessScope, FieldMask, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAccessScope dataAccessScope = new DataAccessScope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataAccessScope response = await dataAccessControlServiceClient.UpdateDataAccessScopeAsync(dataAccessScope, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessScope</summary>
        public void DeleteDataAccessScopeRequestObject()
        {
            // Snippet: DeleteDataAccessScope(DeleteDataAccessScopeRequest, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataAccessScopeRequest request = new DeleteDataAccessScopeRequest
            {
                DataAccessScopeName = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]"),
            };
            // Make the request
            dataAccessControlServiceClient.DeleteDataAccessScope(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessScopeAsync</summary>
        public async Task DeleteDataAccessScopeRequestObjectAsync()
        {
            // Snippet: DeleteDataAccessScopeAsync(DeleteDataAccessScopeRequest, CallSettings)
            // Additional: DeleteDataAccessScopeAsync(DeleteDataAccessScopeRequest, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataAccessScopeRequest request = new DeleteDataAccessScopeRequest
            {
                DataAccessScopeName = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]"),
            };
            // Make the request
            await dataAccessControlServiceClient.DeleteDataAccessScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessScope</summary>
        public void DeleteDataAccessScope()
        {
            // Snippet: DeleteDataAccessScope(string, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessScopes/[DATA_ACCESS_SCOPE]";
            // Make the request
            dataAccessControlServiceClient.DeleteDataAccessScope(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessScopeAsync</summary>
        public async Task DeleteDataAccessScopeAsync()
        {
            // Snippet: DeleteDataAccessScopeAsync(string, CallSettings)
            // Additional: DeleteDataAccessScopeAsync(string, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataAccessScopes/[DATA_ACCESS_SCOPE]";
            // Make the request
            await dataAccessControlServiceClient.DeleteDataAccessScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessScope</summary>
        public void DeleteDataAccessScopeResourceNames()
        {
            // Snippet: DeleteDataAccessScope(DataAccessScopeName, CallSettings)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = DataAccessControlServiceClient.Create();
            // Initialize request argument(s)
            DataAccessScopeName name = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]");
            // Make the request
            dataAccessControlServiceClient.DeleteDataAccessScope(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAccessScopeAsync</summary>
        public async Task DeleteDataAccessScopeResourceNamesAsync()
        {
            // Snippet: DeleteDataAccessScopeAsync(DataAccessScopeName, CallSettings)
            // Additional: DeleteDataAccessScopeAsync(DataAccessScopeName, CancellationToken)
            // Create client
            DataAccessControlServiceClient dataAccessControlServiceClient = await DataAccessControlServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAccessScopeName name = DataAccessScopeName.FromProjectLocationInstanceDataAccessScope("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_ACCESS_SCOPE]");
            // Make the request
            await dataAccessControlServiceClient.DeleteDataAccessScopeAsync(name);
            // End snippet
        }
    }
}
