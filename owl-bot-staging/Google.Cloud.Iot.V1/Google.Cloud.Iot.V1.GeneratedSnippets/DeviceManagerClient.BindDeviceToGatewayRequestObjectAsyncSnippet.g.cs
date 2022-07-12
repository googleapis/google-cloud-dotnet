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

namespace Google.Cloud.Iot.V1.Snippets
{
    // [START cloudiot_v1_generated_DeviceManager_BindDeviceToGateway_async]
    using Google.Cloud.Iot.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDeviceManagerClientSnippets
    {
        /// <summary>Snippet for BindDeviceToGatewayAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task BindDeviceToGatewayRequestObjectAsync()
        {
            // Create client
            DeviceManagerClient deviceManagerClient = await DeviceManagerClient.CreateAsync();
            // Initialize request argument(s)
            BindDeviceToGatewayRequest request = new BindDeviceToGatewayRequest
            {
                ParentAsRegistryName = RegistryName.FromProjectLocationRegistry("[PROJECT]", "[LOCATION]", "[REGISTRY]"),
                GatewayId = "",
                DeviceId = "",
            };
            // Make the request
            BindDeviceToGatewayResponse response = await deviceManagerClient.BindDeviceToGatewayAsync(request);
        }
    }
    // [END cloudiot_v1_generated_DeviceManager_BindDeviceToGateway_async]
}
