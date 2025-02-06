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
    using Google.Cloud.Logging.V2;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMetricsServiceV2ClientSnippets
    {
        /// <summary>Snippet for ListLogMetrics</summary>
        public void ListLogMetricsRequestObject()
        {
            // Snippet: ListLogMetrics(ListLogMetricsRequest, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            ListLogMetricsRequest request = new ListLogMetricsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListLogMetricsResponse, LogMetric> response = metricsServiceV2Client.ListLogMetrics(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetricsAsync</summary>
        public async Task ListLogMetricsRequestObjectAsync()
        {
            // Snippet: ListLogMetricsAsync(ListLogMetricsRequest, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListLogMetricsRequest request = new ListLogMetricsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> response = metricsServiceV2Client.ListLogMetricsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetrics</summary>
        public void ListLogMetrics()
        {
            // Snippet: ListLogMetrics(string, string, int?, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListLogMetricsResponse, LogMetric> response = metricsServiceV2Client.ListLogMetrics(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetricsAsync</summary>
        public async Task ListLogMetricsAsync()
        {
            // Snippet: ListLogMetricsAsync(string, string, int?, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> response = metricsServiceV2Client.ListLogMetricsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetrics</summary>
        public void ListLogMetricsResourceNames()
        {
            // Snippet: ListLogMetrics(ProjectName, string, int?, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListLogMetricsResponse, LogMetric> response = metricsServiceV2Client.ListLogMetrics(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetricsAsync</summary>
        public async Task ListLogMetricsResourceNamesAsync()
        {
            // Snippet: ListLogMetricsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> response = metricsServiceV2Client.ListLogMetricsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLogMetric</summary>
        public void GetLogMetricRequestObject()
        {
            // Snippet: GetLogMetric(GetLogMetricRequest, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            LogMetric response = metricsServiceV2Client.GetLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetricAsync</summary>
        public async Task GetLogMetricRequestObjectAsync()
        {
            // Snippet: GetLogMetricAsync(GetLogMetricRequest, CallSettings)
            // Additional: GetLogMetricAsync(GetLogMetricRequest, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            LogMetric response = await metricsServiceV2Client.GetLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetric</summary>
        public void GetLogMetric()
        {
            // Snippet: GetLogMetric(string, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string metricName = "projects/[PROJECT]/metrics/[METRIC]";
            // Make the request
            LogMetric response = metricsServiceV2Client.GetLogMetric(metricName);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetricAsync</summary>
        public async Task GetLogMetricAsync()
        {
            // Snippet: GetLogMetricAsync(string, CallSettings)
            // Additional: GetLogMetricAsync(string, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string metricName = "projects/[PROJECT]/metrics/[METRIC]";
            // Make the request
            LogMetric response = await metricsServiceV2Client.GetLogMetricAsync(metricName);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetric</summary>
        public void GetLogMetricResourceNames()
        {
            // Snippet: GetLogMetric(LogMetricName, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            LogMetricName metricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]");
            // Make the request
            LogMetric response = metricsServiceV2Client.GetLogMetric(metricName);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetricAsync</summary>
        public async Task GetLogMetricResourceNamesAsync()
        {
            // Snippet: GetLogMetricAsync(LogMetricName, CallSettings)
            // Additional: GetLogMetricAsync(LogMetricName, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LogMetricName metricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]");
            // Make the request
            LogMetric response = await metricsServiceV2Client.GetLogMetricAsync(metricName);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetric</summary>
        public void CreateLogMetricRequestObject()
        {
            // Snippet: CreateLogMetric(CreateLogMetricRequest, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = metricsServiceV2Client.CreateLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetricAsync</summary>
        public async Task CreateLogMetricRequestObjectAsync()
        {
            // Snippet: CreateLogMetricAsync(CreateLogMetricRequest, CallSettings)
            // Additional: CreateLogMetricAsync(CreateLogMetricRequest, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = await metricsServiceV2Client.CreateLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetric</summary>
        public void CreateLogMetric()
        {
            // Snippet: CreateLogMetric(string, LogMetric, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.CreateLogMetric(parent, metric);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetricAsync</summary>
        public async Task CreateLogMetricAsync()
        {
            // Snippet: CreateLogMetricAsync(string, LogMetric, CallSettings)
            // Additional: CreateLogMetricAsync(string, LogMetric, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.CreateLogMetricAsync(parent, metric);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetric</summary>
        public void CreateLogMetricResourceNames()
        {
            // Snippet: CreateLogMetric(ProjectName, LogMetric, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.CreateLogMetric(parent, metric);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetricAsync</summary>
        public async Task CreateLogMetricResourceNamesAsync()
        {
            // Snippet: CreateLogMetricAsync(ProjectName, LogMetric, CallSettings)
            // Additional: CreateLogMetricAsync(ProjectName, LogMetric, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.CreateLogMetricAsync(parent, metric);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetric</summary>
        public void UpdateLogMetricRequestObject()
        {
            // Snippet: UpdateLogMetric(UpdateLogMetricRequest, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = metricsServiceV2Client.UpdateLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetricAsync</summary>
        public async Task UpdateLogMetricRequestObjectAsync()
        {
            // Snippet: UpdateLogMetricAsync(UpdateLogMetricRequest, CallSettings)
            // Additional: UpdateLogMetricAsync(UpdateLogMetricRequest, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = await metricsServiceV2Client.UpdateLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetric</summary>
        public void UpdateLogMetric()
        {
            // Snippet: UpdateLogMetric(string, LogMetric, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string metricName = "projects/[PROJECT]/metrics/[METRIC]";
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.UpdateLogMetric(metricName, metric);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetricAsync</summary>
        public async Task UpdateLogMetricAsync()
        {
            // Snippet: UpdateLogMetricAsync(string, LogMetric, CallSettings)
            // Additional: UpdateLogMetricAsync(string, LogMetric, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string metricName = "projects/[PROJECT]/metrics/[METRIC]";
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.UpdateLogMetricAsync(metricName, metric);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetric</summary>
        public void UpdateLogMetricResourceNames()
        {
            // Snippet: UpdateLogMetric(LogMetricName, LogMetric, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            LogMetricName metricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.UpdateLogMetric(metricName, metric);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetricAsync</summary>
        public async Task UpdateLogMetricResourceNamesAsync()
        {
            // Snippet: UpdateLogMetricAsync(LogMetricName, LogMetric, CallSettings)
            // Additional: UpdateLogMetricAsync(LogMetricName, LogMetric, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LogMetricName metricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.UpdateLogMetricAsync(metricName, metric);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetric</summary>
        public void DeleteLogMetricRequestObject()
        {
            // Snippet: DeleteLogMetric(DeleteLogMetricRequest, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            metricsServiceV2Client.DeleteLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetricAsync</summary>
        public async Task DeleteLogMetricRequestObjectAsync()
        {
            // Snippet: DeleteLogMetricAsync(DeleteLogMetricRequest, CallSettings)
            // Additional: DeleteLogMetricAsync(DeleteLogMetricRequest, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            await metricsServiceV2Client.DeleteLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetric</summary>
        public void DeleteLogMetric()
        {
            // Snippet: DeleteLogMetric(string, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            string metricName = "projects/[PROJECT]/metrics/[METRIC]";
            // Make the request
            metricsServiceV2Client.DeleteLogMetric(metricName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetricAsync</summary>
        public async Task DeleteLogMetricAsync()
        {
            // Snippet: DeleteLogMetricAsync(string, CallSettings)
            // Additional: DeleteLogMetricAsync(string, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string metricName = "projects/[PROJECT]/metrics/[METRIC]";
            // Make the request
            await metricsServiceV2Client.DeleteLogMetricAsync(metricName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetric</summary>
        public void DeleteLogMetricResourceNames()
        {
            // Snippet: DeleteLogMetric(LogMetricName, CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            LogMetricName metricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]");
            // Make the request
            metricsServiceV2Client.DeleteLogMetric(metricName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetricAsync</summary>
        public async Task DeleteLogMetricResourceNamesAsync()
        {
            // Snippet: DeleteLogMetricAsync(LogMetricName, CallSettings)
            // Additional: DeleteLogMetricAsync(LogMetricName, CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LogMetricName metricName = LogMetricName.FromProjectMetric("[PROJECT]", "[METRIC]");
            // Make the request
            await metricsServiceV2Client.DeleteLogMetricAsync(metricName);
            // End snippet
        }
    }
}
