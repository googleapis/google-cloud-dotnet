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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionInstanceGroupManagersClientSnippets
    {
        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstancesRequestObject()
        {
            // Snippet: AbandonInstances(AbandonInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.AbandonInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceAbandonInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesRequestObjectAsync()
        {
            // Snippet: AbandonInstancesAsync(AbandonInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: AbandonInstancesAsync(AbandonInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            AbandonInstancesRegionInstanceGroupManagerRequest request = new AbandonInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.AbandonInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceAbandonInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonInstances</summary>
        public void AbandonInstances()
        {
            // Snippet: AbandonInstances(string, string, string, RegionInstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersAbandonInstancesRequest regionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.AbandonInstances(project, region, instanceGroupManager, regionInstanceGroupManagersAbandonInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceAbandonInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonInstancesAsync</summary>
        public async Task AbandonInstancesAsync()
        {
            // Snippet: AbandonInstancesAsync(string, string, string, RegionInstanceGroupManagersAbandonInstancesRequest, CallSettings)
            // Additional: AbandonInstancesAsync(string, string, string, RegionInstanceGroupManagersAbandonInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersAbandonInstancesRequest regionInstanceGroupManagersAbandonInstancesRequestResource = new RegionInstanceGroupManagersAbandonInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.AbandonInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersAbandonInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceAbandonInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstancesRequestObject()
        {
            // Snippet: ApplyUpdatesToInstances(ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.ApplyUpdatesToInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceApplyUpdatesToInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesRequestObjectAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest request = new ApplyUpdatesToInstancesRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.ApplyUpdatesToInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceApplyUpdatesToInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstances</summary>
        public void ApplyUpdatesToInstances()
        {
            // Snippet: ApplyUpdatesToInstances(string, string, string, RegionInstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersApplyUpdatesRequest regionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.ApplyUpdatesToInstances(project, region, instanceGroupManager, regionInstanceGroupManagersApplyUpdatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceApplyUpdatesToInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyUpdatesToInstancesAsync</summary>
        public async Task ApplyUpdatesToInstancesAsync()
        {
            // Snippet: ApplyUpdatesToInstancesAsync(string, string, string, RegionInstanceGroupManagersApplyUpdatesRequest, CallSettings)
            // Additional: ApplyUpdatesToInstancesAsync(string, string, string, RegionInstanceGroupManagersApplyUpdatesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersApplyUpdatesRequest regionInstanceGroupManagersApplyUpdatesRequestResource = new RegionInstanceGroupManagersApplyUpdatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.ApplyUpdatesToInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersApplyUpdatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceApplyUpdatesToInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstancesRequestObject()
        {
            // Snippet: CreateInstances(CreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.CreateInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceCreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesRequestObjectAsync()
        {
            // Snippet: CreateInstancesAsync(CreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: CreateInstancesAsync(CreateInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstancesRegionInstanceGroupManagerRequest request = new CreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.CreateInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceCreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstances</summary>
        public void CreateInstances()
        {
            // Snippet: CreateInstances(string, string, string, RegionInstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersCreateInstancesRequest regionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.CreateInstances(project, region, instanceGroupManager, regionInstanceGroupManagersCreateInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceCreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstancesAsync</summary>
        public async Task CreateInstancesAsync()
        {
            // Snippet: CreateInstancesAsync(string, string, string, RegionInstanceGroupManagersCreateInstancesRequest, CallSettings)
            // Additional: CreateInstancesAsync(string, string, string, RegionInstanceGroupManagersCreateInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersCreateInstancesRequest regionInstanceGroupManagersCreateInstancesRequestResource = new RegionInstanceGroupManagersCreateInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.CreateInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersCreateInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceCreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionInstanceGroupManagerRequest request = new DeleteRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Delete(project, region, instanceGroupManager);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.DeleteAsync(project, region, instanceGroupManager);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstancesRequestObject()
        {
            // Snippet: DeleteInstances(DeleteInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.DeleteInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceDeleteInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesRequestObjectAsync()
        {
            // Snippet: DeleteInstancesAsync(DeleteInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: DeleteInstancesAsync(DeleteInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstancesRegionInstanceGroupManagerRequest request = new DeleteInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.DeleteInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceDeleteInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstances</summary>
        public void DeleteInstances()
        {
            // Snippet: DeleteInstances(string, string, string, RegionInstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersDeleteInstancesRequest regionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.DeleteInstances(project, region, instanceGroupManager, regionInstanceGroupManagersDeleteInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceDeleteInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstancesAsync</summary>
        public async Task DeleteInstancesAsync()
        {
            // Snippet: DeleteInstancesAsync(string, string, string, RegionInstanceGroupManagersDeleteInstancesRequest, CallSettings)
            // Additional: DeleteInstancesAsync(string, string, string, RegionInstanceGroupManagersDeleteInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersDeleteInstancesRequest regionInstanceGroupManagersDeleteInstancesRequestResource = new RegionInstanceGroupManagersDeleteInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.DeleteInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersDeleteInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceDeleteInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigsRequestObject()
        {
            // Snippet: DeletePerInstanceConfigs(DeletePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.DeletePerInstanceConfigs(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceDeletePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(DeletePerInstanceConfigsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            DeletePerInstanceConfigsRegionInstanceGroupManagerRequest request = new DeletePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RegionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.DeletePerInstanceConfigsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceDeletePerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigs</summary>
        public void DeletePerInstanceConfigs()
        {
            // Snippet: DeletePerInstanceConfigs(string, string, string, RegionInstanceGroupManagerDeleteInstanceConfigReq, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerDeleteInstanceConfigReq regionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.DeletePerInstanceConfigs(project, region, instanceGroupManager, regionInstanceGroupManagerDeleteInstanceConfigReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceDeletePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePerInstanceConfigsAsync</summary>
        public async Task DeletePerInstanceConfigsAsync()
        {
            // Snippet: DeletePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerDeleteInstanceConfigReq, CallSettings)
            // Additional: DeletePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerDeleteInstanceConfigReq, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerDeleteInstanceConfigReq regionInstanceGroupManagerDeleteInstanceConfigReqResource = new RegionInstanceGroupManagerDeleteInstanceConfigReq();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.DeletePerInstanceConfigsAsync(project, region, instanceGroupManager, regionInstanceGroupManagerDeleteInstanceConfigReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceDeletePerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = regionInstanceGroupManagersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstanceGroupManagerRequest request = new GetRegionInstanceGroupManagerRequest
            {
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManager response = await regionInstanceGroupManagersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = regionInstanceGroupManagersClient.Get(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            InstanceGroupManager response = await regionInstanceGroupManagersClient.GetAsync(project, region, instanceGroupManager);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionInstanceGroupManagerRequest request = new InsertRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, InstanceGroupManager, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Insert(project, region, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, InstanceGroupManager, CallSettings)
            // Additional: InsertAsync(string, string, InstanceGroupManager, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.InsertAsync(project, region, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagerList, InstanceGroupManager> response = regionInstanceGroupManagersClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroupManager item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstanceGroupManagersRequest request = new ListRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagerList, InstanceGroupManager> response = regionInstanceGroupManagersClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroupManager item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagerList, InstanceGroupManager> response = regionInstanceGroupManagersClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroupManager item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagerList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagerList, InstanceGroupManager> response = regionInstanceGroupManagersClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroupManager item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagerList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManager item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManager> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManager item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrorsRequestObject()
        {
            // Snippet: ListErrors(ListErrorsRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = regionInstanceGroupManagersClient.ListErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceManagedByIgmError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagersListErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsRequestObjectAsync()
        {
            // Snippet: ListErrorsAsync(ListErrorsRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListErrorsRegionInstanceGroupManagersRequest request = new ListErrorsRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = regionInstanceGroupManagersClient.ListErrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceManagedByIgmError item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagersListErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrors</summary>
        public void ListErrors()
        {
            // Snippet: ListErrors(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = regionInstanceGroupManagersClient.ListErrors(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceManagedByIgmError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagersListErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListErrorsAsync</summary>
        public async Task ListErrorsAsync()
        {
            // Snippet: ListErrorsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = regionInstanceGroupManagersClient.ListErrorsAsync(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceManagedByIgmError item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagersListErrorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstancesRequestObject()
        {
            // Snippet: ListManagedInstances(ListManagedInstancesRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagersListInstancesResponse, ManagedInstance> response = regionInstanceGroupManagersClient.ListManagedInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagersListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesRequestObjectAsync()
        {
            // Snippet: ListManagedInstancesAsync(ListManagedInstancesRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListManagedInstancesRegionInstanceGroupManagersRequest request = new ListManagedInstancesRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagersListInstancesResponse, ManagedInstance> response = regionInstanceGroupManagersClient.ListManagedInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagersListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstances</summary>
        public void ListManagedInstances()
        {
            // Snippet: ListManagedInstances(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagersListInstancesResponse, ManagedInstance> response = regionInstanceGroupManagersClient.ListManagedInstances(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagersListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagedInstancesAsync</summary>
        public async Task ListManagedInstancesAsync()
        {
            // Snippet: ListManagedInstancesAsync(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagersListInstancesResponse, ManagedInstance> response = regionInstanceGroupManagersClient.ListManagedInstancesAsync(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedInstance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagersListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigsRequestObject()
        {
            // Snippet: ListPerInstanceConfigs(ListPerInstanceConfigsRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagersListInstanceConfigsResp, PerInstanceConfig> response = regionInstanceGroupManagersClient.ListPerInstanceConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PerInstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagersListInstanceConfigsResp page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(ListPerInstanceConfigsRegionInstanceGroupManagersRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ListPerInstanceConfigsRegionInstanceGroupManagersRequest request = new ListPerInstanceConfigsRegionInstanceGroupManagersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagersListInstanceConfigsResp, PerInstanceConfig> response = regionInstanceGroupManagersClient.ListPerInstanceConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PerInstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagersListInstanceConfigsResp page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigs</summary>
        public void ListPerInstanceConfigs()
        {
            // Snippet: ListPerInstanceConfigs(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagersListInstanceConfigsResp, PerInstanceConfig> response = regionInstanceGroupManagersClient.ListPerInstanceConfigs(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PerInstanceConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagersListInstanceConfigsResp page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPerInstanceConfigsAsync</summary>
        public async Task ListPerInstanceConfigsAsync()
        {
            // Snippet: ListPerInstanceConfigsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagersListInstanceConfigsResp, PerInstanceConfig> response = regionInstanceGroupManagersClient.ListPerInstanceConfigsAsync(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PerInstanceConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionInstanceGroupManagersListInstanceConfigsResp page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PerInstanceConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PerInstanceConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PerInstanceConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionInstanceGroupManagerRequest request = new PatchRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResource = new InstanceGroupManager(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, InstanceGroupManager, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Patch(project, region, instanceGroupManager, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, InstanceGroupManager, CallSettings)
            // Additional: PatchAsync(string, string, string, InstanceGroupManager, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            InstanceGroupManager instanceGroupManagerResource = new InstanceGroupManager();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.PatchAsync(project, region, instanceGroupManager, instanceGroupManagerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigsRequestObject()
        {
            // Snippet: PatchPerInstanceConfigs(PatchPerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.PatchPerInstanceConfigs(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOncePatchPerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(PatchPerInstanceConfigsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            PatchPerInstanceConfigsRegionInstanceGroupManagerRequest request = new PatchPerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.PatchPerInstanceConfigsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOncePatchPerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigs</summary>
        public void PatchPerInstanceConfigs()
        {
            // Snippet: PatchPerInstanceConfigs(string, string, string, RegionInstanceGroupManagerPatchInstanceConfigReq, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerPatchInstanceConfigReq regionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.PatchPerInstanceConfigs(project, region, instanceGroupManager, regionInstanceGroupManagerPatchInstanceConfigReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOncePatchPerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPerInstanceConfigsAsync</summary>
        public async Task PatchPerInstanceConfigsAsync()
        {
            // Snippet: PatchPerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerPatchInstanceConfigReq, CallSettings)
            // Additional: PatchPerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerPatchInstanceConfigReq, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerPatchInstanceConfigReq regionInstanceGroupManagerPatchInstanceConfigReqResource = new RegionInstanceGroupManagerPatchInstanceConfigReq();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.PatchPerInstanceConfigsAsync(project, region, instanceGroupManager, regionInstanceGroupManagerPatchInstanceConfigReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOncePatchPerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstancesRequestObject()
        {
            // Snippet: RecreateInstances(RecreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.RecreateInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceRecreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesRequestObjectAsync()
        {
            // Snippet: RecreateInstancesAsync(RecreateInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: RecreateInstancesAsync(RecreateInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            RecreateInstancesRegionInstanceGroupManagerRequest request = new RecreateInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.RecreateInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceRecreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstances</summary>
        public void RecreateInstances()
        {
            // Snippet: RecreateInstances(string, string, string, RegionInstanceGroupManagersRecreateRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersRecreateRequest regionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.RecreateInstances(project, region, instanceGroupManager, regionInstanceGroupManagersRecreateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceRecreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecreateInstancesAsync</summary>
        public async Task RecreateInstancesAsync()
        {
            // Snippet: RecreateInstancesAsync(string, string, string, RegionInstanceGroupManagersRecreateRequest, CallSettings)
            // Additional: RecreateInstancesAsync(string, string, string, RegionInstanceGroupManagersRecreateRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersRecreateRequest regionInstanceGroupManagersRecreateRequestResource = new RegionInstanceGroupManagersRecreateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.RecreateInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersRecreateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceRecreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = 0,
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Resize(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: ResizeAsync(ResizeRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ResizeRegionInstanceGroupManagerRequest request = new ResizeRegionInstanceGroupManagerRequest
            {
                Size = 0,
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.ResizeAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, int, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.Resize(project, region, instanceGroupManager, size);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, int, CallSettings)
            // Additional: ResizeAsync(string, string, string, int, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            int size = 0;
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.ResizeAsync(project, region, instanceGroupManager, size);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstances</summary>
        public void ResumeInstancesRequestObject()
        {
            // Snippet: ResumeInstances(ResumeInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ResumeInstancesRegionInstanceGroupManagerRequest request = new ResumeInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersResumeInstancesRequestResource = new RegionInstanceGroupManagersResumeInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.ResumeInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceResumeInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstancesAsync</summary>
        public async Task ResumeInstancesRequestObjectAsync()
        {
            // Snippet: ResumeInstancesAsync(ResumeInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: ResumeInstancesAsync(ResumeInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            ResumeInstancesRegionInstanceGroupManagerRequest request = new ResumeInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersResumeInstancesRequestResource = new RegionInstanceGroupManagersResumeInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.ResumeInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceResumeInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstances</summary>
        public void ResumeInstances()
        {
            // Snippet: ResumeInstances(string, string, string, RegionInstanceGroupManagersResumeInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersResumeInstancesRequest regionInstanceGroupManagersResumeInstancesRequestResource = new RegionInstanceGroupManagersResumeInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.ResumeInstances(project, region, instanceGroupManager, regionInstanceGroupManagersResumeInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceResumeInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeInstancesAsync</summary>
        public async Task ResumeInstancesAsync()
        {
            // Snippet: ResumeInstancesAsync(string, string, string, RegionInstanceGroupManagersResumeInstancesRequest, CallSettings)
            // Additional: ResumeInstancesAsync(string, string, string, RegionInstanceGroupManagersResumeInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersResumeInstancesRequest regionInstanceGroupManagersResumeInstancesRequestResource = new RegionInstanceGroupManagersResumeInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.ResumeInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersResumeInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceResumeInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplateRequestObject()
        {
            // Snippet: SetInstanceTemplate(SetInstanceTemplateRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.SetInstanceTemplate(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceSetInstanceTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateRequestObjectAsync()
        {
            // Snippet: SetInstanceTemplateAsync(SetInstanceTemplateRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(SetInstanceTemplateRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceTemplateRegionInstanceGroupManagerRequest request = new SetInstanceTemplateRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.SetInstanceTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceSetInstanceTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplate</summary>
        public void SetInstanceTemplate()
        {
            // Snippet: SetInstanceTemplate(string, string, string, RegionInstanceGroupManagersSetTemplateRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTemplateRequest regionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.SetInstanceTemplate(project, region, instanceGroupManager, regionInstanceGroupManagersSetTemplateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceSetInstanceTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceTemplateAsync</summary>
        public async Task SetInstanceTemplateAsync()
        {
            // Snippet: SetInstanceTemplateAsync(string, string, string, RegionInstanceGroupManagersSetTemplateRequest, CallSettings)
            // Additional: SetInstanceTemplateAsync(string, string, string, RegionInstanceGroupManagersSetTemplateRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTemplateRequest regionInstanceGroupManagersSetTemplateRequestResource = new RegionInstanceGroupManagersSetTemplateRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.SetInstanceTemplateAsync(project, region, instanceGroupManager, regionInstanceGroupManagersSetTemplateRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceSetInstanceTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPoolsRequestObject()
        {
            // Snippet: SetTargetPools(SetTargetPoolsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.SetTargetPools(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceSetTargetPools(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsRequestObjectAsync()
        {
            // Snippet: SetTargetPoolsAsync(SetTargetPoolsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(SetTargetPoolsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetPoolsRegionInstanceGroupManagerRequest request = new SetTargetPoolsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.SetTargetPoolsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceSetTargetPoolsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPools</summary>
        public void SetTargetPools()
        {
            // Snippet: SetTargetPools(string, string, string, RegionInstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTargetPoolsRequest regionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.SetTargetPools(project, region, instanceGroupManager, regionInstanceGroupManagersSetTargetPoolsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceSetTargetPools(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetTargetPoolsAsync</summary>
        public async Task SetTargetPoolsAsync()
        {
            // Snippet: SetTargetPoolsAsync(string, string, string, RegionInstanceGroupManagersSetTargetPoolsRequest, CallSettings)
            // Additional: SetTargetPoolsAsync(string, string, string, RegionInstanceGroupManagersSetTargetPoolsRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSetTargetPoolsRequest regionInstanceGroupManagersSetTargetPoolsRequestResource = new RegionInstanceGroupManagersSetTargetPoolsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.SetTargetPoolsAsync(project, region, instanceGroupManager, regionInstanceGroupManagersSetTargetPoolsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceSetTargetPoolsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstances</summary>
        public void StartInstancesRequestObject()
        {
            // Snippet: StartInstances(StartInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            StartInstancesRegionInstanceGroupManagerRequest request = new StartInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersStartInstancesRequestResource = new RegionInstanceGroupManagersStartInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.StartInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceStartInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstancesAsync</summary>
        public async Task StartInstancesRequestObjectAsync()
        {
            // Snippet: StartInstancesAsync(StartInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: StartInstancesAsync(StartInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            StartInstancesRegionInstanceGroupManagerRequest request = new StartInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersStartInstancesRequestResource = new RegionInstanceGroupManagersStartInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.StartInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceStartInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstances</summary>
        public void StartInstances()
        {
            // Snippet: StartInstances(string, string, string, RegionInstanceGroupManagersStartInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersStartInstancesRequest regionInstanceGroupManagersStartInstancesRequestResource = new RegionInstanceGroupManagersStartInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.StartInstances(project, region, instanceGroupManager, regionInstanceGroupManagersStartInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceStartInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstancesAsync</summary>
        public async Task StartInstancesAsync()
        {
            // Snippet: StartInstancesAsync(string, string, string, RegionInstanceGroupManagersStartInstancesRequest, CallSettings)
            // Additional: StartInstancesAsync(string, string, string, RegionInstanceGroupManagersStartInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersStartInstancesRequest regionInstanceGroupManagersStartInstancesRequestResource = new RegionInstanceGroupManagersStartInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.StartInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersStartInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceStartInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstances</summary>
        public void StopInstancesRequestObject()
        {
            // Snippet: StopInstances(StopInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            StopInstancesRegionInstanceGroupManagerRequest request = new StopInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersStopInstancesRequestResource = new RegionInstanceGroupManagersStopInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.StopInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceStopInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstancesAsync</summary>
        public async Task StopInstancesRequestObjectAsync()
        {
            // Snippet: StopInstancesAsync(StopInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: StopInstancesAsync(StopInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            StopInstancesRegionInstanceGroupManagerRequest request = new StopInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                RegionInstanceGroupManagersStopInstancesRequestResource = new RegionInstanceGroupManagersStopInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.StopInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceStopInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstances</summary>
        public void StopInstances()
        {
            // Snippet: StopInstances(string, string, string, RegionInstanceGroupManagersStopInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersStopInstancesRequest regionInstanceGroupManagersStopInstancesRequestResource = new RegionInstanceGroupManagersStopInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.StopInstances(project, region, instanceGroupManager, regionInstanceGroupManagersStopInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceStopInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstancesAsync</summary>
        public async Task StopInstancesAsync()
        {
            // Snippet: StopInstancesAsync(string, string, string, RegionInstanceGroupManagersStopInstancesRequest, CallSettings)
            // Additional: StopInstancesAsync(string, string, string, RegionInstanceGroupManagersStopInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersStopInstancesRequest regionInstanceGroupManagersStopInstancesRequestResource = new RegionInstanceGroupManagersStopInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.StopInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersStopInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceStopInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstances</summary>
        public void SuspendInstancesRequestObject()
        {
            // Snippet: SuspendInstances(SuspendInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            SuspendInstancesRegionInstanceGroupManagerRequest request = new SuspendInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersSuspendInstancesRequestResource = new RegionInstanceGroupManagersSuspendInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.SuspendInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceSuspendInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstancesAsync</summary>
        public async Task SuspendInstancesRequestObjectAsync()
        {
            // Snippet: SuspendInstancesAsync(SuspendInstancesRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: SuspendInstancesAsync(SuspendInstancesRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            SuspendInstancesRegionInstanceGroupManagerRequest request = new SuspendInstancesRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                Region = "",
                RegionInstanceGroupManagersSuspendInstancesRequestResource = new RegionInstanceGroupManagersSuspendInstancesRequest(),
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.SuspendInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceSuspendInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstances</summary>
        public void SuspendInstances()
        {
            // Snippet: SuspendInstances(string, string, string, RegionInstanceGroupManagersSuspendInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSuspendInstancesRequest regionInstanceGroupManagersSuspendInstancesRequestResource = new RegionInstanceGroupManagersSuspendInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.SuspendInstances(project, region, instanceGroupManager, regionInstanceGroupManagersSuspendInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceSuspendInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SuspendInstancesAsync</summary>
        public async Task SuspendInstancesAsync()
        {
            // Snippet: SuspendInstancesAsync(string, string, string, RegionInstanceGroupManagersSuspendInstancesRequest, CallSettings)
            // Additional: SuspendInstancesAsync(string, string, string, RegionInstanceGroupManagersSuspendInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagersSuspendInstancesRequest regionInstanceGroupManagersSuspendInstancesRequestResource = new RegionInstanceGroupManagersSuspendInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.SuspendInstancesAsync(project, region, instanceGroupManager, regionInstanceGroupManagersSuspendInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceSuspendInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigsRequestObject()
        {
            // Snippet: UpdatePerInstanceConfigs(UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.UpdatePerInstanceConfigs(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceUpdatePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsRequestObjectAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest request = new UpdatePerInstanceConfigsRegionInstanceGroupManagerRequest
            {
                RequestId = "",
                RegionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq(),
                Region = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.UpdatePerInstanceConfigsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceUpdatePerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigs</summary>
        public void UpdatePerInstanceConfigs()
        {
            // Snippet: UpdatePerInstanceConfigs(string, string, string, RegionInstanceGroupManagerUpdateInstanceConfigReq, CallSettings)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = RegionInstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerUpdateInstanceConfigReq regionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagersClient.UpdatePerInstanceConfigs(project, region, instanceGroupManager, regionInstanceGroupManagerUpdateInstanceConfigReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagersClient.PollOnceUpdatePerInstanceConfigs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePerInstanceConfigsAsync</summary>
        public async Task UpdatePerInstanceConfigsAsync()
        {
            // Snippet: UpdatePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerUpdateInstanceConfigReq, CallSettings)
            // Additional: UpdatePerInstanceConfigsAsync(string, string, string, RegionInstanceGroupManagerUpdateInstanceConfigReq, CancellationToken)
            // Create client
            RegionInstanceGroupManagersClient regionInstanceGroupManagersClient = await RegionInstanceGroupManagersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            RegionInstanceGroupManagerUpdateInstanceConfigReq regionInstanceGroupManagerUpdateInstanceConfigReqResource = new RegionInstanceGroupManagerUpdateInstanceConfigReq();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagersClient.UpdatePerInstanceConfigsAsync(project, region, instanceGroupManager, regionInstanceGroupManagerUpdateInstanceConfigReqResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagersClient.PollOnceUpdatePerInstanceConfigsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
