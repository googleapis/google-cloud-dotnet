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

namespace Google.Cloud.ServiceControl.V1.Snippets
{
    // [START servicecontrol_v1_generated_ServiceController_Report_sync]
    using Google.Cloud.ServiceControl.V1;

    public sealed partial class GeneratedServiceControllerClientSnippets
    {
        /// <summary>Snippet for Report</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ReportRequestObject()
        {
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
        }
    }
    // [END servicecontrol_v1_generated_ServiceController_Report_sync]
}
