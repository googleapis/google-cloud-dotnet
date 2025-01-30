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
    // [START cloudtasks_v2beta3_generated_CloudTasks_CreateQueue_async]
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;
    using gctv = Google.Cloud.Tasks.V2Beta3;

    public sealed partial class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for CreateQueueAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateQueueRequestObjectAsync()
        {
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::CreateQueueRequest request = new gctv::CreateQueueRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new gctv::Queue(),
            };
            // Make the request
            gctv::Queue response = await cloudTasksClient.CreateQueueAsync(request);
        }
    }
    // [END cloudtasks_v2beta3_generated_CloudTasks_CreateQueue_async]
}
