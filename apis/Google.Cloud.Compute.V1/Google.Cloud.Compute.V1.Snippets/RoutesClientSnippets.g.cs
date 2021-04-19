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
    public sealed class GeneratedRoutesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRouteRequest, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            DeleteRouteRequest request = new DeleteRouteRequest
            {
                RequestId = "",
                Route = "",
                Project = "",
            };
            // Make the request
            Operation response = routesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRouteRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRouteRequest, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRouteRequest request = new DeleteRouteRequest
            {
                RequestId = "",
                Route = "",
                Project = "",
            };
            // Make the request
            Operation response = await routesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string route = "";
            // Make the request
            Operation response = routesClient.Delete(project, route);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string route = "";
            // Make the request
            Operation response = await routesClient.DeleteAsync(project, route);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRouteRequest, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            GetRouteRequest request = new GetRouteRequest
            {
                Route = "",
                Project = "",
            };
            // Make the request
            Route response = routesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRouteRequest, CallSettings)
            // Additional: GetAsync(GetRouteRequest, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            GetRouteRequest request = new GetRouteRequest
            {
                Route = "",
                Project = "",
            };
            // Make the request
            Route response = await routesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string route = "";
            // Make the request
            Route response = routesClient.Get(project, route);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string route = "";
            // Make the request
            Route response = await routesClient.GetAsync(project, route);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRouteRequest, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            InsertRouteRequest request = new InsertRouteRequest
            {
                RequestId = "",
                RouteResource = new Route(),
                Project = "",
            };
            // Make the request
            Operation response = routesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRouteRequest, CallSettings)
            // Additional: InsertAsync(InsertRouteRequest, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRouteRequest request = new InsertRouteRequest
            {
                RequestId = "",
                RouteResource = new Route(),
                Project = "",
            };
            // Make the request
            Operation response = await routesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, Route, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            string project = "";
            Route routeResource = new Route();
            // Make the request
            Operation response = routesClient.Insert(project, routeResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, Route, CallSettings)
            // Additional: InsertAsync(string, Route, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Route routeResource = new Route();
            // Make the request
            Operation response = await routesClient.InsertAsync(project, routeResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRoutesRequest, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            ListRoutesRequest request = new ListRoutesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RouteList response = routesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRoutesRequest, CallSettings)
            // Additional: ListAsync(ListRoutesRequest, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            ListRoutesRequest request = new ListRoutesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RouteList response = await routesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            RouteList response = routesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            RouteList response = await routesClient.ListAsync(project);
            // End snippet
        }
    }
}
