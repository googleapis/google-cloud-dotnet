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

namespace Google.Cloud.Gaming.V1Beta.Snippets
{
    // [START gameservices_v1beta_generated_GameServerConfigsService_GetGameServerConfig_async]
    using Google.Cloud.Gaming.V1Beta;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGameServerConfigsServiceClientSnippets
    {
        /// <summary>Snippet for GetGameServerConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetGameServerConfigRequestObjectAsync()
        {
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            // Make the request
            GameServerConfig response = await gameServerConfigsServiceClient.GetGameServerConfigAsync(request);
        }
    }
    // [END gameservices_v1beta_generated_GameServerConfigsService_GetGameServerConfig_async]
}
