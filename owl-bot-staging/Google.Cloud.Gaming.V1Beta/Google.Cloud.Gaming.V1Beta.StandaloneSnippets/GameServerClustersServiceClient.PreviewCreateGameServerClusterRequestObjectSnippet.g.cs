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
    using Google.Cloud.Gaming.V1Beta;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedGameServerClustersServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for PreviewCreateGameServerCluster</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PreviewCreateGameServerClusterRequestObject()
        {
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            PreviewCreateGameServerClusterRequest request = new PreviewCreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "",
                GameServerCluster = new GameServerCluster(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewCreateGameServerClusterResponse response = gameServerClustersServiceClient.PreviewCreateGameServerCluster(request);
        }
    }
}
