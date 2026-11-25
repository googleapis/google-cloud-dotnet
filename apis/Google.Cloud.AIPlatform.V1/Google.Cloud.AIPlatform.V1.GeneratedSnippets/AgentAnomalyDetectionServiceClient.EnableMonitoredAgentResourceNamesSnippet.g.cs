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
    // [START aiplatform_v1_generated_AgentAnomalyDetectionService_EnableMonitoredAgent_sync_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedAgentAnomalyDetectionServiceClientSnippets
    {
        /// <summary>Snippet for EnableMonitoredAgent</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void EnableMonitoredAgentResourceNames()
        {
            // Create client
            AgentAnomalyDetectionServiceClient agentAnomalyDetectionServiceClient = AgentAnomalyDetectionServiceClient.Create();
            // Initialize request argument(s)
            MonitoredAgentName name = MonitoredAgentName.FromProjectLocationMonitoredAgent("[PROJECT]", "[LOCATION]", "[MONITORED_AGENT]");
            // Make the request
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> response = agentAnomalyDetectionServiceClient.EnableMonitoredAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MonitoredAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> retrievedResponse = agentAnomalyDetectionServiceClient.PollOnceEnableMonitoredAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MonitoredAgent retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_AgentAnomalyDetectionService_EnableMonitoredAgent_sync_flattened_resourceNames]
}
