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

namespace Google.Cloud.Dlp.V2.Snippets
{
    using Google.Cloud.Dlp.V2;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDlpServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateJobTrigger</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateJobTriggerRequestObject()
        {
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            JobTrigger response = dlpServiceClient.UpdateJobTrigger(request);
        }
    }
}
