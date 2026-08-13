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
    using Google.Cloud.WorkloadIdentity.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWorkloadIdentityClientSnippets
    {
        /// <summary>Snippet for GenerateServiceAgents</summary>
        public void GenerateServiceAgentsRequestObject()
        {
            // Snippet: GenerateServiceAgents(GenerateServiceAgentsRequest, CallSettings)
            // Create client
            WorkloadIdentityClient workloadIdentityClient = WorkloadIdentityClient.Create();
            // Initialize request argument(s)
            GenerateServiceAgentsRequest request = new GenerateServiceAgentsRequest
            {
                ParentAsServiceProducerName = ServiceProducerName.FromProjectLocationServiceProducer("[PROJECT]", "[LOCATION]", "[SERVICE_PRODUCER]"),
            };
            // Make the request
            Operation<GenerateServiceAgentsResponse, OperationMetadata> response = workloadIdentityClient.GenerateServiceAgents(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateServiceAgentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateServiceAgentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateServiceAgentsResponse, OperationMetadata> retrievedResponse = workloadIdentityClient.PollOnceGenerateServiceAgents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateServiceAgentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceAgentsAsync</summary>
        public async Task GenerateServiceAgentsRequestObjectAsync()
        {
            // Snippet: GenerateServiceAgentsAsync(GenerateServiceAgentsRequest, CallSettings)
            // Additional: GenerateServiceAgentsAsync(GenerateServiceAgentsRequest, CancellationToken)
            // Create client
            WorkloadIdentityClient workloadIdentityClient = await WorkloadIdentityClient.CreateAsync();
            // Initialize request argument(s)
            GenerateServiceAgentsRequest request = new GenerateServiceAgentsRequest
            {
                ParentAsServiceProducerName = ServiceProducerName.FromProjectLocationServiceProducer("[PROJECT]", "[LOCATION]", "[SERVICE_PRODUCER]"),
            };
            // Make the request
            Operation<GenerateServiceAgentsResponse, OperationMetadata> response = await workloadIdentityClient.GenerateServiceAgentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateServiceAgentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateServiceAgentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateServiceAgentsResponse, OperationMetadata> retrievedResponse = await workloadIdentityClient.PollOnceGenerateServiceAgentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateServiceAgentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceAgents</summary>
        public void GenerateServiceAgents()
        {
            // Snippet: GenerateServiceAgents(string, CallSettings)
            // Create client
            WorkloadIdentityClient workloadIdentityClient = WorkloadIdentityClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/serviceProducers/[SERVICE_PRODUCER]";
            // Make the request
            Operation<GenerateServiceAgentsResponse, OperationMetadata> response = workloadIdentityClient.GenerateServiceAgents(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateServiceAgentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateServiceAgentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateServiceAgentsResponse, OperationMetadata> retrievedResponse = workloadIdentityClient.PollOnceGenerateServiceAgents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateServiceAgentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceAgentsAsync</summary>
        public async Task GenerateServiceAgentsAsync()
        {
            // Snippet: GenerateServiceAgentsAsync(string, CallSettings)
            // Additional: GenerateServiceAgentsAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityClient workloadIdentityClient = await WorkloadIdentityClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/serviceProducers/[SERVICE_PRODUCER]";
            // Make the request
            Operation<GenerateServiceAgentsResponse, OperationMetadata> response = await workloadIdentityClient.GenerateServiceAgentsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateServiceAgentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateServiceAgentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateServiceAgentsResponse, OperationMetadata> retrievedResponse = await workloadIdentityClient.PollOnceGenerateServiceAgentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateServiceAgentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceAgents</summary>
        public void GenerateServiceAgentsResourceNames()
        {
            // Snippet: GenerateServiceAgents(ServiceProducerName, CallSettings)
            // Create client
            WorkloadIdentityClient workloadIdentityClient = WorkloadIdentityClient.Create();
            // Initialize request argument(s)
            ServiceProducerName parent = ServiceProducerName.FromProjectLocationServiceProducer("[PROJECT]", "[LOCATION]", "[SERVICE_PRODUCER]");
            // Make the request
            Operation<GenerateServiceAgentsResponse, OperationMetadata> response = workloadIdentityClient.GenerateServiceAgents(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateServiceAgentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateServiceAgentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateServiceAgentsResponse, OperationMetadata> retrievedResponse = workloadIdentityClient.PollOnceGenerateServiceAgents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateServiceAgentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceAgentsAsync</summary>
        public async Task GenerateServiceAgentsResourceNamesAsync()
        {
            // Snippet: GenerateServiceAgentsAsync(ServiceProducerName, CallSettings)
            // Additional: GenerateServiceAgentsAsync(ServiceProducerName, CancellationToken)
            // Create client
            WorkloadIdentityClient workloadIdentityClient = await WorkloadIdentityClient.CreateAsync();
            // Initialize request argument(s)
            ServiceProducerName parent = ServiceProducerName.FromProjectLocationServiceProducer("[PROJECT]", "[LOCATION]", "[SERVICE_PRODUCER]");
            // Make the request
            Operation<GenerateServiceAgentsResponse, OperationMetadata> response = await workloadIdentityClient.GenerateServiceAgentsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateServiceAgentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateServiceAgentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateServiceAgentsResponse, OperationMetadata> retrievedResponse = await workloadIdentityClient.PollOnceGenerateServiceAgentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateServiceAgentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
