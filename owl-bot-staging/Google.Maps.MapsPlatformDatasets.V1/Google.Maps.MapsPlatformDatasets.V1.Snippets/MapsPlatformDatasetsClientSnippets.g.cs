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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Maps.MapsPlatformDatasets.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gr = Google.Rpc;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMapsPlatformDatasetsClientSnippets
    {
        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetRequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.CreateDataset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Dataset = new Dataset(),
            };
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.CreateDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset()
        {
            // Snippet: CreateDataset(string, Dataset, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.CreateDataset(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(string, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(string, Dataset, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.CreateDatasetAsync(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetResourceNames()
        {
            // Snippet: CreateDataset(ProjectName, Dataset, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.CreateDataset(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetResourceNamesAsync()
        {
            // Snippet: CreateDatasetAsync(ProjectName, Dataset, CallSettings)
            // Additional: CreateDatasetAsync(ProjectName, Dataset, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Dataset dataset = new Dataset();
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.CreateDatasetAsync(parent, dataset);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadata</summary>
        public void UpdateDatasetMetadataRequestObject()
        {
            // Snippet: UpdateDatasetMetadata(UpdateDatasetMetadataRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            UpdateDatasetMetadataRequest request = new UpdateDatasetMetadataRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.UpdateDatasetMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadataAsync</summary>
        public async Task UpdateDatasetMetadataRequestObjectAsync()
        {
            // Snippet: UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest, CallSettings)
            // Additional: UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetMetadataRequest request = new UpdateDatasetMetadataRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.UpdateDatasetMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadata</summary>
        public void UpdateDatasetMetadata()
        {
            // Snippet: UpdateDatasetMetadata(Dataset, FieldMask, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.UpdateDatasetMetadata(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetMetadataAsync</summary>
        public async Task UpdateDatasetMetadataAsync()
        {
            // Snippet: UpdateDatasetMetadataAsync(Dataset, FieldMask, CallSettings)
            // Additional: UpdateDatasetMetadataAsync(Dataset, FieldMask, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.UpdateDatasetMetadataAsync(dataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            Dataset response = mapsPlatformDatasetsClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            Dataset response = await mapsPlatformDatasetsClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchDatasetErrors</summary>
        public void FetchDatasetErrorsRequestObject()
        {
            // Snippet: FetchDatasetErrors(FetchDatasetErrorsRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            FetchDatasetErrorsRequest request = new FetchDatasetErrorsRequest
            {
                DatasetAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> response = mapsPlatformDatasetsClient.FetchDatasetErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gr::Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchDatasetErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gr::Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gr::Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gr::Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchDatasetErrorsAsync</summary>
        public async Task FetchDatasetErrorsRequestObjectAsync()
        {
            // Snippet: FetchDatasetErrorsAsync(FetchDatasetErrorsRequest, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            FetchDatasetErrorsRequest request = new FetchDatasetErrorsRequest
            {
                DatasetAsDatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> response = mapsPlatformDatasetsClient.FetchDatasetErrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gr::Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchDatasetErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gr::Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gr::Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gr::Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchDatasetErrors</summary>
        public void FetchDatasetErrors()
        {
            // Snippet: FetchDatasetErrors(string, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            string dataset = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> response = mapsPlatformDatasetsClient.FetchDatasetErrors(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gr::Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchDatasetErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gr::Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gr::Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gr::Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchDatasetErrorsAsync</summary>
        public async Task FetchDatasetErrorsAsync()
        {
            // Snippet: FetchDatasetErrorsAsync(string, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string dataset = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> response = mapsPlatformDatasetsClient.FetchDatasetErrorsAsync(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gr::Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchDatasetErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gr::Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gr::Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gr::Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchDatasetErrors</summary>
        public void FetchDatasetErrorsResourceNames()
        {
            // Snippet: FetchDatasetErrors(DatasetName, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> response = mapsPlatformDatasetsClient.FetchDatasetErrors(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gr::Status item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchDatasetErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gr::Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gr::Status> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gr::Status item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchDatasetErrorsAsync</summary>
        public async Task FetchDatasetErrorsResourceNamesAsync()
        {
            // Snippet: FetchDatasetErrorsAsync(DatasetName, string, int?, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> response = mapsPlatformDatasetsClient.FetchDatasetErrorsAsync(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gr::Status item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchDatasetErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gr::Status item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gr::Status> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gr::Status item in singlePage)
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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Tag = "",
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsClient.ListDatasets(request);

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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Tag = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsClient.ListDatasetsAsync(request);

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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsClient.ListDatasets(parent);

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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsClient.ListDatasetsAsync(parent);

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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsClient.ListDatasets(parent);

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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = mapsPlatformDatasetsClient.ListDatasetsAsync(parent);

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
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            mapsPlatformDatasetsClient.DeleteDataset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetRequestObjectAsync()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest, CallSettings)
            // Additional: DeleteDatasetAsync(DeleteDatasetRequest, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
            };
            // Make the request
            await mapsPlatformDatasetsClient.DeleteDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(string, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            mapsPlatformDatasetsClient.DeleteDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(string, CallSettings)
            // Additional: DeleteDatasetAsync(string, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]";
            // Make the request
            await mapsPlatformDatasetsClient.DeleteDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetResourceNames()
        {
            // Snippet: DeleteDataset(DatasetName, CallSettings)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = MapsPlatformDatasetsClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            mapsPlatformDatasetsClient.DeleteDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetResourceNamesAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName, CancellationToken)
            // Create client
            MapsPlatformDatasetsClient mapsPlatformDatasetsClient = await MapsPlatformDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]");
            // Make the request
            await mapsPlatformDatasetsClient.DeleteDatasetAsync(name);
            // End snippet
        }
    }
}
