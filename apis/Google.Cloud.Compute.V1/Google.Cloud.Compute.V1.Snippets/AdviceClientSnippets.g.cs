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
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAdviceClientSnippets
    {
        /// <summary>Snippet for CalendarMode</summary>
        public void CalendarModeRequestObject()
        {
            // Snippet: CalendarMode(CalendarModeAdviceRpcRequest, CallSettings)
            // Create client
            AdviceClient adviceClient = AdviceClient.Create();
            // Initialize request argument(s)
            CalendarModeAdviceRpcRequest request = new CalendarModeAdviceRpcRequest
            {
                Region = "",
                CalendarModeAdviceRequestResource = new CalendarModeAdviceRequest(),
                Project = "",
            };
            // Make the request
            CalendarModeAdviceResponse response = adviceClient.CalendarMode(request);
            // End snippet
        }

        /// <summary>Snippet for CalendarModeAsync</summary>
        public async Task CalendarModeRequestObjectAsync()
        {
            // Snippet: CalendarModeAsync(CalendarModeAdviceRpcRequest, CallSettings)
            // Additional: CalendarModeAsync(CalendarModeAdviceRpcRequest, CancellationToken)
            // Create client
            AdviceClient adviceClient = await AdviceClient.CreateAsync();
            // Initialize request argument(s)
            CalendarModeAdviceRpcRequest request = new CalendarModeAdviceRpcRequest
            {
                Region = "",
                CalendarModeAdviceRequestResource = new CalendarModeAdviceRequest(),
                Project = "",
            };
            // Make the request
            CalendarModeAdviceResponse response = await adviceClient.CalendarModeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalendarMode</summary>
        public void CalendarMode()
        {
            // Snippet: CalendarMode(string, string, CalendarModeAdviceRequest, CallSettings)
            // Create client
            AdviceClient adviceClient = AdviceClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CalendarModeAdviceRequest calendarModeAdviceRequestResource = new CalendarModeAdviceRequest();
            // Make the request
            CalendarModeAdviceResponse response = adviceClient.CalendarMode(project, region, calendarModeAdviceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CalendarModeAsync</summary>
        public async Task CalendarModeAsync()
        {
            // Snippet: CalendarModeAsync(string, string, CalendarModeAdviceRequest, CallSettings)
            // Additional: CalendarModeAsync(string, string, CalendarModeAdviceRequest, CancellationToken)
            // Create client
            AdviceClient adviceClient = await AdviceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CalendarModeAdviceRequest calendarModeAdviceRequestResource = new CalendarModeAdviceRequest();
            // Make the request
            CalendarModeAdviceResponse response = await adviceClient.CalendarModeAsync(project, region, calendarModeAdviceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Capacity</summary>
        public void CapacityRequestObject()
        {
            // Snippet: Capacity(CapacityAdviceRpcRequest, CallSettings)
            // Create client
            AdviceClient adviceClient = AdviceClient.Create();
            // Initialize request argument(s)
            CapacityAdviceRpcRequest request = new CapacityAdviceRpcRequest
            {
                Region = "",
                CapacityAdviceRequestResource = new CapacityAdviceRequest(),
                Project = "",
            };
            // Make the request
            CapacityAdviceResponse response = adviceClient.Capacity(request);
            // End snippet
        }

        /// <summary>Snippet for CapacityAsync</summary>
        public async Task CapacityRequestObjectAsync()
        {
            // Snippet: CapacityAsync(CapacityAdviceRpcRequest, CallSettings)
            // Additional: CapacityAsync(CapacityAdviceRpcRequest, CancellationToken)
            // Create client
            AdviceClient adviceClient = await AdviceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityAdviceRpcRequest request = new CapacityAdviceRpcRequest
            {
                Region = "",
                CapacityAdviceRequestResource = new CapacityAdviceRequest(),
                Project = "",
            };
            // Make the request
            CapacityAdviceResponse response = await adviceClient.CapacityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Capacity</summary>
        public void Capacity()
        {
            // Snippet: Capacity(string, string, CapacityAdviceRequest, CallSettings)
            // Create client
            AdviceClient adviceClient = AdviceClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CapacityAdviceRequest capacityAdviceRequestResource = new CapacityAdviceRequest();
            // Make the request
            CapacityAdviceResponse response = adviceClient.Capacity(project, region, capacityAdviceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CapacityAsync</summary>
        public async Task CapacityAsync()
        {
            // Snippet: CapacityAsync(string, string, CapacityAdviceRequest, CallSettings)
            // Additional: CapacityAsync(string, string, CapacityAdviceRequest, CancellationToken)
            // Create client
            AdviceClient adviceClient = await AdviceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CapacityAdviceRequest capacityAdviceRequestResource = new CapacityAdviceRequest();
            // Make the request
            CapacityAdviceResponse response = await adviceClient.CapacityAsync(project, region, capacityAdviceRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CapacityHistory</summary>
        public void CapacityHistoryRequestObject()
        {
            // Snippet: CapacityHistory(CapacityHistoryAdviceRequest, CallSettings)
            // Create client
            AdviceClient adviceClient = AdviceClient.Create();
            // Initialize request argument(s)
            CapacityHistoryAdviceRequest request = new CapacityHistoryAdviceRequest
            {
                Region = "",
                CapacityHistoryRequestResource = new CapacityHistoryRequest(),
                Project = "",
            };
            // Make the request
            CapacityHistoryResponse response = adviceClient.CapacityHistory(request);
            // End snippet
        }

        /// <summary>Snippet for CapacityHistoryAsync</summary>
        public async Task CapacityHistoryRequestObjectAsync()
        {
            // Snippet: CapacityHistoryAsync(CapacityHistoryAdviceRequest, CallSettings)
            // Additional: CapacityHistoryAsync(CapacityHistoryAdviceRequest, CancellationToken)
            // Create client
            AdviceClient adviceClient = await AdviceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityHistoryAdviceRequest request = new CapacityHistoryAdviceRequest
            {
                Region = "",
                CapacityHistoryRequestResource = new CapacityHistoryRequest(),
                Project = "",
            };
            // Make the request
            CapacityHistoryResponse response = await adviceClient.CapacityHistoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CapacityHistory</summary>
        public void CapacityHistory()
        {
            // Snippet: CapacityHistory(string, string, CapacityHistoryRequest, CallSettings)
            // Create client
            AdviceClient adviceClient = AdviceClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CapacityHistoryRequest capacityHistoryRequestResource = new CapacityHistoryRequest();
            // Make the request
            CapacityHistoryResponse response = adviceClient.CapacityHistory(project, region, capacityHistoryRequestResource);
            // End snippet
        }

        /// <summary>Snippet for CapacityHistoryAsync</summary>
        public async Task CapacityHistoryAsync()
        {
            // Snippet: CapacityHistoryAsync(string, string, CapacityHistoryRequest, CallSettings)
            // Additional: CapacityHistoryAsync(string, string, CapacityHistoryRequest, CancellationToken)
            // Create client
            AdviceClient adviceClient = await AdviceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            CapacityHistoryRequest capacityHistoryRequestResource = new CapacityHistoryRequest();
            // Make the request
            CapacityHistoryResponse response = await adviceClient.CapacityHistoryAsync(project, region, capacityHistoryRequestResource);
            // End snippet
        }
    }
}
