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

namespace Google.Cloud.Gaming.V1.Snippets
{
    // [START gameservices_v1_generated_GameServerDeploymentsService_PreviewGameServerDeploymentRollout_async]
    using Google.Cloud.Gaming.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGameServerDeploymentsServiceClientSnippets
    {
        /// <summary>Snippet for PreviewGameServerDeploymentRolloutAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task PreviewGameServerDeploymentRolloutRequestObjectAsync()
        {
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewGameServerDeploymentRolloutRequest request = new PreviewGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewGameServerDeploymentRolloutResponse response = await gameServerDeploymentsServiceClient.PreviewGameServerDeploymentRolloutAsync(request);
        }
    }
    // [END gameservices_v1_generated_GameServerDeploymentsService_PreviewGameServerDeploymentRollout_async]
}
