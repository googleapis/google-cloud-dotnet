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
    using Google.Cloud.Dataflow.V1Beta3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMetricsV1Beta3ClientSnippets
    {
        /// <summary>Snippet for GetJobMetrics</summary>
        public void GetJobMetricsRequestObject()
        {
            // Snippet: GetJobMetrics(GetJobMetricsRequest, CallSettings)
            // Create client
            MetricsV1Beta3Client metricsV1Beta3Client = MetricsV1Beta3Client.Create();
            // Initialize request argument(s)
            GetJobMetricsRequest request = new GetJobMetricsRequest
            {
                ProjectId = "",
                JobId = "",
                StartTime = new Timestamp(),
                Location = "",
            };
            // Make the request
            JobMetrics response = metricsV1Beta3Client.GetJobMetrics(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobMetricsAsync</summary>
        public async Task GetJobMetricsRequestObjectAsync()
        {
            // Snippet: GetJobMetricsAsync(GetJobMetricsRequest, CallSettings)
            // Additional: GetJobMetricsAsync(GetJobMetricsRequest, CancellationToken)
            // Create client
            MetricsV1Beta3Client metricsV1Beta3Client = await MetricsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            GetJobMetricsRequest request = new GetJobMetricsRequest
            {
                ProjectId = "",
                JobId = "",
                StartTime = new Timestamp(),
                Location = "",
            };
            // Make the request
            JobMetrics response = await metricsV1Beta3Client.GetJobMetricsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobExecutionDetails</summary>
        public void GetJobExecutionDetailsRequestObject()
        {
            // Snippet: GetJobExecutionDetails(GetJobExecutionDetailsRequest, CallSettings)
            // Create client
            MetricsV1Beta3Client metricsV1Beta3Client = MetricsV1Beta3Client.Create();
            // Initialize request argument(s)
            GetJobExecutionDetailsRequest request = new GetJobExecutionDetailsRequest
            {
                ProjectId = "",
                JobId = "",
                Location = "",
            };
            // Make the request
            PagedEnumerable<JobExecutionDetails, StageSummary> response = metricsV1Beta3Client.GetJobExecutionDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StageSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (JobExecutionDetails page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StageSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StageSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StageSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetJobExecutionDetailsAsync</summary>
        public async Task GetJobExecutionDetailsRequestObjectAsync()
        {
            // Snippet: GetJobExecutionDetailsAsync(GetJobExecutionDetailsRequest, CallSettings)
            // Create client
            MetricsV1Beta3Client metricsV1Beta3Client = await MetricsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            GetJobExecutionDetailsRequest request = new GetJobExecutionDetailsRequest
            {
                ProjectId = "",
                JobId = "",
                Location = "",
            };
            // Make the request
            PagedAsyncEnumerable<JobExecutionDetails, StageSummary> response = metricsV1Beta3Client.GetJobExecutionDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StageSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((JobExecutionDetails page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StageSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StageSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StageSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetStageExecutionDetails</summary>
        public void GetStageExecutionDetailsRequestObject()
        {
            // Snippet: GetStageExecutionDetails(GetStageExecutionDetailsRequest, CallSettings)
            // Create client
            MetricsV1Beta3Client metricsV1Beta3Client = MetricsV1Beta3Client.Create();
            // Initialize request argument(s)
            GetStageExecutionDetailsRequest request = new GetStageExecutionDetailsRequest
            {
                ProjectId = "",
                JobId = "",
                Location = "",
                StageId = "",
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<StageExecutionDetails, WorkerDetails> response = metricsV1Beta3Client.GetStageExecutionDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkerDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StageExecutionDetails page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkerDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkerDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkerDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetStageExecutionDetailsAsync</summary>
        public async Task GetStageExecutionDetailsRequestObjectAsync()
        {
            // Snippet: GetStageExecutionDetailsAsync(GetStageExecutionDetailsRequest, CallSettings)
            // Create client
            MetricsV1Beta3Client metricsV1Beta3Client = await MetricsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            GetStageExecutionDetailsRequest request = new GetStageExecutionDetailsRequest
            {
                ProjectId = "",
                JobId = "",
                Location = "",
                StageId = "",
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<StageExecutionDetails, WorkerDetails> response = metricsV1Beta3Client.GetStageExecutionDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkerDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StageExecutionDetails page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkerDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkerDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkerDetails item in singlePage)
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
