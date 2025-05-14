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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.StorageInsights.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStorageInsightsClientSnippets
    {
        /// <summary>Snippet for ListReportConfigs</summary>
        public void ListReportConfigsRequestObject()
        {
            // Snippet: ListReportConfigs(ListReportConfigsRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ListReportConfigsRequest request = new ListReportConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReportConfigsResponse, ReportConfig> response = storageInsightsClient.ListReportConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigsAsync</summary>
        public async Task ListReportConfigsRequestObjectAsync()
        {
            // Snippet: ListReportConfigsAsync(ListReportConfigsRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListReportConfigsRequest request = new ListReportConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> response = storageInsightsClient.ListReportConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigs</summary>
        public void ListReportConfigs()
        {
            // Snippet: ListReportConfigs(string, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReportConfigsResponse, ReportConfig> response = storageInsightsClient.ListReportConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigsAsync</summary>
        public async Task ListReportConfigsAsync()
        {
            // Snippet: ListReportConfigsAsync(string, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> response = storageInsightsClient.ListReportConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigs</summary>
        public void ListReportConfigsResourceNames()
        {
            // Snippet: ListReportConfigs(LocationName, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReportConfigsResponse, ReportConfig> response = storageInsightsClient.ListReportConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportConfigsAsync</summary>
        public async Task ListReportConfigsResourceNamesAsync()
        {
            // Snippet: ListReportConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> response = storageInsightsClient.ListReportConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReportConfig</summary>
        public void GetReportConfigRequestObject()
        {
            // Snippet: GetReportConfig(GetReportConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            GetReportConfigRequest request = new GetReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
            };
            // Make the request
            ReportConfig response = storageInsightsClient.GetReportConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfigAsync</summary>
        public async Task GetReportConfigRequestObjectAsync()
        {
            // Snippet: GetReportConfigAsync(GetReportConfigRequest, CallSettings)
            // Additional: GetReportConfigAsync(GetReportConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetReportConfigRequest request = new GetReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
            };
            // Make the request
            ReportConfig response = await storageInsightsClient.GetReportConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfig</summary>
        public void GetReportConfig()
        {
            // Snippet: GetReportConfig(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            ReportConfig response = storageInsightsClient.GetReportConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfigAsync</summary>
        public async Task GetReportConfigAsync()
        {
            // Snippet: GetReportConfigAsync(string, CallSettings)
            // Additional: GetReportConfigAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            ReportConfig response = await storageInsightsClient.GetReportConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfig</summary>
        public void GetReportConfigResourceNames()
        {
            // Snippet: GetReportConfig(ReportConfigName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            ReportConfig response = storageInsightsClient.GetReportConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportConfigAsync</summary>
        public async Task GetReportConfigResourceNamesAsync()
        {
            // Snippet: GetReportConfigAsync(ReportConfigName, CallSettings)
            // Additional: GetReportConfigAsync(ReportConfigName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            ReportConfig response = await storageInsightsClient.GetReportConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfig</summary>
        public void CreateReportConfigRequestObject()
        {
            // Snippet: CreateReportConfig(CreateReportConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            CreateReportConfigRequest request = new CreateReportConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReportConfig = new ReportConfig(),
                RequestId = "",
            };
            // Make the request
            ReportConfig response = storageInsightsClient.CreateReportConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfigAsync</summary>
        public async Task CreateReportConfigRequestObjectAsync()
        {
            // Snippet: CreateReportConfigAsync(CreateReportConfigRequest, CallSettings)
            // Additional: CreateReportConfigAsync(CreateReportConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateReportConfigRequest request = new CreateReportConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReportConfig = new ReportConfig(),
                RequestId = "",
            };
            // Make the request
            ReportConfig response = await storageInsightsClient.CreateReportConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfig</summary>
        public void CreateReportConfig()
        {
            // Snippet: CreateReportConfig(string, ReportConfig, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ReportConfig reportConfig = new ReportConfig();
            // Make the request
            ReportConfig response = storageInsightsClient.CreateReportConfig(parent, reportConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfigAsync</summary>
        public async Task CreateReportConfigAsync()
        {
            // Snippet: CreateReportConfigAsync(string, ReportConfig, CallSettings)
            // Additional: CreateReportConfigAsync(string, ReportConfig, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ReportConfig reportConfig = new ReportConfig();
            // Make the request
            ReportConfig response = await storageInsightsClient.CreateReportConfigAsync(parent, reportConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfig</summary>
        public void CreateReportConfigResourceNames()
        {
            // Snippet: CreateReportConfig(LocationName, ReportConfig, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ReportConfig reportConfig = new ReportConfig();
            // Make the request
            ReportConfig response = storageInsightsClient.CreateReportConfig(parent, reportConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateReportConfigAsync</summary>
        public async Task CreateReportConfigResourceNamesAsync()
        {
            // Snippet: CreateReportConfigAsync(LocationName, ReportConfig, CallSettings)
            // Additional: CreateReportConfigAsync(LocationName, ReportConfig, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ReportConfig reportConfig = new ReportConfig();
            // Make the request
            ReportConfig response = await storageInsightsClient.CreateReportConfigAsync(parent, reportConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateReportConfig</summary>
        public void UpdateReportConfigRequestObject()
        {
            // Snippet: UpdateReportConfig(UpdateReportConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            UpdateReportConfigRequest request = new UpdateReportConfigRequest
            {
                UpdateMask = new FieldMask(),
                ReportConfig = new ReportConfig(),
                RequestId = "",
            };
            // Make the request
            ReportConfig response = storageInsightsClient.UpdateReportConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReportConfigAsync</summary>
        public async Task UpdateReportConfigRequestObjectAsync()
        {
            // Snippet: UpdateReportConfigAsync(UpdateReportConfigRequest, CallSettings)
            // Additional: UpdateReportConfigAsync(UpdateReportConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReportConfigRequest request = new UpdateReportConfigRequest
            {
                UpdateMask = new FieldMask(),
                ReportConfig = new ReportConfig(),
                RequestId = "",
            };
            // Make the request
            ReportConfig response = await storageInsightsClient.UpdateReportConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReportConfig</summary>
        public void UpdateReportConfig()
        {
            // Snippet: UpdateReportConfig(ReportConfig, FieldMask, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ReportConfig reportConfig = new ReportConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ReportConfig response = storageInsightsClient.UpdateReportConfig(reportConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReportConfigAsync</summary>
        public async Task UpdateReportConfigAsync()
        {
            // Snippet: UpdateReportConfigAsync(ReportConfig, FieldMask, CallSettings)
            // Additional: UpdateReportConfigAsync(ReportConfig, FieldMask, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfig reportConfig = new ReportConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ReportConfig response = await storageInsightsClient.UpdateReportConfigAsync(reportConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfig</summary>
        public void DeleteReportConfigRequestObject()
        {
            // Snippet: DeleteReportConfig(DeleteReportConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DeleteReportConfigRequest request = new DeleteReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                Force = false,
                RequestId = "",
            };
            // Make the request
            storageInsightsClient.DeleteReportConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfigAsync</summary>
        public async Task DeleteReportConfigRequestObjectAsync()
        {
            // Snippet: DeleteReportConfigAsync(DeleteReportConfigRequest, CallSettings)
            // Additional: DeleteReportConfigAsync(DeleteReportConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReportConfigRequest request = new DeleteReportConfigRequest
            {
                ReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                Force = false,
                RequestId = "",
            };
            // Make the request
            await storageInsightsClient.DeleteReportConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfig</summary>
        public void DeleteReportConfig()
        {
            // Snippet: DeleteReportConfig(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            storageInsightsClient.DeleteReportConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfigAsync</summary>
        public async Task DeleteReportConfigAsync()
        {
            // Snippet: DeleteReportConfigAsync(string, CallSettings)
            // Additional: DeleteReportConfigAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            await storageInsightsClient.DeleteReportConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfig</summary>
        public void DeleteReportConfigResourceNames()
        {
            // Snippet: DeleteReportConfig(ReportConfigName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            storageInsightsClient.DeleteReportConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportConfigAsync</summary>
        public async Task DeleteReportConfigResourceNamesAsync()
        {
            // Snippet: DeleteReportConfigAsync(ReportConfigName, CallSettings)
            // Additional: DeleteReportConfigAsync(ReportConfigName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName name = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            await storageInsightsClient.DeleteReportConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReportDetails</summary>
        public void ListReportDetailsRequestObject()
        {
            // Snippet: ListReportDetails(ListReportDetailsRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ListReportDetailsRequest request = new ListReportDetailsRequest
            {
                ParentAsReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReportDetailsResponse, ReportDetail> response = storageInsightsClient.ListReportDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportDetailsAsync</summary>
        public async Task ListReportDetailsRequestObjectAsync()
        {
            // Snippet: ListReportDetailsAsync(ListReportDetailsRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListReportDetailsRequest request = new ListReportDetailsRequest
            {
                ParentAsReportConfigName = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> response = storageInsightsClient.ListReportDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportDetails</summary>
        public void ListReportDetails()
        {
            // Snippet: ListReportDetails(string, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            PagedEnumerable<ListReportDetailsResponse, ReportDetail> response = storageInsightsClient.ListReportDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportDetailsAsync</summary>
        public async Task ListReportDetailsAsync()
        {
            // Snippet: ListReportDetailsAsync(string, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> response = storageInsightsClient.ListReportDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportDetails</summary>
        public void ListReportDetailsResourceNames()
        {
            // Snippet: ListReportDetails(ReportConfigName, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ReportConfigName parent = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            PagedEnumerable<ListReportDetailsResponse, ReportDetail> response = storageInsightsClient.ListReportDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReportDetail item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportDetail> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportDetailsAsync</summary>
        public async Task ListReportDetailsResourceNamesAsync()
        {
            // Snippet: ListReportDetailsAsync(ReportConfigName, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ReportConfigName parent = ReportConfigName.FromProjectLocationReportConfig("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> response = storageInsightsClient.ListReportDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReportDetail item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReportDetail item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReportDetail> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReportDetail item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReportDetail</summary>
        public void GetReportDetailRequestObject()
        {
            // Snippet: GetReportDetail(GetReportDetailRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            GetReportDetailRequest request = new GetReportDetailRequest
            {
                ReportDetailName = ReportDetailName.FromProjectLocationReportConfigReportDetail("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT_DETAIL]"),
            };
            // Make the request
            ReportDetail response = storageInsightsClient.GetReportDetail(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportDetailAsync</summary>
        public async Task GetReportDetailRequestObjectAsync()
        {
            // Snippet: GetReportDetailAsync(GetReportDetailRequest, CallSettings)
            // Additional: GetReportDetailAsync(GetReportDetailRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetReportDetailRequest request = new GetReportDetailRequest
            {
                ReportDetailName = ReportDetailName.FromProjectLocationReportConfigReportDetail("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT_DETAIL]"),
            };
            // Make the request
            ReportDetail response = await storageInsightsClient.GetReportDetailAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportDetail</summary>
        public void GetReportDetail()
        {
            // Snippet: GetReportDetail(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]/reportDetails/[REPORT_DETAIL]";
            // Make the request
            ReportDetail response = storageInsightsClient.GetReportDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportDetailAsync</summary>
        public async Task GetReportDetailAsync()
        {
            // Snippet: GetReportDetailAsync(string, CallSettings)
            // Additional: GetReportDetailAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reportConfigs/[REPORT_CONFIG]/reportDetails/[REPORT_DETAIL]";
            // Make the request
            ReportDetail response = await storageInsightsClient.GetReportDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportDetail</summary>
        public void GetReportDetailResourceNames()
        {
            // Snippet: GetReportDetail(ReportDetailName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ReportDetailName name = ReportDetailName.FromProjectLocationReportConfigReportDetail("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT_DETAIL]");
            // Make the request
            ReportDetail response = storageInsightsClient.GetReportDetail(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportDetailAsync</summary>
        public async Task GetReportDetailResourceNamesAsync()
        {
            // Snippet: GetReportDetailAsync(ReportDetailName, CallSettings)
            // Additional: GetReportDetailAsync(ReportDetailName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ReportDetailName name = ReportDetailName.FromProjectLocationReportConfigReportDetail("[PROJECT]", "[LOCATION]", "[REPORT_CONFIG]", "[REPORT_DETAIL]");
            // Make the request
            ReportDetail response = await storageInsightsClient.GetReportDetailAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatasetConfigs</summary>
        public void ListDatasetConfigsRequestObject()
        {
            // Snippet: ListDatasetConfigs(ListDatasetConfigsRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            ListDatasetConfigsRequest request = new ListDatasetConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> response = storageInsightsClient.ListDatasetConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatasetConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetConfigsAsync</summary>
        public async Task ListDatasetConfigsRequestObjectAsync()
        {
            // Snippet: ListDatasetConfigsAsync(ListDatasetConfigsRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetConfigsRequest request = new ListDatasetConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> response = storageInsightsClient.ListDatasetConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatasetConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetConfigs</summary>
        public void ListDatasetConfigs()
        {
            // Snippet: ListDatasetConfigs(string, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> response = storageInsightsClient.ListDatasetConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatasetConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetConfigsAsync</summary>
        public async Task ListDatasetConfigsAsync()
        {
            // Snippet: ListDatasetConfigsAsync(string, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> response = storageInsightsClient.ListDatasetConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatasetConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetConfigs</summary>
        public void ListDatasetConfigsResourceNames()
        {
            // Snippet: ListDatasetConfigs(LocationName, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> response = storageInsightsClient.ListDatasetConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatasetConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetConfigsAsync</summary>
        public async Task ListDatasetConfigsResourceNamesAsync()
        {
            // Snippet: ListDatasetConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> response = storageInsightsClient.ListDatasetConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatasetConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatasetConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatasetConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatasetConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDatasetConfig</summary>
        public void GetDatasetConfigRequestObject()
        {
            // Snippet: GetDatasetConfig(GetDatasetConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            GetDatasetConfigRequest request = new GetDatasetConfigRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
            };
            // Make the request
            DatasetConfig response = storageInsightsClient.GetDatasetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetConfigAsync</summary>
        public async Task GetDatasetConfigRequestObjectAsync()
        {
            // Snippet: GetDatasetConfigAsync(GetDatasetConfigRequest, CallSettings)
            // Additional: GetDatasetConfigAsync(GetDatasetConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetConfigRequest request = new GetDatasetConfigRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
            };
            // Make the request
            DatasetConfig response = await storageInsightsClient.GetDatasetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetConfig</summary>
        public void GetDatasetConfig()
        {
            // Snippet: GetDatasetConfig(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            DatasetConfig response = storageInsightsClient.GetDatasetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetConfigAsync</summary>
        public async Task GetDatasetConfigAsync()
        {
            // Snippet: GetDatasetConfigAsync(string, CallSettings)
            // Additional: GetDatasetConfigAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            DatasetConfig response = await storageInsightsClient.GetDatasetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetConfig</summary>
        public void GetDatasetConfigResourceNames()
        {
            // Snippet: GetDatasetConfig(DatasetConfigName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            DatasetConfig response = storageInsightsClient.GetDatasetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetConfigAsync</summary>
        public async Task GetDatasetConfigResourceNamesAsync()
        {
            // Snippet: GetDatasetConfigAsync(DatasetConfigName, CallSettings)
            // Additional: GetDatasetConfigAsync(DatasetConfigName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            DatasetConfig response = await storageInsightsClient.GetDatasetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetConfig</summary>
        public void CreateDatasetConfigRequestObject()
        {
            // Snippet: CreateDatasetConfig(CreateDatasetConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            CreateDatasetConfigRequest request = new CreateDatasetConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DatasetConfigId = "",
                DatasetConfig = new DatasetConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = storageInsightsClient.CreateDatasetConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceCreateDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetConfigAsync</summary>
        public async Task CreateDatasetConfigRequestObjectAsync()
        {
            // Snippet: CreateDatasetConfigAsync(CreateDatasetConfigRequest, CallSettings)
            // Additional: CreateDatasetConfigAsync(CreateDatasetConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetConfigRequest request = new CreateDatasetConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DatasetConfigId = "",
                DatasetConfig = new DatasetConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = await storageInsightsClient.CreateDatasetConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceCreateDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetConfig</summary>
        public void CreateDatasetConfig()
        {
            // Snippet: CreateDatasetConfig(string, DatasetConfig, string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DatasetConfig datasetConfig = new DatasetConfig();
            string datasetConfigId = "";
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = storageInsightsClient.CreateDatasetConfig(parent, datasetConfig, datasetConfigId);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceCreateDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetConfigAsync</summary>
        public async Task CreateDatasetConfigAsync()
        {
            // Snippet: CreateDatasetConfigAsync(string, DatasetConfig, string, CallSettings)
            // Additional: CreateDatasetConfigAsync(string, DatasetConfig, string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DatasetConfig datasetConfig = new DatasetConfig();
            string datasetConfigId = "";
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = await storageInsightsClient.CreateDatasetConfigAsync(parent, datasetConfig, datasetConfigId);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceCreateDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetConfig</summary>
        public void CreateDatasetConfigResourceNames()
        {
            // Snippet: CreateDatasetConfig(LocationName, DatasetConfig, string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DatasetConfig datasetConfig = new DatasetConfig();
            string datasetConfigId = "";
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = storageInsightsClient.CreateDatasetConfig(parent, datasetConfig, datasetConfigId);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceCreateDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetConfigAsync</summary>
        public async Task CreateDatasetConfigResourceNamesAsync()
        {
            // Snippet: CreateDatasetConfigAsync(LocationName, DatasetConfig, string, CallSettings)
            // Additional: CreateDatasetConfigAsync(LocationName, DatasetConfig, string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DatasetConfig datasetConfig = new DatasetConfig();
            string datasetConfigId = "";
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = await storageInsightsClient.CreateDatasetConfigAsync(parent, datasetConfig, datasetConfigId);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceCreateDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetConfig</summary>
        public void UpdateDatasetConfigRequestObject()
        {
            // Snippet: UpdateDatasetConfig(UpdateDatasetConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            UpdateDatasetConfigRequest request = new UpdateDatasetConfigRequest
            {
                UpdateMask = new FieldMask(),
                DatasetConfig = new DatasetConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = storageInsightsClient.UpdateDatasetConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceUpdateDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetConfigAsync</summary>
        public async Task UpdateDatasetConfigRequestObjectAsync()
        {
            // Snippet: UpdateDatasetConfigAsync(UpdateDatasetConfigRequest, CallSettings)
            // Additional: UpdateDatasetConfigAsync(UpdateDatasetConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetConfigRequest request = new UpdateDatasetConfigRequest
            {
                UpdateMask = new FieldMask(),
                DatasetConfig = new DatasetConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = await storageInsightsClient.UpdateDatasetConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceUpdateDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetConfig</summary>
        public void UpdateDatasetConfig()
        {
            // Snippet: UpdateDatasetConfig(DatasetConfig, FieldMask, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DatasetConfig datasetConfig = new DatasetConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = storageInsightsClient.UpdateDatasetConfig(datasetConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceUpdateDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetConfigAsync</summary>
        public async Task UpdateDatasetConfigAsync()
        {
            // Snippet: UpdateDatasetConfigAsync(DatasetConfig, FieldMask, CallSettings)
            // Additional: UpdateDatasetConfigAsync(DatasetConfig, FieldMask, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetConfig datasetConfig = new DatasetConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DatasetConfig, OperationMetadata> response = await storageInsightsClient.UpdateDatasetConfigAsync(datasetConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DatasetConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DatasetConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DatasetConfig, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceUpdateDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DatasetConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetConfig</summary>
        public void DeleteDatasetConfigRequestObject()
        {
            // Snippet: DeleteDatasetConfig(DeleteDatasetConfigRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DeleteDatasetConfigRequest request = new DeleteDatasetConfigRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = storageInsightsClient.DeleteDatasetConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceDeleteDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetConfigAsync</summary>
        public async Task DeleteDatasetConfigRequestObjectAsync()
        {
            // Snippet: DeleteDatasetConfigAsync(DeleteDatasetConfigRequest, CallSettings)
            // Additional: DeleteDatasetConfigAsync(DeleteDatasetConfigRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetConfigRequest request = new DeleteDatasetConfigRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await storageInsightsClient.DeleteDatasetConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceDeleteDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetConfig</summary>
        public void DeleteDatasetConfig()
        {
            // Snippet: DeleteDatasetConfig(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = storageInsightsClient.DeleteDatasetConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceDeleteDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetConfigAsync</summary>
        public async Task DeleteDatasetConfigAsync()
        {
            // Snippet: DeleteDatasetConfigAsync(string, CallSettings)
            // Additional: DeleteDatasetConfigAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await storageInsightsClient.DeleteDatasetConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceDeleteDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetConfig</summary>
        public void DeleteDatasetConfigResourceNames()
        {
            // Snippet: DeleteDatasetConfig(DatasetConfigName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = storageInsightsClient.DeleteDatasetConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceDeleteDatasetConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetConfigAsync</summary>
        public async Task DeleteDatasetConfigResourceNamesAsync()
        {
            // Snippet: DeleteDatasetConfigAsync(DatasetConfigName, CallSettings)
            // Additional: DeleteDatasetConfigAsync(DatasetConfigName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await storageInsightsClient.DeleteDatasetConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceDeleteDatasetConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LinkDataset</summary>
        public void LinkDatasetRequestObject()
        {
            // Snippet: LinkDataset(LinkDatasetRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            LinkDatasetRequest request = new LinkDatasetRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
            };
            // Make the request
            Operation<LinkDatasetResponse, OperationMetadata> response = storageInsightsClient.LinkDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<LinkDatasetResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LinkDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LinkDatasetResponse, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceLinkDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LinkDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LinkDatasetAsync</summary>
        public async Task LinkDatasetRequestObjectAsync()
        {
            // Snippet: LinkDatasetAsync(LinkDatasetRequest, CallSettings)
            // Additional: LinkDatasetAsync(LinkDatasetRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LinkDatasetRequest request = new LinkDatasetRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
            };
            // Make the request
            Operation<LinkDatasetResponse, OperationMetadata> response = await storageInsightsClient.LinkDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LinkDatasetResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LinkDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LinkDatasetResponse, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceLinkDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LinkDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LinkDataset</summary>
        public void LinkDataset()
        {
            // Snippet: LinkDataset(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            Operation<LinkDatasetResponse, OperationMetadata> response = storageInsightsClient.LinkDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<LinkDatasetResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LinkDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LinkDatasetResponse, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceLinkDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LinkDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LinkDatasetAsync</summary>
        public async Task LinkDatasetAsync()
        {
            // Snippet: LinkDatasetAsync(string, CallSettings)
            // Additional: LinkDatasetAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            Operation<LinkDatasetResponse, OperationMetadata> response = await storageInsightsClient.LinkDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<LinkDatasetResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LinkDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LinkDatasetResponse, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceLinkDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LinkDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LinkDataset</summary>
        public void LinkDatasetResourceNames()
        {
            // Snippet: LinkDataset(DatasetConfigName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            Operation<LinkDatasetResponse, OperationMetadata> response = storageInsightsClient.LinkDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<LinkDatasetResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            LinkDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LinkDatasetResponse, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceLinkDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LinkDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LinkDatasetAsync</summary>
        public async Task LinkDatasetResourceNamesAsync()
        {
            // Snippet: LinkDatasetAsync(DatasetConfigName, CallSettings)
            // Additional: LinkDatasetAsync(DatasetConfigName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            Operation<LinkDatasetResponse, OperationMetadata> response = await storageInsightsClient.LinkDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<LinkDatasetResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LinkDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LinkDatasetResponse, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceLinkDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LinkDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlinkDataset</summary>
        public void UnlinkDatasetRequestObject()
        {
            // Snippet: UnlinkDataset(UnlinkDatasetRequest, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            UnlinkDatasetRequest request = new UnlinkDatasetRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = storageInsightsClient.UnlinkDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceUnlinkDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlinkDatasetAsync</summary>
        public async Task UnlinkDatasetRequestObjectAsync()
        {
            // Snippet: UnlinkDatasetAsync(UnlinkDatasetRequest, CallSettings)
            // Additional: UnlinkDatasetAsync(UnlinkDatasetRequest, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UnlinkDatasetRequest request = new UnlinkDatasetRequest
            {
                DatasetConfigName = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await storageInsightsClient.UnlinkDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceUnlinkDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlinkDataset</summary>
        public void UnlinkDataset()
        {
            // Snippet: UnlinkDataset(string, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = storageInsightsClient.UnlinkDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceUnlinkDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlinkDatasetAsync</summary>
        public async Task UnlinkDatasetAsync()
        {
            // Snippet: UnlinkDatasetAsync(string, CallSettings)
            // Additional: UnlinkDatasetAsync(string, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/datasetConfigs/[DATASET_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await storageInsightsClient.UnlinkDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceUnlinkDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlinkDataset</summary>
        public void UnlinkDatasetResourceNames()
        {
            // Snippet: UnlinkDataset(DatasetConfigName, CallSettings)
            // Create client
            StorageInsightsClient storageInsightsClient = StorageInsightsClient.Create();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = storageInsightsClient.UnlinkDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = storageInsightsClient.PollOnceUnlinkDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnlinkDatasetAsync</summary>
        public async Task UnlinkDatasetResourceNamesAsync()
        {
            // Snippet: UnlinkDatasetAsync(DatasetConfigName, CallSettings)
            // Additional: UnlinkDatasetAsync(DatasetConfigName, CancellationToken)
            // Create client
            StorageInsightsClient storageInsightsClient = await StorageInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DatasetConfigName name = DatasetConfigName.FromProjectLocationDatasetConfig("[PROJECT]", "[LOCATION]", "[DATASET_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await storageInsightsClient.UnlinkDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await storageInsightsClient.PollOnceUnlinkDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
