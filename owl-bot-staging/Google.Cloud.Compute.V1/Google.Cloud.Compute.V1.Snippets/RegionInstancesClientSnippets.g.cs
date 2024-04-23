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
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionInstancesClientSnippets
    {
        /// <summary>Snippet for BulkInsert</summary>
        public void BulkInsertRequestObject()
        {
            // Snippet: BulkInsert(BulkInsertRegionInstanceRequest, CallSettings)
            // Create client
            RegionInstancesClient regionInstancesClient = RegionInstancesClient.Create();
            // Initialize request argument(s)
            BulkInsertRegionInstanceRequest request = new BulkInsertRegionInstanceRequest
            {
                RequestId = "",
                BulkInsertInstanceResourceResource = new BulkInsertInstanceResource(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstancesClient.BulkInsert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstancesClient.PollOnceBulkInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsertAsync</summary>
        public async Task BulkInsertRequestObjectAsync()
        {
            // Snippet: BulkInsertAsync(BulkInsertRegionInstanceRequest, CallSettings)
            // Additional: BulkInsertAsync(BulkInsertRegionInstanceRequest, CancellationToken)
            // Create client
            RegionInstancesClient regionInstancesClient = await RegionInstancesClient.CreateAsync();
            // Initialize request argument(s)
            BulkInsertRegionInstanceRequest request = new BulkInsertRegionInstanceRequest
            {
                RequestId = "",
                BulkInsertInstanceResourceResource = new BulkInsertInstanceResource(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstancesClient.BulkInsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstancesClient.PollOnceBulkInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsert</summary>
        public void BulkInsert()
        {
            // Snippet: BulkInsert(string, string, BulkInsertInstanceResource, CallSettings)
            // Create client
            RegionInstancesClient regionInstancesClient = RegionInstancesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BulkInsertInstanceResource bulkInsertInstanceResourceResource = new BulkInsertInstanceResource();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstancesClient.BulkInsert(project, region, bulkInsertInstanceResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstancesClient.PollOnceBulkInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsertAsync</summary>
        public async Task BulkInsertAsync()
        {
            // Snippet: BulkInsertAsync(string, string, BulkInsertInstanceResource, CallSettings)
            // Additional: BulkInsertAsync(string, string, BulkInsertInstanceResource, CancellationToken)
            // Create client
            RegionInstancesClient regionInstancesClient = await RegionInstancesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BulkInsertInstanceResource bulkInsertInstanceResourceResource = new BulkInsertInstanceResource();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstancesClient.BulkInsertAsync(project, region, bulkInsertInstanceResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstancesClient.PollOnceBulkInsertAsync(operationName);
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
