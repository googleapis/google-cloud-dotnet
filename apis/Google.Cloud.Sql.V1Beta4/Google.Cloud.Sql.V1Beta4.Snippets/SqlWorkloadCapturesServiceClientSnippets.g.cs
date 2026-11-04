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
    using Google.Cloud.Sql.V1Beta4;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlWorkloadCapturesServiceClientSnippets
    {
        /// <summary>Snippet for Start</summary>
        public void StartRequestObject()
        {
            // Snippet: Start(WorkloadCapturesStartRequest, CallSettings)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = SqlWorkloadCapturesServiceClient.Create();
            // Initialize request argument(s)
            WorkloadCapturesStartRequest request = new WorkloadCapturesStartRequest
            {
                Project = "",
                Instance = "",
                StartWorkloadCaptureContext = new StartWorkloadCaptureContext(),
            };
            // Make the request
            Operation response = sqlWorkloadCapturesServiceClient.Start(request);
            // End snippet
        }

        /// <summary>Snippet for StartAsync</summary>
        public async Task StartRequestObjectAsync()
        {
            // Snippet: StartAsync(WorkloadCapturesStartRequest, CallSettings)
            // Additional: StartAsync(WorkloadCapturesStartRequest, CancellationToken)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = await SqlWorkloadCapturesServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadCapturesStartRequest request = new WorkloadCapturesStartRequest
            {
                Project = "",
                Instance = "",
                StartWorkloadCaptureContext = new StartWorkloadCaptureContext(),
            };
            // Make the request
            Operation response = await sqlWorkloadCapturesServiceClient.StartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Stop</summary>
        public void StopRequestObject()
        {
            // Snippet: Stop(WorkloadCapturesStopRequest, CallSettings)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = SqlWorkloadCapturesServiceClient.Create();
            // Initialize request argument(s)
            WorkloadCapturesStopRequest request = new WorkloadCapturesStopRequest
            {
                Project = "",
                Instance = "",
                StopWorkloadCaptureContext = new StopWorkloadCaptureContext(),
            };
            // Make the request
            Operation response = sqlWorkloadCapturesServiceClient.Stop(request);
            // End snippet
        }

        /// <summary>Snippet for StopAsync</summary>
        public async Task StopRequestObjectAsync()
        {
            // Snippet: StopAsync(WorkloadCapturesStopRequest, CallSettings)
            // Additional: StopAsync(WorkloadCapturesStopRequest, CancellationToken)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = await SqlWorkloadCapturesServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadCapturesStopRequest request = new WorkloadCapturesStopRequest
            {
                Project = "",
                Instance = "",
                StopWorkloadCaptureContext = new StopWorkloadCaptureContext(),
            };
            // Make the request
            Operation response = await sqlWorkloadCapturesServiceClient.StopAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartReplay</summary>
        public void StartReplayRequestObject()
        {
            // Snippet: StartReplay(WorkloadCapturesStartReplayRequest, CallSettings)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = SqlWorkloadCapturesServiceClient.Create();
            // Initialize request argument(s)
            WorkloadCapturesStartReplayRequest request = new WorkloadCapturesStartReplayRequest
            {
                Project = "",
                Instance = "",
                WorkloadId = "",
                StartWorkloadReplayContext = new StartWorkloadReplayContext(),
            };
            // Make the request
            Operation response = sqlWorkloadCapturesServiceClient.StartReplay(request);
            // End snippet
        }

        /// <summary>Snippet for StartReplayAsync</summary>
        public async Task StartReplayRequestObjectAsync()
        {
            // Snippet: StartReplayAsync(WorkloadCapturesStartReplayRequest, CallSettings)
            // Additional: StartReplayAsync(WorkloadCapturesStartReplayRequest, CancellationToken)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = await SqlWorkloadCapturesServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadCapturesStartReplayRequest request = new WorkloadCapturesStartReplayRequest
            {
                Project = "",
                Instance = "",
                WorkloadId = "",
                StartWorkloadReplayContext = new StartWorkloadReplayContext(),
            };
            // Make the request
            Operation response = await sqlWorkloadCapturesServiceClient.StartReplayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StopReplay</summary>
        public void StopReplayRequestObject()
        {
            // Snippet: StopReplay(WorkloadCapturesStopReplayRequest, CallSettings)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = SqlWorkloadCapturesServiceClient.Create();
            // Initialize request argument(s)
            WorkloadCapturesStopReplayRequest request = new WorkloadCapturesStopReplayRequest
            {
                Project = "",
                Instance = "",
                StopWorkloadReplayContext = new StopWorkloadReplayContext(),
            };
            // Make the request
            Operation response = sqlWorkloadCapturesServiceClient.StopReplay(request);
            // End snippet
        }

        /// <summary>Snippet for StopReplayAsync</summary>
        public async Task StopReplayRequestObjectAsync()
        {
            // Snippet: StopReplayAsync(WorkloadCapturesStopReplayRequest, CallSettings)
            // Additional: StopReplayAsync(WorkloadCapturesStopReplayRequest, CancellationToken)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = await SqlWorkloadCapturesServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadCapturesStopReplayRequest request = new WorkloadCapturesStopReplayRequest
            {
                Project = "",
                Instance = "",
                StopWorkloadReplayContext = new StopWorkloadReplayContext(),
            };
            // Make the request
            Operation response = await sqlWorkloadCapturesServiceClient.StopReplayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlWorkloadCapturesListRequest, CallSettings)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = SqlWorkloadCapturesServiceClient.Create();
            // Initialize request argument(s)
            SqlWorkloadCapturesListRequest request = new SqlWorkloadCapturesListRequest
            {
                Project = "",
                Instance = "",
            };
            // Make the request
            WorkloadCapturesListResponse response = sqlWorkloadCapturesServiceClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(SqlWorkloadCapturesListRequest, CallSettings)
            // Additional: ListAsync(SqlWorkloadCapturesListRequest, CancellationToken)
            // Create client
            SqlWorkloadCapturesServiceClient sqlWorkloadCapturesServiceClient = await SqlWorkloadCapturesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlWorkloadCapturesListRequest request = new SqlWorkloadCapturesListRequest
            {
                Project = "",
                Instance = "",
            };
            // Make the request
            WorkloadCapturesListResponse response = await sqlWorkloadCapturesServiceClient.ListAsync(request);
            // End snippet
        }
    }
}
