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
    }
}
