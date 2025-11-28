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
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCmekConfigServiceClientSnippets
    {
        /// <summary>Snippet for UpdateCmekConfig</summary>
        public void UpdateCmekConfigRequestObject()
        {
            // Snippet: UpdateCmekConfig(UpdateCmekConfigRequest, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateCmekConfigRequest request = new UpdateCmekConfigRequest
            {
                Config = new CmekConfig(),
                SetDefault = false,
            };
            // Make the request
            Operation<CmekConfig, UpdateCmekConfigMetadata> response = cmekConfigServiceClient.UpdateCmekConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<CmekConfig, UpdateCmekConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CmekConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CmekConfig, UpdateCmekConfigMetadata> retrievedResponse = cmekConfigServiceClient.PollOnceUpdateCmekConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CmekConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfigAsync</summary>
        public async Task UpdateCmekConfigRequestObjectAsync()
        {
            // Snippet: UpdateCmekConfigAsync(UpdateCmekConfigRequest, CallSettings)
            // Additional: UpdateCmekConfigAsync(UpdateCmekConfigRequest, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCmekConfigRequest request = new UpdateCmekConfigRequest
            {
                Config = new CmekConfig(),
                SetDefault = false,
            };
            // Make the request
            Operation<CmekConfig, UpdateCmekConfigMetadata> response = await cmekConfigServiceClient.UpdateCmekConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CmekConfig, UpdateCmekConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CmekConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CmekConfig, UpdateCmekConfigMetadata> retrievedResponse = await cmekConfigServiceClient.PollOnceUpdateCmekConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CmekConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfig</summary>
        public void UpdateCmekConfig()
        {
            // Snippet: UpdateCmekConfig(CmekConfig, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            CmekConfig config = new CmekConfig();
            // Make the request
            Operation<CmekConfig, UpdateCmekConfigMetadata> response = cmekConfigServiceClient.UpdateCmekConfig(config);

            // Poll until the returned long-running operation is complete
            Operation<CmekConfig, UpdateCmekConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CmekConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CmekConfig, UpdateCmekConfigMetadata> retrievedResponse = cmekConfigServiceClient.PollOnceUpdateCmekConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CmekConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekConfigAsync</summary>
        public async Task UpdateCmekConfigAsync()
        {
            // Snippet: UpdateCmekConfigAsync(CmekConfig, CallSettings)
            // Additional: UpdateCmekConfigAsync(CmekConfig, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmekConfig config = new CmekConfig();
            // Make the request
            Operation<CmekConfig, UpdateCmekConfigMetadata> response = await cmekConfigServiceClient.UpdateCmekConfigAsync(config);

            // Poll until the returned long-running operation is complete
            Operation<CmekConfig, UpdateCmekConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CmekConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CmekConfig, UpdateCmekConfigMetadata> retrievedResponse = await cmekConfigServiceClient.PollOnceUpdateCmekConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CmekConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfig</summary>
        public void GetCmekConfigRequestObject()
        {
            // Snippet: GetCmekConfig(GetCmekConfigRequest, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            GetCmekConfigRequest request = new GetCmekConfigRequest
            {
                CmekConfigName = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            CmekConfig response = cmekConfigServiceClient.GetCmekConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfigAsync</summary>
        public async Task GetCmekConfigRequestObjectAsync()
        {
            // Snippet: GetCmekConfigAsync(GetCmekConfigRequest, CallSettings)
            // Additional: GetCmekConfigAsync(GetCmekConfigRequest, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCmekConfigRequest request = new GetCmekConfigRequest
            {
                CmekConfigName = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            CmekConfig response = await cmekConfigServiceClient.GetCmekConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfig</summary>
        public void GetCmekConfig()
        {
            // Snippet: GetCmekConfig(string, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cmekConfig";
            // Make the request
            CmekConfig response = cmekConfigServiceClient.GetCmekConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfigAsync</summary>
        public async Task GetCmekConfigAsync()
        {
            // Snippet: GetCmekConfigAsync(string, CallSettings)
            // Additional: GetCmekConfigAsync(string, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cmekConfig";
            // Make the request
            CmekConfig response = await cmekConfigServiceClient.GetCmekConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfig</summary>
        public void GetCmekConfigResourceNames()
        {
            // Snippet: GetCmekConfig(CmekConfigName, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            CmekConfigName name = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            CmekConfig response = cmekConfigServiceClient.GetCmekConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekConfigAsync</summary>
        public async Task GetCmekConfigResourceNamesAsync()
        {
            // Snippet: GetCmekConfigAsync(CmekConfigName, CallSettings)
            // Additional: GetCmekConfigAsync(CmekConfigName, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmekConfigName name = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            CmekConfig response = await cmekConfigServiceClient.GetCmekConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCmekConfigs</summary>
        public void ListCmekConfigsRequestObject()
        {
            // Snippet: ListCmekConfigs(ListCmekConfigsRequest, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            ListCmekConfigsRequest request = new ListCmekConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListCmekConfigsResponse response = cmekConfigServiceClient.ListCmekConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for ListCmekConfigsAsync</summary>
        public async Task ListCmekConfigsRequestObjectAsync()
        {
            // Snippet: ListCmekConfigsAsync(ListCmekConfigsRequest, CallSettings)
            // Additional: ListCmekConfigsAsync(ListCmekConfigsRequest, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCmekConfigsRequest request = new ListCmekConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListCmekConfigsResponse response = await cmekConfigServiceClient.ListCmekConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListCmekConfigs</summary>
        public void ListCmekConfigs()
        {
            // Snippet: ListCmekConfigs(string, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListCmekConfigsResponse response = cmekConfigServiceClient.ListCmekConfigs(parent);
            // End snippet
        }

        /// <summary>Snippet for ListCmekConfigsAsync</summary>
        public async Task ListCmekConfigsAsync()
        {
            // Snippet: ListCmekConfigsAsync(string, CallSettings)
            // Additional: ListCmekConfigsAsync(string, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListCmekConfigsResponse response = await cmekConfigServiceClient.ListCmekConfigsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListCmekConfigs</summary>
        public void ListCmekConfigsResourceNames()
        {
            // Snippet: ListCmekConfigs(LocationName, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListCmekConfigsResponse response = cmekConfigServiceClient.ListCmekConfigs(parent);
            // End snippet
        }

        /// <summary>Snippet for ListCmekConfigsAsync</summary>
        public async Task ListCmekConfigsResourceNamesAsync()
        {
            // Snippet: ListCmekConfigsAsync(LocationName, CallSettings)
            // Additional: ListCmekConfigsAsync(LocationName, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListCmekConfigsResponse response = await cmekConfigServiceClient.ListCmekConfigsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteCmekConfig</summary>
        public void DeleteCmekConfigRequestObject()
        {
            // Snippet: DeleteCmekConfig(DeleteCmekConfigRequest, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            DeleteCmekConfigRequest request = new DeleteCmekConfigRequest
            {
                CmekConfigName = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<Empty, DeleteCmekConfigMetadata> response = cmekConfigServiceClient.DeleteCmekConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCmekConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCmekConfigMetadata> retrievedResponse = cmekConfigServiceClient.PollOnceDeleteCmekConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCmekConfigAsync</summary>
        public async Task DeleteCmekConfigRequestObjectAsync()
        {
            // Snippet: DeleteCmekConfigAsync(DeleteCmekConfigRequest, CallSettings)
            // Additional: DeleteCmekConfigAsync(DeleteCmekConfigRequest, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCmekConfigRequest request = new DeleteCmekConfigRequest
            {
                CmekConfigName = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Operation<Empty, DeleteCmekConfigMetadata> response = await cmekConfigServiceClient.DeleteCmekConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCmekConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCmekConfigMetadata> retrievedResponse = await cmekConfigServiceClient.PollOnceDeleteCmekConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCmekConfig</summary>
        public void DeleteCmekConfig()
        {
            // Snippet: DeleteCmekConfig(string, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cmekConfig";
            // Make the request
            Operation<Empty, DeleteCmekConfigMetadata> response = cmekConfigServiceClient.DeleteCmekConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCmekConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCmekConfigMetadata> retrievedResponse = cmekConfigServiceClient.PollOnceDeleteCmekConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCmekConfigAsync</summary>
        public async Task DeleteCmekConfigAsync()
        {
            // Snippet: DeleteCmekConfigAsync(string, CallSettings)
            // Additional: DeleteCmekConfigAsync(string, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cmekConfig";
            // Make the request
            Operation<Empty, DeleteCmekConfigMetadata> response = await cmekConfigServiceClient.DeleteCmekConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCmekConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCmekConfigMetadata> retrievedResponse = await cmekConfigServiceClient.PollOnceDeleteCmekConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCmekConfig</summary>
        public void DeleteCmekConfigResourceNames()
        {
            // Snippet: DeleteCmekConfig(CmekConfigName, CallSettings)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = CmekConfigServiceClient.Create();
            // Initialize request argument(s)
            CmekConfigName name = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<Empty, DeleteCmekConfigMetadata> response = cmekConfigServiceClient.DeleteCmekConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCmekConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCmekConfigMetadata> retrievedResponse = cmekConfigServiceClient.PollOnceDeleteCmekConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCmekConfigAsync</summary>
        public async Task DeleteCmekConfigResourceNamesAsync()
        {
            // Snippet: DeleteCmekConfigAsync(CmekConfigName, CallSettings)
            // Additional: DeleteCmekConfigAsync(CmekConfigName, CancellationToken)
            // Create client
            CmekConfigServiceClient cmekConfigServiceClient = await CmekConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmekConfigName name = CmekConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<Empty, DeleteCmekConfigMetadata> response = await cmekConfigServiceClient.DeleteCmekConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteCmekConfigMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteCmekConfigMetadata> retrievedResponse = await cmekConfigServiceClient.PollOnceDeleteCmekConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
