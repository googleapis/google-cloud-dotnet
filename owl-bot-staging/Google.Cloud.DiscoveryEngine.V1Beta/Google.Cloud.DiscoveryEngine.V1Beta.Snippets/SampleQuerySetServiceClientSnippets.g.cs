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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSampleQuerySetServiceClientSnippets
    {
        /// <summary>Snippet for GetSampleQuerySet</summary>
        public void GetSampleQuerySetRequestObject()
        {
            // Snippet: GetSampleQuerySet(GetSampleQuerySetRequest, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            GetSampleQuerySetRequest request = new GetSampleQuerySetRequest
            {
                SampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
            };
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.GetSampleQuerySet(request);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuerySetAsync</summary>
        public async Task GetSampleQuerySetRequestObjectAsync()
        {
            // Snippet: GetSampleQuerySetAsync(GetSampleQuerySetRequest, CallSettings)
            // Additional: GetSampleQuerySetAsync(GetSampleQuerySetRequest, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSampleQuerySetRequest request = new GetSampleQuerySetRequest
            {
                SampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
            };
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.GetSampleQuerySetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuerySet</summary>
        public void GetSampleQuerySet()
        {
            // Snippet: GetSampleQuerySet(string, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.GetSampleQuerySet(name);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuerySetAsync</summary>
        public async Task GetSampleQuerySetAsync()
        {
            // Snippet: GetSampleQuerySetAsync(string, CallSettings)
            // Additional: GetSampleQuerySetAsync(string, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.GetSampleQuerySetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuerySet</summary>
        public void GetSampleQuerySetResourceNames()
        {
            // Snippet: GetSampleQuerySet(SampleQuerySetName, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            SampleQuerySetName name = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.GetSampleQuerySet(name);
            // End snippet
        }

        /// <summary>Snippet for GetSampleQuerySetAsync</summary>
        public async Task GetSampleQuerySetResourceNamesAsync()
        {
            // Snippet: GetSampleQuerySetAsync(SampleQuerySetName, CallSettings)
            // Additional: GetSampleQuerySetAsync(SampleQuerySetName, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQuerySetName name = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.GetSampleQuerySetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSampleQuerySets</summary>
        public void ListSampleQuerySetsRequestObject()
        {
            // Snippet: ListSampleQuerySets(ListSampleQuerySetsRequest, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            ListSampleQuerySetsRequest request = new ListSampleQuerySetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> response = sampleQuerySetServiceClient.ListSampleQuerySets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SampleQuerySet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSampleQuerySetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuerySet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuerySet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuerySet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQuerySetsAsync</summary>
        public async Task ListSampleQuerySetsRequestObjectAsync()
        {
            // Snippet: ListSampleQuerySetsAsync(ListSampleQuerySetsRequest, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSampleQuerySetsRequest request = new ListSampleQuerySetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> response = sampleQuerySetServiceClient.ListSampleQuerySetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SampleQuerySet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSampleQuerySetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuerySet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuerySet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuerySet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQuerySets</summary>
        public void ListSampleQuerySets()
        {
            // Snippet: ListSampleQuerySets(string, string, int?, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> response = sampleQuerySetServiceClient.ListSampleQuerySets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SampleQuerySet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSampleQuerySetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuerySet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuerySet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuerySet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQuerySetsAsync</summary>
        public async Task ListSampleQuerySetsAsync()
        {
            // Snippet: ListSampleQuerySetsAsync(string, string, int?, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> response = sampleQuerySetServiceClient.ListSampleQuerySetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SampleQuerySet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSampleQuerySetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuerySet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuerySet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuerySet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQuerySets</summary>
        public void ListSampleQuerySetsResourceNames()
        {
            // Snippet: ListSampleQuerySets(LocationName, string, int?, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> response = sampleQuerySetServiceClient.ListSampleQuerySets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SampleQuerySet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSampleQuerySetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuerySet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuerySet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuerySet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSampleQuerySetsAsync</summary>
        public async Task ListSampleQuerySetsResourceNamesAsync()
        {
            // Snippet: ListSampleQuerySetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> response = sampleQuerySetServiceClient.ListSampleQuerySetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SampleQuerySet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSampleQuerySetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SampleQuerySet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SampleQuerySet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SampleQuerySet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuerySet</summary>
        public void CreateSampleQuerySetRequestObject()
        {
            // Snippet: CreateSampleQuerySet(CreateSampleQuerySetRequest, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            CreateSampleQuerySetRequest request = new CreateSampleQuerySetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SampleQuerySet = new SampleQuerySet(),
                SampleQuerySetId = "",
            };
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.CreateSampleQuerySet(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuerySetAsync</summary>
        public async Task CreateSampleQuerySetRequestObjectAsync()
        {
            // Snippet: CreateSampleQuerySetAsync(CreateSampleQuerySetRequest, CallSettings)
            // Additional: CreateSampleQuerySetAsync(CreateSampleQuerySetRequest, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSampleQuerySetRequest request = new CreateSampleQuerySetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SampleQuerySet = new SampleQuerySet(),
                SampleQuerySetId = "",
            };
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.CreateSampleQuerySetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuerySet</summary>
        public void CreateSampleQuerySet()
        {
            // Snippet: CreateSampleQuerySet(string, SampleQuerySet, string, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SampleQuerySet sampleQuerySet = new SampleQuerySet();
            string sampleQuerySetId = "";
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.CreateSampleQuerySet(parent, sampleQuerySet, sampleQuerySetId);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuerySetAsync</summary>
        public async Task CreateSampleQuerySetAsync()
        {
            // Snippet: CreateSampleQuerySetAsync(string, SampleQuerySet, string, CallSettings)
            // Additional: CreateSampleQuerySetAsync(string, SampleQuerySet, string, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SampleQuerySet sampleQuerySet = new SampleQuerySet();
            string sampleQuerySetId = "";
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.CreateSampleQuerySetAsync(parent, sampleQuerySet, sampleQuerySetId);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuerySet</summary>
        public void CreateSampleQuerySetResourceNames()
        {
            // Snippet: CreateSampleQuerySet(LocationName, SampleQuerySet, string, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SampleQuerySet sampleQuerySet = new SampleQuerySet();
            string sampleQuerySetId = "";
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.CreateSampleQuerySet(parent, sampleQuerySet, sampleQuerySetId);
            // End snippet
        }

        /// <summary>Snippet for CreateSampleQuerySetAsync</summary>
        public async Task CreateSampleQuerySetResourceNamesAsync()
        {
            // Snippet: CreateSampleQuerySetAsync(LocationName, SampleQuerySet, string, CallSettings)
            // Additional: CreateSampleQuerySetAsync(LocationName, SampleQuerySet, string, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SampleQuerySet sampleQuerySet = new SampleQuerySet();
            string sampleQuerySetId = "";
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.CreateSampleQuerySetAsync(parent, sampleQuerySet, sampleQuerySetId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQuerySet</summary>
        public void UpdateSampleQuerySetRequestObject()
        {
            // Snippet: UpdateSampleQuerySet(UpdateSampleQuerySetRequest, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            UpdateSampleQuerySetRequest request = new UpdateSampleQuerySetRequest
            {
                SampleQuerySet = new SampleQuerySet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.UpdateSampleQuerySet(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQuerySetAsync</summary>
        public async Task UpdateSampleQuerySetRequestObjectAsync()
        {
            // Snippet: UpdateSampleQuerySetAsync(UpdateSampleQuerySetRequest, CallSettings)
            // Additional: UpdateSampleQuerySetAsync(UpdateSampleQuerySetRequest, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSampleQuerySetRequest request = new UpdateSampleQuerySetRequest
            {
                SampleQuerySet = new SampleQuerySet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.UpdateSampleQuerySetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQuerySet</summary>
        public void UpdateSampleQuerySet()
        {
            // Snippet: UpdateSampleQuerySet(SampleQuerySet, FieldMask, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            SampleQuerySet sampleQuerySet = new SampleQuerySet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SampleQuerySet response = sampleQuerySetServiceClient.UpdateSampleQuerySet(sampleQuerySet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSampleQuerySetAsync</summary>
        public async Task UpdateSampleQuerySetAsync()
        {
            // Snippet: UpdateSampleQuerySetAsync(SampleQuerySet, FieldMask, CallSettings)
            // Additional: UpdateSampleQuerySetAsync(SampleQuerySet, FieldMask, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQuerySet sampleQuerySet = new SampleQuerySet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SampleQuerySet response = await sampleQuerySetServiceClient.UpdateSampleQuerySetAsync(sampleQuerySet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuerySet</summary>
        public void DeleteSampleQuerySetRequestObject()
        {
            // Snippet: DeleteSampleQuerySet(DeleteSampleQuerySetRequest, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            DeleteSampleQuerySetRequest request = new DeleteSampleQuerySetRequest
            {
                SampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
            };
            // Make the request
            sampleQuerySetServiceClient.DeleteSampleQuerySet(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuerySetAsync</summary>
        public async Task DeleteSampleQuerySetRequestObjectAsync()
        {
            // Snippet: DeleteSampleQuerySetAsync(DeleteSampleQuerySetRequest, CallSettings)
            // Additional: DeleteSampleQuerySetAsync(DeleteSampleQuerySetRequest, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSampleQuerySetRequest request = new DeleteSampleQuerySetRequest
            {
                SampleQuerySetName = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]"),
            };
            // Make the request
            await sampleQuerySetServiceClient.DeleteSampleQuerySetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuerySet</summary>
        public void DeleteSampleQuerySet()
        {
            // Snippet: DeleteSampleQuerySet(string, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            // Make the request
            sampleQuerySetServiceClient.DeleteSampleQuerySet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuerySetAsync</summary>
        public async Task DeleteSampleQuerySetAsync()
        {
            // Snippet: DeleteSampleQuerySetAsync(string, CallSettings)
            // Additional: DeleteSampleQuerySetAsync(string, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sampleQuerySets/[SAMPLE_QUERY_SET]";
            // Make the request
            await sampleQuerySetServiceClient.DeleteSampleQuerySetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuerySet</summary>
        public void DeleteSampleQuerySetResourceNames()
        {
            // Snippet: DeleteSampleQuerySet(SampleQuerySetName, CallSettings)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = SampleQuerySetServiceClient.Create();
            // Initialize request argument(s)
            SampleQuerySetName name = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            // Make the request
            sampleQuerySetServiceClient.DeleteSampleQuerySet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSampleQuerySetAsync</summary>
        public async Task DeleteSampleQuerySetResourceNamesAsync()
        {
            // Snippet: DeleteSampleQuerySetAsync(SampleQuerySetName, CallSettings)
            // Additional: DeleteSampleQuerySetAsync(SampleQuerySetName, CancellationToken)
            // Create client
            SampleQuerySetServiceClient sampleQuerySetServiceClient = await SampleQuerySetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SampleQuerySetName name = SampleQuerySetName.FromProjectLocationSampleQuerySet("[PROJECT]", "[LOCATION]", "[SAMPLE_QUERY_SET]");
            // Make the request
            await sampleQuerySetServiceClient.DeleteSampleQuerySetAsync(name);
            // End snippet
        }
    }
}
