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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSampleQueryServiceClientSnippets
    {
        /// <summary>Snippet for GetSampleQuery</summary>
        public void GetSampleQueryRequestObject()
        {
            // Snippet: GetSampleQuery(GetSampleQueryRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            GetSampleQueryRequest request = new GetSampleQueryRequest
            {
                SampleQueryName = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]"),
            };
            // Make the request
            SampleQuery response = sampleQueryServiceClient.GetSampleQuery(request);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQueryAsync</summary>
        public async Task GetSampleQueryRequestObjectAsync()
        {
            // Snippet: GetSampleQueryAsync(GetSampleQueryRequest, CallSettings)
            // Additional: GetSampleQueryAsync(GetSampleQueryRequest, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSampleQueryRequest request = new GetSampleQueryRequest
            {
                SampleQueryName = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]"),
            };
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.GetSampleQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuery</summary>
        public void GetSampleQuery()
        {
            // Snippet: GetSampleQuery(string, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]/sampleQueries/[SAMPLE_QUERY]";
            // Make the request
            SampleQuery response = sampleQueryServiceClient.GetSampleQuery(name);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQueryAsync</summary>
        public async Task GetSampleQueryAsync()
        {
            // Snippet: GetSampleQueryAsync(string, CallSettings)
            // Additional: GetSampleQueryAsync(string, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]/sampleQueries/[SAMPLE_QUERY]";
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.GetSampleQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuery</summary>
        public void GetSampleQueryResourceNames()
        {
            // Snippet: GetSampleQuery(SampleQueryName, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            SampleQueryName name = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]");
            // Make the request
            SampleQuery response = sampleQueryServiceClient.GetSampleQuery(name);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQueryAsync</summary>
        public async Task GetSampleQueryResourceNamesAsync()
        {
            // Snippet: GetSampleQueryAsync(SampleQueryName, CallSettings)
            // Additional: GetSampleQueryAsync(SampleQueryName, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQueryName name = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]");
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.GetSampleQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSampleQueries</summary>
        public void ListSampleQueriesRequestObject()
        {
            // Snippet: ListSampleQueries(ListSampleQueriesRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            ListSampleQueriesRequest request = new ListSampleQueriesRequest
            {
                ParentAsSampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
            };
            // Make the request
            PagedEnumerable<ListSampleQueriesResponse, SampleQuery> response = sampleQueryServiceClient.ListSampleQueries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SampleQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSampleQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQueriesAsync</summary>
        public async Task ListSampleQueriesRequestObjectAsync()
        {
            // Snippet: ListSampleQueriesAsync(ListSampleQueriesRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSampleQueriesRequest request = new ListSampleQueriesRequest
            {
                ParentAsSampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> response = sampleQueryServiceClient.ListSampleQueriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SampleQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSampleQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQueries</summary>
        public void ListSampleQueries()
        {
            // Snippet: ListSampleQueries(string, string, int?, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            // Make the request
            PagedEnumerable<ListSampleQueriesResponse, SampleQuery> response = sampleQueryServiceClient.ListSampleQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SampleQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSampleQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQueriesAsync</summary>
        public async Task ListSampleQueriesAsync()
        {
            // Snippet: ListSampleQueriesAsync(string, string, int?, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            // Make the request
            PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> response = sampleQueryServiceClient.ListSampleQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SampleQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSampleQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQueries</summary>
        public void ListSampleQueriesResourceNames()
        {
            // Snippet: ListSampleQueries(SampleQuerySetName, string, int?, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            SampleQuerySetName parent = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            // Make the request
            PagedEnumerable<ListSampleQueriesResponse, SampleQuery> response = sampleQueryServiceClient.ListSampleQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SampleQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSampleQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQueriesAsync</summary>
        public async Task ListSampleQueriesResourceNamesAsync()
        {
            // Snippet: ListSampleQueriesAsync(SampleQuerySetName, string, int?, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQuerySetName parent = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            // Make the request
            PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> response = sampleQueryServiceClient.ListSampleQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SampleQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSampleQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuery</summary>
        public void CreateSampleQueryRequestObject()
        {
            // Snippet: CreateSampleQuery(CreateSampleQueryRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            CreateSampleQueryRequest request = new CreateSampleQueryRequest
            {
                ParentAsSampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
                SampleQuery = new SampleQuery(),
                SampleQueryId = "",
            };
            // Make the request
            SampleQuery response = sampleQueryServiceClient.CreateSampleQuery(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQueryAsync</summary>
        public async Task CreateSampleQueryRequestObjectAsync()
        {
            // Snippet: CreateSampleQueryAsync(CreateSampleQueryRequest, CallSettings)
            // Additional: CreateSampleQueryAsync(CreateSampleQueryRequest, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSampleQueryRequest request = new CreateSampleQueryRequest
            {
                ParentAsSampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
                SampleQuery = new SampleQuery(),
                SampleQueryId = "",
            };
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.CreateSampleQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuery</summary>
        public void CreateSampleQuery()
        {
            // Snippet: CreateSampleQuery(string, SampleQuery, string, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            SampleQuery sampleQuery = new SampleQuery();
            string sampleQueryId = "";
            // Make the request
            SampleQuery response = sampleQueryServiceClient.CreateSampleQuery(parent, sampleQuery, sampleQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQueryAsync</summary>
        public async Task CreateSampleQueryAsync()
        {
            // Snippet: CreateSampleQueryAsync(string, SampleQuery, string, CallSettings)
            // Additional: CreateSampleQueryAsync(string, SampleQuery, string, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            SampleQuery sampleQuery = new SampleQuery();
            string sampleQueryId = "";
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.CreateSampleQueryAsync(parent, sampleQuery, sampleQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuery</summary>
        public void CreateSampleQueryResourceNames()
        {
            // Snippet: CreateSampleQuery(SampleQuerySetName, SampleQuery, string, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            SampleQuerySetName parent = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            SampleQuery sampleQuery = new SampleQuery();
            string sampleQueryId = "";
            // Make the request
            SampleQuery response = sampleQueryServiceClient.CreateSampleQuery(parent, sampleQuery, sampleQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQueryAsync</summary>
        public async Task CreateSampleQueryResourceNamesAsync()
        {
            // Snippet: CreateSampleQueryAsync(SampleQuerySetName, SampleQuery, string, CallSettings)
            // Additional: CreateSampleQueryAsync(SampleQuerySetName, SampleQuery, string, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQuerySetName parent = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            SampleQuery sampleQuery = new SampleQuery();
            string sampleQueryId = "";
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.CreateSampleQueryAsync(parent, sampleQuery, sampleQueryId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQuery</summary>
        public void UpdateSampleQueryRequestObject()
        {
            // Snippet: UpdateSampleQuery(UpdateSampleQueryRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            UpdateSampleQueryRequest request = new UpdateSampleQueryRequest
            {
                SampleQuery = new SampleQuery(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SampleQuery response = sampleQueryServiceClient.UpdateSampleQuery(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQueryAsync</summary>
        public async Task UpdateSampleQueryRequestObjectAsync()
        {
            // Snippet: UpdateSampleQueryAsync(UpdateSampleQueryRequest, CallSettings)
            // Additional: UpdateSampleQueryAsync(UpdateSampleQueryRequest, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSampleQueryRequest request = new UpdateSampleQueryRequest
            {
                SampleQuery = new SampleQuery(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.UpdateSampleQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQuery</summary>
        public void UpdateSampleQuery()
        {
            // Snippet: UpdateSampleQuery(SampleQuery, FieldMask, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            SampleQuery sampleQuery = new SampleQuery();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SampleQuery response = sampleQueryServiceClient.UpdateSampleQuery(sampleQuery, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQueryAsync</summary>
        public async Task UpdateSampleQueryAsync()
        {
            // Snippet: UpdateSampleQueryAsync(SampleQuery, FieldMask, CallSettings)
            // Additional: UpdateSampleQueryAsync(SampleQuery, FieldMask, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQuery sampleQuery = new SampleQuery();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SampleQuery response = await sampleQueryServiceClient.UpdateSampleQueryAsync(sampleQuery, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuery</summary>
        public void DeleteSampleQueryRequestObject()
        {
            // Snippet: DeleteSampleQuery(DeleteSampleQueryRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            DeleteSampleQueryRequest request = new DeleteSampleQueryRequest
            {
                SampleQueryName = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]"),
            };
            // Make the request
            sampleQueryServiceClient.DeleteSampleQuery(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQueryAsync</summary>
        public async Task DeleteSampleQueryRequestObjectAsync()
        {
            // Snippet: DeleteSampleQueryAsync(DeleteSampleQueryRequest, CallSettings)
            // Additional: DeleteSampleQueryAsync(DeleteSampleQueryRequest, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSampleQueryRequest request = new DeleteSampleQueryRequest
            {
                SampleQueryName = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]"),
            };
            // Make the request
            await sampleQueryServiceClient.DeleteSampleQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuery</summary>
        public void DeleteSampleQuery()
        {
            // Snippet: DeleteSampleQuery(string, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]/sampleQueries/[SAMPLE_QUERY]";
            // Make the request
            sampleQueryServiceClient.DeleteSampleQuery(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQueryAsync</summary>
        public async Task DeleteSampleQueryAsync()
        {
            // Snippet: DeleteSampleQueryAsync(string, CallSettings)
            // Additional: DeleteSampleQueryAsync(string, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]/sampleQueries/[SAMPLE_QUERY]";
            // Make the request
            await sampleQueryServiceClient.DeleteSampleQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuery</summary>
        public void DeleteSampleQueryResourceNames()
        {
            // Snippet: DeleteSampleQuery(SampleQueryName, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            SampleQueryName name = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]");
            // Make the request
            sampleQueryServiceClient.DeleteSampleQuery(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQueryAsync</summary>
        public async Task DeleteSampleQueryResourceNamesAsync()
        {
            // Snippet: DeleteSampleQueryAsync(SampleQueryName, CallSettings)
            // Additional: DeleteSampleQueryAsync(SampleQueryName, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQueryName name = SampleQueryName.FromProjectLocationSampleQuerySetSampleQuery("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]", "[SAMPLE_QUERY]");
            // Make the request
            await sampleQueryServiceClient.DeleteSampleQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportSampleQueries</summary>
        public void ImportSampleQueriesRequestObject()
        {
            // Snippet: ImportSampleQueries(ImportSampleQueriesRequest, CallSettings)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = SampleQueryServiceClient.Create();
            // Initialize request argument(s)
            ImportSampleQueriesRequest request = new ImportSampleQueriesRequest
            {
                ParentAsSampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
                InlineSource = new ImportSampleQueriesRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
            };
            // Make the request
            Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> response = sampleQueryServiceClient.ImportSampleQueries(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportSampleQueriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> retrievedResponse = sampleQueryServiceClient.PollOnceImportSampleQueries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportSampleQueriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportSampleQueriesAsync</summary>
        public async Task ImportSampleQueriesRequestObjectAsync()
        {
            // Snippet: ImportSampleQueriesAsync(ImportSampleQueriesRequest, CallSettings)
            // Additional: ImportSampleQueriesAsync(ImportSampleQueriesRequest, CancellationToken)
            // Create client
            SampleQueryServiceClient sampleQueryServiceClient = await SampleQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportSampleQueriesRequest request = new ImportSampleQueriesRequest
            {
                ParentAsSampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
                InlineSource = new ImportSampleQueriesRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
            };
            // Make the request
            Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> response = await sampleQueryServiceClient.ImportSampleQueriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportSampleQueriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> retrievedResponse = await sampleQueryServiceClient.PollOnceImportSampleQueriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportSampleQueriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
