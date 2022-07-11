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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    // [START dataproc_v1_generated_JobController_CancelJob_sync_flattened]
    using Google.Cloud.Dataproc.V1;

    public sealed partial class GeneratedJobControllerClientSnippets
    {
        /// <summary>Snippet for CancelJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CancelJob()
        {
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            Job response = jobControllerClient.CancelJob(projectId, region, jobId);
        }
    }
    // [END dataproc_v1_generated_JobController_CancelJob_sync_flattened]
}
