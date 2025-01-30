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
    using Google.Cloud.WebSecurityScanner.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWebSecurityScannerClientSnippets
    {
        /// <summary>Snippet for CreateScanConfig</summary>
        public void CreateScanConfigRequestObject()
        {
            // Snippet: CreateScanConfig(CreateScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            CreateScanConfigRequest request = new CreateScanConfigRequest
            {
                Parent = "",
                ScanConfig = new ScanConfig(),
            };
            // Make the request
            ScanConfig response = webSecurityScannerClient.CreateScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateScanConfigAsync</summary>
        public async Task CreateScanConfigRequestObjectAsync()
        {
            // Snippet: CreateScanConfigAsync(CreateScanConfigRequest, CallSettings)
            // Additional: CreateScanConfigAsync(CreateScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            CreateScanConfigRequest request = new CreateScanConfigRequest
            {
                Parent = "",
                ScanConfig = new ScanConfig(),
            };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.CreateScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfig</summary>
        public void DeleteScanConfigRequestObject()
        {
            // Snippet: DeleteScanConfig(DeleteScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            DeleteScanConfigRequest request = new DeleteScanConfigRequest { Name = "", };
            // Make the request
            webSecurityScannerClient.DeleteScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteScanConfigAsync</summary>
        public async Task DeleteScanConfigRequestObjectAsync()
        {
            // Snippet: DeleteScanConfigAsync(DeleteScanConfigRequest, CallSettings)
            // Additional: DeleteScanConfigAsync(DeleteScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScanConfigRequest request = new DeleteScanConfigRequest { Name = "", };
            // Make the request
            await webSecurityScannerClient.DeleteScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfig</summary>
        public void GetScanConfigRequestObject()
        {
            // Snippet: GetScanConfig(GetScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetScanConfigRequest request = new GetScanConfigRequest { Name = "", };
            // Make the request
            ScanConfig response = webSecurityScannerClient.GetScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfigAsync</summary>
        public async Task GetScanConfigRequestObjectAsync()
        {
            // Snippet: GetScanConfigAsync(GetScanConfigRequest, CallSettings)
            // Additional: GetScanConfigAsync(GetScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            GetScanConfigRequest request = new GetScanConfigRequest { Name = "", };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.GetScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigs</summary>
        public void ListScanConfigsRequestObject()
        {
            // Snippet: ListScanConfigs(ListScanConfigsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListScanConfigsRequest request = new ListScanConfigsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigsAsync</summary>
        public async Task ListScanConfigsRequestObjectAsync()
        {
            // Snippet: ListScanConfigsAsync(ListScanConfigsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListScanConfigsRequest request = new ListScanConfigsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> response = webSecurityScannerClient.ListScanConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfig</summary>
        public void UpdateScanConfigRequestObject()
        {
            // Snippet: UpdateScanConfig(UpdateScanConfigRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScanConfig response = webSecurityScannerClient.UpdateScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfigAsync</summary>
        public async Task UpdateScanConfigRequestObjectAsync()
        {
            // Snippet: UpdateScanConfigAsync(UpdateScanConfigRequest, CallSettings)
            // Additional: UpdateScanConfigAsync(UpdateScanConfigRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfig = new ScanConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScanConfig response = await webSecurityScannerClient.UpdateScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartScanRun</summary>
        public void StartScanRunRequestObject()
        {
            // Snippet: StartScanRun(StartScanRunRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            StartScanRunRequest request = new StartScanRunRequest { Name = "", };
            // Make the request
            ScanRun response = webSecurityScannerClient.StartScanRun(request);
            // End snippet
        }

        /// <summary>Snippet for StartScanRunAsync</summary>
        public async Task StartScanRunRequestObjectAsync()
        {
            // Snippet: StartScanRunAsync(StartScanRunRequest, CallSettings)
            // Additional: StartScanRunAsync(StartScanRunRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            StartScanRunRequest request = new StartScanRunRequest { Name = "", };
            // Make the request
            ScanRun response = await webSecurityScannerClient.StartScanRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanRun</summary>
        public void GetScanRunRequestObject()
        {
            // Snippet: GetScanRun(GetScanRunRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetScanRunRequest request = new GetScanRunRequest { Name = "", };
            // Make the request
            ScanRun response = webSecurityScannerClient.GetScanRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanRunAsync</summary>
        public async Task GetScanRunRequestObjectAsync()
        {
            // Snippet: GetScanRunAsync(GetScanRunRequest, CallSettings)
            // Additional: GetScanRunAsync(GetScanRunRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            GetScanRunRequest request = new GetScanRunRequest { Name = "", };
            // Make the request
            ScanRun response = await webSecurityScannerClient.GetScanRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListScanRuns</summary>
        public void ListScanRunsRequestObject()
        {
            // Snippet: ListScanRuns(ListScanRunsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListScanRunsRequest request = new ListScanRunsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanRunsAsync</summary>
        public async Task ListScanRunsRequestObjectAsync()
        {
            // Snippet: ListScanRunsAsync(ListScanRunsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListScanRunsRequest request = new ListScanRunsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> response = webSecurityScannerClient.ListScanRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for StopScanRun</summary>
        public void StopScanRunRequestObject()
        {
            // Snippet: StopScanRun(StopScanRunRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            StopScanRunRequest request = new StopScanRunRequest { Name = "", };
            // Make the request
            ScanRun response = webSecurityScannerClient.StopScanRun(request);
            // End snippet
        }

        /// <summary>Snippet for StopScanRunAsync</summary>
        public async Task StopScanRunRequestObjectAsync()
        {
            // Snippet: StopScanRunAsync(StopScanRunRequest, CallSettings)
            // Additional: StopScanRunAsync(StopScanRunRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            StopScanRunRequest request = new StopScanRunRequest { Name = "", };
            // Make the request
            ScanRun response = await webSecurityScannerClient.StopScanRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrls</summary>
        public void ListCrawledUrlsRequestObject()
        {
            // Snippet: ListCrawledUrls(ListCrawledUrlsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListCrawledUrlsRequest request = new ListCrawledUrlsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CrawledUrl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCrawledUrlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCrawledUrlsAsync</summary>
        public async Task ListCrawledUrlsRequestObjectAsync()
        {
            // Snippet: ListCrawledUrlsAsync(ListCrawledUrlsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListCrawledUrlsRequest request = new ListCrawledUrlsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> response = webSecurityScannerClient.ListCrawledUrlsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CrawledUrl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCrawledUrlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CrawledUrl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CrawledUrl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CrawledUrl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFinding</summary>
        public void GetFindingRequestObject()
        {
            // Snippet: GetFinding(GetFindingRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest { Name = "", };
            // Make the request
            Finding response = webSecurityScannerClient.GetFinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingAsync</summary>
        public async Task GetFindingRequestObjectAsync()
        {
            // Snippet: GetFindingAsync(GetFindingRequest, CallSettings)
            // Additional: GetFindingAsync(GetFindingRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest { Name = "", };
            // Make the request
            Finding response = await webSecurityScannerClient.GetFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindingsRequestObject()
        {
            // Snippet: ListFindings(ListFindingsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Finding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsAsync</summary>
        public async Task ListFindingsRequestObjectAsync()
        {
            // Snippet: ListFindingsAsync(ListFindingsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, Finding> response = webSecurityScannerClient.ListFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Finding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Finding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Finding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Finding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStats</summary>
        public void ListFindingTypeStatsRequestObject()
        {
            // Snippet: ListFindingTypeStats(ListFindingTypeStatsRequest, CallSettings)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            ListFindingTypeStatsRequest request = new ListFindingTypeStatsRequest { Parent = "", };
            // Make the request
            ListFindingTypeStatsResponse response = webSecurityScannerClient.ListFindingTypeStats(request);
            // End snippet
        }

        /// <summary>Snippet for ListFindingTypeStatsAsync</summary>
        public async Task ListFindingTypeStatsRequestObjectAsync()
        {
            // Snippet: ListFindingTypeStatsAsync(ListFindingTypeStatsRequest, CallSettings)
            // Additional: ListFindingTypeStatsAsync(ListFindingTypeStatsRequest, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingTypeStatsRequest request = new ListFindingTypeStatsRequest { Parent = "", };
            // Make the request
            ListFindingTypeStatsResponse response = await webSecurityScannerClient.ListFindingTypeStatsAsync(request);
            // End snippet
        }
    }
}
