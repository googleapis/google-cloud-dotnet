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

namespace Google.Cloud.CloudBuild.V1.Snippets
{
    // [START cloudbuild_v1_generated_CloudBuild_GetWorkerPool_sync_flattened_resourceNames]
    using Google.Cloud.CloudBuild.V1;

    public sealed partial class GeneratedCloudBuildClientSnippets
    {
        /// <summary>Snippet for GetWorkerPool</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetWorkerPoolResourceNames()
        {
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            WorkerPoolName name = WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]");
            // Make the request
            WorkerPool response = cloudBuildClient.GetWorkerPool(name);
        }
    }
    // [END cloudbuild_v1_generated_CloudBuild_GetWorkerPool_sync_flattened_resourceNames]
}
