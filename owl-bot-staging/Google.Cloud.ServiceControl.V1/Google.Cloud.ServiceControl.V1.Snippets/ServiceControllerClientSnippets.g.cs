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
    using Google.Cloud.ServiceControl.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServiceControllerClientSnippets
    {
        /// <summary>Snippet for Check</summary>
        public void CheckRequestObject()
        {
            // Snippet: Check(CheckRequest, CallSettings)
            // Create client
            ServiceControllerClient serviceControllerClient = ServiceControllerClient.Create();
            // Initialize request argument(s)
            CheckRequest request = new CheckRequest
            {
                ServiceName = "",
                Operation = new Operation(),
                ServiceConfigId = "",
            };
            // Make the request
            CheckResponse response = serviceControllerClient.Check(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAsync</summary>
        public async Task CheckRequestObjectAsync()
        {
            // Snippet: CheckAsync(CheckRequest, CallSettings)
            // Additional: CheckAsync(CheckRequest, CancellationToken)
            // Create client
            ServiceControllerClient serviceControllerClient = await ServiceControllerClient.CreateAsync();
            // Initialize request argument(s)
            CheckRequest request = new CheckRequest
            {
                ServiceName = "",
                Operation = new Operation(),
                ServiceConfigId = "",
            };
            // Make the request
            CheckResponse response = await serviceControllerClient.CheckAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Report</summary>
        public void ReportRequestObject()
        {
            // Snippet: Report(ReportRequest, CallSettings)
            // Create client
            ServiceControllerClient serviceControllerClient = ServiceControllerClient.Create();
            // Initialize request argument(s)
            ReportRequest request = new ReportRequest
            {
                ServiceName = "",
                Operations = { new Operation(), },
                ServiceConfigId = "",
            };
            // Make the request
            ReportResponse response = serviceControllerClient.Report(request);
            // End snippet
        }

        /// <summary>Snippet for ReportAsync</summary>
        public async Task ReportRequestObjectAsync()
        {
            // Snippet: ReportAsync(ReportRequest, CallSettings)
            // Additional: ReportAsync(ReportRequest, CancellationToken)
            // Create client
            ServiceControllerClient serviceControllerClient = await ServiceControllerClient.CreateAsync();
            // Initialize request argument(s)
            ReportRequest request = new ReportRequest
            {
                ServiceName = "",
                Operations = { new Operation(), },
                ServiceConfigId = "",
            };
            // Make the request
            ReportResponse response = await serviceControllerClient.ReportAsync(request);
            // End snippet
        }
    }
}
