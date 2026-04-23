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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOnlineEvaluatorServiceClientSnippets
    {
        /// <summary>Snippet for CreateOnlineEvaluator</summary>
        public void CreateOnlineEvaluatorRequestObject()
        {
            // Snippet: CreateOnlineEvaluator(CreateOnlineEvaluatorRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            CreateOnlineEvaluatorRequest request = new CreateOnlineEvaluatorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OnlineEvaluator = new OnlineEvaluator(),
            };
            // Make the request
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.CreateOnlineEvaluator(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceCreateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineEvaluatorAsync</summary>
        public async Task CreateOnlineEvaluatorRequestObjectAsync()
        {
            // Snippet: CreateOnlineEvaluatorAsync(CreateOnlineEvaluatorRequest, CallSettings)
            // Additional: CreateOnlineEvaluatorAsync(CreateOnlineEvaluatorRequest, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOnlineEvaluatorRequest request = new CreateOnlineEvaluatorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OnlineEvaluator = new OnlineEvaluator(),
            };
            // Make the request
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.CreateOnlineEvaluatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceCreateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineEvaluator</summary>
        public void CreateOnlineEvaluator()
        {
            // Snippet: CreateOnlineEvaluator(string, OnlineEvaluator, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OnlineEvaluator onlineEvaluator = new OnlineEvaluator();
            // Make the request
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.CreateOnlineEvaluator(parent, onlineEvaluator);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceCreateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineEvaluatorAsync</summary>
        public async Task CreateOnlineEvaluatorAsync()
        {
            // Snippet: CreateOnlineEvaluatorAsync(string, OnlineEvaluator, CallSettings)
            // Additional: CreateOnlineEvaluatorAsync(string, OnlineEvaluator, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OnlineEvaluator onlineEvaluator = new OnlineEvaluator();
            // Make the request
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.CreateOnlineEvaluatorAsync(parent, onlineEvaluator);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceCreateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineEvaluator</summary>
        public void CreateOnlineEvaluatorResourceNames()
        {
            // Snippet: CreateOnlineEvaluator(LocationName, OnlineEvaluator, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OnlineEvaluator onlineEvaluator = new OnlineEvaluator();
            // Make the request
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.CreateOnlineEvaluator(parent, onlineEvaluator);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceCreateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineEvaluatorAsync</summary>
        public async Task CreateOnlineEvaluatorResourceNamesAsync()
        {
            // Snippet: CreateOnlineEvaluatorAsync(LocationName, OnlineEvaluator, CallSettings)
            // Additional: CreateOnlineEvaluatorAsync(LocationName, OnlineEvaluator, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OnlineEvaluator onlineEvaluator = new OnlineEvaluator();
            // Make the request
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.CreateOnlineEvaluatorAsync(parent, onlineEvaluator);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceCreateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetOnlineEvaluator</summary>
        public void GetOnlineEvaluatorRequestObject()
        {
            // Snippet: GetOnlineEvaluator(GetOnlineEvaluatorRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            GetOnlineEvaluatorRequest request = new GetOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            OnlineEvaluator response = onlineEvaluatorServiceClient.GetOnlineEvaluator(request);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineEvaluatorAsync</summary>
        public async Task GetOnlineEvaluatorRequestObjectAsync()
        {
            // Snippet: GetOnlineEvaluatorAsync(GetOnlineEvaluatorRequest, CallSettings)
            // Additional: GetOnlineEvaluatorAsync(GetOnlineEvaluatorRequest, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOnlineEvaluatorRequest request = new GetOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            OnlineEvaluator response = await onlineEvaluatorServiceClient.GetOnlineEvaluatorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineEvaluator</summary>
        public void GetOnlineEvaluator()
        {
            // Snippet: GetOnlineEvaluator(string, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            OnlineEvaluator response = onlineEvaluatorServiceClient.GetOnlineEvaluator(name);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineEvaluatorAsync</summary>
        public async Task GetOnlineEvaluatorAsync()
        {
            // Snippet: GetOnlineEvaluatorAsync(string, CallSettings)
            // Additional: GetOnlineEvaluatorAsync(string, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            OnlineEvaluator response = await onlineEvaluatorServiceClient.GetOnlineEvaluatorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineEvaluator</summary>
        public void GetOnlineEvaluatorResourceNames()
        {
            // Snippet: GetOnlineEvaluator(OnlineEvaluatorName, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            OnlineEvaluator response = onlineEvaluatorServiceClient.GetOnlineEvaluator(name);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineEvaluatorAsync</summary>
        public async Task GetOnlineEvaluatorResourceNamesAsync()
        {
            // Snippet: GetOnlineEvaluatorAsync(OnlineEvaluatorName, CallSettings)
            // Additional: GetOnlineEvaluatorAsync(OnlineEvaluatorName, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            OnlineEvaluator response = await onlineEvaluatorServiceClient.GetOnlineEvaluatorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineEvaluator</summary>
        public void UpdateOnlineEvaluatorRequestObject()
        {
            // Snippet: UpdateOnlineEvaluator(UpdateOnlineEvaluatorRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            UpdateOnlineEvaluatorRequest request = new UpdateOnlineEvaluatorRequest
            {
                OnlineEvaluator = new OnlineEvaluator(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.UpdateOnlineEvaluator(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceUpdateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineEvaluatorAsync</summary>
        public async Task UpdateOnlineEvaluatorRequestObjectAsync()
        {
            // Snippet: UpdateOnlineEvaluatorAsync(UpdateOnlineEvaluatorRequest, CallSettings)
            // Additional: UpdateOnlineEvaluatorAsync(UpdateOnlineEvaluatorRequest, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOnlineEvaluatorRequest request = new UpdateOnlineEvaluatorRequest
            {
                OnlineEvaluator = new OnlineEvaluator(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.UpdateOnlineEvaluatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceUpdateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineEvaluator</summary>
        public void UpdateOnlineEvaluator()
        {
            // Snippet: UpdateOnlineEvaluator(OnlineEvaluator, FieldMask, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            OnlineEvaluator onlineEvaluator = new OnlineEvaluator();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.UpdateOnlineEvaluator(onlineEvaluator, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceUpdateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineEvaluatorAsync</summary>
        public async Task UpdateOnlineEvaluatorAsync()
        {
            // Snippet: UpdateOnlineEvaluatorAsync(OnlineEvaluator, FieldMask, CallSettings)
            // Additional: UpdateOnlineEvaluatorAsync(OnlineEvaluator, FieldMask, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineEvaluator onlineEvaluator = new OnlineEvaluator();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.UpdateOnlineEvaluatorAsync(onlineEvaluator, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceUpdateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineEvaluator</summary>
        public void DeleteOnlineEvaluatorRequestObject()
        {
            // Snippet: DeleteOnlineEvaluator(DeleteOnlineEvaluatorRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            DeleteOnlineEvaluatorRequest request = new DeleteOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.DeleteOnlineEvaluator(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceDeleteOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineEvaluatorAsync</summary>
        public async Task DeleteOnlineEvaluatorRequestObjectAsync()
        {
            // Snippet: DeleteOnlineEvaluatorAsync(DeleteOnlineEvaluatorRequest, CallSettings)
            // Additional: DeleteOnlineEvaluatorAsync(DeleteOnlineEvaluatorRequest, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOnlineEvaluatorRequest request = new DeleteOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.DeleteOnlineEvaluatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceDeleteOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineEvaluator</summary>
        public void DeleteOnlineEvaluator()
        {
            // Snippet: DeleteOnlineEvaluator(string, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.DeleteOnlineEvaluator(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceDeleteOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineEvaluatorAsync</summary>
        public async Task DeleteOnlineEvaluatorAsync()
        {
            // Snippet: DeleteOnlineEvaluatorAsync(string, CallSettings)
            // Additional: DeleteOnlineEvaluatorAsync(string, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.DeleteOnlineEvaluatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceDeleteOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineEvaluator</summary>
        public void DeleteOnlineEvaluatorResourceNames()
        {
            // Snippet: DeleteOnlineEvaluator(OnlineEvaluatorName, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.DeleteOnlineEvaluator(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceDeleteOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineEvaluatorAsync</summary>
        public async Task DeleteOnlineEvaluatorResourceNamesAsync()
        {
            // Snippet: DeleteOnlineEvaluatorAsync(OnlineEvaluatorName, CallSettings)
            // Additional: DeleteOnlineEvaluatorAsync(OnlineEvaluatorName, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.DeleteOnlineEvaluatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceDeleteOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListOnlineEvaluators</summary>
        public void ListOnlineEvaluatorsRequestObject()
        {
            // Snippet: ListOnlineEvaluators(ListOnlineEvaluatorsRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            ListOnlineEvaluatorsRequest request = new ListOnlineEvaluatorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> response = onlineEvaluatorServiceClient.ListOnlineEvaluators(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OnlineEvaluator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOnlineEvaluatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineEvaluator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineEvaluator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineEvaluator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineEvaluatorsAsync</summary>
        public async Task ListOnlineEvaluatorsRequestObjectAsync()
        {
            // Snippet: ListOnlineEvaluatorsAsync(ListOnlineEvaluatorsRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOnlineEvaluatorsRequest request = new ListOnlineEvaluatorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> response = onlineEvaluatorServiceClient.ListOnlineEvaluatorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (OnlineEvaluator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOnlineEvaluatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineEvaluator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineEvaluator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineEvaluator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineEvaluators</summary>
        public void ListOnlineEvaluators()
        {
            // Snippet: ListOnlineEvaluators(string, string, int?, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> response = onlineEvaluatorServiceClient.ListOnlineEvaluators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OnlineEvaluator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOnlineEvaluatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineEvaluator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineEvaluator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineEvaluator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineEvaluatorsAsync</summary>
        public async Task ListOnlineEvaluatorsAsync()
        {
            // Snippet: ListOnlineEvaluatorsAsync(string, string, int?, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> response = onlineEvaluatorServiceClient.ListOnlineEvaluatorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (OnlineEvaluator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOnlineEvaluatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineEvaluator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineEvaluator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineEvaluator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineEvaluators</summary>
        public void ListOnlineEvaluatorsResourceNames()
        {
            // Snippet: ListOnlineEvaluators(LocationName, string, int?, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> response = onlineEvaluatorServiceClient.ListOnlineEvaluators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OnlineEvaluator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOnlineEvaluatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineEvaluator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineEvaluator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineEvaluator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineEvaluatorsAsync</summary>
        public async Task ListOnlineEvaluatorsResourceNamesAsync()
        {
            // Snippet: ListOnlineEvaluatorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> response = onlineEvaluatorServiceClient.ListOnlineEvaluatorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (OnlineEvaluator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOnlineEvaluatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineEvaluator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineEvaluator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineEvaluator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ActivateOnlineEvaluator</summary>
        public void ActivateOnlineEvaluatorRequestObject()
        {
            // Snippet: ActivateOnlineEvaluator(ActivateOnlineEvaluatorRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            ActivateOnlineEvaluatorRequest request = new ActivateOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.ActivateOnlineEvaluator(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceActivateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateOnlineEvaluatorAsync</summary>
        public async Task ActivateOnlineEvaluatorRequestObjectAsync()
        {
            // Snippet: ActivateOnlineEvaluatorAsync(ActivateOnlineEvaluatorRequest, CallSettings)
            // Additional: ActivateOnlineEvaluatorAsync(ActivateOnlineEvaluatorRequest, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ActivateOnlineEvaluatorRequest request = new ActivateOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.ActivateOnlineEvaluatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceActivateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateOnlineEvaluator</summary>
        public void ActivateOnlineEvaluator()
        {
            // Snippet: ActivateOnlineEvaluator(string, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.ActivateOnlineEvaluator(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceActivateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateOnlineEvaluatorAsync</summary>
        public async Task ActivateOnlineEvaluatorAsync()
        {
            // Snippet: ActivateOnlineEvaluatorAsync(string, CallSettings)
            // Additional: ActivateOnlineEvaluatorAsync(string, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.ActivateOnlineEvaluatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceActivateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateOnlineEvaluator</summary>
        public void ActivateOnlineEvaluatorResourceNames()
        {
            // Snippet: ActivateOnlineEvaluator(OnlineEvaluatorName, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.ActivateOnlineEvaluator(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceActivateOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateOnlineEvaluatorAsync</summary>
        public async Task ActivateOnlineEvaluatorResourceNamesAsync()
        {
            // Snippet: ActivateOnlineEvaluatorAsync(OnlineEvaluatorName, CallSettings)
            // Additional: ActivateOnlineEvaluatorAsync(OnlineEvaluatorName, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.ActivateOnlineEvaluatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceActivateOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendOnlineEvaluator</summary>
        public void SuspendOnlineEvaluatorRequestObject()
        {
            // Snippet: SuspendOnlineEvaluator(SuspendOnlineEvaluatorRequest, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            SuspendOnlineEvaluatorRequest request = new SuspendOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.SuspendOnlineEvaluator(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceSuspendOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendOnlineEvaluatorAsync</summary>
        public async Task SuspendOnlineEvaluatorRequestObjectAsync()
        {
            // Snippet: SuspendOnlineEvaluatorAsync(SuspendOnlineEvaluatorRequest, CallSettings)
            // Additional: SuspendOnlineEvaluatorAsync(SuspendOnlineEvaluatorRequest, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuspendOnlineEvaluatorRequest request = new SuspendOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]"),
            };
            // Make the request
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.SuspendOnlineEvaluatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceSuspendOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendOnlineEvaluator</summary>
        public void SuspendOnlineEvaluator()
        {
            // Snippet: SuspendOnlineEvaluator(string, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.SuspendOnlineEvaluator(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceSuspendOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendOnlineEvaluatorAsync</summary>
        public async Task SuspendOnlineEvaluatorAsync()
        {
            // Snippet: SuspendOnlineEvaluatorAsync(string, CallSettings)
            // Additional: SuspendOnlineEvaluatorAsync(string, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/onlineEvaluators/[ONLINE_EVALUATOR]";
            // Make the request
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.SuspendOnlineEvaluatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceSuspendOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendOnlineEvaluator</summary>
        public void SuspendOnlineEvaluatorResourceNames()
        {
            // Snippet: SuspendOnlineEvaluator(OnlineEvaluatorName, CallSettings)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = OnlineEvaluatorServiceClient.Create();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> response = onlineEvaluatorServiceClient.SuspendOnlineEvaluator(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> retrievedResponse = onlineEvaluatorServiceClient.PollOnceSuspendOnlineEvaluator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendOnlineEvaluatorAsync</summary>
        public async Task SuspendOnlineEvaluatorResourceNamesAsync()
        {
            // Snippet: SuspendOnlineEvaluatorAsync(OnlineEvaluatorName, CallSettings)
            // Additional: SuspendOnlineEvaluatorAsync(OnlineEvaluatorName, CancellationToken)
            // Create client
            OnlineEvaluatorServiceClient onlineEvaluatorServiceClient = await OnlineEvaluatorServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineEvaluatorName name = OnlineEvaluatorName.FromProjectLocationOnlineEvaluator("[PROJECT]", "[LOCATION]", "[ONLINE_EVALUATOR]");
            // Make the request
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> response = await onlineEvaluatorServiceClient.SuspendOnlineEvaluatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OnlineEvaluator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> retrievedResponse = await onlineEvaluatorServiceClient.PollOnceSuspendOnlineEvaluatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OnlineEvaluator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
