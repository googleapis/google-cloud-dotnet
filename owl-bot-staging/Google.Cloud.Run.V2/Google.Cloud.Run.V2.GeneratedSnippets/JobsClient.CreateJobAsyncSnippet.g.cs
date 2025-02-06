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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START run_v2_generated_Jobs_CreateJob_async_flattened]
    using Google.LongRunning;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    public sealed partial class GeneratedJobsClientSnippets
    {
        /// <summary>Snippet for CreateJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateJobAsync()
        {
            // Create client
            gcrv::JobsClient jobsClient = await gcrv::JobsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Job job = new gcrv::Job();
            string jobId = "";
            // Make the request
            Operation<gcrv::Job, gcrv::Job> response = await jobsClient.CreateJobAsync(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Job, gcrv::Job> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Job, gcrv::Job> retrievedResponse = await jobsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Job retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END run_v2_generated_Jobs_CreateJob_async_flattened]
}
