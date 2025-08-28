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
    using Google.Cloud.CloudSecurityCompliance.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConfigClientSnippets
    {
        /// <summary>Snippet for ListFrameworks</summary>
        public void ListFrameworksRequestObject()
        {
            // Snippet: ListFrameworks(ListFrameworksRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListFrameworksRequest request = new ListFrameworksRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListFrameworksResponse, Framework> response = configClient.ListFrameworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworksAsync</summary>
        public async Task ListFrameworksRequestObjectAsync()
        {
            // Snippet: ListFrameworksAsync(ListFrameworksRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListFrameworksRequest request = new ListFrameworksRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFrameworksResponse, Framework> response = configClient.ListFrameworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Framework item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworks</summary>
        public void ListFrameworks()
        {
            // Snippet: ListFrameworks(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFrameworksResponse, Framework> response = configClient.ListFrameworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworksAsync</summary>
        public async Task ListFrameworksAsync()
        {
            // Snippet: ListFrameworksAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFrameworksResponse, Framework> response = configClient.ListFrameworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Framework item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworks</summary>
        public void ListFrameworksResourceNames()
        {
            // Snippet: ListFrameworks(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworksResponse, Framework> response = configClient.ListFrameworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Framework item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworksAsync</summary>
        public async Task ListFrameworksResourceNamesAsync()
        {
            // Snippet: ListFrameworksAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworksResponse, Framework> response = configClient.ListFrameworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Framework item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Framework item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Framework> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Framework item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFramework</summary>
        public void GetFrameworkRequestObject()
        {
            // Snippet: GetFramework(GetFrameworkRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetFrameworkRequest request = new GetFrameworkRequest
            {
                FrameworkName = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]"),
                MajorRevisionId = 0L,
            };
            // Make the request
            Framework response = configClient.GetFramework(request);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAsync</summary>
        public async Task GetFrameworkRequestObjectAsync()
        {
            // Snippet: GetFrameworkAsync(GetFrameworkRequest, CallSettings)
            // Additional: GetFrameworkAsync(GetFrameworkRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetFrameworkRequest request = new GetFrameworkRequest
            {
                FrameworkName = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]"),
                MajorRevisionId = 0L,
            };
            // Make the request
            Framework response = await configClient.GetFrameworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFramework</summary>
        public void GetFramework()
        {
            // Snippet: GetFramework(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworks/[FRAMEWORK]";
            // Make the request
            Framework response = configClient.GetFramework(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAsync</summary>
        public async Task GetFrameworkAsync()
        {
            // Snippet: GetFrameworkAsync(string, CallSettings)
            // Additional: GetFrameworkAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworks/[FRAMEWORK]";
            // Make the request
            Framework response = await configClient.GetFrameworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFramework</summary>
        public void GetFrameworkResourceNames()
        {
            // Snippet: GetFramework(FrameworkName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            FrameworkName name = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]");
            // Make the request
            Framework response = configClient.GetFramework(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAsync</summary>
        public async Task GetFrameworkResourceNamesAsync()
        {
            // Snippet: GetFrameworkAsync(FrameworkName, CallSettings)
            // Additional: GetFrameworkAsync(FrameworkName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkName name = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]");
            // Make the request
            Framework response = await configClient.GetFrameworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFramework</summary>
        public void CreateFrameworkRequestObject()
        {
            // Snippet: CreateFramework(CreateFrameworkRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CreateFrameworkRequest request = new CreateFrameworkRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FrameworkId = "",
                Framework = new Framework(),
            };
            // Make the request
            Framework response = configClient.CreateFramework(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAsync</summary>
        public async Task CreateFrameworkRequestObjectAsync()
        {
            // Snippet: CreateFrameworkAsync(CreateFrameworkRequest, CallSettings)
            // Additional: CreateFrameworkAsync(CreateFrameworkRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CreateFrameworkRequest request = new CreateFrameworkRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FrameworkId = "",
                Framework = new Framework(),
            };
            // Make the request
            Framework response = await configClient.CreateFrameworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFramework</summary>
        public void CreateFramework()
        {
            // Snippet: CreateFramework(string, Framework, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            Framework framework = new Framework();
            string frameworkId = "";
            // Make the request
            Framework response = configClient.CreateFramework(parent, framework, frameworkId);
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAsync</summary>
        public async Task CreateFrameworkAsync()
        {
            // Snippet: CreateFrameworkAsync(string, Framework, string, CallSettings)
            // Additional: CreateFrameworkAsync(string, Framework, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            Framework framework = new Framework();
            string frameworkId = "";
            // Make the request
            Framework response = await configClient.CreateFrameworkAsync(parent, framework, frameworkId);
            // End snippet
        }

        /// <summary>Snippet for CreateFramework</summary>
        public void CreateFrameworkResourceNames()
        {
            // Snippet: CreateFramework(OrganizationLocationName, Framework, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Framework framework = new Framework();
            string frameworkId = "";
            // Make the request
            Framework response = configClient.CreateFramework(parent, framework, frameworkId);
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAsync</summary>
        public async Task CreateFrameworkResourceNamesAsync()
        {
            // Snippet: CreateFrameworkAsync(OrganizationLocationName, Framework, string, CallSettings)
            // Additional: CreateFrameworkAsync(OrganizationLocationName, Framework, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Framework framework = new Framework();
            string frameworkId = "";
            // Make the request
            Framework response = await configClient.CreateFrameworkAsync(parent, framework, frameworkId);
            // End snippet
        }

        /// <summary>Snippet for UpdateFramework</summary>
        public void UpdateFrameworkRequestObject()
        {
            // Snippet: UpdateFramework(UpdateFrameworkRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            UpdateFrameworkRequest request = new UpdateFrameworkRequest
            {
                UpdateMask = new FieldMask(),
                Framework = new Framework(),
                MajorRevisionId = 0L,
            };
            // Make the request
            Framework response = configClient.UpdateFramework(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFrameworkAsync</summary>
        public async Task UpdateFrameworkRequestObjectAsync()
        {
            // Snippet: UpdateFrameworkAsync(UpdateFrameworkRequest, CallSettings)
            // Additional: UpdateFrameworkAsync(UpdateFrameworkRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFrameworkRequest request = new UpdateFrameworkRequest
            {
                UpdateMask = new FieldMask(),
                Framework = new Framework(),
                MajorRevisionId = 0L,
            };
            // Make the request
            Framework response = await configClient.UpdateFrameworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFramework</summary>
        public void UpdateFramework()
        {
            // Snippet: UpdateFramework(Framework, FieldMask, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            Framework framework = new Framework();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Framework response = configClient.UpdateFramework(framework, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFrameworkAsync</summary>
        public async Task UpdateFrameworkAsync()
        {
            // Snippet: UpdateFrameworkAsync(Framework, FieldMask, CallSettings)
            // Additional: UpdateFrameworkAsync(Framework, FieldMask, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            Framework framework = new Framework();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Framework response = await configClient.UpdateFrameworkAsync(framework, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteFramework</summary>
        public void DeleteFrameworkRequestObject()
        {
            // Snippet: DeleteFramework(DeleteFrameworkRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeleteFrameworkRequest request = new DeleteFrameworkRequest
            {
                FrameworkName = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]"),
            };
            // Make the request
            configClient.DeleteFramework(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkAsync</summary>
        public async Task DeleteFrameworkRequestObjectAsync()
        {
            // Snippet: DeleteFrameworkAsync(DeleteFrameworkRequest, CallSettings)
            // Additional: DeleteFrameworkAsync(DeleteFrameworkRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFrameworkRequest request = new DeleteFrameworkRequest
            {
                FrameworkName = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]"),
            };
            // Make the request
            await configClient.DeleteFrameworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFramework</summary>
        public void DeleteFramework()
        {
            // Snippet: DeleteFramework(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworks/[FRAMEWORK]";
            // Make the request
            configClient.DeleteFramework(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkAsync</summary>
        public async Task DeleteFrameworkAsync()
        {
            // Snippet: DeleteFrameworkAsync(string, CallSettings)
            // Additional: DeleteFrameworkAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/frameworks/[FRAMEWORK]";
            // Make the request
            await configClient.DeleteFrameworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFramework</summary>
        public void DeleteFrameworkResourceNames()
        {
            // Snippet: DeleteFramework(FrameworkName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            FrameworkName name = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]");
            // Make the request
            configClient.DeleteFramework(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFrameworkAsync</summary>
        public async Task DeleteFrameworkResourceNamesAsync()
        {
            // Snippet: DeleteFrameworkAsync(FrameworkName, CallSettings)
            // Additional: DeleteFrameworkAsync(FrameworkName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkName name = FrameworkName.FromOrganizationLocationFramework("[ORGANIZATION]", "[LOCATION]", "[FRAMEWORK]");
            // Make the request
            await configClient.DeleteFrameworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCloudControls</summary>
        public void ListCloudControlsRequestObject()
        {
            // Snippet: ListCloudControls(ListCloudControlsRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            ListCloudControlsRequest request = new ListCloudControlsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListCloudControlsResponse, CloudControl> response = configClient.ListCloudControls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudControl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlsAsync</summary>
        public async Task ListCloudControlsRequestObjectAsync()
        {
            // Snippet: ListCloudControlsAsync(ListCloudControlsRequest, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            ListCloudControlsRequest request = new ListCloudControlsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> response = configClient.ListCloudControlsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudControl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControls</summary>
        public void ListCloudControls()
        {
            // Snippet: ListCloudControls(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCloudControlsResponse, CloudControl> response = configClient.ListCloudControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudControl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlsAsync</summary>
        public async Task ListCloudControlsAsync()
        {
            // Snippet: ListCloudControlsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> response = configClient.ListCloudControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudControl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControls</summary>
        public void ListCloudControlsResourceNames()
        {
            // Snippet: ListCloudControls(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCloudControlsResponse, CloudControl> response = configClient.ListCloudControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudControl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudControlsAsync</summary>
        public async Task ListCloudControlsResourceNamesAsync()
        {
            // Snippet: ListCloudControlsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> response = configClient.ListCloudControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudControl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudControlsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudControl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudControl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudControl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCloudControl</summary>
        public void GetCloudControlRequestObject()
        {
            // Snippet: GetCloudControl(GetCloudControlRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            GetCloudControlRequest request = new GetCloudControlRequest
            {
                CloudControlName = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]"),
            };
            // Make the request
            CloudControl response = configClient.GetCloudControl(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlAsync</summary>
        public async Task GetCloudControlRequestObjectAsync()
        {
            // Snippet: GetCloudControlAsync(GetCloudControlRequest, CallSettings)
            // Additional: GetCloudControlAsync(GetCloudControlRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            GetCloudControlRequest request = new GetCloudControlRequest
            {
                CloudControlName = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]"),
            };
            // Make the request
            CloudControl response = await configClient.GetCloudControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControl</summary>
        public void GetCloudControl()
        {
            // Snippet: GetCloudControl(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cloudControls/[CLOUD_CONTROL]";
            // Make the request
            CloudControl response = configClient.GetCloudControl(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlAsync</summary>
        public async Task GetCloudControlAsync()
        {
            // Snippet: GetCloudControlAsync(string, CallSettings)
            // Additional: GetCloudControlAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cloudControls/[CLOUD_CONTROL]";
            // Make the request
            CloudControl response = await configClient.GetCloudControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControl</summary>
        public void GetCloudControlResourceNames()
        {
            // Snippet: GetCloudControl(CloudControlName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CloudControlName name = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]");
            // Make the request
            CloudControl response = configClient.GetCloudControl(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudControlAsync</summary>
        public async Task GetCloudControlResourceNamesAsync()
        {
            // Snippet: GetCloudControlAsync(CloudControlName, CallSettings)
            // Additional: GetCloudControlAsync(CloudControlName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CloudControlName name = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]");
            // Make the request
            CloudControl response = await configClient.GetCloudControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudControl</summary>
        public void CreateCloudControlRequestObject()
        {
            // Snippet: CreateCloudControl(CreateCloudControlRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CreateCloudControlRequest request = new CreateCloudControlRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                CloudControlId = "",
                CloudControl = new CloudControl(),
            };
            // Make the request
            CloudControl response = configClient.CreateCloudControl(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudControlAsync</summary>
        public async Task CreateCloudControlRequestObjectAsync()
        {
            // Snippet: CreateCloudControlAsync(CreateCloudControlRequest, CallSettings)
            // Additional: CreateCloudControlAsync(CreateCloudControlRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CreateCloudControlRequest request = new CreateCloudControlRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                CloudControlId = "",
                CloudControl = new CloudControl(),
            };
            // Make the request
            CloudControl response = await configClient.CreateCloudControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudControl</summary>
        public void CreateCloudControl()
        {
            // Snippet: CreateCloudControl(string, CloudControl, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            CloudControl cloudControl = new CloudControl();
            string cloudControlId = "";
            // Make the request
            CloudControl response = configClient.CreateCloudControl(parent, cloudControl, cloudControlId);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudControlAsync</summary>
        public async Task CreateCloudControlAsync()
        {
            // Snippet: CreateCloudControlAsync(string, CloudControl, string, CallSettings)
            // Additional: CreateCloudControlAsync(string, CloudControl, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            CloudControl cloudControl = new CloudControl();
            string cloudControlId = "";
            // Make the request
            CloudControl response = await configClient.CreateCloudControlAsync(parent, cloudControl, cloudControlId);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudControl</summary>
        public void CreateCloudControlResourceNames()
        {
            // Snippet: CreateCloudControl(OrganizationLocationName, CloudControl, string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            CloudControl cloudControl = new CloudControl();
            string cloudControlId = "";
            // Make the request
            CloudControl response = configClient.CreateCloudControl(parent, cloudControl, cloudControlId);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudControlAsync</summary>
        public async Task CreateCloudControlResourceNamesAsync()
        {
            // Snippet: CreateCloudControlAsync(OrganizationLocationName, CloudControl, string, CallSettings)
            // Additional: CreateCloudControlAsync(OrganizationLocationName, CloudControl, string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            CloudControl cloudControl = new CloudControl();
            string cloudControlId = "";
            // Make the request
            CloudControl response = await configClient.CreateCloudControlAsync(parent, cloudControl, cloudControlId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCloudControl</summary>
        public void UpdateCloudControlRequestObject()
        {
            // Snippet: UpdateCloudControl(UpdateCloudControlRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            UpdateCloudControlRequest request = new UpdateCloudControlRequest
            {
                UpdateMask = new FieldMask(),
                CloudControl = new CloudControl(),
            };
            // Make the request
            CloudControl response = configClient.UpdateCloudControl(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCloudControlAsync</summary>
        public async Task UpdateCloudControlRequestObjectAsync()
        {
            // Snippet: UpdateCloudControlAsync(UpdateCloudControlRequest, CallSettings)
            // Additional: UpdateCloudControlAsync(UpdateCloudControlRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCloudControlRequest request = new UpdateCloudControlRequest
            {
                UpdateMask = new FieldMask(),
                CloudControl = new CloudControl(),
            };
            // Make the request
            CloudControl response = await configClient.UpdateCloudControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCloudControl</summary>
        public void UpdateCloudControl()
        {
            // Snippet: UpdateCloudControl(CloudControl, FieldMask, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CloudControl cloudControl = new CloudControl();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CloudControl response = configClient.UpdateCloudControl(cloudControl, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCloudControlAsync</summary>
        public async Task UpdateCloudControlAsync()
        {
            // Snippet: UpdateCloudControlAsync(CloudControl, FieldMask, CallSettings)
            // Additional: UpdateCloudControlAsync(CloudControl, FieldMask, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CloudControl cloudControl = new CloudControl();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CloudControl response = await configClient.UpdateCloudControlAsync(cloudControl, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudControl</summary>
        public void DeleteCloudControlRequestObject()
        {
            // Snippet: DeleteCloudControl(DeleteCloudControlRequest, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeleteCloudControlRequest request = new DeleteCloudControlRequest
            {
                CloudControlName = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]"),
            };
            // Make the request
            configClient.DeleteCloudControl(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudControlAsync</summary>
        public async Task DeleteCloudControlRequestObjectAsync()
        {
            // Snippet: DeleteCloudControlAsync(DeleteCloudControlRequest, CallSettings)
            // Additional: DeleteCloudControlAsync(DeleteCloudControlRequest, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCloudControlRequest request = new DeleteCloudControlRequest
            {
                CloudControlName = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]"),
            };
            // Make the request
            await configClient.DeleteCloudControlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudControl</summary>
        public void DeleteCloudControl()
        {
            // Snippet: DeleteCloudControl(string, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cloudControls/[CLOUD_CONTROL]";
            // Make the request
            configClient.DeleteCloudControl(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudControlAsync</summary>
        public async Task DeleteCloudControlAsync()
        {
            // Snippet: DeleteCloudControlAsync(string, CallSettings)
            // Additional: DeleteCloudControlAsync(string, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cloudControls/[CLOUD_CONTROL]";
            // Make the request
            await configClient.DeleteCloudControlAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudControl</summary>
        public void DeleteCloudControlResourceNames()
        {
            // Snippet: DeleteCloudControl(CloudControlName, CallSettings)
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            CloudControlName name = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]");
            // Make the request
            configClient.DeleteCloudControl(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudControlAsync</summary>
        public async Task DeleteCloudControlResourceNamesAsync()
        {
            // Snippet: DeleteCloudControlAsync(CloudControlName, CallSettings)
            // Additional: DeleteCloudControlAsync(CloudControlName, CancellationToken)
            // Create client
            ConfigClient configClient = await ConfigClient.CreateAsync();
            // Initialize request argument(s)
            CloudControlName name = CloudControlName.FromOrganizationLocationCloudControl("[ORGANIZATION]", "[LOCATION]", "[CLOUD_CONTROL]");
            // Make the request
            await configClient.DeleteCloudControlAsync(name);
            // End snippet
        }
    }
}
