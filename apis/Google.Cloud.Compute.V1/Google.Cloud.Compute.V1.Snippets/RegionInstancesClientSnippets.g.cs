// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRegionInstancesClientSnippets
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
            Operation response = regionInstancesClient.BulkInsert(request);
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
            Operation response = await regionInstancesClient.BulkInsertAsync(request);
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
            Operation response = regionInstancesClient.BulkInsert(project, region, bulkInsertInstanceResourceResource);
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
            Operation response = await regionInstancesClient.BulkInsertAsync(project, region, bulkInsertInstanceResourceResource);
            // End snippet
        }
    }
}
