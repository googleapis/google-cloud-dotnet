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
    using Google.Cloud.AppEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApplicationsClientSnippets
    {
        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationRequestObject()
        {
            // Snippet: GetApplication(GetApplicationRequest, CallSettings)
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest { Name = "", };
            // Make the request
            Application response = applicationsClient.GetApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationRequestObjectAsync()
        {
            // Snippet: GetApplicationAsync(GetApplicationRequest, CallSettings)
            // Additional: GetApplicationAsync(GetApplicationRequest, CancellationToken)
            // Create client
            ApplicationsClient applicationsClient = await ApplicationsClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest { Name = "", };
            // Make the request
            Application response = await applicationsClient.GetApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplication()
        {
            // Snippet: GetApplication(string, CallSettings)
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Application response = applicationsClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationAsync()
        {
            // Snippet: GetApplicationAsync(string, CallSettings)
            // Additional: GetApplicationAsync(string, CancellationToken)
            // Create client
            ApplicationsClient applicationsClient = await ApplicationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Application response = await applicationsClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationRequestObject()
        {
            // Snippet: CreateApplication(CreateApplicationRequest, CallSettings)
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                Application = new Application(),
            };
            // Make the request
            Operation<Application, OperationMetadataV1> response = applicationsClient.CreateApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = applicationsClient.PollOnceCreateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationRequestObjectAsync()
        {
            // Snippet: CreateApplicationAsync(CreateApplicationRequest, CallSettings)
            // Additional: CreateApplicationAsync(CreateApplicationRequest, CancellationToken)
            // Create client
            ApplicationsClient applicationsClient = await ApplicationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                Application = new Application(),
            };
            // Make the request
            Operation<Application, OperationMetadataV1> response = await applicationsClient.CreateApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = await applicationsClient.PollOnceCreateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplicationRequestObject()
        {
            // Snippet: UpdateApplication(UpdateApplicationRequest, CallSettings)
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Name = "",
                Application = new Application(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Application, OperationMetadataV1> response = applicationsClient.UpdateApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = applicationsClient.PollOnceUpdateApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationRequestObjectAsync()
        {
            // Snippet: UpdateApplicationAsync(UpdateApplicationRequest, CallSettings)
            // Additional: UpdateApplicationAsync(UpdateApplicationRequest, CancellationToken)
            // Create client
            ApplicationsClient applicationsClient = await ApplicationsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Name = "",
                Application = new Application(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Application, OperationMetadataV1> response = await applicationsClient.UpdateApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = await applicationsClient.PollOnceUpdateApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairApplication</summary>
        public void RepairApplicationRequestObject()
        {
            // Snippet: RepairApplication(RepairApplicationRequest, CallSettings)
            // Create client
            ApplicationsClient applicationsClient = ApplicationsClient.Create();
            // Initialize request argument(s)
            RepairApplicationRequest request = new RepairApplicationRequest { Name = "", };
            // Make the request
            Operation<Application, OperationMetadataV1> response = applicationsClient.RepairApplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = applicationsClient.PollOnceRepairApplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RepairApplicationAsync</summary>
        public async Task RepairApplicationRequestObjectAsync()
        {
            // Snippet: RepairApplicationAsync(RepairApplicationRequest, CallSettings)
            // Additional: RepairApplicationAsync(RepairApplicationRequest, CancellationToken)
            // Create client
            ApplicationsClient applicationsClient = await ApplicationsClient.CreateAsync();
            // Initialize request argument(s)
            RepairApplicationRequest request = new RepairApplicationRequest { Name = "", };
            // Make the request
            Operation<Application, OperationMetadataV1> response = await applicationsClient.RepairApplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Application, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Application result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Application, OperationMetadataV1> retrievedResponse = await applicationsClient.PollOnceRepairApplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Application retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
