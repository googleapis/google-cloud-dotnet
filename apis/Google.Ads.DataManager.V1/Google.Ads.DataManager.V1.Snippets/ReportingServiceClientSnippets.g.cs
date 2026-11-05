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
    using Google.Ads.DataManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReportingServiceClientSnippets
    {
        /// <summary>Snippet for RetrievePartnerMatchReport</summary>
        public void RetrievePartnerMatchReportRequestObject()
        {
            // Snippet: RetrievePartnerMatchReport(RetrievePartnerMatchReportRequest, CallSettings)
            // Create client
            ReportingServiceClient reportingServiceClient = ReportingServiceClient.Create();
            // Initialize request argument(s)
            RetrievePartnerMatchReportRequest request = new RetrievePartnerMatchReportRequest
            {
                Parent = "",
                CurrencyCode = "",
                Filter = "",
                StartDate = 0L,
                EndDate = 0L,
            };
            // Make the request
            PagedEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> response = reportingServiceClient.RetrievePartnerMatchReport(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PartnerMatchReportEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RetrievePartnerMatchReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerMatchReportEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerMatchReportEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerMatchReportEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RetrievePartnerMatchReportAsync</summary>
        public async Task RetrievePartnerMatchReportRequestObjectAsync()
        {
            // Snippet: RetrievePartnerMatchReportAsync(RetrievePartnerMatchReportRequest, CallSettings)
            // Create client
            ReportingServiceClient reportingServiceClient = await ReportingServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrievePartnerMatchReportRequest request = new RetrievePartnerMatchReportRequest
            {
                Parent = "",
                CurrencyCode = "",
                Filter = "",
                StartDate = 0L,
                EndDate = 0L,
            };
            // Make the request
            PagedAsyncEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> response = reportingServiceClient.RetrievePartnerMatchReportAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PartnerMatchReportEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RetrievePartnerMatchReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerMatchReportEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerMatchReportEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerMatchReportEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RetrievePartnerMatchReport</summary>
        public void RetrievePartnerMatchReport()
        {
            // Snippet: RetrievePartnerMatchReport(string, string, int?, CallSettings)
            // Create client
            ReportingServiceClient reportingServiceClient = ReportingServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> response = reportingServiceClient.RetrievePartnerMatchReport(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PartnerMatchReportEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RetrievePartnerMatchReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerMatchReportEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerMatchReportEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerMatchReportEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RetrievePartnerMatchReportAsync</summary>
        public async Task RetrievePartnerMatchReportAsync()
        {
            // Snippet: RetrievePartnerMatchReportAsync(string, string, int?, CallSettings)
            // Create client
            ReportingServiceClient reportingServiceClient = await ReportingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> response = reportingServiceClient.RetrievePartnerMatchReportAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PartnerMatchReportEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RetrievePartnerMatchReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerMatchReportEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerMatchReportEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerMatchReportEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
