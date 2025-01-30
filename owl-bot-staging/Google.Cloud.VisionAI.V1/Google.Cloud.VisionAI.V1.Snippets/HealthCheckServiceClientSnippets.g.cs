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
    using Google.Cloud.VisionAI.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedHealthCheckServiceClientSnippets
    {
        /// <summary>Snippet for HealthCheck</summary>
        public void HealthCheckRequestObject()
        {
            // Snippet: HealthCheck(HealthCheckRequest, CallSettings)
            // Create client
            HealthCheckServiceClient healthCheckServiceClient = HealthCheckServiceClient.Create();
            // Initialize request argument(s)
            HealthCheckRequest request = new HealthCheckRequest
            {
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            HealthCheckResponse response = healthCheckServiceClient.HealthCheck(request);
            // End snippet
        }

        /// <summary>Snippet for HealthCheckAsync</summary>
        public async Task HealthCheckRequestObjectAsync()
        {
            // Snippet: HealthCheckAsync(HealthCheckRequest, CallSettings)
            // Additional: HealthCheckAsync(HealthCheckRequest, CancellationToken)
            // Create client
            HealthCheckServiceClient healthCheckServiceClient = await HealthCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            HealthCheckRequest request = new HealthCheckRequest
            {
                ClusterAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            HealthCheckResponse response = await healthCheckServiceClient.HealthCheckAsync(request);
            // End snippet
        }
    }
}
