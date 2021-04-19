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
    public sealed class GeneratedRegionNotificationEndpointsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionNotificationEndpointRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            DeleteRegionNotificationEndpointRequest request = new DeleteRegionNotificationEndpointRequest
            {
                RequestId = "",
                NotificationEndpoint = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionNotificationEndpointsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionNotificationEndpointRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionNotificationEndpointRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionNotificationEndpointRequest request = new DeleteRegionNotificationEndpointRequest
            {
                RequestId = "",
                NotificationEndpoint = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionNotificationEndpointsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            Operation response = regionNotificationEndpointsClient.Delete(project, region, notificationEndpoint);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            Operation response = await regionNotificationEndpointsClient.DeleteAsync(project, region, notificationEndpoint);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionNotificationEndpointRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                NotificationEndpoint = "",
                Region = "",
                Project = "",
            };
            // Make the request
            NotificationEndpoint response = regionNotificationEndpointsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionNotificationEndpointRequest, CallSettings)
            // Additional: GetAsync(GetRegionNotificationEndpointRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                NotificationEndpoint = "",
                Region = "",
                Project = "",
            };
            // Make the request
            NotificationEndpoint response = await regionNotificationEndpointsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            NotificationEndpoint response = regionNotificationEndpointsClient.Get(project, region, notificationEndpoint);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string notificationEndpoint = "";
            // Make the request
            NotificationEndpoint response = await regionNotificationEndpointsClient.GetAsync(project, region, notificationEndpoint);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionNotificationEndpointRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            InsertRegionNotificationEndpointRequest request = new InsertRegionNotificationEndpointRequest
            {
                RequestId = "",
                NotificationEndpointResource = new NotificationEndpoint(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionNotificationEndpointsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionNotificationEndpointRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionNotificationEndpointRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionNotificationEndpointRequest request = new InsertRegionNotificationEndpointRequest
            {
                RequestId = "",
                NotificationEndpointResource = new NotificationEndpoint(),
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionNotificationEndpointsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, NotificationEndpoint, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NotificationEndpoint notificationEndpointResource = new NotificationEndpoint();
            // Make the request
            Operation response = regionNotificationEndpointsClient.Insert(project, region, notificationEndpointResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, NotificationEndpoint, CallSettings)
            // Additional: InsertAsync(string, string, NotificationEndpoint, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NotificationEndpoint notificationEndpointResource = new NotificationEndpoint();
            // Make the request
            Operation response = await regionNotificationEndpointsClient.InsertAsync(project, region, notificationEndpointResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionNotificationEndpointsRequest, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            ListRegionNotificationEndpointsRequest request = new ListRegionNotificationEndpointsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NotificationEndpointList response = regionNotificationEndpointsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionNotificationEndpointsRequest, CallSettings)
            // Additional: ListAsync(ListRegionNotificationEndpointsRequest, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionNotificationEndpointsRequest request = new ListRegionNotificationEndpointsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NotificationEndpointList response = await regionNotificationEndpointsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = RegionNotificationEndpointsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            NotificationEndpointList response = regionNotificationEndpointsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionNotificationEndpointsClient regionNotificationEndpointsClient = await RegionNotificationEndpointsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            NotificationEndpointList response = await regionNotificationEndpointsClient.ListAsync(project, region);
            // End snippet
        }
    }
}
