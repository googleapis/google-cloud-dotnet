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

namespace Google.Cloud.GSuiteAddOns.V1.Snippets
{
    // [START gsuiteaddons_v1_generated_GSuiteAddOns_InstallDeployment_sync]
    using Google.Cloud.GSuiteAddOns.V1;

    public sealed partial class GeneratedGSuiteAddOnsClientSnippets
    {
        /// <summary>Snippet for InstallDeployment</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void InstallDeploymentRequestObject()
        {
            // Create client
            GSuiteAddOnsClient gSuiteAddOnsClient = GSuiteAddOnsClient.Create();
            // Initialize request argument(s)
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            // Make the request
            gSuiteAddOnsClient.InstallDeployment(request);
        }
    }
    // [END gsuiteaddons_v1_generated_GSuiteAddOns_InstallDeployment_sync]
}
