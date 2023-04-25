// Copyright 2023 Google LLC
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
    using Google.Maps.MapsPlatformDatasets.V1Alpha;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMapsPlatformDatasetsV1AlphaClientSnippets
    {
        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetRequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.CreateDataset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.CreateDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset()
        {
            // Snippet: CreateDataset(string, Dataset, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.CreateDataset(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(string, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(string, Dataset, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.CreateDatasetAsync(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetResourceNames()
        {
            // Snippet: CreateDataset(ProjectName, Dataset, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.CreateDataset(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetResourceNamesAsync()
        {
            // Snippet: CreateDatasetAsync(ProjectName, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(ProjectName, Dataset, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.CreateDatasetAsync(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadata</summary>
        public void UpdateDatasetMetadataRequestObject()
        {
            // Snippet: UpdateDatasetMetadata(UpdateDatasetMetadataRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            UpdateDatasetMetadataRequest request = new UpdateDatasetMetadataRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadataAsync</summary>
        public async Task UpdateDatasetMetadataRequestObjectAsync()
        {
            // Snippet: UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest, CallSettings)
            // Additional: UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetMetadataRequest request = new UpdateDatasetMetadataRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadata</summary>
        public void UpdateDatasetMetadata()
        {
            // Snippet: UpdateDatasetMetadata(Dataset, FieldMask, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadata(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadataAsync</summary>
        public async Task UpdateDatasetMetadataAsync()
        {
            // Snippet: UpdateDatasetMetadataAsync(Dataset, FieldMask, CallSettings)
            // Additional: UpdateDatasetMetadataAsync(Dataset, FieldMask, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadataAsync(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                PublishedUsage = Usage.Unspecified,
            };
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                PublishedUsage = Usage.Unspecified,
            };
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            Dataset response = mapsPlatformDatasetsV1AlphaClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            Dataset response = await mapsPlatformDatasetsV1AlphaClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatasetVersions</summary>
        public void ListDatasetVersionsRequestObject()
        {
            // Snippet: ListDatasetVersions(ListDatasetVersionsRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            ListDatasetVersionsRequest request = new ListDatasetVersionsRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            PagedEnumerable<ListDatasetVersionsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetVersionsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListDatasetVersionsAsync</summary>
        public async Task ListDatasetVersionsRequestObjectAsync()
        {
            // Snippet: ListDatasetVersionsAsync(ListDatasetVersionsRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetVersionsRequest request = new ListDatasetVersionsRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetVersionsResponse page) =>
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

        /// <summary>Snippet for ListDatasetVersions</summary>
        public void ListDatasetVersions()
        {
            // Snippet: ListDatasetVersions(string, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<ListDatasetVersionsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetVersions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetVersionsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListDatasetVersionsAsync</summary>
        public async Task ListDatasetVersionsAsync()
        {
            // Snippet: ListDatasetVersionsAsync(string, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetVersionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetVersionsResponse page) =>
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

        /// <summary>Snippet for ListDatasetVersions</summary>
        public void ListDatasetVersionsResourceNames()
        {
            // Snippet: ListDatasetVersions(DatasetName, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            PagedEnumerable<ListDatasetVersionsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetVersions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetVersionsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListDatasetVersionsAsync</summary>
        public async Task ListDatasetVersionsResourceNamesAsync()
        {
            // Snippet: ListDatasetVersionsAsync(DatasetName, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetVersionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetVersionsResponse page) =>
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
        public void ListDatasetsRequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasets(request);

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
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetsAsync(request);

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
            // Snippet: ListDatasets(string, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasets(parent);

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
            // Snippet: ListDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetsAsync(parent);

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
            // Snippet: ListDatasets(ProjectName, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasets(parent);

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
            // Snippet: ListDatasetsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsV1AlphaClient.ListDatasetsAsync(parent);

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
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                Force = false,
            };
            // Make the request
            mapsPlatformDatasetsV1AlphaClient.DeleteDataset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetRequestObjectAsync()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest, CallSettings)
            // Additional: DeleteDatasetAsync(DeleteDatasetRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                Force = false,
            };
            // Make the request
            await mapsPlatformDatasetsV1AlphaClient.DeleteDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(string, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            mapsPlatformDatasetsV1AlphaClient.DeleteDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(string, CallSettings)
            // Additional: DeleteDatasetAsync(string, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            await mapsPlatformDatasetsV1AlphaClient.DeleteDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetResourceNames()
        {
            // Snippet: DeleteDataset(DatasetName, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            mapsPlatformDatasetsV1AlphaClient.DeleteDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetResourceNamesAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            await mapsPlatformDatasetsV1AlphaClient.DeleteDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersion</summary>
        public void DeleteDatasetVersionRequestObject()
        {
            // Snippet: DeleteDatasetVersion(DeleteDatasetVersionRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            DeleteDatasetVersionRequest request = new DeleteDatasetVersionRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            mapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersionAsync</summary>
        public async Task DeleteDatasetVersionRequestObjectAsync()
        {
            // Snippet: DeleteDatasetVersionAsync(DeleteDatasetVersionRequest, CallSettings)
            // Additional: DeleteDatasetVersionAsync(DeleteDatasetVersionRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetVersionRequest request = new DeleteDatasetVersionRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            await mapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersion</summary>
        public void DeleteDatasetVersion()
        {
            // Snippet: DeleteDatasetVersion(string, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            mapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersionAsync</summary>
        public async Task DeleteDatasetVersionAsync()
        {
            // Snippet: DeleteDatasetVersionAsync(string, CallSettings)
            // Additional: DeleteDatasetVersionAsync(string, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            await mapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersion</summary>
        public void DeleteDatasetVersionResourceNames()
        {
            // Snippet: DeleteDatasetVersion(DatasetName, CallSettings)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = MapsPlatformDatasetsV1AlphaClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            mapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetVersionAsync</summary>
        public async Task DeleteDatasetVersionResourceNamesAsync()
        {
            // Snippet: DeleteDatasetVersionAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetVersionAsync(DatasetName, CancellationToken)
            // Create client
            MapsPlatformDatasetsV1AlphaClient mapsPlatformDatasetsV1AlphaClient = await MapsPlatformDatasetsV1AlphaClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            await mapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersionAsync(name);
            // End snippet
        }
    }
}
