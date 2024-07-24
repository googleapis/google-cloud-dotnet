// Copyright 2024 Google LLC
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
    using Google.Analytics.Data.V1Beta;
    using Google.Api.Gax;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBetaAnalyticsDataClientSnippets
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

        /// <summary>Snippet for CreateAudienceExport</summary>
        public void CreateAudienceExportRequestObject()
        {
            // Snippet: CreateAudienceExport(CreateAudienceExportRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            CreateAudienceExportRequest request = new CreateAudienceExportRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                AudienceExport = new AudienceExport(),
            };
            // Make the request
            Operation<AudienceExport, AudienceExportMetadata> response = betaAnalyticsDataClient.CreateAudienceExport(request);

            // Poll until the returned long-running operation is complete
            Operation<AudienceExport, AudienceExportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AudienceExport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AudienceExport, AudienceExportMetadata> retrievedResponse = betaAnalyticsDataClient.PollOnceCreateAudienceExport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AudienceExport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceExportAsync</summary>
        public async Task CreateAudienceExportRequestObjectAsync()
        {
            // Snippet: CreateAudienceExportAsync(CreateAudienceExportRequest, CallSettings)
            // Additional: CreateAudienceExportAsync(CreateAudienceExportRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            CreateAudienceExportRequest request = new CreateAudienceExportRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                AudienceExport = new AudienceExport(),
            };
            // Make the request
            Operation<AudienceExport, AudienceExportMetadata> response = await betaAnalyticsDataClient.CreateAudienceExportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AudienceExport, AudienceExportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AudienceExport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AudienceExport, AudienceExportMetadata> retrievedResponse = await betaAnalyticsDataClient.PollOnceCreateAudienceExportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AudienceExport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceExport</summary>
        public void CreateAudienceExport()
        {
            // Snippet: CreateAudienceExport(string, AudienceExport, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            AudienceExport audienceExport = new AudienceExport();
            // Make the request
            Operation<AudienceExport, AudienceExportMetadata> response = betaAnalyticsDataClient.CreateAudienceExport(parent, audienceExport);

            // Poll until the returned long-running operation is complete
            Operation<AudienceExport, AudienceExportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AudienceExport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AudienceExport, AudienceExportMetadata> retrievedResponse = betaAnalyticsDataClient.PollOnceCreateAudienceExport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AudienceExport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceExportAsync</summary>
        public async Task CreateAudienceExportAsync()
        {
            // Snippet: CreateAudienceExportAsync(string, AudienceExport, CallSettings)
            // Additional: CreateAudienceExportAsync(string, AudienceExport, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            AudienceExport audienceExport = new AudienceExport();
            // Make the request
            Operation<AudienceExport, AudienceExportMetadata> response = await betaAnalyticsDataClient.CreateAudienceExportAsync(parent, audienceExport);

            // Poll until the returned long-running operation is complete
            Operation<AudienceExport, AudienceExportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AudienceExport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AudienceExport, AudienceExportMetadata> retrievedResponse = await betaAnalyticsDataClient.PollOnceCreateAudienceExportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AudienceExport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceExport</summary>
        public void CreateAudienceExportResourceNames()
        {
            // Snippet: CreateAudienceExport(PropertyName, AudienceExport, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            AudienceExport audienceExport = new AudienceExport();
            // Make the request
            Operation<AudienceExport, AudienceExportMetadata> response = betaAnalyticsDataClient.CreateAudienceExport(parent, audienceExport);

            // Poll until the returned long-running operation is complete
            Operation<AudienceExport, AudienceExportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AudienceExport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AudienceExport, AudienceExportMetadata> retrievedResponse = betaAnalyticsDataClient.PollOnceCreateAudienceExport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AudienceExport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceExportAsync</summary>
        public async Task CreateAudienceExportResourceNamesAsync()
        {
            // Snippet: CreateAudienceExportAsync(PropertyName, AudienceExport, CallSettings)
            // Additional: CreateAudienceExportAsync(PropertyName, AudienceExport, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            AudienceExport audienceExport = new AudienceExport();
            // Make the request
            Operation<AudienceExport, AudienceExportMetadata> response = await betaAnalyticsDataClient.CreateAudienceExportAsync(parent, audienceExport);

            // Poll until the returned long-running operation is complete
            Operation<AudienceExport, AudienceExportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AudienceExport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AudienceExport, AudienceExportMetadata> retrievedResponse = await betaAnalyticsDataClient.PollOnceCreateAudienceExportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AudienceExport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for QueryAudienceExport</summary>
        public void QueryAudienceExportRequestObject()
        {
            // Snippet: QueryAudienceExport(QueryAudienceExportRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            QueryAudienceExportRequest request = new QueryAudienceExportRequest
            {
                Name = "",
                Offset = 0L,
                Limit = 0L,
            };
            // Make the request
            QueryAudienceExportResponse response = betaAnalyticsDataClient.QueryAudienceExport(request);
            // End snippet
        }

        /// <summary>Snippet for QueryAudienceExportAsync</summary>
        public async Task QueryAudienceExportRequestObjectAsync()
        {
            // Snippet: QueryAudienceExportAsync(QueryAudienceExportRequest, CallSettings)
            // Additional: QueryAudienceExportAsync(QueryAudienceExportRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            QueryAudienceExportRequest request = new QueryAudienceExportRequest
            {
                Name = "",
                Offset = 0L,
                Limit = 0L,
            };
            // Make the request
            QueryAudienceExportResponse response = await betaAnalyticsDataClient.QueryAudienceExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryAudienceExport</summary>
        public void QueryAudienceExport()
        {
            // Snippet: QueryAudienceExport(string, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            QueryAudienceExportResponse response = betaAnalyticsDataClient.QueryAudienceExport(name);
            // End snippet
        }

        /// <summary>Snippet for QueryAudienceExportAsync</summary>
        public async Task QueryAudienceExportAsync()
        {
            // Snippet: QueryAudienceExportAsync(string, CallSettings)
            // Additional: QueryAudienceExportAsync(string, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            QueryAudienceExportResponse response = await betaAnalyticsDataClient.QueryAudienceExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceExport</summary>
        public void GetAudienceExportRequestObject()
        {
            // Snippet: GetAudienceExport(GetAudienceExportRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            GetAudienceExportRequest request = new GetAudienceExportRequest
            {
                AudienceExportName = AudienceExportName.FromPropertyAudienceExport("[PROPERTY]", "[AUDIENCE_EXPORT]"),
            };
            // Make the request
            AudienceExport response = betaAnalyticsDataClient.GetAudienceExport(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceExportAsync</summary>
        public async Task GetAudienceExportRequestObjectAsync()
        {
            // Snippet: GetAudienceExportAsync(GetAudienceExportRequest, CallSettings)
            // Additional: GetAudienceExportAsync(GetAudienceExportRequest, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            GetAudienceExportRequest request = new GetAudienceExportRequest
            {
                AudienceExportName = AudienceExportName.FromPropertyAudienceExport("[PROPERTY]", "[AUDIENCE_EXPORT]"),
            };
            // Make the request
            AudienceExport response = await betaAnalyticsDataClient.GetAudienceExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceExport</summary>
        public void GetAudienceExport()
        {
            // Snippet: GetAudienceExport(string, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/audienceExports/[AUDIENCE_EXPORT]";
            // Make the request
            AudienceExport response = betaAnalyticsDataClient.GetAudienceExport(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceExportAsync</summary>
        public async Task GetAudienceExportAsync()
        {
            // Snippet: GetAudienceExportAsync(string, CallSettings)
            // Additional: GetAudienceExportAsync(string, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/audienceExports/[AUDIENCE_EXPORT]";
            // Make the request
            AudienceExport response = await betaAnalyticsDataClient.GetAudienceExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceExport</summary>
        public void GetAudienceExportResourceNames()
        {
            // Snippet: GetAudienceExport(AudienceExportName, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            AudienceExportName name = AudienceExportName.FromPropertyAudienceExport("[PROPERTY]", "[AUDIENCE_EXPORT]");
            // Make the request
            AudienceExport response = betaAnalyticsDataClient.GetAudienceExport(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceExportAsync</summary>
        public async Task GetAudienceExportResourceNamesAsync()
        {
            // Snippet: GetAudienceExportAsync(AudienceExportName, CallSettings)
            // Additional: GetAudienceExportAsync(AudienceExportName, CancellationToken)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            AudienceExportName name = AudienceExportName.FromPropertyAudienceExport("[PROPERTY]", "[AUDIENCE_EXPORT]");
            // Make the request
            AudienceExport response = await betaAnalyticsDataClient.GetAudienceExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAudienceExports</summary>
        public void ListAudienceExportsRequestObject()
        {
            // Snippet: ListAudienceExports(ListAudienceExportsRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            ListAudienceExportsRequest request = new ListAudienceExportsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListAudienceExportsResponse, AudienceExport> response = betaAnalyticsDataClient.ListAudienceExports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceExportsAsync</summary>
        public async Task ListAudienceExportsRequestObjectAsync()
        {
            // Snippet: ListAudienceExportsAsync(ListAudienceExportsRequest, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            ListAudienceExportsRequest request = new ListAudienceExportsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> response = betaAnalyticsDataClient.ListAudienceExportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AudienceExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudienceExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceExports</summary>
        public void ListAudienceExports()
        {
            // Snippet: ListAudienceExports(string, string, int?, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListAudienceExportsResponse, AudienceExport> response = betaAnalyticsDataClient.ListAudienceExports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceExportsAsync</summary>
        public async Task ListAudienceExportsAsync()
        {
            // Snippet: ListAudienceExportsAsync(string, string, int?, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> response = betaAnalyticsDataClient.ListAudienceExportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AudienceExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudienceExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceExports</summary>
        public void ListAudienceExportsResourceNames()
        {
            // Snippet: ListAudienceExports(PropertyName, string, int?, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = BetaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListAudienceExportsResponse, AudienceExport> response = betaAnalyticsDataClient.ListAudienceExports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceExport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceExportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceExport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceExport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceExportsAsync</summary>
        public async Task ListAudienceExportsResourceNamesAsync()
        {
            // Snippet: ListAudienceExportsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> response = betaAnalyticsDataClient.ListAudienceExportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AudienceExport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudienceExportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceExport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceExport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceExport item in singlePage)
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
