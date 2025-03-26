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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServingConfigServiceClientSnippets
    {
        /// <summary>Snippet for UpdateServingConfig</summary>
        public void UpdateServingConfigRequestObject()
        {
            // Snippet: UpdateServingConfig(UpdateServingConfigRequest, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServingConfig response = servingConfigServiceClient.UpdateServingConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfigAsync</summary>
        public async Task UpdateServingConfigRequestObjectAsync()
        {
            // Snippet: UpdateServingConfigAsync(UpdateServingConfigRequest, CallSettings)
            // Additional: UpdateServingConfigAsync(UpdateServingConfigRequest, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServingConfigRequest request = new UpdateServingConfigRequest
            {
                ServingConfig = new ServingConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServingConfig response = await servingConfigServiceClient.UpdateServingConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfig</summary>
        public void UpdateServingConfig()
        {
            // Snippet: UpdateServingConfig(ServingConfig, FieldMask, CallSettings)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = ServingConfigServiceClient.Create();
            // Initialize request argument(s)
            ServingConfig servingConfig = new ServingConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ServingConfig response = servingConfigServiceClient.UpdateServingConfig(servingConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateServingConfigAsync</summary>
        public async Task UpdateServingConfigAsync()
        {
            // Snippet: UpdateServingConfigAsync(ServingConfig, FieldMask, CallSettings)
            // Additional: UpdateServingConfigAsync(ServingConfig, FieldMask, CancellationToken)
            // Create client
            ServingConfigServiceClient servingConfigServiceClient = await ServingConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServingConfig servingConfig = new ServingConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ServingConfig response = await servingConfigServiceClient.UpdateServingConfigAsync(servingConfig, updateMask);
            // End snippet
        }
    }
}
