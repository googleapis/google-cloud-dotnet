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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CapacityPlanner.V1Beta;
    using Google.LongRunning;
    using Google.Type;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUsageServiceClientSnippets
    {
        /// <summary>Snippet for QueryUsageHistories</summary>
        public void QueryUsageHistoriesRequestObject()
        {
            // Snippet: QueryUsageHistories(QueryUsageHistoriesRequest, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            QueryUsageHistoriesRequest request = new QueryUsageHistoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                DiskType = "",
                GpuType = "",
                StartDate = new Date(),
                EndDate = new Date(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
                TpuType = "",
                MachineShape = new MachineShape(),
                IsSpot = false,
                ConfidentialMode = false,
            };
            // Make the request
            QueryUsageHistoriesResponse response = usageServiceClient.QueryUsageHistories(request);
            // End snippet
        }

        /// <summary>Snippet for QueryUsageHistoriesAsync</summary>
        public async Task QueryUsageHistoriesRequestObjectAsync()
        {
            // Snippet: QueryUsageHistoriesAsync(QueryUsageHistoriesRequest, CallSettings)
            // Additional: QueryUsageHistoriesAsync(QueryUsageHistoriesRequest, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryUsageHistoriesRequest request = new QueryUsageHistoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                DiskType = "",
                GpuType = "",
                StartDate = new Date(),
                EndDate = new Date(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
                TpuType = "",
                MachineShape = new MachineShape(),
                IsSpot = false,
                ConfidentialMode = false,
            };
            // Make the request
            QueryUsageHistoriesResponse response = await usageServiceClient.QueryUsageHistoriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryForecasts</summary>
        public void QueryForecastsRequestObject()
        {
            // Snippet: QueryForecasts(QueryForecastsRequest, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            QueryForecastsRequest request = new QueryForecastsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                ForecastType = Forecast.Types.ForecastType.Unspecified,
                PredictionInterval = Forecast.Types.PredictionInterval.Unspecified,
                AggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                DiskType = "",
                GpuType = "",
                TpuType = "",
                MachineShape = new MachineShape(),
                ConfidentialMode = false,
            };
            // Make the request
            QueryForecastsResponse response = usageServiceClient.QueryForecasts(request);
            // End snippet
        }

        /// <summary>Snippet for QueryForecastsAsync</summary>
        public async Task QueryForecastsRequestObjectAsync()
        {
            // Snippet: QueryForecastsAsync(QueryForecastsRequest, CallSettings)
            // Additional: QueryForecastsAsync(QueryForecastsRequest, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryForecastsRequest request = new QueryForecastsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                ForecastType = Forecast.Types.ForecastType.Unspecified,
                PredictionInterval = Forecast.Types.PredictionInterval.Unspecified,
                AggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                DiskType = "",
                GpuType = "",
                TpuType = "",
                MachineShape = new MachineShape(),
                ConfidentialMode = false,
            };
            // Make the request
            QueryForecastsResponse response = await usageServiceClient.QueryForecastsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryReservations</summary>
        public void QueryReservationsRequestObject()
        {
            // Snippet: QueryReservations(QueryReservationsRequest, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            QueryReservationsRequest request = new QueryReservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                GpuType = "",
                CloudResourceType = "",
                ReservationType = QueryReservationsRequest.Types.ReservationType.Unspecified,
                ShareType = QueryReservationsRequest.Types.ShareType.Unspecified,
                OwnershipType = QueryReservationsRequest.Types.OwnershipType.Unspecified,
                ReservationDataLevel = QueryReservationsRequest.Types.ReservationDataLevel.Unspecified,
                MachineShape = new MachineShape(),
                IncludeUnapprovedReservations = false,
                AggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
            };
            // Make the request
            QueryReservationsResponse response = usageServiceClient.QueryReservations(request);
            // End snippet
        }

        /// <summary>Snippet for QueryReservationsAsync</summary>
        public async Task QueryReservationsRequestObjectAsync()
        {
            // Snippet: QueryReservationsAsync(QueryReservationsRequest, CallSettings)
            // Additional: QueryReservationsAsync(QueryReservationsRequest, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryReservationsRequest request = new QueryReservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                GpuType = "",
                CloudResourceType = "",
                ReservationType = QueryReservationsRequest.Types.ReservationType.Unspecified,
                ShareType = QueryReservationsRequest.Types.ShareType.Unspecified,
                OwnershipType = QueryReservationsRequest.Types.OwnershipType.Unspecified,
                ReservationDataLevel = QueryReservationsRequest.Types.ReservationDataLevel.Unspecified,
                MachineShape = new MachineShape(),
                IncludeUnapprovedReservations = false,
                AggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
            };
            // Make the request
            QueryReservationsResponse response = await usageServiceClient.QueryReservationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryReservations</summary>
        public void QueryReservations()
        {
            // Snippet: QueryReservations(string, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            QueryReservationsResponse response = usageServiceClient.QueryReservations(parent);
            // End snippet
        }

        /// <summary>Snippet for QueryReservationsAsync</summary>
        public async Task QueryReservationsAsync()
        {
            // Snippet: QueryReservationsAsync(string, CallSettings)
            // Additional: QueryReservationsAsync(string, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            QueryReservationsResponse response = await usageServiceClient.QueryReservationsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for QueryReservations</summary>
        public void QueryReservationsResourceNames()
        {
            // Snippet: QueryReservations(LocationName, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            QueryReservationsResponse response = usageServiceClient.QueryReservations(parent);
            // End snippet
        }

        /// <summary>Snippet for QueryReservationsAsync</summary>
        public async Task QueryReservationsResourceNamesAsync()
        {
            // Snippet: QueryReservationsAsync(LocationName, CallSettings)
            // Additional: QueryReservationsAsync(LocationName, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            QueryReservationsResponse response = await usageServiceClient.QueryReservationsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ExportUsageHistories</summary>
        public void ExportUsageHistoriesRequestObject()
        {
            // Snippet: ExportUsageHistories(ExportUsageHistoriesRequest, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            ExportUsageHistoriesRequest request = new ExportUsageHistoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                DiskType = "",
                ResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                GpuType = "",
                TpuType = "",
                IsSpot = false,
                MachineShape = new MachineShape(),
            };
            // Make the request
            Operation<ExportUsageHistoriesResponse, OperationMetadata> response = usageServiceClient.ExportUsageHistories(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportUsageHistoriesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportUsageHistoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportUsageHistoriesResponse, OperationMetadata> retrievedResponse = usageServiceClient.PollOnceExportUsageHistories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportUsageHistoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportUsageHistoriesAsync</summary>
        public async Task ExportUsageHistoriesRequestObjectAsync()
        {
            // Snippet: ExportUsageHistoriesAsync(ExportUsageHistoriesRequest, CallSettings)
            // Additional: ExportUsageHistoriesAsync(ExportUsageHistoriesRequest, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportUsageHistoriesRequest request = new ExportUsageHistoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                DiskType = "",
                ResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                GpuType = "",
                TpuType = "",
                IsSpot = false,
                MachineShape = new MachineShape(),
            };
            // Make the request
            Operation<ExportUsageHistoriesResponse, OperationMetadata> response = await usageServiceClient.ExportUsageHistoriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportUsageHistoriesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportUsageHistoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportUsageHistoriesResponse, OperationMetadata> retrievedResponse = await usageServiceClient.PollOnceExportUsageHistoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportUsageHistoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportForecasts</summary>
        public void ExportForecastsRequestObject()
        {
            // Snippet: ExportForecasts(ExportForecastsRequest, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            ExportForecastsRequest request = new ExportForecastsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                DiskType = "",
                ResourceType = "",
                PredictionInterval = Forecast.Types.PredictionInterval.Unspecified,
                AggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                GpuType = "",
                TpuType = "",
                MachineShape = new MachineShape(),
            };
            // Make the request
            Operation<ExportForecastsResponse, OperationMetadata> response = usageServiceClient.ExportForecasts(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportForecastsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportForecastsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportForecastsResponse, OperationMetadata> retrievedResponse = usageServiceClient.PollOnceExportForecasts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportForecastsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportForecastsAsync</summary>
        public async Task ExportForecastsRequestObjectAsync()
        {
            // Snippet: ExportForecastsAsync(ExportForecastsRequest, CallSettings)
            // Additional: ExportForecastsAsync(ExportForecastsRequest, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportForecastsRequest request = new ExportForecastsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                DiskType = "",
                ResourceType = "",
                PredictionInterval = Forecast.Types.PredictionInterval.Unspecified,
                AggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                GpuType = "",
                TpuType = "",
                MachineShape = new MachineShape(),
            };
            // Make the request
            Operation<ExportForecastsResponse, OperationMetadata> response = await usageServiceClient.ExportForecastsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportForecastsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportForecastsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportForecastsResponse, OperationMetadata> retrievedResponse = await usageServiceClient.PollOnceExportForecastsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportForecastsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportReservationsUsage</summary>
        public void ExportReservationsUsageRequestObject()
        {
            // Snippet: ExportReservationsUsage(ExportReservationsUsageRequest, CallSettings)
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            ExportReservationsUsageRequest request = new ExportReservationsUsageRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                ShareType = ExportReservationsUsageRequest.Types.ShareType.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
            };
            // Make the request
            Operation<ExportReservationsUsageResponse, OperationMetadata> response = usageServiceClient.ExportReservationsUsage(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportReservationsUsageResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportReservationsUsageResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportReservationsUsageResponse, OperationMetadata> retrievedResponse = usageServiceClient.PollOnceExportReservationsUsage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportReservationsUsageResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportReservationsUsageAsync</summary>
        public async Task ExportReservationsUsageRequestObjectAsync()
        {
            // Snippet: ExportReservationsUsageAsync(ExportReservationsUsageRequest, CallSettings)
            // Additional: ExportReservationsUsageAsync(ExportReservationsUsageRequest, CancellationToken)
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportReservationsUsageRequest request = new ExportReservationsUsageRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                ShareType = ExportReservationsUsageRequest.Types.ShareType.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
            };
            // Make the request
            Operation<ExportReservationsUsageResponse, OperationMetadata> response = await usageServiceClient.ExportReservationsUsageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportReservationsUsageResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportReservationsUsageResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportReservationsUsageResponse, OperationMetadata> retrievedResponse = await usageServiceClient.PollOnceExportReservationsUsageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportReservationsUsageResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
