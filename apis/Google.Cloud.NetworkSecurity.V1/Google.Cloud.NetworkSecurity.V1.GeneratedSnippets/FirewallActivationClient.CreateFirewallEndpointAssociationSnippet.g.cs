// Copyright 2026 Google LLC
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
    // [START networksecurity_v1_generated_FirewallActivation_CreateFirewallEndpointAssociation_sync_flattened]
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedFirewallActivationClientSnippets
    {
        /// <summary>Snippet for CreateFirewallEndpointAssociation</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateFirewallEndpointAssociation()
        {
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            string firewallEndpointAssociationId = "";
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpointAssociation(parent, firewallEndpointAssociation, firewallEndpointAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networksecurity_v1_generated_FirewallActivation_CreateFirewallEndpointAssociation_sync_flattened]
}
