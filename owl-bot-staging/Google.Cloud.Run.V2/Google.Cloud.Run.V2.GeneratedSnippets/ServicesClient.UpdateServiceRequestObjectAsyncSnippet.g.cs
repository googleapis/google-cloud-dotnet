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
    // [START run_v2_generated_Services_UpdateService_async]
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    public sealed partial class GeneratedServicesClientSnippets
    {
        /// <summary>Snippet for UpdateServiceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateServiceRequestObjectAsync()
        {
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::UpdateServiceRequest request = new gcrv::UpdateServiceRequest
            {
                Service = new gcrv::Service(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.UpdateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END run_v2_generated_Services_UpdateService_async]
}
