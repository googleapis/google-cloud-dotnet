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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Cloud.ResourceManager.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProjectsClientSnippets
    {
        /// <summary>Snippet for GetProject</summary>
        public void GetProjectRequestObject()
        {
            // Snippet: GetProject(GetProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            GetProjectRequest request = new GetProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Project response = projectsClient.GetProject(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectAsync</summary>
        public async Task GetProjectRequestObjectAsync()
        {
            // Snippet: GetProjectAsync(GetProjectRequest, CallSettings)
            // Additional: GetProjectAsync(GetProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            GetProjectRequest request = new GetProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Project response = await projectsClient.GetProjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProject</summary>
        public void GetProject()
        {
            // Snippet: GetProject(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Project response = projectsClient.GetProject(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectAsync</summary>
        public async Task GetProjectAsync()
        {
            // Snippet: GetProjectAsync(string, CallSettings)
            // Additional: GetProjectAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Project response = await projectsClient.GetProjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProject</summary>
        public void GetProjectResourceNames()
        {
            // Snippet: GetProject(ProjectName, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Project response = projectsClient.GetProject(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectAsync</summary>
        public async Task GetProjectResourceNamesAsync()
        {
            // Snippet: GetProjectAsync(ProjectName, CallSettings)
            // Additional: GetProjectAsync(ProjectName, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Project response = await projectsClient.GetProjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProjects</summary>
        public void ListProjectsRequestObject()
        {
            // Snippet: ListProjects(ListProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            ListProjectsRequest request = new ListProjectsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListProjectsResponse, Project> response = projectsClient.ListProjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProjectsAsync</summary>
        public async Task ListProjectsRequestObjectAsync()
        {
            // Snippet: ListProjectsAsync(ListProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            ListProjectsRequest request = new ListProjectsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListProjectsResponse, Project> response = projectsClient.ListProjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectsResponse page) =>
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

        /// <summary>Snippet for ListProjects</summary>
        public void ListProjects()
        {
            // Snippet: ListProjects(string, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListProjectsResponse, Project> response = projectsClient.ListProjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProjectsAsync</summary>
        public async Task ListProjectsAsync()
        {
            // Snippet: ListProjectsAsync(string, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListProjectsResponse, Project> response = projectsClient.ListProjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectsResponse page) =>
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

        /// <summary>Snippet for ListProjects</summary>
        public void ListProjectsResourceNames()
        {
            // Snippet: ListProjects(IResourceName, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListProjectsResponse, Project> response = projectsClient.ListProjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProjectsAsync</summary>
        public async Task ListProjectsResourceNamesAsync()
        {
            // Snippet: ListProjectsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListProjectsResponse, Project> response = projectsClient.ListProjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectsResponse page) =>
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

        /// <summary>Snippet for SearchProjects</summary>
        public void SearchProjectsRequestObject()
        {
            // Snippet: SearchProjects(SearchProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            SearchProjectsRequest request = new SearchProjectsRequest { Query = "", };
            // Make the request
            PagedEnumerable<SearchProjectsResponse, Project> response = projectsClient.SearchProjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchProjectsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchProjectsAsync</summary>
        public async Task SearchProjectsRequestObjectAsync()
        {
            // Snippet: SearchProjectsAsync(SearchProjectsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            SearchProjectsRequest request = new SearchProjectsRequest { Query = "", };
            // Make the request
            PagedAsyncEnumerable<SearchProjectsResponse, Project> response = projectsClient.SearchProjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchProjectsResponse page) =>
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

        /// <summary>Snippet for SearchProjects</summary>
        public void SearchProjects()
        {
            // Snippet: SearchProjects(string, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedEnumerable<SearchProjectsResponse, Project> response = projectsClient.SearchProjects(query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Project item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchProjectsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchProjectsAsync</summary>
        public async Task SearchProjectsAsync()
        {
            // Snippet: SearchProjectsAsync(string, string, int?, CallSettings)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchProjectsResponse, Project> response = projectsClient.SearchProjectsAsync(query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Project item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchProjectsResponse page) =>
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

        /// <summary>Snippet for CreateProject</summary>
        public void CreateProjectRequestObject()
        {
            // Snippet: CreateProject(CreateProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            CreateProjectRequest request = new CreateProjectRequest
            {
                Project = new Project(),
            };
            // Make the request
            Operation<Project, CreateProjectMetadata> response = projectsClient.CreateProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, CreateProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, CreateProjectMetadata> retrievedResponse = projectsClient.PollOnceCreateProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectAsync</summary>
        public async Task CreateProjectRequestObjectAsync()
        {
            // Snippet: CreateProjectAsync(CreateProjectRequest, CallSettings)
            // Additional: CreateProjectAsync(CreateProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            CreateProjectRequest request = new CreateProjectRequest
            {
                Project = new Project(),
            };
            // Make the request
            Operation<Project, CreateProjectMetadata> response = await projectsClient.CreateProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, CreateProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, CreateProjectMetadata> retrievedResponse = await projectsClient.PollOnceCreateProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProject</summary>
        public void CreateProject()
        {
            // Snippet: CreateProject(Project, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            Project project = new Project();
            // Make the request
            Operation<Project, CreateProjectMetadata> response = projectsClient.CreateProject(project);

            // Poll until the returned long-running operation is complete
            Operation<Project, CreateProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, CreateProjectMetadata> retrievedResponse = projectsClient.PollOnceCreateProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectAsync</summary>
        public async Task CreateProjectAsync()
        {
            // Snippet: CreateProjectAsync(Project, CallSettings)
            // Additional: CreateProjectAsync(Project, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            Project project = new Project();
            // Make the request
            Operation<Project, CreateProjectMetadata> response = await projectsClient.CreateProjectAsync(project);

            // Poll until the returned long-running operation is complete
            Operation<Project, CreateProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, CreateProjectMetadata> retrievedResponse = await projectsClient.PollOnceCreateProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProject</summary>
        public void UpdateProjectRequestObject()
        {
            // Snippet: UpdateProject(UpdateProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            UpdateProjectRequest request = new UpdateProjectRequest
            {
                Project = new Project(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Project, UpdateProjectMetadata> response = projectsClient.UpdateProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, UpdateProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UpdateProjectMetadata> retrievedResponse = projectsClient.PollOnceUpdateProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectAsync</summary>
        public async Task UpdateProjectRequestObjectAsync()
        {
            // Snippet: UpdateProjectAsync(UpdateProjectRequest, CallSettings)
            // Additional: UpdateProjectAsync(UpdateProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProjectRequest request = new UpdateProjectRequest
            {
                Project = new Project(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Project, UpdateProjectMetadata> response = await projectsClient.UpdateProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, UpdateProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UpdateProjectMetadata> retrievedResponse = await projectsClient.PollOnceUpdateProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProject</summary>
        public void UpdateProject()
        {
            // Snippet: UpdateProject(Project, FieldMask, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            Project project = new Project();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Project, UpdateProjectMetadata> response = projectsClient.UpdateProject(project, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Project, UpdateProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UpdateProjectMetadata> retrievedResponse = projectsClient.PollOnceUpdateProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectAsync</summary>
        public async Task UpdateProjectAsync()
        {
            // Snippet: UpdateProjectAsync(Project, FieldMask, CallSettings)
            // Additional: UpdateProjectAsync(Project, FieldMask, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            Project project = new Project();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Project, UpdateProjectMetadata> response = await projectsClient.UpdateProjectAsync(project, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Project, UpdateProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UpdateProjectMetadata> retrievedResponse = await projectsClient.PollOnceUpdateProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveProject</summary>
        public void MoveProjectRequestObject()
        {
            // Snippet: MoveProject(MoveProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            MoveProjectRequest request = new MoveProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                DestinationParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Operation<Project, MoveProjectMetadata> response = projectsClient.MoveProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, MoveProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, MoveProjectMetadata> retrievedResponse = projectsClient.PollOnceMoveProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveProjectAsync</summary>
        public async Task MoveProjectRequestObjectAsync()
        {
            // Snippet: MoveProjectAsync(MoveProjectRequest, CallSettings)
            // Additional: MoveProjectAsync(MoveProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            MoveProjectRequest request = new MoveProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                DestinationParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Operation<Project, MoveProjectMetadata> response = await projectsClient.MoveProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, MoveProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, MoveProjectMetadata> retrievedResponse = await projectsClient.PollOnceMoveProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveProject</summary>
        public void MoveProject()
        {
            // Snippet: MoveProject(string, string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            string destinationParent = "a/wildcard/resource";
            // Make the request
            Operation<Project, MoveProjectMetadata> response = projectsClient.MoveProject(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Project, MoveProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, MoveProjectMetadata> retrievedResponse = projectsClient.PollOnceMoveProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveProjectAsync</summary>
        public async Task MoveProjectAsync()
        {
            // Snippet: MoveProjectAsync(string, string, CallSettings)
            // Additional: MoveProjectAsync(string, string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            string destinationParent = "a/wildcard/resource";
            // Make the request
            Operation<Project, MoveProjectMetadata> response = await projectsClient.MoveProjectAsync(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Project, MoveProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, MoveProjectMetadata> retrievedResponse = await projectsClient.PollOnceMoveProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveProject</summary>
        public void MoveProjectResourceNames()
        {
            // Snippet: MoveProject(ProjectName, IResourceName, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IResourceName destinationParent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<Project, MoveProjectMetadata> response = projectsClient.MoveProject(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Project, MoveProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, MoveProjectMetadata> retrievedResponse = projectsClient.PollOnceMoveProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveProjectAsync</summary>
        public async Task MoveProjectResourceNamesAsync()
        {
            // Snippet: MoveProjectAsync(ProjectName, IResourceName, CallSettings)
            // Additional: MoveProjectAsync(ProjectName, IResourceName, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IResourceName destinationParent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<Project, MoveProjectMetadata> response = await projectsClient.MoveProjectAsync(name, destinationParent);

            // Poll until the returned long-running operation is complete
            Operation<Project, MoveProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, MoveProjectMetadata> retrievedResponse = await projectsClient.PollOnceMoveProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProject</summary>
        public void DeleteProjectRequestObject()
        {
            // Snippet: DeleteProject(DeleteProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            DeleteProjectRequest request = new DeleteProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Project, DeleteProjectMetadata> response = projectsClient.DeleteProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, DeleteProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, DeleteProjectMetadata> retrievedResponse = projectsClient.PollOnceDeleteProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectAsync</summary>
        public async Task DeleteProjectRequestObjectAsync()
        {
            // Snippet: DeleteProjectAsync(DeleteProjectRequest, CallSettings)
            // Additional: DeleteProjectAsync(DeleteProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProjectRequest request = new DeleteProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Project, DeleteProjectMetadata> response = await projectsClient.DeleteProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, DeleteProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, DeleteProjectMetadata> retrievedResponse = await projectsClient.PollOnceDeleteProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProject</summary>
        public void DeleteProject()
        {
            // Snippet: DeleteProject(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Operation<Project, DeleteProjectMetadata> response = projectsClient.DeleteProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, DeleteProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, DeleteProjectMetadata> retrievedResponse = projectsClient.PollOnceDeleteProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectAsync</summary>
        public async Task DeleteProjectAsync()
        {
            // Snippet: DeleteProjectAsync(string, CallSettings)
            // Additional: DeleteProjectAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Operation<Project, DeleteProjectMetadata> response = await projectsClient.DeleteProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, DeleteProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, DeleteProjectMetadata> retrievedResponse = await projectsClient.PollOnceDeleteProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProject</summary>
        public void DeleteProjectResourceNames()
        {
            // Snippet: DeleteProject(ProjectName, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Project, DeleteProjectMetadata> response = projectsClient.DeleteProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, DeleteProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, DeleteProjectMetadata> retrievedResponse = projectsClient.PollOnceDeleteProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectAsync</summary>
        public async Task DeleteProjectResourceNamesAsync()
        {
            // Snippet: DeleteProjectAsync(ProjectName, CallSettings)
            // Additional: DeleteProjectAsync(ProjectName, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Project, DeleteProjectMetadata> response = await projectsClient.DeleteProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, DeleteProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, DeleteProjectMetadata> retrievedResponse = await projectsClient.PollOnceDeleteProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteProject</summary>
        public void UndeleteProjectRequestObject()
        {
            // Snippet: UndeleteProject(UndeleteProjectRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            UndeleteProjectRequest request = new UndeleteProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Project, UndeleteProjectMetadata> response = projectsClient.UndeleteProject(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, UndeleteProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UndeleteProjectMetadata> retrievedResponse = projectsClient.PollOnceUndeleteProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteProjectAsync</summary>
        public async Task UndeleteProjectRequestObjectAsync()
        {
            // Snippet: UndeleteProjectAsync(UndeleteProjectRequest, CallSettings)
            // Additional: UndeleteProjectAsync(UndeleteProjectRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteProjectRequest request = new UndeleteProjectRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Project, UndeleteProjectMetadata> response = await projectsClient.UndeleteProjectAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Project, UndeleteProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UndeleteProjectMetadata> retrievedResponse = await projectsClient.PollOnceUndeleteProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteProject</summary>
        public void UndeleteProject()
        {
            // Snippet: UndeleteProject(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Operation<Project, UndeleteProjectMetadata> response = projectsClient.UndeleteProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, UndeleteProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UndeleteProjectMetadata> retrievedResponse = projectsClient.PollOnceUndeleteProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteProjectAsync</summary>
        public async Task UndeleteProjectAsync()
        {
            // Snippet: UndeleteProjectAsync(string, CallSettings)
            // Additional: UndeleteProjectAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            Operation<Project, UndeleteProjectMetadata> response = await projectsClient.UndeleteProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, UndeleteProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UndeleteProjectMetadata> retrievedResponse = await projectsClient.PollOnceUndeleteProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteProject</summary>
        public void UndeleteProjectResourceNames()
        {
            // Snippet: UndeleteProject(ProjectName, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Project, UndeleteProjectMetadata> response = projectsClient.UndeleteProject(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, UndeleteProjectMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UndeleteProjectMetadata> retrievedResponse = projectsClient.PollOnceUndeleteProject(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteProjectAsync</summary>
        public async Task UndeleteProjectResourceNamesAsync()
        {
            // Snippet: UndeleteProjectAsync(ProjectName, CallSettings)
            // Additional: UndeleteProjectAsync(ProjectName, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            Operation<Project, UndeleteProjectMetadata> response = await projectsClient.UndeleteProjectAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Project, UndeleteProjectMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Project result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Project, UndeleteProjectMetadata> retrievedResponse = await projectsClient.PollOnceUndeleteProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Project retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = projectsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await projectsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = projectsClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await projectsClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = projectsClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await projectsClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = projectsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await projectsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = projectsClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await projectsClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = projectsClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await projectsClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = projectsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await projectsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = projectsClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await projectsClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            ProjectsClient projectsClient = ProjectsClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = projectsClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            ProjectsClient projectsClient = await ProjectsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await projectsClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
