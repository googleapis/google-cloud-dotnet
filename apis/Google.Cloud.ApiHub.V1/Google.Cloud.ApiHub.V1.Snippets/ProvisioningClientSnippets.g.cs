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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ApiHub.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProvisioningClientSnippets
    {
        /// <summary>Snippet for CreateApiHubInstance</summary>
        public void CreateApiHubInstanceRequestObject()
        {
            // Snippet: CreateApiHubInstance(CreateApiHubInstanceRequest, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            CreateApiHubInstanceRequest request = new CreateApiHubInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApiHubInstanceId = "",
                ApiHubInstance = new ApiHubInstance(),
            };
            // Make the request
            Operation<ApiHubInstance, OperationMetadata> response = provisioningClient.CreateApiHubInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<ApiHubInstance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiHubInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiHubInstance, OperationMetadata> retrievedResponse = provisioningClient.PollOnceCreateApiHubInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiHubInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiHubInstanceAsync</summary>
        public async Task CreateApiHubInstanceRequestObjectAsync()
        {
            // Snippet: CreateApiHubInstanceAsync(CreateApiHubInstanceRequest, CallSettings)
            // Additional: CreateApiHubInstanceAsync(CreateApiHubInstanceRequest, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            CreateApiHubInstanceRequest request = new CreateApiHubInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ApiHubInstanceId = "",
                ApiHubInstance = new ApiHubInstance(),
            };
            // Make the request
            Operation<ApiHubInstance, OperationMetadata> response = await provisioningClient.CreateApiHubInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ApiHubInstance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiHubInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiHubInstance, OperationMetadata> retrievedResponse = await provisioningClient.PollOnceCreateApiHubInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiHubInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiHubInstance</summary>
        public void CreateApiHubInstance()
        {
            // Snippet: CreateApiHubInstance(string, ApiHubInstance, string, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ApiHubInstance apiHubInstance = new ApiHubInstance();
            string apiHubInstanceId = "";
            // Make the request
            Operation<ApiHubInstance, OperationMetadata> response = provisioningClient.CreateApiHubInstance(parent, apiHubInstance, apiHubInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<ApiHubInstance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiHubInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiHubInstance, OperationMetadata> retrievedResponse = provisioningClient.PollOnceCreateApiHubInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiHubInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiHubInstanceAsync</summary>
        public async Task CreateApiHubInstanceAsync()
        {
            // Snippet: CreateApiHubInstanceAsync(string, ApiHubInstance, string, CallSettings)
            // Additional: CreateApiHubInstanceAsync(string, ApiHubInstance, string, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ApiHubInstance apiHubInstance = new ApiHubInstance();
            string apiHubInstanceId = "";
            // Make the request
            Operation<ApiHubInstance, OperationMetadata> response = await provisioningClient.CreateApiHubInstanceAsync(parent, apiHubInstance, apiHubInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<ApiHubInstance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiHubInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiHubInstance, OperationMetadata> retrievedResponse = await provisioningClient.PollOnceCreateApiHubInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiHubInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiHubInstance</summary>
        public void CreateApiHubInstanceResourceNames()
        {
            // Snippet: CreateApiHubInstance(LocationName, ApiHubInstance, string, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ApiHubInstance apiHubInstance = new ApiHubInstance();
            string apiHubInstanceId = "";
            // Make the request
            Operation<ApiHubInstance, OperationMetadata> response = provisioningClient.CreateApiHubInstance(parent, apiHubInstance, apiHubInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<ApiHubInstance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ApiHubInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiHubInstance, OperationMetadata> retrievedResponse = provisioningClient.PollOnceCreateApiHubInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiHubInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateApiHubInstanceAsync</summary>
        public async Task CreateApiHubInstanceResourceNamesAsync()
        {
            // Snippet: CreateApiHubInstanceAsync(LocationName, ApiHubInstance, string, CallSettings)
            // Additional: CreateApiHubInstanceAsync(LocationName, ApiHubInstance, string, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ApiHubInstance apiHubInstance = new ApiHubInstance();
            string apiHubInstanceId = "";
            // Make the request
            Operation<ApiHubInstance, OperationMetadata> response = await provisioningClient.CreateApiHubInstanceAsync(parent, apiHubInstance, apiHubInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<ApiHubInstance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiHubInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiHubInstance, OperationMetadata> retrievedResponse = await provisioningClient.PollOnceCreateApiHubInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiHubInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetApiHubInstance</summary>
        public void GetApiHubInstanceRequestObject()
        {
            // Snippet: GetApiHubInstance(GetApiHubInstanceRequest, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            GetApiHubInstanceRequest request = new GetApiHubInstanceRequest
            {
                ApiHubInstanceName = ApiHubInstanceName.FromProjectLocationApiHubInstance("[PROJECT]", "[LOCATION]", "[API_HUB_INSTANCE]"),
            };
            // Make the request
            ApiHubInstance response = provisioningClient.GetApiHubInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiHubInstanceAsync</summary>
        public async Task GetApiHubInstanceRequestObjectAsync()
        {
            // Snippet: GetApiHubInstanceAsync(GetApiHubInstanceRequest, CallSettings)
            // Additional: GetApiHubInstanceAsync(GetApiHubInstanceRequest, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            GetApiHubInstanceRequest request = new GetApiHubInstanceRequest
            {
                ApiHubInstanceName = ApiHubInstanceName.FromProjectLocationApiHubInstance("[PROJECT]", "[LOCATION]", "[API_HUB_INSTANCE]"),
            };
            // Make the request
            ApiHubInstance response = await provisioningClient.GetApiHubInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApiHubInstance</summary>
        public void GetApiHubInstance()
        {
            // Snippet: GetApiHubInstance(string, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apiHubInstances/[API_HUB_INSTANCE]";
            // Make the request
            ApiHubInstance response = provisioningClient.GetApiHubInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiHubInstanceAsync</summary>
        public async Task GetApiHubInstanceAsync()
        {
            // Snippet: GetApiHubInstanceAsync(string, CallSettings)
            // Additional: GetApiHubInstanceAsync(string, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apiHubInstances/[API_HUB_INSTANCE]";
            // Make the request
            ApiHubInstance response = await provisioningClient.GetApiHubInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiHubInstance</summary>
        public void GetApiHubInstanceResourceNames()
        {
            // Snippet: GetApiHubInstance(ApiHubInstanceName, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            ApiHubInstanceName name = ApiHubInstanceName.FromProjectLocationApiHubInstance("[PROJECT]", "[LOCATION]", "[API_HUB_INSTANCE]");
            // Make the request
            ApiHubInstance response = provisioningClient.GetApiHubInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetApiHubInstanceAsync</summary>
        public async Task GetApiHubInstanceResourceNamesAsync()
        {
            // Snippet: GetApiHubInstanceAsync(ApiHubInstanceName, CallSettings)
            // Additional: GetApiHubInstanceAsync(ApiHubInstanceName, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            ApiHubInstanceName name = ApiHubInstanceName.FromProjectLocationApiHubInstance("[PROJECT]", "[LOCATION]", "[API_HUB_INSTANCE]");
            // Make the request
            ApiHubInstance response = await provisioningClient.GetApiHubInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupApiHubInstance</summary>
        public void LookupApiHubInstanceRequestObject()
        {
            // Snippet: LookupApiHubInstance(LookupApiHubInstanceRequest, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            LookupApiHubInstanceRequest request = new LookupApiHubInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            LookupApiHubInstanceResponse response = provisioningClient.LookupApiHubInstance(request);
            // End snippet
        }

        /// <summary>Snippet for LookupApiHubInstanceAsync</summary>
        public async Task LookupApiHubInstanceRequestObjectAsync()
        {
            // Snippet: LookupApiHubInstanceAsync(LookupApiHubInstanceRequest, CallSettings)
            // Additional: LookupApiHubInstanceAsync(LookupApiHubInstanceRequest, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            LookupApiHubInstanceRequest request = new LookupApiHubInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            LookupApiHubInstanceResponse response = await provisioningClient.LookupApiHubInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupApiHubInstance</summary>
        public void LookupApiHubInstance()
        {
            // Snippet: LookupApiHubInstance(string, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            LookupApiHubInstanceResponse response = provisioningClient.LookupApiHubInstance(parent);
            // End snippet
        }

        /// <summary>Snippet for LookupApiHubInstanceAsync</summary>
        public async Task LookupApiHubInstanceAsync()
        {
            // Snippet: LookupApiHubInstanceAsync(string, CallSettings)
            // Additional: LookupApiHubInstanceAsync(string, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            LookupApiHubInstanceResponse response = await provisioningClient.LookupApiHubInstanceAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for LookupApiHubInstance</summary>
        public void LookupApiHubInstanceResourceNames()
        {
            // Snippet: LookupApiHubInstance(LocationName, CallSettings)
            // Create client
            ProvisioningClient provisioningClient = ProvisioningClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            LookupApiHubInstanceResponse response = provisioningClient.LookupApiHubInstance(parent);
            // End snippet
        }

        /// <summary>Snippet for LookupApiHubInstanceAsync</summary>
        public async Task LookupApiHubInstanceResourceNamesAsync()
        {
            // Snippet: LookupApiHubInstanceAsync(LocationName, CallSettings)
            // Additional: LookupApiHubInstanceAsync(LocationName, CancellationToken)
            // Create client
            ProvisioningClient provisioningClient = await ProvisioningClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            LookupApiHubInstanceResponse response = await provisioningClient.LookupApiHubInstanceAsync(parent);
            // End snippet
        }
    }
}
