// Copyright 2024 Google LLC
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
    using Google.Cloud.GkeConnect.Gateway.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGatewayControlClientSnippets
    {
        /// <summary>Snippet for GenerateCredentials</summary>
        public void GenerateCredentialsRequestObject()
        {
            // Snippet: GenerateCredentials(GenerateCredentialsRequest, CallSettings)
            // Create client
            GatewayControlClient gatewayControlClient = GatewayControlClient.Create();
            // Initialize request argument(s)
            GenerateCredentialsRequest request = new GenerateCredentialsRequest
            {
                Name = "",
                ForceUseAgent = false,
                Version = "",
                KubernetesNamespace = "",
                OperatingSystem = GenerateCredentialsRequest.Types.OperatingSystem.Unspecified,
            };
            // Make the request
            GenerateCredentialsResponse response = gatewayControlClient.GenerateCredentials(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateCredentialsAsync</summary>
        public async Task GenerateCredentialsRequestObjectAsync()
        {
            // Snippet: GenerateCredentialsAsync(GenerateCredentialsRequest, CallSettings)
            // Additional: GenerateCredentialsAsync(GenerateCredentialsRequest, CancellationToken)
            // Create client
            GatewayControlClient gatewayControlClient = await GatewayControlClient.CreateAsync();
            // Initialize request argument(s)
            GenerateCredentialsRequest request = new GenerateCredentialsRequest
            {
                Name = "",
                ForceUseAgent = false,
                Version = "",
                KubernetesNamespace = "",
                OperatingSystem = GenerateCredentialsRequest.Types.OperatingSystem.Unspecified,
            };
            // Make the request
            GenerateCredentialsResponse response = await gatewayControlClient.GenerateCredentialsAsync(request);
            // End snippet
        }
    }
}
