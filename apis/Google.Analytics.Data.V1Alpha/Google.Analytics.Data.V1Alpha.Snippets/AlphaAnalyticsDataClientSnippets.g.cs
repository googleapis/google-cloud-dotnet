// Copyright 2021 Google LLC
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

namespace Google.Analytics.Data.V1Alpha.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAlphaAnalyticsDataClientSnippets
    {
        /// <summary>Snippet for RunReport</summary>
        public void RunReportRequestObject()
        {
            // Snippet: RunReport(RunReportRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                Entity = new Entity(),
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Offset = 0L,
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                OrderBys = { new OrderBy(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunReportResponse response = alphaAnalyticsDataClient.RunReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunReportAsync</summary>
        public async Task RunReportRequestObjectAsync()
        {
            // Snippet: RunReportAsync(RunReportRequest, CallSettings)
            // Additional: RunReportAsync(RunReportRequest, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                Entity = new Entity(),
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Offset = 0L,
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                OrderBys = { new OrderBy(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunReportResponse response = await alphaAnalyticsDataClient.RunReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunPivotReport</summary>
        public void RunPivotReportRequestObject()
        {
            // Snippet: RunPivotReport(RunPivotReportRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunPivotReportRequest request = new RunPivotReportRequest
            {
                Entity = new Entity(),
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Pivots = { new Pivot(), },
                DateRanges = { new DateRange(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunPivotReportResponse response = alphaAnalyticsDataClient.RunPivotReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunPivotReportAsync</summary>
        public async Task RunPivotReportRequestObjectAsync()
        {
            // Snippet: RunPivotReportAsync(RunPivotReportRequest, CallSettings)
            // Additional: RunPivotReportAsync(RunPivotReportRequest, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunPivotReportRequest request = new RunPivotReportRequest
            {
                Entity = new Entity(),
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Pivots = { new Pivot(), },
                DateRanges = { new DateRange(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunPivotReportResponse response = await alphaAnalyticsDataClient.RunPivotReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunReports</summary>
        public void BatchRunReportsRequestObject()
        {
            // Snippet: BatchRunReports(BatchRunReportsRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            BatchRunReportsRequest request = new BatchRunReportsRequest
            {
                Entity = new Entity(),
                Requests =
                {
                    new RunReportRequest(),
                },
            };
            // Make the request
            BatchRunReportsResponse response = alphaAnalyticsDataClient.BatchRunReports(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunReportsAsync</summary>
        public async Task BatchRunReportsRequestObjectAsync()
        {
            // Snippet: BatchRunReportsAsync(BatchRunReportsRequest, CallSettings)
            // Additional: BatchRunReportsAsync(BatchRunReportsRequest, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunReportsRequest request = new BatchRunReportsRequest
            {
                Entity = new Entity(),
                Requests =
                {
                    new RunReportRequest(),
                },
            };
            // Make the request
            BatchRunReportsResponse response = await alphaAnalyticsDataClient.BatchRunReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunPivotReports</summary>
        public void BatchRunPivotReportsRequestObject()
        {
            // Snippet: BatchRunPivotReports(BatchRunPivotReportsRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest
            {
                Entity = new Entity(),
                Requests =
                {
                    new RunPivotReportRequest(),
                },
            };
            // Make the request
            BatchRunPivotReportsResponse response = alphaAnalyticsDataClient.BatchRunPivotReports(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunPivotReportsAsync</summary>
        public async Task BatchRunPivotReportsRequestObjectAsync()
        {
            // Snippet: BatchRunPivotReportsAsync(BatchRunPivotReportsRequest, CallSettings)
            // Additional: BatchRunPivotReportsAsync(BatchRunPivotReportsRequest, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest
            {
                Entity = new Entity(),
                Requests =
                {
                    new RunPivotReportRequest(),
                },
            };
            // Make the request
            BatchRunPivotReportsResponse response = await alphaAnalyticsDataClient.BatchRunPivotReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadata</summary>
        public void GetMetadataRequestObject()
        {
            // Snippet: GetMetadata(GetMetadataRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Metadata response = alphaAnalyticsDataClient.GetMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataRequestObjectAsync()
        {
            // Snippet: GetMetadataAsync(GetMetadataRequest, CallSettings)
            // Additional: GetMetadataAsync(GetMetadataRequest, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Metadata response = await alphaAnalyticsDataClient.GetMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadata</summary>
        public void GetMetadata()
        {
            // Snippet: GetMetadata(string, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/metadata";
            // Make the request
            Metadata response = alphaAnalyticsDataClient.GetMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataAsync()
        {
            // Snippet: GetMetadataAsync(string, CallSettings)
            // Additional: GetMetadataAsync(string, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/metadata";
            // Make the request
            Metadata response = await alphaAnalyticsDataClient.GetMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadata</summary>
        public void GetMetadataResourceNames()
        {
            // Snippet: GetMetadata(MetadataName, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            MetadataName name = MetadataName.FromProperty("[PROPERTY]");
            // Make the request
            Metadata response = alphaAnalyticsDataClient.GetMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataResourceNamesAsync()
        {
            // Snippet: GetMetadataAsync(MetadataName, CallSettings)
            // Additional: GetMetadataAsync(MetadataName, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            MetadataName name = MetadataName.FromProperty("[PROPERTY]");
            // Make the request
            Metadata response = await alphaAnalyticsDataClient.GetMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunRealtimeReport</summary>
        public void RunRealtimeReportRequestObject()
        {
            // Snippet: RunRealtimeReport(RunRealtimeReportRequest, CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                Limit = 0L,
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunRealtimeReportResponse response = alphaAnalyticsDataClient.RunRealtimeReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunRealtimeReportAsync</summary>
        public async Task RunRealtimeReportRequestObjectAsync()
        {
            // Snippet: RunRealtimeReportAsync(RunRealtimeReportRequest, CallSettings)
            // Additional: RunRealtimeReportAsync(RunRealtimeReportRequest, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                Limit = 0L,
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunRealtimeReportResponse response = await alphaAnalyticsDataClient.RunRealtimeReportAsync(request);
            // End snippet
        }
    }
}
