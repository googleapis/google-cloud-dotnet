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
    public sealed class AllGeneratedProjectsClientSnippets
    {
        /// <summary>Snippet for DisableXpnHost</summary>
        public void DisableXpnHostRequestObject()
        {
            // Snippet: DisableXpnHost(DisableXpnHostProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            DisableXpnHostProjectRequest request = new DisableXpnHostProjectRequest
            {
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.DisableXpnHost(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceDisableXpnHost(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnHostAsync</summary>
        public async Task DisableXpnHostRequestObjectAsync()
        {
            // Snippet: DisableXpnHostAsync(DisableXpnHostProjectRequest, CallSettings)
            // Additional: DisableXpnHostAsync(DisableXpnHostProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            DisableXpnHostProjectRequest request = new DisableXpnHostProjectRequest
            {
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.DisableXpnHostAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceDisableXpnHostAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnHost</summary>
        public void DisableXpnHost()
        {
            // Snippet: DisableXpnHost(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.DisableXpnHost(project);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceDisableXpnHost(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnHostAsync</summary>
        public async Task DisableXpnHostAsync()
        {
            // Snippet: DisableXpnHostAsync(string, CallSettings)
            // Additional: DisableXpnHostAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.DisableXpnHostAsync(project);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceDisableXpnHostAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnResource</summary>
        public void DisableXpnResourceRequestObject()
        {
            // Snippet: DisableXpnResource(DisableXpnResourceProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            DisableXpnResourceProjectRequest request = new DisableXpnResourceProjectRequest
            {
                RequestId = "",
                ProjectsDisableXpnResourceRequestResource = new ProjectsDisableXpnResourceRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.DisableXpnResource(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceDisableXpnResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnResourceAsync</summary>
        public async Task DisableXpnResourceRequestObjectAsync()
        {
            // Snippet: DisableXpnResourceAsync(DisableXpnResourceProjectRequest, CallSettings)
            // Additional: DisableXpnResourceAsync(DisableXpnResourceProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            DisableXpnResourceProjectRequest request = new DisableXpnResourceProjectRequest
            {
                RequestId = "",
                ProjectsDisableXpnResourceRequestResource = new ProjectsDisableXpnResourceRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.DisableXpnResourceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceDisableXpnResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnResource</summary>
        public void DisableXpnResource()
        {
            // Snippet: DisableXpnResource(string, ProjectsDisableXpnResourceRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            ProjectsDisableXpnResourceRequest projectsDisableXpnResourceRequestResource = new ProjectsDisableXpnResourceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.DisableXpnResource(project, projectsDisableXpnResourceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceDisableXpnResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableXpnResourceAsync</summary>
        public async Task DisableXpnResourceAsync()
        {
            // Snippet: DisableXpnResourceAsync(string, ProjectsDisableXpnResourceRequest, CallSettings)
            // Additional: DisableXpnResourceAsync(string, ProjectsDisableXpnResourceRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ProjectsDisableXpnResourceRequest projectsDisableXpnResourceRequestResource = new ProjectsDisableXpnResourceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.DisableXpnResourceAsync(project, projectsDisableXpnResourceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceDisableXpnResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnHost</summary>
        public void EnableXpnHostRequestObject()
        {
            // Snippet: EnableXpnHost(EnableXpnHostProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            EnableXpnHostProjectRequest request = new EnableXpnHostProjectRequest
            {
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.EnableXpnHost(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceEnableXpnHost(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnHostAsync</summary>
        public async Task EnableXpnHostRequestObjectAsync()
        {
            // Snippet: EnableXpnHostAsync(EnableXpnHostProjectRequest, CallSettings)
            // Additional: EnableXpnHostAsync(EnableXpnHostProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            EnableXpnHostProjectRequest request = new EnableXpnHostProjectRequest
            {
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.EnableXpnHostAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceEnableXpnHostAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnHost</summary>
        public void EnableXpnHost()
        {
            // Snippet: EnableXpnHost(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.EnableXpnHost(project);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceEnableXpnHost(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnHostAsync</summary>
        public async Task EnableXpnHostAsync()
        {
            // Snippet: EnableXpnHostAsync(string, CallSettings)
            // Additional: EnableXpnHostAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.EnableXpnHostAsync(project);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceEnableXpnHostAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnResource</summary>
        public void EnableXpnResourceRequestObject()
        {
            // Snippet: EnableXpnResource(EnableXpnResourceProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            EnableXpnResourceProjectRequest request = new EnableXpnResourceProjectRequest
            {
                RequestId = "",
                Project = "",
                ProjectsEnableXpnResourceRequestResource = new ProjectsEnableXpnResourceRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.EnableXpnResource(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceEnableXpnResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnResourceAsync</summary>
        public async Task EnableXpnResourceRequestObjectAsync()
        {
            // Snippet: EnableXpnResourceAsync(EnableXpnResourceProjectRequest, CallSettings)
            // Additional: EnableXpnResourceAsync(EnableXpnResourceProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            EnableXpnResourceProjectRequest request = new EnableXpnResourceProjectRequest
            {
                RequestId = "",
                Project = "",
                ProjectsEnableXpnResourceRequestResource = new ProjectsEnableXpnResourceRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.EnableXpnResourceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceEnableXpnResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnResource</summary>
        public void EnableXpnResource()
        {
            // Snippet: EnableXpnResource(string, ProjectsEnableXpnResourceRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            ProjectsEnableXpnResourceRequest projectsEnableXpnResourceRequestResource = new ProjectsEnableXpnResourceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.EnableXpnResource(project, projectsEnableXpnResourceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceEnableXpnResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableXpnResourceAsync</summary>
        public async Task EnableXpnResourceAsync()
        {
            // Snippet: EnableXpnResourceAsync(string, ProjectsEnableXpnResourceRequest, CallSettings)
            // Additional: EnableXpnResourceAsync(string, ProjectsEnableXpnResourceRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ProjectsEnableXpnResourceRequest projectsEnableXpnResourceRequestResource = new ProjectsEnableXpnResourceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.EnableXpnResourceAsync(project, projectsEnableXpnResourceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceEnableXpnResourceAsync(operationName);
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
            // Snippet: Get(GetProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            GetProjectRequest request = new GetProjectRequest { Project = "", };
            // Make the request
            Project response = projectsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetProjectRequest, CallSettings)
            // Additional: GetAsync(GetProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            GetProjectRequest request = new GetProjectRequest { Project = "", };
            // Make the request
            Project response = await projectsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            Project response = projectsClient.Get(project);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            Project response = await projectsClient.GetAsync(project);
            // End snippet
        }

        /// <summary>Snippet for GetXpnHost</summary>
        public void GetXpnHostRequestObject()
        {
            // Snippet: GetXpnHost(GetXpnHostProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            GetXpnHostProjectRequest request = new GetXpnHostProjectRequest { Project = "", };
            // Make the request
            Project response = projectsClient.GetXpnHost(request);
            // End snippet
        }

        /// <summary>Snippet for GetXpnHostAsync</summary>
        public async Task GetXpnHostRequestObjectAsync()
        {
            // Snippet: GetXpnHostAsync(GetXpnHostProjectRequest, CallSettings)
            // Additional: GetXpnHostAsync(GetXpnHostProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            GetXpnHostProjectRequest request = new GetXpnHostProjectRequest { Project = "", };
            // Make the request
            Project response = await projectsClient.GetXpnHostAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetXpnHost</summary>
        public void GetXpnHost()
        {
            // Snippet: GetXpnHost(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            Project response = projectsClient.GetXpnHost(project);
            // End snippet
        }

        /// <summary>Snippet for GetXpnHostAsync</summary>
        public async Task GetXpnHostAsync()
        {
            // Snippet: GetXpnHostAsync(string, CallSettings)
            // Additional: GetXpnHostAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            Project response = await projectsClient.GetXpnHostAsync(project);
            // End snippet
        }

        /// <summary>Snippet for GetXpnResources</summary>
        public void GetXpnResourcesRequestObject()
        {
            // Snippet: GetXpnResources(GetXpnResourcesProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            GetXpnResourcesProjectsRequest request = new GetXpnResourcesProjectsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ProjectsGetXpnResources, XpnResourceId> response = projectsClient.GetXpnResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (XpnResourceId item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ProjectsGetXpnResources page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (XpnResourceId item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<XpnResourceId> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (XpnResourceId item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetXpnResourcesAsync</summary>
        public async Task GetXpnResourcesRequestObjectAsync()
        {
            // Snippet: GetXpnResourcesAsync(GetXpnResourcesProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            GetXpnResourcesProjectsRequest request = new GetXpnResourcesProjectsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ProjectsGetXpnResources, XpnResourceId> response = projectsClient.GetXpnResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((XpnResourceId item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ProjectsGetXpnResources page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (XpnResourceId item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<XpnResourceId> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (XpnResourceId item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetXpnResources</summary>
        public void GetXpnResources()
        {
            // Snippet: GetXpnResources(string, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ProjectsGetXpnResources, XpnResourceId> response = projectsClient.GetXpnResources(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (XpnResourceId item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ProjectsGetXpnResources page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (XpnResourceId item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<XpnResourceId> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (XpnResourceId item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetXpnResourcesAsync</summary>
        public async Task GetXpnResourcesAsync()
        {
            // Snippet: GetXpnResourcesAsync(string, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ProjectsGetXpnResources, XpnResourceId> response = projectsClient.GetXpnResourcesAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((XpnResourceId item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ProjectsGetXpnResources page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (XpnResourceId item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<XpnResourceId> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (XpnResourceId item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListXpnHosts</summary>
        public void ListXpnHostsRequestObject()
        {
            // Snippet: ListXpnHosts(ListXpnHostsProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            ListXpnHostsProjectsRequest request = new ListXpnHostsProjectsRequest
            {
                OrderBy = "",
                Project = "",
                ProjectsListXpnHostsRequestResource = new ProjectsListXpnHostsRequest(),
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<XpnHostList, Project> response = projectsClient.ListXpnHosts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (XpnHostList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Project item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Project> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Project item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListXpnHostsAsync</summary>
        public async Task ListXpnHostsRequestObjectAsync()
        {
            // Snippet: ListXpnHostsAsync(ListXpnHostsProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            ListXpnHostsProjectsRequest request = new ListXpnHostsProjectsRequest
            {
                OrderBy = "",
                Project = "",
                ProjectsListXpnHostsRequestResource = new ProjectsListXpnHostsRequest(),
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<XpnHostList, Project> response = projectsClient.ListXpnHostsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((XpnHostList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Project item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Project> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Project item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListXpnHosts</summary>
        public void ListXpnHosts()
        {
            // Snippet: ListXpnHosts(string, ProjectsListXpnHostsRequest, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            ProjectsListXpnHostsRequest projectsListXpnHostsRequestResource = new ProjectsListXpnHostsRequest();
            // Make the request
            PagedEnumerable<XpnHostList, Project> response = projectsClient.ListXpnHosts(project, projectsListXpnHostsRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (XpnHostList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Project item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Project> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Project item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListXpnHostsAsync</summary>
        public async Task ListXpnHostsAsync()
        {
            // Snippet: ListXpnHostsAsync(string, ProjectsListXpnHostsRequest, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ProjectsListXpnHostsRequest projectsListXpnHostsRequestResource = new ProjectsListXpnHostsRequest();
            // Make the request
            PagedAsyncEnumerable<XpnHostList, Project> response = projectsClient.ListXpnHostsAsync(project, projectsListXpnHostsRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((XpnHostList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Project item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Project> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Project item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for MoveDisk</summary>
        public void MoveDiskRequestObject()
        {
            // Snippet: MoveDisk(MoveDiskProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            MoveDiskProjectRequest request = new MoveDiskProjectRequest
            {
                RequestId = "",
                Project = "",
                DiskMoveRequestResource = new DiskMoveRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.MoveDisk(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceMoveDisk(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveDiskAsync</summary>
        public async Task MoveDiskRequestObjectAsync()
        {
            // Snippet: MoveDiskAsync(MoveDiskProjectRequest, CallSettings)
            // Additional: MoveDiskAsync(MoveDiskProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            MoveDiskProjectRequest request = new MoveDiskProjectRequest
            {
                RequestId = "",
                Project = "",
                DiskMoveRequestResource = new DiskMoveRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.MoveDiskAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceMoveDiskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveDisk</summary>
        public void MoveDisk()
        {
            // Snippet: MoveDisk(string, DiskMoveRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            DiskMoveRequest diskMoveRequestResource = new DiskMoveRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.MoveDisk(project, diskMoveRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceMoveDisk(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveDiskAsync</summary>
        public async Task MoveDiskAsync()
        {
            // Snippet: MoveDiskAsync(string, DiskMoveRequest, CallSettings)
            // Additional: MoveDiskAsync(string, DiskMoveRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            DiskMoveRequest diskMoveRequestResource = new DiskMoveRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.MoveDiskAsync(project, diskMoveRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceMoveDiskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveInstance</summary>
        public void MoveInstanceRequestObject()
        {
            // Snippet: MoveInstance(MoveInstanceProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            MoveInstanceProjectRequest request = new MoveInstanceProjectRequest
            {
                RequestId = "",
                Project = "",
                InstanceMoveRequestResource = new InstanceMoveRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.MoveInstance(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceMoveInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveInstanceAsync</summary>
        public async Task MoveInstanceRequestObjectAsync()
        {
            // Snippet: MoveInstanceAsync(MoveInstanceProjectRequest, CallSettings)
            // Additional: MoveInstanceAsync(MoveInstanceProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            MoveInstanceProjectRequest request = new MoveInstanceProjectRequest
            {
                RequestId = "",
                Project = "",
                InstanceMoveRequestResource = new InstanceMoveRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.MoveInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceMoveInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveInstance</summary>
        public void MoveInstance()
        {
            // Snippet: MoveInstance(string, InstanceMoveRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            InstanceMoveRequest instanceMoveRequestResource = new InstanceMoveRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.MoveInstance(project, instanceMoveRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceMoveInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveInstanceAsync</summary>
        public async Task MoveInstanceAsync()
        {
            // Snippet: MoveInstanceAsync(string, InstanceMoveRequest, CallSettings)
            // Additional: MoveInstanceAsync(string, InstanceMoveRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            InstanceMoveRequest instanceMoveRequestResource = new InstanceMoveRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.MoveInstanceAsync(project, instanceMoveRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceMoveInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCloudArmorTier</summary>
        public void SetCloudArmorTierRequestObject()
        {
            // Snippet: SetCloudArmorTier(SetCloudArmorTierProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            SetCloudArmorTierProjectRequest request = new SetCloudArmorTierProjectRequest
            {
                RequestId = "",
                ProjectsSetCloudArmorTierRequestResource = new ProjectsSetCloudArmorTierRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetCloudArmorTier(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetCloudArmorTier(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCloudArmorTierAsync</summary>
        public async Task SetCloudArmorTierRequestObjectAsync()
        {
            // Snippet: SetCloudArmorTierAsync(SetCloudArmorTierProjectRequest, CallSettings)
            // Additional: SetCloudArmorTierAsync(SetCloudArmorTierProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            SetCloudArmorTierProjectRequest request = new SetCloudArmorTierProjectRequest
            {
                RequestId = "",
                ProjectsSetCloudArmorTierRequestResource = new ProjectsSetCloudArmorTierRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetCloudArmorTierAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetCloudArmorTierAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCloudArmorTier</summary>
        public void SetCloudArmorTier()
        {
            // Snippet: SetCloudArmorTier(string, ProjectsSetCloudArmorTierRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            ProjectsSetCloudArmorTierRequest projectsSetCloudArmorTierRequestResource = new ProjectsSetCloudArmorTierRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetCloudArmorTier(project, projectsSetCloudArmorTierRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetCloudArmorTier(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCloudArmorTierAsync</summary>
        public async Task SetCloudArmorTierAsync()
        {
            // Snippet: SetCloudArmorTierAsync(string, ProjectsSetCloudArmorTierRequest, CallSettings)
            // Additional: SetCloudArmorTierAsync(string, ProjectsSetCloudArmorTierRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ProjectsSetCloudArmorTierRequest projectsSetCloudArmorTierRequestResource = new ProjectsSetCloudArmorTierRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetCloudArmorTierAsync(project, projectsSetCloudArmorTierRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetCloudArmorTierAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCommonInstanceMetadata</summary>
        public void SetCommonInstanceMetadataRequestObject()
        {
            // Snippet: SetCommonInstanceMetadata(SetCommonInstanceMetadataProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            SetCommonInstanceMetadataProjectRequest request = new SetCommonInstanceMetadataProjectRequest
            {
                RequestId = "",
                Project = "",
                MetadataResource = new Metadata(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetCommonInstanceMetadata(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetCommonInstanceMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCommonInstanceMetadataAsync</summary>
        public async Task SetCommonInstanceMetadataRequestObjectAsync()
        {
            // Snippet: SetCommonInstanceMetadataAsync(SetCommonInstanceMetadataProjectRequest, CallSettings)
            // Additional: SetCommonInstanceMetadataAsync(SetCommonInstanceMetadataProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            SetCommonInstanceMetadataProjectRequest request = new SetCommonInstanceMetadataProjectRequest
            {
                RequestId = "",
                Project = "",
                MetadataResource = new Metadata(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetCommonInstanceMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetCommonInstanceMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCommonInstanceMetadata</summary>
        public void SetCommonInstanceMetadata()
        {
            // Snippet: SetCommonInstanceMetadata(string, Metadata, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            Metadata metadataResource = new Metadata();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetCommonInstanceMetadata(project, metadataResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetCommonInstanceMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCommonInstanceMetadataAsync</summary>
        public async Task SetCommonInstanceMetadataAsync()
        {
            // Snippet: SetCommonInstanceMetadataAsync(string, Metadata, CallSettings)
            // Additional: SetCommonInstanceMetadataAsync(string, Metadata, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Metadata metadataResource = new Metadata();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetCommonInstanceMetadataAsync(project, metadataResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetCommonInstanceMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultNetworkTier</summary>
        public void SetDefaultNetworkTierRequestObject()
        {
            // Snippet: SetDefaultNetworkTier(SetDefaultNetworkTierProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            SetDefaultNetworkTierProjectRequest request = new SetDefaultNetworkTierProjectRequest
            {
                RequestId = "",
                ProjectsSetDefaultNetworkTierRequestResource = new ProjectsSetDefaultNetworkTierRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetDefaultNetworkTier(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetDefaultNetworkTier(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultNetworkTierAsync</summary>
        public async Task SetDefaultNetworkTierRequestObjectAsync()
        {
            // Snippet: SetDefaultNetworkTierAsync(SetDefaultNetworkTierProjectRequest, CallSettings)
            // Additional: SetDefaultNetworkTierAsync(SetDefaultNetworkTierProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            SetDefaultNetworkTierProjectRequest request = new SetDefaultNetworkTierProjectRequest
            {
                RequestId = "",
                ProjectsSetDefaultNetworkTierRequestResource = new ProjectsSetDefaultNetworkTierRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetDefaultNetworkTierAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetDefaultNetworkTierAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultNetworkTier</summary>
        public void SetDefaultNetworkTier()
        {
            // Snippet: SetDefaultNetworkTier(string, ProjectsSetDefaultNetworkTierRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            ProjectsSetDefaultNetworkTierRequest projectsSetDefaultNetworkTierRequestResource = new ProjectsSetDefaultNetworkTierRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetDefaultNetworkTier(project, projectsSetDefaultNetworkTierRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetDefaultNetworkTier(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultNetworkTierAsync</summary>
        public async Task SetDefaultNetworkTierAsync()
        {
            // Snippet: SetDefaultNetworkTierAsync(string, ProjectsSetDefaultNetworkTierRequest, CallSettings)
            // Additional: SetDefaultNetworkTierAsync(string, ProjectsSetDefaultNetworkTierRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ProjectsSetDefaultNetworkTierRequest projectsSetDefaultNetworkTierRequestResource = new ProjectsSetDefaultNetworkTierRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetDefaultNetworkTierAsync(project, projectsSetDefaultNetworkTierRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetDefaultNetworkTierAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUsageExportBucket</summary>
        public void SetUsageExportBucketRequestObject()
        {
            // Snippet: SetUsageExportBucket(SetUsageExportBucketProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            SetUsageExportBucketProjectRequest request = new SetUsageExportBucketProjectRequest
            {
                UsageExportLocationResource = new UsageExportLocation(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetUsageExportBucket(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetUsageExportBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUsageExportBucketAsync</summary>
        public async Task SetUsageExportBucketRequestObjectAsync()
        {
            // Snippet: SetUsageExportBucketAsync(SetUsageExportBucketProjectRequest, CallSettings)
            // Additional: SetUsageExportBucketAsync(SetUsageExportBucketProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            SetUsageExportBucketProjectRequest request = new SetUsageExportBucketProjectRequest
            {
                UsageExportLocationResource = new UsageExportLocation(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetUsageExportBucketAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetUsageExportBucketAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUsageExportBucket</summary>
        public void SetUsageExportBucket()
        {
            // Snippet: SetUsageExportBucket(string, UsageExportLocation, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string project = "";
            UsageExportLocation usageExportLocationResource = new UsageExportLocation();
            // Make the request
            lro::Operation<Operation, Operation> response = projectsClient.SetUsageExportBucket(project, usageExportLocationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = projectsClient.PollOnceSetUsageExportBucket(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUsageExportBucketAsync</summary>
        public async Task SetUsageExportBucketAsync()
        {
            // Snippet: SetUsageExportBucketAsync(string, UsageExportLocation, CallSettings)
            // Additional: SetUsageExportBucketAsync(string, UsageExportLocation, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            UsageExportLocation usageExportLocationResource = new UsageExportLocation();
            // Make the request
            lro::Operation<Operation, Operation> response = await projectsClient.SetUsageExportBucketAsync(project, usageExportLocationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await projectsClient.PollOnceSetUsageExportBucketAsync(operationName);
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
