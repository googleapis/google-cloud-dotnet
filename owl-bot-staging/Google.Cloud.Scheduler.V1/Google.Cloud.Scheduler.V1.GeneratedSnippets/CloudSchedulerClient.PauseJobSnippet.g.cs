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

namespace Google.Cloud.Scheduler.V1.Snippets
{
    // [START cloudscheduler_v1_generated_CloudScheduler_PauseJob_sync_flattened]
    using Google.Cloud.Scheduler.V1;

    public sealed partial class GeneratedCloudSchedulerClientSnippets
    {
        /// <summary>Snippet for PauseJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PauseJob()
        {
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = cloudSchedulerClient.PauseJob(name);
        }
    }
    // [END cloudscheduler_v1_generated_CloudScheduler_PauseJob_sync_flattened]
}
