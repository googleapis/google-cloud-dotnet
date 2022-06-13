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

namespace Google.Cloud.OsConfig.V1Alpha.Snippets
{
    // [START osconfig_v1alpha_generated_OsConfigZonalService_GetInstanceOSPoliciesCompliance_async_flattened_resourceNames]
    using Google.Cloud.OsConfig.V1Alpha;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOsConfigZonalServiceClientSnippets
    {
        /// <summary>Snippet for GetInstanceOSPoliciesComplianceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetInstanceOSPoliciesComplianceResourceNamesAsync()
        {
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceOSPoliciesComplianceName name = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = await osConfigZonalServiceClient.GetInstanceOSPoliciesComplianceAsync(name);
#pragma warning restore CS0612
        }
    }
    // [END osconfig_v1alpha_generated_OsConfigZonalService_GetInstanceOSPoliciesCompliance_async_flattened_resourceNames]
}
