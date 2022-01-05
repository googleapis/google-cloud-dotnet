// Copyright 2022 Google LLC
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

namespace Google.Analytics.Data.V1Beta.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBetaAnalyticsDataClientSnippets
    {
        /// <summary>Snippet for RunReport</summary>
        public void RunReportRequestObject()
        {
            // Snippet: RunReport(RunReportRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Offset = 0L,
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunReportResponse response = betaAnalyticsDataClient.RunReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunReportAsync</summary>
        public async Task RunReportRequestObjectAsync()
        {
            // Snippet: RunReportAsync(RunReportRequest, CallSettings)
            // Additional: RunReportAsync(RunReportRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Offset = 0L,
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunReportResponse response = await betaAnalyticsDataClient.RunReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunPivotReport</summary>
        public void RunPivotReportRequestObject()
        {
            // Snippet: RunPivotReport(RunPivotReportRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunPivotReportRequest request = new RunPivotReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Pivots = { new Pivot(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunPivotReportResponse response = betaAnalyticsDataClient.RunPivotReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunPivotReportAsync</summary>
        public async Task RunPivotReportRequestObjectAsync()
        {
            // Snippet: RunPivotReportAsync(RunPivotReportRequest, CallSettings)
            // Additional: RunPivotReportAsync(RunPivotReportRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunPivotReportRequest request = new RunPivotReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DateRanges = { new DateRange(), },
                Pivots = { new Pivot(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CurrencyCode = "",
                CohortSpec = new CohortSpec(),
                KeepEmptyRows = false,
                ReturnPropertyQuota = false,
            };
            // Make the request
            RunPivotReportResponse response = await betaAnalyticsDataClient.RunPivotReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunReports</summary>
        public void BatchRunReportsRequestObject()
        {
            // Snippet: BatchRunReports(BatchRunReportsRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            BatchRunReportsRequest request = new BatchRunReportsRequest
            {
                Property = "",
                Requests =
                {
                    new RunReportRequest(),
                },
            };
            // Make the request
            BatchRunReportsResponse response = betaAnalyticsDataClient.BatchRunReports(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunReportsAsync</summary>
        public async Task BatchRunReportsRequestObjectAsync()
        {
            // Snippet: BatchRunReportsAsync(BatchRunReportsRequest, CallSettings)
            // Additional: BatchRunReportsAsync(BatchRunReportsRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunReportsRequest request = new BatchRunReportsRequest
            {
                Property = "",
                Requests =
                {
                    new RunReportRequest(),
                },
            };
            // Make the request
            BatchRunReportsResponse response = await betaAnalyticsDataClient.BatchRunReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunPivotReports</summary>
        public void BatchRunPivotReportsRequestObject()
        {
            // Snippet: BatchRunPivotReports(BatchRunPivotReportsRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest
            {
                Property = "",
                Requests =
                {
                    new RunPivotReportRequest(),
                },
            };
            // Make the request
            BatchRunPivotReportsResponse response = betaAnalyticsDataClient.BatchRunPivotReports(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunPivotReportsAsync</summary>
        public async Task BatchRunPivotReportsRequestObjectAsync()
        {
            // Snippet: BatchRunPivotReportsAsync(BatchRunPivotReportsRequest, CallSettings)
            // Additional: BatchRunPivotReportsAsync(BatchRunPivotReportsRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest
            {
                Property = "",
                Requests =
                {
                    new RunPivotReportRequest(),
                },
            };
            // Make the request
            BatchRunPivotReportsResponse response = await betaAnalyticsDataClient.BatchRunPivotReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadata</summary>
        public void GetMetadataRequestObject()
        {
            // Snippet: GetMetadata(GetMetadataRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Metadata response = betaAnalyticsDataClient.GetMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataRequestObjectAsync()
        {
            // Snippet: GetMetadataAsync(GetMetadataRequest, CallSettings)
            // Additional: GetMetadataAsync(GetMetadataRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            GetMetadataRequest request = new GetMetadataRequest
            {
                MetadataName = MetadataName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Metadata response = await betaAnalyticsDataClient.GetMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetadata</summary>
        public void GetMetadata()
        {
            // Snippet: GetMetadata(string, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/metadata";
            // Make the request
            Metadata response = betaAnalyticsDataClient.GetMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataAsync()
        {
            // Snippet: GetMetadataAsync(string, CallSettings)
            // Additional: GetMetadataAsync(string, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/metadata";
            // Make the request
            Metadata response = await betaAnalyticsDataClient.GetMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadata</summary>
        public void GetMetadataResourceNames()
        {
            // Snippet: GetMetadata(MetadataName, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            MetadataName name = MetadataName.FromProperty("[PROPERTY]");
            // Make the request
            Metadata response = betaAnalyticsDataClient.GetMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataResourceNamesAsync()
        {
            // Snippet: GetMetadataAsync(MetadataName, CallSettings)
            // Additional: GetMetadataAsync(MetadataName, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            MetadataName name = MetadataName.FromProperty("[PROPERTY]");
            // Make the request
            Metadata response = await betaAnalyticsDataClient.GetMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunRealtimeReport</summary>
        public void RunRealtimeReportRequestObject()
        {
            // Snippet: RunRealtimeReport(RunRealtimeReportRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = false,
                MinuteRanges = { new MinuteRange(), },
            };
            // Make the request
            RunRealtimeReportResponse response = betaAnalyticsDataClient.RunRealtimeReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunRealtimeReportAsync</summary>
        public async Task RunRealtimeReportRequestObjectAsync()
        {
            // Snippet: RunRealtimeReportAsync(RunRealtimeReportRequest, CallSettings)
            // Additional: RunRealtimeReportAsync(RunRealtimeReportRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunRealtimeReportRequest request = new RunRealtimeReportRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                Limit = 0L,
                MetricAggregations =
                {
                    MetricAggregation.Unspecified,
                },
                OrderBys = { new OrderBy(), },
                ReturnPropertyQuota = false,
                MinuteRanges = { new MinuteRange(), },
            };
            // Make the request
            RunRealtimeReportResponse response = await betaAnalyticsDataClient.RunRealtimeReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckCompatibility</summary>
        public void CheckCompatibilityRequestObject()
        {
            // Snippet: CheckCompatibility(CheckCompatibilityRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            CheckCompatibilityRequest request = new CheckCompatibilityRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CompatibilityFilter = Compatibility.Unspecified,
            };
            // Make the request
            CheckCompatibilityResponse response = betaAnalyticsDataClient.CheckCompatibility(request);
            // End snippet
        }

        /// <summary>Snippet for CheckCompatibilityAsync</summary>
        public async Task CheckCompatibilityRequestObjectAsync()
        {
            // Snippet: CheckCompatibilityAsync(CheckCompatibilityRequest, CallSettings)
            // Additional: CheckCompatibilityAsync(CheckCompatibilityRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            CheckCompatibilityRequest request = new CheckCompatibilityRequest
            {
                Property = "",
                Dimensions = { new Dimension(), },
                Metrics = { new Metric(), },
                DimensionFilter = new FilterExpression(),
                MetricFilter = new FilterExpression(),
                CompatibilityFilter = Compatibility.Unspecified,
            };
            // Make the request
            CheckCompatibilityResponse response = await betaAnalyticsDataClient.CheckCompatibilityAsync(request);
            // End snippet
        }
    }
}
