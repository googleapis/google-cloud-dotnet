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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    // [START monitoring_v3_generated_AlertPolicyService_UpdateAlertPolicy_sync_flattened]
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedAlertPolicyServiceClientSnippets
    {
        /// <summary>Snippet for UpdateAlertPolicy</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateAlertPolicy()
        {
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.UpdateAlertPolicy(updateMask, alertPolicy);
        }
    }
    // [END monitoring_v3_generated_AlertPolicyService_UpdateAlertPolicy_sync_flattened]
}
