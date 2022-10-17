// Copyright 2022 Google LLC
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

namespace Google.Cloud.Dataform.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataformClientSnippets
    {
        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesRequestObject()
        {
            // Snippet: ListRepositories(ListRepositoriesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = dataformClient.ListRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesRequestObjectAsync()
        {
            // Snippet: ListRepositoriesAsync(ListRepositoriesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = dataformClient.ListRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositories()
        {
            // Snippet: ListRepositories(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = dataformClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesAsync()
        {
            // Snippet: ListRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = dataformClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesResourceNames()
        {
            // Snippet: ListRepositories(LocationName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = dataformClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesResourceNamesAsync()
        {
            // Snippet: ListRepositoriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = dataformClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryRequestObject()
        {
            // Snippet: GetRepository(GetRepositoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = dataformClient.GetRepository(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryRequestObjectAsync()
        {
            // Snippet: GetRepositoryAsync(GetRepositoryRequest, CallSettings)
            // Additional: GetRepositoryAsync(GetRepositoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = await dataformClient.GetRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepository()
        {
            // Snippet: GetRepository(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = dataformClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryAsync()
        {
            // Snippet: GetRepositoryAsync(string, CallSettings)
            // Additional: GetRepositoryAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = await dataformClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryResourceNames()
        {
            // Snippet: GetRepository(RepositoryName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Repository response = dataformClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryResourceNamesAsync()
        {
            // Snippet: GetRepositoryAsync(RepositoryName, CallSettings)
            // Additional: GetRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Repository response = await dataformClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryRequestObject()
        {
            // Snippet: CreateRepository(CreateRepositoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "",
            };
            // Make the request
            Repository response = dataformClient.CreateRepository(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryRequestObjectAsync()
        {
            // Snippet: CreateRepositoryAsync(CreateRepositoryRequest, CallSettings)
            // Additional: CreateRepositoryAsync(CreateRepositoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "",
            };
            // Make the request
            Repository response = await dataformClient.CreateRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepository()
        {
            // Snippet: CreateRepository(string, Repository, string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Repository response = dataformClient.CreateRepository(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryAsync()
        {
            // Snippet: CreateRepositoryAsync(string, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(string, Repository, string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Repository response = await dataformClient.CreateRepositoryAsync(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryResourceNames()
        {
            // Snippet: CreateRepository(LocationName, Repository, string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Repository response = dataformClient.CreateRepository(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryResourceNamesAsync()
        {
            // Snippet: CreateRepositoryAsync(LocationName, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(LocationName, Repository, string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Repository response = await dataformClient.CreateRepositoryAsync(parent, repository, repositoryId);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepositoryRequestObject()
        {
            // Snippet: UpdateRepository(UpdateRepositoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new FieldMask(),
                Repository = new Repository(),
            };
            // Make the request
            Repository response = dataformClient.UpdateRepository(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryRequestObjectAsync()
        {
            // Snippet: UpdateRepositoryAsync(UpdateRepositoryRequest, CallSettings)
            // Additional: UpdateRepositoryAsync(UpdateRepositoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new FieldMask(),
                Repository = new Repository(),
            };
            // Make the request
            Repository response = await dataformClient.UpdateRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepository()
        {
            // Snippet: UpdateRepository(Repository, FieldMask, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            Repository repository = new Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Repository response = dataformClient.UpdateRepository(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryAsync()
        {
            // Snippet: UpdateRepositoryAsync(Repository, FieldMask, CallSettings)
            // Additional: UpdateRepositoryAsync(Repository, FieldMask, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            Repository repository = new Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Repository response = await dataformClient.UpdateRepositoryAsync(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryRequestObject()
        {
            // Snippet: DeleteRepository(DeleteRepositoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Force = false,
            };
            // Make the request
            dataformClient.DeleteRepository(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryRequestObjectAsync()
        {
            // Snippet: DeleteRepositoryAsync(DeleteRepositoryRequest, CallSettings)
            // Additional: DeleteRepositoryAsync(DeleteRepositoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Force = false,
            };
            // Make the request
            await dataformClient.DeleteRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepository()
        {
            // Snippet: DeleteRepository(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            dataformClient.DeleteRepository(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryAsync()
        {
            // Snippet: DeleteRepositoryAsync(string, CallSettings)
            // Additional: DeleteRepositoryAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            await dataformClient.DeleteRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryResourceNames()
        {
            // Snippet: DeleteRepository(RepositoryName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            dataformClient.DeleteRepository(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryResourceNamesAsync()
        {
            // Snippet: DeleteRepositoryAsync(RepositoryName, CallSettings)
            // Additional: DeleteRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            await dataformClient.DeleteRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchRemoteBranches</summary>
        public void FetchRemoteBranchesRequestObject()
        {
            // Snippet: FetchRemoteBranches(FetchRemoteBranchesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            FetchRemoteBranchesRequest request = new FetchRemoteBranchesRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            FetchRemoteBranchesResponse response = dataformClient.FetchRemoteBranches(request);
            // End snippet
        }

        /// <summary>Snippet for FetchRemoteBranchesAsync</summary>
        public async Task FetchRemoteBranchesRequestObjectAsync()
        {
            // Snippet: FetchRemoteBranchesAsync(FetchRemoteBranchesRequest, CallSettings)
            // Additional: FetchRemoteBranchesAsync(FetchRemoteBranchesRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            FetchRemoteBranchesRequest request = new FetchRemoteBranchesRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            FetchRemoteBranchesResponse response = await dataformClient.FetchRemoteBranchesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspacesRequestObject()
        {
            // Snippet: ListWorkspaces(ListWorkspacesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            ListWorkspacesRequest request = new ListWorkspacesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListWorkspacesResponse, Workspace> response = dataformClient.ListWorkspaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesRequestObjectAsync()
        {
            // Snippet: ListWorkspacesAsync(ListWorkspacesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkspacesRequest request = new ListWorkspacesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> response = dataformClient.ListWorkspacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspaces()
        {
            // Snippet: ListWorkspaces(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListWorkspacesResponse, Workspace> response = dataformClient.ListWorkspaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesAsync()
        {
            // Snippet: ListWorkspacesAsync(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> response = dataformClient.ListWorkspacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspacesResourceNames()
        {
            // Snippet: ListWorkspaces(RepositoryName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListWorkspacesResponse, Workspace> response = dataformClient.ListWorkspaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesResourceNamesAsync()
        {
            // Snippet: ListWorkspacesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> response = dataformClient.ListWorkspacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspaceRequestObject()
        {
            // Snippet: GetWorkspace(GetWorkspaceRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            Workspace response = dataformClient.GetWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceRequestObjectAsync()
        {
            // Snippet: GetWorkspaceAsync(GetWorkspaceRequest, CallSettings)
            // Additional: GetWorkspaceAsync(GetWorkspaceRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            Workspace response = await dataformClient.GetWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspace()
        {
            // Snippet: GetWorkspace(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            Workspace response = dataformClient.GetWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceAsync()
        {
            // Snippet: GetWorkspaceAsync(string, CallSettings)
            // Additional: GetWorkspaceAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            Workspace response = await dataformClient.GetWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspaceResourceNames()
        {
            // Snippet: GetWorkspace(WorkspaceName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            WorkspaceName name = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            Workspace response = dataformClient.GetWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceResourceNamesAsync()
        {
            // Snippet: GetWorkspaceAsync(WorkspaceName, CallSettings)
            // Additional: GetWorkspaceAsync(WorkspaceName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            WorkspaceName name = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            Workspace response = await dataformClient.GetWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspace</summary>
        public void CreateWorkspaceRequestObject()
        {
            // Snippet: CreateWorkspace(CreateWorkspaceRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "",
            };
            // Make the request
            Workspace response = dataformClient.CreateWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspaceAsync</summary>
        public async Task CreateWorkspaceRequestObjectAsync()
        {
            // Snippet: CreateWorkspaceAsync(CreateWorkspaceRequest, CallSettings)
            // Additional: CreateWorkspaceAsync(CreateWorkspaceRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkspaceRequest request = new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Workspace = new Workspace(),
                WorkspaceId = "",
            };
            // Make the request
            Workspace response = await dataformClient.CreateWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspace</summary>
        public void CreateWorkspace()
        {
            // Snippet: CreateWorkspace(string, Workspace, string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            Workspace workspace = new Workspace();
            string workspaceId = "";
            // Make the request
            Workspace response = dataformClient.CreateWorkspace(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspaceAsync</summary>
        public async Task CreateWorkspaceAsync()
        {
            // Snippet: CreateWorkspaceAsync(string, Workspace, string, CallSettings)
            // Additional: CreateWorkspaceAsync(string, Workspace, string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            Workspace workspace = new Workspace();
            string workspaceId = "";
            // Make the request
            Workspace response = await dataformClient.CreateWorkspaceAsync(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspace</summary>
        public void CreateWorkspaceResourceNames()
        {
            // Snippet: CreateWorkspace(RepositoryName, Workspace, string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            Workspace workspace = new Workspace();
            string workspaceId = "";
            // Make the request
            Workspace response = dataformClient.CreateWorkspace(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkspaceAsync</summary>
        public async Task CreateWorkspaceResourceNamesAsync()
        {
            // Snippet: CreateWorkspaceAsync(RepositoryName, Workspace, string, CallSettings)
            // Additional: CreateWorkspaceAsync(RepositoryName, Workspace, string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            Workspace workspace = new Workspace();
            string workspaceId = "";
            // Make the request
            Workspace response = await dataformClient.CreateWorkspaceAsync(parent, workspace, workspaceId);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspace</summary>
        public void DeleteWorkspaceRequestObject()
        {
            // Snippet: DeleteWorkspace(DeleteWorkspaceRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            dataformClient.DeleteWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspaceAsync</summary>
        public async Task DeleteWorkspaceRequestObjectAsync()
        {
            // Snippet: DeleteWorkspaceAsync(DeleteWorkspaceRequest, CallSettings)
            // Additional: DeleteWorkspaceAsync(DeleteWorkspaceRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkspaceRequest request = new DeleteWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            await dataformClient.DeleteWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspace</summary>
        public void DeleteWorkspace()
        {
            // Snippet: DeleteWorkspace(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            dataformClient.DeleteWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspaceAsync</summary>
        public async Task DeleteWorkspaceAsync()
        {
            // Snippet: DeleteWorkspaceAsync(string, CallSettings)
            // Additional: DeleteWorkspaceAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workspaces/[WORKSPACE]";
            // Make the request
            await dataformClient.DeleteWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspace</summary>
        public void DeleteWorkspaceResourceNames()
        {
            // Snippet: DeleteWorkspace(WorkspaceName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            WorkspaceName name = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            dataformClient.DeleteWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkspaceAsync</summary>
        public async Task DeleteWorkspaceResourceNamesAsync()
        {
            // Snippet: DeleteWorkspaceAsync(WorkspaceName, CallSettings)
            // Additional: DeleteWorkspaceAsync(WorkspaceName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            WorkspaceName name = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]");
            // Make the request
            await dataformClient.DeleteWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InstallNpmPackages</summary>
        public void InstallNpmPackagesRequestObject()
        {
            // Snippet: InstallNpmPackages(InstallNpmPackagesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            InstallNpmPackagesRequest request = new InstallNpmPackagesRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            InstallNpmPackagesResponse response = dataformClient.InstallNpmPackages(request);
            // End snippet
        }

        /// <summary>Snippet for InstallNpmPackagesAsync</summary>
        public async Task InstallNpmPackagesRequestObjectAsync()
        {
            // Snippet: InstallNpmPackagesAsync(InstallNpmPackagesRequest, CallSettings)
            // Additional: InstallNpmPackagesAsync(InstallNpmPackagesRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            InstallNpmPackagesRequest request = new InstallNpmPackagesRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            InstallNpmPackagesResponse response = await dataformClient.InstallNpmPackagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PullGitCommits</summary>
        public void PullGitCommitsRequestObject()
        {
            // Snippet: PullGitCommits(PullGitCommitsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            PullGitCommitsRequest request = new PullGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
                Author = new CommitAuthor(),
            };
            // Make the request
            dataformClient.PullGitCommits(request);
            // End snippet
        }

        /// <summary>Snippet for PullGitCommitsAsync</summary>
        public async Task PullGitCommitsRequestObjectAsync()
        {
            // Snippet: PullGitCommitsAsync(PullGitCommitsRequest, CallSettings)
            // Additional: PullGitCommitsAsync(PullGitCommitsRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            PullGitCommitsRequest request = new PullGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
                Author = new CommitAuthor(),
            };
            // Make the request
            await dataformClient.PullGitCommitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PushGitCommits</summary>
        public void PushGitCommitsRequestObject()
        {
            // Snippet: PushGitCommits(PushGitCommitsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            PushGitCommitsRequest request = new PushGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            dataformClient.PushGitCommits(request);
            // End snippet
        }

        /// <summary>Snippet for PushGitCommitsAsync</summary>
        public async Task PushGitCommitsRequestObjectAsync()
        {
            // Snippet: PushGitCommitsAsync(PushGitCommitsRequest, CallSettings)
            // Additional: PushGitCommitsAsync(PushGitCommitsRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            PushGitCommitsRequest request = new PushGitCommitsRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            await dataformClient.PushGitCommitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileGitStatuses</summary>
        public void FetchFileGitStatusesRequestObject()
        {
            // Snippet: FetchFileGitStatuses(FetchFileGitStatusesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            FetchFileGitStatusesRequest request = new FetchFileGitStatusesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            FetchFileGitStatusesResponse response = dataformClient.FetchFileGitStatuses(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileGitStatusesAsync</summary>
        public async Task FetchFileGitStatusesRequestObjectAsync()
        {
            // Snippet: FetchFileGitStatusesAsync(FetchFileGitStatusesRequest, CallSettings)
            // Additional: FetchFileGitStatusesAsync(FetchFileGitStatusesRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            FetchFileGitStatusesRequest request = new FetchFileGitStatusesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
            };
            // Make the request
            FetchFileGitStatusesResponse response = await dataformClient.FetchFileGitStatusesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitAheadBehind</summary>
        public void FetchGitAheadBehindRequestObject()
        {
            // Snippet: FetchGitAheadBehind(FetchGitAheadBehindRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            FetchGitAheadBehindRequest request = new FetchGitAheadBehindRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            FetchGitAheadBehindResponse response = dataformClient.FetchGitAheadBehind(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitAheadBehindAsync</summary>
        public async Task FetchGitAheadBehindRequestObjectAsync()
        {
            // Snippet: FetchGitAheadBehindAsync(FetchGitAheadBehindRequest, CallSettings)
            // Additional: FetchGitAheadBehindAsync(FetchGitAheadBehindRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitAheadBehindRequest request = new FetchGitAheadBehindRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                RemoteBranch = "",
            };
            // Make the request
            FetchGitAheadBehindResponse response = await dataformClient.FetchGitAheadBehindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CommitWorkspaceChanges</summary>
        public void CommitWorkspaceChangesRequestObject()
        {
            // Snippet: CommitWorkspaceChanges(CommitWorkspaceChangesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CommitWorkspaceChangesRequest request = new CommitWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CommitMessage = "",
                Paths = { "", },
                Author = new CommitAuthor(),
            };
            // Make the request
            dataformClient.CommitWorkspaceChanges(request);
            // End snippet
        }

        /// <summary>Snippet for CommitWorkspaceChangesAsync</summary>
        public async Task CommitWorkspaceChangesRequestObjectAsync()
        {
            // Snippet: CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest, CallSettings)
            // Additional: CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CommitWorkspaceChangesRequest request = new CommitWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                CommitMessage = "",
                Paths = { "", },
                Author = new CommitAuthor(),
            };
            // Make the request
            await dataformClient.CommitWorkspaceChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetWorkspaceChanges</summary>
        public void ResetWorkspaceChangesRequestObject()
        {
            // Snippet: ResetWorkspaceChanges(ResetWorkspaceChangesRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            ResetWorkspaceChangesRequest request = new ResetWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Paths = { "", },
                Clean = false,
            };
            // Make the request
            dataformClient.ResetWorkspaceChanges(request);
            // End snippet
        }

        /// <summary>Snippet for ResetWorkspaceChangesAsync</summary>
        public async Task ResetWorkspaceChangesRequestObjectAsync()
        {
            // Snippet: ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest, CallSettings)
            // Additional: ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            ResetWorkspaceChangesRequest request = new ResetWorkspaceChangesRequest
            {
                WorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Paths = { "", },
                Clean = false,
            };
            // Make the request
            await dataformClient.ResetWorkspaceChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileDiff</summary>
        public void FetchFileDiffRequestObject()
        {
            // Snippet: FetchFileDiff(FetchFileDiffRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            FetchFileDiffRequest request = new FetchFileDiffRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            FetchFileDiffResponse response = dataformClient.FetchFileDiff(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFileDiffAsync</summary>
        public async Task FetchFileDiffRequestObjectAsync()
        {
            // Snippet: FetchFileDiffAsync(FetchFileDiffRequest, CallSettings)
            // Additional: FetchFileDiffAsync(FetchFileDiffRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            FetchFileDiffRequest request = new FetchFileDiffRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            FetchFileDiffResponse response = await dataformClient.FetchFileDiffAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryDirectoryContents</summary>
        public void QueryDirectoryContentsRequestObject()
        {
            // Snippet: QueryDirectoryContents(QueryDirectoryContentsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            QueryDirectoryContentsRequest request = new QueryDirectoryContentsRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            PagedEnumerable<QueryDirectoryContentsResponse, QueryDirectoryContentsResponse.Types.DirectoryEntry> response = dataformClient.QueryDirectoryContents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QueryDirectoryContentsResponse.Types.DirectoryEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryDirectoryContentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QueryDirectoryContentsResponse.Types.DirectoryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QueryDirectoryContentsResponse.Types.DirectoryEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QueryDirectoryContentsResponse.Types.DirectoryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDirectoryContentsAsync</summary>
        public async Task QueryDirectoryContentsRequestObjectAsync()
        {
            // Snippet: QueryDirectoryContentsAsync(QueryDirectoryContentsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            QueryDirectoryContentsRequest request = new QueryDirectoryContentsRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryDirectoryContentsResponse, QueryDirectoryContentsResponse.Types.DirectoryEntry> response = dataformClient.QueryDirectoryContentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QueryDirectoryContentsResponse.Types.DirectoryEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryDirectoryContentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QueryDirectoryContentsResponse.Types.DirectoryEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QueryDirectoryContentsResponse.Types.DirectoryEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QueryDirectoryContentsResponse.Types.DirectoryEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for MakeDirectory</summary>
        public void MakeDirectoryRequestObject()
        {
            // Snippet: MakeDirectory(MakeDirectoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            MakeDirectoryRequest request = new MakeDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            MakeDirectoryResponse response = dataformClient.MakeDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for MakeDirectoryAsync</summary>
        public async Task MakeDirectoryRequestObjectAsync()
        {
            // Snippet: MakeDirectoryAsync(MakeDirectoryRequest, CallSettings)
            // Additional: MakeDirectoryAsync(MakeDirectoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            MakeDirectoryRequest request = new MakeDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            MakeDirectoryResponse response = await dataformClient.MakeDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDirectory</summary>
        public void RemoveDirectoryRequestObject()
        {
            // Snippet: RemoveDirectory(RemoveDirectoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RemoveDirectoryRequest request = new RemoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            dataformClient.RemoveDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDirectoryAsync</summary>
        public async Task RemoveDirectoryRequestObjectAsync()
        {
            // Snippet: RemoveDirectoryAsync(RemoveDirectoryRequest, CallSettings)
            // Additional: RemoveDirectoryAsync(RemoveDirectoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RemoveDirectoryRequest request = new RemoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            await dataformClient.RemoveDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveDirectory</summary>
        public void MoveDirectoryRequestObject()
        {
            // Snippet: MoveDirectory(MoveDirectoryRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            MoveDirectoryRequest request = new MoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            MoveDirectoryResponse response = dataformClient.MoveDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for MoveDirectoryAsync</summary>
        public async Task MoveDirectoryRequestObjectAsync()
        {
            // Snippet: MoveDirectoryAsync(MoveDirectoryRequest, CallSettings)
            // Additional: MoveDirectoryAsync(MoveDirectoryRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            MoveDirectoryRequest request = new MoveDirectoryRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            MoveDirectoryResponse response = await dataformClient.MoveDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadFile</summary>
        public void ReadFileRequestObject()
        {
            // Snippet: ReadFile(ReadFileRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            ReadFileRequest request = new ReadFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            ReadFileResponse response = dataformClient.ReadFile(request);
            // End snippet
        }

        /// <summary>Snippet for ReadFileAsync</summary>
        public async Task ReadFileRequestObjectAsync()
        {
            // Snippet: ReadFileAsync(ReadFileRequest, CallSettings)
            // Additional: ReadFileAsync(ReadFileRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            ReadFileRequest request = new ReadFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            ReadFileResponse response = await dataformClient.ReadFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveFile</summary>
        public void RemoveFileRequestObject()
        {
            // Snippet: RemoveFile(RemoveFileRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RemoveFileRequest request = new RemoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            dataformClient.RemoveFile(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveFileAsync</summary>
        public async Task RemoveFileRequestObjectAsync()
        {
            // Snippet: RemoveFileAsync(RemoveFileRequest, CallSettings)
            // Additional: RemoveFileAsync(RemoveFileRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RemoveFileRequest request = new RemoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
            };
            // Make the request
            await dataformClient.RemoveFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveFile</summary>
        public void MoveFileRequestObject()
        {
            // Snippet: MoveFile(MoveFileRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            MoveFileRequest request = new MoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            MoveFileResponse response = dataformClient.MoveFile(request);
            // End snippet
        }

        /// <summary>Snippet for MoveFileAsync</summary>
        public async Task MoveFileRequestObjectAsync()
        {
            // Snippet: MoveFileAsync(MoveFileRequest, CallSettings)
            // Additional: MoveFileAsync(MoveFileRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            MoveFileRequest request = new MoveFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                NewPath = "",
            };
            // Make the request
            MoveFileResponse response = await dataformClient.MoveFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteFile</summary>
        public void WriteFileRequestObject()
        {
            // Snippet: WriteFile(WriteFileRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            WriteFileRequest request = new WriteFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                Contents = ByteString.Empty,
            };
            // Make the request
            WriteFileResponse response = dataformClient.WriteFile(request);
            // End snippet
        }

        /// <summary>Snippet for WriteFileAsync</summary>
        public async Task WriteFileRequestObjectAsync()
        {
            // Snippet: WriteFileAsync(WriteFileRequest, CallSettings)
            // Additional: WriteFileAsync(WriteFileRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            WriteFileRequest request = new WriteFileRequest
            {
                WorkspaceAsWorkspaceName = WorkspaceName.FromProjectLocationRepositoryWorkspace("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKSPACE]"),
                Path = "",
                Contents = ByteString.Empty,
            };
            // Make the request
            WriteFileResponse response = await dataformClient.WriteFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResults</summary>
        public void ListCompilationResultsRequestObject()
        {
            // Snippet: ListCompilationResults(ListCompilationResultsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            ListCompilationResultsRequest request = new ListCompilationResultsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListCompilationResultsResponse, CompilationResult> response = dataformClient.ListCompilationResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResultsAsync</summary>
        public async Task ListCompilationResultsRequestObjectAsync()
        {
            // Snippet: ListCompilationResultsAsync(ListCompilationResultsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            ListCompilationResultsRequest request = new ListCompilationResultsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> response = dataformClient.ListCompilationResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CompilationResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompilationResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResults</summary>
        public void ListCompilationResults()
        {
            // Snippet: ListCompilationResults(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListCompilationResultsResponse, CompilationResult> response = dataformClient.ListCompilationResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResultsAsync</summary>
        public async Task ListCompilationResultsAsync()
        {
            // Snippet: ListCompilationResultsAsync(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> response = dataformClient.ListCompilationResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CompilationResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompilationResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResults</summary>
        public void ListCompilationResultsResourceNames()
        {
            // Snippet: ListCompilationResults(RepositoryName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListCompilationResultsResponse, CompilationResult> response = dataformClient.ListCompilationResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CompilationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompilationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompilationResultsAsync</summary>
        public async Task ListCompilationResultsResourceNamesAsync()
        {
            // Snippet: ListCompilationResultsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> response = dataformClient.ListCompilationResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CompilationResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompilationResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResult</summary>
        public void GetCompilationResultRequestObject()
        {
            // Snippet: GetCompilationResult(GetCompilationResultRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            // Make the request
            CompilationResult response = dataformClient.GetCompilationResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResultAsync</summary>
        public async Task GetCompilationResultRequestObjectAsync()
        {
            // Snippet: GetCompilationResultAsync(GetCompilationResultRequest, CallSettings)
            // Additional: GetCompilationResultAsync(GetCompilationResultRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            GetCompilationResultRequest request = new GetCompilationResultRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
            };
            // Make the request
            CompilationResult response = await dataformClient.GetCompilationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResult</summary>
        public void GetCompilationResult()
        {
            // Snippet: GetCompilationResult(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/compilationResults/[COMPILATION_RESULT]";
            // Make the request
            CompilationResult response = dataformClient.GetCompilationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResultAsync</summary>
        public async Task GetCompilationResultAsync()
        {
            // Snippet: GetCompilationResultAsync(string, CallSettings)
            // Additional: GetCompilationResultAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/compilationResults/[COMPILATION_RESULT]";
            // Make the request
            CompilationResult response = await dataformClient.GetCompilationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResult</summary>
        public void GetCompilationResultResourceNames()
        {
            // Snippet: GetCompilationResult(CompilationResultName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CompilationResultName name = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]");
            // Make the request
            CompilationResult response = dataformClient.GetCompilationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompilationResultAsync</summary>
        public async Task GetCompilationResultResourceNamesAsync()
        {
            // Snippet: GetCompilationResultAsync(CompilationResultName, CallSettings)
            // Additional: GetCompilationResultAsync(CompilationResultName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CompilationResultName name = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]");
            // Make the request
            CompilationResult response = await dataformClient.GetCompilationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResult</summary>
        public void CreateCompilationResultRequestObject()
        {
            // Snippet: CreateCompilationResult(CreateCompilationResultRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            // Make the request
            CompilationResult response = dataformClient.CreateCompilationResult(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResultAsync</summary>
        public async Task CreateCompilationResultRequestObjectAsync()
        {
            // Snippet: CreateCompilationResultAsync(CreateCompilationResultRequest, CallSettings)
            // Additional: CreateCompilationResultAsync(CreateCompilationResultRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CreateCompilationResultRequest request = new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                CompilationResult = new CompilationResult(),
            };
            // Make the request
            CompilationResult response = await dataformClient.CreateCompilationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResult</summary>
        public void CreateCompilationResult()
        {
            // Snippet: CreateCompilationResult(string, CompilationResult, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            CompilationResult compilationResult = new CompilationResult();
            // Make the request
            CompilationResult response = dataformClient.CreateCompilationResult(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResultAsync</summary>
        public async Task CreateCompilationResultAsync()
        {
            // Snippet: CreateCompilationResultAsync(string, CompilationResult, CallSettings)
            // Additional: CreateCompilationResultAsync(string, CompilationResult, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            CompilationResult compilationResult = new CompilationResult();
            // Make the request
            CompilationResult response = await dataformClient.CreateCompilationResultAsync(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResult</summary>
        public void CreateCompilationResultResourceNames()
        {
            // Snippet: CreateCompilationResult(RepositoryName, CompilationResult, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            CompilationResult compilationResult = new CompilationResult();
            // Make the request
            CompilationResult response = dataformClient.CreateCompilationResult(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for CreateCompilationResultAsync</summary>
        public async Task CreateCompilationResultResourceNamesAsync()
        {
            // Snippet: CreateCompilationResultAsync(RepositoryName, CompilationResult, CallSettings)
            // Additional: CreateCompilationResultAsync(RepositoryName, CompilationResult, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            CompilationResult compilationResult = new CompilationResult();
            // Make the request
            CompilationResult response = await dataformClient.CreateCompilationResultAsync(parent, compilationResult);
            // End snippet
        }

        /// <summary>Snippet for QueryCompilationResultActions</summary>
        public void QueryCompilationResultActionsRequestObject()
        {
            // Snippet: QueryCompilationResultActions(QueryCompilationResultActionsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            QueryCompilationResultActionsRequest request = new QueryCompilationResultActionsRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<QueryCompilationResultActionsResponse, CompilationResultAction> response = dataformClient.QueryCompilationResultActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CompilationResultAction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryCompilationResultActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResultAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResultAction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResultAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCompilationResultActionsAsync</summary>
        public async Task QueryCompilationResultActionsRequestObjectAsync()
        {
            // Snippet: QueryCompilationResultActionsAsync(QueryCompilationResultActionsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            QueryCompilationResultActionsRequest request = new QueryCompilationResultActionsRequest
            {
                CompilationResultName = CompilationResultName.FromProjectLocationRepositoryCompilationResult("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[COMPILATION_RESULT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryCompilationResultActionsResponse, CompilationResultAction> response = dataformClient.QueryCompilationResultActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CompilationResultAction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryCompilationResultActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CompilationResultAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CompilationResultAction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CompilationResultAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocations</summary>
        public void ListWorkflowInvocationsRequestObject()
        {
            // Snippet: ListWorkflowInvocations(ListWorkflowInvocationsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            ListWorkflowInvocationsRequest request = new ListWorkflowInvocationsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> response = dataformClient.ListWorkflowInvocations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocationsAsync</summary>
        public async Task ListWorkflowInvocationsRequestObjectAsync()
        {
            // Snippet: ListWorkflowInvocationsAsync(ListWorkflowInvocationsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkflowInvocationsRequest request = new ListWorkflowInvocationsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> response = dataformClient.ListWorkflowInvocationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkflowInvocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowInvocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocations</summary>
        public void ListWorkflowInvocations()
        {
            // Snippet: ListWorkflowInvocations(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> response = dataformClient.ListWorkflowInvocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocationsAsync</summary>
        public async Task ListWorkflowInvocationsAsync()
        {
            // Snippet: ListWorkflowInvocationsAsync(string, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> response = dataformClient.ListWorkflowInvocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkflowInvocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowInvocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocations</summary>
        public void ListWorkflowInvocationsResourceNames()
        {
            // Snippet: ListWorkflowInvocations(RepositoryName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> response = dataformClient.ListWorkflowInvocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkflowInvocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowInvocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowInvocationsAsync</summary>
        public async Task ListWorkflowInvocationsResourceNamesAsync()
        {
            // Snippet: ListWorkflowInvocationsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> response = dataformClient.ListWorkflowInvocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkflowInvocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowInvocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocation</summary>
        public void GetWorkflowInvocationRequestObject()
        {
            // Snippet: GetWorkflowInvocation(GetWorkflowInvocationRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            WorkflowInvocation response = dataformClient.GetWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocationAsync</summary>
        public async Task GetWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: GetWorkflowInvocationAsync(GetWorkflowInvocationRequest, CallSettings)
            // Additional: GetWorkflowInvocationAsync(GetWorkflowInvocationRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkflowInvocationRequest request = new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            WorkflowInvocation response = await dataformClient.GetWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocation</summary>
        public void GetWorkflowInvocation()
        {
            // Snippet: GetWorkflowInvocation(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            WorkflowInvocation response = dataformClient.GetWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocationAsync</summary>
        public async Task GetWorkflowInvocationAsync()
        {
            // Snippet: GetWorkflowInvocationAsync(string, CallSettings)
            // Additional: GetWorkflowInvocationAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            WorkflowInvocation response = await dataformClient.GetWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocation</summary>
        public void GetWorkflowInvocationResourceNames()
        {
            // Snippet: GetWorkflowInvocation(WorkflowInvocationName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            WorkflowInvocationName name = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            WorkflowInvocation response = dataformClient.GetWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowInvocationAsync</summary>
        public async Task GetWorkflowInvocationResourceNamesAsync()
        {
            // Snippet: GetWorkflowInvocationAsync(WorkflowInvocationName, CallSettings)
            // Additional: GetWorkflowInvocationAsync(WorkflowInvocationName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowInvocationName name = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            WorkflowInvocation response = await dataformClient.GetWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocation</summary>
        public void CreateWorkflowInvocationRequestObject()
        {
            // Snippet: CreateWorkflowInvocation(CreateWorkflowInvocationRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            // Make the request
            WorkflowInvocation response = dataformClient.CreateWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocationAsync</summary>
        public async Task CreateWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest, CallSettings)
            // Additional: CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkflowInvocationRequest request = new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                WorkflowInvocation = new WorkflowInvocation(),
            };
            // Make the request
            WorkflowInvocation response = await dataformClient.CreateWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocation</summary>
        public void CreateWorkflowInvocation()
        {
            // Snippet: CreateWorkflowInvocation(string, WorkflowInvocation, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            WorkflowInvocation workflowInvocation = new WorkflowInvocation();
            // Make the request
            WorkflowInvocation response = dataformClient.CreateWorkflowInvocation(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocationAsync</summary>
        public async Task CreateWorkflowInvocationAsync()
        {
            // Snippet: CreateWorkflowInvocationAsync(string, WorkflowInvocation, CallSettings)
            // Additional: CreateWorkflowInvocationAsync(string, WorkflowInvocation, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            WorkflowInvocation workflowInvocation = new WorkflowInvocation();
            // Make the request
            WorkflowInvocation response = await dataformClient.CreateWorkflowInvocationAsync(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocation</summary>
        public void CreateWorkflowInvocationResourceNames()
        {
            // Snippet: CreateWorkflowInvocation(RepositoryName, WorkflowInvocation, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            WorkflowInvocation workflowInvocation = new WorkflowInvocation();
            // Make the request
            WorkflowInvocation response = dataformClient.CreateWorkflowInvocation(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowInvocationAsync</summary>
        public async Task CreateWorkflowInvocationResourceNamesAsync()
        {
            // Snippet: CreateWorkflowInvocationAsync(RepositoryName, WorkflowInvocation, CallSettings)
            // Additional: CreateWorkflowInvocationAsync(RepositoryName, WorkflowInvocation, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            WorkflowInvocation workflowInvocation = new WorkflowInvocation();
            // Make the request
            WorkflowInvocation response = await dataformClient.CreateWorkflowInvocationAsync(parent, workflowInvocation);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocation</summary>
        public void DeleteWorkflowInvocationRequestObject()
        {
            // Snippet: DeleteWorkflowInvocation(DeleteWorkflowInvocationRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            dataformClient.DeleteWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocationAsync</summary>
        public async Task DeleteWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest, CallSettings)
            // Additional: DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkflowInvocationRequest request = new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            await dataformClient.DeleteWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocation</summary>
        public void DeleteWorkflowInvocation()
        {
            // Snippet: DeleteWorkflowInvocation(string, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            dataformClient.DeleteWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocationAsync</summary>
        public async Task DeleteWorkflowInvocationAsync()
        {
            // Snippet: DeleteWorkflowInvocationAsync(string, CallSettings)
            // Additional: DeleteWorkflowInvocationAsync(string, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/workflowInvocations/[WORKFLOW_INVOCATION]";
            // Make the request
            await dataformClient.DeleteWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocation</summary>
        public void DeleteWorkflowInvocationResourceNames()
        {
            // Snippet: DeleteWorkflowInvocation(WorkflowInvocationName, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            WorkflowInvocationName name = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            dataformClient.DeleteWorkflowInvocation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowInvocationAsync</summary>
        public async Task DeleteWorkflowInvocationResourceNamesAsync()
        {
            // Snippet: DeleteWorkflowInvocationAsync(WorkflowInvocationName, CallSettings)
            // Additional: DeleteWorkflowInvocationAsync(WorkflowInvocationName, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowInvocationName name = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]");
            // Make the request
            await dataformClient.DeleteWorkflowInvocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelWorkflowInvocation</summary>
        public void CancelWorkflowInvocationRequestObject()
        {
            // Snippet: CancelWorkflowInvocation(CancelWorkflowInvocationRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            CancelWorkflowInvocationRequest request = new CancelWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            dataformClient.CancelWorkflowInvocation(request);
            // End snippet
        }

        /// <summary>Snippet for CancelWorkflowInvocationAsync</summary>
        public async Task CancelWorkflowInvocationRequestObjectAsync()
        {
            // Snippet: CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest, CallSettings)
            // Additional: CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest, CancellationToken)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            CancelWorkflowInvocationRequest request = new CancelWorkflowInvocationRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            await dataformClient.CancelWorkflowInvocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWorkflowInvocationActions</summary>
        public void QueryWorkflowInvocationActionsRequestObject()
        {
            // Snippet: QueryWorkflowInvocationActions(QueryWorkflowInvocationActionsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            QueryWorkflowInvocationActionsRequest request = new QueryWorkflowInvocationActionsRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            PagedEnumerable<QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction> response = dataformClient.QueryWorkflowInvocationActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkflowInvocationAction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryWorkflowInvocationActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocationAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocationAction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocationAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryWorkflowInvocationActionsAsync</summary>
        public async Task QueryWorkflowInvocationActionsRequestObjectAsync()
        {
            // Snippet: QueryWorkflowInvocationActionsAsync(QueryWorkflowInvocationActionsRequest, CallSettings)
            // Create client
            DataformClient dataformClient = await DataformClient.CreateAsync();
            // Initialize request argument(s)
            QueryWorkflowInvocationActionsRequest request = new QueryWorkflowInvocationActionsRequest
            {
                WorkflowInvocationName = WorkflowInvocationName.FromProjectLocationRepositoryWorkflowInvocation("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[WORKFLOW_INVOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction> response = dataformClient.QueryWorkflowInvocationActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkflowInvocationAction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryWorkflowInvocationActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowInvocationAction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowInvocationAction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowInvocationAction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
