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
    // [START monitoring_v3_generated_SnoozeService_UpdateSnooze_sync]
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedSnoozeServiceClientSnippets
    {
        /// <summary>Snippet for UpdateSnooze</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateSnoozeRequestObject()
        {
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            UpdateSnoozeRequest request = new UpdateSnoozeRequest
            {
                Snooze = new Snooze(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snooze response = snoozeServiceClient.UpdateSnooze(request);
        }
    }
    // [END monitoring_v3_generated_SnoozeService_UpdateSnooze_sync]
}
