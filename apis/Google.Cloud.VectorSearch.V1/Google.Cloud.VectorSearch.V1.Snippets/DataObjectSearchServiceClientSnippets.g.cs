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
    using Google.Cloud.VectorSearch.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataObjectSearchServiceClientSnippets
    {
        /// <summary>Snippet for SearchDataObjects</summary>
        public void SearchDataObjectsRequestObject()
        {
            // Snippet: SearchDataObjects(SearchDataObjectsRequest, CallSettings)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = DataObjectSearchServiceClient.Create();
            // Initialize request argument(s)
            SearchDataObjectsRequest request = new SearchDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                VectorSearch = new VectorSearch(),
            };
            // Make the request
            PagedEnumerable<SearchDataObjectsResponse, SearchResult> response = dataObjectSearchServiceClient.SearchDataObjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchDataObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDataObjectsAsync</summary>
        public async Task SearchDataObjectsRequestObjectAsync()
        {
            // Snippet: SearchDataObjectsAsync(SearchDataObjectsRequest, CallSettings)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = await DataObjectSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchDataObjectsRequest request = new SearchDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                VectorSearch = new VectorSearch(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchDataObjectsResponse, SearchResult> response = dataObjectSearchServiceClient.SearchDataObjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchDataObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDataObjects</summary>
        public void QueryDataObjectsRequestObject()
        {
            // Snippet: QueryDataObjects(QueryDataObjectsRequest, CallSettings)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = DataObjectSearchServiceClient.Create();
            // Initialize request argument(s)
            QueryDataObjectsRequest request = new QueryDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = new Struct(),
                OutputFields = new OutputFields(),
            };
            // Make the request
            PagedEnumerable<QueryDataObjectsResponse, DataObject> response = dataObjectSearchServiceClient.QueryDataObjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataObject item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryDataObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataObject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataObject> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataObject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDataObjectsAsync</summary>
        public async Task QueryDataObjectsRequestObjectAsync()
        {
            // Snippet: QueryDataObjectsAsync(QueryDataObjectsRequest, CallSettings)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = await DataObjectSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryDataObjectsRequest request = new QueryDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = new Struct(),
                OutputFields = new OutputFields(),
            };
            // Make the request
            PagedAsyncEnumerable<QueryDataObjectsResponse, DataObject> response = dataObjectSearchServiceClient.QueryDataObjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataObject item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (QueryDataObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataObject item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataObject> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataObject item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateDataObjects</summary>
        public void AggregateDataObjectsRequestObject()
        {
            // Snippet: AggregateDataObjects(AggregateDataObjectsRequest, CallSettings)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = DataObjectSearchServiceClient.Create();
            // Initialize request argument(s)
            AggregateDataObjectsRequest request = new AggregateDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = new Struct(),
                Aggregate = AggregationMethod.Unspecified,
            };
            // Make the request
            AggregateDataObjectsResponse response = dataObjectSearchServiceClient.AggregateDataObjects(request);
            // End snippet
        }

        /// <summary>Snippet for AggregateDataObjectsAsync</summary>
        public async Task AggregateDataObjectsRequestObjectAsync()
        {
            // Snippet: AggregateDataObjectsAsync(AggregateDataObjectsRequest, CallSettings)
            // Additional: AggregateDataObjectsAsync(AggregateDataObjectsRequest, CancellationToken)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = await DataObjectSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            AggregateDataObjectsRequest request = new AggregateDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = new Struct(),
                Aggregate = AggregationMethod.Unspecified,
            };
            // Make the request
            AggregateDataObjectsResponse response = await dataObjectSearchServiceClient.AggregateDataObjectsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSearchDataObjects</summary>
        public void BatchSearchDataObjectsRequestObject()
        {
            // Snippet: BatchSearchDataObjects(BatchSearchDataObjectsRequest, CallSettings)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = DataObjectSearchServiceClient.Create();
            // Initialize request argument(s)
            BatchSearchDataObjectsRequest request = new BatchSearchDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Searches = { new Search(), },
                Combine = new BatchSearchDataObjectsRequest.Types.CombineResultsOptions(),
            };
            // Make the request
            BatchSearchDataObjectsResponse response = dataObjectSearchServiceClient.BatchSearchDataObjects(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSearchDataObjectsAsync</summary>
        public async Task BatchSearchDataObjectsRequestObjectAsync()
        {
            // Snippet: BatchSearchDataObjectsAsync(BatchSearchDataObjectsRequest, CallSettings)
            // Additional: BatchSearchDataObjectsAsync(BatchSearchDataObjectsRequest, CancellationToken)
            // Create client
            DataObjectSearchServiceClient dataObjectSearchServiceClient = await DataObjectSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchSearchDataObjectsRequest request = new BatchSearchDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Searches = { new Search(), },
                Combine = new BatchSearchDataObjectsRequest.Types.CombineResultsOptions(),
            };
            // Make the request
            BatchSearchDataObjectsResponse response = await dataObjectSearchServiceClient.BatchSearchDataObjectsAsync(request);
            // End snippet
        }
    }
}
