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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ApiHub.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubDependenciesClientSnippets
    {
        /// <summary>Snippet for CreateDependency</summary>
        public void CreateDependencyRequestObject()
        {
            // Snippet: CreateDependency(CreateDependencyRequest, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            CreateDependencyRequest request = new CreateDependencyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DependencyId = "",
                Dependency = new Dependency(),
            };
            // Make the request
            Dependency response = apiHubDependenciesClient.CreateDependency(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDependencyAsync</summary>
        public async Task CreateDependencyRequestObjectAsync()
        {
            // Snippet: CreateDependencyAsync(CreateDependencyRequest, CallSettings)
            // Additional: CreateDependencyAsync(CreateDependencyRequest, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            CreateDependencyRequest request = new CreateDependencyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DependencyId = "",
                Dependency = new Dependency(),
            };
            // Make the request
            Dependency response = await apiHubDependenciesClient.CreateDependencyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDependency</summary>
        public void CreateDependency()
        {
            // Snippet: CreateDependency(string, Dependency, string, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Dependency dependency = new Dependency();
            string dependencyId = "";
            // Make the request
            Dependency response = apiHubDependenciesClient.CreateDependency(parent, dependency, dependencyId);
            // End snippet
        }

        /// <summary>Snippet for CreateDependencyAsync</summary>
        public async Task CreateDependencyAsync()
        {
            // Snippet: CreateDependencyAsync(string, Dependency, string, CallSettings)
            // Additional: CreateDependencyAsync(string, Dependency, string, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Dependency dependency = new Dependency();
            string dependencyId = "";
            // Make the request
            Dependency response = await apiHubDependenciesClient.CreateDependencyAsync(parent, dependency, dependencyId);
            // End snippet
        }

        /// <summary>Snippet for CreateDependency</summary>
        public void CreateDependencyResourceNames()
        {
            // Snippet: CreateDependency(LocationName, Dependency, string, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dependency dependency = new Dependency();
            string dependencyId = "";
            // Make the request
            Dependency response = apiHubDependenciesClient.CreateDependency(parent, dependency, dependencyId);
            // End snippet
        }

        /// <summary>Snippet for CreateDependencyAsync</summary>
        public async Task CreateDependencyResourceNamesAsync()
        {
            // Snippet: CreateDependencyAsync(LocationName, Dependency, string, CallSettings)
            // Additional: CreateDependencyAsync(LocationName, Dependency, string, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Dependency dependency = new Dependency();
            string dependencyId = "";
            // Make the request
            Dependency response = await apiHubDependenciesClient.CreateDependencyAsync(parent, dependency, dependencyId);
            // End snippet
        }

        /// <summary>Snippet for GetDependency</summary>
        public void GetDependencyRequestObject()
        {
            // Snippet: GetDependency(GetDependencyRequest, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            GetDependencyRequest request = new GetDependencyRequest
            {
                DependencyName = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]"),
            };
            // Make the request
            Dependency response = apiHubDependenciesClient.GetDependency(request);
            // End snippet
        }

        /// <summary>Snippet for GetDependencyAsync</summary>
        public async Task GetDependencyRequestObjectAsync()
        {
            // Snippet: GetDependencyAsync(GetDependencyRequest, CallSettings)
            // Additional: GetDependencyAsync(GetDependencyRequest, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            GetDependencyRequest request = new GetDependencyRequest
            {
                DependencyName = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]"),
            };
            // Make the request
            Dependency response = await apiHubDependenciesClient.GetDependencyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDependency</summary>
        public void GetDependency()
        {
            // Snippet: GetDependency(string, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dependencies/[DEPENDENCY]";
            // Make the request
            Dependency response = apiHubDependenciesClient.GetDependency(name);
            // End snippet
        }

        /// <summary>Snippet for GetDependencyAsync</summary>
        public async Task GetDependencyAsync()
        {
            // Snippet: GetDependencyAsync(string, CallSettings)
            // Additional: GetDependencyAsync(string, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dependencies/[DEPENDENCY]";
            // Make the request
            Dependency response = await apiHubDependenciesClient.GetDependencyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDependency</summary>
        public void GetDependencyResourceNames()
        {
            // Snippet: GetDependency(DependencyName, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            DependencyName name = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]");
            // Make the request
            Dependency response = apiHubDependenciesClient.GetDependency(name);
            // End snippet
        }

        /// <summary>Snippet for GetDependencyAsync</summary>
        public async Task GetDependencyResourceNamesAsync()
        {
            // Snippet: GetDependencyAsync(DependencyName, CallSettings)
            // Additional: GetDependencyAsync(DependencyName, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            DependencyName name = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]");
            // Make the request
            Dependency response = await apiHubDependenciesClient.GetDependencyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDependency</summary>
        public void UpdateDependencyRequestObject()
        {
            // Snippet: UpdateDependency(UpdateDependencyRequest, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            UpdateDependencyRequest request = new UpdateDependencyRequest
            {
                Dependency = new Dependency(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dependency response = apiHubDependenciesClient.UpdateDependency(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDependencyAsync</summary>
        public async Task UpdateDependencyRequestObjectAsync()
        {
            // Snippet: UpdateDependencyAsync(UpdateDependencyRequest, CallSettings)
            // Additional: UpdateDependencyAsync(UpdateDependencyRequest, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDependencyRequest request = new UpdateDependencyRequest
            {
                Dependency = new Dependency(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Dependency response = await apiHubDependenciesClient.UpdateDependencyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDependency</summary>
        public void UpdateDependency()
        {
            // Snippet: UpdateDependency(Dependency, FieldMask, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            Dependency dependency = new Dependency();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dependency response = apiHubDependenciesClient.UpdateDependency(dependency, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDependencyAsync</summary>
        public async Task UpdateDependencyAsync()
        {
            // Snippet: UpdateDependencyAsync(Dependency, FieldMask, CallSettings)
            // Additional: UpdateDependencyAsync(Dependency, FieldMask, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            Dependency dependency = new Dependency();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Dependency response = await apiHubDependenciesClient.UpdateDependencyAsync(dependency, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDependency</summary>
        public void DeleteDependencyRequestObject()
        {
            // Snippet: DeleteDependency(DeleteDependencyRequest, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            DeleteDependencyRequest request = new DeleteDependencyRequest
            {
                DependencyName = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]"),
            };
            // Make the request
            apiHubDependenciesClient.DeleteDependency(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDependencyAsync</summary>
        public async Task DeleteDependencyRequestObjectAsync()
        {
            // Snippet: DeleteDependencyAsync(DeleteDependencyRequest, CallSettings)
            // Additional: DeleteDependencyAsync(DeleteDependencyRequest, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDependencyRequest request = new DeleteDependencyRequest
            {
                DependencyName = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]"),
            };
            // Make the request
            await apiHubDependenciesClient.DeleteDependencyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDependency</summary>
        public void DeleteDependency()
        {
            // Snippet: DeleteDependency(string, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dependencies/[DEPENDENCY]";
            // Make the request
            apiHubDependenciesClient.DeleteDependency(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDependencyAsync</summary>
        public async Task DeleteDependencyAsync()
        {
            // Snippet: DeleteDependencyAsync(string, CallSettings)
            // Additional: DeleteDependencyAsync(string, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dependencies/[DEPENDENCY]";
            // Make the request
            await apiHubDependenciesClient.DeleteDependencyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDependency</summary>
        public void DeleteDependencyResourceNames()
        {
            // Snippet: DeleteDependency(DependencyName, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            DependencyName name = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]");
            // Make the request
            apiHubDependenciesClient.DeleteDependency(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDependencyAsync</summary>
        public async Task DeleteDependencyResourceNamesAsync()
        {
            // Snippet: DeleteDependencyAsync(DependencyName, CallSettings)
            // Additional: DeleteDependencyAsync(DependencyName, CancellationToken)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            DependencyName name = DependencyName.FromProjectLocationDependency("[PROJECT]", "[LOCATION]", "[DEPENDENCY]");
            // Make the request
            await apiHubDependenciesClient.DeleteDependencyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDependencies</summary>
        public void ListDependenciesRequestObject()
        {
            // Snippet: ListDependencies(ListDependenciesRequest, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            ListDependenciesRequest request = new ListDependenciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDependenciesResponse, Dependency> response = apiHubDependenciesClient.ListDependencies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dependency item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDependenciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dependency item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dependency> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dependency item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDependenciesAsync</summary>
        public async Task ListDependenciesRequestObjectAsync()
        {
            // Snippet: ListDependenciesAsync(ListDependenciesRequest, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            ListDependenciesRequest request = new ListDependenciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDependenciesResponse, Dependency> response = apiHubDependenciesClient.ListDependenciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dependency item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDependenciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dependency item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dependency> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dependency item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDependencies</summary>
        public void ListDependencies()
        {
            // Snippet: ListDependencies(string, string, int?, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDependenciesResponse, Dependency> response = apiHubDependenciesClient.ListDependencies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dependency item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDependenciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dependency item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dependency> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dependency item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDependenciesAsync</summary>
        public async Task ListDependenciesAsync()
        {
            // Snippet: ListDependenciesAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDependenciesResponse, Dependency> response = apiHubDependenciesClient.ListDependenciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dependency item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDependenciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dependency item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dependency> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dependency item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDependencies</summary>
        public void ListDependenciesResourceNames()
        {
            // Snippet: ListDependencies(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = ApiHubDependenciesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDependenciesResponse, Dependency> response = apiHubDependenciesClient.ListDependencies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dependency item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDependenciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dependency item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dependency> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dependency item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDependenciesAsync</summary>
        public async Task ListDependenciesResourceNamesAsync()
        {
            // Snippet: ListDependenciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubDependenciesClient apiHubDependenciesClient = await ApiHubDependenciesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDependenciesResponse, Dependency> response = apiHubDependenciesClient.ListDependenciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dependency item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDependenciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dependency item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dependency> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dependency item in singlePage)
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
