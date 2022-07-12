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

namespace Google.Cloud.GkeConnect.Gateway.V1Beta1.Snippets
{
    // [START connectgateway_v1beta1_generated_GatewayService_GetResource_sync]
    using Google.Api;
    using Google.Cloud.GkeConnect.Gateway.V1Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedGatewayServiceClientSnippets
    {
        /// <summary>Snippet for GetResource</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetResourceRequestObject()
        {
            // Create client
            GatewayServiceClient gatewayServiceClient = GatewayServiceClient.Create();
            // Initialize request argument(s)
            HttpBody request = new HttpBody
            {
                ContentType = "",
                Data = ByteString.Empty,
                Extensions = { new Any(), },
            };
            // Make the request
            HttpBody response = gatewayServiceClient.GetResource(request);
        }
    }
    // [END connectgateway_v1beta1_generated_GatewayService_GetResource_sync]
}
