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
    // [START logging_v2_generated_ConfigServiceV2_CreateBucketLongRunning_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Logging.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedConfigServiceV2ClientSnippets
    {
        /// <summary>Snippet for CreateBucketLongRunningAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateBucketLongRunningRequestObjectAsync()
        {
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BucketId = "",
                Bucket = new LogBucket(),
            };
            // Make the request
            Operation<LogBucket, BucketMetadata> response = await configServiceV2Client.CreateBucketLongRunningAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<LogBucket, BucketMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            LogBucket result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<LogBucket, BucketMetadata> retrievedResponse = await configServiceV2Client.PollOnceCreateBucketLongRunningAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                LogBucket retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END logging_v2_generated_ConfigServiceV2_CreateBucketLongRunning_async]
}
