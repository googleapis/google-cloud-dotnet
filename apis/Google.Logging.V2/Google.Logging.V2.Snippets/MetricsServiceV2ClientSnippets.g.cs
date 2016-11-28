// Copyright 2016, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Logging.V2;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Logging.V2.Snippets
{
    public class GeneratedMetricsServiceV2ClientSnippets
    {
        public async Task ListLogMetricsAsync()
        {
            // Snippet: ListLogMetricsAsync(string,string,int?,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = MetricsServiceV2Client.FormatParentName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListLogMetricsResponse,LogMetric> response =
                metricsServiceV2Client.ListLogMetricsAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogMetric item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogMetric item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListLogMetrics()
        {
            // Snippet: ListLogMetrics(string,string,int?,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = MetricsServiceV2Client.FormatParentName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListLogMetricsResponse,LogMetric> response =
                metricsServiceV2Client.ListLogMetrics(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogMetric item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogMetric item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task GetLogMetricAsync()
        {
            // Snippet: GetLogMetricAsync(string,CallSettings)
            // Additional: GetLogMetricAsync(string,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedMetricName = MetricsServiceV2Client.FormatMetricName("[PROJECT]", "[METRIC]");
            // Make the request
            LogMetric response = await metricsServiceV2Client.GetLogMetricAsync(formattedMetricName);
            // End snippet
        }

        public void GetLogMetric()
        {
            // Snippet: GetLogMetric(string,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedMetricName = MetricsServiceV2Client.FormatMetricName("[PROJECT]", "[METRIC]");
            // Make the request
            LogMetric response = metricsServiceV2Client.GetLogMetric(formattedMetricName);
            // End snippet
        }

        public async Task CreateLogMetricAsync()
        {
            // Snippet: CreateLogMetricAsync(string,LogMetric,CallSettings)
            // Additional: CreateLogMetricAsync(string,LogMetric,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = MetricsServiceV2Client.FormatParentName("[PROJECT]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.CreateLogMetricAsync(formattedParent, metric);
            // End snippet
        }

        public void CreateLogMetric()
        {
            // Snippet: CreateLogMetric(string,LogMetric,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = MetricsServiceV2Client.FormatParentName("[PROJECT]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.CreateLogMetric(formattedParent, metric);
            // End snippet
        }

        public async Task UpdateLogMetricAsync()
        {
            // Snippet: UpdateLogMetricAsync(string,LogMetric,CallSettings)
            // Additional: UpdateLogMetricAsync(string,LogMetric,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedMetricName = MetricsServiceV2Client.FormatMetricName("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.UpdateLogMetricAsync(formattedMetricName, metric);
            // End snippet
        }

        public void UpdateLogMetric()
        {
            // Snippet: UpdateLogMetric(string,LogMetric,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedMetricName = MetricsServiceV2Client.FormatMetricName("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.UpdateLogMetric(formattedMetricName, metric);
            // End snippet
        }

        public async Task DeleteLogMetricAsync()
        {
            // Snippet: DeleteLogMetricAsync(string,CallSettings)
            // Additional: DeleteLogMetricAsync(string,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedMetricName = MetricsServiceV2Client.FormatMetricName("[PROJECT]", "[METRIC]");
            // Make the request
            await metricsServiceV2Client.DeleteLogMetricAsync(formattedMetricName);
            // End snippet
        }

        public void DeleteLogMetric()
        {
            // Snippet: DeleteLogMetric(string,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedMetricName = MetricsServiceV2Client.FormatMetricName("[PROJECT]", "[METRIC]");
            // Make the request
            metricsServiceV2Client.DeleteLogMetric(formattedMetricName);
            // End snippet
        }

    }
}
