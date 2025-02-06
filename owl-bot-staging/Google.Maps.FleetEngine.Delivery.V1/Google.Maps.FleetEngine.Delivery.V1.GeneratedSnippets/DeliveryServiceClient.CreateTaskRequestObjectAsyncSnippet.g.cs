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
    // [START fleetengine_v1_generated_DeliveryService_CreateTask_async]
    using System.Threading.Tasks;
    using gmfdv = Google.Maps.FleetEngine.Delivery.V1;

    public sealed partial class GeneratedDeliveryServiceClientSnippets
    {
        /// <summary>Snippet for CreateTaskAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateTaskRequestObjectAsync()
        {
            // Create client
            gmfdv::DeliveryServiceClient deliveryServiceClient = await gmfdv::DeliveryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gmfdv::CreateTaskRequest request = new gmfdv::CreateTaskRequest
            {
                Header = new gmfdv::DeliveryRequestHeader(),
                Parent = "",
                Task = new gmfdv::Task(),
                TaskId = "",
            };
            // Make the request
            gmfdv::Task response = await deliveryServiceClient.CreateTaskAsync(request);
        }
    }
    // [END fleetengine_v1_generated_DeliveryService_CreateTask_async]
}
